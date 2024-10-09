using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using src.Models;
using System;
using System.Diagnostics;
using System.Security.Cryptography;
using System.Text;

namespace src.Controllers
{
    public class HomeController : Controller
    {
        private readonly DatabaseContext _context;

        public HomeController(DatabaseContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string email, string senha)
        {
            string senhaHash = GerarHashSha256(senha);

            var usuario = _context.usuarios.FirstOrDefault(u => u.Email == email && u.Senha == senhaHash);

            if (usuario != null)
            {
                return View("Perfil");

            }

            ModelState.AddModelError(string.Empty, "Login inválido.");
            return View("Index");
        }

        [HttpPost]
        public IActionResult Cadastro(string nome, string email, string nomeEmpresa, string senha)
        {
            if (_context.usuarios.Any(u => u.Email == email))
            {
                // Email já registrado
                ModelState.AddModelError(string.Empty, "O e-mail já está registrado.");
                return View("Index");
            }

            string senhaHash = GerarHashSha256(senha);

            var novoUsuario = new Usuario
            {
                Nome = nome,
                Email = email,
                Senha = senhaHash
            };

            _context.usuarios.Add(novoUsuario);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }

        private string GerarHashSha256(string senha)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(senha));
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

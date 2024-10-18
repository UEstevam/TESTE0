using Microsoft.AspNetCore.Mvc;
using src.Models;
using System.Linq;

namespace src.Controllers
{
    public class PerfilController : Controller
    {
        private readonly DatabaseContext _context;

        public PerfilController(DatabaseContext context)
        {
            _context = context;
        }

        // Action para exibir o perfil do usuário
        public IActionResult Perfil(int id)
        {
            // Busca o usuário pelo ID
            var usuarioExistente = _context.usuarios.FirstOrDefault(u => u.Id == id);

            if (usuarioExistente == null)
            {
                return NotFound();
            }

            return View("Perfil", usuarioExistente);
        }

        // Ação para atualizar o perfil
        [HttpPost]
        public IActionResult AtualizarPerfil(int id, string nome, string email)
        {
            // Busca o usuário pelo ID
            var usuarioExistente = _context.usuarios.FirstOrDefault(u => u.Id == id);

            if (usuarioExistente == null)
            {
                return NotFound();
            }

            // Atualiza os dados do usuário
            usuarioExistente.Nome = nome;
            usuarioExistente.Email = email;

            // Salva as alterações no banco de dados
            _context.usuarios.Update(usuarioExistente);
            _context.SaveChanges();

            // Redireciona para o perfil atualizado, passando o ID
            return RedirectToAction("Perfil", new {id = usuarioExistente.Id});
        }

        // Action para deletar o perfil do usuário
        [HttpPost]
        public IActionResult DeletarPerfil(int id)
        {
            // Busca o usuário pelo ID
            var usuarioExistente = _context.usuarios.FirstOrDefault(u => u.Id == id);

            if (usuarioExistente == null)
            {
                return NotFound();
            }

            // Remove o usuário do banco de dados
            _context.usuarios.Remove(usuarioExistente);
            _context.SaveChanges();

            // Redireciona para a página inicial ou página de sucesso após a deleção
            return RedirectToAction("Index", "Home");
        }
    }
}

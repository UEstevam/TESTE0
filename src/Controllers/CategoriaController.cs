using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.BlazorIdentity.Pages.Manage;
using src.Models;
using System.Linq;

namespace src.Controllers
{
    public class CategoriaController : Controller
    {
        private readonly DatabaseContext _context;

        // Construtor com injeção do contexto do banco de dados
        public CategoriaController(DatabaseContext context)
        {
            _context = context;
        }

        // Ação para listar todos os fornecedores
        public IActionResult Index()
        {
            var userId = User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier)?.Value;
            if (userId == null)
            {
                return View();

            }

            // Converte o userId para int de maneira segura
            int userIdParsed;
            if (!int.TryParse(userId, out userIdParsed))
            {
                // Se a conversão falhar, também podemos redirecionar ou tratar o erro
                return View("Error");
            }

            // Busca as categorias associadas ao usuário autenticado
            var categorias = _context.Categoria
                                     .Where(c => c.IdUser == userIdParsed)
                                     .ToList();

            return View(categorias);
        }

        // Renderiza o formulário para editar um fornecedor
        public IActionResult Editar(int id)
        {
            var fornecedor = _context.Fornecedor.FirstOrDefault(f => f.Id == id);
            if (fornecedor == null)
            {
                return NotFound();
            }
            return View(fornecedor);
        }

        // Ação para editar um fornecedor
        [HttpPost]
        public IActionResult EditarFornecedor(Fornecedor fornecedor)
        {
            // Busca o usuário pelo ID
            var fornecedorExistente = _context.Fornecedor.FirstOrDefault(u => u.Id == fornecedor.Id);

            if (fornecedorExistente == null)
            {
                return NotFound();
            }

            // Atualiza os dados do usuário
            fornecedorExistente.Id = fornecedor.Id;
            fornecedorExistente.Nome = fornecedor.Nome;
            fornecedorExistente.Email = fornecedor.Email;
            fornecedorExistente.Telefone = fornecedor.Telefone;
            fornecedorExistente.EnderecoRua = fornecedor.EnderecoRua;
            fornecedorExistente.EnderecoNumero = fornecedor.EnderecoNumero;
            fornecedorExistente.EnderecoCEP = fornecedor.EnderecoCEP;
            fornecedorExistente.EnderecoUF = fornecedor.EnderecoUF;

            // Salva as alterações no banco de dados
            _context.Fornecedor.Update(fornecedorExistente);
            _context.SaveChanges();

            // Redireciona para o fornecedor atualizado, passando o ID
            return RedirectToAction("Index");
        }

        // Renderiza o formulário para adicionar um fornecedor
        public IActionResult Adicionar()
        {
            return View();
        }

        // Ação adicionar um novo fornecedor
        [HttpPost]
        public IActionResult AdicionarFornecedor(string nome, string email, string telefone, string EnderecoRua, string EnderecoNumero, string EnderecoCEP, string EnderecoUF)
        {

            var userId = User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier)?.Value;
            if (userId != null)
            {
                var novoFornecedor = new Fornecedor
                {
                    IdUser = int.Parse(userId),
                    Nome = nome,
                    Email = email,
                    Telefone = telefone,
                    EnderecoRua = EnderecoRua,
                    EnderecoNumero = EnderecoNumero,
                    EnderecoCEP = EnderecoCEP,
                    EnderecoUF = EnderecoUF
                };

                _context.Fornecedor.Add(novoFornecedor);
                _context.SaveChanges();

                return RedirectToAction("Index");
            }

            return NotFound();
        }

        // Ação para deletar um fornecedor
        public IActionResult Deletar(int id)
        {
            var fornecedor = _context.Fornecedor.FirstOrDefault(f => f.Id == id);
            if (fornecedor == null)
            {
                return NotFound();
            }

            // Remove o usuário do banco de dados
            _context.Fornecedor.Remove(fornecedor);
            _context.SaveChanges();

            // Redireciona para a página inicial ou página de sucesso após a deleção
            return RedirectToAction("Index");

        }
    }
}

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

           var categorias = _context.Categoria.Where(f => f.IdUser == int.Parse(userId)).ToList(); 

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

        // Renderiza o formulário para adicionar uma categoria
        public IActionResult Adicionar()
        {
            return View();
        }

        // Ação adicionar um nova Categoria
        [HttpPost]
        public IActionResult AdicionarCategoria(string Nome, string Descricao)
        {

            var userId = User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier)?.Value;
            if (userId != null)
            {
                var novaCategoria = new Categoria
                {
                    IdUser = int.Parse(userId),
                    Nome = Nome,
                    Descricao = Descricao,
                    CriadoEm = DateTime.Now
        
                };

                _context.Categoria.Add(novaCategoria);
                _context.SaveChanges();

                return RedirectToAction("Index");
            }

            return NotFound();
        }

        // Ação para deletar uma categoria
        public IActionResult Deletar(int id)
        {
            var categoria = _context.Categoria.FirstOrDefault(f => f.Id == id);
            if (categoria == null)
            {
                return NotFound();
            }

            // Remove a categoria do banco de dados
            _context.Categoria.Remove(categoria);
            _context.SaveChanges();

            // Redireciona para a página inicial
            return RedirectToAction("Index");

        }
    }
}

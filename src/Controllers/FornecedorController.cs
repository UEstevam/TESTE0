using Microsoft.AspNetCore.Mvc;
using src.Models;
using System.Linq;

namespace src.Controllers
{
    public class FornecedorController : Controller
    {
        private readonly DatabaseContext _context;

        // Construtor com injeção do contexto do banco de dados
        public FornecedorController(DatabaseContext context)
        {
            _context = context;
        }

        // Ação para listar todos os fornecedores
        public IActionResult Index()
        {
            // Busca a lista de fornecedores diretamente do banco de dados
            var fornecedores = _context.Fornecedor.ToList();

            // Passa a lista de fornecedores para a view
            return View(fornecedores);
        }

        // Ação para exibir os detalhes de um fornecedor
        public IActionResult Details(int id)
        {
            var fornecedor = _context.Fornecedor.FirstOrDefault(f => f.Id == id);
            if (fornecedor == null)
            {
                return NotFound();
            }
            return View(fornecedor);
        }

        // Ação para editar um fornecedor
        public IActionResult Edit(int id)
        {
            var fornecedor = _context.Fornecedor.FirstOrDefault(f => f.Id == id);
            if (fornecedor == null)
            {
                return NotFound();
            }
            return View(fornecedor);
        }

        // Ação para deletar um fornecedor
        public IActionResult Delete(int id)
        {
            var fornecedor = _context.Fornecedor.FirstOrDefault(f => f.Id == id);
            if (fornecedor == null)
            {
                return NotFound();
            }
            return View(fornecedor);
        }
    }
}

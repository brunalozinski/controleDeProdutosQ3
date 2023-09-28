using ControleProdutosQ3.Models;
using ControleProdutosQ3.Repository;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace ControleProdutosQ3.Controllers
{
    public class ClienteController : Controller
    {
        private readonly IClienteRepositorio _clienteRepositorio;

        public ClienteController(IClienteRepositorio clienteRepositorio)
        {
            _clienteRepositorio = clienteRepositorio;
        }

        public async Task<IActionResult> Index()
        {
            List<ClienteModel> clientes = await _clienteRepositorio.BuscaTodos();
            ViewBag.Produtos = "outro objeto";
            return await Task.FromResult(View(clientes));
        }

        public async Task<IActionResult> Criar()
        {
            return await Task.FromResult(View());
        }

        [HttpPost]
        public async Task<IActionResult> Criar (ClienteModel cliente)
        {
            List<ValidationResult> results = new List<ValidationResult>();
            ValidationContext context = new ValidationContext(cliente);

            bool isValid = Validator.TryValidateObject(cliente, context, results, true);
            if (!isValid)
            {
                foreach (ValidationResult validationResult in results) 
                {
                    return await Task.FromResult(View(cliente));
                }  
            }
            cliente.Status = 1;

            await _clienteRepositorio.Adicionar(cliente);
            return await Task.FromResult(RedirectToAction("Index"));
        }

    }
}

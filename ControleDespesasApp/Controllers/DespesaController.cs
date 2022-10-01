using ControleDespesasApp.Models;
using ControleDespesasApp.Services;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ControleDespesasApp.Controllers
{
    public class DespesaController : Controller
    {
        private readonly ILogger<DespesaController> _logger;
        private readonly IDespesaService _despesaService;

        public DespesaController(ILogger<DespesaController> logger, IDespesaService despesaService)
        {
            _logger = logger;
            _despesaService=despesaService;
        }

        public IActionResult Index()
        {
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
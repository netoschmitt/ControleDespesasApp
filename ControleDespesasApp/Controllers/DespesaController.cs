using ControleDespesasApp.DTOs;
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

        public async Task<IActionResult> Index()
        {
            var listDespesaDto = new ListDespesaDTO();

            listDespesaDto.Items = await _despesaService.FindBy(listDespesaDto.DataInicio, listDespesaDto.DataFim);

            return View(listDespesaDto);
        }


        [HttpPost]
        public async Task<IActionResult> Index(ListDespesaDTO listDespesaDto)
        {
            try
            {
                listDespesaDto.Items = await _despesaService.FindBy(listDespesaDto.DataInicio, listDespesaDto.DataFim);

                return View(listDespesaDto);
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("CustomError", ex.Message);
                return View(listDespesaDto);
            }
            
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
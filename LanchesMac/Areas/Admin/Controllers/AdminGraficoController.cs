using LanchesMac.Areas.Admin.Servicos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace LanchesMac.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class AdminGraficoController : Controller
    {
        private readonly GraficoVendasService _graficoVendasService;

        public AdminGraficoController(GraficoVendasService graficoVendasService)
        {
            _graficoVendasService = graficoVendasService ?? throw
                new ArgumentNullException(nameof(graficoVendasService));
        }

        public JsonResult VendasLanches(int dias)
        {
            var lanchesVendasTotais = _graficoVendasService.GetVendasLanches(dias);
            return Json(lanchesVendasTotais);
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult VendaMensal()
        {
            return View();
        }

        [HttpGet]
        public IActionResult VendaSemanal()
        {
            return View();
        }
    }
}

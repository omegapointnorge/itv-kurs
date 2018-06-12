using Microsoft.AspNetCore.Mvc;
using WineApi.Wines;

namespace WineApi.Controllers
{
    [Route("api/[controller]")]
    public class WineController : Controller
    {
        public VinmonopoletRepository _wineRepo;

        public WineController(VinmonopoletRepository wineRepo)
        {
            _wineRepo = wineRepo;
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var wineInfo = _wineRepo.GetWineInfo(id);
            // return wineInfo != null ? Ok(wineInfo) : (IActionResult)NotFound();
            return wineInfo != null ? Ok(wineInfo) : throw new System.Exception();
        }
    }
}
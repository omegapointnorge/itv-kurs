using System;
using System.Threading;
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

            var random = new Random();
            var value = random.Next(0,10);
            
            switch(value)
            {
                case int v when v < 3:
                    throw new Exception();
                case int v when v >= 3 && v < 5:
                    Thread.Sleep(2000);
                    break;
                default:
                    break;
            }
            
            return wineInfo != null ? Ok(wineInfo) : (IActionResult)NotFound();
        }
    }
}
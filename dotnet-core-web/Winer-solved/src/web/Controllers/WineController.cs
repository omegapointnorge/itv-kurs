using Microsoft.AspNetCore.Mvc;

namespace web.Controllers
{
    [Route("api/[controller]")]
    public class WineController : Controller
    {
        public IWineInfoRepository _wineRepo;

        public WineController(IWineInfoRepository wineRepo)
        {
            _wineRepo = wineRepo;
        }


        [HttpGet("{id}")]
        public WineInfo Get(int id)
        {
            return _wineRepo.GetWineInfo(id);
        }
    }
}
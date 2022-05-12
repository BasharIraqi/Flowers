using Microsoft.AspNetCore.Mvc;

namespace Flowers.Controllers
{
    [ApiController]
    [Route("flowers/[action]")]
    public class FlowersController :ControllerBase
    {
        [HttpGet]
        public string Aster()
        {
            return "Aster";
        }
        [HttpGet]
        public string Azalea()
        {
            return "Azalea";
        }
        [HttpGet]
        public string Buttercup()
        {
            return "Buttercup";
        }
        [HttpGet]
        public string Crocus()
        {
            return "Crocus";
        }
    }
    
}

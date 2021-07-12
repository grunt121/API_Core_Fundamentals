using Microsoft.AspNetCore.Mvc;

namespace CoreCodeCamp.Controllers
{
    [Route("api/camps")]
    public class CampsControllers: ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new {Moniker = "ATL2018", Name = "Atlanta Code Camp"});
        }
    }
}

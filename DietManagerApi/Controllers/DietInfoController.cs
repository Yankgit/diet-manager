using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DietManagerCore.Behaviours;
using DietManagerCore.Requests;
using DietManagerCore.Responses;

namespace DietManagerApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DietInfoController : ControllerBase
    {

        [HttpGet]
        public IActionResult GetBaseDietInfo([FromQuery] BaseLifeStyleInfoRequest request)
        {
            BaseLifeStyleInfoBehaviour behaviour = new BaseLifeStyleInfoBehaviour();

            BaseLifeStyleInfoResponse response = behaviour.TriggerAction(request);

            if (response == null)
                return NotFound();

            return Ok(response);
        }
    }
}

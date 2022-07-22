using AreaCheck.Model;
using AreaCheck.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace AreaCheck.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AreaController : ControllerBase
    {
        private readonly IAreaService _areaService;

        public AreaController(IAreaService areaService)
        {
            _areaService = areaService;
        }

        [HttpPost]
        public IActionResult CalculateArea(AreaModel model)
        {
            var resut = _areaService.CalculateArea(model);
            return Ok(resut);
        }
    }
}

using FarmManagementApp.Data;
using FarmManagementApp.Models;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;

namespace FarmManagementApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FarmsController : ControllerBase
    {
        private readonly FarmRepository _farmRepository;

        public FarmsController(FarmRepository farmRepository)
        {
            _farmRepository = farmRepository;
        }

        [HttpGet]
        public IEnumerable<Farm> Get()
        {
            return _farmRepository.GetFarms();
        }
    }

}

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Application.Interfaces;
using Application.Services;
using Domain.Models.Garments;

namespace GarmentEfficienyApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GarmentController : ControllerBase
    {
        private readonly IGarmentService _garmentService;
        public GarmentController(IGarmentService garmentService)
        {
            _garmentService = garmentService;
        }

        [HttpPost]
        public ActionResult<Garment> Add([FromBody] Garment garment)
        {
            try
            {
                _garmentService.Add(garment);
                return NoContent();
            }
            catch (Exception) 
            {
                return StatusCode(500, "Internal server error");
            } 
        }
    }
}




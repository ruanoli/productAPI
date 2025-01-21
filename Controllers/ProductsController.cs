using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductAPI.Services.Models;

namespace ProductAPI.Services.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {

        [HttpGet("GetAllProduct")]
        public IActionResult GetAll()
        {
            //TODO

            return Ok();
        }

        [HttpPost("RegisterProduct")]
        public IActionResult Register(ProductPostRequest model)
        {
            //TODO

            return Ok();
        }

        [HttpPut("UpdateProduct")]
        public IActionResult Update(ProductPostRequest model)
        {
            //TODO

            return Ok();
        }

        [HttpDelete("DeleteProduct")]
        public IActionResult Delete(ProductPostRequest model)
        {
            //TODO

            return Ok();
        }
    }
}

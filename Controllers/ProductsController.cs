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
        [ProducesResponseType(typeof(List<ProductGetModel>), 200)] 
        public IActionResult GetAll()
        {
            //TODO

            return Ok(new List<ProductGetModel>());
        }

        [HttpGet("GetProductById/{productId}")]
        [ProducesResponseType(typeof(ProductGetModel), 200)] 
        public IActionResult GetById(Guid productId)
        {
            //TODO

            return Ok();
        }

        [HttpPost("RegisterProduct")]
        [ProducesResponseType(typeof(ProductResponseModel), 201)] 
        [ProducesResponseType(typeof(ProductResponseModel), 500)] 
        [ProducesResponseType(typeof(ProductResponseModel), 400)] 
        public IActionResult Register(ProductPostRequestModel model)
        {
            //TODO

            try
            {
                var response = new ProductResponseModel()
                {
                    StatusCode = 201,
                    Message = "Produto Cadastrado",
                    Product = new ProductGetModel()
                };
                
                return StatusCode(201, response);
            }
            catch (Exception)
            {
                var response = new ProductResponseModel()
                {
                    StatusCode = 500,
                    Message = "Erro Interno"
                };

                return StatusCode(500, response);
            }



        }

        [HttpPut("UpdateProduct")]
        [ProducesResponseType(typeof(ProductResponseModel), 200)] 
        [ProducesResponseType(typeof(ProductResponseModel), 500)] 
        [ProducesResponseType(typeof(ProductResponseModel), 400)] 
        public IActionResult Update(ProductPostRequestModel model)
        {
            //TODO

            var response = new ProductResponseModel()
            {
                StatusCode = 200,
                Message = "Produto Atualizado com sucesso.",
                Product = new ProductGetModel()
            };

            return StatusCode(200, response);
        }

        [HttpDelete("DeleteProduct/{productId}")]
        [ProducesResponseType(typeof(ProductResponseModel), 200)] 
        [ProducesResponseType(typeof(ProductResponseModel), 500)] 
        [ProducesResponseType(typeof(ProductResponseModel), 400)] 
        public IActionResult Delete(Guid productId)
        {
            //TODO

            var response = new ProductResponseModel()
            {
                StatusCode = 200,
                Message = "Produto Atualizado com sucesso.",
                Product = new ProductGetModel()
            };

            return StatusCode(200, response);
        }
    }
}

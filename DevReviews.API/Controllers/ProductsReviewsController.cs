using DevReviews.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace DevReviews.API.Controllers
{
    [ApiController]
    [Route("api/products/{productId}/productsreviews")]
    public class ProductsReviewsController : ControllerBase
    {
        [HttpGet("{id}")]
         public IActionResult GetById(int productId, int id) {
             return Ok();
         }

         [HttpPost()]
         public IActionResult Post(int productId, AddProductReviewInputModel model) {
             return CreatedAtAction(nameof(GetById), new {id = 1, productId = 2}, model);
         }
    }
}
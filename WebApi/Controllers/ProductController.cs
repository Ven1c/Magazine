using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Magazine.Domain.Services;
using Magazine.Domain;
using Magazine.Domain.Commands;
namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService productService;

        public ProductController(IProductService _productservice)
        {
            _productservice = productService;
        }

        [HttpPost]
        public async Task<ActionResult<Product>> Add([FromBody] AddCommand addcommand)
        {
            var prod = productService.Add(addcommand);
            return Ok(prod);
        }

    }
}

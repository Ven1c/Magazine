using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Magazine.Domain.Services;
using Magazine.Domain;
using Magazine.Domain.Commands;
namespace WebApi.Controllers
{
    [Route("api/[controller]/")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productservice)
        {
            _productService = productservice;
        }

        [HttpPost("add")]
        public async Task<ActionResult<Product>> Add([FromBody] AddCommand addcommand)
        {
            var prod = _productService.Add(addcommand);
            return Ok(prod);
        }

        [HttpPost("delete")]
        public async Task<ActionResult<Product>> Remove([FromBody] Product product)
        {
            var prod = _productService.Remove(product);
            return Ok(prod);

        }
        [HttpPost("edit")]
        public async Task<ActionResult<Product>> Edit([FromBody] Product product)
        {
            var prod = _productService.Edit(product);
            return Ok(prod);

        }
        [HttpGet]
        public async Task<ActionResult<Product>> Search([FromRoute] string name)
        {
            var prod = _productService.Search(name);
            return Ok(prod);
        }

    }
}

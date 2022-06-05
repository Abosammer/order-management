using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Managem.Models;
using Managem.Models.SyncfusionViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Managem.Controllers.api
{
    [Authorize]
    [Produces("application/json")]
    [Route("api/Product")]
    public class ProductController : Controller
    {
        private readonly IRpotStory<Product> Pro;

        public ProductController(IRpotStory<Product> _Product)

        {
            Pro = _Product;

        }
        // GET: api/Product
        //[HttpGet]
        public ActionResult GetProduct()
        {

            IList<Product> Product = Pro.List();
            int Count = Product.Count();
            return Ok(new { Product, Count });
        }



        [HttpPost("[action]")]
        public IActionResult Insert([FromBody]CrudViewModel<Product> payload)
        {
            Product Product = payload.value;
            Pro.Add(Product);
             
            return Ok(Product);
        }

        [HttpPost("[action]")]
        public IActionResult Update([FromBody]CrudViewModel<Product> payload)
        {
            Product Product = payload.value;
            Pro.Update(Product.Id, Product);
            return Ok(Product);
        }

        [HttpPost("[action]")]
        public IActionResult Remove([FromBody]CrudViewModel<Product> payload)
        {
            Product bill = Pro.Find((int)payload.key);
                
            Pro.Delete((int)payload.key);
            return Ok(bill);

        }
    }
}
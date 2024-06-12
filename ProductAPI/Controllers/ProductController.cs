using Data.Models.Entitys;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductAPI.Models;
using Services;

namespace ProductAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        IProductBL _prodRepo;

        public ProductController(IProductBL productBL)
        {
            _prodRepo = productBL;
        }

        [HttpGet]
        public IActionResult GetAllProduct()
        {
            List<ProductModel> products = _prodRepo.GetAll()
                .Select(p =>
            new ProductModel() { Id = p.Id, Name = p.Name, Price = p.Price })
                .ToList();
            return Ok(products);
        }


        [HttpGet("{id}")]

        public IActionResult GetProduct(int id)
        {
            try
            {
                if (id <= 0)
                {
                    return BadRequest();
                }

                var product = _prodRepo.GetById(id);

                if (product != null)
                {
                    ProductModel productModel = new ProductModel()
                    {
                        Id = product.Id,
                        Name = product.Name,
                        Price = product.Price
                    };

                    return Ok(productModel);
                }
                return NotFound();
            }
            catch (Exception ex) 
            {

                return BadRequest(ex.Message);
            }
        }


        [HttpPost]
        public IActionResult Create(ProductModel product)
        {
            try
            {
                if (product != null)
                {
                    Product p = new Product()
                    {
                        Id = product.Id,
                        Name = product.Name,
                        Price = product.Price
                    };

                    bool result = _prodRepo.Create(p);

                    if (result)
                    {
                        return Ok();
                    }
                    else
                    {
                        return BadRequest();
                    }
                }

                return BadRequest();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}

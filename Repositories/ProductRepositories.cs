using Data.Models.Entitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class ProductRepositories : IProductRepositories
    {
        ProductDBContext _db;
        public ProductRepositories(ProductDBContext db)
        {
            _db = db;
        }
        public List<Product> GetAll()
        {
            return _db.Products.ToList();
        }

        public Product GetById(int id)
        {
            var products = _db.Products.Find(id);
            return products;
        }
        public bool Create(Product product)
        {
            if (product != null)
            {
                _db.Products.Add(product);
                return true;
            }
            return false;
        }

        public bool Delete(int id)
        {
            var products = _db.Products.Find(id);
            _db.Products.Remove(products);
            _db.SaveChanges();

            return true;
        }



        public bool Update(Product product)
        {
            try
            {
                Product DbProduct = _db.Products.Find(product.Id);
                if (DbProduct != null)
                {
                    DbProduct.Name = product.Name;
                    DbProduct.Price = product.Price;

                    _db.SaveChanges();


                    return true;
                }
                return false;
            }
            catch
            {
                return false;
            }
        }
    }
}

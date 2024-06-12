using Data.Models.Entitys;
using Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class ProductBL : IProductBL
    {
        IProductRepositories _prodRepo;

        public ProductBL(IProductRepositories prod)
        {
            _prodRepo = prod;
        }

        public bool Create(Product product)
        {
            return _prodRepo.Create(product);
        }

        public bool Delete(int id)
        {
            return _prodRepo.Delete(id);
        }

        public List<Product> GetAll()
        {
            return _prodRepo.GetAll();
        }

        public Product GetById(int id)
        {
            return _prodRepo.GetById(id);
        }

        public bool Update(Product product)
        {
            return _prodRepo.Update(product);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Models.Entitys;

namespace Repositories
{
    public interface IProductRepositories
    {
        List<Product> GetAll();
        Product GetById(int id);
        bool Create(Product product);
        bool Update(Product product);
        bool Delete(int id);
    }
}

using Data.Models.Entitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public interface IProductBL
    {
        List<Product> GetAll();
        Product GetById(int id);
        bool Create(Product product);
        bool Update(Product product);
        bool Delete(int id);
    }
}

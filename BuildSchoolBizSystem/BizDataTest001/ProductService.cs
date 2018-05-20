using BizDataLibrary.Models;
using BizDataLibrary.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BizDataTest001
{
    class ProductService
    {
        public void Create(Product entity)
        {
            BizModel context = new BizModel();
            BizRepository<Product> repository = new BizRepository<Product>(context);
            repository.Create(entity);
            context.SaveChanges();
        }

        public void Delete(Product entity)
        {
            BizModel context = new BizModel();
            BizRepository<Product> repository = new BizRepository<Product>(context);
            repository.Delete(entity);
            context.SaveChanges();
        }

        public List<Product> GetAll()
        {
            BizModel context = new BizModel();
            BizRepository<Product> repository = new BizRepository<Product>(context);
            var result = repository.GetAll().OrderBy((x) => x.PartNo).ToList();
            return result;
        }

        public Product GetByParNo(string partNo)
        {
            BizModel context = new BizModel();
            BizRepository<Product> repository = new BizRepository<Product>(context);
            var result = repository.GetAll().FirstOrDefault((x) => x.PartNo == partNo);
            return result;
        }

    }
}

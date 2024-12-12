using MyApiProject.DataAccess.Abstract;
using MyApiProject.DataAccess.Context;
using MyApiProject.DataAccess.Repositories;
using MyApiProject.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApiProject.DataAccess.EntityFramework
{
    public class EfProductDal : GenericRepository<Product>,IProductDal
    {
        private readonly ApiContext _context;
        public EfProductDal(ApiContext context) : base(context)
        {
            _context = context;
        }

        public int GetProductCount()
        {
            return _context.Products.Count();
        }
    }
}

using MyApiProject.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApiProjec.Business.Abstract
{
    public interface IProductService:IGenericService<Product>
    {
        public int TGetProductCount();
    }
}

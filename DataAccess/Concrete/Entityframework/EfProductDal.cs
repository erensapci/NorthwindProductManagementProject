using Core.DataAccess.Concrete.EntityFramework;
using DataAccess. Abstract;
using DataAccess.Concrete.Entityframework.Contexts;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.Entityframework
{
    public class EfProductDal : EfEntityRepositoryBase<Product,NorthwindContext>, IProductDal
    {
      
    }
}

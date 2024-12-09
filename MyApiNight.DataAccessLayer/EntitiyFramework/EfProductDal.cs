using MyApiNight.DataAccessLayer.Abstract;
using MyApiNight.DataAccessLayer.Context;
using MyApiNight.DataAccessLayer.Repositories;
using MyApiNight.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApiNight.DataAccessLayer.EntitiyFramework
{
    public class EfProductDal : GenericRepositories<Product>, IProductDal
    {
        public EfProductDal(ApiContext context) : base(context)
        {
        }
    }
}

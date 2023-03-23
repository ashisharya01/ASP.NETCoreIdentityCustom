using Microsoft.Extensions.Logging;
using ASP.NETCoreIdentityCustom.Core;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ASP.NETCoreIdentityCustom.Repository;
using ASP.NETCoreIdentityCustom.Interfaces;
using ASP.NETCoreIdentityCustom;

namespace PEI_ETL.Infrastrucure.Repository
{

    public class ProductRepository : GenericRepository<ProductDetails>, IProductRepository
    {
        public ProductRepository(ETLDbContext context, ILogger logger) : base(context, logger)
        {

        }
    }
}

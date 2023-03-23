using Microsoft.Extensions.Logging;
using ASP.NETCoreIdentityCustom.Core;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ASP.NETCoreIdentityCustom.Repository;
using ASP.NETCoreIdentityCustom;
using ASP.NETCoreIdentityCustom.Interfaces;

namespace PEI_ETL.Infrastrucure.Repository
{

    public class ProjectRepository : GenericRepository<Project>, IProjectRepository
    {
        public ProjectRepository(ETLDbContext context, ILogger logger) : base(context, logger)
        {
        }
    }
}

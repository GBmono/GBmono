using Gbmono.Models.Infrastructure;
using Gbmono.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;


namespace Gbmono.Web.App_Start
{
    public class CdManagerController : ApiController
    {
        private readonly RepositoryManager<CdInstance> _repositoryManager;
        private readonly RepositoryManager<CdInstanceProperty> _CdrepositoryManager;



        public CdManagerController()
        {



        }


        public IEnumerable<CdInstance> GetAll()
        {


            return _repositoryManager.Repository.Table.ToList();
        }

    }
}

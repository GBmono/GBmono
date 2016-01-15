using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Gbmono.Models;
using Gbmono.Models.Infrastructure;

namespace Gbmono.WebAPI.Controllers
{
    [RoutePrefix("api/Retailers")]
    public class RetailersController : ApiController
    {
        private readonly RepositoryManager _repositoryManager;

        #region ctor
        public RetailersController()
        {
            _repositoryManager = new RepositoryManager();
        }
        #endregion

        public IEnumerable<Retailer> GetAll()
        {
            return _repositoryManager.RetailerRepository.Table.OrderBy(m => m.Name).ToList();
        }

        public Retailer GetById(int id)
        {
            // load retailer entity with all the related shops
            return _repositoryManager.RetailerRepository
                                     .Table
                                     .Include(m => m.Shops)
                                     .SingleOrDefault(m => m.RetailerId == id);
        }

        [HttpPost]
        public IHttpActionResult Create([FromBody] Retailer retailer)
        {
            // todo: validation
            // same name check

            _repositoryManager.RetailerRepository.Create(retailer);
            _repositoryManager.ManufacturerRepository.Save();

            return Ok();
        }

        [HttpPut]
        public IHttpActionResult Update(int id, [FromBody] Retailer retailer)
        {
            _repositoryManager.RetailerRepository.Delete(retailer);
            _repositoryManager.RetailerRepository.Save();

            return Ok();
        }

        [HttpDelete]
        public IHttpActionResult Delete(int id)
        {
            // todo: delete foreign records

            var entityToDel = _repositoryManager.RetailerRepository.Get(id);

            // dele
            _repositoryManager.RetailerRepository.Delete(entityToDel);
            _repositoryManager.RetailerRepository.Save();

            return Ok();
        }
    }
}

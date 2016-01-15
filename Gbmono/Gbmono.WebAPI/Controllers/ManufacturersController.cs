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
    [RoutePrefix("api/Manufacturers")]
    public class ManufacturersController : ApiController
    {
        private readonly RepositoryManager _repositoryManager;

        #region ctor
        public ManufacturersController()
        {
            _repositoryManager = new RepositoryManager();
        }
        #endregion

        public IEnumerable<Manufacturer> GetAll()
        {
            return _repositoryManager.ManufacturerRepository.Table.OrderBy(m => m.Name).ToList();
        }

        public Manufacturer GetById(int id)
        {
            // return _repositoryManager.ManufacturerRepository.Get(id);

            // load manufacturer entity with all the related brands data
            return _repositoryManager.ManufacturerRepository
                                     .Table
                                     .Include(m => m.Brands)
                                     .SingleOrDefault(m => m.ManufacturerId == id);
        }

        [HttpPost]
        public IHttpActionResult Create([FromBody] Manufacturer manufacturer)
        {
            // todo: validation
            // same name check

            _repositoryManager.ManufacturerRepository.Create(manufacturer);
            _repositoryManager.ManufacturerRepository.Save();

            return Ok();
        }

        [HttpPut]
        public IHttpActionResult Update(int id, [FromBody] Manufacturer manufacturer)
        {
            _repositoryManager.ManufacturerRepository.Delete(manufacturer);
            _repositoryManager.ManufacturerRepository.Save();

            return Ok();
        }

        [HttpDelete]
        public IHttpActionResult Delete(int id)
        {
            // todo: delete foreign records

            var entityToDel = _repositoryManager.ManufacturerRepository.Get(id);

            // dele
            _repositoryManager.ManufacturerRepository.Delete(entityToDel);
            _repositoryManager.ManufacturerRepository.Save();

            return Ok();
        }
    }
}

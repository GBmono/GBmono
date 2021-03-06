﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Gbmono.Models;
using Gbmono.Models.Infrastructure;


namespace Gbmono.WebAPI.Controllers
{
    [RoutePrefix("api/Brands")]
    public class BrandsController : ApiController
    {
        private readonly RepositoryManager _repositoryManager;

        #region ctor
        public BrandsController()
        {
            _repositoryManager = new RepositoryManager();
        }
        #endregion

        public IEnumerable<Brand> GetAll()
        {
            return _repositoryManager.BrandRepository.Table.OrderBy(m => m.Name).ToList();
        }

        [HttpGet]
        public Brand GetById(int id)
        {
            return _repositoryManager.BrandRepository.Get(id);
        }

        [HttpPost]
        public IHttpActionResult Create([FromBody] Brand brand)
        {
            // todo: validation

            _repositoryManager.BrandRepository.Create(brand);
            _repositoryManager.BrandRepository.Save();

            return Ok();
        }

        [HttpPut]
        public IHttpActionResult Update(int id, [FromBody] Brand brand)
        {
            _repositoryManager.BrandRepository.Update(brand);
            _repositoryManager.BrandRepository.Save();

            return Ok();
        }

        [HttpDelete]
        public IHttpActionResult Delete(int id)
        {
            // todo delete related records

            var entityToDel = _repositoryManager.BrandRepository.Get(id);

            _repositoryManager.BrandRepository.Delete(entityToDel);
            _repositoryManager.BrandRepository.Save();

            return Ok();
        }
    }
}

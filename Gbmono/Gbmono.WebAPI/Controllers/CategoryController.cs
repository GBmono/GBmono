using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using Gbmono.Models;
using Gbmono.Models.Infrastructure;
using Gbmono.WebAPI.Repository;

namespace Gbmono.WebAPI.Controllers
{
    public class CategoryController : ApiController
    {
        private readonly CategoryService _categoryService;

        #region ctor
        public CategoryController()
        {
            _categoryService = new CategoryService();
        }
        #endregion

        [HttpGet]
        public async Task<IHttpActionResult> GetAllCategory()
        {
            var result=await _categoryService.GetAllCagegory();

            return Ok(result);
        }
    }
}

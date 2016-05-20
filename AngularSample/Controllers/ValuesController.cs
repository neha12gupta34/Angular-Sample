using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using AngularSample.Models;
using System.Web.Http;

namespace AngularSample.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }

        [System.Web.Http.HttpGet]
        public IEnumerable<Category> Category()
        {
            var category = new List<Category>();
            category.Add(new Category { Id = 1, Name = "Maruti" });
            category.Add(new Category { Id = 1, Name = "hyundai" });
            category.Add(new Category { Id = 1, Name = "volkswagen" });
            return category;
        }

        [System.Web.Http.HttpGet]
        public HttpResponseMessage GetCategoryList()
        {
            var category = new List<Category>();
            category.Add(new Category { Id = 1, Name = "Maruti" });
            category.Add(new Category { Id = 1, Name = "hyundai" });
            category.Add(new Category { Id = 1, Name = "volkswagen" });
            return Request.CreateResponse(HttpStatusCode.Accepted, category, Configuration.Formatters.JsonFormatter);
        }
    }
}
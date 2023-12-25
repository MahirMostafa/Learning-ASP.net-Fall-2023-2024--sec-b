using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AppLayerApi.Controllers
{
    public class CatagoriesController : ApiController
    {
        [HttpGet]
        [Route("api/catagory/{id}")]
        public HttpResponseMessage GetCatagory(int id)
        {
            try
            {
                //var data = PersonService.Getname(id);
                //return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex);
            }
        }

    }
}

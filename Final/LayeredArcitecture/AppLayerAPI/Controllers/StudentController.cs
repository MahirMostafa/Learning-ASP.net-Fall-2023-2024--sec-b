using BusinessLogicLayer.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AppLayerAPI.Controllers
{
    public class StudentController : ApiController
    {
        [HttpGet]
        [Route("api/Student/all")]
        public HttpResponseMessage All()
        {
            try
            {
                var data = StudentService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch(Exception ex) 
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }


        [HttpGet]
        [Route("api/Student/{id}")]
        public HttpResponseMessage Get(int id) 
        {
            try
            {
                var data = StudentService.Get(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);

            }
            catch(Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }


    }
}

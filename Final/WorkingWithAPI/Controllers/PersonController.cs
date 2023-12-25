using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WorkingWithAPI.EF;
using WorkingWithAPI.Models;

namespace WorkingWithAPI.Controllers
{
    public class PersonController : ApiController
    {
        [HttpGet]
        [Route("api/persons")]
        public HttpResponseMessage AllPerson()
        {
            var db = new DemoAPIEntities();
            try
            {
               var persons = db.persons.ToList();
                return Request.CreateResponse(HttpStatusCode.OK, persons);
            }
            catch (Exception ex) 
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);

            }
        }



        [HttpGet]
        [Route("api/getperson/{id}")]
        public HttpResponseMessage Post(int id) 
        {
            var db = new DemoAPIEntities();
            try
            {
                var data = db.persons.Find(id);
                if(data != null) {
                    return Request.CreateResponse(HttpStatusCode.OK, data);
                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.NotFound, "Data Not Found");
                }
            }
            catch(Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
            
        }

        [HttpPost]
        [Route("api/persons/create")]

        public HttpResponseMessage Create(person p)
        {
            var db = new DemoAPIEntities();
            try
            {
                 db.persons.Add(p);
                db.SaveChanges();
                return Request.CreateResponse(HttpStatusCode.Created,new {msg="Data Added"});
               
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }

        }
        [HttpPost]
        [Route("api/persons/update")]
        public HttpResponseMessage Update(person p) 
        {
            var db = new DemoAPIEntities();
            try
            {
                var exp = db.persons.Find(p.Id);
                db.Entry(exp).CurrentValues.SetValues(p);
                db.SaveChanges();
                return Request.CreateResponse(HttpStatusCode.OK, "Data Updated");

            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }

        }


    }


}

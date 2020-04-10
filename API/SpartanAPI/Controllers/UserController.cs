using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using SpartanDAL;

namespace SpartanAPI.Controllers
{
    public class UserController : ApiController
    {
        private UsuarioQuerys dbQuerys;

        public UserController()
        {
            dbQuerys = new UsuarioQuerys();
        }

        // GET: api/User
        public IHttpActionResult Get()
        {
            return Json(dbQuerys.GetAllUsers());
        }

        // GET: api/User/5
        public IHttpActionResult Get(int id)
        {
            return Json(dbQuerys.GetUserById(id));
        }

        // GET: api/User/5
        public IHttpActionResult GetUserProfile(int id)
        {
            return Ok(dbQuerys.GetUserProfileById(id));
        }

        // POST: api/User
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/User/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/User/5
        public void Delete(int id)
        {
        }
    }
}

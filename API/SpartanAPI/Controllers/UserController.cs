using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using SpartanDAL;
using SpartanDAL.Implentations;

namespace SpartanAPI.Controllers
{
    public class UserController : ApiController
    {
        private readonly BaseRepository<Usuario> dbQuerys;

        public UserController() =>        
            dbQuerys = new BaseRepository<Usuario>(new MobilePOCEntities());        

        [Route("user/")]
        public IHttpActionResult Get()
        {
            return Json(dbQuerys.Get());
        }

        [Route("user/{id}/")]
        public IHttpActionResult GetById(int id)
        {
            return Json(dbQuerys.GetByID(id));
        }

        [Route("user/post/{usuarioPost}/")]
        public void Post([FromBody]Usuario usuarioPost)
        {
            dbQuerys.Insert(usuarioPost);
        }

        [Route("user/delete/{id}/")]
        public void Delete(int id)
        {
            dbQuerys.Delete(id);
        }
    }
}

using SpartanDAL;
using SpartanDAL.Implentations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SpartanAPI.Controllers
{
    public class UserProfileController : ApiController
    {
        private readonly BaseRepository<UsuarioPerfil> dbQuerys;

        public UserProfileController() =>
            dbQuerys = new BaseRepository<UsuarioPerfil>(new MobilePOCEntities());

        [Route("userProfile/")]
        public IHttpActionResult Get()
        {
            return Json(dbQuerys.Get());
        }

        [Route("userProfile/{id}/")]
        public IHttpActionResult GetById(int id)
        {
            return Json(dbQuerys.GetByID(id));
        }

        [Route("userProfile/post/{usuarioPost}/")]
        public void Post([FromBody]UsuarioPerfil usuarioPerfilPost)
        {
            dbQuerys.Insert(usuarioPerfilPost);
        }

        [Route("userProfile/delete/{id}/")]
        public void Delete(int id)
        {
            dbQuerys.Delete(id);
        }
    }
}

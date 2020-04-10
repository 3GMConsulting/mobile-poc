using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SpartanDTO;
using SpartanDAL.Extensions;

namespace SpartanDAL
{
    public class UsuarioQuerys
    {
        private readonly MobilePOCEntities dbContext;

        public UsuarioQuerys()
        {
            dbContext = new MobilePOCEntities();
        }

        public List<UsuarioDTO> GetAllUsers()
        {
            var result = new List<UsuarioDTO>();
            foreach (Usuario usuario in dbContext.Usuarios.ToList())
            {
                result.Add(usuario.ToUsuarioDTO());  
            }
            return result;
        }

        public UsuarioDTO GetUserById(int id)
        {
            var result = dbContext.Usuarios.Where(x => x.IdUsuario == id).ToList().FirstOrDefault();
            return result.ToUsuarioDTO();
        }      

        public UsuarioPerfilDTO GetUserProfileById(int id)
        {
            var result = dbContext.UsuarioPerfils.Where(x => x.IdUsuarioPerfil == id).ToList().FirstOrDefault();
            return result.ToUsuarioPerfilDTO();
        }

        public UsuarioSeguridadDTO GetUserSecById(int id)
        {
            var result = dbContext.UsuarioSeguridads.Where(x => x.IdUsuarioSeguridad == id).ToList().FirstOrDefault();
            return result.ToUsuarioSeguridadDTO();
        }
    }
}

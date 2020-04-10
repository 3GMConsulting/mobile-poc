using SpartanDTO;

namespace SpartanDAL.Extensions
{
    public static class DtoMapper
    {
        public static UsuarioDTO ToUsuarioDTO(this Usuario source)
        {
           return new UsuarioDTO
           {
               IdUsuario = source.IdUsuario,
               Contrasena = source.Contrasena,
               FechaNacimiento = source.FechaNacimiento,
               Mail = source.Mail,
               Usuario1 = source.Usuario1,
               NombreCompleto = source.NombreCompleto,
               IdUsuarioPerfil = source.IdUsuarioPerfil,
               IdUsuarioSeguridad = source.IdUsuarioSeguridad
           }; 
        }

        public static UsuarioPerfilDTO ToUsuarioPerfilDTO(this UsuarioPerfil source)
        {
            return new UsuarioPerfilDTO
            {
               IdUsuarioPerfil = source.IdUsuarioPerfil,
               EstadoPerfil = source.EstadoPerfil,
               FotoPerfil = source.FotoPerfil,
               ScoreGlobal = source.ScoreGlobal,
               ScoreJugador = source.ScoreObservador,
               ScoreObservador = source.ScoreObservador
            };
        }

        public static UsuarioSeguridadDTO ToUsuarioSeguridadDTO(this UsuarioSeguridad source)
        {
            return new UsuarioSeguridadDTO
            {
                IdUsuarioSeguridad = source.IdUsuarioSeguridad,
                PreguntaSecreta = source.PreguntaSecreta,
                RespuestaSecreta = source.RespuestaSecreta
            };
        }
    }
}

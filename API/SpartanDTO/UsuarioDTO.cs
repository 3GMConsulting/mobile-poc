using System;

namespace SpartanDTO
{
    public class UsuarioDTO
    {
        public int IdUsuario { get; set; }
        public string Usuario1 { get; set; }
        public string Contrasena { get; set; }
        public string NombreCompleto { get; set; }
        public string Mail { get; set; }
        public Nullable<System.DateTime> FechaNacimiento { get; set; }
        public Nullable<int> IdUsuarioPerfil { get; set; }
        public Nullable<int> IdUsuarioSeguridad { get; set; }
    }
}

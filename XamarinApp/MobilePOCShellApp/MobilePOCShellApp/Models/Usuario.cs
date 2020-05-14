using System;

namespace MobilePOCShellApp.Models
{
    public class Usuario
    {
        public int IdUsuario { get; set; }
        public string NombreUsuario { get; set; }
        public string Contraseña { get; set; }
        public string NombreCompleto { get; set; }
        public string Mail { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public int IdPerfil { get; set; }
        public int IdSeguridad { get; set; }
    }
}

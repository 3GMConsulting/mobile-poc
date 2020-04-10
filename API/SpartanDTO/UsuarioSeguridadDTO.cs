using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpartanDTO
{
    public class UsuarioSeguridadDTO
    {
        public int IdUsuarioSeguridad { get; set; }
        public string PreguntaSecreta { get; set; }
        public string RespuestaSecreta { get; set; }
    }
}

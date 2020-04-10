using System;

namespace SpartanDTO
{
    public class UsuarioPerfilDTO
    {
        public int IdUsuarioPerfil { get; set; }
        public byte[] FotoPerfil { get; set; }
        public string EstadoPerfil { get; set; }
        public Nullable<int> ScoreJugador { get; set; }
        public Nullable<int> ScoreObservador { get; set; }
        public Nullable<int> ScoreGlobal { get; set; }
    }
}

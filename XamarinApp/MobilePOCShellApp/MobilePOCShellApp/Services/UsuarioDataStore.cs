using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MobilePOCShellApp.Models;

namespace MobilePOCShellApp.Services
{
    public class UsuarioDataStore : IDataStore<Usuario>
    {
        readonly List<Usuario> usuarios;

        public UsuarioDataStore()
        {
            usuarios = new List<Usuario>()
            {

            };
        }

        public async Task<bool> Authenticate<T>(Usuario usuario)
        {
            if (usuario.NombreUsuario == "FernandoAMartinez" && usuario.Contraseña == "12345")
                return true;
            else
                return false;
        }

        public async Task<bool> AddItemAsync(Usuario usuario)
        {
            usuarios.Add(usuario);

            return await Task.FromResult(true);
        }

        public async Task<bool> UpdateItemAsync(Usuario usuario)
        {
            var oldItem = usuarios.Where((Usuario arg) => arg.IdUsuario == usuario.IdUsuario).FirstOrDefault();
            usuarios.Remove(oldItem);
            usuarios.Add(usuario);

            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteItemAsync(string id)
        {
            var oldItem = usuarios.Where((Usuario arg) => arg.IdUsuario == Convert.ToInt32(id)).FirstOrDefault();
            usuarios.Remove(oldItem);

            return await Task.FromResult(true);
        }

        public async Task<Usuario> GetItemAsync(string id) => 
            await Task.FromResult(usuarios.FirstOrDefault(s => s.IdUsuario == Convert.ToInt32(id)));
        

        public async Task<IEnumerable<Usuario>> GetItemsAsync(bool forceRefresh = false) => 
            await Task.FromResult(usuarios);
        
    }
}
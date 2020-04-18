/*
A partir de las clases CajaRepository y SucursalRepository, crear la clase BaseRepository<T> 
que unifique los métodos GetAllAsync y GetOneAsync
Crear un abstract BaseEntity que defina la property Id y luego modificar las entities Caja y Sucursal para que hereden de BaseEntity 
Aclaración: Se deben respetar la interfaces. 
*/

using System.Threading.Tasks;

namespace Domain.Entities
{

    public abstract class BaseEntity<IdType>
    {
        public IdType Id { get; set; }
    }

    public class Caja : BaseEntity<Guid>
    {
        public int SucursalId { get; }
        public string Descripcion { get; }
        public int TipoCajaId { get; }

        public Caja(Guid id, int sucursalId, string descripcion, int tipoCajaId)
        {
            Id = id;
            SucursalId = sucursalId;
            Descripcion = descripcion;
            TipoCajaId = tipoCajaId;
        }
    }

    public class Sucursal : BaseEntity<int>
    {
        public string Direccion { get; }
        public string Telefono { get; }

        public Sucursal(int id, string direccion, string telefono)
        {
            Id = id;
            Direccion = direccion;
            Telefono = telefono;
        }
    }



    public interface ICajaRepository
    {
        Task<IEnumerable<Caja>> GetAllAsync();
        Task<Caja> GetOneAsync(Guid id);
    }

    public interface ISucursalRepository
    {
        Task<IEnumerable<Sucursal>> GetAllAsync();
        Task<Sucursal> GetOneAsync(int id);
    }

    public interface IBaseRepository<T, IdType> where T : class
    {
        Task<IEnumerable<T>> GetAllAsync();
        Task<T> GetOneAsync(IdType id);
    }

    public class BaseRepository<T, IdType> where T : BaseEntity<IdType>
    {
        private readonly DataContext _db;

        public BaseRepository(DataContext db)
        {
            _db = db ?? throw new ArgumentNullException(nameof(DataContext));
        }

        public async Task<IEnumerable<T>> GetAllAsync()
          => await _db.Set<T>().ToListAsync();

        public async Task<T> GetOneAsync(IdType id)
          => await _db.Set<T>().FirstOrDefaultAsync(x => x.Id.Equals(id));
    }

    public class CajaRepository : BaseRepository<Caja, Guid>, ICajaRepository
    {
        private readonly DataContext _db;

        public CajaRepository(DataContext db)
            => _db = db;
    }

    internal class DataContext
    {
    }

    public class SucursalRepository : ISucursalRepository
    {
        private readonly DataContext _db;

        public CajaRepository(DataContext db)
            => _db = db;
    }

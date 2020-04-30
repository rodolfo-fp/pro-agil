using System.Threading.Tasks;
using ProAgil.Domain;

namespace ProAgil.Repository {
    public interface IProAgilRepository {
        void Add<T>(T entity) where T : class;
        void Update<T>(T entity) where T : class;
        void Delete<T>(T entity) where T : class;
        Task<bool> SaveChangesAsync();

        Task<Evento[]> GetAllEventoAsyncByTema(string Tema, bool IncludePalestrantes);
        Task<Evento[]> GetAllEventoAsync(bool IncludePalestrantes);
        Task<Evento> GetEventoAsyncById(int EventoId, bool IncludePalestrantes);

        Task<Palestrante[]> GetAllPalestrantesAsyncByName(string Nome, bool IncludeEventos);
        Task<Palestrante> GetPalestranteAsync(int PalestranteId, bool IncludeEventos);
    }
}
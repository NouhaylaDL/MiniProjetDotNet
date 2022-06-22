using MiniProjetDotNet.Models;

namespace MiniProjetDotNet.Interfaces
{
    public interface ISalarieService
    {
        Task<IEnumerable<Salarie>?> GetAll();
        Task<Salarie?> GetById(int ID);
        Task Add(Salarie salarie);
        Task Update(Salarie salarie);
        Task Delete (int idsalarie);
        Task<bool> Exists(int Idsal);
    }
}
using MiniProjetDotNet.Models;
using System.Threading.Tasks;
using System.Linq;
using System.Collections.Generic;
namespace MiniProjetDotNet.Interfaces
{
    public interface ISalarieRepository
    {
        Task<IEnumerable<Salarie>?> GetAll();
        Task<Salarie?> GetById(int ID);
        Task Add(Salarie salarie);
        Task Update(Salarie salarie);
        Task Delete (Salarie salarie);
        Task<bool> Exists(int Idsal);

    }
}
   
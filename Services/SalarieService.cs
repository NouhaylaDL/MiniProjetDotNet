using MiniProjetDotNet.Interfaces;
using MiniProjetDotNet.Models;

namespace MiniProjetDotNet.Services
{
    public class SalarieService : ISalarieService
    {
        private readonly ISalarieRepository _IserviceRepository;
        public SalarieService(ISalarieRepository salarieRepository)
        {
            this._IserviceRepository = salarieRepository;
        }

        public async Task Add(Salarie salarie)
        {
            await this._IserviceRepository.Add(salarie);
        }

        public async Task Delete(int idsalarie)
        {
            var salarie = await this._IserviceRepository.GetById(idsalarie);
            await this._IserviceRepository.Delete(salarie!);
        }

        public async Task<bool> Exists(int Idsal)
        {
            return await this._IserviceRepository.Exists(Idsal);
        }

        public Task<IEnumerable<Salarie>?> GetAll()
        {
            return this._IserviceRepository.GetAll();
        }

        public async Task<Salarie?> GetById(int ID)
        {
            return await this._IserviceRepository.GetById(ID);
        }

        public async Task Update(Salarie salarie)
        {
            await this._IserviceRepository.Update(salarie);
        }
    }
}
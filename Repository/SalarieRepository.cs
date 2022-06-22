using MiniProjetDotNet.Interfaces;
using MiniProjetDotNet.Data;
using MiniProjetDotNet.Models;
using Microsoft.EntityFrameworkCore;
namespace MiniProjetDotNet.Repository

{
    public class SalarieRepository : ISalarieRepository
    {
        private readonly DataContext _db;
        public SalarieRepository(DataContext data)
        {
            this._db = data;
        }

        public async Task Add(Salarie salarie)
        {
            await this._db.Salaries.AddAsync(salarie);
            await this._db.SaveChangesAsync();
        }

        public async Task Delete(Salarie salarie)
        {
            this._db.Salaries.Remove(salarie);
            await this._db.SaveChangesAsync();
        }
        public async Task Update(Salarie salarie)
        {
            this._db.Entry(salarie).State = EntityState.Modified;
            await this._db.SaveChangesAsync();
        }

        public async Task<IEnumerable<Salarie>?> GetAll()
        {
            return await this._db.Salaries.ToListAsync();
        }
        public async Task<bool> Exists(int Idsal)
        {
            return await this._db.Salaries.AnyAsync(a => a.ID == Idsal);
        }

        public async Task<Salarie?> GetById(int ID)
        {
            return await this._db.Salaries.FirstOrDefaultAsync(a => a.ID == ID);
        }

    }
}
using BLL.MusicViewModelInterface;
using DAL.Config;
using Microsoft.EntityFrameworkCore;
using Models.Music;

namespace DAL.MusicRepository
{

    public class MusicRep : MusicI<MusicViewModel>
    {

        private readonly DbContextOptions<ContextBase> _OptionsBuilder;
        private readonly ContextBase _contextBase;

        public MusicRep(ContextBase contextBase)
        {
            _contextBase = contextBase;
        }

        public async Task Add(MusicViewModel Object)
        {
            await _contextBase.Set<MusicViewModel>().AddAsync(Object);
            await _contextBase.SaveChangesAsync();
        }

        public async Task Delete(MusicViewModel Object)
        {
            _contextBase.Set<MusicViewModel>().Remove(Object);
            await _contextBase.SaveChangesAsync();
        }

        public async Task Update(MusicViewModel Object)
        {
            _contextBase.Set<MusicViewModel>().Update(Object);
            await _contextBase.SaveChangesAsync();
        }

        public async Task<MusicViewModel> GetEntityById(int Id)
        {
            return await _contextBase.Set<MusicViewModel>().FindAsync(Id);
        }

        public async Task<List<MusicViewModel>> List()
        {
            return await _contextBase.Set<MusicViewModel>().ToListAsync();
        }

    }
}

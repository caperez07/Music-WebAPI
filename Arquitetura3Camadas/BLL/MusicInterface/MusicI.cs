using BLL.MusicViewModelInterface;
using Models.Music;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.MusicViewModelInterface
{
    public interface MusicI<MusicViewModel>
    {
        Task Add(MusicViewModel Object);

        Task Delete(MusicViewModel Object);

        Task Update(MusicViewModel Object);

        Task<MusicViewModel> GetEntityById(int Id);

        Task<List<MusicViewModel>> List();
    }
}

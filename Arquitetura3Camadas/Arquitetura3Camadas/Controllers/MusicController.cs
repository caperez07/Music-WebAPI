using BLL.MusicViewModelInterface;
using Microsoft.AspNetCore.Mvc;
using Models.Music;

namespace Arquitetura3Camadas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MusicController : Controller
    {
        private readonly MusicI<MusicViewModel> _MusicI;

        public MusicController(MusicI<MusicViewModel> musicI)
        {
            _MusicI = musicI;
        }

        [HttpGet("Lista_de_músicas")]
        public async Task<IActionResult> MusicList()
        {
            return Ok(await _MusicI.List());
        }

        [HttpPost("Adicionar_músicas")]
        public async Task AddMusic(MusicViewModel music)
        {
            await _MusicI.Add(music);
        }

        [HttpPost("Remover_músicas")]
        public async Task RemoveMusic(MusicViewModel music)
        {
            await _MusicI.Delete(music);
        }

        [HttpPost("Atualizar_músicas")]
        public async Task UpdateMusic(MusicViewModel music)
        {
            await _MusicI.Update(music);
        }

        [HttpPost("Obter_música_por_Id")]
        public async Task<IActionResult> GetMusicById(int Id)
        {
            return Json(await _MusicI.GetEntityById(Id));
        }
    }
}

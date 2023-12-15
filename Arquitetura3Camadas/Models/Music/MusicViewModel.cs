using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Music
{
    [Table("Tabela_de_Músicas")]
    public class MusicViewModel
    {
        [Key]
        [Column("MusicID")]
        [Display(Name = "Código da música")]
        public int MusicId { get; set; }

        [Required]
        [Column("MusicNAME")]
        [Display(Name = "Nome da música")]
        [MaxLength(255)]
        public string MusicName { get; set; }

        [Required]
        [Column("SingerNAME")]
        [Display(Name = "Nome do cantor(a/e)")]
        [MaxLength(70)]
        public string SingerName { get; set; }

        [Required]
        [Column("MusicGENDER")]
        [Display(Name = "Gênero da Música")]
        [MaxLength(15)]
        public string MusicGender { get; set; }


        [Column("MusicPLATFORMS")]
        [Display(Name = "Plataformas disponíveis")]
        [MaxLength(20)]
        public string? MusicPlatforms { get; set; }

        public MusicViewModel()
        {
        }

        public MusicViewModel(int musicId, string musicName, string singerName, string musicGender, string? musicPlatforms)
        {
            MusicId = musicId;
            MusicName = musicName;
            SingerName = singerName;
            MusicGender = musicGender;
            MusicPlatforms = musicPlatforms;
        }
    }
}

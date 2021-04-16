using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace DOLPHIN.Model
{
    public class SoHieuSoGiaHan
    {
        [ForeignKey("MaSoHieu")]
        [JsonIgnore]
        public virtual SoHieu SoHieu { get; set; }

        [Key]
        [Column(Order = 0)]
        public int MaSoHieu { get; set; }


        [ForeignKey("MaSoGiaHan")]
        [JsonIgnore]
        public virtual SoGiaHan SoGiaHan { get; set; }

        [Key]
        [Column(Order = 1)]
        public int MaSoGiaHan { get; set; }
    }
}

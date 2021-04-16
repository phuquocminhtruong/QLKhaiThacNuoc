using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using System.Text.Json.Serialization;

namespace DOLPHIN.Model
{
    public class GiayPhepSoGiaHan
    {
        [ForeignKey("MaGiayPhep")]
        [JsonIgnore]
        public virtual ToTrinh GiayPhep { get; set; }

        [Key]
        [Column(Order = 0)]
        public int MaGiayPhep { get; set; }


        [ForeignKey("MaSoGiaHan")]
        [JsonIgnore]
        public virtual SoGiaHan SoGiaHan { get; set; }

        [Key]
        [Column(Order = 1)]
        public int MaSoGiaHan { get; set; }
    }
}

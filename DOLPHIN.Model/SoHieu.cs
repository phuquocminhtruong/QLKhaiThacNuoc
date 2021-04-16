using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using System.Text.Json.Serialization;

namespace DOLPHIN.Model
{
    public class SoHieu
    {
        [Key]
        public int Id { get; set; }

        public string TenLoaiVanBan { get; set; }

        public string ChuVietTat { get; set; }

        /// <summary>
        /// Gets or sets.
        /// </summary>
        public virtual ICollection<SoHieuSoGiaHan> SoHieuSoGiaHan { get; set; }
    }
}

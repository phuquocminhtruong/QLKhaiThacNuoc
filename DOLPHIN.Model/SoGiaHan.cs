using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DOLPHIN.Model
{
    public class SoGiaHan
    {
        [Key]
        public int Id { get; set; }

        public int LuuLuong { get; set; }

        public int DuongKinh { get; set; }

        public string ToaDo { get; set; }

        public DateTime ThoiGian { get; set; }

        public int TrangThai { get; set; }

        /// <summary>
        /// Gets or sets.
        /// </summary>
        public virtual ICollection<ToChucSoGiaHan> ToChucSoGiaHan { get; set; }

        /// <summary>
        /// Gets or sets.
        /// </summary>
        public virtual ICollection<GiayPhepSoGiaHan> GiayPhepSoGiaHan { get; set; }

        /// <summary>
        /// Gets or sets.
        /// </summary>
        public virtual ICollection<SoHieuSoGiaHan> SoHieuSoGiaHan { get; set; }
    }
}

using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DOLPHIN.Model
{
    public class HoSo
    {
        [Key]
        public int Id { get; set; }

        public string TenHoSo { get; set; }

        public int KhoiLuong { get; set; }

        public string NoiDung { get; set; }

        /// <summary>
        /// Gets or sets.
        /// </summary>
        [ForeignKey("MaToChuc")]
        public virtual ToChuc ToChuc { get; set; }

        public DateTime NgayThucHienQuyDinh { get; set; }

        public DateTime NgayThucHienThucTe { get; set; }

        public int SoLanCapNhat { get; set; }

        public DateTime NgayBanHanh { get; set; }

        public int TrangThai { get; set; }
    }
}

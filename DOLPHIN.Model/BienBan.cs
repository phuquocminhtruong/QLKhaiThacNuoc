using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using System.Text.Json.Serialization;

namespace DOLPHIN.Model
{
    public class BienBan
    {
        [Key]
        public int Id { get; set; }

        public string TenBienBan { get; set; }

        public DateTime NgayLapBienBan { get; set; }

        /// <summary>
        /// Gets or sets.
        /// </summary>
        [ForeignKey("MaToChucDaiDien")]
        public virtual ToChuc ToChuc { get; set; }

        public string ThongTinDonVi { get; set; }

        public DateTime NgayThucHienQuyDinh { get; set; }

        public string HienTrang { get; set; }

        public string NhanXet { get; set; }

        public string YKienDonVi { get; set; }

        public int SoLanCapNhat { get; set; }

        public DateTime NgayBanHanh { get; set; }

        public int TrangThai { get; set; }
    }
}

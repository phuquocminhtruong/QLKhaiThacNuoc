using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DOLPHIN.Model
{
    public class ToTrinh
    {
        [Key]
        public int Id { get; set; }

        public string TenToTrinh { get; set; }

        public DateTime NgayTao { get; set; }

        /// <summary>
        /// Gets or sets.
        /// </summary>
        [ForeignKey("MaToChuc")]
        public virtual ToChuc ToChuc { get; set; }

        public int MaToChuc { get; set; }

        /// <summary>
        /// Gets or sets.
        /// </summary>
        [ForeignKey("MaDonViHanhChinh")]
        public virtual DonViHanhChinh DonViHanhChinh { get; set; }

        public int MaDonViHanhChinh { get; set; }

        public string MucDichKhaiThac { get; set; }

        public int TangChuaNuocKhaiThac { get; set; }

        public int SoGieng { get; set; }

        public int LuongNuocKhaiThac { get; set; }

        public DateTime ThoiHanCapPhep { get; set; }

        /// <summary>
        /// Gets or sets.
        /// </summary>
        [ForeignKey("MaQuanTrac")]
        public virtual QuanTrac QuanTrac  { get; set; }

        public int MaQuanTrac { get; set; }

        public int SoLanCapNhat { get; set; }

        public DateTime  NgayBanHanh { get; set; }

        public int TrangThai { get; set; }

        /// <summary>
        /// Gets or sets type: to trinh / giay phep
        /// </summary>
        public int Type { get; set; }

        /// <summary>
        /// Gets or sets.
        /// </summary>
        public virtual ICollection<GiayPhepSoGiaHan> GiayPhepSoGiaHan { get; set; }
    }
}

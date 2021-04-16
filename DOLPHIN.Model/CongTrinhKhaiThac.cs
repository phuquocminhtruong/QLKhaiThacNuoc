using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DOLPHIN.Model
{
    public class CongTrinhKhaiThac
    {
        [Key]
        public int Id { get; set; }

        public string TenCongTrinh { get; set; }

        public string LoaiCongTrinh { get; set; }

        /// <summary>
        /// Gets or sets.
        /// </summary>
        [ForeignKey("MaCanBoQuanLy")]
        public virtual CanBo CanBo { get; set; }

        public int MaCanBoQuanLy { get; set; }
        public DateTime NgayThucHien { get; set; }

        public DateTime ThoiGianDuKien { get; set; }

        /// <summary>
        /// Gets or sets.
        /// </summary>
        [ForeignKey("MaGiayPhep")]
        public virtual ToTrinh ToTrinh { get; set; }

        public int MaGiayPhep { get; set; }

        /// <summary>
        /// Gets or sets: 0: Đang khai thác / 1: Tạm dừng khai thác...
        /// </summary>
        public int TrangThai { get; set; }
    }
}

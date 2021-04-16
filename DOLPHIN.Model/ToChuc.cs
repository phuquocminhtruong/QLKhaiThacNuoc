using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DOLPHIN.Model
{
    public class ToChuc
    {
        [Key]
        public int Id { get; set; }

        public string TenToChuc { get; set; }

        public string DiaChi { get; set; }

        public string SoDienThoai { get; set; }

        public int MaNhanVienQuanLy { get; set; }

        /// <summary>
        /// Gets or sets.
        /// </summary>
        public virtual ICollection<ToChucSoGiaHan> ToChucSoGiaHan { get; set; }
    }
}

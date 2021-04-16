using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DOLPHIN.Model
{
    public class CanBo 
    {
        /// <summary>
        /// Gets or sets Id.
        /// </summary>
        [Key]
        public int Id { get; set; }

        [Required]
        public string TenCanBo { get; set; }

        public string DonVi { get; set; }

        public string DiaChi { get; set; }

        public string SoDienThoai { get; set; }

        /// <summary>
        /// Gets or sets : 0 : Còn làm việc / 1 : Nghỉ việc 
        /// </summary>
        public int TrangThai { get; set; }
    }
}

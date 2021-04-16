using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DOLPHIN.Model
{
    public class LoaiChiPhi
    {
        [Key]
        public int Id { get; set; }

        public string TenLoaiChiPhi { get; set; }

        public int SoTien { get; set; }

        public DateTime NgayBanHanh { get; set; }

        public DateTime NgayCapNhat { get; set; }
    }
}

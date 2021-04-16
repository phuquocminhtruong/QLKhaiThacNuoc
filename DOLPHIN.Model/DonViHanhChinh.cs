using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace DOLPHIN.Model
{
    public class DonViHanhChinh
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string TenDonViHanhChinh { set; get; }
        public string ToaDo { get; set; }
    }
}

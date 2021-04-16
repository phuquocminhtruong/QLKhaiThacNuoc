using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DOLPHIN.Model
{
    public class MetaData
    {
        [Key]
        public int Id { get; set; }

        public string TenFile { get; set; }

        public string NoiDung { get; set; }

        public DateTime NgayThucHien { get; set; }

        public DateTime NgayCapNhat { get; set; }
    }
}

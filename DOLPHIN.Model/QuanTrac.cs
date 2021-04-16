using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DOLPHIN.Model
{
    public class QuanTrac
    {
        [Key]
        public int Id { get; set; }

        public int MucNuocTinh { get; set; }

        public int MucNuocDong { get; set; }

        public int LuuLuong { get; set; }

        public string ChatLuongNuoc { get; set; }
    }
}

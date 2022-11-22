using System;
using System.Collections.Generic;

namespace Project.Models
{
    public partial class KetQua
    {
        public int MaSo { get; set; }
        public string MaMh { get; set; } = null!;
        public int Diem { get; set; }

        public virtual Mon Mon { get; set; } = null!;
        public virtual SinhVien SinhVien { get; set; } = null!;
    }
}
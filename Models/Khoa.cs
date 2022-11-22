using System;
using System.Collections.Generic;

namespace Project.Models
{
    public partial class Khoa
    {
        public Khoa()
        {
            SinhViens = new HashSet<SinhVien>();
        }

        public string MaKhoa { get; set; } = null!;
        public string? TenKhoa { get; set; }

        public virtual ICollection<SinhVien> SinhViens { get; set; }
    }
}

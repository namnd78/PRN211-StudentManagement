using System;
using System.Collections.Generic;

namespace Project.Models
{
    public partial class Mon
    {
        public string MaMh { get; set; } = null!;
        public string? TenMh { get; set; }
        public int? SoTiet { get; set; }
        public virtual ICollection<KetQua> KetQuas { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace Project.Models
{
    public partial class SinhVien
    {
        public int MaSo { get; set; }
        public string HoTen { get; set; }
        public DateTime? NgaySinh { get; set; }
        public bool? GioiTinh { get; set; }
        public string? DiaChi { get; set; }
        public string? DienThoai { get; set; }
        public string? MaKhoa { get; set; }
        public double? Gpa { get; set; }
        public bool? ChuyenNganh { get; set; }

        public virtual Khoa? Khoa { get; set; }
        public virtual ICollection<KetQua> KetQuas { get; set; }

        public string GioiTinhs
        {
            get
            {
                if ((bool)GioiTinh)
                {
                    return "Nam";
                }
                return "Nữ";
            }
        }
    }
}

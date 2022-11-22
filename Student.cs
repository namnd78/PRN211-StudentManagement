using Project.Models;

namespace Project
{
    public partial class Student : Form
    {
        public Student()
        {
            InitializeComponent();
        }

        MyTestContext context = new MyTestContext();
        private void Student_Load(object sender, EventArgs e)
        {
            btnDoAdd.Visible = false;
            btnDoEdit.Visible = false;
            btnDoDelete.Visible = false;
            txtName.Enabled = false;
            txtCode.Enabled = false;
            txtAddress.Enabled = false;
            txtPhone.Enabled = false;
            dtpDOB.Enabled = false;
            cboDepartment.Enabled = false;
            rdFemale.Enabled = false;
            rdMale.Enabled = false;
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                var dataDepartment = context.Khoas.OrderBy(item => item.TenKhoa).ToList();
                cboDepartment.DataSource = dataDepartment;
                cboDepartment.DisplayMember = "TenKhoa";
                cboDepartment.ValueMember = "MaKhoa";

                var dataDepartmentSearch = context.Khoas.OrderBy(item => item.TenKhoa).ToList();
                dataDepartmentSearch.Insert(0, new Khoa { MaKhoa = "All", TenKhoa = " Tất cả khoa" });
                cboDepartmentSearch.DataSource = dataDepartmentSearch;
                cboDepartmentSearch.DisplayMember = "TenKhoa";
                cboDepartmentSearch.ValueMember = "MaKhoa";

                cboGenderSearch.SelectedIndex = 0;
                cboSort.SelectedIndex = 0;

                var data = context.SinhViens.Select(item => new
                {
                    MaSo = item.MaSo,
                    HoTen = item.HoTen,
                    NgaySinh = item.NgaySinh,
                    GioiTinh = item.GioiTinh,
                    GioiTinhs = item.GioiTinhs,
                    DiaChi = item.DiaChi,
                    DienThoai = item.DienThoai,
                    MaKhoa = item.MaKhoa,
                    TenKhoa = item.Khoa.TenKhoa,
                }).ToList();

                dgStudent.DataSource = data;
                dgStudent.Columns["GioiTinh"].Visible = false;
                dgStudent.Columns["MaKhoa"].Visible = false;
                dgStudent.Columns["MaSo"].HeaderText = "Mã Số";
                dgStudent.Columns["HoTen"].HeaderText = "Họ Tên";
                dgStudent.Columns["NgaySinh"].HeaderText = "Ngày Sinh";
                dgStudent.Columns["GioiTinhs"].HeaderText = "Giới Tính";
                dgStudent.Columns["DiaChi"].HeaderText = "Địa Chỉ";
                dgStudent.Columns["DienThoai"].HeaderText = "Điện Thoại";
                dgStudent.Columns["TenKhoa"].HeaderText = "Khoa";
                dgStudent.Columns[2].DefaultCellStyle.Format = "dd/MM/yyyy";

                txtCode.DataBindings.Clear();
                txtCode.DataBindings.Add("Text", data, "MaSo");
                txtName.DataBindings.Clear();
                txtName.DataBindings.Add("Text", data, "HoTen");
                dtpDOB.DataBindings.Clear();
                // DateTimePicker: CauseValidation = true -> value cannot change 
                dtpDOB.DataBindings.Add("Value", data, "NgaySinh");
                txtAddress.DataBindings.Clear();
                txtAddress.DataBindings.Add("Text", data, "DiaChi");
                txtPhone.DataBindings.Clear();
                txtPhone.DataBindings.Add("Text", data, "DienThoai");
                cboDepartment.DataBindings.Clear();
                cboDepartment.DataBindings.Add("Text", data, "TenKhoa");
                rdMale.DataBindings.Clear();
                rdMale.DataBindings.Add("Checked", data, "GioiTinh");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Load error: " + ex.Message);
            }
        }

        private void rdMale_CheckedChanged(object sender, EventArgs e)
        {
            rdFemale.Checked = !rdMale.Checked;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtName.Enabled = true;
            txtCode.Enabled = true;
            txtAddress.Enabled = true;
            txtPhone.Enabled = true;
            dtpDOB.Enabled = true;
            cboDepartment.Enabled = true;
            rdFemale.Enabled = true;
            rdMale.Enabled = true;
            btnDoAdd.Visible = true;
            btnDoEdit.Visible = false;
            btnDoDelete.Visible = false;
            txtName.Text = "";
            txtCode.Text = "";
            txtAddress.Text = "";
            txtPhone.Text = "";
            rdMale.Checked = true;
            dtpDOB.Value = DateTime.Now;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            LoadData();
            txtName.Enabled = true;
            txtCode.Enabled = true;
            txtAddress.Enabled = true;
            txtPhone.Enabled = true;
            dtpDOB.Enabled = true;
            cboDepartment.Enabled = true;
            rdFemale.Enabled = true;
            rdMale.Enabled = true;
            btnDoAdd.Visible = false;
            btnDoEdit.Visible = true;
            btnDoDelete.Visible = false;
        }

        private void btnDoAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtCode.Text.Trim())
               || string.IsNullOrEmpty(txtName.Text.Trim())
               || string.IsNullOrEmpty(txtAddress.Text.Trim())
               || string.IsNullOrEmpty(txtPhone.Text.Trim()))
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin sinh viên!", "Alert");
                    return;
                }
                if (!CheckInteger(txtCode.Text, "Mã số sinh viên chỉ được bao gồm số!"))
                {
                    return;
                }
                if (!CheckInteger(txtPhone.Text, "Số điện thoại không hợp lệ!"))
                {
                    return;
                }
                if (txtPhone.Text.Length < 10)
                {
                    MessageBox.Show("Số điện thoại không hợp lệ!", "Alert");
                    return;
                }
                int code = Convert.ToInt32(txtCode.Text.Trim());
                if (context.SinhViens.FirstOrDefault(item => item.MaSo == code) != null)
                {
                    MessageBox.Show("Mã số sinh viên đã tồn tại!", "Alert");
                    return;
                };
                if (context.SinhViens.FirstOrDefault(item => item.DienThoai == txtPhone.Text.Trim()) != null)
                {
                    MessageBox.Show("Số điện thoại đã được sử dụng!", "Alert");
                    return;
                };
                SinhVien sv = new SinhVien
                {
                    MaSo = code,
                    HoTen = txtName.Text.Trim(),
                    NgaySinh = dtpDOB.Value.Date,
                    DiaChi = txtAddress.Text.Trim(),
                    MaKhoa = (string)cboDepartment.SelectedValue,
                    GioiTinh = rdMale.Checked,
                    DienThoai = txtPhone.Text.Trim()
                };
                context.SinhViens.Add(sv);
                if (context.SaveChanges() > 0)
                {
                    MessageBox.Show("Thêm sinh viên thành công!");
                    LoadData();
                    btnAdd_Click(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private bool CheckInteger(string rawNumber, string message)
        {
            int number;
            try
            {
                number = Convert.ToInt32(rawNumber);
            }
            catch (Exception ex)
            {
                MessageBox.Show(message, "Alert");
                return false;
            }
            return true;
        }

        private void btnDoEdit_Click(object sender, EventArgs e)
        {
            try
            {
                int rawCode = (int)dgStudent.CurrentRow.Cells["MaSo"].Value;
                SinhVien sv = context.SinhViens.Find(rawCode);
                if (string.IsNullOrEmpty(txtCode.Text.Trim())
               || string.IsNullOrEmpty(txtName.Text.Trim())
               || string.IsNullOrEmpty(txtAddress.Text.Trim())
               || string.IsNullOrEmpty(txtPhone.Text.Trim()))
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin sinh viên!", "Alert");
                    return;
                }
                if (!CheckInteger(txtCode.Text, "Mã số sinh viên chỉ được bao gồm số!"))
                {
                    return;
                }
                if (!CheckInteger(txtPhone.Text, "Số điện thoại không hợp lệ!"))
                {
                    return;
                }
                if (txtPhone.Text.Length < 10)
                {
                    MessageBox.Show("Số điện thoại không hợp lệ!", "Alert");
                    return;
                }
                int codeNew = Convert.ToInt32(txtCode.Text.Trim());
                SinhVien svByCode = context.SinhViens.FirstOrDefault(item => item.MaSo == codeNew);
                if (svByCode != null && svByCode.MaSo != sv.MaSo)
                {
                    MessageBox.Show("Mã số sinh viên đã tồn tại!", "Alert");
                    return;
                };
                SinhVien svByPhone = context.SinhViens.FirstOrDefault(item => item.DienThoai == txtPhone.Text.Trim());
                if (svByPhone != null && svByPhone.DienThoai != sv.DienThoai)
                {
                    MessageBox.Show("Số điện thoại đã được sử dụng!", "Alert");
                    return;
                };
                SinhVien svNew = new SinhVien();
                if (sv != null)
                {
                    svNew.MaSo = codeNew;
                    svNew.HoTen = txtName.Text.Trim();
                    svNew.NgaySinh = dtpDOB.Value;
                    svNew.DiaChi = txtAddress.Text.Trim();
                    svNew.MaKhoa = (string)cboDepartment.SelectedValue;
                    svNew.GioiTinh = rdMale.Checked;
                    svNew.DienThoai = txtPhone.Text.Trim();
                    context.SinhViens.Remove(sv);
                    context.SaveChanges();
                    context.SinhViens.Add(svNew);
                    if (sv.MaKhoa != (string)cboDepartment.SelectedValue)
                    {
                        svNew.ChuyenNganh = true;
                    }
                    if (context.SaveChanges() > 0)
                    {
                        MessageBox.Show("Cập nhật thông tin sinh viên thành công!");
                        LoadData();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            btnDoAdd.Visible = false;
            btnDoEdit.Visible = false;
            btnDoDelete.Visible = true;
            txtName.Enabled = false;
            txtCode.Enabled = false;
            txtAddress.Enabled = false;
            txtPhone.Enabled = false;
            dtpDOB.Enabled = false;
            cboDepartment.Enabled = false;
            rdFemale.Enabled = false;
            rdMale.Enabled = false;
            LoadData();
        }

        private void btnDoDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int svCode = (int)dgStudent.CurrentRow.Cells["MaSo"].Value;
                SinhVien sv = context.SinhViens.FirstOrDefault(item => item.MaSo == svCode);
                if (sv != null && MessageBox.Show("Bạn muốn xóa sinh viên có mã số " + svCode + " ?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //context.SinhViens.Remove(sv);
                    SvthoiHoc s = context.SvthoiHocs.FirstOrDefault(item => item.Id == 1);
                    SvthoiHoc sNew = new SvthoiHoc();
                    sNew.Id = 1;
                    sNew.SoLuong = s.SoLuong + 1;
                    context.SvthoiHocs.Remove(s);
                    context.SvthoiHocs.Add(sNew);
                    if (context.SaveChanges() > 0)
                    {
                        MessageBox.Show("Xóa sinh viên thành công!");
                        LoadData();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Search_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                var data = context.SinhViens.Select(item => new
                {
                    MaSo = item.MaSo,
                    HoTen = item.HoTen,
                    NgaySinh = item.NgaySinh,
                    GioiTinh = item.GioiTinh,
                    GioiTinhs = item.GioiTinhs,
                    DiaChi = item.DiaChi,
                    DienThoai = item.DienThoai,
                    MaKhoa = item.MaKhoa,
                    TenKhoa = item.Khoa.TenKhoa,
                });
                if (!cboDepartmentSearch.SelectedValue.Equals("All"))
                {
                    data = data.Where(item => item.MaKhoa == cboDepartmentSearch.SelectedValue.ToString());
                }
                if (txtSearch != null)
                {
                    data = data.Where(item => item.MaSo.ToString().Contains(txtSearch.Text)
                    || item.HoTen.Contains(txtSearch.Text)
                    || item.DienThoai.Contains(txtSearch.Text)
                    || item.DiaChi.Contains(txtSearch.Text));
                }
                if (cboGenderSearch.SelectedIndex == 1)
                {
                    data = data.Where(item => item.GioiTinh == true);
                }
                else if (cboGenderSearch.SelectedIndex == 2)
                {
                    data = data.Where(item => item.GioiTinh == false);
                }
                switch (cboSort.SelectedIndex)
                {
                    case 0:
                        data = data.OrderBy(item => item.MaSo);
                        break;
                    case 1:
                        data = data.OrderByDescending(item => item.MaSo);
                        break;
                    case 2:
                        data = data.OrderBy(item => item.HoTen);
                        break;
                    case 3:
                        data = data.OrderByDescending(item => item.HoTen);
                        break;
                }
                dgStudent.DataSource = data.ToList();
                dgStudent.Columns[2].DefaultCellStyle.Format = "dd/MM/yyyy";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        // add excel library at COM reference (not working when add in NuGet)
        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "XLSX (*.xlsx)|*.xlsx|XLS (*.xls)|*.xls";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                ToExcel(saveFileDialog.FileName);
                LoadData();
            }
        }

        private void ToExcel(string fileName)
        {
            Microsoft.Office.Interop.Excel.Application excel;
            Microsoft.Office.Interop.Excel.Workbook workbook;
            Microsoft.Office.Interop.Excel.Worksheet worksheet;
            Microsoft.Office.Interop.Excel.Range range;
            try
            {
                excel = new Microsoft.Office.Interop.Excel.Application();
                workbook = excel.Workbooks.Add(Type.Missing);
                worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Sheets[1];
                worksheet.Name = "Danh sách sinh viên";

                dgStudent.Columns.RemoveAt(3);
                dgStudent.Columns.RemoveAt(6);

                // format
                range = worksheet.Range[worksheet.Cells[1, 1], worksheet.Cells[1, dgStudent.ColumnCount]];
                range.Font.Bold = true;
                range.Interior.Color = Color.PaleTurquoise;
                range = worksheet.Columns[3];
                range.NumberFormat = "dd/MM/yyyy";
                range = worksheet.Columns[6];
                range.NumberFormat = "@";
                range = worksheet.Columns[1];
                range.NumberFormat = "@";
                // export header 
                for (int i = 0; i < dgStudent.ColumnCount; i++)
                {
                    worksheet.Cells[1, i + 1] = dgStudent.Columns[i].HeaderText;
                }
                range = worksheet.Columns[6];
                range.NumberFormat = "@";
                // export content
                for (int i = 0; i < dgStudent.RowCount; i++)
                {
                    for (int j = 0; j < dgStudent.ColumnCount; j++)
                    {
                        worksheet.Cells[i + 2, j + 1] = dgStudent.Rows[i].Cells[j].Value.ToString();
                    }
                }

                excel.Columns.AutoFit();
                excel.Visible = true;
                workbook.SaveAs(fileName);
                MessageBox.Show("Xuất dữ liệu ra Excel thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void gbInfo_Enter(object sender, EventArgs e)
        {

        }
    }
}

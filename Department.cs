using Project.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class Department : Form
    {
        public Department()
        {
            InitializeComponent();
        }

        MyTestContext context = new MyTestContext();

        private void Department_Load(object sender, EventArgs e)
        {
            btnDoAdd.Visible = false;
            btnDoEdit.Visible = false;
            btnDoDelete.Visible = false;
            txtName.Enabled = false;
            txtCode.Enabled = false;
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                var data = context.Khoas.Select(item => new
                {
                    MaKhoa = item.MaKhoa,
                    TenKhoa = item.TenKhoa
                }).ToList();
                dgDepartment.DataSource = data;
                dgDepartment.Columns["MaKhoa"].HeaderText = "Mã Khoa";
                dgDepartment.Columns["TenKhoa"].HeaderText = "Tên Khoa";
                txtCode.DataBindings.Clear();
                txtCode.DataBindings.Add("Text", data, "MaKhoa");
                txtName.DataBindings.Clear();
                txtName.DataBindings.Add("Text", data, "TenKhoa");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Load error: " + ex.Message);
            }
        }

        private void btnDoAdd_Click(object sender, EventArgs e)
        {
            try
            {
                txtCode.Text = txtCode.Text.Trim().ToUpper();
                txtName.Text = txtName.Text.Trim();
                if (string.IsNullOrEmpty(txtCode.Text)
               || string.IsNullOrEmpty(txtName.Text))
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin khoa!", "Alert");
                    return;
                }
                if (context.Khoas.FirstOrDefault(item => item.MaKhoa == txtCode.Text) != null)
                {
                    MessageBox.Show("Mã khoa đã tồn tại!", "Alert");
                    return;
                };
                Khoa k = new Khoa
                {
                    MaKhoa = txtCode.Text,
                    TenKhoa = txtName.Text
                };
                context.Khoas.Add(k);
                if (context.SaveChanges() > 0)
                {
                    MessageBox.Show("Thêm khoa thành công!");
                    LoadData();
                    btnAdd_Click(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnDoEdit_Click(object sender, EventArgs e)
        {
            try
            {
                context.ChangeTracker.Clear();
                txtCode.Text = txtCode.Text.Trim().ToUpper();
                txtName.Text = txtName.Text.Trim();
                string codeRaw = dgDepartment.CurrentRow.Cells["MaKhoa"].Value.ToString();
                Khoa khoa = context.Khoas.FirstOrDefault(item => item.MaKhoa == codeRaw);
                if (string.IsNullOrEmpty(txtCode.Text)
               || string.IsNullOrEmpty(txtName.Text))
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin khoa!", "Alert");
                    return;
                }
                Khoa khoaByCode = context.Khoas.FirstOrDefault(item => item.MaKhoa == txtCode.Text);
                ////
                //txtCode.Text = codeRaw;
                //txtName.Text = khoaByCode.MaKhoa;
                ////
                if (khoaByCode != null && khoaByCode.MaKhoa != codeRaw)
                {
                    MessageBox.Show("Mã khoa đã tồn tại!", "Alert");
                    return;
                };
                Khoa khoaNew = new Khoa();
                if (khoa != null)
                {
                    khoaNew.MaKhoa = txtCode.Text;
                    khoaNew.TenKhoa = txtName.Text;
                    context.Khoas.Remove(khoa);
                    context.Khoas.Add(khoaNew);
                    if (context.SaveChanges() > 0)
                    {
                        MessageBox.Show("Cập nhật thông tin khoa thành công!");
                        LoadData();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtName.Enabled = true;
            txtCode.Enabled = true;
            btnDoAdd.Visible = true;
            btnDoEdit.Visible = false;
            btnDoDelete.Visible = false;
            txtName.Text = "";
            txtCode.Text = "";
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            txtName.Enabled = true;
            txtCode.Enabled = true;
            btnDoAdd.Visible = false;
            btnDoEdit.Visible = true;
            btnDoDelete.Visible = false;
            LoadData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            txtName.Enabled = false;
            txtCode.Enabled = false;
            btnDoAdd.Visible = false;
            btnDoEdit.Visible = false;
            btnDoDelete.Visible = true;
            LoadData();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void btnDoDelete_Click(object sender, EventArgs e)
        {
            try
            {
                String code = dgDepartment.CurrentRow.Cells["MaKhoa"].Value.ToString();
                Khoa khoa = context.Khoas.FirstOrDefault(item => item.MaKhoa.Equals(code));
                if (khoa != null && MessageBox.Show("Bạn muốn xóa khoa có mã " + code.Trim() + " ?", "Xóa", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    context.Khoas.Remove(khoa);
                    if (context.SaveChanges() > 0)
                    {
                        MessageBox.Show("Xóa khoa thành công!");
                        LoadData();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            var data = context.Khoas.Select(item => new
            {
                MaKhoa = item.MaKhoa,
                TenKhoa = item.TenKhoa
            });
            if (txtSearch != null)
            {
                data = data.Where(item => item.MaKhoa.Contains(txtSearch.Text)
                || item.TenKhoa.Contains(txtSearch.Text));
            }
            dgDepartment.DataSource = data.ToList();
        }

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
                worksheet.Name = "Danh sách khoa";
                range = worksheet.Range[worksheet.Cells[1, 1], worksheet.Cells[1, dgDepartment.ColumnCount]];
                range.Font.Bold = true;
                range.Interior.Color = Color.PaleTurquoise;
                for (int i = 0; i < dgDepartment.ColumnCount; i++)
                {
                    worksheet.Cells[1, i + 1] = dgDepartment.Columns[i].HeaderText;
                }
                for (int i = 0; i < dgDepartment.RowCount; i++)
                {
                    for (int j = 0; j < dgDepartment.ColumnCount; j++)
                    {
                        worksheet.Cells[i + 2, j + 1] = dgDepartment.Rows[i].Cells[j].Value.ToString();
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
    }
}

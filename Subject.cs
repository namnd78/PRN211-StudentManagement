using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
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
    public partial class Subject : Form
    {
        public Subject()
        {
            InitializeComponent();
        }
        MyTestContext context = new MyTestContext();

        private void Subject_Load(object sender, EventArgs e)
        {
            btnDoAdd.Visible = false;
            btnDoEdit.Visible = false;
            btnDoDelete.Visible = false;
            txtName.Enabled = false;
            txtCode.Enabled = false;
            numSlot.Enabled = false;
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                var data = context.Mons.Select(item => new
                {
                    MaMh = item.MaMh,
                    TenMh = item.TenMh,
                    SoTiet = item.SoTiet
                }).ToList();
                dgSubject.DataSource = data;
                dgSubject.Columns["MaMh"].HeaderText = "Mã Môn Học";
                dgSubject.Columns["TenMh"].HeaderText = "Tên Môn Học";
                dgSubject.Columns["SoTiet"].HeaderText = "Số Tiết";
                txtCode.DataBindings.Clear();
                txtCode.DataBindings.Add("Text", data, "MaMh");
                txtName.DataBindings.Clear();
                txtName.DataBindings.Add("Text", data, "TenMh");
                numSlot.DataBindings.Clear();
                numSlot.DataBindings.Add("Text", data, "SoTiet");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Load error: " + ex.Message);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtName.Enabled = true;
            txtCode.Enabled = true;
            numSlot.Enabled = true;
            btnDoAdd.Visible = true;
            btnDoEdit.Visible = false;
            btnDoDelete.Visible = false;
            txtName.Text = "";
            txtCode.Text = "";
            numSlot.Value = 0;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            txtName.Enabled = true;
            txtCode.Enabled = true;
            numSlot.Enabled = true;
            btnDoAdd.Visible = false;
            btnDoEdit.Visible = true;
            btnDoDelete.Visible = false;
            LoadData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            txtName.Enabled = false;
            txtCode.Enabled = false;
            numSlot.Enabled = false;
            btnDoAdd.Visible = false;
            btnDoEdit.Visible = false;
            btnDoDelete.Visible = true;
            LoadData();
        }

        private void btnDoAdd_Click(object sender, EventArgs e)
        {
            context.ChangeTracker.Clear();
            try
            {
                txtCode.Text = txtCode.Text.Trim().ToUpper();
                txtName.Text = txtName.Text.Trim();
                if (string.IsNullOrEmpty(txtCode.Text)
               || string.IsNullOrEmpty(txtName.Text))
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin môn học!", "Alert");
                    return;
                }
                Mon subject = context.Mons.FirstOrDefault(item => item.MaMh == txtCode.Text);
                if (subject != null)
                {
                    string result = "Mã môn đã tồn tại!";
                    if (!subject.TenMh.Trim().Equals(txtName.Text))
                    {
                        result += "\nTên môn học có thay đổi: " + txtName.Text;
                    }
                    if (subject.SoTiet != numSlot.Value)
                    {
                        result += "\nSố tiết có thay đổi: " + numSlot.Value;
                    }
                    if (!subject.TenMh.Trim().Equals(txtName.Text) || subject.SoTiet != numSlot.Value)
                    {
                        if (MessageBox.Show(result + "\n Bạn có muốn lưu thay đổi không?", "Alert", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            Mon subjectNew = new Mon();
                            if (subject != null)
                            {
                                subjectNew.MaMh = txtCode.Text;
                                subjectNew.TenMh = txtName.Text;
                                subjectNew.SoTiet = (int?)numSlot.Value;
                                context.Mons.Remove(subject);
                                context.Mons.Add(subjectNew);
                                if (context.SaveChanges() > 0)
                                {
                                    MessageBox.Show("Cập nhật thông tin môn học thành công!");
                                    LoadData();
                                    return;
                                }
                            }
                        }
                        else
                        {
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show(result);
                        return;
                    }
                };
                Mon m = new Mon
                {
                    MaMh = txtCode.Text,
                    TenMh = txtName.Text,
                    SoTiet = (int)numSlot.Value
                };
                context.Mons.Add(m);
                if (context.SaveChanges() > 0)
                {
                    MessageBox.Show("Thêm môn học thành công!");
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
                string codeRaw = dgSubject.CurrentRow.Cells["MaMh"].Value.ToString();
                Mon mon = context.Mons.FirstOrDefault(item => item.MaMh == codeRaw);
                if (string.IsNullOrEmpty(txtCode.Text)
               || string.IsNullOrEmpty(txtName.Text))
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin môn học!", "Alert");
                    return;
                }
                Mon monByCode = context.Mons.FirstOrDefault(item => item.MaMh == txtCode.Text);
                if (monByCode != null && monByCode.MaMh != codeRaw)
                {
                    MessageBox.Show("Mã môn học đã tồn tại!", "Alert");
                    return;
                };
                Mon monNew = new Mon();
                if (mon != null)
                {
                    monNew.MaMh = txtCode.Text;
                    monNew.TenMh = txtName.Text;
                    monNew.SoTiet = (int?)numSlot.Value;
                    context.Mons.Remove(mon);
                    context.Mons.Add(monNew);
                    if (context.SaveChanges() > 0)
                    {
                        MessageBox.Show("Cập nhật thông tin môn học thành công!");
                        LoadData();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnDoDelete_Click(object sender, EventArgs e)
        {
            try
            {
                String code = dgSubject.CurrentRow.Cells["MaMh"].Value.ToString();
                Mon mon = context.Mons.FirstOrDefault(item => item.MaMh.Equals(code));
                if (mon != null && MessageBox.Show("Bạn muốn xóa môn học có mã " + code.Trim() + " ?", "Xóa", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    context.Mons.Remove(mon);
                    if (context.SaveChanges() > 0)
                    {
                        MessageBox.Show("Xóa môn học thành công!");
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
            Hide();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            var data = context.Mons.Select(item => new
            {
                MaMh = item.MaMh,
                TenMh = item.TenMh,
                SoTiet = item.SoTiet
            });
            if (txtSearch != null)
            {
                data = data.Where(item => item.MaMh.Contains(txtSearch.Text)
                || item.TenMh.Contains(txtSearch.Text));
            }
            dgSubject.DataSource = data.ToList();
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
                worksheet.Name = "Danh sách môn học";
                range = worksheet.Range[worksheet.Cells[1, 1], worksheet.Cells[1, dgSubject.ColumnCount]];
                range.Font.Bold = true;
                range.Interior.Color = Color.PaleTurquoise;
                for (int i = 0; i < dgSubject.ColumnCount; i++)
                {
                    worksheet.Cells[1, i + 1] = dgSubject.Columns[i].HeaderText;
                }
                for (int i = 0; i < dgSubject.RowCount; i++)
                {
                    for (int j = 0; j < dgSubject.ColumnCount; j++)
                    {
                        worksheet.Cells[i + 2, j + 1] = dgSubject.Rows[i].Cells[j].Value.ToString();
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

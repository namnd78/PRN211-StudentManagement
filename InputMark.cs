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
using static System.Runtime.CompilerServices.RuntimeHelpers;
using System.Xml.Linq;

namespace Project
{
    public partial class InputMark : Form
    {
        public InputMark()
        {
            InitializeComponent();
        }
        private void InputMark_Load(object sender, EventArgs e)
        {
            btnDoAdd.Visible = false;
            btnDoDelete.Visible = false;
            numMark.Enabled = false;
            LoadData();
            cboStudentCode_SelectedValueChanged(sender, e);
            cboSubjectCode_SelectedValueChanged(sender, e);
        }
        MyTestContext context = new MyTestContext();

        private void LoadData()
        {
            try
            {
                var studentData = context.SinhViens.ToList();
                var subjectData = context.Mons.ToList();
                cboStudentCode.DataSource = studentData;
                cboStudentCode.DisplayMember = "MaSo";
                cboSubjectCode.DataSource = subjectData;
                cboSubjectCode.DisplayMember = "MaMh";
                numMark.Value = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnDoAdd_Click(object sender, EventArgs e)
        {
            try
            {
                KetQua kq = context.KetQuas.Find(Convert.ToInt32(cboStudentCode.Text), cboSubjectCode.Text);
                if (string.IsNullOrEmpty(numMark.Text.ToString()))
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Alert");
                    return;
                }
                if (kq != null)
                {
                    DialogResult result = MessageBox.Show("Sinh viên đã có điểm của môn học này, bạn có muốn cập nhật điểm không?", "Alert", MessageBoxButtons.YesNo);
                    if (result == DialogResult.No)
                    {
                        return;
                    }
                    if (result == DialogResult.Yes)
                    {
                        kq.Diem = (int)numMark.Value;
                    }
                }
                else
                {
                    KetQua kqNew = new KetQua
                    {
                        MaSo = Convert.ToInt32(cboStudentCode.Text),
                        MaMh = cboSubjectCode.Text,
                        Diem = (int)numMark.Value
                    };
                    context.KetQuas.Add(kqNew);
                }
                if (context.SaveChanges() > 0)
                {
                    MessageBox.Show("Nhập điểm thành công!");
                    cboStudentCode_SelectedValueChanged(sender, e);
                    UpdateGPA();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void cboStudentCode_SelectedValueChanged(object sender, EventArgs e)
        {
            SinhVien student = (SinhVien)cboStudentCode.SelectedItem;
            txtStudentName.Text = context.SinhViens.FirstOrDefault(item => item.MaSo == student.MaSo).HoTen;
            var data = context.KetQuas.Select(item => new
            {
                MaSo = item.MaSo,
                MaMh = item.MaMh,
                TenMh = item.Mon.TenMh,
                Diem = item.Diem
            }).Where(item => item.MaSo == student.MaSo).ToList();
            dgMark.DataSource = data;
            dgMark.Columns["MaSo"].Visible = false;
            dgMark.Columns["MaMh"].HeaderText = "Mã môn";
            dgMark.Columns["TenMh"].HeaderText = "Tên môn học";
            dgMark.Columns["Diem"].HeaderText = "Điểm";
            cboSubjectCode.DataBindings.Clear();
            cboSubjectCode.DataBindings.Add("Text", data, "MaMh");
            numMark.DataBindings.Clear();
            numMark.DataBindings.Add("Text", data, "Diem");
        }

        private void cboSubjectCode_SelectedValueChanged(object sender, EventArgs e)
        {
            txtSubjectName.Text = ((Mon)cboSubjectCode.SelectedItem).TenMh;
            KetQua kq = context.KetQuas.Find(Convert.ToInt32(cboStudentCode.Text), cboSubjectCode.Text);
            if (kq != null)
            {
                numMark.Value = (decimal)kq.Diem;
            }
            else
            {
                numMark.ResetText();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void btnDoDelete_Click(object sender, EventArgs e)
        {
            try
            {
                KetQua kq = context.KetQuas.Find(Convert.ToInt32(cboStudentCode.Text), cboSubjectCode.Text);
                if (kq != null && MessageBox.Show("Bạn muốn xóa điểm của môn học " + kq.MaMh.Trim() + " ?", "Xóa", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    context.KetQuas.Remove(kq);
                    if (context.SaveChanges() > 0)
                    {
                        MessageBox.Show("Xóa điểm thành công!");
                        UpdateGPA();
                        LoadData();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            btnDoAdd.Visible = true;
            btnDoDelete.Visible = false;
            numMark.Enabled = true;
            numMark.Value = 0;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            btnDoAdd.Visible = false;
            btnDoDelete.Visible = true;
            numMark.Enabled = false;
            cboStudentCode_SelectedValueChanged(sender, e);
        }
        private void UpdateGPA()
        {
            SinhVien sv = context.SinhViens.Find(Convert.ToInt32(cboStudentCode.Text));
            var kq = context.KetQuas.Where(item => item.MaSo == Convert.ToInt32(cboStudentCode.Text)).ToList();
            int sum = 0;
            for (int i = 0; i < kq.Count; i++)
            {
                sum += kq[i].Diem;
            }
            double average = (double)sum / kq.Count;
            sv.Gpa = average;
            context.SaveChanges();
        }
    }
}

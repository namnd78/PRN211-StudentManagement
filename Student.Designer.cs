namespace Project
{
    partial class Student
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gbInfo = new System.Windows.Forms.GroupBox();
            this.btnDoDelete = new System.Windows.Forms.Button();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.btnDoEdit = new System.Windows.Forms.Button();
            this.btnDoAdd = new System.Windows.Forms.Button();
            this.rdFemale = new System.Windows.Forms.RadioButton();
            this.rdMale = new System.Windows.Forms.RadioButton();
            this.cboDepartment = new System.Windows.Forms.ComboBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgStudent = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.cboDepartmentSearch = new System.Windows.Forms.ComboBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.cboGenderSearch = new System.Windows.Forms.ComboBox();
            this.btnExportExcel = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.cboSort = new System.Windows.Forms.ComboBox();
            this.gbInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgStudent)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbInfo
            // 
            this.gbInfo.Controls.Add(this.btnDoDelete);
            this.gbInfo.Controls.Add(this.dtpDOB);
            this.gbInfo.Controls.Add(this.btnDoEdit);
            this.gbInfo.Controls.Add(this.btnDoAdd);
            this.gbInfo.Controls.Add(this.rdFemale);
            this.gbInfo.Controls.Add(this.rdMale);
            this.gbInfo.Controls.Add(this.cboDepartment);
            this.gbInfo.Controls.Add(this.txtPhone);
            this.gbInfo.Controls.Add(this.txtAddress);
            this.gbInfo.Controls.Add(this.txtName);
            this.gbInfo.Controls.Add(this.label7);
            this.gbInfo.Controls.Add(this.label8);
            this.gbInfo.Controls.Add(this.label5);
            this.gbInfo.Controls.Add(this.label9);
            this.gbInfo.Controls.Add(this.label4);
            this.gbInfo.Controls.Add(this.label1);
            this.gbInfo.Controls.Add(this.label3);
            this.gbInfo.Controls.Add(this.txtCode);
            this.gbInfo.Controls.Add(this.label6);
            this.gbInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbInfo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gbInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(174)))), ((int)(((byte)(254)))));
            this.gbInfo.Location = new System.Drawing.Point(129, 36);
            this.gbInfo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbInfo.Name = "gbInfo";
            this.gbInfo.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbInfo.Size = new System.Drawing.Size(1056, 343);
            this.gbInfo.TabIndex = 12;
            this.gbInfo.TabStop = false;
            this.gbInfo.Enter += new System.EventHandler(this.gbInfo_Enter);
            // 
            // btnDoDelete
            // 
            this.btnDoDelete.BackColor = System.Drawing.Color.White;
            this.btnDoDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDoDelete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(174)))), ((int)(((byte)(254)))));
            this.btnDoDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(248)))), ((int)(((byte)(220)))));
            this.btnDoDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(248)))), ((int)(((byte)(220)))));
            this.btnDoDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDoDelete.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDoDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(174)))), ((int)(((byte)(254)))));
            this.btnDoDelete.Image = global::Project.Properties.Resources.eraser;
            this.btnDoDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDoDelete.Location = new System.Drawing.Point(890, 266);
            this.btnDoDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDoDelete.Name = "btnDoDelete";
            this.btnDoDelete.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnDoDelete.Size = new System.Drawing.Size(113, 49);
            this.btnDoDelete.TabIndex = 26;
            this.btnDoDelete.Text = "   Xóa";
            this.btnDoDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDoDelete.UseVisualStyleBackColor = false;
            this.btnDoDelete.Click += new System.EventHandler(this.btnDoDelete_Click);
            // 
            // dtpDOB
            // 
            this.dtpDOB.CalendarForeColor = System.Drawing.Color.DimGray;
            this.dtpDOB.CalendarTitleForeColor = System.Drawing.Color.DimGray;
            this.dtpDOB.CausesValidation = false;
            this.dtpDOB.CustomFormat = "  dd / MM / yyyy";
            this.dtpDOB.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDOB.Location = new System.Drawing.Point(238, 197);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(163, 29);
            this.dtpDOB.TabIndex = 25;
            // 
            // btnDoEdit
            // 
            this.btnDoEdit.BackColor = System.Drawing.Color.White;
            this.btnDoEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDoEdit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(174)))), ((int)(((byte)(254)))));
            this.btnDoEdit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(248)))), ((int)(((byte)(220)))));
            this.btnDoEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(248)))), ((int)(((byte)(220)))));
            this.btnDoEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDoEdit.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDoEdit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(174)))), ((int)(((byte)(254)))));
            this.btnDoEdit.Image = global::Project.Properties.Resources.reload_sm;
            this.btnDoEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDoEdit.Location = new System.Drawing.Point(860, 266);
            this.btnDoEdit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDoEdit.Name = "btnDoEdit";
            this.btnDoEdit.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnDoEdit.Size = new System.Drawing.Size(143, 49);
            this.btnDoEdit.TabIndex = 23;
            this.btnDoEdit.Text = "  Cập nhật";
            this.btnDoEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDoEdit.UseVisualStyleBackColor = false;
            this.btnDoEdit.Click += new System.EventHandler(this.btnDoEdit_Click);
            // 
            // btnDoAdd
            // 
            this.btnDoAdd.BackColor = System.Drawing.Color.White;
            this.btnDoAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDoAdd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(174)))), ((int)(((byte)(254)))));
            this.btnDoAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(248)))), ((int)(((byte)(220)))));
            this.btnDoAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(248)))), ((int)(((byte)(220)))));
            this.btnDoAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDoAdd.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDoAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(174)))), ((int)(((byte)(254)))));
            this.btnDoAdd.Image = global::Project.Properties.Resources.plus_sm;
            this.btnDoAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDoAdd.Location = new System.Drawing.Point(860, 266);
            this.btnDoAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDoAdd.Name = "btnDoAdd";
            this.btnDoAdd.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnDoAdd.Size = new System.Drawing.Size(143, 49);
            this.btnDoAdd.TabIndex = 22;
            this.btnDoAdd.Text = " Thêm mới";
            this.btnDoAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDoAdd.UseVisualStyleBackColor = false;
            this.btnDoAdd.Click += new System.EventHandler(this.btnDoAdd_Click);
            // 
            // rdFemale
            // 
            this.rdFemale.AutoSize = true;
            this.rdFemale.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rdFemale.Location = new System.Drawing.Point(860, 132);
            this.rdFemale.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdFemale.Name = "rdFemale";
            this.rdFemale.Size = new System.Drawing.Size(52, 23);
            this.rdFemale.TabIndex = 18;
            this.rdFemale.TabStop = true;
            this.rdFemale.Text = "Nữ";
            this.rdFemale.UseVisualStyleBackColor = true;
            // 
            // rdMale
            // 
            this.rdMale.AutoSize = true;
            this.rdMale.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(174)))), ((int)(((byte)(254)))));
            this.rdMale.FlatAppearance.BorderSize = 0;
            this.rdMale.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(174)))), ((int)(((byte)(254)))));
            this.rdMale.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(174)))), ((int)(((byte)(254)))));
            this.rdMale.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(174)))), ((int)(((byte)(254)))));
            this.rdMale.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rdMale.Location = new System.Drawing.Point(766, 132);
            this.rdMale.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdMale.Name = "rdMale";
            this.rdMale.Size = new System.Drawing.Size(70, 23);
            this.rdMale.TabIndex = 17;
            this.rdMale.TabStop = true;
            this.rdMale.Text = "Nam";
            this.rdMale.UseVisualStyleBackColor = true;
            this.rdMale.CheckedChanged += new System.EventHandler(this.rdMale_CheckedChanged);
            // 
            // cboDepartment
            // 
            this.cboDepartment.ForeColor = System.Drawing.Color.DimGray;
            this.cboDepartment.FormattingEnabled = true;
            this.cboDepartment.Location = new System.Drawing.Point(755, 61);
            this.cboDepartment.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboDepartment.Name = "cboDepartment";
            this.cboDepartment.Size = new System.Drawing.Size(203, 29);
            this.cboDepartment.TabIndex = 16;
            // 
            // txtPhone
            // 
            this.txtPhone.BackColor = System.Drawing.Color.White;
            this.txtPhone.CausesValidation = false;
            this.txtPhone.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtPhone.ForeColor = System.Drawing.Color.DimGray;
            this.txtPhone.Location = new System.Drawing.Point(755, 197);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(203, 29);
            this.txtPhone.TabIndex = 14;
            // 
            // txtAddress
            // 
            this.txtAddress.BackColor = System.Drawing.Color.White;
            this.txtAddress.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtAddress.ForeColor = System.Drawing.Color.DimGray;
            this.txtAddress.Location = new System.Drawing.Point(238, 262);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(263, 29);
            this.txtAddress.TabIndex = 13;
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.White;
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtName.ForeColor = System.Drawing.Color.DimGray;
            this.txtName.Location = new System.Drawing.Point(238, 129);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(263, 29);
            this.txtName.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(174)))), ((int)(((byte)(254)))));
            this.label7.Location = new System.Drawing.Point(630, 133);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 23);
            this.label7.TabIndex = 9;
            this.label7.Text = "Giới tính";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(174)))), ((int)(((byte)(254)))));
            this.label8.Location = new System.Drawing.Point(630, 69);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 23);
            this.label8.TabIndex = 10;
            this.label8.Text = "Khoa";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(174)))), ((int)(((byte)(254)))));
            this.label5.Location = new System.Drawing.Point(102, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 23);
            this.label5.TabIndex = 7;
            this.label5.Text = "Ngày sinh";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(174)))), ((int)(((byte)(254)))));
            this.label9.Location = new System.Drawing.Point(102, 266);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 23);
            this.label9.TabIndex = 11;
            this.label9.Text = "Địa chỉ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(174)))), ((int)(((byte)(254)))));
            this.label4.Location = new System.Drawing.Point(102, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "Họ tên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(125)))), ((int)(((byte)(240)))));
            this.label1.Location = new System.Drawing.Point(42, -4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(329, 34);
            this.label1.TabIndex = 1;
            this.label1.Text = "STUDENT INFORMATION";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(174)))), ((int)(((byte)(254)))));
            this.label3.Location = new System.Drawing.Point(102, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mã số";
            // 
            // txtCode
            // 
            this.txtCode.BackColor = System.Drawing.Color.White;
            this.txtCode.CausesValidation = false;
            this.txtCode.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtCode.ForeColor = System.Drawing.Color.DimGray;
            this.txtCode.Location = new System.Drawing.Point(238, 60);
            this.txtCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(163, 29);
            this.txtCode.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(174)))), ((int)(((byte)(254)))));
            this.label6.Location = new System.Drawing.Point(630, 197);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 23);
            this.label6.TabIndex = 8;
            this.label6.Text = "Điện thoại";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.White;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(248)))), ((int)(((byte)(220)))));
            this.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(248)))), ((int)(((byte)(220)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(174)))), ((int)(((byte)(254)))));
            this.btnAdd.Image = global::Project.Properties.Resources.student;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(1271, 49);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Padding = new System.Windows.Forms.Padding(23, 0, 0, 0);
            this.btnAdd.Size = new System.Drawing.Size(210, 60);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "   Thêm mới";
            this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgStudent
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dgStudent.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgStudent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgStudent.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgStudent.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgStudent.Location = new System.Drawing.Point(129, 520);
            this.dgStudent.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgStudent.Name = "dgStudent";
            this.dgStudent.RowHeadersWidth = 51;
            this.dgStudent.RowTemplate.Height = 25;
            this.dgStudent.Size = new System.Drawing.Size(1352, 420);
            this.dgStudent.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(125)))), ((int)(((byte)(240)))));
            this.label2.Location = new System.Drawing.Point(129, 410);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 34);
            this.label2.TabIndex = 3;
            this.label2.Text = "STUDENT LIST";
            // 
            // cboDepartmentSearch
            // 
            this.cboDepartmentSearch.CausesValidation = false;
            this.cboDepartmentSearch.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cboDepartmentSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(174)))), ((int)(((byte)(254)))));
            this.cboDepartmentSearch.FormattingEnabled = true;
            this.cboDepartmentSearch.Location = new System.Drawing.Point(447, 466);
            this.cboDepartmentSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboDepartmentSearch.Name = "cboDepartmentSearch";
            this.cboDepartmentSearch.Size = new System.Drawing.Size(198, 29);
            this.cboDepartmentSearch.TabIndex = 17;
            this.cboDepartmentSearch.SelectedIndexChanged += new System.EventHandler(this.Search_ValueChanged);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(129, 465);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PlaceholderText = " Tìm mã sv,  tên sv, địa chỉ, SĐT";
            this.txtSearch.Size = new System.Drawing.Size(264, 30);
            this.txtSearch.TabIndex = 18;
            this.txtSearch.TextChanged += new System.EventHandler(this.Search_ValueChanged);
            // 
            // cboGenderSearch
            // 
            this.cboGenderSearch.CausesValidation = false;
            this.cboGenderSearch.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cboGenderSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(174)))), ((int)(((byte)(254)))));
            this.cboGenderSearch.FormattingEnabled = true;
            this.cboGenderSearch.Items.AddRange(new object[] {
            " Tất cả giới tính",
            " Nam",
            " Nữ"});
            this.cboGenderSearch.Location = new System.Drawing.Point(700, 466);
            this.cboGenderSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboGenderSearch.Name = "cboGenderSearch";
            this.cboGenderSearch.Size = new System.Drawing.Size(162, 29);
            this.cboGenderSearch.TabIndex = 19;
            this.cboGenderSearch.SelectedValueChanged += new System.EventHandler(this.Search_ValueChanged);
            // 
            // btnExportExcel
            // 
            this.btnExportExcel.BackColor = System.Drawing.Color.White;
            this.btnExportExcel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExportExcel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(174)))), ((int)(((byte)(254)))));
            this.btnExportExcel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(248)))), ((int)(((byte)(220)))));
            this.btnExportExcel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(248)))), ((int)(((byte)(220)))));
            this.btnExportExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportExcel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnExportExcel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(174)))), ((int)(((byte)(254)))));
            this.btnExportExcel.Image = global::Project.Properties.Resources.excel;
            this.btnExportExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExportExcel.Location = new System.Drawing.Point(1339, 412);
            this.btnExportExcel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnExportExcel.Name = "btnExportExcel";
            this.btnExportExcel.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnExportExcel.Size = new System.Drawing.Size(142, 40);
            this.btnExportExcel.TabIndex = 27;
            this.btnExportExcel.Text = "  Xuất Excel";
            this.btnExportExcel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExportExcel.UseVisualStyleBackColor = false;
            this.btnExportExcel.Click += new System.EventHandler(this.btnExportExcel_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.btnAdd);
            this.panel4.Controls.Add(this.btnEdit);
            this.panel4.Controls.Add(this.btnDelete);
            this.panel4.Controls.Add(this.cboSort);
            this.panel4.Controls.Add(this.btnExportExcel);
            this.panel4.Controls.Add(this.cboGenderSearch);
            this.panel4.Controls.Add(this.txtSearch);
            this.panel4.Controls.Add(this.cboDepartmentSearch);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.dgStudent);
            this.panel4.Controls.Add(this.gbInfo);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1582, 953);
            this.panel4.TabIndex = 3;
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.White;
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(248)))), ((int)(((byte)(220)))));
            this.btnEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(248)))), ((int)(((byte)(220)))));
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEdit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(174)))), ((int)(((byte)(254)))));
            this.btnEdit.Image = global::Project.Properties.Resources.writing;
            this.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEdit.Location = new System.Drawing.Point(1271, 134);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Padding = new System.Windows.Forms.Padding(23, 0, 0, 0);
            this.btnEdit.Size = new System.Drawing.Size(210, 60);
            this.btnEdit.TabIndex = 8;
            this.btnEdit.Text = "   Chỉnh sửa";
            this.btnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.White;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(248)))), ((int)(((byte)(220)))));
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(248)))), ((int)(((byte)(220)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(174)))), ((int)(((byte)(254)))));
            this.btnDelete.Image = global::Project.Properties.Resources.paint_roller;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(1271, 219);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Padding = new System.Windows.Forms.Padding(23, 0, 0, 0);
            this.btnDelete.Size = new System.Drawing.Size(210, 60);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "   Xóa";
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // cboSort
            // 
            this.cboSort.CausesValidation = false;
            this.cboSort.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cboSort.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(174)))), ((int)(((byte)(254)))));
            this.cboSort.FormattingEnabled = true;
            this.cboSort.Items.AddRange(new object[] {
            " ID tăng dần",
            " ID giảm dần",
            " Tên A - Z",
            " Tên Z - A"});
            this.cboSort.Location = new System.Drawing.Point(1327, 465);
            this.cboSort.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboSort.Name = "cboSort";
            this.cboSort.Size = new System.Drawing.Size(154, 29);
            this.cboSort.TabIndex = 28;
            this.cboSort.SelectedIndexChanged += new System.EventHandler(this.Search_ValueChanged);
            // 
            // Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1582, 953);
            this.Controls.Add(this.panel4);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Student";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Student";
            this.Load += new System.EventHandler(this.Student_Load);
            this.gbInfo.ResumeLayout(false);
            this.gbInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgStudent)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private GroupBox gbInfo;
        private Button btnDoDelete;
        private DateTimePicker dtpDOB;
        private Button btnDoEdit;
        private Button btnDoAdd;
        private RadioButton rdFemale;
        private RadioButton rdMale;
        private ComboBox cboDepartment;
        private TextBox txtPhone;
        private TextBox txtAddress;
        private TextBox txtName;
        private Label label7;
        private Label label8;
        private Label label5;
        private Label label9;
        private Label label4;
        private Label label1;
        private Label label3;
        private TextBox txtCode;
        private Label label6;
        private DataGridView dgStudent;
        private Label label2;
        private ComboBox cboDepartmentSearch;
        private TextBox txtSearch;
        private ComboBox cboGenderSearch;
        private Button btnExportExcel;
        private Panel panel4;
        private ComboBox cboSort;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnDelete;
    }
}
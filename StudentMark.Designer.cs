namespace Project
{
    partial class StudentMark
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgMark = new System.Windows.Forms.DataGridView();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboStudentCode = new System.Windows.Forms.ComboBox();
            this.txtAverage = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnExportExcel = new System.Windows.Forms.Button();
            this.cboDepartment = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgMark)).BeginInit();
            this.SuspendLayout();
            // 
            // dgMark
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dgMark.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgMark.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgMark.BackgroundColor = System.Drawing.Color.White;
            this.dgMark.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgMark.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMark.Location = new System.Drawing.Point(161, 366);
            this.dgMark.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgMark.Name = "dgMark";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgMark.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgMark.RowHeadersWidth = 51;
            this.dgMark.RowTemplate.Height = 25;
            this.dgMark.Size = new System.Drawing.Size(996, 532);
            this.dgMark.TabIndex = 3;
            // 
            // txtStudentName
            // 
            this.txtStudentName.BackColor = System.Drawing.Color.White;
            this.txtStudentName.Enabled = false;
            this.txtStudentName.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtStudentName.ForeColor = System.Drawing.Color.DimGray;
            this.txtStudentName.Location = new System.Drawing.Point(375, 180);
            this.txtStudentName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(263, 31);
            this.txtStudentName.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(195, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 25);
            this.label4.TabIndex = 15;
            this.label4.Text = "TÊN SINH VIÊN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(195, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 25);
            this.label3.TabIndex = 13;
            this.label3.Text = "MÃ SINH VIÊN";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(195, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 25);
            this.label1.TabIndex = 17;
            this.label1.Text = "KHOA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(255)))), ((int)(((byte)(220)))));
            this.label2.Location = new System.Drawing.Point(161, 286);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(234, 39);
            this.label2.TabIndex = 19;
            this.label2.Text = "MARK REPORT";
            // 
            // cboStudentCode
            // 
            this.cboStudentCode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboStudentCode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboStudentCode.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cboStudentCode.ForeColor = System.Drawing.Color.DimGray;
            this.cboStudentCode.FormattingEnabled = true;
            this.cboStudentCode.Location = new System.Drawing.Point(375, 123);
            this.cboStudentCode.Name = "cboStudentCode";
            this.cboStudentCode.Size = new System.Drawing.Size(263, 33);
            this.cboStudentCode.TabIndex = 32;
            this.cboStudentCode.SelectedValueChanged += new System.EventHandler(this.cboStudentCode_SelectedValueChanged);
            // 
            // txtAverage
            // 
            this.txtAverage.BackColor = System.Drawing.Color.White;
            this.txtAverage.Enabled = false;
            this.txtAverage.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtAverage.ForeColor = System.Drawing.Color.DimGray;
            this.txtAverage.Location = new System.Drawing.Point(1402, 375);
            this.txtAverage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAverage.Name = "txtAverage";
            this.txtAverage.Size = new System.Drawing.Size(105, 31);
            this.txtAverage.TabIndex = 34;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(1198, 375);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(177, 25);
            this.label5.TabIndex = 33;
            this.label5.Text = "ĐIỂM TRUNG BÌNH";
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
            this.btnExportExcel.Location = new System.Drawing.Point(1015, 292);
            this.btnExportExcel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnExportExcel.Name = "btnExportExcel";
            this.btnExportExcel.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnExportExcel.Size = new System.Drawing.Size(142, 40);
            this.btnExportExcel.TabIndex = 35;
            this.btnExportExcel.Text = " Xuất Excel";
            this.btnExportExcel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExportExcel.UseVisualStyleBackColor = false;
            this.btnExportExcel.Click += new System.EventHandler(this.btnExportExcel_Click);
            // 
            // cboDepartment
            // 
            this.cboDepartment.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboDepartment.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboDepartment.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cboDepartment.ForeColor = System.Drawing.Color.DimGray;
            this.cboDepartment.FormattingEnabled = true;
            this.cboDepartment.Location = new System.Drawing.Point(375, 64);
            this.cboDepartment.Name = "cboDepartment";
            this.cboDepartment.Size = new System.Drawing.Size(263, 33);
            this.cboDepartment.TabIndex = 36;
            this.cboDepartment.SelectedValueChanged += new System.EventHandler(this.cboDepartment_SelectedValueChanged);
            // 
            // StudentMark
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Project.Properties.Resources.background71;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1582, 953);
            this.Controls.Add(this.cboDepartment);
            this.Controls.Add(this.btnExportExcel);
            this.Controls.Add(this.txtAverage);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cboStudentCode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtStudentName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgMark);
            this.Name = "StudentMark";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StudentMark";
            this.Load += new System.EventHandler(this.StudentMark_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgMark)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgMark;
        private TextBox txtStudentName;
        private Label label4;
        private Label label3;
        private Label label1;
        private Label label2;
        private ComboBox cboStudentCode;
        private TextBox txtAverage;
        private Label label5;
        private Button btnExportExcel;
        private ComboBox cboDepartment;
    }
}
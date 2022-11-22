namespace Project
{
    partial class InputMark
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.txtSubjectName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnDoAdd = new System.Windows.Forms.Button();
            this.gbInfor = new System.Windows.Forms.GroupBox();
            this.numMark = new System.Windows.Forms.NumericUpDown();
            this.cboSubjectCode = new System.Windows.Forms.ComboBox();
            this.cboStudentCode = new System.Windows.Forms.ComboBox();
            this.btnDoDelete = new System.Windows.Forms.Button();
            this.dgMark = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.gbInfor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMark)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgMark)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(72, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 23);
            this.label3.TabIndex = 17;
            this.label3.Text = "Mã sinh viên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(72, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 23);
            this.label4.TabIndex = 19;
            this.label4.Text = "Họ tên";
            // 
            // txtStudentName
            // 
            this.txtStudentName.BackColor = System.Drawing.Color.White;
            this.txtStudentName.Enabled = false;
            this.txtStudentName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtStudentName.ForeColor = System.Drawing.Color.DimGray;
            this.txtStudentName.Location = new System.Drawing.Point(212, 101);
            this.txtStudentName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(321, 29);
            this.txtStudentName.TabIndex = 20;
            // 
            // txtSubjectName
            // 
            this.txtSubjectName.BackColor = System.Drawing.Color.White;
            this.txtSubjectName.Enabled = false;
            this.txtSubjectName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtSubjectName.ForeColor = System.Drawing.Color.DimGray;
            this.txtSubjectName.Location = new System.Drawing.Point(212, 215);
            this.txtSubjectName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSubjectName.Name = "txtSubjectName";
            this.txtSubjectName.Size = new System.Drawing.Size(362, 29);
            this.txtSubjectName.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(72, 218);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 23);
            this.label1.TabIndex = 26;
            this.label1.Text = "Tên môn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(72, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 23);
            this.label2.TabIndex = 24;
            this.label2.Text = "Mã môn";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(72, 277);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 23);
            this.label5.TabIndex = 28;
            this.label5.Text = "Điểm";
            // 
            // btnDoAdd
            // 
            this.btnDoAdd.BackColor = System.Drawing.Color.White;
            this.btnDoAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDoAdd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(174)))), ((int)(((byte)(254)))));
            this.btnDoAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnDoAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnDoAdd.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDoAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(174)))), ((int)(((byte)(254)))));
            this.btnDoAdd.Image = global::Project.Properties.Resources.pen;
            this.btnDoAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDoAdd.Location = new System.Drawing.Point(746, 369);
            this.btnDoAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDoAdd.Name = "btnDoAdd";
            this.btnDoAdd.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnDoAdd.Size = new System.Drawing.Size(145, 49);
            this.btnDoAdd.TabIndex = 30;
            this.btnDoAdd.Text = " Nhập điểm";
            this.btnDoAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDoAdd.UseVisualStyleBackColor = false;
            this.btnDoAdd.Click += new System.EventHandler(this.btnDoAdd_Click);
            // 
            // gbInfor
            // 
            this.gbInfor.BackColor = System.Drawing.Color.Transparent;
            this.gbInfor.Controls.Add(this.numMark);
            this.gbInfor.Controls.Add(this.cboSubjectCode);
            this.gbInfor.Controls.Add(this.cboStudentCode);
            this.gbInfor.Controls.Add(this.label5);
            this.gbInfor.Controls.Add(this.label3);
            this.gbInfor.Controls.Add(this.txtSubjectName);
            this.gbInfor.Controls.Add(this.label1);
            this.gbInfor.Controls.Add(this.label4);
            this.gbInfor.Controls.Add(this.label2);
            this.gbInfor.Controls.Add(this.txtStudentName);
            this.gbInfor.Location = new System.Drawing.Point(210, 38);
            this.gbInfor.Name = "gbInfor";
            this.gbInfor.Size = new System.Drawing.Size(731, 352);
            this.gbInfor.TabIndex = 31;
            this.gbInfor.TabStop = false;
            // 
            // numMark
            // 
            this.numMark.CausesValidation = false;
            this.numMark.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.numMark.ForeColor = System.Drawing.Color.DimGray;
            this.numMark.Location = new System.Drawing.Point(212, 277);
            this.numMark.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numMark.Name = "numMark";
            this.numMark.Size = new System.Drawing.Size(206, 29);
            this.numMark.TabIndex = 32;
            // 
            // cboSubjectCode
            // 
            this.cboSubjectCode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboSubjectCode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboSubjectCode.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cboSubjectCode.ForeColor = System.Drawing.Color.DimGray;
            this.cboSubjectCode.FormattingEnabled = true;
            this.cboSubjectCode.Location = new System.Drawing.Point(212, 158);
            this.cboSubjectCode.Name = "cboSubjectCode";
            this.cboSubjectCode.Size = new System.Drawing.Size(206, 29);
            this.cboSubjectCode.TabIndex = 31;
            this.cboSubjectCode.SelectedValueChanged += new System.EventHandler(this.cboSubjectCode_SelectedValueChanged);
            // 
            // cboStudentCode
            // 
            this.cboStudentCode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboStudentCode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboStudentCode.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cboStudentCode.ForeColor = System.Drawing.Color.DimGray;
            this.cboStudentCode.FormattingEnabled = true;
            this.cboStudentCode.Location = new System.Drawing.Point(212, 48);
            this.cboStudentCode.Name = "cboStudentCode";
            this.cboStudentCode.Size = new System.Drawing.Size(206, 29);
            this.cboStudentCode.TabIndex = 30;
            this.cboStudentCode.SelectedValueChanged += new System.EventHandler(this.cboStudentCode_SelectedValueChanged);
            // 
            // btnDoDelete
            // 
            this.btnDoDelete.BackColor = System.Drawing.Color.White;
            this.btnDoDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDoDelete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(174)))), ((int)(((byte)(254)))));
            this.btnDoDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(248)))), ((int)(((byte)(220)))));
            this.btnDoDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(248)))), ((int)(((byte)(220)))));
            this.btnDoDelete.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDoDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(174)))), ((int)(((byte)(254)))));
            this.btnDoDelete.Image = global::Project.Properties.Resources.eraser;
            this.btnDoDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDoDelete.Location = new System.Drawing.Point(778, 369);
            this.btnDoDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDoDelete.Name = "btnDoDelete";
            this.btnDoDelete.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnDoDelete.Size = new System.Drawing.Size(113, 49);
            this.btnDoDelete.TabIndex = 34;
            this.btnDoDelete.Text = "   Xóa";
            this.btnDoDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDoDelete.UseVisualStyleBackColor = false;
            this.btnDoDelete.Click += new System.EventHandler(this.btnDoDelete_Click);
            // 
            // dgMark
            // 
            this.dgMark.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgMark.BackgroundColor = System.Drawing.Color.White;
            this.dgMark.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMark.Location = new System.Drawing.Point(210, 542);
            this.dgMark.Name = "dgMark";
            this.dgMark.RowHeadersWidth = 51;
            this.dgMark.RowTemplate.Height = 29;
            this.dgMark.Size = new System.Drawing.Size(980, 387);
            this.dgMark.TabIndex = 35;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(255)))), ((int)(((byte)(220)))));
            this.label6.Location = new System.Drawing.Point(210, 467);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(259, 40);
            this.label6.TabIndex = 36;
            this.label6.Text = "STUDENT MARK";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.White;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(248)))), ((int)(((byte)(220)))));
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(248)))), ((int)(((byte)(220)))));
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(174)))), ((int)(((byte)(254)))));
            this.btnDelete.Image = global::Project.Properties.Resources.paint_roller;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(980, 179);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Padding = new System.Windows.Forms.Padding(23, 0, 0, 0);
            this.btnDelete.Size = new System.Drawing.Size(210, 60);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "   Xóa điểm";
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.White;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(248)))), ((int)(((byte)(220)))));
            this.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(248)))), ((int)(((byte)(220)))));
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(174)))), ((int)(((byte)(254)))));
            this.btnAdd.Image = global::Project.Properties.Resources.ball_pen;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(980, 86);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Padding = new System.Windows.Forms.Padding(23, 0, 0, 0);
            this.btnAdd.Size = new System.Drawing.Size(210, 60);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "   Nhập điểm";
            this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // InputMark
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Project.Properties.Resources.background4;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1582, 953);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgMark);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnDoDelete);
            this.Controls.Add(this.btnDoAdd);
            this.Controls.Add(this.gbInfor);
            this.DoubleBuffered = true;
            this.Name = "InputMark";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Input Mark";
            this.Load += new System.EventHandler(this.InputMark_Load);
            this.gbInfor.ResumeLayout(false);
            this.gbInfor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMark)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgMark)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label3;
        private Label label4;
        private TextBox txtStudentName;
        private TextBox txtSubjectName;
        private Label label1;
        private Label label2;
        private Label label5;
        private Button btnDoAdd;
        private GroupBox gbInfor;
        private ComboBox cboSubjectCode;
        private ComboBox cboStudentCode;
        private NumericUpDown numMark;
        private Button btnDoDelete;
        private DataGridView dgMark;
        private Label label6;
        private Button btnDelete;
        private Button btnAdd;
    }
}
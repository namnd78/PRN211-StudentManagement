namespace Project
{
    partial class Subject
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnExportExcel = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgSubject = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDoDelete = new System.Windows.Forms.Button();
            this.numSlot = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.btnDoEdit = new System.Windows.Forms.Button();
            this.btnDoAdd = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSubject)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSlot)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.btnAdd);
            this.panel4.Controls.Add(this.btnEdit);
            this.panel4.Controls.Add(this.btnDelete);
            this.panel4.Controls.Add(this.btnExportExcel);
            this.panel4.Controls.Add(this.txtSearch);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.dgSubject);
            this.panel4.Controls.Add(this.groupBox1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1582, 953);
            this.panel4.TabIndex = 7;
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
            this.btnAdd.Location = new System.Drawing.Point(975, 73);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Padding = new System.Windows.Forms.Padding(23, 0, 0, 0);
            this.btnAdd.Size = new System.Drawing.Size(210, 60);
            this.btnAdd.TabIndex = 30;
            this.btnAdd.Text = "   Thêm mới";
            this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
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
            this.btnEdit.Location = new System.Drawing.Point(975, 158);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Padding = new System.Windows.Forms.Padding(23, 0, 0, 0);
            this.btnEdit.Size = new System.Drawing.Size(210, 60);
            this.btnEdit.TabIndex = 31;
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
            this.btnDelete.Location = new System.Drawing.Point(975, 243);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Padding = new System.Windows.Forms.Padding(23, 0, 0, 0);
            this.btnDelete.Size = new System.Drawing.Size(210, 60);
            this.btnDelete.TabIndex = 32;
            this.btnDelete.Text = "   Xóa";
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
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
            this.btnExportExcel.Location = new System.Drawing.Point(1093, 398);
            this.btnExportExcel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnExportExcel.Name = "btnExportExcel";
            this.btnExportExcel.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnExportExcel.Size = new System.Drawing.Size(142, 40);
            this.btnExportExcel.TabIndex = 29;
            this.btnExportExcel.Text = " Xuất Excel";
            this.btnExportExcel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExportExcel.UseVisualStyleBackColor = false;
            this.btnExportExcel.Click += new System.EventHandler(this.btnExportExcel_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(139, 406);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PlaceholderText = " Tìm mã môn, tên môn";
            this.txtSearch.Size = new System.Drawing.Size(244, 30);
            this.txtSearch.TabIndex = 19;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(125)))), ((int)(((byte)(240)))));
            this.label2.Location = new System.Drawing.Point(139, 358);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 34);
            this.label2.TabIndex = 3;
            this.label2.Text = "SUBJECT LIST";
            // 
            // dgSubject
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dgSubject.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgSubject.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgSubject.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgSubject.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgSubject.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSubject.Location = new System.Drawing.Point(139, 451);
            this.dgSubject.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgSubject.Name = "dgSubject";
            this.dgSubject.RowHeadersWidth = 51;
            this.dgSubject.RowTemplate.Height = 25;
            this.dgSubject.Size = new System.Drawing.Size(1096, 441);
            this.dgSubject.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDoDelete);
            this.groupBox1.Controls.Add(this.numSlot);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btnDoEdit);
            this.groupBox1.Controls.Add(this.btnDoAdd);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtCode);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(174)))), ((int)(((byte)(254)))));
            this.groupBox1.Location = new System.Drawing.Point(139, 58);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(704, 260);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
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
            this.btnDoDelete.Location = new System.Drawing.Point(533, 185);
            this.btnDoDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDoDelete.Name = "btnDoDelete";
            this.btnDoDelete.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnDoDelete.Size = new System.Drawing.Size(113, 49);
            this.btnDoDelete.TabIndex = 28;
            this.btnDoDelete.Text = "   Xóa";
            this.btnDoDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDoDelete.UseVisualStyleBackColor = false;
            this.btnDoDelete.Click += new System.EventHandler(this.btnDoDelete_Click);
            // 
            // numSlot
            // 
            this.numSlot.CausesValidation = false;
            this.numSlot.ForeColor = System.Drawing.Color.DimGray;
            this.numSlot.Location = new System.Drawing.Point(496, 72);
            this.numSlot.Name = "numSlot";
            this.numSlot.Size = new System.Drawing.Size(150, 29);
            this.numSlot.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(174)))), ((int)(((byte)(254)))));
            this.label5.Location = new System.Drawing.Point(395, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 23);
            this.label5.TabIndex = 22;
            this.label5.Text = "Số tiết";
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
            this.btnDoEdit.Location = new System.Drawing.Point(503, 185);
            this.btnDoEdit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDoEdit.Name = "btnDoEdit";
            this.btnDoEdit.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnDoEdit.Size = new System.Drawing.Size(143, 49);
            this.btnDoEdit.TabIndex = 21;
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
            this.btnDoAdd.Location = new System.Drawing.Point(503, 185);
            this.btnDoAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDoAdd.Name = "btnDoAdd";
            this.btnDoAdd.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnDoAdd.Size = new System.Drawing.Size(143, 49);
            this.btnDoAdd.TabIndex = 20;
            this.btnDoAdd.Text = " Thêm mới";
            this.btnDoAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDoAdd.UseVisualStyleBackColor = false;
            this.btnDoAdd.Click += new System.EventHandler(this.btnDoAdd_Click);
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.White;
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtName.ForeColor = System.Drawing.Color.DimGray;
            this.txtName.Location = new System.Drawing.Point(164, 135);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(197, 29);
            this.txtName.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(174)))), ((int)(((byte)(254)))));
            this.label4.Location = new System.Drawing.Point(42, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tên môn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(125)))), ((int)(((byte)(240)))));
            this.label1.Location = new System.Drawing.Point(42, -3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(327, 34);
            this.label1.TabIndex = 1;
            this.label1.Text = "SUBJECT INFORMATION";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(174)))), ((int)(((byte)(254)))));
            this.label3.Location = new System.Drawing.Point(42, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mã môn";
            // 
            // txtCode
            // 
            this.txtCode.BackColor = System.Drawing.Color.White;
            this.txtCode.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtCode.ForeColor = System.Drawing.Color.DimGray;
            this.txtCode.Location = new System.Drawing.Point(164, 66);
            this.txtCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(163, 29);
            this.txtCode.TabIndex = 5;
            // 
            // Subject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1582, 953);
            this.Controls.Add(this.panel4);
            this.Name = "Subject";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Subject";
            this.Load += new System.EventHandler(this.Subject_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSubject)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSlot)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel4;
        private Label label2;
        private DataGridView dgSubject;
        private GroupBox groupBox1;
        private NumericUpDown numSlot;
        private Label label5;
        private Button btnDoEdit;
        private Button btnDoAdd;
        private TextBox txtName;
        private Label label4;
        private Label label1;
        private Label label3;
        private TextBox txtCode;
        private Button btnDoDelete;
        private TextBox txtSearch;
        private Button btnExportExcel;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnDelete;
    }
}
namespace GUI
{
    partial class fInfoNhomND
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.siticoneBorderlessForm1 = new Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm(this.components);
            this.siticonePanel1 = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.butChange = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.dsChucNang = new Siticone.Desktop.UI.WinForms.SiticoneDataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maChucNangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenChucNangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenManHinhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nHOMNGUOIDUNGsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cHUCNANGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.labelMaNhom = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelTenNhom = new System.Windows.Forms.Label();
            this.siticonePictureBox1 = new Siticone.Desktop.UI.WinForms.SiticonePictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.topPanel = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.exitControlBox = new Siticone.Desktop.UI.WinForms.SiticoneControlBox();
            this.siticoneControlBox1 = new Siticone.Desktop.UI.WinForms.SiticoneControlBox();
            this.siticonePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsChucNang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cHUCNANGBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.siticonePictureBox1)).BeginInit();
            this.topPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // siticoneBorderlessForm1
            // 
            this.siticoneBorderlessForm1.ContainerControl = this;
            this.siticoneBorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.siticoneBorderlessForm1.TransparentWhileDrag = true;
            // 
            // siticonePanel1
            // 
            this.siticonePanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(241)))), ((int)(((byte)(255)))));
            this.siticonePanel1.BorderColor = System.Drawing.Color.Azure;
            this.siticonePanel1.BorderThickness = 2;
            this.siticonePanel1.Controls.Add(this.butChange);
            this.siticonePanel1.Controls.Add(this.dsChucNang);
            this.siticonePanel1.Controls.Add(this.label1);
            this.siticonePanel1.Controls.Add(this.labelMaNhom);
            this.siticonePanel1.Controls.Add(this.label2);
            this.siticonePanel1.Controls.Add(this.labelTenNhom);
            this.siticonePanel1.Location = new System.Drawing.Point(59, 101);
            this.siticonePanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.siticonePanel1.Name = "siticonePanel1";
            this.siticonePanel1.Size = new System.Drawing.Size(696, 571);
            this.siticonePanel1.TabIndex = 14;
            // 
            // butChange
            // 
            this.butChange.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.butChange.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.butChange.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.butChange.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.butChange.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.butChange.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(101)))), ((int)(((byte)(192)))));
            this.butChange.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butChange.ForeColor = System.Drawing.Color.White;
            this.butChange.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.butChange.Location = new System.Drawing.Point(265, 484);
            this.butChange.Name = "butChange";
            this.butChange.Size = new System.Drawing.Size(183, 54);
            this.butChange.TabIndex = 30;
            this.butChange.Text = "Sửa thông tin";
            this.butChange.Click += new System.EventHandler(this.butChange_Click);
            // 
            // dsChucNang
            // 
            this.dsChucNang.AllowUserToAddRows = false;
            this.dsChucNang.AllowUserToDeleteRows = false;
            this.dsChucNang.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI Variable Display", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dsChucNang.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dsChucNang.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dsChucNang.AutoGenerateColumns = false;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(75)))), ((int)(((byte)(141)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI Variable Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dsChucNang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dsChucNang.ColumnHeadersHeight = 35;
            this.dsChucNang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dsChucNang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.maChucNangDataGridViewTextBoxColumn,
            this.tenChucNangDataGridViewTextBoxColumn,
            this.tenManHinhDataGridViewTextBoxColumn,
            this.nHOMNGUOIDUNGsDataGridViewTextBoxColumn});
            this.dsChucNang.DataSource = this.cHUCNANGBindingSource;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI Variable Display", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dsChucNang.DefaultCellStyle = dataGridViewCellStyle9;
            this.dsChucNang.GridColor = System.Drawing.Color.Azure;
            this.dsChucNang.Location = new System.Drawing.Point(78, 207);
            this.dsChucNang.Name = "dsChucNang";
            this.dsChucNang.ReadOnly = true;
            this.dsChucNang.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dsChucNang.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dsChucNang.RowHeadersVisible = false;
            this.dsChucNang.RowHeadersWidth = 51;
            this.dsChucNang.RowTemplate.Height = 30;
            this.dsChucNang.Size = new System.Drawing.Size(575, 257);
            this.dsChucNang.TabIndex = 29;
            this.dsChucNang.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dsChucNang.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dsChucNang.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dsChucNang.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dsChucNang.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dsChucNang.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dsChucNang.ThemeStyle.GridColor = System.Drawing.Color.Azure;
            this.dsChucNang.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(101)))), ((int)(((byte)(192)))));
            this.dsChucNang.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dsChucNang.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dsChucNang.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dsChucNang.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dsChucNang.ThemeStyle.HeaderStyle.Height = 35;
            this.dsChucNang.ThemeStyle.ReadOnly = true;
            this.dsChucNang.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dsChucNang.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dsChucNang.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dsChucNang.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dsChucNang.ThemeStyle.RowsStyle.Height = 30;
            this.dsChucNang.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.Azure;
            this.dsChucNang.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dsChucNang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dsChucNang_CellContentClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // maChucNangDataGridViewTextBoxColumn
            // 
            this.maChucNangDataGridViewTextBoxColumn.DataPropertyName = "MaChucNang";
            this.maChucNangDataGridViewTextBoxColumn.HeaderText = "Mã chức năng";
            this.maChucNangDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maChucNangDataGridViewTextBoxColumn.Name = "maChucNangDataGridViewTextBoxColumn";
            this.maChucNangDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tenChucNangDataGridViewTextBoxColumn
            // 
            this.tenChucNangDataGridViewTextBoxColumn.DataPropertyName = "TenChucNang";
            this.tenChucNangDataGridViewTextBoxColumn.HeaderText = "Tên chức năng";
            this.tenChucNangDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tenChucNangDataGridViewTextBoxColumn.Name = "tenChucNangDataGridViewTextBoxColumn";
            this.tenChucNangDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tenManHinhDataGridViewTextBoxColumn
            // 
            this.tenManHinhDataGridViewTextBoxColumn.DataPropertyName = "TenManHinh";
            this.tenManHinhDataGridViewTextBoxColumn.HeaderText = "Tên màn hình";
            this.tenManHinhDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tenManHinhDataGridViewTextBoxColumn.Name = "tenManHinhDataGridViewTextBoxColumn";
            this.tenManHinhDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nHOMNGUOIDUNGsDataGridViewTextBoxColumn
            // 
            this.nHOMNGUOIDUNGsDataGridViewTextBoxColumn.DataPropertyName = "NHOMNGUOIDUNGs";
            this.nHOMNGUOIDUNGsDataGridViewTextBoxColumn.HeaderText = "NHOMNGUOIDUNGs";
            this.nHOMNGUOIDUNGsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nHOMNGUOIDUNGsDataGridViewTextBoxColumn.Name = "nHOMNGUOIDUNGsDataGridViewTextBoxColumn";
            this.nHOMNGUOIDUNGsDataGridViewTextBoxColumn.ReadOnly = true;
            this.nHOMNGUOIDUNGsDataGridViewTextBoxColumn.Visible = false;
            // 
            // cHUCNANGBindingSource
            // 
            this.cHUCNANGBindingSource.DataSource = typeof(DTO.CHUCNANG);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Variable Display", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(101)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(70, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(538, 44);
            this.label1.TabIndex = 5;
            this.label1.Text = "THÔNG TIN NHÓM NGƯỜI DÙNG";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelMaNhom
            // 
            this.labelMaNhom.AutoSize = true;
            this.labelMaNhom.Font = new System.Drawing.Font("Segoe UI Variable Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMaNhom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(101)))), ((int)(((byte)(192)))));
            this.labelMaNhom.Location = new System.Drawing.Point(156, 89);
            this.labelMaNhom.Name = "labelMaNhom";
            this.labelMaNhom.Size = new System.Drawing.Size(223, 27);
            this.labelMaNhom.TabIndex = 28;
            this.labelMaNhom.Text = "Mã Nhóm Người Dùng: ";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Variable Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(101)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(251, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(248, 27);
            this.label2.TabIndex = 28;
            this.label2.Text = "DANH SÁCH CHỨC NĂNG";
            // 
            // labelTenNhom
            // 
            this.labelTenNhom.AutoSize = true;
            this.labelTenNhom.Font = new System.Drawing.Font("Segoe UI Variable Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTenNhom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(101)))), ((int)(((byte)(192)))));
            this.labelTenNhom.Location = new System.Drawing.Point(156, 126);
            this.labelTenNhom.Name = "labelTenNhom";
            this.labelTenNhom.Size = new System.Drawing.Size(224, 27);
            this.labelTenNhom.TabIndex = 28;
            this.labelTenNhom.Text = "Tên Nhóm Người Dùng: ";
            // 
            // siticonePictureBox1
            // 
            this.siticonePictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.siticonePictureBox1.Image = global::GUI.Properties.Resources.Logo_Trường_Đại_học_Sư_phạm_Thành_phố_Hồ_Chí_Minh4;
            this.siticonePictureBox1.ImageRotate = 0F;
            this.siticonePictureBox1.Location = new System.Drawing.Point(3, 9);
            this.siticonePictureBox1.Name = "siticonePictureBox1";
            this.siticonePictureBox1.Size = new System.Drawing.Size(143, 56);
            this.siticonePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.siticonePictureBox1.TabIndex = 5;
            this.siticonePictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(139, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(271, 48);
            this.label3.TabIndex = 4;
            this.label3.Text = "HCMUE LIBRARY";
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.White;
            this.topPanel.Controls.Add(this.siticonePictureBox1);
            this.topPanel.Controls.Add(this.label3);
            this.topPanel.Controls.Add(this.exitControlBox);
            this.topPanel.Controls.Add(this.siticoneControlBox1);
            this.topPanel.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(75)))), ((int)(((byte)(141)))));
            this.topPanel.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(75)))), ((int)(((byte)(141)))));
            this.topPanel.ForeColor = System.Drawing.Color.DimGray;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(811, 71);
            this.topPanel.TabIndex = 15;
            // 
            // exitControlBox
            // 
            this.exitControlBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exitControlBox.BackColor = System.Drawing.Color.Transparent;
            this.exitControlBox.FillColor = System.Drawing.Color.Transparent;
            this.exitControlBox.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.exitControlBox.IconColor = System.Drawing.Color.White;
            this.exitControlBox.Location = new System.Drawing.Point(725, 0);
            this.exitControlBox.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.exitControlBox.Name = "exitControlBox";
            this.exitControlBox.Size = new System.Drawing.Size(83, 66);
            this.exitControlBox.TabIndex = 0;
            // 
            // siticoneControlBox1
            // 
            this.siticoneControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.siticoneControlBox1.BackColor = System.Drawing.Color.Transparent;
            this.siticoneControlBox1.ControlBoxType = Siticone.Desktop.UI.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.siticoneControlBox1.FillColor = System.Drawing.Color.Transparent;
            this.siticoneControlBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.siticoneControlBox1.IconColor = System.Drawing.Color.White;
            this.siticoneControlBox1.Location = new System.Drawing.Point(647, 0);
            this.siticoneControlBox1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.siticoneControlBox1.Name = "siticoneControlBox1";
            this.siticoneControlBox1.Size = new System.Drawing.Size(79, 66);
            this.siticoneControlBox1.TabIndex = 0;
            // 
            // fInfoNhomND
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(75)))), ((int)(((byte)(141)))));
            this.ClientSize = new System.Drawing.Size(811, 710);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.siticonePanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fInfoNhomND";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fInfoNhomND";
            this.siticonePanel1.ResumeLayout(false);
            this.siticonePanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsChucNang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cHUCNANGBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.siticonePictureBox1)).EndInit();
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm siticoneBorderlessForm1;
        private Siticone.Desktop.UI.WinForms.SiticonePanel siticonePanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelMaNhom;
        private System.Windows.Forms.Label labelTenNhom;
        private Siticone.Desktop.UI.WinForms.SiticoneDataGridView dsChucNang;
        private System.Windows.Forms.BindingSource cHUCNANGBindingSource;
        private System.Windows.Forms.Label label2;
        private Siticone.Desktop.UI.WinForms.SiticoneButton butChange;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maChucNangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenChucNangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenManHinhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nHOMNGUOIDUNGsDataGridViewTextBoxColumn;
        private Siticone.Desktop.UI.WinForms.SiticonePanel topPanel;
        private Siticone.Desktop.UI.WinForms.SiticonePictureBox siticonePictureBox1;
        private System.Windows.Forms.Label label3;
        private Siticone.Desktop.UI.WinForms.SiticoneControlBox exitControlBox;
        private Siticone.Desktop.UI.WinForms.SiticoneControlBox siticoneControlBox1;
    }
}
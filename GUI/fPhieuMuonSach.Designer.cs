using System.Windows.Forms;

namespace GUI
{
    partial class fPhieuMuonSach
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
            this.siticonePanel1 = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.comboDocGia = new System.Windows.Forms.ComboBox();
            this.dOCGIABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboCuonSach = new System.Windows.Forms.ComboBox();
            this.cUONSACHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.siticoneVSeparator2 = new Siticone.Desktop.UI.WinForms.SiticoneVSeparator();
            this.siticoneVSeparator1 = new Siticone.Desktop.UI.WinForms.SiticoneVSeparator();
            this.siticoneSeparator2 = new Siticone.Desktop.UI.WinForms.SiticoneSeparator();
            this.butSave = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.label13 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dateNgayMuon = new Siticone.Desktop.UI.WinForms.SiticoneDateTimePicker();
            this.labelHanTra = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelTheLoai = new System.Windows.Forms.Label();
            this.labelTienPhat = new System.Windows.Forms.Label();
            this.labelTongNoHienTai = new System.Windows.Forms.Label();
            this.labelDonGiaPhat = new System.Windows.Forms.Label();
            this.labelTongNoMoi = new System.Windows.Forms.Label();
            this.labelSoNgayTre = new System.Windows.Forms.Label();
            this.labelHoTen = new System.Windows.Forms.Label();
            this.labelTenCS = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.siticoneControlBox1 = new Siticone.Desktop.UI.WinForms.SiticoneControlBox();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.siticoneDragControl1 = new Siticone.Desktop.UI.WinForms.SiticoneDragControl(this.components);
            this.ErrorDia = new Siticone.Desktop.UI.WinForms.SiticoneMessageDialog();
            this.SuccDia = new Siticone.Desktop.UI.WinForms.SiticoneMessageDialog();
            this.siticonePictureBox1 = new Siticone.Desktop.UI.WinForms.SiticonePictureBox();
            this.topPanel = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.siticoneControlBox2 = new Siticone.Desktop.UI.WinForms.SiticoneControlBox();
            this.siticoneControlBox3 = new Siticone.Desktop.UI.WinForms.SiticoneControlBox();
            this.siticonePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dOCGIABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cUONSACHBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.siticonePictureBox1)).BeginInit();
            this.topPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // siticonePanel1
            // 
            this.siticonePanel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.siticonePanel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(196)))), ((int)(((byte)(255)))));
            this.siticonePanel1.BorderThickness = 2;
            this.siticonePanel1.Controls.Add(this.comboDocGia);
            this.siticonePanel1.Controls.Add(this.comboCuonSach);
            this.siticonePanel1.Controls.Add(this.siticoneVSeparator2);
            this.siticonePanel1.Controls.Add(this.siticoneVSeparator1);
            this.siticonePanel1.Controls.Add(this.siticoneSeparator2);
            this.siticonePanel1.Controls.Add(this.butSave);
            this.siticonePanel1.Controls.Add(this.label13);
            this.siticonePanel1.Controls.Add(this.label8);
            this.siticonePanel1.Controls.Add(this.label10);
            this.siticonePanel1.Controls.Add(this.dateNgayMuon);
            this.siticonePanel1.Controls.Add(this.labelHanTra);
            this.siticonePanel1.Controls.Add(this.label11);
            this.siticonePanel1.Controls.Add(this.label3);
            this.siticonePanel1.Controls.Add(this.labelTheLoai);
            this.siticonePanel1.Controls.Add(this.labelTienPhat);
            this.siticonePanel1.Controls.Add(this.labelTongNoHienTai);
            this.siticonePanel1.Controls.Add(this.labelDonGiaPhat);
            this.siticonePanel1.Controls.Add(this.labelTongNoMoi);
            this.siticonePanel1.Controls.Add(this.labelSoNgayTre);
            this.siticonePanel1.Controls.Add(this.labelHoTen);
            this.siticonePanel1.Controls.Add(this.labelTenCS);
            this.siticonePanel1.Controls.Add(this.label2);
            this.siticonePanel1.Controls.Add(this.label12);
            this.siticonePanel1.Controls.Add(this.label1);
            this.siticonePanel1.Location = new System.Drawing.Point(100, 116);
            this.siticonePanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.siticonePanel1.Name = "siticonePanel1";
            this.siticonePanel1.Size = new System.Drawing.Size(973, 729);
            this.siticonePanel1.TabIndex = 1;
            this.siticonePanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.siticonePanel1_Paint);
            // 
            // comboDocGia
            // 
            this.comboDocGia.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboDocGia.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboDocGia.DataSource = this.dOCGIABindingSource;
            this.comboDocGia.DisplayMember = "MaDocGia";
            this.comboDocGia.Font = new System.Drawing.Font("Segoe UI Variable Display", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboDocGia.FormattingEnabled = true;
            this.comboDocGia.Location = new System.Drawing.Point(592, 201);
            this.comboDocGia.Name = "comboDocGia";
            this.comboDocGia.Size = new System.Drawing.Size(236, 32);
            this.comboDocGia.TabIndex = 155;
            this.comboDocGia.ValueMember = "ID";
            this.comboDocGia.SelectedIndexChanged += new System.EventHandler(this.comboDocGia_SelectedIndexChanged);
            // 
            // dOCGIABindingSource
            // 
            this.dOCGIABindingSource.DataSource = typeof(DTO.DOCGIA);
            // 
            // comboCuonSach
            // 
            this.comboCuonSach.AllowDrop = true;
            this.comboCuonSach.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboCuonSach.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboCuonSach.BackColor = System.Drawing.SystemColors.Window;
            this.comboCuonSach.DataSource = this.cUONSACHBindingSource;
            this.comboCuonSach.DisplayMember = "MaCuonSach";
            this.comboCuonSach.Font = new System.Drawing.Font("Segoe UI Variable Display", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboCuonSach.FormattingEnabled = true;
            this.comboCuonSach.Location = new System.Drawing.Point(122, 201);
            this.comboCuonSach.Name = "comboCuonSach";
            this.comboCuonSach.Size = new System.Drawing.Size(231, 32);
            this.comboCuonSach.TabIndex = 154;
            this.comboCuonSach.ValueMember = "id";
            this.comboCuonSach.SelectedIndexChanged += new System.EventHandler(this.comboCuonSach_SelectedIndexChanged);
            // 
            // cUONSACHBindingSource
            // 
            this.cUONSACHBindingSource.DataSource = typeof(DTO.CUONSACH);
            // 
            // siticoneVSeparator2
            // 
            this.siticoneVSeparator2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(101)))), ((int)(((byte)(192)))));
            this.siticoneVSeparator2.FillThickness = 2;
            this.siticoneVSeparator2.Location = new System.Drawing.Point(499, 434);
            this.siticoneVSeparator2.Name = "siticoneVSeparator2";
            this.siticoneVSeparator2.Size = new System.Drawing.Size(10, 176);
            this.siticoneVSeparator2.TabIndex = 151;
            // 
            // siticoneVSeparator1
            // 
            this.siticoneVSeparator1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(101)))), ((int)(((byte)(192)))));
            this.siticoneVSeparator1.FillThickness = 2;
            this.siticoneVSeparator1.Location = new System.Drawing.Point(499, 139);
            this.siticoneVSeparator1.Name = "siticoneVSeparator1";
            this.siticoneVSeparator1.Size = new System.Drawing.Size(10, 176);
            this.siticoneVSeparator1.TabIndex = 151;
            // 
            // siticoneSeparator2
            // 
            this.siticoneSeparator2.FillColor = System.Drawing.Color.DarkSlateBlue;
            this.siticoneSeparator2.Location = new System.Drawing.Point(213, 340);
            this.siticoneSeparator2.Name = "siticoneSeparator2";
            this.siticoneSeparator2.Size = new System.Drawing.Size(568, 28);
            this.siticoneSeparator2.TabIndex = 150;
            // 
            // butSave
            // 
            this.butSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.butSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.butSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.butSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.butSave.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(101)))), ((int)(((byte)(192)))));
            this.butSave.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butSave.ForeColor = System.Drawing.Color.White;
            this.butSave.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.butSave.Location = new System.Drawing.Point(425, 663);
            this.butSave.Name = "butSave";
            this.butSave.Size = new System.Drawing.Size(150, 50);
            this.butSave.TabIndex = 65;
            this.butSave.Text = "Lưu";
            this.butSave.Click += new System.EventHandler(this.butSave_Click_1);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(101)))), ((int)(((byte)(192)))));
            this.label13.Location = new System.Drawing.Point(625, 117);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(240, 37);
            this.label13.TabIndex = 147;
            this.label13.Text = "Thông tin độc giả";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(101)))), ((int)(((byte)(192)))));
            this.label8.Location = new System.Drawing.Point(382, 371);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(236, 37);
            this.label8.TabIndex = 146;
            this.label8.Text = "Chi tiết mượn trả";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(101)))), ((int)(((byte)(192)))));
            this.label10.Location = new System.Drawing.Point(140, 117);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(275, 37);
            this.label10.TabIndex = 146;
            this.label10.Text = "Thông tin cuốn sách";
            // 
            // dateNgayMuon
            // 
            this.dateNgayMuon.Checked = true;
            this.dateNgayMuon.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(241)))), ((int)(((byte)(255)))));
            this.dateNgayMuon.Font = new System.Drawing.Font("Segoe UI Variable Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateNgayMuon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(101)))), ((int)(((byte)(192)))));
            this.dateNgayMuon.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateNgayMuon.Location = new System.Drawing.Point(122, 465);
            this.dateNgayMuon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateNgayMuon.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dateNgayMuon.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dateNgayMuon.Name = "dateNgayMuon";
            this.dateNgayMuon.Size = new System.Drawing.Size(167, 50);
            this.dateNgayMuon.TabIndex = 131;
            this.dateNgayMuon.Value = new System.DateTime(2022, 12, 2, 22, 44, 12, 275);
            this.dateNgayMuon.ValueChanged += new System.EventHandler(this.dateNgayMuon_ValueChanged_1);
            // 
            // labelHanTra
            // 
            this.labelHanTra.AutoSize = true;
            this.labelHanTra.Font = new System.Drawing.Font("Segoe UI Variable Display", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHanTra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(101)))), ((int)(((byte)(192)))));
            this.labelHanTra.Location = new System.Drawing.Point(306, 474);
            this.labelHanTra.Name = "labelHanTra";
            this.labelHanTra.Size = new System.Drawing.Size(148, 31);
            this.labelHanTra.TabIndex = 129;
            this.labelHanTra.Text = "dd/mm/yyyy";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Variable Display", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(101)))), ((int)(((byte)(192)))));
            this.label11.Location = new System.Drawing.Point(308, 441);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 24);
            this.label11.TabIndex = 129;
            this.label11.Text = "Hạn Trả";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Variable Display", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(101)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(588, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 24);
            this.label3.TabIndex = 128;
            this.label3.Text = "Độc Giả";
            // 
            // labelTheLoai
            // 
            this.labelTheLoai.AutoSize = true;
            this.labelTheLoai.Font = new System.Drawing.Font("Segoe UI Variable Display", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTheLoai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(101)))), ((int)(((byte)(192)))));
            this.labelTheLoai.Location = new System.Drawing.Point(116, 295);
            this.labelTheLoai.Name = "labelTheLoai";
            this.labelTheLoai.Size = new System.Drawing.Size(106, 31);
            this.labelTheLoai.TabIndex = 128;
            this.labelTheLoai.Text = "Thể Loại: ";
            // 
            // labelTienPhat
            // 
            this.labelTienPhat.AutoSize = true;
            this.labelTienPhat.Font = new System.Drawing.Font("Segoe UI Variable Display", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTienPhat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(101)))), ((int)(((byte)(192)))));
            this.labelTienPhat.Location = new System.Drawing.Point(581, 544);
            this.labelTienPhat.Name = "labelTienPhat";
            this.labelTienPhat.Size = new System.Drawing.Size(116, 31);
            this.labelTienPhat.TabIndex = 128;
            this.labelTienPhat.Text = "Tiền Phạt: ";
            // 
            // labelTongNoHienTai
            // 
            this.labelTongNoHienTai.AutoSize = true;
            this.labelTongNoHienTai.Font = new System.Drawing.Font("Segoe UI Variable Display", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTongNoHienTai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(101)))), ((int)(((byte)(192)))));
            this.labelTongNoHienTai.Location = new System.Drawing.Point(586, 295);
            this.labelTongNoHienTai.Name = "labelTongNoHienTai";
            this.labelTongNoHienTai.Size = new System.Drawing.Size(195, 31);
            this.labelTongNoHienTai.TabIndex = 128;
            this.labelTongNoHienTai.Text = "Tổng Nợ Hiện Tại: ";
            this.labelTongNoHienTai.Click += new System.EventHandler(this.labelTongNoHienTai_Click);
            // 
            // labelDonGiaPhat
            // 
            this.labelDonGiaPhat.AutoSize = true;
            this.labelDonGiaPhat.Font = new System.Drawing.Font("Segoe UI Variable Display", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDonGiaPhat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(101)))), ((int)(((byte)(192)))));
            this.labelDonGiaPhat.Location = new System.Drawing.Point(581, 489);
            this.labelDonGiaPhat.Name = "labelDonGiaPhat";
            this.labelDonGiaPhat.Size = new System.Drawing.Size(154, 31);
            this.labelDonGiaPhat.TabIndex = 128;
            this.labelDonGiaPhat.Text = "Đơn Giá Phạt: ";
            // 
            // labelTongNoMoi
            // 
            this.labelTongNoMoi.AutoSize = true;
            this.labelTongNoMoi.Font = new System.Drawing.Font("Segoe UI Variable Display", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTongNoMoi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(101)))), ((int)(((byte)(192)))));
            this.labelTongNoMoi.Location = new System.Drawing.Point(581, 599);
            this.labelTongNoMoi.Name = "labelTongNoMoi";
            this.labelTongNoMoi.Size = new System.Drawing.Size(155, 31);
            this.labelTongNoMoi.TabIndex = 128;
            this.labelTongNoMoi.Text = "Tổng Nợ Mới: ";
            // 
            // labelSoNgayTre
            // 
            this.labelSoNgayTre.AutoSize = true;
            this.labelSoNgayTre.Font = new System.Drawing.Font("Segoe UI Variable Display", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSoNgayTre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(101)))), ((int)(((byte)(192)))));
            this.labelSoNgayTre.Location = new System.Drawing.Point(581, 434);
            this.labelSoNgayTre.Name = "labelSoNgayTre";
            this.labelSoNgayTre.Size = new System.Drawing.Size(177, 31);
            this.labelSoNgayTre.TabIndex = 128;
            this.labelSoNgayTre.Text = "Số Ngày Trả Trễ: ";
            // 
            // labelHoTen
            // 
            this.labelHoTen.AutoSize = true;
            this.labelHoTen.Font = new System.Drawing.Font("Segoe UI Variable Display", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHoTen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(101)))), ((int)(((byte)(192)))));
            this.labelHoTen.Location = new System.Drawing.Point(586, 250);
            this.labelHoTen.Name = "labelHoTen";
            this.labelHoTen.Size = new System.Drawing.Size(93, 31);
            this.labelHoTen.TabIndex = 128;
            this.labelHoTen.Text = "Họ Tên: ";
            // 
            // labelTenCS
            // 
            this.labelTenCS.AutoSize = true;
            this.labelTenCS.Font = new System.Drawing.Font("Segoe UI Variable Display", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTenCS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(101)))), ((int)(((byte)(192)))));
            this.labelTenCS.Location = new System.Drawing.Point(116, 250);
            this.labelTenCS.Name = "labelTenCS";
            this.labelTenCS.Size = new System.Drawing.Size(59, 31);
            this.labelTenCS.TabIndex = 128;
            this.labelTenCS.Text = "Tên: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Variable Display", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(101)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(118, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 24);
            this.label2.TabIndex = 128;
            this.label2.Text = "Mã Cuốn Sách";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI Variable Display", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(101)))), ((int)(((byte)(192)))));
            this.label12.Location = new System.Drawing.Point(118, 439);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(103, 24);
            this.label12.TabIndex = 128;
            this.label12.Text = "Ngày Mượn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Variable Display", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(101)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(322, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(338, 49);
            this.label1.TabIndex = 5;
            this.label1.Text = "PHIẾU MƯỢN TRẢ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // siticoneControlBox1
            // 
            this.siticoneControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.siticoneControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(101)))), ((int)(((byte)(192)))));
            this.siticoneControlBox1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.siticoneControlBox1.IconColor = System.Drawing.Color.White;
            this.siticoneControlBox1.Location = new System.Drawing.Point(1087, -1);
            this.siticoneControlBox1.Name = "siticoneControlBox1";
            this.siticoneControlBox1.Size = new System.Drawing.Size(60, 60);
            this.siticoneControlBox1.TabIndex = 67;
            // 
            // siticoneDragControl1
            // 
            this.siticoneDragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.siticoneDragControl1.TargetControl = this;
            this.siticoneDragControl1.UseTransparentDrag = true;
            // 
            // ErrorDia
            // 
            this.ErrorDia.Buttons = Siticone.Desktop.UI.WinForms.MessageDialogButtons.OK;
            this.ErrorDia.Caption = null;
            this.ErrorDia.Icon = Siticone.Desktop.UI.WinForms.MessageDialogIcon.Error;
            this.ErrorDia.Parent = null;
            this.ErrorDia.Style = Siticone.Desktop.UI.WinForms.MessageDialogStyle.Default;
            this.ErrorDia.Text = null;
            // 
            // SuccDia
            // 
            this.SuccDia.Buttons = Siticone.Desktop.UI.WinForms.MessageDialogButtons.OK;
            this.SuccDia.Caption = null;
            this.SuccDia.Icon = Siticone.Desktop.UI.WinForms.MessageDialogIcon.None;
            this.SuccDia.Parent = null;
            this.SuccDia.Style = Siticone.Desktop.UI.WinForms.MessageDialogStyle.Default;
            this.SuccDia.Text = null;
            // 
            // siticonePictureBox1
            // 
            this.siticonePictureBox1.Image = global::GUI.Properties.Resources.Logo_Trường_Đại_học_Sư_phạm_Thành_phố_Hồ_Chí_Minh3;
            this.siticonePictureBox1.ImageRotate = 0F;
            this.siticonePictureBox1.Location = new System.Drawing.Point(12, 4);
            this.siticonePictureBox1.Name = "siticonePictureBox1";
            this.siticonePictureBox1.Size = new System.Drawing.Size(178, 63);
            this.siticonePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.siticonePictureBox1.TabIndex = 74;
            this.siticonePictureBox1.TabStop = false;
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(75)))), ((int)(((byte)(141)))));
            this.topPanel.Controls.Add(this.siticonePictureBox1);
            this.topPanel.Controls.Add(this.label4);
            this.topPanel.Controls.Add(this.siticoneControlBox2);
            this.topPanel.Controls.Add(this.siticoneControlBox3);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(1144, 79);
            this.topPanel.TabIndex = 74;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(183, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(252, 45);
            this.label4.TabIndex = 73;
            this.label4.Text = "HCMUE LIBRARY";
            // 
            // siticoneControlBox2
            // 
            this.siticoneControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.siticoneControlBox2.FillColor = System.Drawing.Color.Transparent;
            this.siticoneControlBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(74)))), ((int)(((byte)(182)))));
            this.siticoneControlBox2.IconColor = System.Drawing.Color.White;
            this.siticoneControlBox2.Location = new System.Drawing.Point(1066, 4);
            this.siticoneControlBox2.Name = "siticoneControlBox2";
            this.siticoneControlBox2.Size = new System.Drawing.Size(57, 45);
            this.siticoneControlBox2.TabIndex = 72;
            this.siticoneControlBox2.Click += new System.EventHandler(this.siticoneControlBox2_Click);
            // 
            // siticoneControlBox3
            // 
            this.siticoneControlBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.siticoneControlBox3.ControlBoxType = Siticone.Desktop.UI.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.siticoneControlBox3.FillColor = System.Drawing.Color.Transparent;
            this.siticoneControlBox3.ForeColor = System.Drawing.Color.White;
            this.siticoneControlBox3.IconColor = System.Drawing.Color.White;
            this.siticoneControlBox3.Location = new System.Drawing.Point(1005, 4);
            this.siticoneControlBox3.Name = "siticoneControlBox3";
            this.siticoneControlBox3.Size = new System.Drawing.Size(55, 45);
            this.siticoneControlBox3.TabIndex = 71;
            // 
            // fPhieuMuonSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(75)))), ((int)(((byte)(141)))));
            this.ClientSize = new System.Drawing.Size(1144, 926);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.siticoneControlBox1);
            this.Controls.Add(this.siticonePanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "fPhieuMuonSach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BMChoMuonSach";
            this.siticonePanel1.ResumeLayout(false);
            this.siticonePanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dOCGIABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cUONSACHBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.siticonePictureBox1)).EndInit();
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticonePanel siticonePanel1;
        private Label label1;
        private Siticone.Desktop.UI.WinForms.SiticoneButton butSave;
        private Siticone.Desktop.UI.WinForms.SiticoneControlBox siticoneControlBox1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private Label label13;
        private Label label10;
        private Siticone.Desktop.UI.WinForms.SiticoneDateTimePicker dateNgayMuon;
        private Label label11;
        private Label label12;
        private Label labelHanTra;
        private Siticone.Desktop.UI.WinForms.SiticoneVSeparator siticoneVSeparator1;
        private Siticone.Desktop.UI.WinForms.SiticoneVSeparator siticoneVSeparator2;
        private Siticone.Desktop.UI.WinForms.SiticoneSeparator siticoneSeparator2;
        private Label label8;
        private Label label3;
        private Label labelTheLoai;
        private Label labelTienPhat;
        private Label labelTongNoHienTai;
        private Label labelDonGiaPhat;
        private Label labelTongNoMoi;
        private Label labelSoNgayTre;
        private Label labelHoTen;
        private Label labelTenCS;
        private Label label2;
        private Siticone.Desktop.UI.WinForms.SiticoneDragControl siticoneDragControl1;
        private Siticone.Desktop.UI.WinForms.SiticoneMessageDialog ErrorDia;
        private ComboBox comboDocGia;
        private ComboBox comboCuonSach;
        private Siticone.Desktop.UI.WinForms.SiticoneMessageDialog SuccDia;
        private BindingSource dOCGIABindingSource;
        private BindingSource cUONSACHBindingSource;
        private Panel topPanel;
        private Siticone.Desktop.UI.WinForms.SiticonePictureBox siticonePictureBox1;
        private Label label4;
        private Siticone.Desktop.UI.WinForms.SiticoneControlBox siticoneControlBox2;
        private Siticone.Desktop.UI.WinForms.SiticoneControlBox siticoneControlBox3;
    }
}
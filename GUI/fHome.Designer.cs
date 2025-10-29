namespace GUI
{
    partial class fHome
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
            this.siticoneBorderlessForm1 = new Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm(this.components);
            this.siticoneDragControl1 = new Siticone.Desktop.UI.WinForms.SiticoneDragControl(this.components);
            this.siticoneGradientPanel1 = new Siticone.Desktop.UI.WinForms.SiticoneGradientPanel();
            this.butManager = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.butTraCuu = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.butTTTK = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.container = new Siticone.Desktop.UI.WinForms.SiticoneGradientPanel();
            this.errorDia = new Siticone.Desktop.UI.WinForms.SiticoneMessageDialog();
            this.siticoneControlBox1 = new Siticone.Desktop.UI.WinForms.SiticoneControlBox();
            this.exitControlBox = new Siticone.Desktop.UI.WinForms.SiticoneControlBox();
            this.label2 = new System.Windows.Forms.Label();
            this.topPanel = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.siticonePictureBox1 = new Siticone.Desktop.UI.WinForms.SiticonePictureBox();
            this.miniControlBox = new Siticone.Desktop.UI.WinForms.SiticoneControlBox();
            this.closeControlBox = new Siticone.Desktop.UI.WinForms.SiticoneControlBox();
            this.siticoneGradientPanel1.SuspendLayout();
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.siticonePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // siticoneBorderlessForm1
            // 
            this.siticoneBorderlessForm1.ContainerControl = this;
            this.siticoneBorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.siticoneBorderlessForm1.TransparentWhileDrag = true;
            // 
            // siticoneDragControl1
            // 
            this.siticoneDragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.siticoneDragControl1.TargetControl = this.topPanel;
            this.siticoneDragControl1.UseTransparentDrag = true;
            // 
            // siticoneGradientPanel1
            // 
            this.siticoneGradientPanel1.BackColor = System.Drawing.Color.Azure;
            this.siticoneGradientPanel1.Controls.Add(this.butManager);
            this.siticoneGradientPanel1.Controls.Add(this.butTraCuu);
            this.siticoneGradientPanel1.Controls.Add(this.butTTTK);
            this.siticoneGradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.siticoneGradientPanel1.Location = new System.Drawing.Point(0, 71);
            this.siticoneGradientPanel1.Name = "siticoneGradientPanel1";
            this.siticoneGradientPanel1.Size = new System.Drawing.Size(1350, 79);
            this.siticoneGradientPanel1.TabIndex = 3;
            // 
            // butManager
            // 
            this.butManager.BorderRadius = 4;
            this.butManager.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.butManager.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.butManager.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.butManager.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.butManager.Dock = System.Windows.Forms.DockStyle.Right;
            this.butManager.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(101)))), ((int)(((byte)(192)))));
            this.butManager.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butManager.ForeColor = System.Drawing.Color.White;
            this.butManager.Image = global::GUI.Properties.Resources.white_key_icon1;
            this.butManager.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.butManager.ImageOffset = new System.Drawing.Point(5, 0);
            this.butManager.ImageSize = new System.Drawing.Size(30, 30);
            this.butManager.Location = new System.Drawing.Point(1170, 0);
            this.butManager.Name = "butManager";
            this.butManager.Size = new System.Drawing.Size(180, 79);
            this.butManager.TabIndex = 2;
            this.butManager.Text = "Quản lý";
            this.butManager.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.butManager.TextOffset = new System.Drawing.Point(10, 0);
            this.butManager.Click += new System.EventHandler(this.butManager_Click);
            // 
            // butTraCuu
            // 
            this.butTraCuu.BackColor = System.Drawing.Color.Azure;
            this.butTraCuu.BorderColor = System.Drawing.Color.Transparent;
            this.butTraCuu.ButtonMode = Siticone.Desktop.UI.WinForms.Enums.ButtonMode.RadioButton;
            this.butTraCuu.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(218)))), ((int)(((byte)(255)))));
            this.butTraCuu.CheckedState.CustomBorderColor = System.Drawing.Color.SlateBlue;
            this.butTraCuu.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(218)))), ((int)(((byte)(255)))));
            this.butTraCuu.CheckedState.ForeColor = System.Drawing.Color.SlateBlue;
            this.butTraCuu.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.butTraCuu.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.butTraCuu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.butTraCuu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.butTraCuu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.butTraCuu.Dock = System.Windows.Forms.DockStyle.Left;
            this.butTraCuu.FillColor = System.Drawing.Color.Transparent;
            this.butTraCuu.Font = new System.Drawing.Font("Segoe UI Variable Display", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butTraCuu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(101)))), ((int)(((byte)(192)))));
            this.butTraCuu.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.butTraCuu.Location = new System.Drawing.Point(365, 0);
            this.butTraCuu.Name = "butTraCuu";
            this.butTraCuu.Size = new System.Drawing.Size(365, 79);
            this.butTraCuu.TabIndex = 1;
            this.butTraCuu.Text = "Tra cứu sách";
            this.butTraCuu.Click += new System.EventHandler(this.butTraCuu_Click);
            // 
            // butTTTK
            // 
            this.butTTTK.BackColor = System.Drawing.Color.Azure;
            this.butTTTK.BorderColor = System.Drawing.Color.Transparent;
            this.butTTTK.ButtonMode = Siticone.Desktop.UI.WinForms.Enums.ButtonMode.RadioButton;
            this.butTTTK.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(218)))), ((int)(((byte)(255)))));
            this.butTTTK.CheckedState.CustomBorderColor = System.Drawing.Color.SlateBlue;
            this.butTTTK.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(218)))), ((int)(((byte)(255)))));
            this.butTTTK.CheckedState.ForeColor = System.Drawing.Color.SlateBlue;
            this.butTTTK.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.butTTTK.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.butTTTK.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.butTTTK.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.butTTTK.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.butTTTK.Dock = System.Windows.Forms.DockStyle.Left;
            this.butTTTK.FillColor = System.Drawing.Color.Transparent;
            this.butTTTK.Font = new System.Drawing.Font("Segoe UI Variable Display", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butTTTK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(101)))), ((int)(((byte)(192)))));
            this.butTTTK.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.butTTTK.Location = new System.Drawing.Point(0, 0);
            this.butTTTK.Name = "butTTTK";
            this.butTTTK.Size = new System.Drawing.Size(365, 79);
            this.butTTTK.TabIndex = 0;
            this.butTTTK.Text = "Thông tin tài khoản";
            this.butTTTK.Click += new System.EventHandler(this.butTTTK_Click);
            // 
            // container
            // 
            this.container.BackColor = System.Drawing.Color.WhiteSmoke;
            this.container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.container.Location = new System.Drawing.Point(0, 150);
            this.container.Name = "container";
            this.container.Size = new System.Drawing.Size(1350, 952);
            this.container.TabIndex = 4;
            // 
            // errorDia
            // 
            this.errorDia.Buttons = Siticone.Desktop.UI.WinForms.MessageDialogButtons.OK;
            this.errorDia.Caption = null;
            this.errorDia.Icon = Siticone.Desktop.UI.WinForms.MessageDialogIcon.Error;
            this.errorDia.Parent = null;
            this.errorDia.Style = Siticone.Desktop.UI.WinForms.MessageDialogStyle.Light;
            this.errorDia.Text = null;
            // 
            // siticoneControlBox1
            // 
            this.siticoneControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.siticoneControlBox1.BackColor = System.Drawing.Color.Transparent;
            this.siticoneControlBox1.ControlBoxType = Siticone.Desktop.UI.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.siticoneControlBox1.FillColor = System.Drawing.Color.Transparent;
            this.siticoneControlBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.siticoneControlBox1.IconColor = System.Drawing.Color.White;
            this.siticoneControlBox1.Location = new System.Drawing.Point(1186, 0);
            this.siticoneControlBox1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.siticoneControlBox1.Name = "siticoneControlBox1";
            this.siticoneControlBox1.Size = new System.Drawing.Size(79, 66);
            this.siticoneControlBox1.TabIndex = 0;
            // 
            // exitControlBox
            // 
            this.exitControlBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exitControlBox.BackColor = System.Drawing.Color.Transparent;
            this.exitControlBox.FillColor = System.Drawing.Color.Transparent;
            this.exitControlBox.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.exitControlBox.IconColor = System.Drawing.Color.White;
            this.exitControlBox.Location = new System.Drawing.Point(1264, 0);
            this.exitControlBox.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.exitControlBox.Name = "exitControlBox";
            this.exitControlBox.Size = new System.Drawing.Size(83, 66);
            this.exitControlBox.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(139, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(271, 48);
            this.label2.TabIndex = 4;
            this.label2.Text = "HCMUE LIBRARY";
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.White;
            this.topPanel.Controls.Add(this.miniControlBox);
            this.topPanel.Controls.Add(this.closeControlBox);
            this.topPanel.Controls.Add(this.siticonePictureBox1);
            this.topPanel.Controls.Add(this.label2);
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
            this.topPanel.Size = new System.Drawing.Size(1350, 71);
            this.topPanel.TabIndex = 2;
            this.topPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.topPanel_Paint);
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
            // miniControlBox
            // 
            this.miniControlBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.miniControlBox.BackColor = System.Drawing.Color.Transparent;
            this.miniControlBox.ControlBoxType = Siticone.Desktop.UI.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.miniControlBox.FillColor = System.Drawing.Color.Transparent;
            this.miniControlBox.IconColor = System.Drawing.Color.White;
            this.miniControlBox.Location = new System.Drawing.Point(1026, 15);
            this.miniControlBox.Name = "miniControlBox";
            this.miniControlBox.Size = new System.Drawing.Size(48, 42);
            this.miniControlBox.TabIndex = 6;
            // 
            // closeControlBox
            // 
            this.closeControlBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeControlBox.BackColor = System.Drawing.Color.Transparent;
            this.closeControlBox.FillColor = System.Drawing.Color.Transparent;
            this.closeControlBox.IconColor = System.Drawing.Color.White;
            this.closeControlBox.Location = new System.Drawing.Point(1076, 15);
            this.closeControlBox.Name = "closeControlBox";
            this.closeControlBox.Size = new System.Drawing.Size(49, 42);
            this.closeControlBox.TabIndex = 7;
            // 
            // fHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 1102);
            this.Controls.Add(this.container);
            this.Controls.Add(this.siticoneGradientPanel1);
            this.Controls.Add(this.topPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fHome";
            this.siticoneGradientPanel1.ResumeLayout(false);
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.siticonePictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm siticoneBorderlessForm1;
        private Siticone.Desktop.UI.WinForms.SiticoneDragControl siticoneDragControl1;
        private Siticone.Desktop.UI.WinForms.SiticoneGradientPanel siticoneGradientPanel1;
        private Siticone.Desktop.UI.WinForms.SiticoneButton butTraCuu;
        private Siticone.Desktop.UI.WinForms.SiticoneButton butTTTK;
        private Siticone.Desktop.UI.WinForms.SiticoneGradientPanel container;
        private Siticone.Desktop.UI.WinForms.SiticoneButton butManager;
        private Siticone.Desktop.UI.WinForms.SiticoneMessageDialog errorDia;
        private Siticone.Desktop.UI.WinForms.SiticonePanel topPanel;
        private System.Windows.Forms.Label label2;
        private Siticone.Desktop.UI.WinForms.SiticoneControlBox exitControlBox;
        private Siticone.Desktop.UI.WinForms.SiticoneControlBox siticoneControlBox1;
        private Siticone.Desktop.UI.WinForms.SiticonePictureBox siticonePictureBox1;
        private Siticone.Desktop.UI.WinForms.SiticoneControlBox miniControlBox;
        private Siticone.Desktop.UI.WinForms.SiticoneControlBox closeControlBox;
    }
}
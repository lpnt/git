namespace Lpnt.CoBan.Function
{
    partial class FrmNhapTuExcel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNhapTuExcel));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.btnDong = new DevExpress.XtraEditors.SimpleButton();
            this.btnThucHien = new DevExpress.XtraEditors.SimpleButton();
            this.cboNhanSuSheet = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cboChiDoanSheet = new DevExpress.XtraEditors.ComboBoxEdit();
            this.chkDanhSachNhanSu = new DevExpress.XtraEditors.CheckEdit();
            this.chkDanhSachChiDoan = new DevExpress.XtraEditors.CheckEdit();
            this.chkDanhSachDonVi = new DevExpress.XtraEditors.CheckEdit();
            this.cboDonViSheet = new DevExpress.XtraEditors.ComboBoxEdit();
            this.bteDuongDan = new DevExpress.XtraEditors.ButtonEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem9 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.simpleSeparator1 = new DevExpress.XtraLayout.SimpleSeparator();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboNhanSuSheet.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboChiDoanSheet.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkDanhSachNhanSu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkDanhSachChiDoan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkDanhSachDonVi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboDonViSheet.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bteDuongDan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.btnDong);
            this.layoutControl1.Controls.Add(this.btnThucHien);
            this.layoutControl1.Controls.Add(this.cboNhanSuSheet);
            this.layoutControl1.Controls.Add(this.cboChiDoanSheet);
            this.layoutControl1.Controls.Add(this.chkDanhSachNhanSu);
            this.layoutControl1.Controls.Add(this.chkDanhSachChiDoan);
            this.layoutControl1.Controls.Add(this.chkDanhSachDonVi);
            this.layoutControl1.Controls.Add(this.cboDonViSheet);
            this.layoutControl1.Controls.Add(this.bteDuongDan);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(829, 112, 250, 350);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(484, 244);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // btnDong
            // 
            this.btnDong.Image = ((System.Drawing.Image)(resources.GetObject("btnDong.Image")));
            this.btnDong.Location = new System.Drawing.Point(377, 210);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(95, 22);
            this.btnDong.StyleController = this.layoutControl1;
            this.btnDong.TabIndex = 12;
            this.btnDong.Text = "Đóng";
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnThucHien
            // 
            this.btnThucHien.Image = ((System.Drawing.Image)(resources.GetObject("btnThucHien.Image")));
            this.btnThucHien.Location = new System.Drawing.Point(278, 210);
            this.btnThucHien.Name = "btnThucHien";
            this.btnThucHien.Size = new System.Drawing.Size(95, 22);
            this.btnThucHien.StyleController = this.layoutControl1;
            this.btnThucHien.TabIndex = 11;
            this.btnThucHien.Text = "Thực hiện";
            this.btnThucHien.Click += new System.EventHandler(this.btnThucHien_Click);
            // 
            // cboNhanSuSheet
            // 
            this.cboNhanSuSheet.Enabled = false;
            this.cboNhanSuSheet.Location = new System.Drawing.Point(284, 158);
            this.cboNhanSuSheet.Name = "cboNhanSuSheet";
            this.cboNhanSuSheet.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboNhanSuSheet.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cboNhanSuSheet.Size = new System.Drawing.Size(176, 20);
            this.cboNhanSuSheet.StyleController = this.layoutControl1;
            this.cboNhanSuSheet.TabIndex = 10;
            this.cboNhanSuSheet.Visible = false;
            // 
            // cboChiDoanSheet
            // 
            this.cboChiDoanSheet.Enabled = false;
            this.cboChiDoanSheet.Location = new System.Drawing.Point(284, 134);
            this.cboChiDoanSheet.Name = "cboChiDoanSheet";
            this.cboChiDoanSheet.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboChiDoanSheet.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cboChiDoanSheet.Size = new System.Drawing.Size(176, 20);
            this.cboChiDoanSheet.StyleController = this.layoutControl1;
            this.cboChiDoanSheet.TabIndex = 9;
            this.cboChiDoanSheet.Visible = false;
            // 
            // chkDanhSachNhanSu
            // 
            this.chkDanhSachNhanSu.Location = new System.Drawing.Point(24, 158);
            this.chkDanhSachNhanSu.Name = "chkDanhSachNhanSu";
            this.chkDanhSachNhanSu.Properties.Caption = "Danh sách nhân sự";
            this.chkDanhSachNhanSu.Size = new System.Drawing.Size(197, 19);
            this.chkDanhSachNhanSu.StyleController = this.layoutControl1;
            this.chkDanhSachNhanSu.TabIndex = 8;
            this.chkDanhSachNhanSu.CheckedChanged += new System.EventHandler(this.chkDanhSachNhanSu_CheckedChanged);
            // 
            // chkDanhSachChiDoan
            // 
            this.chkDanhSachChiDoan.Location = new System.Drawing.Point(24, 134);
            this.chkDanhSachChiDoan.Name = "chkDanhSachChiDoan";
            this.chkDanhSachChiDoan.Properties.Caption = "Danh sách chi đoàn";
            this.chkDanhSachChiDoan.Size = new System.Drawing.Size(197, 19);
            this.chkDanhSachChiDoan.StyleController = this.layoutControl1;
            this.chkDanhSachChiDoan.TabIndex = 7;
            this.chkDanhSachChiDoan.CheckedChanged += new System.EventHandler(this.chkDanhSachChiDoan_CheckedChanged);
            // 
            // chkDanhSachDonVi
            // 
            this.chkDanhSachDonVi.Location = new System.Drawing.Point(24, 110);
            this.chkDanhSachDonVi.Name = "chkDanhSachDonVi";
            this.chkDanhSachDonVi.Properties.Caption = "Danh sách đơn vị";
            this.chkDanhSachDonVi.Size = new System.Drawing.Size(197, 19);
            this.chkDanhSachDonVi.StyleController = this.layoutControl1;
            this.chkDanhSachDonVi.TabIndex = 6;
            this.chkDanhSachDonVi.CheckedChanged += new System.EventHandler(this.chkDanhSachDonVi_CheckedChanged);
            // 
            // cboDonViSheet
            // 
            this.cboDonViSheet.Enabled = false;
            this.cboDonViSheet.Location = new System.Drawing.Point(284, 110);
            this.cboDonViSheet.Name = "cboDonViSheet";
            this.cboDonViSheet.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboDonViSheet.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cboDonViSheet.Size = new System.Drawing.Size(176, 20);
            this.cboDonViSheet.StyleController = this.layoutControl1;
            this.cboDonViSheet.TabIndex = 5;
            // 
            // bteDuongDan
            // 
            this.bteDuongDan.Location = new System.Drawing.Point(24, 43);
            this.bteDuongDan.Name = "bteDuongDan";
            this.bteDuongDan.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.bteDuongDan.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.bteDuongDan.Size = new System.Drawing.Size(436, 20);
            this.bteDuongDan.StyleController = this.layoutControl1;
            this.bteDuongDan.TabIndex = 4;
            this.bteDuongDan.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.bteDuongDan_ButtonClick);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2,
            this.layoutControlGroup3,
            this.layoutControlItem8,
            this.layoutControlItem9,
            this.emptySpaceItem1,
            this.simpleSeparator1,
            this.emptySpaceItem2});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(484, 244);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.AppearanceGroup.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.layoutControlGroup2.AppearanceGroup.Options.UseFont = true;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.Size = new System.Drawing.Size(464, 67);
            this.layoutControlGroup2.Text = "Đường dẫn tệp tin Excel";
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.bteDuongDan;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(440, 24);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlGroup3
            // 
            this.layoutControlGroup3.AppearanceGroup.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.layoutControlGroup3.AppearanceGroup.Options.UseFont = true;
            this.layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem3,
            this.layoutControlItem2,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.layoutControlItem6,
            this.layoutControlItem7});
            this.layoutControlGroup3.Location = new System.Drawing.Point(0, 67);
            this.layoutControlGroup3.Name = "layoutControlGroup3";
            this.layoutControlGroup3.Size = new System.Drawing.Size(464, 115);
            this.layoutControlGroup3.Text = "Danh mục nhập liệu";
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.chkDanhSachDonVi;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(201, 24);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.cboDonViSheet;
            this.layoutControlItem2.Location = new System.Drawing.Point(201, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(239, 24);
            this.layoutControlItem2.Text = "Sheet Excel";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(56, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.chkDanhSachChiDoan;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(201, 24);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.chkDanhSachNhanSu;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(201, 24);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.cboChiDoanSheet;
            this.layoutControlItem6.Location = new System.Drawing.Point(201, 24);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(239, 24);
            this.layoutControlItem6.Text = "Sheet Excel";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(56, 13);
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.cboNhanSuSheet;
            this.layoutControlItem7.Location = new System.Drawing.Point(201, 48);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(239, 24);
            this.layoutControlItem7.Text = "Sheet Excel";
            this.layoutControlItem7.TextSize = new System.Drawing.Size(56, 13);
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.btnThucHien;
            this.layoutControlItem8.Location = new System.Drawing.Point(266, 198);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(99, 26);
            this.layoutControlItem8.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem8.TextVisible = false;
            // 
            // layoutControlItem9
            // 
            this.layoutControlItem9.Control = this.btnDong;
            this.layoutControlItem9.Location = new System.Drawing.Point(365, 198);
            this.layoutControlItem9.Name = "layoutControlItem9";
            this.layoutControlItem9.Size = new System.Drawing.Size(99, 26);
            this.layoutControlItem9.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem9.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 182);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(464, 14);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // simpleSeparator1
            // 
            this.simpleSeparator1.AllowHotTrack = false;
            this.simpleSeparator1.Location = new System.Drawing.Point(0, 196);
            this.simpleSeparator1.Name = "simpleSeparator1";
            this.simpleSeparator1.Size = new System.Drawing.Size(464, 2);
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(0, 198);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(266, 26);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // FrmNhapTuExcel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 244);
            this.Controls.Add(this.layoutControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmNhapTuExcel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhập từ Excel";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cboNhanSuSheet.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboChiDoanSheet.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkDanhSachNhanSu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkDanhSachChiDoan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkDanhSachDonVi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboDonViSheet.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bteDuongDan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.CheckEdit chkDanhSachDonVi;
        private DevExpress.XtraEditors.ComboBoxEdit cboDonViSheet;
        private DevExpress.XtraEditors.ButtonEdit bteDuongDan;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraEditors.SimpleButton btnDong;
        private DevExpress.XtraEditors.SimpleButton btnThucHien;
        private DevExpress.XtraEditors.ComboBoxEdit cboNhanSuSheet;
        private DevExpress.XtraEditors.ComboBoxEdit cboChiDoanSheet;
        private DevExpress.XtraEditors.CheckEdit chkDanhSachNhanSu;
        private DevExpress.XtraEditors.CheckEdit chkDanhSachChiDoan;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem9;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.SimpleSeparator simpleSeparator1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
    }
}
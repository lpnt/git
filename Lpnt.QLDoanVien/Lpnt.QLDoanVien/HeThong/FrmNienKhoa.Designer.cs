namespace Lpnt.QLDoanVien.HeThong
{
    partial class FrmNienKhoa
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
            this.xpc = new DevExpress.Xpo.XPCollection(this.components);
            this.gridControlCus1 = new Lpnt.CoBan.Common.GridControlCus();
            this.gridViewCus1 = new Lpnt.CoBan.Common.GridViewCus();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenNienKhoa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSuDung = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.BM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UOW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCus1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCus1)).BeginInit();
            this.SuspendLayout();
            // 
            // TB
            // 
            this.TB.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnNap, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThem, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXoa, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnLuu, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnDong, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXemVaIn, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.TB.OptionsBar.AllowQuickCustomization = false;
            this.TB.OptionsBar.DrawDragBorder = false;
            this.TB.OptionsBar.UseWholeRow = true;
            // 
            // xpc
            // 
            this.xpc.DeleteObjectOnRemove = true;
            this.xpc.DisplayableProperties = "Id;TenNienKhoa;SuDung";
            this.xpc.ObjectType = typeof(Lpnt.DuLieu.NienKhoa);
            this.xpc.Session = this.UOW;
            // 
            // gridControlCus1
            // 
            this.gridControlCus1.DataSource = this.xpc;
            this.gridControlCus1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlCus1.Location = new System.Drawing.Point(0, 29);
            this.gridControlCus1.MainView = this.gridViewCus1;
            this.gridControlCus1.MenuManager = this.BM;
            this.gridControlCus1.Name = "gridControlCus1";
            this.gridControlCus1.Size = new System.Drawing.Size(584, 333);
            this.gridControlCus1.TabIndex = 4;
            this.gridControlCus1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewCus1});
            // 
            // gridViewCus1
            // 
            this.gridViewCus1.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Blue;
            this.gridViewCus1.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gridViewCus1.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridViewCus1.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewCus1.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridViewCus1.AppearancePrint.HeaderPanel.Options.UseTextOptions = true;
            this.gridViewCus1.AppearancePrint.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewCus1.AppearancePrint.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridViewCus1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colTenNienKhoa,
            this.colSuDung});
            this.gridViewCus1.FixedLineWidth = 1;
            this.gridViewCus1.GridControl = this.gridControlCus1;
            this.gridViewCus1.GroupFormat = "[#image]{1} {2}";
            this.gridViewCus1.IndicatorWidth = 40;
            this.gridViewCus1.KeyColumn = "Id";
            this.gridViewCus1.Name = "gridViewCus1";
            this.gridViewCus1.OptionsBehavior.AutoExpandAllGroups = true;
            this.gridViewCus1.OptionsDetail.EnableMasterViewMode = false;
            this.gridViewCus1.OptionsFind.FindMode = DevExpress.XtraEditors.FindMode.Always;
            this.gridViewCus1.OptionsSelection.CheckBoxSelectorColumnWidth = 40;
            this.gridViewCus1.OptionsSelection.InvertSelection = true;
            this.gridViewCus1.OptionsSelection.MultiSelect = true;
            this.gridViewCus1.OptionsSelection.ResetSelectionClickOutsideCheckboxSelector = true;
            this.gridViewCus1.OptionsView.ColumnAutoWidth = false;
            this.gridViewCus1.OptionsView.EnableAppearanceEvenRow = true;
            this.gridViewCus1.OptionsView.ShowAutoFilterRow = true;
            this.gridViewCus1.OptionsView.ShowFooter = true;
            this.gridViewCus1.OptionsView.ShowGroupPanel = false;
            this.gridViewCus1.CellValueChanging += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridViewCus1_CellValueChanging);
            // 
            // colId
            // 
            this.colId.AppearanceCell.Options.UseTextOptions = true;
            this.colId.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colId.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "Id", "{0}")});
            this.colId.Visible = true;
            this.colId.VisibleIndex = 0;
            // 
            // colTenNienKhoa
            // 
            this.colTenNienKhoa.AppearanceCell.Options.UseTextOptions = true;
            this.colTenNienKhoa.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTenNienKhoa.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colTenNienKhoa.FieldName = "TenNienKhoa";
            this.colTenNienKhoa.Name = "colTenNienKhoa";
            this.colTenNienKhoa.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colTenNienKhoa.Visible = true;
            this.colTenNienKhoa.VisibleIndex = 1;
            this.colTenNienKhoa.Width = 100;
            // 
            // colSuDung
            // 
            this.colSuDung.FieldName = "SuDung";
            this.colSuDung.Name = "colSuDung";
            this.colSuDung.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colSuDung.Visible = true;
            this.colSuDung.VisibleIndex = 2;
            // 
            // FrmNienKhoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 362);
            this.Controls.Add(this.gridControlCus1);
            this.Name = "FrmNienKhoa";
            this.Text = "Niên khóa";
            this.Controls.SetChildIndex(this.gridControlCus1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.BM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UOW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCus1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCus1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.Xpo.XPCollection xpc;
        private CoBan.Common.GridControlCus gridControlCus1;
        private CoBan.Common.GridViewCus gridViewCus1;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colTenNienKhoa;
        private DevExpress.XtraGrid.Columns.GridColumn colSuDung;
    }
}
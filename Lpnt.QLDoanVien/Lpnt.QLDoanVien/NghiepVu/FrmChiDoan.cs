using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Lpnt.CoBan.Common;
using DevExpress.Data.Filtering;
using Lpnt.DuLieu;

namespace Lpnt.QLDoanVien.NghiepVu
{
    public partial class FrmChiDoan : FrmBase
    {
        public FrmChiDoan()
        {
            InitializeComponent();
            OnNap();
        }
        protected override void OnNap()
        {
            Text = string.Format("[{0}] Quản lý chi đoàn", clsHeThong.NienKhoaSuDung.TenNienKhoa);

            xpcDonVi.Reload();
            xpcDonVi.Criteria = CriteriaOperator.Parse(Constants.FILTER_NIENKHOA_DONVI, clsHeThong.NienKhoaSuDung.Id);
            xpcChiDoan.Filter = CriteriaOperator.Parse("[DonVi.Id] = ?", slkDonVi.EditValue);

            base.OnNap();
        }
        protected override void OnThem()
        {
            if (slkDonVi.EditValue == null) return;

            gvChiDoan.AddNewRow();
        }
        protected override void OnXoa()
        {
            if (gvChiDoan.SelectedRowsCount == 0) return;
            var res = MsgBox.ShowYesNoDialog(string.Format("Bạn có chắc muốn xóa ({0}) dòng đang chọn?", gvChiDoan.SelectedRowsCount));
            if (res == DialogResult.No) return;

            gvChiDoan.DeleteSelectedRows();
            OnLuu();
        }
        protected override bool OnLuu()
        {
            gvChiDoan.CloseEditor();
            gvChiDoan.UpdateCurrentRow();

            if (gvChiDoan.HasError()) return false;
            if (dxError.HasErrors) return false;

            return base.OnLuu();
        }
        private void rslkDonVi_EditValueChanged(object sender, EventArgs e)
        {
            var rslk = sender as SearchLookUpEdit;
            if (rslk == null) return;

            xpcChiDoan.Filter = CriteriaOperator.Parse("[DonVi.Id] = ?", rslk.EditValue);
        }

        private void gvChiDoan_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            DonVi donvi = xpcDonVi.Lookup(slkDonVi.EditValue) as DonVi;
            if (donvi == null) return;

            var chidoan = gvChiDoan.GetFocusedRow() as ChiDoan;
            if (chidoan == null) return;

            chidoan.DonVi = donvi;
        }
    }
}
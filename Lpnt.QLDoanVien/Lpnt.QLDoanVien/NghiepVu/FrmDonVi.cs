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
using Lpnt.DuLieu;
using DevExpress.Data.Filtering;

namespace Lpnt.QLDoanVien.NghiepVu
{
    public partial class FrmDonVi : FrmBase
    {
        public FrmDonVi()
        {
            InitializeComponent();
            OnNap();
        }

        protected override void OnNap()
        {
            Text = string.Format("[{0}] Quản lý đơn vị", clsHeThong.NienKhoaSuDung.TenNienKhoa);

            // Lọc đơn vị theo niên khóa đang sử dụng
            xpcDonVi.Filter = CriteriaOperator.Parse(Constants.FILTER_NIENKHOA_DONVI, clsHeThong.NienKhoaSuDung.Id);

            xpcTinhThanh.Reload();
            xpcHuyenQuan.Reload();
            xpcNienKhoa.Reload();
            foreach (DonVi donvi in xpcDonVi)
            {
                donvi.Reload();
                donvi.ChiDoans.Reload();
            }
            xpcDonVi.Reload();

            base.OnNap();
        }
        protected override void OnThem()
        {
            gvDonVi.AddNewRow();
        }
        protected override void OnXoa()
        {
            if (gvDonVi.SelectedRowsCount == 0) return;
            var res = MsgBox.ShowYesNoDialog(string.Format("Bạn có chắc muốn xóa ({0}) dòng đang chọn?", gvDonVi.SelectedRowsCount));
            if (res == DialogResult.No) return;

            gvDonVi.DeleteSelectedRows();
            OnLuu();
        }
        protected override bool OnLuu()
        {
            gvChiDoan.CloseEditor();
            gvChiDoan.UpdateCurrentRow();
            gvDonVi.CloseEditor();
            gvDonVi.UpdateCurrentRow();

            if (gvChiDoan.HasError()) return false;
            if (gvDonVi.HasError()) return false;
            if (dxError.HasErrors) return false;

            return base.OnLuu();
        }

        private void gvDonVi_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            var donvi = gvDonVi.GetFocusedRow() as DonVi;
            if (donvi == null) return;

            donvi.ChiDoans.DeleteObjectOnRemove = true;
            gcChiDoan.DataSource = donvi.ChiDoans;
        }
        private void gcChiDoan_EmbeddedNavigator_ButtonClick(object sender, NavigatorButtonClickEventArgs e)
        {
            if (e.Button.Tag.ToString().Equals("ThemChiDoan"))
            {
                var donvi = gvDonVi.GetFocusedRow() as DonVi;
                if (donvi == null) return;

                gvChiDoan.AddNewRow();
            }

            if (e.Button.Tag.ToString().Equals("XoaChiDoan"))
            {
                if (gvChiDoan.SelectedRowsCount == 0) return;

                var res = MsgBox.ShowYesNoDialog(string.Format("Bạn muốn xóa ({0}) chi đoàn đang chọn?", gvChiDoan.SelectedRowsCount));
                if (res == DialogResult.No) return;

                gvChiDoan.DeleteSelectedRows();
                OnLuu();
            }

            e.Handled = true;
        }
        private void gvDonVi_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            var donvi = gvDonVi.GetFocusedRow() as DonVi;
            if (donvi == null) return;

            if (clsHeThong.NienKhoaSuDung != null) donvi.NienKhoa = xpcNienKhoa.Lookup(clsHeThong.NienKhoaSuDung.Id) as NienKhoa;
        }

        private void rslkNienKhoa_QueryPopUp(object sender, CancelEventArgs e)
        {
            xpcNienKhoa.Reload();
        }
        private void SearchLookUpEditNienKhoa_QueryPopUp(object sender, CancelEventArgs e)
        {
            xpcNienKhoa.Reload();
        }
        private void rslkTinhDoan_QueryPopUp(object sender, CancelEventArgs e)
        {
            xpcTinhThanh.Reload();
        }
        private void SearchLookUpEditTinhDoan_QueryPopUp(object sender, CancelEventArgs e)
        {
            xpcTinhThanh.Reload();
        }
        private void rslkHuyenDoan_QueryPopUp(object sender, CancelEventArgs e)
        {
            xpcHuyenQuan.Reload();
        }
        private void SearchLookUpEditHuyenDoan_QueryPopUp(object sender, CancelEventArgs e)
        {
            xpcHuyenQuan.Reload();
        }
    }
}
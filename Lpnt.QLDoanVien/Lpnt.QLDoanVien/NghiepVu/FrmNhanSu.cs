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

namespace Lpnt.QLDoanVien.NghiepVu
{
    public partial class FrmNhanSu : FrmBase
    {
        public FrmNhanSu()
        {
            InitializeComponent();
            OnNap();
        }

        protected override void OnNap()
        {
            Text = string.Format("[{0}] Quản lý nhân sự", clsHeThong.NienKhoaSuDung.TenNienKhoa);
            xpcDonVi.Reload();
            xpcChiDoan.Reload();
            xpcNhanSu.Reload();

            xpcDonVi.Filter = CriteriaOperator.Parse(Constants.FILTER_NIENKHOA_DONVI, clsHeThong.NienKhoaSuDung.Id);
            xpcChiDoan.Filter = CriteriaOperator.Parse("[DonVi.Id] = ?", SearchLookUpEditDonVi.EditValue);
            xpcNhanSu.Filter = CriteriaOperator.Parse("[ChiDoan.Id] = ?", SearchLookUpEditChiDoan.EditValue);

            base.OnNap();
        }

        private void rslkDonVi_EditValueChanged(object sender, EventArgs e)
        {
            var rslk = sender as SearchLookUpEdit;
            if (rslk == null) return;

            SearchLookUpEditChiDoan.EditValue = null;
            xpcChiDoan.Filter = CriteriaOperator.Parse("[DonVi.Id] = ?", rslk.EditValue);
        }

        private void rslkChiDoan_EditValueChanged(object sender, EventArgs e)
        {
            var rslk = sender as SearchLookUpEdit;
            if (rslk == null) return;

            xpcNhanSu.Filter = CriteriaOperator.Parse("[ChiDoan.Id] = ?", rslk.EditValue);
        }
    }
}
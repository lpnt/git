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

namespace Lpnt.QLDoanVien.HeThong
{
    public partial class FrmNienKhoa : FrmBase
    {
        public FrmNienKhoa()
        {
            InitializeComponent();
            OnNap();
        }
        protected override void OnNap()
        {

            base.OnNap();
            xpc.Reload();
        }
        protected override void OnThem()
        {
            gridViewCus1.AddNewRow();
        }
        protected override void OnXoa()
        {
            if (gridViewCus1.SelectedRowsCount == 0) return;
            var res = MsgBox.ShowYesNoDialog(string.Format("Bạn có chắc muốn xóa ({0}) dòng đang chọn?", gridViewCus1.SelectedRowsCount));
            if (res == DialogResult.No) return;

            gridViewCus1.DeleteSelectedRows();
            OnLuu();
        }
        protected override bool OnLuu()
        {
            gridViewCus1.CloseEditor();
            gridViewCus1.UpdateCurrentRow();
            if (gridViewCus1.HasError()) return false;

            if( base.OnLuu())
            {
                CapNhatNienKhoaSuDung();
                CapNhatDuLieu();
            }

            return true;
        }
        bool CapNhatNienKhoaSuDung()
        {
            try
            {
                foreach (Form f in Application.OpenForms)
                {
                    var ftrangchu = f as FrmTrangChu;
                    if(ftrangchu != null) ftrangchu.NapNienKhoa();
                }

                return true;
            }
            catch (Exception ex)
            {
                MsgBox.ShowErrorDialog(ex.Message);
                return false;
            }
        }        
        bool CapNhatDuLieu()
        {
            try
            {
                var openForms = Application.OpenForms;
                for (int i = 0; i < openForms.Count; i++)
                {
                    Form f = openForms[i];

                    var fbase = f as FrmBase;
                    if (fbase != null) fbase.NapLaiDuLieu();
                }

                return true;
            }
            catch (Exception ex)
            {
                MsgBox.ShowErrorDialog(ex.Message);
                return false;
            }
        }
        private void gridViewCus1_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (!e.Column.FieldName.Equals("SuDung")) return;

            foreach (NienKhoa nienkhoa in xpc)
            {
                nienkhoa.SuDung = false;
                nienkhoa.Save();
            }
        }
    }
}
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
using System.IO;
using System.Data.OleDb;

namespace Lpnt.CoBan.Function
{
    public partial class FrmNhapTuExcel : DevExpress.XtraEditors.XtraForm
    {
        public FrmNhapTuExcel()
        {
            InitializeComponent();
        }
        private void bteDuongDan_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var op = new OpenFileDialog() { Filter = "Excel files|*.xls;*.xlsx|All files (*.*)|*.*", Multiselect = false, InitialDirectory = Application.StartupPath };
            if (op.ShowDialog() == DialogResult.OK)
            {
                bteDuongDan.Text = op.FileName;
                InitSheetNames(op.FileName);
            }
        }
        private void chkDanhSachDonVi_CheckedChanged(object sender, EventArgs e)
        {
            cboDonViSheet.Enabled = chkDanhSachDonVi.Checked;
        }
        private void chkDanhSachChiDoan_CheckedChanged(object sender, EventArgs e)
        {
            cboChiDoanSheet.Enabled = chkDanhSachChiDoan.Checked;
        }
        private void chkDanhSachNhanSu_CheckedChanged(object sender, EventArgs e)
        {

        }
        private bool ValidateExcelSheet()
        {
            var excelPath = bteDuongDan.Text;
            if (string.IsNullOrEmpty(excelPath))
            {
                MsgBox.ShowWarningDialog("Vui lòng chọn tập tin excel để import");
                return false;
            }
            if (!File.Exists(excelPath))
            {
                MsgBox.ShowWarningDialog("Tập tin excel không tồn tại");
                return false;
            }

            return true;
        }
        private void RunImportData()
        {
            if (!ValidateExcelSheet()) return;

            if (chkDanhSachDonVi.Checked && !string.IsNullOrEmpty(cboDonViSheet.Text))
            {
                MsgBox.ShowWaitForm("Nhập liệu danh sách đơn vị ...");
                ImportData.ImportDonViList(bteDuongDan.Text, cboDonViSheet.Text);
            }

            if (chkDanhSachChiDoan.Checked && !string.IsNullOrEmpty(cboChiDoanSheet.Text))
            {
                MsgBox.ShowWaitForm("Nhập liệu danh sách chi đoàn ...");
                ImportData.ImportChiDoanList(bteDuongDan.Text, cboChiDoanSheet.Text);
            }

            MsgBox.CloseWaitForm();
        }
        private void InitSheetNames(string fileName)
        {
            cboDonViSheet.Properties.Items.Clear();
            cboChiDoanSheet.Properties.Items.Clear();
            try
            {
                var conStr = string.Empty;
                if (fileName.Contains(".xlsx"))
                {
                    conStr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source="
                             + fileName + ";Extended Properties=\"Excel 12.0;HDR=YES\";";
                }
                else if (fileName.Contains(".xls"))
                {
                    conStr = "Provider=Microsoft.Jet.OLEDB.4.0;" +
                             "Data Source=" + fileName + ";Extended Properties=Excel 8.0;";
                }
                var con = new OleDbConnection(conStr);

                con.Open();
                var dt = con.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);

                if (dt == null)
                {
                    MsgBox.ShowWarningDialog("Tập tin không có sheet excel.");
                }
                var excelSheetNames = new string[dt.Rows.Count];
                var i = 0;

                foreach (DataRow row in dt.Rows)
                {
                    excelSheetNames[i] = row["TABLE_NAME"].ToString().Replace("$", "");
                    excelSheetNames[i] = excelSheetNames[i].Replace("'", "");
                    excelSheetNames[i] = excelSheetNames[i].Replace("#", ".");
                    i++;
                }
                for (var s = 0; s < excelSheetNames.Length; s++)
                {
                    if (!excelSheetNames[s].Contains("DvListSource") && !excelSheetNames[s].Contains("_"))
                    {
                        cboDonViSheet.Properties.Items.Add(excelSheetNames[s]);
                        cboChiDoanSheet.Properties.Items.Add(excelSheetNames[s]);
                    }
                }
            }
            catch (Exception ex)
            {
                MsgBox.ShowErrorDialog(ex.Message);
                bteDuongDan.ResetText();
            }
        }
        private void btnThucHien_Click(object sender, EventArgs e)
        {
            RunImportData();
        }
        private void btnDong_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
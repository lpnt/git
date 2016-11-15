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
using DevExpress.Xpo;
using DevExpress.Data.Filtering;

namespace Lpnt.CoBan.Function
{
    public partial class FrmDangNhap : DevExpress.XtraEditors.XtraForm
    {
        bool isFirstRun = false;
        const string MSG_NOT_VALIDATE = "Không hợp lệ";
        public FrmDangNhap()
        {
            InitializeComponent();

            NapGhiNho();
            // Tìm xem có phải là lần chạy đầu tiên không?
            object tmp;
            Param.GetValue("Lần chạy đầu tiên", out tmp, ParamCategory.System, true, DataType.Bool);
            isFirstRun = (bool)tmp;
        }
        private void FrmDangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            LuuGhiNho(chkGhiNhoTaiKhoan.Checked);
        }
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (CheckLogin(txtTaiKhoan.Text, txtMatKhau.Text))
            {
                LuuGhiNho(chkGhiNhoTaiKhoan.Checked);
                this.DialogResult = DialogResult.OK;
            }
        }
        private bool CheckLogin(string user, string pass)
        {
            // Tìm trong CSDL xem có User nào trùng với tên đăng nhập không?
            NguoiDung userLogin = XpoDefault.Session.FindObject<NguoiDung>(CriteriaOperator.Parse("[TaiKhoan] = ?", user));

            // Nếu có thì kiểm tra mật khẩu đúng không?
            if (userLogin != null)
            {
                if (userLogin.CheckUserPassword(pass))
                {
                    if (userLogin.KichHoat)
                    {
                        clsDuLieu.NguoiDungDangNhap = userLogin;
                        return true;
                    }
                    else
                    {
                        MsgBox.ShowWarningDialog("Tài khoản của bạn đang bị khóa.\nVui lòng liên hệ quản trị để biết chi tiết!");
                        return false;
                    }
                }
                else
                {
                    // Sai mật khẩu
                    txtMatKhau.ErrorText = MSG_NOT_VALIDATE;
                }
                return false;
            }

            // Hiện tại trong CSDL chưa có user nào, ta có thể xem đây là lần chạy đầu tiên (đối với khách hàng)
            // Ta cần tạo ra 1 user có quyền cao nhất (admin), vì chưa làm phân quyền nên chỉ cần tạo 1 user
            // Sau này thêm thông số để biết đây có phải là lần chạy đầu tiên hay k?

            // Giờ sửa lại code isFirstRun luôn
            if (userLogin == null && isFirstRun) // Đoạn code này sẽ không chạy nữa nếu không phải lần chạy đầu
            {
                if (MsgBox.ShowYesNoDialog("Đây là lần chạy đầu tiên, bạn có muốn tạo tài khoản [" + user + "] với quyền [quản trị]? ") == DialogResult.No) return false;

                userLogin = new NguoiDung(XpoDefault.Session);
                userLogin.TaiKhoan = user;
                userLogin.SetPassword(pass);
                var nhom = new NhomNguoiDung(XpoDefault.Session) { TenNhom = "Quản trị", QuanTri = true };
                nhom.Save();
                userLogin.Nhom = nhom;
                userLogin.Save();

                clsDuLieu.NguoiDungDangNhap = userLogin;

                // Cấu hình và khởi tạo dữ liệu khi sử dụng lần đầu
                string xls_donvihanhchinh = Application.StartupPath + @"\Resources\Don_Vi_Hanh_Chinh_2016.xls";
                ImportData.ImportTinhThanhList(xls_donvihanhchinh, "Tỉnh");
                ImportData.ImportHuyenQuanList(xls_donvihanhchinh, "Huyện");
                ImportData.ImportXaPhuongList(xls_donvihanhchinh, "Xã");

                clsDuLieu.KhoiTaoDuLieu();

                // Cập nhật lại isFirstRun = false;
                Param.SetValue("Lần chạy đầu tiên", false);
                return true;
            }
            if (userLogin == null)
            {
                txtMatKhau.ErrorText = MSG_NOT_VALIDATE;
            }

            return false;
        }
        private void NapGhiNho()
        {
            chkGhiNhoTaiKhoan.Checked = Convert.ToBoolean(AppConfig.GetValue("RememberLogin"));
            txtTaiKhoan.Text = AppConfig.GetValue("UserName");
            txtMatKhau.Text = AppConfig.GetValue("UserPassword");
        }
        private void LuuGhiNho(bool remember)
        {
            AppConfig.SetValue("RememberLogin", Convert.ToString(chkGhiNhoTaiKhoan.Checked));
            if (remember)
            {
                AppConfig.SetValue("UserName", txtTaiKhoan.Text.Trim());
                AppConfig.SetValue("UserPassword", txtMatKhau.Text.Trim());
            }
            else
            {
                AppConfig.SetValue("UserName", string.Empty);
                AppConfig.SetValue("UserPassword", string.Empty);
            }
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void txtTaiKhoan_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnDangNhap.PerformClick();
        }
        private void txtMatKhau_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnDangNhap.PerformClick();
        }
        /// <summary>
        /// Quên mật khẩu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void hplQuenMatKhau_Click(object sender, EventArgs e)
        {

        }
    }
}
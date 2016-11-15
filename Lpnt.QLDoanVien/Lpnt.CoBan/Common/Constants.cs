using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lpnt.CoBan.Common
{
    public class Constants
    {
        /// <summary>
        /// Thông tin tác giả
        /// </summary>
        public const string TAC_GIA_TEN = "Lê Phúc Nhã Thịnh";
        public const string TAC_GIA_SO_DIEN_THOAI = "0888 262 168";
        public const string TAC_GIA_EMAIL = "lt0888262168gmail.com";
        public const string TAC_GIA_WEBSITE = "";

        /// <summary>
        /// Dùng để tạo khoá bản quyền và khoá của khởi động cùng Windows
        /// </summary>
        public const string KHOA_CUA_PHAN_MEM = "Lpnt.QLDoanVien";
        public const string TIEN_TO_PHAN_MEM_VIET_TAT = "Lpnt.QLDoanVien";
        public const string TIEN_TO_PHAN_MEM = "Lpnt";

        /// <summary>
        /// Tên phần mềm, dùng hiển thị tiêu đề FrmTrangChu
        /// </summary>
        public const string TEN_PHAN_MEM = "Phần mềm quản lý đoàn viên";

        /// <summary>
        /// Tên cơ sở dữ liệu mặc định
        /// </summary>
        public const string TEN_CO_SO_DU_LIEU = "QuanLyDoanVien";

        /// <summary>
        /// Lọc hiển thị theo niên khóa
        /// </summary>
        public const string FILTER_NIENKHOA_DONVI = "[NienKhoa.Id] = ?";
        public const string FILTER_NIENKHOA_CHIDOAN = "[DonVi.NienKhoa.Id] = ?";
        public const string FILTER_NIENKHOA_NHANSU = "[ChiDoan.DonVi.NienKhoa.Id] = ?";

        /// <summary>
        /// Dường dẫn sử dụng trong phần mềm
        /// </summary>
        public const string HIEN_THI_COT_DIEU_KIEN = "[DanhMuc] = ? and [TenCot] = ?";

        /// <summary>
        /// Phiếu thu
        /// </summary>
        public static string INVOICE_TYPE_THU = "Phiếu thu";
        /// <summary>
        /// Phiếu chi
        /// </summary>
        public static string INVOICE_TYPE_CHI = "Phiếu chi";

        /// <summary>
        /// Phiếu nhập hàng
        /// </summary>
        public static string INVOICE_TYPE_NHAPHANG = "Phiếu nhập hàng";
        /// <summary>
        ///Phiếu xuất hàng
        /// </summary>
        public static string INVOICE_TYPE_XUATHANG = "Phiếu xuất hàng";

        /// <summary>
        /// Phiếu bán hàng
        /// </summary>
        public static string INVOICE_TYPE_BANHANG = "Phiếu bán hàng";
        /// <summary>
        /// Phiếu mua hàng
        /// </summary>
        public static string INVOICE_TYPE_MUAHANG = "Phiếu mua hàng";

        #region Format datetime number money
        /// <summary>
        /// Định dạng ngày
        /// </summary>
        public const string FORMAT_DATE_DISPLAYCODE = "Định dạng ngày";
        /// <summary>
        /// Định dạng giờ
        /// </summary>
        public const string FORMAT_TIME_DISPLAYCODE = "Định dạng giờ";

        /// <summary>
        /// Dấu cách thập phân
        /// </summary>
        public const string FORMAT_SEPARATOR_DISPLAYCODE = "Dấu cách thập phân";
        /// <summary>
        /// Dấu cách hàng ngàn
        /// </summary>
        public const string FORMAT_GROUPSEPARATOR_DISPLAYCODE = "Dấu cách hàng ngàn";
        /// <summary>
        /// Hiện thị giá trị âm
        /// </summary>
        public const string FORMAT_NEGATIVE_DISPLAYCODE = "Hiện thị giá trị âm";
        /// <summary>
        /// Số lẻ làm tròn
        /// </summary>
        public const string FORMAT_DIGITS_DISPLAYCODE = "Số lẻ làm tròn";
        #endregion
    }
}

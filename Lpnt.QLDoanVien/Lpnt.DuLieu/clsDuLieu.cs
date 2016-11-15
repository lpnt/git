using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lpnt.DuLieu
{
    public class clsDuLieu
    {
        /// <summary>
        /// Thông tin người dùng đăng nhập
        /// </summary>
        public static NguoiDung NguoiDungDangNhap
        {
            get;
            set;
        }

        public static void KhoiTaoDuLieu()
        {
            NienKhoa.KhoiTao();
        }
    }
}

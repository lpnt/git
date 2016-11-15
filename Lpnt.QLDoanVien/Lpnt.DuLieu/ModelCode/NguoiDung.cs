using System;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using DevExpress.XtraEditors.DXErrorProvider;
using System.Security.Cryptography;

namespace Lpnt.DuLieu
{

    public partial class NguoiDung
    {
        public NguoiDung(Session session) : base(session) { }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
            fKichHoat = true;
        }
        public bool CheckUserPassword(string pass)
        {
            string p = MD5Encoding(pass);
            return p.Equals(MatKhau);
        }
        public void SetPassword(string pass)
        {
            // Mã hóa mật khẩu MD5
            MatKhau = MD5Encoding(pass);
        }
        public string MD5Encoding(string Data)
        {
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            byte[] bdrr = System.Text.Encoding.UTF8.GetBytes(Data);
            byte[] barr = md5.ComputeHash(bdrr);
            return Convert.ToBase64String(barr);
        }
        public override void GetPropertyError(string propertyName, ErrorInfo info)
        {
            base.GetPropertyError(propertyName, info);

            switch (propertyName)
            {
                case "TaiKhoan":
                    if (string.IsNullOrEmpty(TaiKhoan))
                    {
                        info.ErrorType = ErrorType.Critical;
                        info.ErrorText = "Tài khoản không được trống";
                    }
                    else if (Exists(Session, ClassInfo, propertyName, TaiKhoan))
                    {
                        info.ErrorType = ErrorType.Critical;
                        info.ErrorText = "Tài khoản không được trùng";
                    }
                    break;
            }
        }
    }

}

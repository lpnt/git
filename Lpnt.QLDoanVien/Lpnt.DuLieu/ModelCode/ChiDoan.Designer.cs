﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
namespace Lpnt.DuLieu
{

    public partial class ChiDoan : BaseObject
    {
        int fStt;
        public int Stt
        {
            get { return fStt; }
            set { SetPropertyValue<int>("Stt", ref fStt, value); }
        }
        string fMaChiDoan;
        [DevExpress.Xpo.DisplayName(@"Mã chi đoàn")]
        public string MaChiDoan
        {
            get { return fMaChiDoan; }
            set { SetPropertyValue<string>("MaChiDoan", ref fMaChiDoan, value); }
        }
        string fTenChiDoan;
        [DevExpress.Xpo.DisplayName(@"Chi đoàn")]
        public string TenChiDoan
        {
            get { return fTenChiDoan; }
            set { SetPropertyValue<string>("TenChiDoan", ref fTenChiDoan, value); }
        }
        DonVi fDonVi;
        [Association(@"ChiDoanReferencesDonVi")]
        [DevExpress.Xpo.DisplayName(@"Đơn vị")]
        public DonVi DonVi
        {
            get { return fDonVi; }
            set { SetPropertyValue<DonVi>("DonVi", ref fDonVi, value); }
        }
        string fDienThoai;
        [DevExpress.Xpo.DisplayName(@"Điện thoại")]
        public string DienThoai
        {
            get { return fDienThoai; }
            set { SetPropertyValue<string>("DienThoai", ref fDienThoai, value); }
        }
        string fEmailLienHe;
        [DevExpress.Xpo.DisplayName(@"Email liên hệ")]
        public string EmailLienHe
        {
            get { return fEmailLienHe; }
            set { SetPropertyValue<string>("EmailLienHe", ref fEmailLienHe, value); }
        }
        byte[] fLogo;
        public byte[] Logo
        {
            get { return fLogo; }
            set { SetPropertyValue<byte[]>("Logo", ref fLogo, value); }
        }
        string fGhiChu;
        [DevExpress.Xpo.DisplayName(@"Ghi chú")]
        public string GhiChu
        {
            get { return fGhiChu; }
            set { SetPropertyValue<string>("GhiChu", ref fGhiChu, value); }
        }
        [Association(@"NhanSuReferencesChiDoan"), Aggregated]
        public XPCollection<NhanSu> NhanSus { get { return GetCollection<NhanSu>("NhanSus"); } }
    }

}

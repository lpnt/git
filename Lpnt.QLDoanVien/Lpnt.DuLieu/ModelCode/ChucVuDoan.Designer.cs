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

    public partial class ChucVuDoan : BaseObject
    {
        string fTenChucVuDoan;
        [DevExpress.Xpo.DisplayName(@"Chức vụ đoàn")]
        public string TenChucVuDoan
        {
            get { return fTenChucVuDoan; }
            set { SetPropertyValue<string>("TenChucVuDoan", ref fTenChucVuDoan, value); }
        }
    }

}

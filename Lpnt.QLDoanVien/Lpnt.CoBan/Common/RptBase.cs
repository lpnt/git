using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace Lpnt.CoBan.Common
{
    public partial class RptBase : DevExpress.XtraReports.UI.XtraReport
    {
        public RptBase()
        {
            InitializeComponent();
        }
        private string _TenBaoCao;

        public string TenBaoCao
        {
            get
            {
                return _TenBaoCao;
            }

            set
            {
                _TenBaoCao = value;
            }
        }
    }
}

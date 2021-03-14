using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace Cafe_MC22_Management
{
    public partial class fReport : DevExpress.XtraReports.UI.XtraReport
    {
        public fReport()
        {
            InitializeComponent();
            Init();
        }

        #region Methods

        void Init()
        {
            fromDate.Description = "Từ ngày";
            toDate.Description = "Đến ngày";
            fromDate.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            toDate.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1).AddMonths(1).AddDays(-1);
        }

        public void Submit(DateTime fromDate, DateTime toDate)
        {
            this.fromDate.Value = fromDate;
            this.toDate.Value = toDate;
            CreateDocument();
        }

        #endregion

    }
}

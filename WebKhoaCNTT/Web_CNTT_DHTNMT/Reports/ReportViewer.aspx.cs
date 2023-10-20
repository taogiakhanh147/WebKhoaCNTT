using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web_CNTT_DHTNMT.Reports
{
    public partial class ReportViewer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                List<Models.@new> lstData = new List<Models.@new>();
                Web_CNTT_DHTNMT.Controllers.AdminController _tintucController
                    = new Web_CNTT_DHTNMT.Controllers.AdminController();
                lstData = _tintucController.GetKhachHangs();

                ReportViewer1.LocalReport.ReportPath = Server.MapPath("DanhSachTinTuc.rdlc");
                ReportViewer1.LocalReport.DataSources.Clear();
                ReportViewer1.LocalReport.DataSources.Add
                    (new Microsoft.Reporting.WebForms.ReportDataSource("dsData", lstData));
            }
        }
    }
}
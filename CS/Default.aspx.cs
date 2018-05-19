using System;
using DevExpress.XtraCharts;
// ...

namespace WebChartDataBinding {
    public partial class _Default : System.Web.UI.Page {

        protected void Button1_Click(object sender, EventArgs e) {
            WebChartControl1.DataSourceID = "AccessDataSource1";
            WebChartControl1.SeriesDataMember = "Year";
            WebChartControl1.SeriesTemplate.ArgumentDataMember = "Region";
            WebChartControl1.SeriesTemplate.ValueDataMembers.AddRange(new string[] {"GSP"});
            WebChartControl1.SeriesTemplate.View = new SideBySideBarSeriesView();
            WebChartControl1.DataBind();
        }
    }

}
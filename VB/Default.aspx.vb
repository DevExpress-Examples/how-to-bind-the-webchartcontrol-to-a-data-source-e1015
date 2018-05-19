Imports System
Imports DevExpress.XtraCharts
' ...

Namespace WebChartDataBinding
    Partial Public Class _Default
        Inherits System.Web.UI.Page

        Protected Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs)
            WebChartControl1.DataSourceID = "AccessDataSource1"
            WebChartControl1.SeriesDataMember = "Year"
            WebChartControl1.SeriesTemplate.ArgumentDataMember = "Region"
            WebChartControl1.SeriesTemplate.ValueDataMembers.AddRange(New String() {"GSP"})
            WebChartControl1.SeriesTemplate.View = New SideBySideBarSeriesView()
            WebChartControl1.DataBind()
        End Sub
    End Class

End Namespace
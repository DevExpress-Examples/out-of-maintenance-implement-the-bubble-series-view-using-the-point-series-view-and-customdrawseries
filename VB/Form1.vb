Public Class Form1

    Private Sub ChartControl1_CustomDrawSeriesPoint(ByVal sender As System.Object, ByVal e As DevExpress.XtraCharts.CustomDrawSeriesPointEventArgs) Handles ChartControl1.CustomDrawSeriesPoint
        Dim drw As DataRowView = CType(e.SeriesPoint.Tag, DataRowView)
        CType(e.SeriesDrawOptions, DevExpress.XtraCharts.PointDrawOptions).Marker.Size = Convert.ToInt32(drw("Rad"))
    End Sub

    Private Sub ChartControl1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChartControl1.Click

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DataSet1.DataTable1.AddDataTable1Row("A", 10, 10)
        DataSet1.DataTable1.AddDataTable1Row("B", 20, 20)
        DataSet1.DataTable1.AddDataTable1Row("C", 30, 15)
        DataSet1.DataTable1.AddDataTable1Row("D", 40, 8)
    End Sub
End Class

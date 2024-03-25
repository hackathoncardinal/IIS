Public Class StockPrint

    Private Sub StockPrint_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'InfotectDBMS1DataSet1.stock' table. You can move, or remove it, as needed.
        Me.stockTableAdapter.Fill(Me.InfotectDBMS1DataSet1.stock)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class
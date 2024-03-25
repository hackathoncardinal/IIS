Public Class UnpaidPrint

    Private Sub UnpaidPrint_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'InfotectDBMS1DataSet1.UnRDCN1' table. You can move, or remove it, as needed.
        Me.UnRDCN1TableAdapter.Fill(Me.InfotectDBMS1DataSet1.UnRDCN1)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class
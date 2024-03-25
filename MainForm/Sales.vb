Public Class Sales

    Private Sub Sales_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'InfotectDBMS1DataSet1.RDCN1' table. You can move, or remove it, as needed.
        Me.RDCN1TableAdapter.Fill(Me.InfotectDBMS1DataSet1.RDCN1)

    End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        SalesPrint.ShowDialog()
    End Sub
End Class
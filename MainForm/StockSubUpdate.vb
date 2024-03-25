Public Class StockSubUpdate


    Private Sub StockSubUpdate_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'InfotectDBMS1DataSet1.stock' table. You can move, or remove it, as needed.
        Me.StockTableAdapter.Fill(Me.InfotectDBMS1DataSet1.stock)

    End Sub


    Private Sub DataGridView1_RowHeaderMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView1.RowHeaderMouseClick
        Try
            Dim dr As DataGridViewRow = DataGridView1.SelectedRows(0)
            ' Stock.Show()
            ' or simply use column name instead of index
            'dr.Cells["id"].Value.ToString();
            Stock.txtUPID.Text = dr.Cells(1).Value.ToString()
            Stock.txtUItem.Text = dr.Cells(2).Value.ToString()
            Stock.TxtUname.Text = dr.Cells(3).Value.ToString()
            Stock.txtUQuantity.Text = dr.Cells(4).Value.ToString()
            Me.Hide()
            Me.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
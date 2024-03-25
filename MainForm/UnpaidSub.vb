Public Class UnpaidSub
    Private Sub UnpaidSub_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'InfotectDBMS1DataSet1.UnRDCN1' table. You can move, or remove it, as needed.
        Me.UnRDCN1TableAdapter.Fill(Me.InfotectDBMS1DataSet1.UnRDCN1)
    End Sub




    Private Sub UnRDCN1DataGridView_RowHeaderMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles UnRDCN1DataGridView.RowHeaderMouseClick
        Try
            Dim dr As DataGridViewRow = UnRDCN1DataGridView.SelectedRows(0)
            '  Stock.Show()
            ' or simply use column name instead of index
            'dr.Cells["id"].Value.ToString();
            Unpaid.txtControlNo.Text = dr.Cells(0).Value.ToString()
            Unpaid.txtClientNo.Text = dr.Cells(1).Value.ToString()
            Unpaid.txtOrderNo.Text = dr.Cells(2).Value.ToString()
            '___________________________________________
            With Unpaid
                .txtCN.Text = dr.Cells(0).Value.ToString()
                .txtClient.Text = dr.Cells(1).Value.ToString()
                .txtON.Text = dr.Cells(2).Value.ToString()
                .txtCP.Text = dr.Cells(3).Value.ToString()
                .txtContactN.Text = dr.Cells(4).Value.ToString()
                .txtAddress.Text = dr.Cells(5).Value.ToString()
                .txtDateBorrowed.Text = dr.Cells(6).Value.ToString()
                .txtDateReturned.Text = dr.Cells(7).Value.ToString()
                .txtStatus.Text = "Returned"
            End With
            Me.Hide()
            Me.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
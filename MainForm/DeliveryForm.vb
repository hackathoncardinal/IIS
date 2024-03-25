Imports System.Data.OleDb
Imports System.Data
Public Class DeliveryForm
    Dim con As OleDbConnection
    Dim Command As OleDbCommand

    Private Sub DeliveryForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'InfotectDBMS1DataSet1.OrderNumber1' table. You can move, or remove it, as needed.
        Me.OrderNumber1TableAdapter.Fill(Me.InfotectDBMS1DataSet1.OrderNumber1)
        Dim ddd As Date = Now
        txtControlNo.Text = "Crt-" + ddd.ToString("yyyy") + "00" + ddd.ToString("dd") + ddd.ToString("mm") + ddd.ToString("ss")
        txtOrderNo.Text = "OD-" + ddd.ToString("yyyy") + "00" + ddd.ToString("dd") + ddd.ToString("mm") + ddd.ToString("ss")
        btnOrderLOOP.PerformClick()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        DeliverySubForm.ShowDialog()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        DeliverySubFormItem.ShowDialog()
    End Sub

    Private Sub txtProcess_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtProcess.Click
        'Table name is DeliveryControlNo

        If txtClientNo.Text = Nothing Then
            Beep()
            MsgBox("Youre ClientNo is Empty", MsgBoxStyle.Information, "Warning")
            Exit Sub
        End If

        If txtContact_Person.Text = Nothing Then
            Beep()
            MsgBox("Youre Contact_Person is Empty", MsgBoxStyle.Information, "Warning")
            Exit Sub
        End If

        If txtContact_number.Text = Nothing Then
            Beep()
            MsgBox("Youre Contact_Number is Empty", MsgBoxStyle.Information, "Warning")
            Exit Sub
        End If


        If txtDelivery.Text = Nothing Then
            Beep()
            MsgBox("Youre Delivery is Empty", MsgBoxStyle.Information, "Warning")
            Exit Sub
        End If

  
        con.Close()
        '   Try
            Dim Reader3 As OleDbDataReader
            con.Open()
            Dim Query3 As String
        Query3 = "insert into [DeliveryControlNo](ControlNo,ClientNo,OrderNo,ContactPerson,ContactNumber,Addressto,DateBorrowed,Status)  VALUES ('" & txtControlNo.Text & _
                 "','" & txtClientNo.Text & "','" & txtOrderNo.Text & "','" & txtContact_Person.Text & "','" & txtContact_number.Text & "','" & txtDelivery.Text & "','" & TimeDelivery.Text & "','" & "Unreturned" & "')"
            Command = New OleDbCommand(Query3, con)
            Reader3 = Command.ExecuteReader
        ' MessageBox.Show(".Data Process And Save 1'" & txtControlNo.Text & "'")
            con.Close()
            Me.Close()
        '      Catch ex As Exception
        '    MsgBox(ex.Message + "")
        '      End Try
        Me.Refresh()
        '____________________________________________________________
        'UnReturnedDCN
        '   Try
        Dim Reader4 As OleDbDataReader
        con.Open()
        Dim Query4 As String
        Query4 = "insert into [UnRDCN1](ControlNo,ClientNo,OrderNo,ContactPerson,ContactNumber,Addressto,DateBorrowed,Status)  VALUES ('" & txtControlNo.Text & _
                 "','" & txtClientNo.Text & "','" & txtOrderNo.Text & "','" & txtContact_Person.Text & "','" & txtContact_number.Text & "','" & txtDelivery.Text & "','" & TimeDelivery.Text & "','" & "Unreturned" & "')"
        Command = New OleDbCommand(Query4, con)
        Reader4 = Command.ExecuteReader
        MessageBox.Show(".Data Process And Save 2'" & txtControlNo.Text & "'")
        con.Close()
        Me.Close()
        '      Catch ex As Exception
        '    MsgBox(ex.Message + "")
        '      End Try
        Me.Refresh()

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        '-----------------------------------------Update Section
        con = New OleDbConnection
        con.ConnectionString = ConString
        Dim Reader As OleDbDataReader
        Dim Reader1 As OleDbDataReader
        Try
            con.Open()
            Dim Query As String

            Query = "UPDATE [stock] SET Quantity='" & CInt(Val(txtProductStock.Text + 0) - Val(txtProductPcs.Text + 0)) & "' where ProductID='" & txtProductID.Text & "'"
            Command = New OleDbCommand(Query, con)
            Reader = Command.ExecuteReader
            con.Close()
            MessageBox.Show("Data Update")
            con.Open()
            Dim Query1 As String
            Query1 = "insert into [OrderNumber1](OrderNo,ProductID,ProductName,Pcs,DateOrder)  VALUES ('" & txtOrderNo.Text & _
                 "','" & txtProductID.Text & "','" & txtProductName.Text & "','" & CInt(txtProductPcs.Text) & "','" & TimeDelivery.Text & "')"
            Command = New OleDbCommand(Query1, con)
            Reader1 = Command.ExecuteReader
            MessageBox.Show("Data Save '" & txtOrderNo.Text & "'")
            ' Me.OrderNumber1TableAdapter5.Fill(Me.Jdb1DataSet1.OrderNumber1)
            Me.OrderNumber1TableAdapter.Fill(Me.InfotectDBMS1DataSet1.OrderNumber1)
            ORDERTEXXT.Text = txtOrderNo.Text
            btnOrderLOOP.PerformClick()
            con.Close()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try

        MessageBox.Show("Successfully Update", "Stock Details", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Button5.PerformClick()
    End Sub

    Private Sub txtProductPcs_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtProductPcs.KeyPress
        If (e.KeyChar < Chr(48) Or e.KeyChar > Chr(57)) And e.KeyChar <> Chr(8) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtProductPcs_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtProductPcs.TextChanged
        If Val(txtProductPcs.Text) <= Val(txtProductStock.Text) Then
        Else
            MessageBox.Show("The Item Stock is Only '" & txtProductStock.Text & "' ")
            txtProductPcs.Text = 0
        End If
    End Sub

    Private Sub FillByToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOrderLOOP.Click
        Try
            Me.OrderNumber1TableAdapter.FillBy(Me.InfotectDBMS1DataSet1.OrderNumber1, ORDERTEXXT.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub
End Class
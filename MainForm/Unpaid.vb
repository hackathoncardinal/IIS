Imports System.Data.OleDb
Imports System.Data
Imports System.IO
Imports Excel = Microsoft.Office.Interop.Excel
Imports System.Security.Cryptography
Imports System.Text
Public Class Unpaid
    Dim con As OleDbConnection
    Dim Command As OleDbCommand

    Private Sub btn_paid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_paid.Click
        If txtControlNo.Text = Nothing Then
            Beep()
            MsgBox("You're ControlNo TextBox is Empty", MsgBoxStyle.Information, "Warning")
            Exit Sub
        End If
        '_________________________________________________________________
        '-DELETED SECTION

        con = New OleDbConnection
        con.ConnectionString = ConString
        Dim Reader1 As OleDbDataReader
        Try
            con.Open()
            Dim Query1 As String
            Query1 = "delete from [UnRDCN1] where ControlNo='" & txtCN.Text & "'"
            Command = New OleDbCommand(Query1, con)
            Reader1 = Command.ExecuteReader
            '  MessageBox.Show("Data Delete")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        Finally
            con.Close()
        End Try

        '_______DELETED_______________________________________________()

        con = New OleDbConnection
        con.ConnectionString = ConString
        Dim Reader2 As OleDbDataReader
        Try
            con.Open()
            Dim Query2 As String
            Query2 = "insert into [RDCN1]([ControlNo],[ClientNo],[OrderNo],[ContactPerson],[ContactNumber],[Addressto],[DateBorrowed],[DateReturned],[Status])  VALUES ('" & txtCN.Text & "','" & txtClient.Text & "','" & txtON.Text & "','" & txtCP.Text & "','" & txtContactN.Text & "','" & txtAddress.Text & "','" & txtDateBorrowed.Text & "','" & DateTimePicker1.Text & "','" & txtStatus.Text & "')"
            Command = New OleDbCommand(Query2, con)
            Reader2 = Command.ExecuteReader
            MessageBox.Show("Inventory UPdate")

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        Finally
            con.Close()
        End Try
        Me.UnRDCN1TableAdapter.Fill(Me.InfotectDBMS1DataSet1.UnRDCN1)
        Clear()
    End Sub

    Sub Clear()
        txtClientNo.Clear()
        txtControlNo.Clear()
        txtOrderNo.Clear()
    End Sub

    Private Sub Unpaid_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'InfotectDBMS1DataSet1.UnRDCN1' table. You can move, or remove it, as needed.
        Me.UnRDCN1TableAdapter.Fill(Me.InfotectDBMS1DataSet1.UnRDCN1)

    End Sub


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        UnpaidSub.ShowDialog()
    End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        UnpaidPrint.ShowDialog()
    End Sub
End Class
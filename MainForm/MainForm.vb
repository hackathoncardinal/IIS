Public Class MainForm

    Private Sub btn_Registration_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Registration.Click
        PictureBox2.Visible = False
        RegistrationForm.ShowDialog()
    End Sub

    Private Sub btn_about_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        PictureBox2.Visible = False
        AboutForm.Show()
    End Sub

    Private Sub MainForm_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs)
        PictureBox2.Visible = False
    End Sub

   

    Private Sub btn_Home_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Home.Click
        PictureBox2.Visible = True
    End Sub


    Private Sub btn_Delivery_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Delivery.Click
        PictureBox2.Visible = False
        DeliveryForm.ShowDialog()
    End Sub

    Private Sub btn_Client_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Client.Click
        PictureBox2.Visible = False
        Client_form.ShowDialog()
    End Sub

    Private Sub btn_Stock_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Stock.Click
        PictureBox2.Visible = False
        Stock.ShowDialog()
    End Sub

    Private Sub btn_unpaid_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_unpaid.Click
        PictureBox2.Visible = False
        Unpaid.ShowDialog()
    End Sub

    Private Sub btn_SalesSummary_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_SalesSummary.Click
        PictureBox2.Visible = False
        Sales.ShowDialog()
    End Sub

    Private Sub btn_logout_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_logout.Click
        PictureBox2.Visible = False
        Beep()
        If MsgBox("Oops", MsgBoxStyle.YesNo, "Logout") = MsgBoxResult.Yes Then
            LoginForm.Show()
            Me.Close()
        End If
    End Sub

    Private Sub btn_about_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_about.Click
        PictureBox2.Visible = False
        AboutForm.ShowDialog()
    End Sub

    Private Sub MainForm_Load_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'InfotectDBMS1DataSet1.UnRDCN1' table. You can move, or remove it, as needed.
        Me.UnRDCN1TableAdapter.Fill(Me.InfotectDBMS1DataSet1.UnRDCN1)
        'TODO: This line of code loads data into the 'InfotectDBMS1DataSet1.stock' table. You can move, or remove it, as needed.
        Me.StockTableAdapter.Fill(Me.InfotectDBMS1DataSet1.stock)

        tsUser.Text = "Login As : " + LoginForm.Label6.Text
        tsUsername.Text = "Name : " + LoginForm.TextBox1.Text

        If tsUser.Text = "Login As : " + "Guest" Then
            btn_Registration.Enabled = False
            '--------------deliveryform
            DeliveryForm.Button3.Enabled = False
            DeliveryForm.Button4.Enabled = False
            DeliveryForm.txtProcess.Enabled = False
            DeliveryForm.Button2.Enabled = False
            '--------------deliveryform
        End If
        If tsUser.Text = "Login As : " + "Admin" Then
            btn_Registration.Enabled = True
        End If
        Timer1.Start()

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Me.StockTableAdapter.Fill(Me.InfotectDBMS1DataSet1.stock)
        Me.UnRDCN1TableAdapter.Fill(Me.InfotectDBMS1DataSet1.UnRDCN1)
    End Sub
End Class
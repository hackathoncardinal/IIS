<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Unpaid
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ControlNoLabel As System.Windows.Forms.Label
        Dim ClientNoLabel As System.Windows.Forms.Label
        Dim OrderNoLabel As System.Windows.Forms.Label
        Dim ContactPersonLabel As System.Windows.Forms.Label
        Dim ContactNumberLabel As System.Windows.Forms.Label
        Dim AddresstoLabel As System.Windows.Forms.Label
        Dim DateReturnedLabel As System.Windows.Forms.Label
        Dim StatusLabel As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim Label6 As System.Windows.Forms.Label
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.btn_paid = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtControlNo = New System.Windows.Forms.TextBox()
        Me.ClientNo = New System.Windows.Forms.Label()
        Me.txtClientNo = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtOrderNo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.InfotectDBMS1DataSet1 = New Infotech.InfotectDBMS1DataSet1()
        Me.UnRDCN1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UnRDCN1TableAdapter = New Infotech.InfotectDBMS1DataSet1TableAdapters.UnRDCN1TableAdapter()
        Me.TableAdapterManager = New Infotech.InfotectDBMS1DataSet1TableAdapters.TableAdapterManager()
        Me.UnRDCN1DataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtCN = New System.Windows.Forms.TextBox()
        Me.txtClient = New System.Windows.Forms.TextBox()
        Me.txtON = New System.Windows.Forms.TextBox()
        Me.txtCP = New System.Windows.Forms.TextBox()
        Me.txtContactN = New System.Windows.Forms.TextBox()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.txtStatus = New System.Windows.Forms.TextBox()
        Me.txtDateReturned = New System.Windows.Forms.DateTimePicker()
        Me.txtDateBorrowed = New System.Windows.Forms.DateTimePicker()
        Me.btnPrint = New System.Windows.Forms.Button()
        ControlNoLabel = New System.Windows.Forms.Label()
        ClientNoLabel = New System.Windows.Forms.Label()
        OrderNoLabel = New System.Windows.Forms.Label()
        ContactPersonLabel = New System.Windows.Forms.Label()
        ContactNumberLabel = New System.Windows.Forms.Label()
        AddresstoLabel = New System.Windows.Forms.Label()
        DateReturnedLabel = New System.Windows.Forms.Label()
        StatusLabel = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        Label6 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.InfotectDBMS1DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UnRDCN1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UnRDCN1DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ControlNoLabel
        '
        ControlNoLabel.AutoSize = True
        ControlNoLabel.Location = New System.Drawing.Point(37, 427)
        ControlNoLabel.Name = "ControlNoLabel"
        ControlNoLabel.Size = New System.Drawing.Size(60, 13)
        ControlNoLabel.TabIndex = 45
        ControlNoLabel.Text = "Control No:"
        '
        'ClientNoLabel
        '
        ClientNoLabel.AutoSize = True
        ClientNoLabel.Location = New System.Drawing.Point(37, 453)
        ClientNoLabel.Name = "ClientNoLabel"
        ClientNoLabel.Size = New System.Drawing.Size(53, 13)
        ClientNoLabel.TabIndex = 47
        ClientNoLabel.Text = "Client No:"
        '
        'OrderNoLabel
        '
        OrderNoLabel.AutoSize = True
        OrderNoLabel.Location = New System.Drawing.Point(37, 479)
        OrderNoLabel.Name = "OrderNoLabel"
        OrderNoLabel.Size = New System.Drawing.Size(53, 13)
        OrderNoLabel.TabIndex = 49
        OrderNoLabel.Text = "Order No:"
        '
        'ContactPersonLabel
        '
        ContactPersonLabel.AutoSize = True
        ContactPersonLabel.Location = New System.Drawing.Point(37, 505)
        ContactPersonLabel.Name = "ContactPersonLabel"
        ContactPersonLabel.Size = New System.Drawing.Size(83, 13)
        ContactPersonLabel.TabIndex = 51
        ContactPersonLabel.Text = "Contact Person:"
        '
        'ContactNumberLabel
        '
        ContactNumberLabel.AutoSize = True
        ContactNumberLabel.Location = New System.Drawing.Point(37, 531)
        ContactNumberLabel.Name = "ContactNumberLabel"
        ContactNumberLabel.Size = New System.Drawing.Size(87, 13)
        ContactNumberLabel.TabIndex = 53
        ContactNumberLabel.Text = "Contact Number:"
        '
        'AddresstoLabel
        '
        AddresstoLabel.AutoSize = True
        AddresstoLabel.Location = New System.Drawing.Point(37, 557)
        AddresstoLabel.Name = "AddresstoLabel"
        AddresstoLabel.Size = New System.Drawing.Size(57, 13)
        AddresstoLabel.TabIndex = 55
        AddresstoLabel.Text = "Addressto:"
        '
        'DateReturnedLabel
        '
        DateReturnedLabel.AutoSize = True
        DateReturnedLabel.Location = New System.Drawing.Point(37, 614)
        DateReturnedLabel.Name = "DateReturnedLabel"
        DateReturnedLabel.Size = New System.Drawing.Size(80, 13)
        DateReturnedLabel.TabIndex = 59
        DateReturnedLabel.Text = "Date Returned:"
        '
        'StatusLabel
        '
        StatusLabel.AutoSize = True
        StatusLabel.Location = New System.Drawing.Point(37, 639)
        StatusLabel.Name = "StatusLabel"
        StatusLabel.Size = New System.Drawing.Size(40, 13)
        StatusLabel.TabIndex = 61
        StatusLabel.Text = "Status:"
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.Location = New System.Drawing.Point(90, 179)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(80, 13)
        Label4.TabIndex = 66
        Label4.Text = "Date Returned:"
        '
        'Label6
        '
        Label6.AutoSize = True
        Label6.Location = New System.Drawing.Point(37, 588)
        Label6.Name = "Label6"
        Label6.Size = New System.Drawing.Size(81, 13)
        Label6.TabIndex = 66
        Label6.Text = "Date Borrowed:"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(928, 44)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(91, 23)
        Me.Button2.TabIndex = 42
        Me.Button2.Text = "Select"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(746, 15)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 41
        Me.Button1.Text = "Export Excel"
        Me.Button1.UseVisualStyleBackColor = False
        Me.Button1.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1.Controls.Add(Label4)
        Me.GroupBox1.Controls.Add(Me.btn_paid)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtControlNo)
        Me.GroupBox1.Controls.Add(Me.ClientNo)
        Me.GroupBox1.Controls.Add(Me.txtClientNo)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtOrderNo)
        Me.GroupBox1.Location = New System.Drawing.Point(836, 72)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(261, 259)
        Me.GroupBox1.TabIndex = 40
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "dd/MMM/yyyy"
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(30, 144)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 67
        '
        'btn_paid
        '
        Me.btn_paid.Location = New System.Drawing.Point(158, 230)
        Me.btn_paid.Name = "btn_paid"
        Me.btn_paid.Size = New System.Drawing.Size(91, 23)
        Me.btn_paid.TabIndex = 35
        Me.btn_paid.Text = "Returned"
        Me.btn_paid.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(90, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 13)
        Me.Label5.TabIndex = 34
        Me.Label5.Text = "Control Number"
        '
        'txtControlNo
        '
        Me.txtControlNo.Location = New System.Drawing.Point(11, 32)
        Me.txtControlNo.Name = "txtControlNo"
        Me.txtControlNo.ReadOnly = True
        Me.txtControlNo.Size = New System.Drawing.Size(238, 20)
        Me.txtControlNo.TabIndex = 33
        '
        'ClientNo
        '
        Me.ClientNo.AutoSize = True
        Me.ClientNo.Location = New System.Drawing.Point(107, 102)
        Me.ClientNo.Name = "ClientNo"
        Me.ClientNo.Size = New System.Drawing.Size(47, 13)
        Me.ClientNo.TabIndex = 32
        Me.ClientNo.Text = "ClientNo"
        '
        'txtClientNo
        '
        Me.txtClientNo.Location = New System.Drawing.Point(18, 118)
        Me.txtClientNo.Name = "txtClientNo"
        Me.txtClientNo.ReadOnly = True
        Me.txtClientNo.Size = New System.Drawing.Size(223, 20)
        Me.txtClientNo.TabIndex = 31
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(103, 62)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Order No."
        '
        'txtOrderNo
        '
        Me.txtOrderNo.Location = New System.Drawing.Point(11, 78)
        Me.txtOrderNo.Name = "txtOrderNo"
        Me.txtOrderNo.ReadOnly = True
        Me.txtOrderNo.Size = New System.Drawing.Size(238, 20)
        Me.txtOrderNo.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(925, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 13)
        Me.Label2.TabIndex = 39
        Me.Label2.Text = "Select Control #"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(381, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(119, 25)
        Me.Label1.TabIndex = 38
        Me.Label1.Text = "Unreturned"
        '
        'InfotectDBMS1DataSet1
        '
        Me.InfotectDBMS1DataSet1.DataSetName = "InfotectDBMS1DataSet1"
        Me.InfotectDBMS1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'UnRDCN1BindingSource
        '
        Me.UnRDCN1BindingSource.DataMember = "UnRDCN1"
        Me.UnRDCN1BindingSource.DataSource = Me.InfotectDBMS1DataSet1
        '
        'UnRDCN1TableAdapter
        '
        Me.UnRDCN1TableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ClientFormTableAdapter = Nothing
        Me.TableAdapterManager.DeliveryControlNoTableAdapter = Nothing
        Me.TableAdapterManager.OrderNumber1TableAdapter = Nothing
        Me.TableAdapterManager.RDCN1TableAdapter = Nothing
        Me.TableAdapterManager.RegistrationTableAdapter = Nothing
        Me.TableAdapterManager.stockTableAdapter = Nothing
        Me.TableAdapterManager.UnRDCN1TableAdapter = Me.UnRDCN1TableAdapter
        Me.TableAdapterManager.UpdateOrder = Infotech.InfotectDBMS1DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'UnRDCN1DataGridView
        '
        Me.UnRDCN1DataGridView.AllowUserToAddRows = False
        Me.UnRDCN1DataGridView.AllowUserToDeleteRows = False
        Me.UnRDCN1DataGridView.AutoGenerateColumns = False
        Me.UnRDCN1DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.UnRDCN1DataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10})
        Me.UnRDCN1DataGridView.DataSource = Me.UnRDCN1BindingSource
        Me.UnRDCN1DataGridView.Location = New System.Drawing.Point(6, 44)
        Me.UnRDCN1DataGridView.Name = "UnRDCN1DataGridView"
        Me.UnRDCN1DataGridView.ReadOnly = True
        Me.UnRDCN1DataGridView.Size = New System.Drawing.Size(818, 314)
        Me.UnRDCN1DataGridView.TabIndex = 43
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "ControlNo"
        Me.DataGridViewTextBoxColumn2.HeaderText = "ControlNo"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "ClientNo"
        Me.DataGridViewTextBoxColumn3.HeaderText = "ClientNo"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "OrderNo"
        Me.DataGridViewTextBoxColumn4.HeaderText = "OrderNo"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "ContactPerson"
        Me.DataGridViewTextBoxColumn5.HeaderText = "ContactPerson"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "ContactNumber"
        Me.DataGridViewTextBoxColumn6.HeaderText = "ContactNumber"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Addressto"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Addressto"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "DateBorrowed"
        Me.DataGridViewTextBoxColumn8.HeaderText = "DateBorrowed"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "DateReturned"
        Me.DataGridViewTextBoxColumn9.HeaderText = "DateReturned"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "Status"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Status"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        '
        'txtCN
        '
        Me.txtCN.Location = New System.Drawing.Point(130, 424)
        Me.txtCN.Name = "txtCN"
        Me.txtCN.Size = New System.Drawing.Size(200, 20)
        Me.txtCN.TabIndex = 63
        '
        'txtClient
        '
        Me.txtClient.Location = New System.Drawing.Point(130, 450)
        Me.txtClient.Name = "txtClient"
        Me.txtClient.Size = New System.Drawing.Size(200, 20)
        Me.txtClient.TabIndex = 64
        '
        'txtON
        '
        Me.txtON.Location = New System.Drawing.Point(130, 476)
        Me.txtON.Name = "txtON"
        Me.txtON.Size = New System.Drawing.Size(200, 20)
        Me.txtON.TabIndex = 64
        '
        'txtCP
        '
        Me.txtCP.Location = New System.Drawing.Point(130, 502)
        Me.txtCP.Name = "txtCP"
        Me.txtCP.Size = New System.Drawing.Size(200, 20)
        Me.txtCP.TabIndex = 64
        '
        'txtContactN
        '
        Me.txtContactN.Location = New System.Drawing.Point(130, 528)
        Me.txtContactN.Name = "txtContactN"
        Me.txtContactN.Size = New System.Drawing.Size(200, 20)
        Me.txtContactN.TabIndex = 64
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(130, 554)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(200, 20)
        Me.txtAddress.TabIndex = 64
        '
        'txtStatus
        '
        Me.txtStatus.Location = New System.Drawing.Point(130, 636)
        Me.txtStatus.Name = "txtStatus"
        Me.txtStatus.Size = New System.Drawing.Size(200, 20)
        Me.txtStatus.TabIndex = 64
        '
        'txtDateReturned
        '
        Me.txtDateReturned.CustomFormat = "dd/MMM/yyyy"
        Me.txtDateReturned.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtDateReturned.Location = New System.Drawing.Point(130, 609)
        Me.txtDateReturned.Name = "txtDateReturned"
        Me.txtDateReturned.Size = New System.Drawing.Size(200, 20)
        Me.txtDateReturned.TabIndex = 65
        '
        'txtDateBorrowed
        '
        Me.txtDateBorrowed.CustomFormat = "dd/MMM/yyyy"
        Me.txtDateBorrowed.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtDateBorrowed.Location = New System.Drawing.Point(130, 583)
        Me.txtDateBorrowed.Name = "txtDateBorrowed"
        Me.txtDateBorrowed.Size = New System.Drawing.Size(200, 20)
        Me.txtDateBorrowed.TabIndex = 67
        '
        'btnPrint
        '
        Me.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrint.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.Location = New System.Drawing.Point(6, 10)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(75, 31)
        Me.btnPrint.TabIndex = 68
        Me.btnPrint.Text = "Print"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'Unpaid
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Infotech.My.Resources.Resources._27101950596
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1117, 369)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.txtDateBorrowed)
        Me.Controls.Add(Label6)
        Me.Controls.Add(Me.txtDateReturned)
        Me.Controls.Add(Me.txtStatus)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.txtContactN)
        Me.Controls.Add(Me.txtCP)
        Me.Controls.Add(Me.txtON)
        Me.Controls.Add(Me.txtClient)
        Me.Controls.Add(Me.txtCN)
        Me.Controls.Add(ControlNoLabel)
        Me.Controls.Add(ClientNoLabel)
        Me.Controls.Add(OrderNoLabel)
        Me.Controls.Add(ContactPersonLabel)
        Me.Controls.Add(ContactNumberLabel)
        Me.Controls.Add(AddresstoLabel)
        Me.Controls.Add(DateReturnedLabel)
        Me.Controls.Add(StatusLabel)
        Me.Controls.Add(Me.UnRDCN1DataGridView)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.Name = "Unpaid"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.InfotectDBMS1DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UnRDCN1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UnRDCN1DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_paid As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtControlNo As System.Windows.Forms.TextBox
    Friend WithEvents ClientNo As System.Windows.Forms.Label
    Friend WithEvents txtClientNo As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtOrderNo As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents InfotectDBMS1DataSet1 As Infotech.InfotectDBMS1DataSet1
    Friend WithEvents UnRDCN1BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents UnRDCN1TableAdapter As Infotech.InfotectDBMS1DataSet1TableAdapters.UnRDCN1TableAdapter
    Friend WithEvents TableAdapterManager As Infotech.InfotectDBMS1DataSet1TableAdapters.TableAdapterManager
    Friend WithEvents UnRDCN1DataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtCN As System.Windows.Forms.TextBox
    Friend WithEvents txtClient As System.Windows.Forms.TextBox
    Friend WithEvents txtON As System.Windows.Forms.TextBox
    Friend WithEvents txtCP As System.Windows.Forms.TextBox
    Friend WithEvents txtContactN As System.Windows.Forms.TextBox
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents txtStatus As System.Windows.Forms.TextBox
    Friend WithEvents txtDateReturned As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtDateBorrowed As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnPrint As System.Windows.Forms.Button
End Class

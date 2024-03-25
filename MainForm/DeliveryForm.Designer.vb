<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DeliveryForm
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
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtProductPcs = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtProductStock = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtProductName = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtProductID = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.txtDelivery = New System.Windows.Forms.TextBox()
        Me.txtContact_number = New System.Windows.Forms.TextBox()
        Me.txtContact_Person = New System.Windows.Forms.TextBox()
        Me.txtOrderNo = New System.Windows.Forms.TextBox()
        Me.txtClientNo = New System.Windows.Forms.TextBox()
        Me.txtControlNo = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TimeDelivery = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtProcess = New System.Windows.Forms.Button()
        Me.InfotectDBMS1DataSet1 = New Infotech.InfotectDBMS1DataSet1()
        Me.OrderNumber1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OrderNumber1TableAdapter = New Infotech.InfotectDBMS1DataSet1TableAdapters.OrderNumber1TableAdapter()
        Me.TableAdapterManager = New Infotech.InfotectDBMS1DataSet1TableAdapters.TableAdapterManager()
        Me.OrderNumber1DataGridView = New System.Windows.Forms.DataGridView()
        Me.FillByToolStrip = New System.Windows.Forms.ToolStrip()
        Me.OrderNoToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.ORDERTEXXT = New System.Windows.Forms.ToolStripTextBox()
        Me.btnOrderLOOP = New System.Windows.Forms.ToolStripButton()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.InfotectDBMS1DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderNumber1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderNumber1DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FillByToolStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(512, 244)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(61, 46)
        Me.Button5.TabIndex = 47
        Me.Button5.Text = "Clear" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Item"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(512, 202)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(61, 38)
        Me.Button4.TabIndex = 46
        Me.Button4.Text = "Select" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Item"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.Location = New System.Drawing.Point(510, 294)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(66, 54)
        Me.Button3.TabIndex = 45
        Me.Button3.Text = "Add " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Chart"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtProductPcs)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.txtProductStock)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.txtProductName)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.txtProductID)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Location = New System.Drawing.Point(15, 196)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(488, 152)
        Me.GroupBox3.TabIndex = 43
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Chart Details"
        '
        'txtProductPcs
        '
        Me.txtProductPcs.Location = New System.Drawing.Point(86, 107)
        Me.txtProductPcs.MaxLength = 11
        Me.txtProductPcs.Name = "txtProductPcs"
        Me.txtProductPcs.Size = New System.Drawing.Size(166, 20)
        Me.txtProductPcs.TabIndex = 23
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(6, 110)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(25, 13)
        Me.Label14.TabIndex = 22
        Me.Label14.Text = "Pcs"
        '
        'txtProductStock
        '
        Me.txtProductStock.Location = New System.Drawing.Point(99, 77)
        Me.txtProductStock.MaxLength = 11
        Me.txtProductStock.Name = "txtProductStock"
        Me.txtProductStock.ReadOnly = True
        Me.txtProductStock.Size = New System.Drawing.Size(130, 20)
        Me.txtProductStock.TabIndex = 21
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(7, 81)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(77, 13)
        Me.Label13.TabIndex = 20
        Me.Label13.Text = "Quantity Stock"
        '
        'txtProductName
        '
        Me.txtProductName.Location = New System.Drawing.Point(86, 54)
        Me.txtProductName.MaxLength = 11
        Me.txtProductName.Name = "txtProductName"
        Me.txtProductName.ReadOnly = True
        Me.txtProductName.Size = New System.Drawing.Size(396, 20)
        Me.txtProductName.TabIndex = 17
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(6, 57)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(64, 13)
        Me.Label11.TabIndex = 16
        Me.Label11.Text = "ITEM Name"
        '
        'txtProductID
        '
        Me.txtProductID.Location = New System.Drawing.Point(86, 26)
        Me.txtProductID.MaxLength = 11
        Me.txtProductID.Name = "txtProductID"
        Me.txtProductID.ReadOnly = True
        Me.txtProductID.Size = New System.Drawing.Size(396, 20)
        Me.txtProductID.TabIndex = 15
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 31)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(66, 13)
        Me.Label10.TabIndex = 14
        Me.Label10.Text = "ITEM CODE"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(294, 32)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(20, 21)
        Me.Button2.TabIndex = 41
        Me.Button2.Text = "<"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'txtDelivery
        '
        Me.txtDelivery.Location = New System.Drawing.Point(97, 135)
        Me.txtDelivery.Name = "txtDelivery"
        Me.txtDelivery.Size = New System.Drawing.Size(428, 20)
        Me.txtDelivery.TabIndex = 38
        '
        'txtContact_number
        '
        Me.txtContact_number.Location = New System.Drawing.Point(98, 108)
        Me.txtContact_number.MaxLength = 11
        Me.txtContact_number.Name = "txtContact_number"
        Me.txtContact_number.Size = New System.Drawing.Size(191, 20)
        Me.txtContact_number.TabIndex = 37
        '
        'txtContact_Person
        '
        Me.txtContact_Person.Location = New System.Drawing.Point(98, 77)
        Me.txtContact_Person.Name = "txtContact_Person"
        Me.txtContact_Person.Size = New System.Drawing.Size(289, 20)
        Me.txtContact_Person.TabIndex = 36
        '
        'txtOrderNo
        '
        Me.txtOrderNo.Location = New System.Drawing.Point(97, 54)
        Me.txtOrderNo.Name = "txtOrderNo"
        Me.txtOrderNo.ReadOnly = True
        Me.txtOrderNo.Size = New System.Drawing.Size(191, 20)
        Me.txtOrderNo.TabIndex = 35
        '
        'txtClientNo
        '
        Me.txtClientNo.Location = New System.Drawing.Point(97, 32)
        Me.txtClientNo.Name = "txtClientNo"
        Me.txtClientNo.ReadOnly = True
        Me.txtClientNo.Size = New System.Drawing.Size(191, 20)
        Me.txtClientNo.TabIndex = 34
        '
        'txtControlNo
        '
        Me.txtControlNo.Location = New System.Drawing.Point(97, 6)
        Me.txtControlNo.Name = "txtControlNo"
        Me.txtControlNo.ReadOnly = True
        Me.txtControlNo.Size = New System.Drawing.Size(192, 20)
        Me.txtControlNo.TabIndex = 33
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(12, 111)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(84, 13)
        Me.Label8.TabIndex = 32
        Me.Label8.Text = "Contact Number"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 84)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 13)
        Me.Label7.TabIndex = 31
        Me.Label7.Text = "Contact Person"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TimeDelivery)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Location = New System.Drawing.Point(579, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(299, 91)
        Me.GroupBox1.TabIndex = 30
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Date Borrowed"
        '
        'TimeDelivery
        '
        Me.TimeDelivery.CustomFormat = "dd/MMM/yyyy"
        Me.TimeDelivery.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.TimeDelivery.Location = New System.Drawing.Point(66, 34)
        Me.TimeDelivery.Name = "TimeDelivery"
        Me.TimeDelivery.Size = New System.Drawing.Size(227, 20)
        Me.TimeDelivery.TabIndex = 27
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 34)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Delivery"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 138)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 13)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "Address"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 61)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "Order No."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Client No."
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 13)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Control No."
        '
        'txtProcess
        '
        Me.txtProcess.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProcess.Location = New System.Drawing.Point(793, 615)
        Me.txtProcess.Name = "txtProcess"
        Me.txtProcess.Size = New System.Drawing.Size(126, 58)
        Me.txtProcess.TabIndex = 25
        Me.txtProcess.Text = "Process"
        Me.txtProcess.UseVisualStyleBackColor = True
        '
        'InfotectDBMS1DataSet1
        '
        Me.InfotectDBMS1DataSet1.DataSetName = "InfotectDBMS1DataSet1"
        Me.InfotectDBMS1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'OrderNumber1BindingSource
        '
        Me.OrderNumber1BindingSource.DataMember = "OrderNumber1"
        Me.OrderNumber1BindingSource.DataSource = Me.InfotectDBMS1DataSet1
        '
        'OrderNumber1TableAdapter
        '
        Me.OrderNumber1TableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ClientFormTableAdapter = Nothing
        Me.TableAdapterManager.DeliveryControlNoTableAdapter = Nothing
        Me.TableAdapterManager.OrderNumber1TableAdapter = Me.OrderNumber1TableAdapter
        Me.TableAdapterManager.RDCN1TableAdapter = Nothing
        Me.TableAdapterManager.RegistrationTableAdapter = Nothing
        Me.TableAdapterManager.stockTableAdapter = Nothing
        Me.TableAdapterManager.UnRDCN1TableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Infotech.InfotectDBMS1DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'OrderNumber1DataGridView
        '
        Me.OrderNumber1DataGridView.AllowUserToAddRows = False
        Me.OrderNumber1DataGridView.AllowUserToDeleteRows = False
        Me.OrderNumber1DataGridView.AutoGenerateColumns = False
        Me.OrderNumber1DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.OrderNumber1DataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.OrderNumber1DataGridView.DataSource = Me.OrderNumber1BindingSource
        Me.OrderNumber1DataGridView.Location = New System.Drawing.Point(0, 354)
        Me.OrderNumber1DataGridView.Name = "OrderNumber1DataGridView"
        Me.OrderNumber1DataGridView.ReadOnly = True
        Me.OrderNumber1DataGridView.Size = New System.Drawing.Size(787, 327)
        Me.OrderNumber1DataGridView.TabIndex = 48
        '
        'FillByToolStrip
        '
        Me.FillByToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OrderNoToolStripLabel, Me.ORDERTEXXT, Me.btnOrderLOOP})
        Me.FillByToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.FillByToolStrip.Name = "FillByToolStrip"
        Me.FillByToolStrip.Size = New System.Drawing.Size(939, 25)
        Me.FillByToolStrip.TabIndex = 49
        Me.FillByToolStrip.Text = "FillByToolStrip"
        Me.FillByToolStrip.Visible = False
        '
        'OrderNoToolStripLabel
        '
        Me.OrderNoToolStripLabel.Name = "OrderNoToolStripLabel"
        Me.OrderNoToolStripLabel.Size = New System.Drawing.Size(56, 22)
        Me.OrderNoToolStripLabel.Text = "OrderNo:"
        '
        'ORDERTEXXT
        '
        Me.ORDERTEXXT.Name = "ORDERTEXXT"
        Me.ORDERTEXXT.Size = New System.Drawing.Size(100, 25)
        '
        'btnOrderLOOP
        '
        Me.btnOrderLOOP.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnOrderLOOP.Name = "btnOrderLOOP"
        Me.btnOrderLOOP.Size = New System.Drawing.Size(39, 22)
        Me.btnOrderLOOP.Text = "FillBy"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "OrderNo"
        Me.DataGridViewTextBoxColumn2.HeaderText = "OrderNo"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Visible = False
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "ProductID"
        Me.DataGridViewTextBoxColumn3.HeaderText = "ITEMCODE"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "ProductName"
        Me.DataGridViewTextBoxColumn4.HeaderText = "ITEM NAME"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Pcs"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Pcs"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "DateOrder"
        Me.DataGridViewTextBoxColumn6.HeaderText = "DateOrder"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'DeliveryForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Infotech.My.Resources.Resources._27101950596
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(939, 701)
        Me.Controls.Add(Me.FillByToolStrip)
        Me.Controls.Add(Me.OrderNumber1DataGridView)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.txtDelivery)
        Me.Controls.Add(Me.txtContact_number)
        Me.Controls.Add(Me.txtContact_Person)
        Me.Controls.Add(Me.txtOrderNo)
        Me.Controls.Add(Me.txtClientNo)
        Me.Controls.Add(Me.txtControlNo)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtProcess)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.Name = "DeliveryForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "u"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.InfotectDBMS1DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderNumber1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderNumber1DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FillByToolStrip.ResumeLayout(False)
        Me.FillByToolStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txtProductPcs As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtProductStock As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtProductName As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtProductID As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents txtDelivery As System.Windows.Forms.TextBox
    Friend WithEvents txtContact_number As System.Windows.Forms.TextBox
    Friend WithEvents txtContact_Person As System.Windows.Forms.TextBox
    Friend WithEvents txtOrderNo As System.Windows.Forms.TextBox
    Friend WithEvents txtClientNo As System.Windows.Forms.TextBox
    Friend WithEvents txtControlNo As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TimeDelivery As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtProcess As System.Windows.Forms.Button
    Friend WithEvents InfotectDBMS1DataSet1 As Infotech.InfotectDBMS1DataSet1
    Friend WithEvents OrderNumber1BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents OrderNumber1TableAdapter As Infotech.InfotectDBMS1DataSet1TableAdapters.OrderNumber1TableAdapter
    Friend WithEvents TableAdapterManager As Infotech.InfotectDBMS1DataSet1TableAdapters.TableAdapterManager
    Friend WithEvents OrderNumber1DataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents FillByToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents OrderNoToolStripLabel As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ORDERTEXXT As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents btnOrderLOOP As System.Windows.Forms.ToolStripButton
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class

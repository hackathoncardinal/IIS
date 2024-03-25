<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Stock
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
        Me.Button6 = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.dtpStockDate = New System.Windows.Forms.DateTimePicker()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txt_Quantity = New System.Windows.Forms.TextBox()
        Me.txt_Item = New System.Windows.Forms.TextBox()
        Me.txt_Name = New System.Windows.Forms.TextBox()
        Me.txt_productid = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtUDate = New System.Windows.Forms.DateTimePicker()
        Me.txtUQuantity = New System.Windows.Forms.TextBox()
        Me.txtUItem = New System.Windows.Forms.TextBox()
        Me.TxtUname = New System.Windows.Forms.TextBox()
        Me.txtUPID = New System.Windows.Forms.TextBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtdDate = New System.Windows.Forms.DateTimePicker()
        Me.txtDQuantity = New System.Windows.Forms.TextBox()
        Me.txtDitem = New System.Windows.Forms.TextBox()
        Me.txtDName = New System.Windows.Forms.TextBox()
        Me.txtDPID = New System.Windows.Forms.TextBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.btn_close = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.InfotectDBMS1DataSet1 = New Infotech.InfotectDBMS1DataSet1()
        Me.StockBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StockTableAdapter = New Infotech.InfotectDBMS1DataSet1TableAdapters.stockTableAdapter()
        Me.TableAdapterManager = New Infotech.InfotectDBMS1DataSet1TableAdapters.TableAdapterManager()
        Me.StockDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        CType(Me.InfotectDBMS1DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StockBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StockDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button6.FlatAppearance.BorderSize = 0
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Location = New System.Drawing.Point(432, 19)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(75, 23)
        Me.Button6.TabIndex = 21
        Me.Button6.Text = "Export Excel"
        Me.Button6.UseVisualStyleBackColor = False
        Me.Button6.Visible = False
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(10, 80)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(339, 286)
        Me.TabControl1.TabIndex = 20
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.dtpStockDate)
        Me.TabPage1.Controls.Add(Me.Label15)
        Me.TabPage1.Controls.Add(Me.txt_Quantity)
        Me.TabPage1.Controls.Add(Me.txt_Item)
        Me.TabPage1.Controls.Add(Me.txt_Name)
        Me.TabPage1.Controls.Add(Me.txt_productid)
        Me.TabPage1.Controls.Add(Me.Label14)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Button1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(331, 260)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Create New Stock"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'dtpStockDate
        '
        Me.dtpStockDate.CustomFormat = "dd/MMM/yyyy"
        Me.dtpStockDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpStockDate.Location = New System.Drawing.Point(91, 169)
        Me.dtpStockDate.Name = "dtpStockDate"
        Me.dtpStockDate.Size = New System.Drawing.Size(120, 20)
        Me.dtpStockDate.TabIndex = 26
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(13, 175)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(30, 13)
        Me.Label15.TabIndex = 27
        Me.Label15.Text = "Date"
        '
        'txt_Quantity
        '
        Me.txt_Quantity.Location = New System.Drawing.Point(91, 143)
        Me.txt_Quantity.Name = "txt_Quantity"
        Me.txt_Quantity.Size = New System.Drawing.Size(227, 20)
        Me.txt_Quantity.TabIndex = 25
        '
        'txt_Item
        '
        Me.txt_Item.Location = New System.Drawing.Point(91, 73)
        Me.txt_Item.Name = "txt_Item"
        Me.txt_Item.Size = New System.Drawing.Size(227, 20)
        Me.txt_Item.TabIndex = 23
        '
        'txt_Name
        '
        Me.txt_Name.Location = New System.Drawing.Point(107, 95)
        Me.txt_Name.Name = "txt_Name"
        Me.txt_Name.Size = New System.Drawing.Size(211, 20)
        Me.txt_Name.TabIndex = 20
        '
        'txt_productid
        '
        Me.txt_productid.Location = New System.Drawing.Point(92, 51)
        Me.txt_productid.Name = "txt_productid"
        Me.txt_productid.ReadOnly = True
        Me.txt_productid.Size = New System.Drawing.Size(227, 20)
        Me.txt_productid.TabIndex = 19
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(12, 146)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(46, 13)
        Me.Label14.TabIndex = 24
        Me.Label14.Text = "Quantity"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 76)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 13)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "Item/Details"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(11, 98)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 13)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "DepartmentName"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Product ID"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(128, 205)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 48)
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "    Create " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "New Stock"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Label6)
        Me.TabPage2.Controls.Add(Me.Label7)
        Me.TabPage2.Controls.Add(Me.Label8)
        Me.TabPage2.Controls.Add(Me.Label16)
        Me.TabPage2.Controls.Add(Me.Label17)
        Me.TabPage2.Controls.Add(Me.txtUDate)
        Me.TabPage2.Controls.Add(Me.txtUQuantity)
        Me.TabPage2.Controls.Add(Me.txtUItem)
        Me.TabPage2.Controls.Add(Me.TxtUname)
        Me.TabPage2.Controls.Add(Me.txtUPID)
        Me.TabPage2.Controls.Add(Me.Button4)
        Me.TabPage2.Controls.Add(Me.Button2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(331, 260)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Edit/Update Stock"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(7, 168)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(30, 13)
        Me.Label6.TabIndex = 41
        Me.Label6.Text = "Date"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 139)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(46, 13)
        Me.Label7.TabIndex = 40
        Me.Label7.Text = "Quantity"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 69)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(64, 13)
        Me.Label8.TabIndex = 39
        Me.Label8.Text = "Item/Details"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(5, 91)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(90, 13)
        Me.Label16.TabIndex = 37
        Me.Label16.Text = "DepartmentName"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(6, 47)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(58, 13)
        Me.Label17.TabIndex = 36
        Me.Label17.Text = "Product ID"
        '
        'txtUDate
        '
        Me.txtUDate.CustomFormat = "dd/MM/yyyy"
        Me.txtUDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtUDate.Location = New System.Drawing.Point(85, 159)
        Me.txtUDate.Name = "txtUDate"
        Me.txtUDate.Size = New System.Drawing.Size(120, 20)
        Me.txtUDate.TabIndex = 35
        '
        'txtUQuantity
        '
        Me.txtUQuantity.Location = New System.Drawing.Point(85, 133)
        Me.txtUQuantity.Name = "txtUQuantity"
        Me.txtUQuantity.Size = New System.Drawing.Size(227, 20)
        Me.txtUQuantity.TabIndex = 34
        '
        'txtUItem
        '
        Me.txtUItem.Location = New System.Drawing.Point(85, 67)
        Me.txtUItem.Name = "txtUItem"
        Me.txtUItem.Size = New System.Drawing.Size(212, 20)
        Me.txtUItem.TabIndex = 31
        '
        'TxtUname
        '
        Me.TxtUname.Location = New System.Drawing.Point(101, 89)
        Me.TxtUname.Name = "TxtUname"
        Me.TxtUname.Size = New System.Drawing.Size(211, 20)
        Me.TxtUname.TabIndex = 28
        '
        'txtUPID
        '
        Me.txtUPID.Location = New System.Drawing.Point(70, 44)
        Me.txtUPID.Name = "txtUPID"
        Me.txtUPID.ReadOnly = True
        Me.txtUPID.Size = New System.Drawing.Size(227, 20)
        Me.txtUPID.TabIndex = 27
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(303, 44)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(18, 23)
        Me.Button4.TabIndex = 32
        Me.Button4.Text = "<"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(128, 198)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 48)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Edit/Update Stock"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.Color.Silver
        Me.TabPage3.Controls.Add(Me.Label10)
        Me.TabPage3.Controls.Add(Me.Label11)
        Me.TabPage3.Controls.Add(Me.Label12)
        Me.TabPage3.Controls.Add(Me.Label18)
        Me.TabPage3.Controls.Add(Me.Label19)
        Me.TabPage3.Controls.Add(Me.txtdDate)
        Me.TabPage3.Controls.Add(Me.txtDQuantity)
        Me.TabPage3.Controls.Add(Me.txtDitem)
        Me.TabPage3.Controls.Add(Me.txtDName)
        Me.TabPage3.Controls.Add(Me.txtDPID)
        Me.TabPage3.Controls.Add(Me.Button5)
        Me.TabPage3.Controls.Add(Me.Button3)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(331, 260)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Delete Stock"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(7, 139)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(30, 13)
        Me.Label10.TabIndex = 49
        Me.Label10.Text = "Date"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(6, 118)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(46, 13)
        Me.Label11.TabIndex = 48
        Me.Label11.Text = "Quantity"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(6, 48)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(64, 13)
        Me.Label12.TabIndex = 47
        Me.Label12.Text = "Item/Details"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(5, 70)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(90, 13)
        Me.Label18.TabIndex = 45
        Me.Label18.Text = "DepartmentName"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(6, 26)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(58, 13)
        Me.Label19.TabIndex = 44
        Me.Label19.Text = "Product ID"
        '
        'txtdDate
        '
        Me.txtdDate.CustomFormat = "dd/MMM/yyyy"
        Me.txtdDate.Enabled = False
        Me.txtdDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtdDate.Location = New System.Drawing.Point(86, 133)
        Me.txtdDate.Name = "txtdDate"
        Me.txtdDate.Size = New System.Drawing.Size(120, 20)
        Me.txtdDate.TabIndex = 43
        '
        'txtDQuantity
        '
        Me.txtDQuantity.Location = New System.Drawing.Point(86, 107)
        Me.txtDQuantity.Name = "txtDQuantity"
        Me.txtDQuantity.ReadOnly = True
        Me.txtDQuantity.Size = New System.Drawing.Size(227, 20)
        Me.txtDQuantity.TabIndex = 42
        '
        'txtDitem
        '
        Me.txtDitem.Location = New System.Drawing.Point(85, 41)
        Me.txtDitem.Name = "txtDitem"
        Me.txtDitem.ReadOnly = True
        Me.txtDitem.Size = New System.Drawing.Size(227, 20)
        Me.txtDitem.TabIndex = 39
        '
        'txtDName
        '
        Me.txtDName.Location = New System.Drawing.Point(101, 63)
        Me.txtDName.Name = "txtDName"
        Me.txtDName.ReadOnly = True
        Me.txtDName.Size = New System.Drawing.Size(211, 20)
        Me.txtDName.TabIndex = 36
        '
        'txtDPID
        '
        Me.txtDPID.Location = New System.Drawing.Point(86, 19)
        Me.txtDPID.Name = "txtDPID"
        Me.txtDPID.ReadOnly = True
        Me.txtDPID.Size = New System.Drawing.Size(202, 20)
        Me.txtDPID.TabIndex = 35
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(291, 19)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(21, 20)
        Me.Button5.TabIndex = 40
        Me.Button5.Text = "<"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(161, 187)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 48)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "  Delete " & Global.Microsoft.VisualBasic.ChrW(13) & " Stock"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'btn_close
        '
        Me.btn_close.Location = New System.Drawing.Point(1099, 11)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Size = New System.Drawing.Size(75, 23)
        Me.btn_close.TabIndex = 19
        Me.btn_close.Text = "Close"
        Me.btn_close.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(10, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 25)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "&Stock In"
        '
        'InfotectDBMS1DataSet1
        '
        Me.InfotectDBMS1DataSet1.DataSetName = "InfotectDBMS1DataSet1"
        Me.InfotectDBMS1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'StockBindingSource
        '
        Me.StockBindingSource.DataMember = "stock"
        Me.StockBindingSource.DataSource = Me.InfotectDBMS1DataSet1
        '
        'StockTableAdapter
        '
        Me.StockTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ClientFormTableAdapter = Nothing
        Me.TableAdapterManager.DeliveryControlNoTableAdapter = Nothing
        Me.TableAdapterManager.OrderNumber1TableAdapter = Nothing
        Me.TableAdapterManager.RDCN1TableAdapter = Nothing
        Me.TableAdapterManager.RegistrationTableAdapter = Nothing
        Me.TableAdapterManager.stockTableAdapter = Me.StockTableAdapter
        Me.TableAdapterManager.UnRDCN1TableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Infotech.InfotectDBMS1DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'StockDataGridView
        '
        Me.StockDataGridView.AllowUserToAddRows = False
        Me.StockDataGridView.AllowUserToDeleteRows = False
        Me.StockDataGridView.AutoGenerateColumns = False
        Me.StockDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.StockDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.StockDataGridView.DataSource = Me.StockBindingSource
        Me.StockDataGridView.Location = New System.Drawing.Point(351, 47)
        Me.StockDataGridView.Name = "StockDataGridView"
        Me.StockDataGridView.ReadOnly = True
        Me.StockDataGridView.Size = New System.Drawing.Size(831, 319)
        Me.StockDataGridView.TabIndex = 22
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "ProductID"
        Me.DataGridViewTextBoxColumn2.HeaderText = "ProductID"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Item"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Item"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Name"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Name"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Quantity"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Quantity"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Date"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Date"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'btnPrint
        '
        Me.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrint.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.Location = New System.Drawing.Point(351, 11)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(75, 31)
        Me.btnPrint.TabIndex = 23
        Me.btnPrint.Text = "Print"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'Stock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Infotech.My.Resources.Resources._27101950596
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1194, 386)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.StockDataGridView)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.btn_close)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Stock"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Stock"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        CType(Me.InfotectDBMS1DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StockBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StockDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtUDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtUQuantity As System.Windows.Forms.TextBox
    Friend WithEvents txtUItem As System.Windows.Forms.TextBox
    Friend WithEvents TxtUname As System.Windows.Forms.TextBox
    Friend WithEvents txtUPID As System.Windows.Forms.TextBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents txtdDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtDQuantity As System.Windows.Forms.TextBox
    Friend WithEvents txtDitem As System.Windows.Forms.TextBox
    Friend WithEvents txtDName As System.Windows.Forms.TextBox
    Friend WithEvents txtDPID As System.Windows.Forms.TextBox
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents btn_close As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents dtpStockDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txt_Quantity As System.Windows.Forms.TextBox
    Friend WithEvents txt_Item As System.Windows.Forms.TextBox
    Friend WithEvents txt_Name As System.Windows.Forms.TextBox
    Friend WithEvents txt_productid As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents InfotectDBMS1DataSet1 As Infotech.InfotectDBMS1DataSet1
    Friend WithEvents StockBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents StockTableAdapter As Infotech.InfotectDBMS1DataSet1TableAdapters.stockTableAdapter
    Friend WithEvents TableAdapterManager As Infotech.InfotectDBMS1DataSet1TableAdapters.TableAdapterManager
    Friend WithEvents StockDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnPrint As System.Windows.Forms.Button
End Class

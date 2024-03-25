<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.tsUser = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tsUsername = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_about = New System.Windows.Forms.Button()
        Me.btn_Delivery = New System.Windows.Forms.Button()
        Me.btn_SalesSummary = New System.Windows.Forms.Button()
        Me.btn_unpaid = New System.Windows.Forms.Button()
        Me.btn_logout = New System.Windows.Forms.Button()
        Me.btn_Registration = New System.Windows.Forms.Button()
        Me.btn_Client = New System.Windows.Forms.Button()
        Me.btn_Home = New System.Windows.Forms.Button()
        Me.btn_Stock = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.UnRDCN1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UnRDCN1TableAdapter = New Infotech.InfotectDBMS1DataSet1TableAdapters.UnRDCN1TableAdapter()
        Me.UnRDCN1DataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InfotectDBMS1DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StockBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StockDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UnRDCN1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UnRDCN1DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox2
        '
        Me.PictureBox2.Location = New System.Drawing.Point(142, 76)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(100, 50)
        Me.PictureBox2.TabIndex = 22
        Me.PictureBox2.TabStop = False
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsUser, Me.tsUsername})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 659)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1359, 22)
        Me.StatusStrip1.TabIndex = 19
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'tsUser
        '
        Me.tsUser.Name = "tsUser"
        Me.tsUser.Size = New System.Drawing.Size(30, 17)
        Me.tsUser.Text = "User"
        '
        'tsUsername
        '
        Me.tsUsername.Name = "tsUsername"
        Me.tsUsername.Size = New System.Drawing.Size(80, 17)
        Me.tsUsername.Text = "Administrator"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 104)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 25)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "&Stock In"
        '
        'btn_about
        '
        Me.btn_about.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_about.Location = New System.Drawing.Point(616, 12)
        Me.btn_about.Name = "btn_about"
        Me.btn_about.Size = New System.Drawing.Size(75, 50)
        Me.btn_about.TabIndex = 31
        Me.btn_about.Text = "About"
        Me.btn_about.UseVisualStyleBackColor = True
        '
        'btn_Delivery
        '
        Me.btn_Delivery.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Delivery.Location = New System.Drawing.Point(211, 12)
        Me.btn_Delivery.Name = "btn_Delivery"
        Me.btn_Delivery.Size = New System.Drawing.Size(75, 50)
        Me.btn_Delivery.TabIndex = 30
        Me.btn_Delivery.Text = "Delivery/Borrowed"
        Me.btn_Delivery.UseVisualStyleBackColor = True
        '
        'btn_SalesSummary
        '
        Me.btn_SalesSummary.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_SalesSummary.Location = New System.Drawing.Point(535, 12)
        Me.btn_SalesSummary.Name = "btn_SalesSummary"
        Me.btn_SalesSummary.Size = New System.Drawing.Size(75, 50)
        Me.btn_SalesSummary.TabIndex = 29
        Me.btn_SalesSummary.Text = "Return Summary"
        Me.btn_SalesSummary.UseVisualStyleBackColor = True
        '
        'btn_unpaid
        '
        Me.btn_unpaid.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_unpaid.Location = New System.Drawing.Point(450, 12)
        Me.btn_unpaid.Name = "btn_unpaid"
        Me.btn_unpaid.Size = New System.Drawing.Size(84, 50)
        Me.btn_unpaid.TabIndex = 28
        Me.btn_unpaid.Text = "Unreturned"
        Me.btn_unpaid.UseVisualStyleBackColor = True
        '
        'btn_logout
        '
        Me.btn_logout.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_logout.Location = New System.Drawing.Point(697, 12)
        Me.btn_logout.Name = "btn_logout"
        Me.btn_logout.Size = New System.Drawing.Size(75, 50)
        Me.btn_logout.TabIndex = 27
        Me.btn_logout.Text = "Logout"
        Me.btn_logout.UseVisualStyleBackColor = True
        '
        'btn_Registration
        '
        Me.btn_Registration.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Registration.Location = New System.Drawing.Point(130, 12)
        Me.btn_Registration.Name = "btn_Registration"
        Me.btn_Registration.Size = New System.Drawing.Size(75, 50)
        Me.btn_Registration.TabIndex = 26
        Me.btn_Registration.Text = "Registration"
        Me.btn_Registration.UseVisualStyleBackColor = True
        '
        'btn_Client
        '
        Me.btn_Client.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Client.Location = New System.Drawing.Point(292, 12)
        Me.btn_Client.Name = "btn_Client"
        Me.btn_Client.Size = New System.Drawing.Size(75, 50)
        Me.btn_Client.TabIndex = 25
        Me.btn_Client.Text = "Client"
        Me.btn_Client.UseVisualStyleBackColor = True
        '
        'btn_Home
        '
        Me.btn_Home.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Home.Location = New System.Drawing.Point(17, 12)
        Me.btn_Home.Name = "btn_Home"
        Me.btn_Home.Size = New System.Drawing.Size(107, 50)
        Me.btn_Home.TabIndex = 24
        Me.btn_Home.Text = "Home"
        Me.btn_Home.UseVisualStyleBackColor = True
        '
        'btn_Stock
        '
        Me.btn_Stock.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Stock.Location = New System.Drawing.Point(373, 12)
        Me.btn_Stock.Name = "btn_Stock"
        Me.btn_Stock.Size = New System.Drawing.Size(75, 50)
        Me.btn_Stock.TabIndex = 23
        Me.btn_Stock.Text = "Stock"
        Me.btn_Stock.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = Global.Infotech.My.Resources.Resources.julies
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(782, -6)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(557, 111)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 32
        Me.PictureBox1.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
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
        Me.TableAdapterManager.UnRDCN1TableAdapter = Me.UnRDCN1TableAdapter
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
        Me.StockDataGridView.Location = New System.Drawing.Point(0, 132)
        Me.StockDataGridView.Name = "StockDataGridView"
        Me.StockDataGridView.ReadOnly = True
        Me.StockDataGridView.Size = New System.Drawing.Size(755, 493)
        Me.StockDataGridView.TabIndex = 33
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
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(802, 105)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(444, 25)
        Me.Label3.TabIndex = 34
        Me.Label3.Text = "&UnReturned Delivery Details   / Upon Pick Up"
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
        'UnRDCN1DataGridView
        '
        Me.UnRDCN1DataGridView.AllowUserToAddRows = False
        Me.UnRDCN1DataGridView.AllowUserToDeleteRows = False
        Me.UnRDCN1DataGridView.AutoGenerateColumns = False
        Me.UnRDCN1DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.UnRDCN1DataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15})
        Me.UnRDCN1DataGridView.DataSource = Me.UnRDCN1BindingSource
        Me.UnRDCN1DataGridView.Location = New System.Drawing.Point(761, 132)
        Me.UnRDCN1DataGridView.Name = "UnRDCN1DataGridView"
        Me.UnRDCN1DataGridView.ReadOnly = True
        Me.UnRDCN1DataGridView.Size = New System.Drawing.Size(586, 493)
        Me.UnRDCN1DataGridView.TabIndex = 34
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "ControlNo"
        Me.DataGridViewTextBoxColumn7.HeaderText = "ControlNo"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "ClientNo"
        Me.DataGridViewTextBoxColumn8.HeaderText = "ClientNo"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "OrderNo"
        Me.DataGridViewTextBoxColumn9.HeaderText = "OrderNo"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "ContactPerson"
        Me.DataGridViewTextBoxColumn10.HeaderText = "ContactPerson"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "ContactNumber"
        Me.DataGridViewTextBoxColumn11.HeaderText = "ContactNumber"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "Addressto"
        Me.DataGridViewTextBoxColumn12.HeaderText = "Addressto"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "DateBorrowed"
        Me.DataGridViewTextBoxColumn13.HeaderText = "DateBorrowed"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.ReadOnly = True
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "DateReturned"
        Me.DataGridViewTextBoxColumn14.HeaderText = "DateReturned"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.ReadOnly = True
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "Status"
        Me.DataGridViewTextBoxColumn15.HeaderText = "Status"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        Me.DataGridViewTextBoxColumn15.ReadOnly = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Infotech.My.Resources.Resources._27101950596
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1359, 681)
        Me.ControlBox = False
        Me.Controls.Add(Me.UnRDCN1DataGridView)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.StockDataGridView)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btn_about)
        Me.Controls.Add(Me.btn_Delivery)
        Me.Controls.Add(Me.btn_SalesSummary)
        Me.Controls.Add(Me.btn_unpaid)
        Me.Controls.Add(Me.btn_logout)
        Me.Controls.Add(Me.btn_Registration)
        Me.Controls.Add(Me.btn_Client)
        Me.Controls.Add(Me.btn_Home)
        Me.Controls.Add(Me.btn_Stock)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MainForm"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InfotectDBMS1DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StockBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StockDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UnRDCN1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UnRDCN1DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents tsUser As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents tsUsername As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btn_about As System.Windows.Forms.Button
    Friend WithEvents btn_Delivery As System.Windows.Forms.Button
    Friend WithEvents btn_SalesSummary As System.Windows.Forms.Button
    Friend WithEvents btn_unpaid As System.Windows.Forms.Button
    Friend WithEvents btn_logout As System.Windows.Forms.Button
    Friend WithEvents btn_Registration As System.Windows.Forms.Button
    Friend WithEvents btn_Client As System.Windows.Forms.Button
    Friend WithEvents btn_Home As System.Windows.Forms.Button
    Friend WithEvents btn_Stock As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
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
    Friend WithEvents UnRDCN1TableAdapter As Infotech.InfotectDBMS1DataSet1TableAdapters.UnRDCN1TableAdapter
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents UnRDCN1BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents UnRDCN1DataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As System.Windows.Forms.DataGridViewTextBoxColumn

End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UnpaidSub
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
        CType(Me.InfotectDBMS1DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UnRDCN1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UnRDCN1DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.UnRDCN1DataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UnRDCN1DataGridView.Location = New System.Drawing.Point(0, 0)
        Me.UnRDCN1DataGridView.Name = "UnRDCN1DataGridView"
        Me.UnRDCN1DataGridView.ReadOnly = True
        Me.UnRDCN1DataGridView.Size = New System.Drawing.Size(1041, 491)
        Me.UnRDCN1DataGridView.TabIndex = 1
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
        'UnpaidSub
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1041, 491)
        Me.Controls.Add(Me.UnRDCN1DataGridView)
        Me.Name = "UnpaidSub"
        CType(Me.InfotectDBMS1DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UnRDCN1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UnRDCN1DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
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
End Class

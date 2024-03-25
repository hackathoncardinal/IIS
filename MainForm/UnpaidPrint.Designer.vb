<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UnpaidPrint
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.InfotectDBMS1DataSet1 = New Infotech.InfotectDBMS1DataSet1()
        Me.UnRDCN1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UnRDCN1TableAdapter = New Infotech.InfotectDBMS1DataSet1TableAdapters.UnRDCN1TableAdapter()
        CType(Me.InfotectDBMS1DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UnRDCN1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.UnRDCN1BindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Infotech.Report3.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(870, 342)
        Me.ReportViewer1.TabIndex = 0
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
        'UnpaidPrint
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(870, 342)
        Me.Controls.Add(Me.ReportViewer1)
        Me.MinimizeBox = False
        Me.Name = "UnpaidPrint"
        Me.Text = "Print"
        CType(Me.InfotectDBMS1DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UnRDCN1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents UnRDCN1BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents InfotectDBMS1DataSet1 As Infotech.InfotectDBMS1DataSet1
    Friend WithEvents UnRDCN1TableAdapter As Infotech.InfotectDBMS1DataSet1TableAdapters.UnRDCN1TableAdapter
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Sale_reports
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
        Me.LblSaleReports = New System.Windows.Forms.Label()
        Me.DvgSaleReport = New System.Windows.Forms.DataGridView()
        Me.CmbRealtorName = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CmbPropertyType = New System.Windows.Forms.ComboBox()
        Me.BtnExport = New System.Windows.Forms.Button()
        CType(Me.DvgSaleReport, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblSaleReports
        '
        Me.LblSaleReports.AutoSize = True
        Me.LblSaleReports.BackColor = System.Drawing.Color.White
        Me.LblSaleReports.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSaleReports.Location = New System.Drawing.Point(32, 20)
        Me.LblSaleReports.Name = "LblSaleReports"
        Me.LblSaleReports.Size = New System.Drawing.Size(420, 46)
        Me.LblSaleReports.TabIndex = 0
        Me.LblSaleReports.Text = "Managing Sale reports"
        '
        'DvgSaleReport
        '
        Me.DvgSaleReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DvgSaleReport.Location = New System.Drawing.Point(29, 87)
        Me.DvgSaleReport.Name = "DvgSaleReport"
        Me.DvgSaleReport.RowHeadersWidth = 62
        Me.DvgSaleReport.RowTemplate.Height = 28
        Me.DvgSaleReport.Size = New System.Drawing.Size(1218, 456)
        Me.DvgSaleReport.TabIndex = 1
        '
        'CmbRealtorName
        '
        Me.CmbRealtorName.FormattingEnabled = True
        Me.CmbRealtorName.Location = New System.Drawing.Point(255, 648)
        Me.CmbRealtorName.Name = "CmbRealtorName"
        Me.CmbRealtorName.Size = New System.Drawing.Size(121, 28)
        Me.CmbRealtorName.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(87, 650)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(147, 26)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Realtor Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(480, 646)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(209, 26)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Property Desrciption"
        '
        'CmbPropertyType
        '
        Me.CmbPropertyType.FormattingEnabled = True
        Me.CmbPropertyType.Location = New System.Drawing.Point(719, 644)
        Me.CmbPropertyType.Name = "CmbPropertyType"
        Me.CmbPropertyType.Size = New System.Drawing.Size(121, 28)
        Me.CmbPropertyType.TabIndex = 5
        '
        'BtnExport
        '
        Me.BtnExport.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnExport.Location = New System.Drawing.Point(969, 645)
        Me.BtnExport.Name = "BtnExport"
        Me.BtnExport.Size = New System.Drawing.Size(200, 36)
        Me.BtnExport.TabIndex = 6
        Me.BtnExport.Text = "Export to PDF"
        Me.BtnExport.UseVisualStyleBackColor = True
        '
        'Sale_reports
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1433, 794)
        Me.Controls.Add(Me.BtnExport)
        Me.Controls.Add(Me.CmbPropertyType)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CmbRealtorName)
        Me.Controls.Add(Me.DvgSaleReport)
        Me.Controls.Add(Me.LblSaleReports)
        Me.Name = "Sale_reports"
        Me.Text = "Sale_reports"
        CType(Me.DvgSaleReport, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblSaleReports As Label
    Friend WithEvents DvgSaleReport As DataGridView
    Friend WithEvents CmbRealtorName As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents CmbPropertyType As ComboBox
    Friend WithEvents BtnExport As Button
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SaleReports
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
        Me.DvgSalesReport = New System.Windows.Forms.DataGridView()
        Me.LblFrom = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DtpFrom = New System.Windows.Forms.DateTimePicker()
        Me.DtpTo = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BtnExport = New System.Windows.Forms.Button()
        Me.CmbRealtorName = New System.Windows.Forms.ComboBox()
        Me.CmbPropertyType = New System.Windows.Forms.ComboBox()
        Me.btnClearProp = New System.Windows.Forms.Button()
        Me.btnClrName = New System.Windows.Forms.Button()
        Me.BtnMainpage = New System.Windows.Forms.Button()
        CType(Me.DvgSalesReport, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DvgSalesReport
        '
        Me.DvgSalesReport.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DvgSalesReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DvgSalesReport.Location = New System.Drawing.Point(57, 206)
        Me.DvgSalesReport.Name = "DvgSalesReport"
        Me.DvgSalesReport.ReadOnly = True
        Me.DvgSalesReport.RowHeadersWidth = 62
        Me.DvgSalesReport.RowTemplate.Height = 28
        Me.DvgSalesReport.Size = New System.Drawing.Size(1096, 386)
        Me.DvgSalesReport.TabIndex = 2
        '
        'LblFrom
        '
        Me.LblFrom.AutoSize = True
        Me.LblFrom.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblFrom.Location = New System.Drawing.Point(45, 56)
        Me.LblFrom.Name = "LblFrom"
        Me.LblFrom.Size = New System.Drawing.Size(70, 29)
        Me.LblFrom.TabIndex = 3
        Me.LblFrom.Text = "From"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(45, 128)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 29)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "To"
        '
        'DtpFrom
        '
        Me.DtpFrom.Location = New System.Drawing.Point(136, 59)
        Me.DtpFrom.Name = "DtpFrom"
        Me.DtpFrom.Size = New System.Drawing.Size(324, 26)
        Me.DtpFrom.TabIndex = 5
        '
        'DtpTo
        '
        Me.DtpTo.Location = New System.Drawing.Point(136, 131)
        Me.DtpTo.Name = "DtpTo"
        Me.DtpTo.Size = New System.Drawing.Size(324, 26)
        Me.DtpTo.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(573, 129)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(162, 29)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Realtor Name"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(575, 59)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(165, 29)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Property Type"
        '
        'BtnExport
        '
        Me.BtnExport.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnExport.Location = New System.Drawing.Point(1021, 598)
        Me.BtnExport.Name = "BtnExport"
        Me.BtnExport.Size = New System.Drawing.Size(132, 41)
        Me.BtnExport.TabIndex = 9
        Me.BtnExport.Text = "Export to PDF"
        Me.BtnExport.UseVisualStyleBackColor = True
        '
        'CmbRealtorName
        '
        Me.CmbRealtorName.DisplayMember = "RealtorName"
        Me.CmbRealtorName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbRealtorName.FormattingEnabled = True
        Me.CmbRealtorName.Location = New System.Drawing.Point(740, 128)
        Me.CmbRealtorName.Name = "CmbRealtorName"
        Me.CmbRealtorName.Size = New System.Drawing.Size(201, 28)
        Me.CmbRealtorName.TabIndex = 10
        Me.CmbRealtorName.ValueMember = "RealtorId"
        '
        'CmbPropertyType
        '
        Me.CmbPropertyType.DisplayMember = "Description"
        Me.CmbPropertyType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbPropertyType.FormattingEnabled = True
        Me.CmbPropertyType.Location = New System.Drawing.Point(740, 59)
        Me.CmbPropertyType.Name = "CmbPropertyType"
        Me.CmbPropertyType.Size = New System.Drawing.Size(201, 28)
        Me.CmbPropertyType.TabIndex = 11
        Me.CmbPropertyType.ValueMember = "PropertyTypeID"
        '
        'btnClearProp
        '
        Me.btnClearProp.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClearProp.ForeColor = System.Drawing.Color.Brown
        Me.btnClearProp.Location = New System.Drawing.Point(947, 56)
        Me.btnClearProp.Name = "btnClearProp"
        Me.btnClearProp.Size = New System.Drawing.Size(34, 31)
        Me.btnClearProp.TabIndex = 12
        Me.btnClearProp.Text = "X"
        Me.btnClearProp.UseVisualStyleBackColor = True
        '
        'btnClrName
        '
        Me.btnClrName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClrName.ForeColor = System.Drawing.Color.Brown
        Me.btnClrName.Location = New System.Drawing.Point(947, 125)
        Me.btnClrName.Name = "btnClrName"
        Me.btnClrName.Size = New System.Drawing.Size(34, 31)
        Me.btnClrName.TabIndex = 13
        Me.btnClrName.Text = "X"
        Me.btnClrName.UseVisualStyleBackColor = True
        '
        'BtnMainpage
        '
        Me.BtnMainpage.Location = New System.Drawing.Point(866, 607)
        Me.BtnMainpage.Name = "BtnMainpage"
        Me.BtnMainpage.Size = New System.Drawing.Size(135, 32)
        Me.BtnMainpage.TabIndex = 14
        Me.BtnMainpage.Text = "Mainpage"
        Me.BtnMainpage.UseVisualStyleBackColor = True
        '
        'SaleReports
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1207, 676)
        Me.Controls.Add(Me.BtnMainpage)
        Me.Controls.Add(Me.btnClrName)
        Me.Controls.Add(Me.btnClearProp)
        Me.Controls.Add(Me.CmbPropertyType)
        Me.Controls.Add(Me.CmbRealtorName)
        Me.Controls.Add(Me.BtnExport)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.DtpTo)
        Me.Controls.Add(Me.DtpFrom)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.LblFrom)
        Me.Controls.Add(Me.DvgSalesReport)
        Me.Name = "SaleReports"
        Me.Text = "Sale Reports"
        CType(Me.DvgSalesReport, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DvgSalesReport As DataGridView
    Friend WithEvents LblFrom As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents DtpFrom As DateTimePicker
    Friend WithEvents DtpTo As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents BtnExport As Button
    Friend WithEvents CmbRealtorName As ComboBox
    Friend WithEvents CmbPropertyType As ComboBox
    Friend WithEvents btnClearProp As Button
    Friend WithEvents btnClrName As Button
    Friend WithEvents BtnMainpage As Button
End Class

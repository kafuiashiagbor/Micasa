<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RentPayments
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.DgvRentPayments = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CmbPaymentStatus = New System.Windows.Forms.ComboBox()
        Me.BtnDeletePayments = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtSearch = New System.Windows.Forms.TextBox()
        Me.LblFromDate = New System.Windows.Forms.Label()
        Me.LblToDate = New System.Windows.Forms.Label()
        Me.DtpTo = New System.Windows.Forms.DateTimePicker()
        Me.DtpFrom = New System.Windows.Forms.DateTimePicker()
        Me.BtnMainpage = New System.Windows.Forms.Button()
        CType(Me.DgvRentPayments, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DgvRentPayments
        '
        Me.DgvRentPayments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvRentPayments.Location = New System.Drawing.Point(28, 271)
        Me.DgvRentPayments.Name = "DgvRentPayments"
        Me.DgvRentPayments.RowHeadersWidth = 62
        Me.DgvRentPayments.RowTemplate.Height = 28
        Me.DgvRentPayments.Size = New System.Drawing.Size(1164, 444)
        Me.DgvRentPayments.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(19, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(320, 52)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Rent Payments"
        '
        'CmbPaymentStatus
        '
        Me.CmbPaymentStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.CmbPaymentStatus.FormattingEnabled = True
        Me.CmbPaymentStatus.Location = New System.Drawing.Point(768, 199)
        Me.CmbPaymentStatus.Name = "CmbPaymentStatus"
        Me.CmbPaymentStatus.Size = New System.Drawing.Size(121, 33)
        Me.CmbPaymentStatus.TabIndex = 8
        '
        'BtnDeletePayments
        '
        Me.BtnDeletePayments.Location = New System.Drawing.Point(548, 808)
        Me.BtnDeletePayments.Name = "BtnDeletePayments"
        Me.BtnDeletePayments.Size = New System.Drawing.Size(163, 45)
        Me.BtnDeletePayments.TabIndex = 12
        Me.BtnDeletePayments.Text = "Delete payment"
        Me.BtnDeletePayments.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label2.Location = New System.Drawing.Point(603, 202)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(150, 25)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Payment Status"
        '
        'TxtSearch
        '
        Me.TxtSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.TxtSearch.Location = New System.Drawing.Point(607, 134)
        Me.TxtSearch.Name = "TxtSearch"
        Me.TxtSearch.Size = New System.Drawing.Size(282, 30)
        Me.TxtSearch.TabIndex = 14
        '
        'LblFromDate
        '
        Me.LblFromDate.AutoSize = True
        Me.LblFromDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.LblFromDate.Location = New System.Drawing.Point(57, 141)
        Me.LblFromDate.Name = "LblFromDate"
        Me.LblFromDate.Size = New System.Drawing.Size(106, 25)
        Me.LblFromDate.TabIndex = 15
        Me.LblFromDate.Text = "From date:"
        '
        'LblToDate
        '
        Me.LblToDate.AutoSize = True
        Me.LblToDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.LblToDate.Location = New System.Drawing.Point(57, 207)
        Me.LblToDate.Name = "LblToDate"
        Me.LblToDate.Size = New System.Drawing.Size(82, 25)
        Me.LblToDate.TabIndex = 16
        Me.LblToDate.Text = "To Date"
        '
        'DtpTo
        '
        Me.DtpTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.DtpTo.Location = New System.Drawing.Point(174, 134)
        Me.DtpTo.Name = "DtpTo"
        Me.DtpTo.Size = New System.Drawing.Size(280, 30)
        Me.DtpTo.TabIndex = 17
        '
        'DtpFrom
        '
        Me.DtpFrom.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.DtpFrom.Location = New System.Drawing.Point(174, 202)
        Me.DtpFrom.Name = "DtpFrom"
        Me.DtpFrom.Size = New System.Drawing.Size(280, 30)
        Me.DtpFrom.TabIndex = 18
        '
        'BtnMainpage
        '
        Me.BtnMainpage.Location = New System.Drawing.Point(1046, 208)
        Me.BtnMainpage.Name = "BtnMainpage"
        Me.BtnMainpage.Size = New System.Drawing.Size(109, 40)
        Me.BtnMainpage.TabIndex = 19
        Me.BtnMainpage.Text = "Mainpage"
        Me.BtnMainpage.UseVisualStyleBackColor = True
        '
        'RentPayments
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1463, 934)
        Me.Controls.Add(Me.BtnMainpage)
        Me.Controls.Add(Me.DtpFrom)
        Me.Controls.Add(Me.DtpTo)
        Me.Controls.Add(Me.LblToDate)
        Me.Controls.Add(Me.LblFromDate)
        Me.Controls.Add(Me.TxtSearch)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BtnDeletePayments)
        Me.Controls.Add(Me.CmbPaymentStatus)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DgvRentPayments)
        Me.Name = "RentPayments"
        Me.Text = "RentPayments"
        CType(Me.DgvRentPayments, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DgvRentPayments As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents CmbPaymentStatus As ComboBox
    Friend WithEvents BtnDeletePayments As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtSearch As TextBox
    Friend WithEvents LblFromDate As Label
    Friend WithEvents LblToDate As Label
    Friend WithEvents DtpTo As DateTimePicker
    Friend WithEvents DtpFrom As DateTimePicker
    Friend WithEvents BtnMainpage As Button
End Class

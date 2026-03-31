<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Rentals
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
        Me.DgvRentals = New System.Windows.Forms.DataGridView()
        Me.TxtSearch = New System.Windows.Forms.TextBox()
        Me.BtnMainPage = New System.Windows.Forms.Button()
        Me.CmbPropertyID = New System.Windows.Forms.ComboBox()
        Me.LblPropertyID = New System.Windows.Forms.Label()
        Me.CmbClientName = New System.Windows.Forms.ComboBox()
        Me.CmbPaymentStatus = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DtpStartDate = New System.Windows.Forms.DateTimePicker()
        Me.CmbPropertyType = New System.Windows.Forms.ComboBox()
        Me.TxtAmount = New System.Windows.Forms.TextBox()
        Me.LblCtype = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.LblDate = New System.Windows.Forms.Label()
        Me.LblAmount = New System.Windows.Forms.Label()
        Me.LblClient = New System.Windows.Forms.Label()
        Me.DtpEndDate = New System.Windows.Forms.DateTimePicker()
        Me.LblEndDate = New System.Windows.Forms.Label()
        Me.BtnDelete = New System.Windows.Forms.Button()
        Me.BtnEdit = New System.Windows.Forms.Button()
        Me.BtnAdd = New System.Windows.Forms.Button()
        CType(Me.DgvRentals, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DgvRentals
        '
        Me.DgvRentals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvRentals.Location = New System.Drawing.Point(12, 125)
        Me.DgvRentals.Name = "DgvRentals"
        Me.DgvRentals.RowHeadersWidth = 62
        Me.DgvRentals.RowTemplate.Height = 28
        Me.DgvRentals.Size = New System.Drawing.Size(1225, 443)
        Me.DgvRentals.TabIndex = 0
        '
        'TxtSearch
        '
        Me.TxtSearch.Location = New System.Drawing.Point(12, 65)
        Me.TxtSearch.Name = "TxtSearch"
        Me.TxtSearch.Size = New System.Drawing.Size(523, 26)
        Me.TxtSearch.TabIndex = 1
        '
        'BtnMainPage
        '
        Me.BtnMainPage.Location = New System.Drawing.Point(642, 65)
        Me.BtnMainPage.Name = "BtnMainPage"
        Me.BtnMainPage.Size = New System.Drawing.Size(133, 35)
        Me.BtnMainPage.TabIndex = 2
        Me.BtnMainPage.Text = "Mainpage"
        Me.BtnMainPage.UseVisualStyleBackColor = True
        '
        'CmbPropertyID
        '
        Me.CmbPropertyID.DisplayMember = "Description"
        Me.CmbPropertyID.FormattingEnabled = True
        Me.CmbPropertyID.Items.AddRange(New Object() {"House", "Apartment", "Office", "Penthouse"})
        Me.CmbPropertyID.Location = New System.Drawing.Point(654, 711)
        Me.CmbPropertyID.Name = "CmbPropertyID"
        Me.CmbPropertyID.Size = New System.Drawing.Size(121, 28)
        Me.CmbPropertyID.TabIndex = 48
        Me.CmbPropertyID.ValueMember = "PropertyID"
        '
        'LblPropertyID
        '
        Me.LblPropertyID.AutoSize = True
        Me.LblPropertyID.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPropertyID.ForeColor = System.Drawing.Color.Black
        Me.LblPropertyID.Location = New System.Drawing.Point(482, 711)
        Me.LblPropertyID.Name = "LblPropertyID"
        Me.LblPropertyID.Size = New System.Drawing.Size(115, 25)
        Me.LblPropertyID.TabIndex = 47
        Me.LblPropertyID.Text = "Property No"
        '
        'CmbClientName
        '
        Me.CmbClientName.DisplayMember = "Name"
        Me.CmbClientName.FormattingEnabled = True
        Me.CmbClientName.Items.AddRange(New Object() {""})
        Me.CmbClientName.Location = New System.Drawing.Point(224, 641)
        Me.CmbClientName.Name = "CmbClientName"
        Me.CmbClientName.Size = New System.Drawing.Size(121, 28)
        Me.CmbClientName.TabIndex = 46
        Me.CmbClientName.ValueMember = "ClientID"
        '
        'CmbPaymentStatus
        '
        Me.CmbPaymentStatus.FormattingEnabled = True
        Me.CmbPaymentStatus.Items.AddRange(New Object() {"Paid", "Pending", "Overdue"})
        Me.CmbPaymentStatus.Location = New System.Drawing.Point(224, 784)
        Me.CmbPaymentStatus.Name = "CmbPaymentStatus"
        Me.CmbPaymentStatus.Size = New System.Drawing.Size(121, 28)
        Me.CmbPaymentStatus.TabIndex = 45
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(68, 709)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 25)
        Me.Label2.TabIndex = 44
        Me.Label2.Text = "Amount"
        '
        'DtpStartDate
        '
        Me.DtpStartDate.Location = New System.Drawing.Point(1015, 641)
        Me.DtpStartDate.Name = "DtpStartDate"
        Me.DtpStartDate.Size = New System.Drawing.Size(282, 26)
        Me.DtpStartDate.TabIndex = 43
        '
        'CmbPropertyType
        '
        Me.CmbPropertyType.DisplayMember = "Description"
        Me.CmbPropertyType.FormattingEnabled = True
        Me.CmbPropertyType.Items.AddRange(New Object() {"House", "Apartment", "Office", "Penthouse"})
        Me.CmbPropertyType.Location = New System.Drawing.Point(654, 644)
        Me.CmbPropertyType.Name = "CmbPropertyType"
        Me.CmbPropertyType.Size = New System.Drawing.Size(121, 28)
        Me.CmbPropertyType.TabIndex = 42
        Me.CmbPropertyType.ValueMember = "PropertyTypeID"
        '
        'TxtAmount
        '
        Me.TxtAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtAmount.Location = New System.Drawing.Point(226, 706)
        Me.TxtAmount.Name = "TxtAmount"
        Me.TxtAmount.Size = New System.Drawing.Size(119, 30)
        Me.TxtAmount.TabIndex = 41
        '
        'LblCtype
        '
        Me.LblCtype.AutoSize = True
        Me.LblCtype.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.LblCtype.ForeColor = System.Drawing.Color.Black
        Me.LblCtype.Location = New System.Drawing.Point(41, 784)
        Me.LblCtype.Name = "LblCtype"
        Me.LblCtype.Size = New System.Drawing.Size(150, 25)
        Me.LblCtype.TabIndex = 40
        Me.LblCtype.Text = "Payment Status"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(482, 644)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(135, 25)
        Me.Label7.TabIndex = 39
        Me.Label7.Text = "Property Type"
        '
        'LblDate
        '
        Me.LblDate.AutoSize = True
        Me.LblDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.LblDate.ForeColor = System.Drawing.Color.Black
        Me.LblDate.Location = New System.Drawing.Point(885, 641)
        Me.LblDate.Name = "LblDate"
        Me.LblDate.Size = New System.Drawing.Size(99, 25)
        Me.LblDate.TabIndex = 38
        Me.LblDate.Text = "Start Date"
        '
        'LblAmount
        '
        Me.LblAmount.AutoSize = True
        Me.LblAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.LblAmount.ForeColor = System.Drawing.Color.Black
        Me.LblAmount.Location = New System.Drawing.Point(885, 787)
        Me.LblAmount.Name = "LblAmount"
        Me.LblAmount.Size = New System.Drawing.Size(0, 25)
        Me.LblAmount.TabIndex = 37
        '
        'LblClient
        '
        Me.LblClient.AutoSize = True
        Me.LblClient.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.LblClient.ForeColor = System.Drawing.Color.Black
        Me.LblClient.Location = New System.Drawing.Point(86, 644)
        Me.LblClient.Name = "LblClient"
        Me.LblClient.Size = New System.Drawing.Size(62, 25)
        Me.LblClient.TabIndex = 36
        Me.LblClient.Text = "Client"
        '
        'DtpEndDate
        '
        Me.DtpEndDate.Location = New System.Drawing.Point(1015, 714)
        Me.DtpEndDate.Name = "DtpEndDate"
        Me.DtpEndDate.Size = New System.Drawing.Size(282, 26)
        Me.DtpEndDate.TabIndex = 50
        '
        'LblEndDate
        '
        Me.LblEndDate.AutoSize = True
        Me.LblEndDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.LblEndDate.ForeColor = System.Drawing.Color.Black
        Me.LblEndDate.Location = New System.Drawing.Point(885, 714)
        Me.LblEndDate.Name = "LblEndDate"
        Me.LblEndDate.Size = New System.Drawing.Size(93, 25)
        Me.LblEndDate.TabIndex = 49
        Me.LblEndDate.Text = "End Date"
        '
        'BtnDelete
        '
        Me.BtnDelete.ForeColor = System.Drawing.Color.Black
        Me.BtnDelete.Location = New System.Drawing.Point(878, 867)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(110, 43)
        Me.BtnDelete.TabIndex = 53
        Me.BtnDelete.Text = "Delete"
        Me.BtnDelete.UseVisualStyleBackColor = True
        '
        'BtnEdit
        '
        Me.BtnEdit.ForeColor = System.Drawing.Color.Black
        Me.BtnEdit.Location = New System.Drawing.Point(596, 867)
        Me.BtnEdit.Name = "BtnEdit"
        Me.BtnEdit.Size = New System.Drawing.Size(110, 43)
        Me.BtnEdit.TabIndex = 52
        Me.BtnEdit.Text = "Edit"
        Me.BtnEdit.UseVisualStyleBackColor = True
        '
        'BtnAdd
        '
        Me.BtnAdd.ForeColor = System.Drawing.Color.Black
        Me.BtnAdd.Location = New System.Drawing.Point(333, 867)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(110, 43)
        Me.BtnAdd.TabIndex = 51
        Me.BtnAdd.Text = "Add"
        Me.BtnAdd.UseVisualStyleBackColor = True
        '
        'Rentals
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1351, 940)
        Me.Controls.Add(Me.BtnDelete)
        Me.Controls.Add(Me.BtnEdit)
        Me.Controls.Add(Me.BtnAdd)
        Me.Controls.Add(Me.DtpEndDate)
        Me.Controls.Add(Me.LblEndDate)
        Me.Controls.Add(Me.CmbPropertyID)
        Me.Controls.Add(Me.LblPropertyID)
        Me.Controls.Add(Me.CmbClientName)
        Me.Controls.Add(Me.CmbPaymentStatus)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DtpStartDate)
        Me.Controls.Add(Me.CmbPropertyType)
        Me.Controls.Add(Me.TxtAmount)
        Me.Controls.Add(Me.LblCtype)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.LblDate)
        Me.Controls.Add(Me.LblAmount)
        Me.Controls.Add(Me.LblClient)
        Me.Controls.Add(Me.BtnMainPage)
        Me.Controls.Add(Me.TxtSearch)
        Me.Controls.Add(Me.DgvRentals)
        Me.Name = "Rentals"
        Me.Text = "Rentals"
        CType(Me.DgvRentals, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DgvRentals As DataGridView
    Friend WithEvents TxtSearch As TextBox
    Friend WithEvents BtnMainPage As Button
    Friend WithEvents CmbPropertyID As ComboBox
    Friend WithEvents LblPropertyID As Label
    Friend WithEvents CmbClientName As ComboBox
    Friend WithEvents CmbPaymentStatus As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents DtpStartDate As DateTimePicker
    Friend WithEvents CmbPropertyType As ComboBox
    Friend WithEvents TxtAmount As TextBox
    Friend WithEvents LblCtype As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents LblDate As Label
    Friend WithEvents LblAmount As Label
    Friend WithEvents LblClient As Label
    Friend WithEvents DtpEndDate As DateTimePicker
    Friend WithEvents LblEndDate As Label
    Friend WithEvents BtnDelete As Button
    Friend WithEvents BtnEdit As Button
    Friend WithEvents BtnAdd As Button
End Class

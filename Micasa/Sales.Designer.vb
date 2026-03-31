<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Sales
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.CmbPropertyID = New System.Windows.Forms.ComboBox()
        Me.LblPropertyID = New System.Windows.Forms.Label()
        Me.CmbClientName = New System.Windows.Forms.ComboBox()
        Me.BtnMainPage = New System.Windows.Forms.Button()
        Me.CmbPaymentMethod = New System.Windows.Forms.ComboBox()
        Me.BtnDelete = New System.Windows.Forms.Button()
        Me.BtnEdit = New System.Windows.Forms.Button()
        Me.BtnAdd = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DtpSaleDate = New System.Windows.Forms.DateTimePicker()
        Me.CmbPropertyType = New System.Windows.Forms.ComboBox()
        Me.TxtAmount = New System.Windows.Forms.TextBox()
        Me.LblCtype = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.LblDate = New System.Windows.Forms.Label()
        Me.LblAmount = New System.Windows.Forms.Label()
        Me.LblClient = New System.Windows.Forms.Label()
        Me.TxtSearch = New System.Windows.Forms.TextBox()
        Me.DgvSales = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.FontDialog1 = New System.Windows.Forms.FontDialog()
        Me.Panel1.SuspendLayout()
        CType(Me.DgvSales, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.CmbPropertyID)
        Me.Panel1.Controls.Add(Me.LblPropertyID)
        Me.Panel1.Controls.Add(Me.CmbClientName)
        Me.Panel1.Controls.Add(Me.BtnMainPage)
        Me.Panel1.Controls.Add(Me.CmbPaymentMethod)
        Me.Panel1.Controls.Add(Me.BtnDelete)
        Me.Panel1.Controls.Add(Me.BtnEdit)
        Me.Panel1.Controls.Add(Me.BtnAdd)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.DtpSaleDate)
        Me.Panel1.Controls.Add(Me.CmbPropertyType)
        Me.Panel1.Controls.Add(Me.TxtAmount)
        Me.Panel1.Controls.Add(Me.LblCtype)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.LblDate)
        Me.Panel1.Controls.Add(Me.LblAmount)
        Me.Panel1.Controls.Add(Me.LblClient)
        Me.Panel1.Controls.Add(Me.TxtSearch)
        Me.Panel1.Controls.Add(Me.DgvSales)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.ForeColor = System.Drawing.Color.White
        Me.Panel1.Location = New System.Drawing.Point(-1, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1505, 1043)
        Me.Panel1.TabIndex = 0
        '
        'CmbPropertyID
        '
        Me.CmbPropertyID.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmbPropertyID.DisplayMember = "Description"
        Me.CmbPropertyID.FormattingEnabled = True
        Me.CmbPropertyID.Items.AddRange(New Object() {"House", "Apartment", "Office", "Penthouse"})
        Me.CmbPropertyID.Location = New System.Drawing.Point(654, 768)
        Me.CmbPropertyID.Name = "CmbPropertyID"
        Me.CmbPropertyID.Size = New System.Drawing.Size(121, 28)
        Me.CmbPropertyID.TabIndex = 35
        '
        'LblPropertyID
        '
        Me.LblPropertyID.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblPropertyID.AutoSize = True
        Me.LblPropertyID.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPropertyID.ForeColor = System.Drawing.Color.Black
        Me.LblPropertyID.Location = New System.Drawing.Point(482, 768)
        Me.LblPropertyID.Name = "LblPropertyID"
        Me.LblPropertyID.Size = New System.Drawing.Size(115, 25)
        Me.LblPropertyID.TabIndex = 34
        Me.LblPropertyID.Text = "Property No"
        '
        'CmbClientName
        '
        Me.CmbClientName.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmbClientName.DisplayMember = "Name"
        Me.CmbClientName.FormattingEnabled = True
        Me.CmbClientName.Items.AddRange(New Object() {""})
        Me.CmbClientName.Location = New System.Drawing.Point(224, 698)
        Me.CmbClientName.Name = "CmbClientName"
        Me.CmbClientName.Size = New System.Drawing.Size(121, 28)
        Me.CmbClientName.TabIndex = 33
        Me.CmbClientName.ValueMember = "ClientID"
        '
        'BtnMainPage
        '
        Me.BtnMainPage.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnMainPage.ForeColor = System.Drawing.Color.Black
        Me.BtnMainPage.Location = New System.Drawing.Point(623, 102)
        Me.BtnMainPage.Name = "BtnMainPage"
        Me.BtnMainPage.Size = New System.Drawing.Size(114, 37)
        Me.BtnMainPage.TabIndex = 32
        Me.BtnMainPage.Text = "Mainpage"
        Me.BtnMainPage.UseVisualStyleBackColor = True
        '
        'CmbPaymentMethod
        '
        Me.CmbPaymentMethod.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmbPaymentMethod.FormattingEnabled = True
        Me.CmbPaymentMethod.Items.AddRange(New Object() {"Cash", "Bank Deposit", "Mortage", "Lease"})
        Me.CmbPaymentMethod.Location = New System.Drawing.Point(224, 765)
        Me.CmbPaymentMethod.Name = "CmbPaymentMethod"
        Me.CmbPaymentMethod.Size = New System.Drawing.Size(121, 28)
        Me.CmbPaymentMethod.TabIndex = 29
        '
        'BtnDelete
        '
        Me.BtnDelete.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnDelete.ForeColor = System.Drawing.Color.Black
        Me.BtnDelete.Location = New System.Drawing.Point(929, 934)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(110, 43)
        Me.BtnDelete.TabIndex = 26
        Me.BtnDelete.Text = "Delete"
        Me.BtnDelete.UseVisualStyleBackColor = True
        '
        'BtnEdit
        '
        Me.BtnEdit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnEdit.ForeColor = System.Drawing.Color.Black
        Me.BtnEdit.Location = New System.Drawing.Point(647, 934)
        Me.BtnEdit.Name = "BtnEdit"
        Me.BtnEdit.Size = New System.Drawing.Size(110, 43)
        Me.BtnEdit.TabIndex = 25
        Me.BtnEdit.Text = "Edit"
        Me.BtnEdit.UseVisualStyleBackColor = True
        '
        'BtnAdd
        '
        Me.BtnAdd.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnAdd.ForeColor = System.Drawing.Color.Black
        Me.BtnAdd.Location = New System.Drawing.Point(384, 934)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(110, 43)
        Me.BtnAdd.TabIndex = 24
        Me.BtnAdd.Text = "Add"
        Me.BtnAdd.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(884, 763)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 25)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Amount"
        '
        'DtpSaleDate
        '
        Me.DtpSaleDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DtpSaleDate.Location = New System.Drawing.Point(1015, 698)
        Me.DtpSaleDate.Name = "DtpSaleDate"
        Me.DtpSaleDate.Size = New System.Drawing.Size(282, 26)
        Me.DtpSaleDate.TabIndex = 22
        '
        'CmbPropertyType
        '
        Me.CmbPropertyType.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmbPropertyType.DisplayMember = "Description"
        Me.CmbPropertyType.FormattingEnabled = True
        Me.CmbPropertyType.Items.AddRange(New Object() {"House", "Apartment", "Office", "Penthouse"})
        Me.CmbPropertyType.Location = New System.Drawing.Point(654, 701)
        Me.CmbPropertyType.Name = "CmbPropertyType"
        Me.CmbPropertyType.Size = New System.Drawing.Size(121, 28)
        Me.CmbPropertyType.TabIndex = 20
        Me.CmbPropertyType.ValueMember = "PropertyTypeID"
        '
        'TxtAmount
        '
        Me.TxtAmount.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtAmount.Location = New System.Drawing.Point(1015, 758)
        Me.TxtAmount.Name = "TxtAmount"
        Me.TxtAmount.Size = New System.Drawing.Size(100, 30)
        Me.TxtAmount.TabIndex = 18
        '
        'LblCtype
        '
        Me.LblCtype.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblCtype.AutoSize = True
        Me.LblCtype.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.LblCtype.ForeColor = System.Drawing.Color.Black
        Me.LblCtype.Location = New System.Drawing.Point(54, 768)
        Me.LblCtype.Name = "LblCtype"
        Me.LblCtype.Size = New System.Drawing.Size(160, 25)
        Me.LblCtype.TabIndex = 13
        Me.LblCtype.Text = "Payment Method"
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(482, 701)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(135, 25)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Property Type"
        '
        'LblDate
        '
        Me.LblDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblDate.AutoSize = True
        Me.LblDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.LblDate.ForeColor = System.Drawing.Color.Black
        Me.LblDate.Location = New System.Drawing.Point(885, 698)
        Me.LblDate.Name = "LblDate"
        Me.LblDate.Size = New System.Drawing.Size(98, 25)
        Me.LblDate.TabIndex = 10
        Me.LblDate.Text = "Sale Date"
        '
        'LblAmount
        '
        Me.LblAmount.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblAmount.AutoSize = True
        Me.LblAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.LblAmount.ForeColor = System.Drawing.Color.Black
        Me.LblAmount.Location = New System.Drawing.Point(885, 763)
        Me.LblAmount.Name = "LblAmount"
        Me.LblAmount.Size = New System.Drawing.Size(0, 25)
        Me.LblAmount.TabIndex = 9
        '
        'LblClient
        '
        Me.LblClient.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblClient.AutoSize = True
        Me.LblClient.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.LblClient.ForeColor = System.Drawing.Color.Black
        Me.LblClient.Location = New System.Drawing.Point(86, 701)
        Me.LblClient.Name = "LblClient"
        Me.LblClient.Size = New System.Drawing.Size(62, 25)
        Me.LblClient.TabIndex = 8
        Me.LblClient.Text = "Client"
        '
        'TxtSearch
        '
        Me.TxtSearch.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtSearch.Location = New System.Drawing.Point(23, 102)
        Me.TxtSearch.Name = "TxtSearch"
        Me.TxtSearch.Size = New System.Drawing.Size(465, 26)
        Me.TxtSearch.TabIndex = 2
        '
        'DgvSales
        '
        Me.DgvSales.AllowUserToAddRows = False
        Me.DgvSales.AllowUserToDeleteRows = False
        Me.DgvSales.AllowUserToOrderColumns = True
        Me.DgvSales.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DgvSales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvSales.GridColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.DgvSales.Location = New System.Drawing.Point(23, 180)
        Me.DgvSales.Name = "DgvSales"
        Me.DgvSales.RowHeadersWidth = 62
        Me.DgvSales.RowTemplate.Height = 28
        Me.DgvSales.Size = New System.Drawing.Size(1241, 449)
        Me.DgvSales.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(13, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(375, 55)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Managing sales"
        '
        'Sales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1709, 1045)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Sales"
        Me.Text = "Sales"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DgvSales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents DgvSales As DataGridView
    Friend WithEvents TxtSearch As TextBox
    Friend WithEvents LblClient As Label
    Friend WithEvents TxtAmount As TextBox
    Friend WithEvents LblCtype As Label
    Friend WithEvents LblDate As Label
    Friend WithEvents LblAmount As Label
    Friend WithEvents DtpSaleDate As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents BtnAdd As Button
    Friend WithEvents BtnDelete As Button
    Friend WithEvents BtnEdit As Button
    Friend WithEvents CmbPaymentMethod As ComboBox
    Friend WithEvents FontDialog1 As FontDialog
    Friend WithEvents BtnMainPage As Button
    Friend WithEvents CmbPropertyType As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents CmbClientName As ComboBox
    Friend WithEvents CmbPropertyID As ComboBox
    Friend WithEvents LblPropertyID As Label
End Class

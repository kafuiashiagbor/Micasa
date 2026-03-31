<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Properties
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BtnClear = New System.Windows.Forms.Button()
        Me.CmbPropertyType = New System.Windows.Forms.ComboBox()
        Me.BtnRemoveImage = New System.Windows.Forms.Button()
        Me.TxtImagePath = New System.Windows.Forms.TextBox()
        Me.PicPropertyImage = New System.Windows.Forms.PictureBox()
        Me.TxtpropertyID = New System.Windows.Forms.TextBox()
        Me.BtnMainpage = New System.Windows.Forms.Button()
        Me.LblpropertyID = New System.Windows.Forms.Label()
        Me.TxtSearch = New System.Windows.Forms.TextBox()
        Me.BtnDelete = New System.Windows.Forms.Button()
        Me.BtnEdit = New System.Windows.Forms.Button()
        Me.BtnAdd = New System.Windows.Forms.Button()
        Me.TxtMonthlyRent = New System.Windows.Forms.MaskedTextBox()
        Me.TxtStatus = New System.Windows.Forms.MaskedTextBox()
        Me.TxtAddress = New System.Windows.Forms.MaskedTextBox()
        Me.LblMonnthlyRent = New System.Windows.Forms.Label()
        Me.LblType = New System.Windows.Forms.Label()
        Me.LblAddress = New System.Windows.Forms.Label()
        Me.LblStatus = New System.Windows.Forms.Label()
        Me.DgvProperties = New System.Windows.Forms.DataGridView()
        Me.PropertiesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DbTenantDataSet = New Micasa.dbTenantDataSet()
        Me.PropertiesTableAdapter = New Micasa.dbTenantDataSetTableAdapters.PropertiesTableAdapter()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.bsProperties = New System.Windows.Forms.BindingSource(Me.components)
        Me.LblManaging = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.PicPropertyImage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgvProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PropertiesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DbTenantDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.BtnClear)
        Me.Panel1.Controls.Add(Me.CmbPropertyType)
        Me.Panel1.Controls.Add(Me.BtnRemoveImage)
        Me.Panel1.Controls.Add(Me.TxtImagePath)
        Me.Panel1.Controls.Add(Me.PicPropertyImage)
        Me.Panel1.Controls.Add(Me.TxtpropertyID)
        Me.Panel1.Controls.Add(Me.BtnMainpage)
        Me.Panel1.Controls.Add(Me.LblpropertyID)
        Me.Panel1.Controls.Add(Me.TxtSearch)
        Me.Panel1.Controls.Add(Me.BtnDelete)
        Me.Panel1.Controls.Add(Me.BtnEdit)
        Me.Panel1.Controls.Add(Me.BtnAdd)
        Me.Panel1.Controls.Add(Me.TxtMonthlyRent)
        Me.Panel1.Controls.Add(Me.TxtStatus)
        Me.Panel1.Controls.Add(Me.TxtAddress)
        Me.Panel1.Controls.Add(Me.LblMonnthlyRent)
        Me.Panel1.Controls.Add(Me.LblType)
        Me.Panel1.Controls.Add(Me.LblAddress)
        Me.Panel1.Controls.Add(Me.LblStatus)
        Me.Panel1.Controls.Add(Me.DgvProperties)
        Me.Panel1.Location = New System.Drawing.Point(12, 76)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1856, 861)
        Me.Panel1.TabIndex = 0
        '
        'BtnClear
        '
        Me.BtnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClear.Location = New System.Drawing.Point(977, 784)
        Me.BtnClear.Name = "BtnClear"
        Me.BtnClear.Size = New System.Drawing.Size(271, 46)
        Me.BtnClear.TabIndex = 31
        Me.BtnClear.Text = "Clear data"
        Me.BtnClear.UseVisualStyleBackColor = True
        '
        'CmbPropertyType
        '
        Me.CmbPropertyType.DisplayMember = "Description"
        Me.CmbPropertyType.FormattingEnabled = True
        Me.CmbPropertyType.Location = New System.Drawing.Point(745, 609)
        Me.CmbPropertyType.Name = "CmbPropertyType"
        Me.CmbPropertyType.Size = New System.Drawing.Size(121, 28)
        Me.CmbPropertyType.TabIndex = 30
        Me.CmbPropertyType.ValueMember = "PropertyTypeID"
        '
        'BtnRemoveImage
        '
        Me.BtnRemoveImage.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRemoveImage.Location = New System.Drawing.Point(1455, 546)
        Me.BtnRemoveImage.Name = "BtnRemoveImage"
        Me.BtnRemoveImage.Size = New System.Drawing.Size(194, 40)
        Me.BtnRemoveImage.TabIndex = 29
        Me.BtnRemoveImage.Text = "Remove image"
        Me.BtnRemoveImage.UseVisualStyleBackColor = True
        '
        'TxtImagePath
        '
        Me.TxtImagePath.Location = New System.Drawing.Point(1478, 740)
        Me.TxtImagePath.Name = "TxtImagePath"
        Me.TxtImagePath.Size = New System.Drawing.Size(121, 26)
        Me.TxtImagePath.TabIndex = 28
        Me.TxtImagePath.UseWaitCursor = True
        Me.TxtImagePath.Visible = False
        '
        'PicPropertyImage
        '
        Me.PicPropertyImage.Image = Global.Micasa.My.Resources.Resources.NoImage1
        Me.PicPropertyImage.Location = New System.Drawing.Point(1308, 79)
        Me.PicPropertyImage.Name = "PicPropertyImage"
        Me.PicPropertyImage.Size = New System.Drawing.Size(489, 424)
        Me.PicPropertyImage.TabIndex = 26
        Me.PicPropertyImage.TabStop = False
        '
        'TxtpropertyID
        '
        Me.TxtpropertyID.Location = New System.Drawing.Point(223, 546)
        Me.TxtpropertyID.Name = "TxtpropertyID"
        Me.TxtpropertyID.Size = New System.Drawing.Size(151, 26)
        Me.TxtpropertyID.TabIndex = 25
        '
        'BtnMainpage
        '
        Me.BtnMainpage.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnMainpage.Location = New System.Drawing.Point(1116, 17)
        Me.BtnMainpage.Name = "BtnMainpage"
        Me.BtnMainpage.Size = New System.Drawing.Size(147, 46)
        Me.BtnMainpage.TabIndex = 24
        Me.BtnMainpage.Text = "Mainpage"
        Me.BtnMainpage.UseVisualStyleBackColor = True
        '
        'LblpropertyID
        '
        Me.LblpropertyID.AutoSize = True
        Me.LblpropertyID.Font = New System.Drawing.Font("Mongolian Baiti", 14.0!)
        Me.LblpropertyID.Location = New System.Drawing.Point(62, 546)
        Me.LblpropertyID.Name = "LblpropertyID"
        Me.LblpropertyID.Size = New System.Drawing.Size(138, 30)
        Me.LblpropertyID.TabIndex = 22
        Me.LblpropertyID.Text = "PropertyID"
        '
        'TxtSearch
        '
        Me.TxtSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.TxtSearch.Location = New System.Drawing.Point(79, 33)
        Me.TxtSearch.Name = "TxtSearch"
        Me.TxtSearch.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.TxtSearch.Size = New System.Drawing.Size(631, 35)
        Me.TxtSearch.TabIndex = 20
        '
        'BtnDelete
        '
        Me.BtnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDelete.Location = New System.Drawing.Point(776, 784)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(103, 46)
        Me.BtnDelete.TabIndex = 13
        Me.BtnDelete.Text = "Delete"
        Me.BtnDelete.UseVisualStyleBackColor = True
        '
        'BtnEdit
        '
        Me.BtnEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEdit.Location = New System.Drawing.Point(531, 784)
        Me.BtnEdit.Name = "BtnEdit"
        Me.BtnEdit.Size = New System.Drawing.Size(117, 46)
        Me.BtnEdit.TabIndex = 12
        Me.BtnEdit.Text = "Update"
        Me.BtnEdit.UseVisualStyleBackColor = True
        '
        'BtnAdd
        '
        Me.BtnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAdd.Location = New System.Drawing.Point(289, 784)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(109, 46)
        Me.BtnAdd.TabIndex = 11
        Me.BtnAdd.Text = "Add" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.BtnAdd.UseVisualStyleBackColor = True
        '
        'TxtMonthlyRent
        '
        Me.TxtMonthlyRent.Location = New System.Drawing.Point(745, 534)
        Me.TxtMonthlyRent.Name = "TxtMonthlyRent"
        Me.TxtMonthlyRent.Size = New System.Drawing.Size(151, 26)
        Me.TxtMonthlyRent.TabIndex = 9
        '
        'TxtStatus
        '
        Me.TxtStatus.Location = New System.Drawing.Point(223, 677)
        Me.TxtStatus.Name = "TxtStatus"
        Me.TxtStatus.Size = New System.Drawing.Size(151, 26)
        Me.TxtStatus.TabIndex = 8
        '
        'TxtAddress
        '
        Me.TxtAddress.Location = New System.Drawing.Point(223, 608)
        Me.TxtAddress.Name = "TxtAddress"
        Me.TxtAddress.Size = New System.Drawing.Size(151, 26)
        Me.TxtAddress.TabIndex = 7
        '
        'LblMonnthlyRent
        '
        Me.LblMonnthlyRent.AutoSize = True
        Me.LblMonnthlyRent.Font = New System.Drawing.Font("Mongolian Baiti", 14.0!)
        Me.LblMonnthlyRent.Location = New System.Drawing.Point(512, 529)
        Me.LblMonnthlyRent.Name = "LblMonnthlyRent"
        Me.LblMonnthlyRent.Size = New System.Drawing.Size(170, 30)
        Me.LblMonnthlyRent.TabIndex = 5
        Me.LblMonnthlyRent.Text = "Monthly Rent"
        '
        'LblType
        '
        Me.LblType.AutoSize = True
        Me.LblType.Font = New System.Drawing.Font("Mongolian Baiti", 14.0!)
        Me.LblType.Location = New System.Drawing.Point(512, 600)
        Me.LblType.Name = "LblType"
        Me.LblType.Size = New System.Drawing.Size(70, 30)
        Me.LblType.TabIndex = 4
        Me.LblType.Text = "Type"
        '
        'LblAddress
        '
        Me.LblAddress.AutoSize = True
        Me.LblAddress.Font = New System.Drawing.Font("Mongolian Baiti", 14.0!)
        Me.LblAddress.Location = New System.Drawing.Point(62, 604)
        Me.LblAddress.Name = "LblAddress"
        Me.LblAddress.Size = New System.Drawing.Size(104, 30)
        Me.LblAddress.TabIndex = 3
        Me.LblAddress.Text = "Address"
        '
        'LblStatus
        '
        Me.LblStatus.AutoSize = True
        Me.LblStatus.Font = New System.Drawing.Font("Mongolian Baiti", 14.0!)
        Me.LblStatus.Location = New System.Drawing.Point(62, 677)
        Me.LblStatus.Name = "LblStatus"
        Me.LblStatus.Size = New System.Drawing.Size(82, 30)
        Me.LblStatus.TabIndex = 2
        Me.LblStatus.Text = "Status"
        '
        'DgvProperties
        '
        Me.DgvProperties.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvProperties.Location = New System.Drawing.Point(19, 79)
        Me.DgvProperties.Name = "DgvProperties"
        Me.DgvProperties.RowHeadersWidth = 62
        Me.DgvProperties.RowTemplate.Height = 28
        Me.DgvProperties.Size = New System.Drawing.Size(1258, 424)
        Me.DgvProperties.TabIndex = 0
        '
        'PropertiesBindingSource
        '
        Me.PropertiesBindingSource.DataMember = "Properties"
        Me.PropertiesBindingSource.DataSource = Me.DbTenantDataSet
        '
        'DbTenantDataSet
        '
        Me.DbTenantDataSet.DataSetName = "dbTenantDataSet"
        Me.DbTenantDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PropertiesTableAdapter
        '
        Me.PropertiesTableAdapter.ClearBeforeFill = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'bsProperties
        '
        '
        'LblManaging
        '
        Me.LblManaging.AutoSize = True
        Me.LblManaging.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblManaging.Location = New System.Drawing.Point(3, 21)
        Me.LblManaging.Name = "LblManaging"
        Me.LblManaging.Size = New System.Drawing.Size(443, 52)
        Me.LblManaging.TabIndex = 1
        Me.LblManaging.Text = "Managing Properties"
        '
        'Properties
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1903, 918)
        Me.Controls.Add(Me.LblManaging)
        Me.Controls.Add(Me.Panel1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Properties"
        Me.Text = "Properties"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PicPropertyImage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgvProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PropertiesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DbTenantDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsProperties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents DgvProperties As DataGridView
    Friend WithEvents DbTenantDataSet As dbTenantDataSet
    Friend WithEvents PropertiesBindingSource As BindingSource
    Friend WithEvents PropertiesTableAdapter As dbTenantDataSetTableAdapters.PropertiesTableAdapter
    Friend WithEvents LblMonnthlyRent As Label
    Friend WithEvents LblType As Label
    Friend WithEvents LblAddress As Label
    Friend WithEvents LblStatus As Label
    Friend WithEvents TxtMonthlyRent As MaskedTextBox
    Friend WithEvents TxtStatus As MaskedTextBox
    Friend WithEvents TxtAddress As MaskedTextBox
    Friend WithEvents BtnDelete As Button
    Friend WithEvents BtnEdit As Button
    Friend WithEvents BtnAdd As Button
    Friend WithEvents TxtSearch As TextBox
    Friend WithEvents LblpropertyID As Label
    Friend WithEvents BtnMainpage As Button
    Friend WithEvents TxtpropertyID As TextBox
    Friend WithEvents PicPropertyImage As PictureBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents TxtImagePath As TextBox
    Friend WithEvents BtnRemoveImage As Button
    Friend WithEvents bsProperties As BindingSource
    Friend WithEvents CmbPropertyType As ComboBox
    Friend WithEvents LblManaging As Label
    Friend WithEvents BtnClear As Button
End Class

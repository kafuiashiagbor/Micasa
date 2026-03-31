<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Clients
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
        Me.components = New System.ComponentModel.Container()
        Me.ClientsPanel = New System.Windows.Forms.Panel()
        Me.BtnMainpage = New System.Windows.Forms.Button()
        Me.TxtAddress = New System.Windows.Forms.TextBox()
        Me.LblAddress = New System.Windows.Forms.Label()
        Me.TxtSearch = New System.Windows.Forms.TextBox()
        Me.LblSearch = New System.Windows.Forms.Label()
        Me.LblTitle = New System.Windows.Forms.Label()
        Me.BtnEdit = New System.Windows.Forms.Button()
        Me.BtnDelete = New System.Windows.Forms.Button()
        Me.BtnAdd = New System.Windows.Forms.Button()
        Me.TxtEmail = New System.Windows.Forms.TextBox()
        Me.LblEmail = New System.Windows.Forms.Label()
        Me.DtpDateOfBirth = New System.Windows.Forms.DateTimePicker()
        Me.LblDOB = New System.Windows.Forms.Label()
        Me.TxtName = New System.Windows.Forms.TextBox()
        Me.LblName = New System.Windows.Forms.Label()
        Me.LblClient = New System.Windows.Forms.Label()
        Me.DgvClients = New System.Windows.Forms.DataGridView()
        Me.DbTenantDataSet1 = New Micasa.dbTenantDataSet()
        Me.DbTenantDataSet2 = New Micasa.dbTenantDataSet()
        Me.bsClients = New System.Windows.Forms.BindingSource(Me.components)
        Me.BtnClear = New System.Windows.Forms.Button()
        Me.ClientsPanel.SuspendLayout()
        CType(Me.DgvClients, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DbTenantDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DbTenantDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsClients, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ClientsPanel
        '
        Me.ClientsPanel.BackColor = System.Drawing.Color.White
        Me.ClientsPanel.Controls.Add(Me.BtnClear)
        Me.ClientsPanel.Controls.Add(Me.BtnMainpage)
        Me.ClientsPanel.Controls.Add(Me.TxtAddress)
        Me.ClientsPanel.Controls.Add(Me.LblAddress)
        Me.ClientsPanel.Controls.Add(Me.TxtSearch)
        Me.ClientsPanel.Controls.Add(Me.LblSearch)
        Me.ClientsPanel.Controls.Add(Me.LblTitle)
        Me.ClientsPanel.Controls.Add(Me.BtnEdit)
        Me.ClientsPanel.Controls.Add(Me.BtnDelete)
        Me.ClientsPanel.Controls.Add(Me.BtnAdd)
        Me.ClientsPanel.Controls.Add(Me.TxtEmail)
        Me.ClientsPanel.Controls.Add(Me.LblEmail)
        Me.ClientsPanel.Controls.Add(Me.DtpDateOfBirth)
        Me.ClientsPanel.Controls.Add(Me.LblDOB)
        Me.ClientsPanel.Controls.Add(Me.TxtName)
        Me.ClientsPanel.Controls.Add(Me.LblName)
        Me.ClientsPanel.Controls.Add(Me.LblClient)
        Me.ClientsPanel.Controls.Add(Me.DgvClients)
        Me.ClientsPanel.Location = New System.Drawing.Point(8, 5)
        Me.ClientsPanel.Name = "ClientsPanel"
        Me.ClientsPanel.Size = New System.Drawing.Size(1537, 1004)
        Me.ClientsPanel.TabIndex = 0
        '
        'BtnMainpage
        '
        Me.BtnMainpage.Location = New System.Drawing.Point(589, 98)
        Me.BtnMainpage.Name = "BtnMainpage"
        Me.BtnMainpage.Size = New System.Drawing.Size(100, 36)
        Me.BtnMainpage.TabIndex = 31
        Me.BtnMainpage.Text = "Mainpage"
        Me.BtnMainpage.UseVisualStyleBackColor = True
        '
        'TxtAddress
        '
        Me.TxtAddress.AcceptsTab = True
        Me.TxtAddress.Font = New System.Drawing.Font("Mongolian Baiti", 11.0!)
        Me.TxtAddress.Location = New System.Drawing.Point(834, 737)
        Me.TxtAddress.Name = "TxtAddress"
        Me.TxtAddress.Size = New System.Drawing.Size(147, 33)
        Me.TxtAddress.TabIndex = 30
        '
        'LblAddress
        '
        Me.LblAddress.AutoSize = True
        Me.LblAddress.Font = New System.Drawing.Font("Mongolian Baiti", 14.0!)
        Me.LblAddress.Location = New System.Drawing.Point(603, 737)
        Me.LblAddress.Name = "LblAddress"
        Me.LblAddress.Size = New System.Drawing.Size(104, 30)
        Me.LblAddress.TabIndex = 29
        Me.LblAddress.Text = "Address" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'TxtSearch
        '
        Me.TxtSearch.Location = New System.Drawing.Point(125, 103)
        Me.TxtSearch.Name = "TxtSearch"
        Me.TxtSearch.Size = New System.Drawing.Size(333, 26)
        Me.TxtSearch.TabIndex = 21
        '
        'LblSearch
        '
        Me.LblSearch.AutoSize = True
        Me.LblSearch.Font = New System.Drawing.Font("Mongolian Baiti", 14.0!)
        Me.LblSearch.Location = New System.Drawing.Point(9, 98)
        Me.LblSearch.Name = "LblSearch"
        Me.LblSearch.Size = New System.Drawing.Size(110, 30)
        Me.LblSearch.TabIndex = 20
        Me.LblSearch.Text = "Search : "
        '
        'LblTitle
        '
        Me.LblTitle.AutoSize = True
        Me.LblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitle.Location = New System.Drawing.Point(4, 4)
        Me.LblTitle.Name = "LblTitle"
        Me.LblTitle.Size = New System.Drawing.Size(411, 55)
        Me.LblTitle.TabIndex = 18
        Me.LblTitle.Text = "Managing Clients"
        '
        'BtnEdit
        '
        Me.BtnEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEdit.Location = New System.Drawing.Point(472, 940)
        Me.BtnEdit.Name = "BtnEdit"
        Me.BtnEdit.Size = New System.Drawing.Size(100, 40)
        Me.BtnEdit.TabIndex = 14
        Me.BtnEdit.Text = "Edit"
        Me.BtnEdit.UseVisualStyleBackColor = True
        '
        'BtnDelete
        '
        Me.BtnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDelete.Location = New System.Drawing.Point(649, 940)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(100, 40)
        Me.BtnDelete.TabIndex = 13
        Me.BtnDelete.Text = "Delete"
        Me.BtnDelete.UseVisualStyleBackColor = True
        '
        'BtnAdd
        '
        Me.BtnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAdd.Location = New System.Drawing.Point(292, 940)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(100, 40)
        Me.BtnAdd.TabIndex = 11
        Me.BtnAdd.Text = "Add"
        Me.BtnAdd.UseVisualStyleBackColor = True
        '
        'TxtEmail
        '
        Me.TxtEmail.AcceptsTab = True
        Me.TxtEmail.Font = New System.Drawing.Font("Mongolian Baiti", 11.0!)
        Me.TxtEmail.Location = New System.Drawing.Point(245, 757)
        Me.TxtEmail.Name = "TxtEmail"
        Me.TxtEmail.Size = New System.Drawing.Size(147, 33)
        Me.TxtEmail.TabIndex = 9
        '
        'LblEmail
        '
        Me.LblEmail.AutoSize = True
        Me.LblEmail.Font = New System.Drawing.Font("Mongolian Baiti", 14.0!)
        Me.LblEmail.Location = New System.Drawing.Point(85, 756)
        Me.LblEmail.Name = "LblEmail"
        Me.LblEmail.Size = New System.Drawing.Size(80, 30)
        Me.LblEmail.TabIndex = 8
        Me.LblEmail.Text = "Email"
        '
        'DtpDateOfBirth
        '
        Me.DtpDateOfBirth.CustomFormat = "mm/dd/yyyy"
        Me.DtpDateOfBirth.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DtpDateOfBirth.Location = New System.Drawing.Point(834, 680)
        Me.DtpDateOfBirth.Name = "DtpDateOfBirth"
        Me.DtpDateOfBirth.Size = New System.Drawing.Size(271, 32)
        Me.DtpDateOfBirth.TabIndex = 6
        '
        'LblDOB
        '
        Me.LblDOB.AutoSize = True
        Me.LblDOB.Font = New System.Drawing.Font("Mongolian Baiti", 14.0!)
        Me.LblDOB.Location = New System.Drawing.Point(603, 677)
        Me.LblDOB.Name = "LblDOB"
        Me.LblDOB.Size = New System.Drawing.Size(160, 30)
        Me.LblDOB.TabIndex = 5
        Me.LblDOB.Text = "Date of Birth"
        '
        'TxtName
        '
        Me.TxtName.Font = New System.Drawing.Font("Mongolian Baiti", 11.0!)
        Me.TxtName.Location = New System.Drawing.Point(245, 696)
        Me.TxtName.Name = "TxtName"
        Me.TxtName.Size = New System.Drawing.Size(147, 33)
        Me.TxtName.TabIndex = 4
        '
        'LblName
        '
        Me.LblName.AutoSize = True
        Me.LblName.Font = New System.Drawing.Font("Mongolian Baiti", 14.0!)
        Me.LblName.Location = New System.Drawing.Point(85, 694)
        Me.LblName.Name = "LblName"
        Me.LblName.Size = New System.Drawing.Size(79, 30)
        Me.LblName.TabIndex = 3
        Me.LblName.Text = "Name"
        '
        'LblClient
        '
        Me.LblClient.AutoSize = True
        Me.LblClient.Font = New System.Drawing.Font("Mongolian Baiti", 14.0!)
        Me.LblClient.Location = New System.Drawing.Point(84, 653)
        Me.LblClient.Name = "LblClient"
        Me.LblClient.Size = New System.Drawing.Size(0, 30)
        Me.LblClient.TabIndex = 1
        '
        'DgvClients
        '
        Me.DgvClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvClients.Location = New System.Drawing.Point(26, 196)
        Me.DgvClients.Name = "DgvClients"
        Me.DgvClients.RowHeadersWidth = 62
        Me.DgvClients.RowTemplate.Height = 28
        Me.DgvClients.Size = New System.Drawing.Size(1166, 428)
        Me.DgvClients.TabIndex = 0
        '
        'DbTenantDataSet1
        '
        Me.DbTenantDataSet1.DataSetName = "dbTenantDataSet"
        Me.DbTenantDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DbTenantDataSet2
        '
        Me.DbTenantDataSet2.DataSetName = "dbTenantDataSet"
        Me.DbTenantDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BtnClear
        '
        Me.BtnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClear.Location = New System.Drawing.Point(819, 940)
        Me.BtnClear.Name = "BtnClear"
        Me.BtnClear.Size = New System.Drawing.Size(162, 40)
        Me.BtnClear.TabIndex = 32
        Me.BtnClear.Text = "Clear Data"
        Me.BtnClear.UseVisualStyleBackColor = True
        '
        'Clients
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1535, 1021)
        Me.Controls.Add(Me.ClientsPanel)
        Me.Name = "Clients"
        Me.Text = "Clients"
        Me.ClientsPanel.ResumeLayout(False)
        Me.ClientsPanel.PerformLayout()
        CType(Me.DgvClients, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DbTenantDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DbTenantDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsClients, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ClientsPanel As Panel
    Friend WithEvents DgvClients As DataGridView
    Friend WithEvents LblClient As Label
    Friend WithEvents LblDOB As Label
    Friend WithEvents TxtName As TextBox
    Friend WithEvents LblName As Label
    Friend WithEvents DtpDateOfBirth As DateTimePicker
    Friend WithEvents LblEmail As Label
    Friend WithEvents TxtEmail As TextBox
    Friend WithEvents BtnEdit As Button
    Friend WithEvents BtnDelete As Button
    Friend WithEvents BtnAdd As Button
    Friend WithEvents LblSearch As Label
    Friend WithEvents LblTitle As Label
    Friend WithEvents TxtSearch As TextBox
    Friend WithEvents TxtAddress As TextBox
    Friend WithEvents LblAddress As Label
    Friend WithEvents BtnMainpage As Button
    Friend WithEvents DbTenantDataSet1 As dbTenantDataSet
    Friend WithEvents DbTenantDataSet2 As dbTenantDataSet
    Friend WithEvents bsClients As BindingSource
    Friend WithEvents BtnClear As Button
End Class

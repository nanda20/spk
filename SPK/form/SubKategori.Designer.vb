<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SubKategori
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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtUserLogin = New System.Windows.Forms.Label()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnInsert = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tabelSubKategori = New System.Windows.Forms.DataGridView()
        Me.txtKategori = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.Label()
        Me.cmbKategori = New System.Windows.Forms.ComboBox()
        Me.Panel2.SuspendLayout()
        CType(Me.tabelSubKategori, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.Panel1.Location = New System.Drawing.Point(-4, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(531, 10)
        Me.Panel1.TabIndex = 35
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.txtUserLogin)
        Me.Panel2.Location = New System.Drawing.Point(-4, 9)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(531, 57)
        Me.Panel2.TabIndex = 36
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Square721 Cn BT", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label6.Location = New System.Drawing.Point(34, 4)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(206, 42)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "SUB KATEGORI"
        '
        'txtUserLogin
        '
        Me.txtUserLogin.AutoSize = True
        Me.txtUserLogin.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUserLogin.Location = New System.Drawing.Point(1145, 25)
        Me.txtUserLogin.Name = "txtUserLogin"
        Me.txtUserLogin.Size = New System.Drawing.Size(61, 23)
        Me.txtUserLogin.TabIndex = 1
        Me.txtUserLogin.Text = "LOGIN"
        '
        'btnReset
        '
        Me.btnReset.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.btnReset.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnReset.FlatAppearance.BorderSize = 0
        Me.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReset.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnReset.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnReset.Location = New System.Drawing.Point(360, 194)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(101, 36)
        Me.btnReset.TabIndex = 48
        Me.btnReset.Text = "RESET"
        Me.btnReset.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDelete.FlatAppearance.BorderSize = 0
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnDelete.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnDelete.Location = New System.Drawing.Point(262, 194)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(101, 36)
        Me.btnDelete.TabIndex = 47
        Me.btnDelete.Text = "DELETE"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUpdate.FlatAppearance.BorderSize = 0
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnUpdate.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnUpdate.Location = New System.Drawing.Point(163, 194)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(101, 36)
        Me.btnUpdate.TabIndex = 46
        Me.btnUpdate.Text = "UPDATE"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'btnInsert
        '
        Me.btnInsert.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.btnInsert.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnInsert.FlatAppearance.BorderSize = 0
        Me.btnInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInsert.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnInsert.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnInsert.Location = New System.Drawing.Point(66, 194)
        Me.btnInsert.Name = "btnInsert"
        Me.btnInsert.Size = New System.Drawing.Size(101, 36)
        Me.btnInsert.TabIndex = 45
        Me.btnInsert.Text = "INSERT"
        Me.btnInsert.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(167, 134)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(15, 23)
        Me.Label2.TabIndex = 43
        Me.Label2.Text = ":"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(33, 134)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(90, 23)
        Me.Label5.TabIndex = 42
        Me.Label5.Text = "KATEGORI"
        '
        'tabelSubKategori
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabelSubKategori.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.tabelSubKategori.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.tabelSubKategori.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tabelSubKategori.Location = New System.Drawing.Point(38, 247)
        Me.tabelSubKategori.Name = "tabelSubKategori"
        Me.tabelSubKategori.Size = New System.Drawing.Size(449, 313)
        Me.tabelSubKategori.TabIndex = 41
        '
        'txtKategori
        '
        Me.txtKategori.Font = New System.Drawing.Font("Tahoma", 12.75!)
        Me.txtKategori.Location = New System.Drawing.Point(191, 95)
        Me.txtKategori.Name = "txtKategori"
        Me.txtKategori.Size = New System.Drawing.Size(296, 28)
        Me.txtKategori.TabIndex = 39
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(167, 99)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(15, 23)
        Me.Label4.TabIndex = 38
        Me.Label4.Text = ":"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(33, 98)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(126, 23)
        Me.Label3.TabIndex = 37
        Me.Label3.Text = "SUB KATEGORI"
        '
        'txtID
        '
        Me.txtID.AutoSize = True
        Me.txtID.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtID.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtID.Location = New System.Drawing.Point(34, 76)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(16, 23)
        Me.txtID.TabIndex = 40
        Me.txtID.Text = "-"
        '
        'cmbKategori
        '
        Me.cmbKategori.Font = New System.Drawing.Font("Tahoma", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbKategori.FormattingEnabled = True
        Me.cmbKategori.Location = New System.Drawing.Point(191, 134)
        Me.cmbKategori.Name = "cmbKategori"
        Me.cmbKategori.Size = New System.Drawing.Size(296, 29)
        Me.cmbKategori.TabIndex = 49
        '
        'SubKategori
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(527, 571)
        Me.Controls.Add(Me.cmbKategori)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnInsert)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.tabelSubKategori)
        Me.Controls.Add(Me.txtKategori)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtID)
        Me.Name = "SubKategori"
        Me.Text = "SubKategori"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.tabelSubKategori, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtUserLogin As System.Windows.Forms.Label
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents btnInsert As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents tabelSubKategori As System.Windows.Forms.DataGridView
    Friend WithEvents txtKategori As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtID As System.Windows.Forms.Label
    Friend WithEvents cmbKategori As System.Windows.Forms.ComboBox
End Class

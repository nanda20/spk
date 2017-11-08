<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormKategori
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnInsert = New System.Windows.Forms.Button()
        Me.tabelKategori = New System.Windows.Forms.DataGridView()
        Me.btnCariBarang = New System.Windows.Forms.Button()
        Me.txtCariKategori = New System.Windows.Forms.TextBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtUserLogin = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.txtIdKategori = New System.Windows.Forms.Label()
        Me.txtBobot = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtKategori = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtIdBarang = New System.Windows.Forms.Label()
        CType(Me.tabelKategori, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnReset
        '
        Me.btnReset.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.btnReset.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnReset.FlatAppearance.BorderSize = 0
        Me.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReset.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.btnReset.Location = New System.Drawing.Point(439, 117)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(101, 40)
        Me.btnReset.TabIndex = 26
        Me.btnReset.Text = "RESET"
        Me.btnReset.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDelete.FlatAppearance.BorderSize = 0
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.btnDelete.Location = New System.Drawing.Point(341, 117)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(101, 40)
        Me.btnDelete.TabIndex = 25
        Me.btnDelete.Text = "DELETE"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUpdate.FlatAppearance.BorderSize = 0
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.btnUpdate.Location = New System.Drawing.Point(242, 117)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(101, 40)
        Me.btnUpdate.TabIndex = 24
        Me.btnUpdate.Text = "UPDATE"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'btnInsert
        '
        Me.btnInsert.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.btnInsert.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnInsert.FlatAppearance.BorderSize = 0
        Me.btnInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInsert.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInsert.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.btnInsert.Location = New System.Drawing.Point(145, 117)
        Me.btnInsert.Name = "btnInsert"
        Me.btnInsert.Size = New System.Drawing.Size(101, 40)
        Me.btnInsert.TabIndex = 23
        Me.btnInsert.Text = "INSERT"
        Me.btnInsert.UseVisualStyleBackColor = False
        '
        'tabelKategori
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.tabelKategori.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.tabelKategori.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.tabelKategori.DefaultCellStyle = DataGridViewCellStyle2
        Me.tabelKategori.Location = New System.Drawing.Point(17, 59)
        Me.tabelKategori.Name = "tabelKategori"
        Me.tabelKategori.Size = New System.Drawing.Size(543, 448)
        Me.tabelKategori.TabIndex = 28
        '
        'btnCariBarang
        '
        Me.btnCariBarang.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.btnCariBarang.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCariBarang.FlatAppearance.BorderSize = 0
        Me.btnCariBarang.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCariBarang.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCariBarang.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnCariBarang.Location = New System.Drawing.Point(497, 21)
        Me.btnCariBarang.Name = "btnCariBarang"
        Me.btnCariBarang.Size = New System.Drawing.Size(63, 29)
        Me.btnCariBarang.TabIndex = 27
        Me.btnCariBarang.Text = "CARI"
        Me.btnCariBarang.UseVisualStyleBackColor = False
        '
        'txtCariKategori
        '
        Me.txtCariKategori.Font = New System.Drawing.Font("Tahoma", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCariKategori.Location = New System.Drawing.Point(131, 21)
        Me.txtCariKategori.Name = "txtCariKategori"
        Me.txtCariKategori.Size = New System.Drawing.Size(360, 28)
        Me.txtCariKategori.TabIndex = 7
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Panel4.Controls.Add(Me.tabelKategori)
        Me.Panel4.Controls.Add(Me.btnCariBarang)
        Me.Panel4.Controls.Add(Me.txtCariKategori)
        Me.Panel4.Controls.Add(Me.Label16)
        Me.Panel4.Controls.Add(Me.Label17)
        Me.Panel4.Location = New System.Drawing.Point(634, 121)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(580, 521)
        Me.Panel4.TabIndex = 7
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Label16.Location = New System.Drawing.Point(105, 25)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(15, 23)
        Me.Label16.TabIndex = 6
        Me.Label16.Text = ":"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Label17.Location = New System.Drawing.Point(13, 25)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(90, 23)
        Me.Label17.TabIndex = 5
        Me.Label17.Text = "KATEGORI"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.Panel1.Location = New System.Drawing.Point(-1, -1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1366, 10)
        Me.Panel1.TabIndex = 4
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.Panel2.Controls.Add(Me.txtUserLogin)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(-1, 8)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1366, 75)
        Me.Panel2.TabIndex = 5
        '
        'txtUserLogin
        '
        Me.txtUserLogin.AutoSize = True
        Me.txtUserLogin.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUserLogin.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtUserLogin.Location = New System.Drawing.Point(1153, 25)
        Me.txtUserLogin.Name = "txtUserLogin"
        Me.txtUserLogin.Size = New System.Drawing.Size(16, 23)
        Me.txtUserLogin.TabIndex = 1
        Me.txtUserLogin.Text = "-"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Square721 Cn BT", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(21, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(200, 42)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "DATA Kategori"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Panel3.Controls.Add(Me.txtIdKategori)
        Me.Panel3.Controls.Add(Me.txtBobot)
        Me.Panel3.Controls.Add(Me.btnReset)
        Me.Panel3.Controls.Add(Me.btnDelete)
        Me.Panel3.Controls.Add(Me.btnUpdate)
        Me.Panel3.Controls.Add(Me.btnInsert)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Controls.Add(Me.txtKategori)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.txtIdBarang)
        Me.Panel3.Location = New System.Drawing.Point(29, 121)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(580, 521)
        Me.Panel3.TabIndex = 6
        '
        'txtIdKategori
        '
        Me.txtIdKategori.AutoSize = True
        Me.txtIdKategori.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdKategori.ForeColor = System.Drawing.Color.White
        Me.txtIdKategori.Location = New System.Drawing.Point(38, 178)
        Me.txtIdKategori.Name = "txtIdKategori"
        Me.txtIdKategori.Size = New System.Drawing.Size(90, 23)
        Me.txtIdKategori.TabIndex = 28
        Me.txtIdKategori.Text = "KATEGORI"
        '
        'txtBobot
        '
        Me.txtBobot.Font = New System.Drawing.Font("Tahoma", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBobot.Location = New System.Drawing.Point(139, 65)
        Me.txtBobot.Name = "txtBobot"
        Me.txtBobot.Size = New System.Drawing.Size(401, 28)
        Me.txtBobot.TabIndex = 27
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(113, 65)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(15, 23)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = ":"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(21, 65)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(67, 23)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "BOBOT"
        '
        'txtKategori
        '
        Me.txtKategori.Font = New System.Drawing.Font("Tahoma", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKategori.Location = New System.Drawing.Point(139, 21)
        Me.txtKategori.Name = "txtKategori"
        Me.txtKategori.Size = New System.Drawing.Size(401, 28)
        Me.txtKategori.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(113, 25)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(15, 23)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = ":"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(21, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 23)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "KATEGORI"
        '
        'txtIdBarang
        '
        Me.txtIdBarang.AutoSize = True
        Me.txtIdBarang.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdBarang.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.txtIdBarang.Location = New System.Drawing.Point(21, 11)
        Me.txtIdBarang.Name = "txtIdBarang"
        Me.txtIdBarang.Size = New System.Drawing.Size(64, 23)
        Me.txtIdBarang.TabIndex = 22
        Me.txtIdBarang.Text = "NAMA"
        '
        'FormKategori
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1250, 681)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel3)
        Me.Name = "FormKategori"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Kriteria"
        CType(Me.tabelKategori, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents btnInsert As System.Windows.Forms.Button
    Friend WithEvents tabelKategori As System.Windows.Forms.DataGridView
    Friend WithEvents btnCariBarang As System.Windows.Forms.Button
    Friend WithEvents txtCariKategori As System.Windows.Forms.TextBox
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents txtUserLogin As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtKategori As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtIdBarang As System.Windows.Forms.Label
    Friend WithEvents txtBobot As System.Windows.Forms.TextBox
    Friend WithEvents txtIdKategori As System.Windows.Forms.Label

End Class

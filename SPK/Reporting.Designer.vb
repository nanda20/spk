<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Reporting
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
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btnCariPasien = New System.Windows.Forms.Button()
        Me.txtUserLogin = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Location = New System.Drawing.Point(-1, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(744, 57)
        Me.Panel2.TabIndex = 3
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.Panel3.Location = New System.Drawing.Point(-4, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(748, 10)
        Me.Panel3.TabIndex = 9
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.Panel4.Controls.Add(Me.btnCariPasien)
        Me.Panel4.Controls.Add(Me.txtUserLogin)
        Me.Panel4.Controls.Add(Me.Label1)
        Me.Panel4.Location = New System.Drawing.Point(-4, 9)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(748, 45)
        Me.Panel4.TabIndex = 10
        '
        'btnCariPasien
        '
        Me.btnCariPasien.BackColor = System.Drawing.Color.White
        Me.btnCariPasien.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCariPasien.FlatAppearance.BorderSize = 0
        Me.btnCariPasien.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCariPasien.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCariPasien.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnCariPasien.Location = New System.Drawing.Point(671, 7)
        Me.btnCariPasien.Name = "btnCariPasien"
        Me.btnCariPasien.Size = New System.Drawing.Size(63, 28)
        Me.btnCariPasien.TabIndex = 28
        Me.btnCariPasien.Text = "SUBMIT"
        Me.btnCariPasien.UseVisualStyleBackColor = False
        '
        'txtUserLogin
        '
        Me.txtUserLogin.AutoSize = True
        Me.txtUserLogin.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUserLogin.Location = New System.Drawing.Point(1363, 23)
        Me.txtUserLogin.Name = "txtUserLogin"
        Me.txtUserLogin.Size = New System.Drawing.Size(61, 23)
        Me.txtUserLogin.TabIndex = 1
        Me.txtUserLogin.Text = "LOGIN"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(11, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(149, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "LAPORAN TERAPI"
        '
        'Panel1
        '
        Me.Panel1.Location = New System.Drawing.Point(0, 52)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(741, 681)
        Me.Panel1.TabIndex = 2
        '
        'Reporting
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(743, 732)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Reporting"
        Me.Text = "Reporting"
        Me.Panel2.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents btnCariPasien As System.Windows.Forms.Button
    Friend WithEvents txtUserLogin As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PopUpDataPenduduk
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btnCariPasien = New System.Windows.Forms.Button()
        Me.txtNama = New System.Windows.Forms.TextBox()
        Me.tabelPenduduk = New System.Windows.Forms.DataGridView()
        CType(Me.tabelPenduduk, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCariPasien
        '
        Me.btnCariPasien.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.btnCariPasien.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCariPasien.FlatAppearance.BorderSize = 0
        Me.btnCariPasien.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCariPasien.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCariPasien.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnCariPasien.Location = New System.Drawing.Point(686, 24)
        Me.btnCariPasien.Name = "btnCariPasien"
        Me.btnCariPasien.Size = New System.Drawing.Size(63, 29)
        Me.btnCariPasien.TabIndex = 34
        Me.btnCariPasien.Text = "CARI"
        Me.btnCariPasien.UseVisualStyleBackColor = False
        '
        'txtNama
        '
        Me.txtNama.Font = New System.Drawing.Font("Tahoma", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNama.Location = New System.Drawing.Point(352, 24)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Size = New System.Drawing.Size(328, 28)
        Me.txtNama.TabIndex = 33
        '
        'tabelPenduduk
        '
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabelPenduduk.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.tabelPenduduk.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.tabelPenduduk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.tabelPenduduk.DefaultCellStyle = DataGridViewCellStyle3
        Me.tabelPenduduk.Location = New System.Drawing.Point(12, 68)
        Me.tabelPenduduk.Name = "tabelPenduduk"
        Me.tabelPenduduk.Size = New System.Drawing.Size(737, 381)
        Me.tabelPenduduk.TabIndex = 32
        '
        'PopUpDataPenduduk
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(763, 473)
        Me.Controls.Add(Me.btnCariPasien)
        Me.Controls.Add(Me.txtNama)
        Me.Controls.Add(Me.tabelPenduduk)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "PopUpDataPenduduk"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Data Penduduk"
        CType(Me.tabelPenduduk, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCariPasien As System.Windows.Forms.Button
    Friend WithEvents txtNama As System.Windows.Forms.TextBox
    Friend WithEvents tabelPenduduk As System.Windows.Forms.DataGridView
End Class

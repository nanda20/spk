Imports MySql.Data.MySqlClient
Public Class FormPenduduk

    Private Sub DataPenduduk_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        loadTabelPenduduk()
    End Sub

    Private Sub txtCari_TextChanged(sender As Object, e As EventArgs) Handles txtCari.TextChanged
        Dim pasien As New PendudukDao
        tabelPenduduk.DataSource = pasien.selectByNama(txtCari.Text)
        tabelPenduduk.Refresh()
    End Sub

    Private Sub loadTabelPenduduk()
        tabelPenduduk.DataSource = New PendudukDao().selectAll
        tabelPenduduk.Refresh()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        Dim Penduduk As New PendudukDao
        Dim jk As String
        If rbtnL.Checked = True Then
            jk = "L"
        Else
            jk = "P"
        End If

        Penduduk.noKtp = txtNoKtp.Text
        Penduduk.nama = txtNama1.Text
        Penduduk.gender = jk
        Penduduk.alamat = txtAlamat.Text
        Penduduk.noTelp = txtNoTelp.Text
        Penduduk.keterangan = txtKet.Text

        Penduduk.insert()

        Reset()
        loadTabelPenduduk()
    End Sub


    Private Sub tabelPenduduk_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles tabelPenduduk.CellMouseClick
        Dim index As Integer = tabelPenduduk.SelectedCells.Item(0).RowIndex
        txtNama1.Text = tabelPenduduk.Item(3, index).Value.ToString
        txtNoKtp.Text = tabelPenduduk.Item(2, index).Value.ToString
        Dim jk As String = tabelPenduduk.Item(4, index).Value.ToString
        If jk = "L" Then
            rbtnL.Checked = True
        Else
            rbtnP.Checked = True
        End If
        txtAlamat.Text = tabelPenduduk.Item(5, index).Value.ToString
        txtNoTelp.Text = tabelPenduduk.Item(6, index).Value.ToString
        txtKet.Text = tabelPenduduk.Item(7, index).Value.ToString


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If txtNama.Text <> "" Then
            MsgBox("Pilih Data Terlebih Dahulu")
        Else
            If MsgBox("Anda Yakin Ingin ingin menghapus data ?", MsgBoxStyle.OkCancel, "Delete Data") = MsgBoxResult.Ok Then
                Dim Penduduk As New PendudukDao
                Penduduk.noKtp = txtNoKtp.Text
                Penduduk.delete()
                loadTabelPenduduk()
                Reset()
            End If
        End If
    End Sub
    Private Sub Reset()
        txtKet.Text = ""
        txtNama1.Text = ""
        txtAlamat.Text = ""
        txtNoTelp.Text = ""
        txtNoKtp.Text = ""
        rbtnL.Checked = False
        rbtnP.Checked = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Reset()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim Penduduk As New PendudukDao
        Dim jk As String
        If rbtnL.Checked = True Then
            jk = "L"
        Else
            jk = "P"
        End If

        Penduduk.noKtp = txtNoKtp.Text
        Penduduk.nama = txtNama1.Text
        Penduduk.gender = jk
        Penduduk.alamat = txtAlamat.Text
        Penduduk.noTelp = txtNoTelp.Text
        Penduduk.keterangan = txtKet.Text

        Penduduk.update()

        Reset()
        loadTabelPenduduk()
    End Sub

    Private Sub tabelPenduduk_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles tabelPenduduk.CellContentClick

    End Sub
End Class
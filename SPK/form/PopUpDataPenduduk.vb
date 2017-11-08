Public Class PopUpDataPenduduk

    Private Sub PopUpDataPenduduk_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadTabelPenduduk()
    End Sub
    Private Sub loadTabelPenduduk()
        tabelPenduduk.DataSource = New PendudukDao().selectAll
        tabelPenduduk.Refresh()
    End Sub

    Private Sub tabelPenduduk_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles tabelPenduduk.MouseDoubleClick
        InputNilaiSPK.txtNoKtp.Text = tabelPenduduk.CurrentRow.Cells(2).Value
        InputNilaiSPK.txtNama.Text = tabelPenduduk.CurrentRow.Cells(3).Value
        InputNilaiSPK.txtAlamat.Text = tabelPenduduk.CurrentRow.Cells(5).Value
        Me.Close()
    End Sub

    Private Sub txtCariPasien_TextChanged(sender As Object, e As EventArgs) Handles txtNama.TextChanged
        Dim pasien As New PendudukDao
        tabelPenduduk.DataSource = pasien.selectByNama(txtNama.Text)
        tabelPenduduk.Refresh()
    End Sub

    Private Sub tabelPenduduk_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles tabelPenduduk.CellContentClick

    End Sub
End Class
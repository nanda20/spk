Imports MySql.Data.MySqlClient
Public Class FormKategori



    Private Sub Kategori_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadTabelKategori()
    End Sub
    Private Sub loadTabelKategori()
        tabelKategori.DataSource = New KategoriDao().selectAll
        tabelKategori.Refresh()
    End Sub

    Private Sub btnInsert_Click(sender As Object, e As EventArgs) Handles btnInsert.Click
        Dim Kategori As New KategoriDao
        Kategori.kategori = txtBobot.Text
        Kategori.bobot = txtBobot.Text
        
        Kategori.insert()

        Reset()
        loadTabelKategori()
    End Sub
    Private Sub Reset()
        txtIdKategori.Text = ""
        txtKategori.Text = ""
        txtBobot.Text = ""

    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        Reset()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim Kategori As New KategoriDao
        Kategori.idKategori = txtIdKategori.Text
        Kategori.kategori = txtBobot.Text
        Kategori.bobot = Val(txtBobot.Text)

        Kategori.update()

        Reset()
        loadTabelKategori()
    End Sub

     

    Private Sub tabelKategori_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles tabelKategori.CellMouseClick
        Dim index As Integer = tabelKategori.SelectedCells.Item(0).RowIndex
        txtIdKategori.Text = tabelKategori.Item(0, index).Value.ToString
        txtKategori.Text = tabelKategori.Item(1, index).Value.ToString
        txtBobot.Text = tabelKategori.Item(2, index).Value.ToString
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If txtIdKategori.Text = "" Then
            MsgBox("Pilih Data Terlebih Dahulu")
        Else
            If MsgBox("Anda Yakin Ingin ingin menghapus data ?", MsgBoxStyle.OkCancel, "Delete Data") = MsgBoxResult.Ok Then
                Dim Kategori As New KategoriDao
                Kategori.idKategori = txtIdKategori.Text
                Kategori.delete()
                Reset()
                loadTabelKategori()
            End If
        End If
    End Sub

    Private Sub txtCariBarang_TextChanged(sender As Object, e As EventArgs) Handles txtCariKategori.TextChanged
        Dim Kategori As New KategoriDao
        tabelKategori.DataSource = Kategori.selectByNama(txtCariKategori.Text)
        tabelKategori.Refresh()
    End Sub
End Class

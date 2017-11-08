Imports MySql.Data.MySqlClient
Public Class SubKategori
  Dim cLeft As Integer = 1
 
  
    Private Sub SubKategori_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadTabelSubKategori()
        getKategori()



    End Sub
    Private Sub loadTabelSubKategori()
        tabelSubKategori.DataSource = New SubKategoriDao().selectAll
        tabelSubKategori.Refresh()
    End Sub


    Private Sub getKategori()
        Dim sql As String = "select idKategori, kategori from kategori "

        Try
            konkeksiDB()
            conn.Open()
            dtTable = New DataTable
            dtAdapter = New MySqlDataAdapter(sql, conn)
            dtAdapter.Fill(dtTable)
            cmbKategori.DataSource = dtTable
            cmbKategori.DisplayMember = "kategori"
            cmbKategori.ValueMember = "idKategori"
            conn.Close()
        Catch ex As Exception
            MsgBox("gagal" + ex.ToString)
            conn.Close()
        End Try

    End Sub

End Class
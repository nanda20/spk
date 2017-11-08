Imports MySql.Data.MySqlClient

Public Class InputNilaiSPK
    Dim cLeft As Integer = 1
    Dim copyT As TextBox
    Private Sub InputNilaiSPK_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        getKategori()
        loadTabelKategori()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        PopUpDataPenduduk.Show()
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

  
    Private Sub cmbKategori_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbKategori.SelectedIndexChanged
        'MsgBox(cmbKategori.Text.ToString)
        getSubKategori(cmbKategori.Text)
    End Sub

    Private Sub getSubKategori(val As String)
        Dim subKategori As New SubKategoriDao
        If (val.Equals("Kondisi Rumah")) Then
            For i As Integer = 0 To 5
                AddNewTextBox(val)
            Next

        End If

    End Sub
    Public Function AddNewTextBox(kat As String) As System.Windows.Forms.TextBox
        Dim txt As New System.Windows.Forms.TextBox()
        Me.Controls.Add(txt)
        txt.Top = cLeft * 25
        txt.Left = 200
        'txt.Text = "TextBox " & Me.cLeft.ToString
        txt.Name = "txt" + kat & Me.cLeft.ToString
        cLeft = cLeft + 1
        copyT = txt
        Return txt
    End Function

    Private Sub cmbKategori_TabIndexChanged(sender As Object, e As EventArgs) Handles cmbKategori.TabIndexChanged
        'MsgBox(cmbKategori.Text.ToString)
    End Sub

    Private Sub cmbKategori_ValueMemberChanged(sender As Object, e As EventArgs) Handles cmbKategori.ValueMemberChanged
        'MsgBox(cmbKategori.Text.ToString)
    End Sub
    Private Sub loadTabelKategori()
        tabelNilai.DataSource = New NIlaiDao().selectAll
        tabelNilai.Refresh()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FormLoading.Show()
        hitungWSM()
        FormLoading.Close()

        'MsgBox(tabelNilai.RowCount.ToString)
    End Sub

    Private Sub hitungWSM()


        'pendeklarasian Bobot Sub Kategori
        Dim bobotSubKategori() As Double = {0.3, 0.2, 0.3, 0.2, 0.1, 0.15, 0.1, 0.1, 0.2, 0.15, 0.2, 1, 1, 0.6, 0.4}

        'pendeklarasian Bobot Kategori
        Dim bobotKategori() As Double = {0.3, 0.2, 0.1, 0.2, 0.2}

        'Jumlah Kategori
        Dim countKategori As Integer = 16


        'deklarasi Array 2D, untuk Kolom perhitungan ke 1
        'index[0]= idPenduduk, index[1]-index[15] untuk nilai
        Dim dataNilai(3000, countKategori) As Double

        'Deklarasi Array 2d,untuk perhitungan ke 2
        Dim dataNilaiFinal(3000, 6) As Double

        'Menghitung jumlah baris
        Dim countRows As Integer = tabelNilai.RowCount
        Dim countpenduduk As Integer = 0

        Dim counterBaris As Integer = 0
        Dim counterKolom As Integer = countKategori - 1


        For i As Integer = 0 To countRows - 1





            'memasukan Id Penduduk 
            If i Mod countKategori = 0 Then
                'tabelKategori.Item(0, index).Value.ToString
                Try

                    'Digunakan untuk memasukan IdPenduduk

                    dataNilai(countpenduduk, 0) = tabelNilai.Item(5, i).Value

                    countpenduduk += 1

                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try

            End If

            '-----------------------------------------------------------------
            ' input nilai kedalam array 2 Dimensi
            If i > 0 And i Mod 15 = 0 Then
                counterBaris += 1
                counterKolom = 1

            Else
                If i = 0 Then
                    counterKolom = 1
                End If
            End If

            dataNilai(counterBaris, counterKolom) = tabelNilai.Item(4, i).Value
            counterKolom += 1


        Next


        For i As Integer = 0 To 3
            For y As Integer = 0 To 15
                Debug.Write(i.ToString + "," + y.ToString + "=" + dataNilai(i, y).ToString + " | ")
            Next
            Debug.WriteLine("")
        Next
        Debug.WriteLine("")
        Debug.WriteLine("")
        Debug.WriteLine("------------------------------Pengkalian Dengan Sub Kategori Bobot -------------------------------------------------------------------")
        Debug.WriteLine("")
        Debug.WriteLine("")

        For i As Integer = 0 To 3
            For y As Integer = 0 To 15
                If (y < 15) Then
                    dataNilai(i, y + 1) = (dataNilai(i, y + 1) * bobotSubKategori(y))
                End If

            Next
        Next

        For i As Integer = 0 To 3
            For y As Integer = 0 To 15
                Debug.Write(dataNilai(i, y).ToString + " | ")
            Next
            Debug.WriteLine("")
        Next


        Debug.WriteLine("")
        Debug.WriteLine("")
        Debug.WriteLine("------------------------------Pengkalian Dengan  Kategori Bobot -------------------------------------------------------------------")
        Debug.WriteLine("")
        Debug.WriteLine("")

        For i As Integer = 0 To 3

            For y As Integer = 0 To 15

                If y >= 1 And y <= 4 Then

                    dataNilaiFinal(i, 1) += dataNilai(i, y)

                End If

                If y > 4 And y <= 11 Then

                    dataNilaiFinal(i, 2) += dataNilai(i, y)

                End If
                If (y = 12) Then
                    dataNilaiFinal(i, 3) += dataNilai(i, 12)

                End If

                If (y = 13) Then
                    dataNilaiFinal(i, 4) += dataNilai(i, 13)

                End If

                If y > 13 And y <= 15 Then
                    dataNilaiFinal(i, 5) += dataNilai(i, y)

                End If



            Next
            Debug.WriteLine("")
        Next

        Debug.WriteLine("------------------------------Hasil -------------------------------------------------------------------")


        For i As Integer = 0 To 3
            For y As Integer = 0 To 5
                If (y < 5) Then
                    dataNilaiFinal(i, 0) = dataNilai(i, 0)
                    dataNilaiFinal(i, y + 1) = dataNilaiFinal(i, y + 1) * bobotKategori(y)
                    Debug.Write(dataNilaiFinal(i, y + 1).ToString + "|")
                End If

            Next
            Debug.WriteLine("")
        Next
        Debug.WriteLine("------------------------------Hasil -------------------------------------------------------------------")
        Dim penduduk As New PendudukDao
        For i As Integer = 0 To 3
            For y As Integer = 1 To 5

                'dataNilaiFinal(i, 0) = dataNilai(i, 0)

                dataNilaiFinal(i, 1) += dataNilaiFinal(i, y + 1)
            Next
            penduduk.updateHitung(dataNilaiFinal(i, 1), dataNilaiFinal(i, 0))
            Debug.Write(dataNilaiFinal(i, 0).ToString + " | " + dataNilaiFinal(i, 1).ToString + "|")
            Debug.WriteLine("")
        Next



    End Sub
End Class
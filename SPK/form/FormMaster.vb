Public Class FormMaster


    Private Sub Panel3_MouseClick(sender As Object, e As MouseEventArgs) Handles Panel3.MouseClick
        FormPenduduk.Show()
    End Sub

     
    Private Sub Panel14_MouseClick(sender As Object, e As MouseEventArgs) Handles Panel14.MouseClick
        FormKategori.Show()
    End Sub

    Private Sub Label2_MouseClick(sender As Object, e As MouseEventArgs) Handles Label2.MouseClick
        InputNilaiSPK.Show()
    End Sub

   
    Private Sub Panel1_MouseClick(sender As Object, e As MouseEventArgs) Handles Panel1.MouseClick
        InputNilaiSPK.Show()
    End Sub
End Class
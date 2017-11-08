Public Class Form1
    Dim cLeft As Integer = 1
    Dim copyT As TextBox
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        AddNewTextBox()
    End Sub

    Public Function AddNewTextBox() As System.Windows.Forms.TextBox
        Dim txt As New System.Windows.Forms.TextBox()
        Me.Controls.Add(txt)
        txt.Top = cLeft * 25
        txt.Left = 200
        txt.Text = "TextBox " & Me.cLeft.ToString
        txt.Name = "txt" & Me.cLeft.ToString
        cLeft = cLeft + 1
        copyT = txt
        Return txt
    End Function
     
   
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        For i As Integer = 1 To cLeft
            Dim obj As Object = Me.Controls.Find("txt" + i.ToString, True).FirstOrDefault

            Try
                MsgBox(obj.Text.ToString + i.ToString)
            Catch ex As Exception

            End Try

        Next




        
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ' Display the current text.
        Dim txt As TextBox = DirectCast(sender, TextBox)
        MsgBox(txt.Name & ": [" & txt.Text & "]")
    End Sub
 

End Class
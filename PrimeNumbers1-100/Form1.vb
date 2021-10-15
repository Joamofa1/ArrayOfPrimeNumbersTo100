Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim checkprime = 1, i, primenumber As Integer
        For primenumber = 1 To 100
            For i = 2 To primenumber - 1
                If primenumber Mod i = 0 Then
                    checkprime = 0 'The number is not a prime
                    Exit For
                Else
                    checkprime = 1 'its a prime number
                End If
            Next
            If checkprime = 1 Then
                ListBox1.Items.Add(primenumber)
            End If
        Next
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged

    End Sub
End Class

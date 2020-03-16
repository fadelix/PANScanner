Public Class FormAbout
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked

        ' Specify that the link was visited.
        Me.LinkLabel1.LinkVisited = True

        ' Navigate to a URL.
        System.Diagnostics.Process.Start("https://ngoprex.com")
    End Sub


End Class
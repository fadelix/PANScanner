Imports System.IO
Imports System.Text.RegularExpressions

Public Class Form1
    Public Shared scanner As Integer = 0

    Private Sub btninfo_Click(sender As Object, e As EventArgs) Handles btninfo.Click
        FormAbout.Show()
    End Sub



    Private Sub btnscan_Click(sender As Object, e As EventArgs) Handles btnscan.Click
        'On Error Resume Next


        btnscan.Text = "Searching..."
        lblresult.Text = "Searching..."
        Me.Cursor = Cursors.WaitCursor
        Application.DoEvents()
        cari(spath.Text)
        btnscan.Text = "Scan Now"
        Me.Cursor = Cursors.Default
        lblresult.Text = ListBox1.Items.Count.ToString() & " files Scanned, " & scanner & " Credit card pattern found"




    End Sub

    Sub cari(ByVal pathdir As String)
        On Error Resume Next
        Dim stack As New System.Collections.Generic.Stack(Of System.IO.DirectoryInfo)

        stack.Push(New System.IO.DirectoryInfo(pathdir))

        While stack.Count > 0
            Dim di As System.IO.DirectoryInfo = stack.Pop
            'process files in current directory as you need.
            For Each f As System.IO.FileInfo In di.GetFiles
                Dim ext As String = LCase(Mid(f.FullName, Len(f.FullName) - 2, 3))
                If ext = "dll" Or ext = "sys" Or ext = "com" Or ext = "exe" Or ext = "jpg" Or ext = "png" Or ext = "gif" Or ext = "bmp" Then
                    Me.ListBox1.Items.Add(f.FullName & "- File Not Included to scan")
                Else
                    Dim readText As String = File.ReadAllText(f.FullName)
                    scan(f.FullName, readText)
                    lblresult.Text = "Scanning " & f.FullName
                End If

            Next

            For Each subDi As System.IO.DirectoryInfo In di.GetDirectories
                stack.Push(subDi)
            Next


        End While
        ListBox1.Items(0).backgroundcolor = Color.Green
    End Sub

    Sub scan(filepath, filesource)
        Dim regex As Regex = New Regex("([0-9]{4}[\s-]?){3}([0-9]{4})")
        'Dim source As String = Replace(Replace(filesource, "-", ""), " ", "")
        Dim match As Match = regex.Match(filesource)
        'MsgBox(filepath)
        'MsgBox(filesource)
        If match.Success Then
            scanner = scanner + 1
            Me.ListBox1.Items.Add(filepath & "- Found Credit card Number")
        Else
            Me.ListBox1.Items.Add(filepath & "- File clean")
        End If

    End Sub

    Private Sub btnsearch_Click(sender As Object, e As EventArgs) Handles btnsearch.Click
        If (FolderBrowserDialog1.ShowDialog() = DialogResult.OK) Then
            spath.Text = FolderBrowserDialog1.SelectedPath
        End If
    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        If SaveFileDialog1.ShowDialog() = DialogResult.OK Then
            Dim sb As New System.Text.StringBuilder()

            For Each o As Object In ListBox1.Items
                sb.AppendLine(o)
            Next

            System.IO.File.WriteAllText(SaveFileDialog1.FileName, sb.ToString())
            MsgBox("file have been saved as " & SaveFileDialog1.FileName)
        End If
    End Sub

    Private Sub btnhelp_Click(sender As Object, e As EventArgs) Handles btnhelp.Click
        Try
            System.Diagnostics.Process.Start("Help.pdf")
        Catch ex As Exception
            MsgBox("File Help.pdf doesn't exist in current directory" & vbCrLf & ex.Message)
        End Try
        Exit Sub
    End Sub
End Class

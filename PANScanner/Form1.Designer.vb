<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.spath = New System.Windows.Forms.Label()
        Me.btnsearch = New System.Windows.Forms.Button()
        Me.btninfo = New System.Windows.Forms.Button()
        Me.btnscan = New System.Windows.Forms.Button()
        Me.lblresult = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.btnhelp = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.spath)
        Me.GroupBox1.Controls.Add(Me.btnsearch)
        Me.GroupBox1.Controls.Add(Me.btninfo)
        Me.GroupBox1.Controls.Add(Me.btnscan)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(805, 58)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Directory to scan"
        '
        'spath
        '
        Me.spath.AutoSize = True
        Me.spath.Location = New System.Drawing.Point(100, 24)
        Me.spath.Name = "spath"
        Me.spath.Size = New System.Drawing.Size(0, 13)
        Me.spath.TabIndex = 5
        '
        'btnsearch
        '
        Me.btnsearch.Location = New System.Drawing.Point(19, 20)
        Me.btnsearch.Name = "btnsearch"
        Me.btnsearch.Size = New System.Drawing.Size(75, 23)
        Me.btnsearch.TabIndex = 4
        Me.btnsearch.Text = "Browse"
        Me.btnsearch.UseVisualStyleBackColor = True
        '
        'btninfo
        '
        Me.btninfo.Location = New System.Drawing.Point(720, 19)
        Me.btninfo.Name = "btninfo"
        Me.btninfo.Size = New System.Drawing.Size(70, 23)
        Me.btninfo.TabIndex = 2
        Me.btninfo.Text = "About"
        Me.btninfo.UseVisualStyleBackColor = True
        '
        'btnscan
        '
        Me.btnscan.Location = New System.Drawing.Point(639, 19)
        Me.btnscan.Name = "btnscan"
        Me.btnscan.Size = New System.Drawing.Size(75, 23)
        Me.btnscan.TabIndex = 1
        Me.btnscan.Text = "Scan Now"
        Me.btnscan.UseVisualStyleBackColor = True
        '
        'lblresult
        '
        Me.lblresult.AutoSize = True
        Me.lblresult.Location = New System.Drawing.Point(12, 464)
        Me.lblresult.Name = "lblresult"
        Me.lblresult.Size = New System.Drawing.Size(49, 13)
        Me.lblresult.TabIndex = 3
        Me.lblresult.Text = "Waiting.."
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(13, 80)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(804, 368)
        Me.ListBox1.TabIndex = 4
        '
        'btnsave
        '
        Me.btnsave.Location = New System.Drawing.Point(742, 464)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(75, 23)
        Me.btnsave.TabIndex = 5
        Me.btnsave.Text = "Save result"
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.Filter = "Text File | *.txt"
        '
        'btnhelp
        '
        Me.btnhelp.Location = New System.Drawing.Point(651, 464)
        Me.btnhelp.Name = "btnhelp"
        Me.btnhelp.Size = New System.Drawing.Size(75, 23)
        Me.btnhelp.TabIndex = 6
        Me.btnhelp.Text = "Help"
        Me.btnhelp.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(829, 495)
        Me.Controls.Add(Me.btnhelp)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblresult)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PAN Scanner - http://ngoprex.com"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btninfo As Button
    Friend WithEvents btnscan As Button
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents lblresult As Label
    Friend WithEvents spath As Label
    Friend WithEvents btnsearch As Button
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents btnsave As Button
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents btnhelp As Button
End Class

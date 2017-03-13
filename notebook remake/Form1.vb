Imports system.io

Public Class frmNotebook1
    Inherits Windows.Forms.Form
    Private strFileName As String
    Private Sub tsbSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbSave.Click
        ' rtbMainText.SaveFile(My.Resources.maintext_rtf)
    End Sub

    Private Sub tsbCut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbCut.Click
        rtbMainText.Cut()
    End Sub

    Private Sub tsbCopy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbCopy.Click
        rtbMainText.Copy()
    End Sub

    Private Sub tsbPaste_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbPaste.Click
        rtbMainText.Paste()
    End Sub

    Private Sub tsbLeft_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbLeft.Click
        Me.rtbMainText.SelectionAlignment = HorizontalAlignment.Left
    End Sub

    Private Sub tsbRight_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbRight.Click
        Me.rtbMainText.SelectionAlignment = HorizontalAlignment.Right
    End Sub

    Private Sub tsbMiddle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbMiddle.Click
        Me.rtbMainText.SelectionAlignment = HorizontalAlignment.Center
    End Sub

    Private Sub tsbJustify_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbJustify.Click
        Dim rtfjustify As Object
        Me.rtbMainText.SelectionAlignment = rtfjustify
    End Sub

    Private Sub RedoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RedoToolStripMenuItem.Click
        Me.rtbMainText.Redo()
    End Sub

    Private Sub UndoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UndoToolStripMenuItem.Click
        Me.rtbMainText.Undo()
    End Sub

    Private Sub tsbBullet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbBullet.Click
        If (Me.rtbMainText.SelectionBullet = True) = False Then
            Me.rtbMainText.SelectionBullet = True
        Else
            Me.rtbMainText.SelectionBullet = False
        End If
    End Sub

    Private Sub tsbFont_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbFont.Click


        If fdFont.ShowDialog = Windows.Forms.DialogResult.OK Then
            rtbMainText.SelectionFont = fdFont.Font
            rtbMainText.Focus()
            rtbMainText.Font = fdFont.Font
        End If
    End Sub

    Private Sub tsbFontColor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbFontColor.Click
        If cdColor.ShowDialog = Windows.Forms.DialogResult.OK Then
            rtbMainText.SelectionColor = cdColor.Color
            rtbMainText.Focus()
        End If
    End Sub

    Private Sub tsbOpen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbOpen.Click

        'use with to refer to object code without writing its name in every line
        With ofdFileDialog
            .Filter = "Text Files (.txt)|*.txt|Web Pages (.html)|*.html|Web Pages (.htm)| *.htm |All Files (*.*)|*.*"

            'index of selected file
            .FilterIndex = 1

            'title of file dialog
            .Title = "Russell Notebook"

            'clear FileName box for every Dialog load
            ofdFileDialog.FileName = ""

            'showing the dialog box
            If ofdFileDialog.ShowDialog = Windows.Forms.DialogResult.OK Then
                Dim alltext As String
                Try
                    'save the filename
                    strFileName = ofdFileDialog.FileName

                    'read the contents of the file
                    alltext = My.Computer.FileSystem.ReadAllText(strFileName)

                    'display the file contents in the page
                    rtbMainText.Text = alltext

                Catch ex As Exception

                End Try
            End If
        End With


    End Sub

    Private Sub tsbSaveAs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbSaveAs.Click
        With sfdSaveFile
            .DefaultExt = "txt"
            .FileName = strFileName
            .Filter = "Text Files (.txt)|*.txt|Web Pages (.html)|*.html|Web Pages (.htm)| *.htm |All Files (*.*)|*.*"
            .FilterIndex = 1
            .OverwritePrompt = True
        End With

        If sfdSaveFile.ShowDialog = Windows.Forms.DialogResult.OK Then
            Try
                'save the filename
                strFileName = sfdSaveFile.FileName

                Dim filepath As String

                'open or create the file
                filepath = System.IO.Path.Combine(My.Computer.FileSystem.SpecialDirectories.MyDocuments, strFileName)

                'replace the contents of the file
                My.Computer.FileSystem.WriteAllText(filepath, rtbMainText.Text, False)
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub tsbNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbNew.Click
        'if no text is in the text box then clear it for new document
        If rtbMainText.Text = "" Then
            rtbMainText.ResetText()
            'clear file name in save dialog to allow for saving in new document
            sfdSaveFile.FileName = ""
        Else
            sfdSaveFile.FileName = ""
            With sfdSaveFile
                .DefaultExt = "txt"
                .FileName = strFileName
                .Filter = "Text Files (.txt)|*.txt|Web Pages (.html)|*.html|Web Pages (.htm)| *.htm |All Files (*.*)|*.*"
                .FilterIndex = 1
                .OverwritePrompt = True
            End With

            If sfdSaveFile.ShowDialog = Windows.Forms.DialogResult.OK Then
                Try
                    'save the filename
                    strFileName = sfdSaveFile.FileName

                    Dim filepath As String

                    'open or create the file
                    filepath = System.IO.Path.Combine(My.Computer.FileSystem.SpecialDirectories.MyDocuments, strFileName)

                    'replace the contents of the file
                    My.Computer.FileSystem.WriteAllText(filepath, rtbMainText.Text, False)
                    rtbMainText.ResetText()
                    sfdSaveFile.FileName = ""
                Catch ex As Exception

                End Try
            End If
        End If

    End Sub

    Private Sub tsmScreenSaver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmScreenSaver.Click
        tsmShow.Visible = True
        tsmHide.Visible = False
        Dim counter As Integer
        'fading form code
        For counter = 100 To 5 Step -5
            Me.Opacity = counter / 100
            Me.Refresh()
            Threading.Thread.Sleep(50)
        Next counter

        My.Application.ApplicationContext.MainForm.Hide()

        Call ScreenSave1r.gf_StartScreenSaver()

    End Sub

    Private Sub tsmHide_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmHide.Click
        
        My.Application.ApplicationContext.MainForm.Hide()
        tsmHide.Visible = False
        If tsmShow.Visible = False Then
            tsmShow.Visible = True
        Else : tsmShow.Visible = True
            
        End If

    End Sub

    Private Sub tsmShow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmShow.Click
        Me.Opacity = 0.99


        My.Application.ApplicationContext.MainForm.Show()
        My.Application.ApplicationContext.MainForm.WindowState = FormWindowState.Normal
        Russell.Hide()
        tsmShow.Visible = False
        If tsmHide.Visible = False Then
            tsmHide.Visible = True
        
        Else : tsmHide.Visible = True
            
        End If
    End Sub

    Private Sub tsmClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmClose.Click
        My.Application.ApplicationContext.MainForm.Close()
    End Sub

    Private Sub frmNotebook1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tsmShow.Visible = False
        tsmHide.Visible = True
        Me.Opacity = 0.98
        Russell.Enabled = False
        Russell.Hide()
    End Sub

    Private Sub niNotebook_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles niNotebook.MouseDoubleClick
        niNotebook.ShowBalloonTip(9000)
    End Sub

    Private Sub AboutUs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutUs.Click
        frmAbout.Show()
    End Sub
End Class


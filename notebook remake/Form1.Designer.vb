<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNotebook1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmNotebook1))
        Me.TsNotebookMain1 = New System.Windows.Forms.ToolStrip
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator
        Me.tsbCut = New System.Windows.Forms.ToolStripButton
        Me.tsbCopy = New System.Windows.Forms.ToolStripButton
        Me.tsbPaste = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.tsbFont = New System.Windows.Forms.ToolStripButton
        Me.tsbFontColor = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.tsbLeft = New System.Windows.Forms.ToolStripButton
        Me.tsbRight = New System.Windows.Forms.ToolStripButton
        Me.tsbMiddle = New System.Windows.Forms.ToolStripButton
        Me.tsbJustify = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.tsbOpen = New System.Windows.Forms.ToolStripButton
        Me.tsbSave = New System.Windows.Forms.ToolStripButton
        Me.tsbSaveAs = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator
        Me.tsbBullet = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator
        Me.tsbNew = New System.Windows.Forms.ToolStripButton
        Me.stsNotebook1 = New System.Windows.Forms.StatusStrip
        Me.tslNotebook1 = New System.Windows.Forms.ToolStripStatusLabel
        Me.tslNotebook2 = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolStripDropDownButton1 = New System.Windows.Forms.ToolStripDropDownButton
        Me.AboutUs = New System.Windows.Forms.ToolStripMenuItem
        Me.UndoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.RedoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.fdFont = New System.Windows.Forms.FontDialog
        Me.cdColor = New System.Windows.Forms.ColorDialog
        Me.ofdFileDialog = New System.Windows.Forms.OpenFileDialog
        Me.sfdSaveFile = New System.Windows.Forms.SaveFileDialog
        Me.rtbMainText = New System.Windows.Forms.RichTextBox
        Me.niNotebook = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.cmsMenu1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.tsmScreenSaver = New System.Windows.Forms.ToolStripMenuItem
        Me.tsmShow = New System.Windows.Forms.ToolStripMenuItem
        Me.tsmHide = New System.Windows.Forms.ToolStripMenuItem
        Me.tsmClose = New System.Windows.Forms.ToolStripMenuItem
        Me.TsNotebookMain1.SuspendLayout()
        Me.stsNotebook1.SuspendLayout()
        Me.cmsMenu1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TsNotebookMain1
        '
        Me.TsNotebookMain1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TsNotebookMain1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator5, Me.tsbCut, Me.tsbCopy, Me.tsbPaste, Me.ToolStripSeparator2, Me.tsbFont, Me.tsbFontColor, Me.ToolStripSeparator1, Me.tsbLeft, Me.tsbRight, Me.tsbMiddle, Me.tsbJustify, Me.ToolStripSeparator3, Me.tsbOpen, Me.tsbSave, Me.tsbSaveAs, Me.ToolStripSeparator4, Me.tsbBullet, Me.ToolStripSeparator6, Me.tsbNew})
        Me.TsNotebookMain1.Location = New System.Drawing.Point(0, 0)
        Me.TsNotebookMain1.Name = "TsNotebookMain1"
        Me.TsNotebookMain1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.TsNotebookMain1.Size = New System.Drawing.Size(1028, 39)
        Me.TsNotebookMain1.TabIndex = 1
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 39)
        '
        'tsbCut
        '
        Me.tsbCut.Image = Global.notebook_remake.My.Resources.Resources.ico_alpha_ColumnCheck_32x32
        Me.tsbCut.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbCut.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbCut.Name = "tsbCut"
        Me.tsbCut.Size = New System.Drawing.Size(60, 36)
        Me.tsbCut.Text = "Cut"
        '
        'tsbCopy
        '
        Me.tsbCopy.Image = Global.notebook_remake.My.Resources.Resources.ico_alpha_5_32x32
        Me.tsbCopy.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbCopy.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbCopy.Name = "tsbCopy"
        Me.tsbCopy.Size = New System.Drawing.Size(68, 36)
        Me.tsbCopy.Text = "Copy"
        '
        'tsbPaste
        '
        Me.tsbPaste.Image = Global.notebook_remake.My.Resources.Resources.ico_alpha_CopyFile_32x32
        Me.tsbPaste.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbPaste.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbPaste.Name = "tsbPaste"
        Me.tsbPaste.Size = New System.Drawing.Size(70, 36)
        Me.tsbPaste.Text = "Paste"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 39)
        '
        'tsbFont
        '
        Me.tsbFont.Image = Global.notebook_remake.My.Resources.Resources.f1
        Me.tsbFont.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbFont.ImageTransparentColor = System.Drawing.Color.Transparent
        Me.tsbFont.Name = "tsbFont"
        Me.tsbFont.Size = New System.Drawing.Size(65, 36)
        Me.tsbFont.Text = "Font"
        '
        'tsbFontColor
        '
        Me.tsbFontColor.Image = Global.notebook_remake.My.Resources.Resources.c1
        Me.tsbFontColor.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbFontColor.ImageTransparentColor = System.Drawing.Color.Transparent
        Me.tsbFontColor.Name = "tsbFontColor"
        Me.tsbFontColor.Size = New System.Drawing.Size(93, 36)
        Me.tsbFontColor.Text = "Font Color"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 39)
        '
        'tsbLeft
        '
        Me.tsbLeft.Image = Global.notebook_remake.My.Resources.Resources.l
        Me.tsbLeft.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbLeft.ImageTransparentColor = System.Drawing.Color.Transparent
        Me.tsbLeft.Name = "tsbLeft"
        Me.tsbLeft.Size = New System.Drawing.Size(62, 36)
        Me.tsbLeft.Text = "Left"
        '
        'tsbRight
        '
        Me.tsbRight.Image = Global.notebook_remake.My.Resources.Resources.r
        Me.tsbRight.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbRight.ImageTransparentColor = System.Drawing.Color.Transparent
        Me.tsbRight.Name = "tsbRight"
        Me.tsbRight.Size = New System.Drawing.Size(68, 36)
        Me.tsbRight.Text = "Right"
        '
        'tsbMiddle
        '
        Me.tsbMiddle.Image = Global.notebook_remake.My.Resources.Resources.m
        Me.tsbMiddle.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbMiddle.ImageTransparentColor = System.Drawing.Color.Transparent
        Me.tsbMiddle.Name = "tsbMiddle"
        Me.tsbMiddle.Size = New System.Drawing.Size(73, 36)
        Me.tsbMiddle.Text = "Middle"
        '
        'tsbJustify
        '
        Me.tsbJustify.Image = Global.notebook_remake.My.Resources.Resources.j
        Me.tsbJustify.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbJustify.ImageTransparentColor = System.Drawing.Color.Transparent
        Me.tsbJustify.Name = "tsbJustify"
        Me.tsbJustify.Size = New System.Drawing.Size(75, 36)
        Me.tsbJustify.Text = "Justify"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 39)
        '
        'tsbOpen
        '
        Me.tsbOpen.Image = Global.notebook_remake.My.Resources.Resources.ico_alpha_Defrag_32x32
        Me.tsbOpen.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbOpen.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbOpen.Name = "tsbOpen"
        Me.tsbOpen.Size = New System.Drawing.Size(69, 36)
        Me.tsbOpen.Text = "Open"
        '
        'tsbSave
        '
        Me.tsbSave.Image = Global.notebook_remake.My.Resources.Resources.ico_alpha_CopyUserSettings_32x32
        Me.tsbSave.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbSave.Name = "tsbSave"
        Me.tsbSave.Size = New System.Drawing.Size(67, 36)
        Me.tsbSave.Text = "Save"
        '
        'tsbSaveAs
        '
        Me.tsbSaveAs.Image = Global.notebook_remake.My.Resources.Resources.ico_alpha_DriveDefrag_32x32
        Me.tsbSaveAs.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbSaveAs.ImageTransparentColor = System.Drawing.Color.Transparent
        Me.tsbSaveAs.Name = "tsbSaveAs"
        Me.tsbSaveAs.Size = New System.Drawing.Size(82, 36)
        Me.tsbSaveAs.Text = "Save As"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 39)
        '
        'tsbBullet
        '
        Me.tsbBullet.Image = Global.notebook_remake.My.Resources.Resources.ico_alpha_Desktop2_24x24
        Me.tsbBullet.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbBullet.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbBullet.Name = "tsbBullet"
        Me.tsbBullet.Size = New System.Drawing.Size(61, 36)
        Me.tsbBullet.Text = "Bullet"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 39)
        '
        'tsbNew
        '
        Me.tsbNew.Image = Global.notebook_remake.My.Resources.Resources.ico_alpha_Document_16x16
        Me.tsbNew.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbNew.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbNew.Name = "tsbNew"
        Me.tsbNew.Size = New System.Drawing.Size(48, 36)
        Me.tsbNew.Text = "New"
        '
        'stsNotebook1
        '
        Me.stsNotebook1.AutoSize = False
        Me.stsNotebook1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stsNotebook1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tslNotebook1, Me.tslNotebook2, Me.ToolStripDropDownButton1})
        Me.stsNotebook1.Location = New System.Drawing.Point(0, 471)
        Me.stsNotebook1.Name = "stsNotebook1"
        Me.stsNotebook1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.stsNotebook1.Size = New System.Drawing.Size(1028, 38)
        Me.stsNotebook1.TabIndex = 2
        Me.stsNotebook1.Text = "Russell Notebook"
        '
        'tslNotebook1
        '
        Me.tslNotebook1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.tslNotebook1.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Top
        Me.tslNotebook1.BorderStyle = System.Windows.Forms.Border3DStyle.Sunken
        Me.tslNotebook1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tslNotebook1.Image = Global.notebook_remake.My.Resources.Resources.ico_alpha_ColumnCheck_32x32
        Me.tslNotebook1.ImageTransparentColor = System.Drawing.Color.Transparent
        Me.tslNotebook1.Name = "tslNotebook1"
        Me.tslNotebook1.Size = New System.Drawing.Size(937, 33)
        Me.tslNotebook1.Spring = True
        Me.tslNotebook1.Text = "Russell Notebook"
        '
        'tslNotebook2
        '
        Me.tslNotebook2.Name = "tslNotebook2"
        Me.tslNotebook2.Size = New System.Drawing.Size(0, 33)
        '
        'ToolStripDropDownButton1
        '
        Me.ToolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripDropDownButton1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutUs, Me.UndoToolStripMenuItem, Me.RedoToolStripMenuItem})
        Me.ToolStripDropDownButton1.Image = Global.notebook_remake.My.Resources.Resources.ico_alpha_DLLFile_32x32
        Me.ToolStripDropDownButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownButton1.Name = "ToolStripDropDownButton1"
        Me.ToolStripDropDownButton1.Size = New System.Drawing.Size(45, 36)
        Me.ToolStripDropDownButton1.Text = "ToolStripDropDownButton1"
        '
        'AboutUs
        '
        Me.AboutUs.Image = Global.notebook_remake.My.Resources.Resources.ico_alpha_CompSpeak_32x32
        Me.AboutUs.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.AboutUs.Name = "AboutUs"
        Me.AboutUs.Size = New System.Drawing.Size(135, 38)
        Me.AboutUs.Text = "About"
        '
        'UndoToolStripMenuItem
        '
        Me.UndoToolStripMenuItem.Image = Global.notebook_remake.My.Resources.Resources.ico_alpha_ErrorNotify_32x32
        Me.UndoToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.UndoToolStripMenuItem.Name = "UndoToolStripMenuItem"
        Me.UndoToolStripMenuItem.Size = New System.Drawing.Size(135, 38)
        Me.UndoToolStripMenuItem.Text = "Undo"
        '
        'RedoToolStripMenuItem
        '
        Me.RedoToolStripMenuItem.Image = Global.notebook_remake.My.Resources.Resources.ico_alpha_Cleaning_24x24
        Me.RedoToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.RedoToolStripMenuItem.Name = "RedoToolStripMenuItem"
        Me.RedoToolStripMenuItem.Size = New System.Drawing.Size(135, 38)
        Me.RedoToolStripMenuItem.Text = "Redo"
        '
        'sfdSaveFile
        '
        Me.sfdSaveFile.CreatePrompt = True
        '
        'rtbMainText
        '
        Me.rtbMainText.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rtbMainText.Location = New System.Drawing.Point(0, 39)
        Me.rtbMainText.Name = "rtbMainText"
        Me.rtbMainText.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical
        Me.rtbMainText.Size = New System.Drawing.Size(1028, 432)
        Me.rtbMainText.TabIndex = 3
        Me.rtbMainText.Text = ""
        '
        'niNotebook
        '
        Me.niNotebook.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.niNotebook.BalloonTipText = "Russell's Notebook"
        Me.niNotebook.BalloonTipTitle = "By Me!!!!!"
        Me.niNotebook.ContextMenuStrip = Me.cmsMenu1
        Me.niNotebook.Icon = CType(resources.GetObject("niNotebook.Icon"), System.Drawing.Icon)
        Me.niNotebook.Text = "Russell's Notebook"
        Me.niNotebook.Visible = True
        '
        'cmsMenu1
        '
        Me.cmsMenu1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmScreenSaver, Me.tsmShow, Me.tsmHide, Me.tsmClose})
        Me.cmsMenu1.Name = "cmsMenu1"
        Me.cmsMenu1.Size = New System.Drawing.Size(206, 156)
        Me.cmsMenu1.Text = "Options"
        '
        'tsmScreenSaver
        '
        Me.tsmScreenSaver.Image = Global.notebook_remake.My.Resources.Resources.ico_alpha_Effects_32x32
        Me.tsmScreenSaver.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsmScreenSaver.Name = "tsmScreenSaver"
        Me.tsmScreenSaver.Size = New System.Drawing.Size(205, 38)
        Me.tsmScreenSaver.Text = "Activate ScreenSaver"
        '
        'tsmShow
        '
        Me.tsmShow.Image = Global.notebook_remake.My.Resources.Resources.ico_alpha_Desktop_32x32
        Me.tsmShow.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsmShow.Name = "tsmShow"
        Me.tsmShow.Size = New System.Drawing.Size(205, 38)
        Me.tsmShow.Text = "Show"
        '
        'tsmHide
        '
        Me.tsmHide.Image = Global.notebook_remake.My.Resources.Resources.ico_alpha_ActiveWndTracking_32x32
        Me.tsmHide.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsmHide.Name = "tsmHide"
        Me.tsmHide.Size = New System.Drawing.Size(205, 38)
        Me.tsmHide.Text = "Hide"
        '
        'tsmClose
        '
        Me.tsmClose.Image = Global.notebook_remake.My.Resources.Resources.ico_alpha_Error_32x32
        Me.tsmClose.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsmClose.Name = "tsmClose"
        Me.tsmClose.Size = New System.Drawing.Size(205, 38)
        Me.tsmClose.Text = "Close "
        '
        'frmNotebook1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1028, 509)
        Me.Controls.Add(Me.rtbMainText)
        Me.Controls.Add(Me.stsNotebook1)
        Me.Controls.Add(Me.TsNotebookMain1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmNotebook1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Russell's Notebook"
        Me.TsNotebookMain1.ResumeLayout(False)
        Me.TsNotebookMain1.PerformLayout()
        Me.stsNotebook1.ResumeLayout(False)
        Me.stsNotebook1.PerformLayout()
        Me.cmsMenu1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TsNotebookMain1 As System.Windows.Forms.ToolStrip
    Friend WithEvents stsNotebook1 As System.Windows.Forms.StatusStrip
    Friend WithEvents tslNotebook1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents tslNotebook2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents tsbCut As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbCopy As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbPaste As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbFont As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbFontColor As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbLeft As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbRight As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbMiddle As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbJustify As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbSave As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbSaveAs As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbOpen As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbBullet As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripDropDownButton1 As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents AboutUs As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UndoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RedoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents fdFont As System.Windows.Forms.FontDialog
    Friend WithEvents cdColor As System.Windows.Forms.ColorDialog
    Friend WithEvents ofdFileDialog As System.Windows.Forms.OpenFileDialog
    Friend WithEvents sfdSaveFile As System.Windows.Forms.SaveFileDialog
    Friend WithEvents rtbMainText As System.Windows.Forms.RichTextBox
    Friend WithEvents tsbNew As System.Windows.Forms.ToolStripButton
    Friend WithEvents niNotebook As System.Windows.Forms.NotifyIcon
    Friend WithEvents cmsMenu1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents tsmScreenSaver As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmClose As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmShow As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmHide As System.Windows.Forms.ToolStripMenuItem

End Class

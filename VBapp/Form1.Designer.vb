﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
   Inherits System.Windows.Forms.Form

   'Form overrides dispose to clean up the component list.
   <System.Diagnostics.DebuggerNonUserCode()> _
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
   <System.Diagnostics.DebuggerStepThrough()> _
   Private Sub InitializeComponent()
      Me.components = New System.ComponentModel.Container()
      Me.cbPriority = New System.Windows.Forms.ComboBox()
      Me.lblPriority = New System.Windows.Forms.Label()
      Me.tabconMain = New System.Windows.Forms.TabControl()
      Me.TabPage1 = New System.Windows.Forms.TabPage()
      Me.lblOutput = New System.Windows.Forms.Label()
      Me.Label6 = New System.Windows.Forms.Label()
      Me.btnGen = New System.Windows.Forms.Button()
      Me.Label4 = New System.Windows.Forms.Label()
      Me.textPara = New System.Windows.Forms.TextBox()
      Me.Label3 = New System.Windows.Forms.Label()
      Me.textProgram = New System.Windows.Forms.TextBox()
      Me.lblAffinity = New System.Windows.Forms.Label()
      Me.textAffinity = New System.Windows.Forms.MaskedTextBox()
      Me.GroupBox1 = New System.Windows.Forms.GroupBox()
      Me.checkWait = New System.Windows.Forms.CheckBox()
      Me.checkI = New System.Windows.Forms.CheckBox()
      Me.checkB = New System.Windows.Forms.CheckBox()
      Me.Label2 = New System.Windows.Forms.Label()
      Me.cbWindow = New System.Windows.Forms.ComboBox()
      Me.Label1 = New System.Windows.Forms.Label()
      Me.textbPath = New System.Windows.Forms.TextBox()
      Me.lblTitle = New System.Windows.Forms.Label()
      Me.textbTitle = New System.Windows.Forms.TextBox()
      Me.TabPage2 = New System.Windows.Forms.TabPage()
      Me.TabPage3 = New System.Windows.Forms.TabPage()
      Me.Label5 = New System.Windows.Forms.Label()
      Me.tipTitle = New System.Windows.Forms.ToolTip(Me.components)
      Me.tipPath = New System.Windows.Forms.ToolTip(Me.components)
      Me.tipB = New System.Windows.Forms.ToolTip(Me.components)
      Me.tipI = New System.Windows.Forms.ToolTip(Me.components)
      Me.tipPriority = New System.Windows.Forms.ToolTip(Me.components)
      Me.tipWait = New System.Windows.Forms.ToolTip(Me.components)
      Me.tipAffinity = New System.Windows.Forms.ToolTip(Me.components)
      Me.tipWindow = New System.Windows.Forms.ToolTip(Me.components)
      Me.tabconMain.SuspendLayout()
      Me.TabPage1.SuspendLayout()
      Me.GroupBox1.SuspendLayout()
      Me.TabPage3.SuspendLayout()
      Me.SuspendLayout()
      '
      'cbPriority
      '
      Me.cbPriority.DisplayMember = "Normal"
      Me.cbPriority.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
      Me.cbPriority.FormattingEnabled = True
      Me.cbPriority.Items.AddRange(New Object() {"Idle", "Below Normal", "Normal", "Above Normal", "High", "Realtime"})
      Me.cbPriority.Location = New System.Drawing.Point(10, 100)
      Me.cbPriority.Name = "cbPriority"
      Me.cbPriority.Size = New System.Drawing.Size(121, 21)
      Me.cbPriority.TabIndex = 0
      Me.tipPriority.SetToolTip(Me.cbPriority, "Start application in the specified priority class.")
      '
      'lblPriority
      '
      Me.lblPriority.AutoSize = True
      Me.lblPriority.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblPriority.Location = New System.Drawing.Point(6, 75)
      Me.lblPriority.Name = "lblPriority"
      Me.lblPriority.Size = New System.Drawing.Size(80, 22)
      Me.lblPriority.TabIndex = 1
      Me.lblPriority.Text = "Priority:"
      '
      'tabconMain
      '
      Me.tabconMain.Controls.Add(Me.TabPage1)
      Me.tabconMain.Controls.Add(Me.TabPage2)
      Me.tabconMain.Controls.Add(Me.TabPage3)
      Me.tabconMain.Location = New System.Drawing.Point(12, 12)
      Me.tabconMain.Name = "tabconMain"
      Me.tabconMain.SelectedIndex = 0
      Me.tabconMain.Size = New System.Drawing.Size(459, 419)
      Me.tabconMain.TabIndex = 2
      '
      'TabPage1
      '
      Me.TabPage1.Controls.Add(Me.lblOutput)
      Me.TabPage1.Controls.Add(Me.Label6)
      Me.TabPage1.Controls.Add(Me.btnGen)
      Me.TabPage1.Controls.Add(Me.Label4)
      Me.TabPage1.Controls.Add(Me.textPara)
      Me.TabPage1.Controls.Add(Me.Label3)
      Me.TabPage1.Controls.Add(Me.textProgram)
      Me.TabPage1.Controls.Add(Me.lblAffinity)
      Me.TabPage1.Controls.Add(Me.textAffinity)
      Me.TabPage1.Controls.Add(Me.GroupBox1)
      Me.TabPage1.Controls.Add(Me.Label2)
      Me.TabPage1.Controls.Add(Me.cbWindow)
      Me.TabPage1.Controls.Add(Me.Label1)
      Me.TabPage1.Controls.Add(Me.textbPath)
      Me.TabPage1.Controls.Add(Me.lblTitle)
      Me.TabPage1.Controls.Add(Me.textbTitle)
      Me.TabPage1.Controls.Add(Me.cbPriority)
      Me.TabPage1.Controls.Add(Me.lblPriority)
      Me.TabPage1.Location = New System.Drawing.Point(4, 22)
      Me.TabPage1.Name = "TabPage1"
      Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
      Me.TabPage1.Size = New System.Drawing.Size(451, 393)
      Me.TabPage1.TabIndex = 0
      Me.TabPage1.Text = "Generate"
      Me.TabPage1.UseVisualStyleBackColor = True
      '
      'lblOutput
      '
      Me.lblOutput.AutoSize = True
      Me.lblOutput.Location = New System.Drawing.Point(62, 377)
      Me.lblOutput.Name = "lblOutput"
      Me.lblOutput.Size = New System.Drawing.Size(0, 13)
      Me.lblOutput.TabIndex = 19
      '
      'Label6
      '
      Me.Label6.AutoSize = True
      Me.Label6.Location = New System.Drawing.Point(10, 377)
      Me.Label6.Name = "Label6"
      Me.Label6.Size = New System.Drawing.Size(45, 13)
      Me.Label6.TabIndex = 18
      Me.Label6.Text = "Output: "
      '
      'btnGen
      '
      Me.btnGen.Location = New System.Drawing.Point(273, 281)
      Me.btnGen.Name = "btnGen"
      Me.btnGen.Size = New System.Drawing.Size(75, 23)
      Me.btnGen.TabIndex = 17
      Me.btnGen.Text = "Generate"
      Me.btnGen.UseVisualStyleBackColor = True
      '
      'Label4
      '
      Me.Label4.AutoSize = True
      Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label4.Location = New System.Drawing.Point(6, 320)
      Me.Label4.Name = "Label4"
      Me.Label4.Size = New System.Drawing.Size(118, 22)
      Me.Label4.TabIndex = 16
      Me.Label4.Text = "Parameters:"
      '
      'textPara
      '
      Me.textPara.Location = New System.Drawing.Point(10, 345)
      Me.textPara.MaxLength = 256
      Me.textPara.Name = "textPara"
      Me.textPara.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
      Me.textPara.Size = New System.Drawing.Size(195, 20)
      Me.textPara.TabIndex = 15
      '
      'Label3
      '
      Me.Label3.AutoSize = True
      Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label3.Location = New System.Drawing.Point(6, 259)
      Me.Label3.Name = "Label3"
      Me.Label3.Size = New System.Drawing.Size(97, 22)
      Me.Label3.TabIndex = 14
      Me.Label3.Text = "Program: "
      '
      'textProgram
      '
      Me.textProgram.Location = New System.Drawing.Point(10, 284)
      Me.textProgram.MaxLength = 256
      Me.textProgram.Name = "textProgram"
      Me.textProgram.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
      Me.textProgram.Size = New System.Drawing.Size(195, 20)
      Me.textProgram.TabIndex = 13
      '
      'lblAffinity
      '
      Me.lblAffinity.AutoSize = True
      Me.lblAffinity.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblAffinity.Location = New System.Drawing.Point(223, 143)
      Me.lblAffinity.Name = "lblAffinity"
      Me.lblAffinity.Size = New System.Drawing.Size(78, 22)
      Me.lblAffinity.TabIndex = 12
      Me.lblAffinity.Text = "Affinity:"
      '
      'textAffinity
      '
      Me.textAffinity.Location = New System.Drawing.Point(307, 145)
      Me.textAffinity.Mask = "9999"
      Me.textAffinity.Name = "textAffinity"
      Me.textAffinity.Size = New System.Drawing.Size(115, 20)
      Me.textAffinity.TabIndex = 11
      Me.textAffinity.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
      '
      'GroupBox1
      '
      Me.GroupBox1.Controls.Add(Me.checkWait)
      Me.GroupBox1.Controls.Add(Me.checkI)
      Me.GroupBox1.Controls.Add(Me.checkB)
      Me.GroupBox1.Location = New System.Drawing.Point(10, 143)
      Me.GroupBox1.Name = "GroupBox1"
      Me.GroupBox1.Size = New System.Drawing.Size(150, 100)
      Me.GroupBox1.TabIndex = 10
      Me.GroupBox1.TabStop = False
      Me.GroupBox1.Text = "Flags"
      '
      'checkWait
      '
      Me.checkWait.AutoSize = True
      Me.checkWait.Location = New System.Drawing.Point(11, 66)
      Me.checkWait.Name = "checkWait"
      Me.checkWait.Size = New System.Drawing.Size(48, 17)
      Me.checkWait.TabIndex = 8
      Me.checkWait.Text = "Wait"
      Me.tipWait.SetToolTip(Me.checkWait, "Start application and wait for it to terminate.")
      Me.checkWait.UseVisualStyleBackColor = True
      '
      'checkI
      '
      Me.checkI.AutoSize = True
      Me.checkI.Location = New System.Drawing.Point(11, 19)
      Me.checkI.Name = "checkI"
      Me.checkI.Size = New System.Drawing.Size(110, 17)
      Me.checkI.TabIndex = 7
      Me.checkI.Text = "New Environment"
      Me.tipI.SetToolTip(Me.checkI, "The new environment will be the original environment passed" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "to the cmd.exe and n" &
        "ot the current environment.")
      Me.checkI.UseVisualStyleBackColor = True
      '
      'checkB
      '
      Me.checkB.AutoSize = True
      Me.checkB.Location = New System.Drawing.Point(11, 42)
      Me.checkB.Name = "checkB"
      Me.checkB.Size = New System.Drawing.Size(84, 17)
      Me.checkB.TabIndex = 6
      Me.checkB.Text = "Background"
      Me.tipB.SetToolTip(Me.checkB, "Start application without creating a new window. The " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "application has ^C handlin" &
        "g ignored. Unless the application" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "enables ^C processing, ^Break is the only way" &
        " to interrupt" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "the application.")
      Me.checkB.UseVisualStyleBackColor = True
      '
      'Label2
      '
      Me.Label2.AutoSize = True
      Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label2.Location = New System.Drawing.Point(223, 75)
      Me.Label2.Name = "Label2"
      Me.Label2.Size = New System.Drawing.Size(146, 22)
      Me.Label2.TabIndex = 9
      Me.Label2.Text = "Window status:"
      '
      'cbWindow
      '
      Me.cbWindow.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
      Me.cbWindow.FormattingEnabled = True
      Me.cbWindow.Items.AddRange(New Object() {"Default", "Minimized", "Maximized"})
      Me.cbWindow.Location = New System.Drawing.Point(227, 100)
      Me.cbWindow.Name = "cbWindow"
      Me.cbWindow.Size = New System.Drawing.Size(121, 21)
      Me.cbWindow.TabIndex = 8
      Me.tipWindow.SetToolTip(Me.cbWindow, "Start the window minimized, maximized, or normally.")
      '
      'Label1
      '
      Me.Label1.AutoSize = True
      Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label1.Location = New System.Drawing.Point(223, 12)
      Me.Label1.Name = "Label1"
      Me.Label1.Size = New System.Drawing.Size(159, 22)
      Me.Label1.TabIndex = 5
      Me.Label1.Text = "Path to program:"
      '
      'textbPath
      '
      Me.textbPath.Location = New System.Drawing.Point(227, 37)
      Me.textbPath.MaxLength = 256
      Me.textbPath.Name = "textbPath"
      Me.textbPath.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
      Me.textbPath.Size = New System.Drawing.Size(195, 20)
      Me.textbPath.TabIndex = 4
      Me.tipPath.SetToolTip(Me.textbPath, "Starting directory.")
      '
      'lblTitle
      '
      Me.lblTitle.AutoSize = True
      Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblTitle.Location = New System.Drawing.Point(6, 12)
      Me.lblTitle.Name = "lblTitle"
      Me.lblTitle.Size = New System.Drawing.Size(56, 22)
      Me.lblTitle.TabIndex = 3
      Me.lblTitle.Text = "Title:"
      '
      'textbTitle
      '
      Me.textbTitle.Location = New System.Drawing.Point(10, 37)
      Me.textbTitle.MaxLength = 256
      Me.textbTitle.Name = "textbTitle"
      Me.textbTitle.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
      Me.textbTitle.Size = New System.Drawing.Size(195, 20)
      Me.textbTitle.TabIndex = 2
      Me.tipTitle.SetToolTip(Me.textbTitle, "Title to display in window title bar.")
      '
      'TabPage2
      '
      Me.TabPage2.Location = New System.Drawing.Point(4, 22)
      Me.TabPage2.Name = "TabPage2"
      Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
      Me.TabPage2.Size = New System.Drawing.Size(451, 393)
      Me.TabPage2.TabIndex = 1
      Me.TabPage2.Text = "Import"
      Me.TabPage2.UseVisualStyleBackColor = True
      '
      'TabPage3
      '
      Me.TabPage3.Controls.Add(Me.Label5)
      Me.TabPage3.Location = New System.Drawing.Point(4, 22)
      Me.TabPage3.Name = "TabPage3"
      Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
      Me.TabPage3.Size = New System.Drawing.Size(451, 393)
      Me.TabPage3.TabIndex = 2
      Me.TabPage3.Text = "About"
      Me.TabPage3.UseVisualStyleBackColor = True
      '
      'Label5
      '
      Me.Label5.AutoSize = True
      Me.Label5.Location = New System.Drawing.Point(142, 55)
      Me.Label5.Name = "Label5"
      Me.Label5.Size = New System.Drawing.Size(150, 13)
      Me.Label5.TabIndex = 0
      Me.Label5.Text = "Created By: Mitchell Freiderich"
      Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopCenter
      '
      'tipTitle
      '
      Me.tipTitle.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
      '
      'Form1
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(483, 443)
      Me.Controls.Add(Me.tabconMain)
      Me.Name = "Form1"
      Me.Text = "start GUI"
      Me.tabconMain.ResumeLayout(False)
      Me.TabPage1.ResumeLayout(False)
      Me.TabPage1.PerformLayout()
      Me.GroupBox1.ResumeLayout(False)
      Me.GroupBox1.PerformLayout()
      Me.TabPage3.ResumeLayout(False)
      Me.TabPage3.PerformLayout()
      Me.ResumeLayout(False)

   End Sub

   Friend WithEvents cbPriority As ComboBox
   Friend WithEvents lblPriority As Label
   Friend WithEvents tabconMain As TabControl
   Friend WithEvents TabPage1 As TabPage
   Friend WithEvents TabPage2 As TabPage
   Friend WithEvents TabPage3 As TabPage
   Friend WithEvents lblTitle As Label
   Friend WithEvents textbTitle As TextBox
   Friend WithEvents Label1 As Label
   Friend WithEvents textbPath As TextBox
   Friend WithEvents tipTitle As ToolTip
   Friend WithEvents tipPriority As ToolTip
   Friend WithEvents Label2 As Label
   Friend WithEvents cbWindow As ComboBox
   Friend WithEvents checkI As CheckBox
   Friend WithEvents tipI As ToolTip
   Friend WithEvents checkB As CheckBox
   Friend WithEvents tipB As ToolTip
   Friend WithEvents tipPath As ToolTip
   Friend WithEvents GroupBox1 As GroupBox
   Friend WithEvents checkWait As CheckBox
   Friend WithEvents tipWait As ToolTip
   Friend WithEvents textAffinity As MaskedTextBox
   Friend WithEvents lblAffinity As Label
   Friend WithEvents tipWindow As ToolTip
   Friend WithEvents tipAffinity As ToolTip
   Friend WithEvents btnGen As Button
   Friend WithEvents Label4 As Label
   Friend WithEvents textPara As TextBox
   Friend WithEvents Label3 As Label
   Friend WithEvents textProgram As TextBox
   Friend WithEvents lblOutput As Label
   Friend WithEvents Label6 As Label
   Friend WithEvents Label5 As Label
End Class

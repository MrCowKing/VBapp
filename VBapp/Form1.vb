Public Class Form1
   Dim strGen As String

   Private Sub GenerateString()
      'Restore strGen to default
      strGen = "START "
      'START ["title"] [/D path] [/I] [/MIN] [/MAX] [/SEPARATE | /Shared]
      '[/LOW | /NORMAL | /HIGH | /REALTIME | /ABOVENORMAL | /BELOWNORMAL]
      '[/NODE <NUMA node>] [/AFFINITY <hex affinity mask>] [/WAIT] [/B]
      '[command/program] [parameters]

      'Title
      If Not String.IsNullOrEmpty(textbTitle.Text) Then
         strGen += """" & textbTitle.Text & """ "
      End If

      'Path
      If Not String.IsNullOrEmpty(textbPath.Text) Then
         strGen += "/D " & textbPath.Text & " "
      End If

      'Environment
      If checkI.Checked Then
         strGen += "/I "
      End If

      'Window state
      If IsNothing(cbWindow.SelectedItem) Then
         Console.Error.WriteLine("Combo Box Window 'SelectedItem' is Nothing and shouldn't be!")
      Else
         Select Case cbWindow.SelectedItem.ToString()
            Case "Minimized"
               strGen += "/MIN "
            Case "Maximized"
               strGen += "/MAX "
         End Select
      End If

      'Priority
      If IsNothing(cbPriority.SelectedItem) Then
         Console.Error.WriteLine("Combo Box Priority 'SelectedItem' is Nothing and shouldn't be!")
      Else
         Select Case cbPriority.SelectedItem.ToString()
            Case "Idle"
               strGen += "/LOW "
            Case "Below Normal"
               strGen += "/BELOWNORMAL "
            Case "Normal"
               strGen += "/NORMAL "
            Case "Above Normal"
               strGen += "/ABOVENORMAL "
            Case "High"
               strGen += "/HIGH "
            Case "Realtime"
               strGen += "/REALTIME "
            Case Else
               strGen += "/NORMAL "
         End Select
      End If

      'Affinity
      If Not String.IsNullOrEmpty(textAffinity.Text) Then
         strGen += String.Format("/AFFINITY 0x{0:x} ", textAffinity.Text)
      End If

      'Wait to terminate
      If checkWait.Checked Then
         strGen += "/WAIT "
      End If

      'No New Window
      If checkB.Checked Then
         strGen += "/B "
      End If

      'program to run
      strGen += textProgram.Text & " "
      'parameters to pass to program
      strGen += textPara.Text
   End Sub

   Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
      cbWindow.SelectedIndex = 0
      cbPriority.SelectedIndex = 2
   End Sub

   Private Sub btnGen_Click(sender As Object, e As EventArgs) Handles btnGen.Click
      GenerateString()
      'write it all out
      Console.WriteLine(strGen)
   End Sub

   'Anytime a value changes, generate the output
   Private Sub StartInputChanged(sender As Object, e As EventArgs) Handles textbTitle.TextChanged, textProgram.TextChanged, textPara.TextChanged, textbPath.TextChanged, textAffinity.TextChanged, checkWait.CheckedChanged, checkI.CheckedChanged, checkB.CheckedChanged, cbWindow.SelectedIndexChanged, cbPriority.SelectedIndexChanged
      GenerateString()
      lblOutput.Text = strGen
   End Sub
End Class

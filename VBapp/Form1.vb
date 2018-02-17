Public Class Form1
   Dim strGen As String

   Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

   End Sub

   Private Sub btnGen_Click(sender As Object, e As EventArgs) Handles btnGen.Click
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
      Select Case cbWindow.SelectedItem.ToString()
         Case "Minimized"
            strGen += "/MIN "
         Case "Maximized"
            strGen += "/MAX "
      End Select
      'Priority
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
      End Select
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
      'write it all out
      Console.WriteLine(strGen)
   End Sub
End Class

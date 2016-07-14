Imports System.IO
Imports System.ComponentModel
Imports System.Runtime.InteropServices
Imports System.Threading

Public Class EfficacyTest

    Private userDesktop As String = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory)
    Private UserClosedApp As Boolean = False

    Protected Overrides Sub OnLoad(ByVal e As System.EventArgs)
        Dim scr = Screen.FromPoint(Me.Location)
        Me.Location = New Point(scr.WorkingArea.Right - Me.Width, scr.WorkingArea.Top)
        MyBase.OnLoad(e)
    End Sub
    Private Sub btnRun_Click(sender As Object, e As EventArgs) Handles btnRun.Click

        If Directory.GetFiles(tbPath1.Text, "*.exe").Count > 1000 Then
            MsgBox(tbPath1.Text + " has more than the limit of 1000 executable files." + vbCrLf + vbCrLf + "Please reduce the number of executable files to 1000 or less and try again.")
            Return
        End If

        If MessageBox.Show("Are you sure that you would like to execute each file in the " + tbPath1.Text + " directory?" + vbCrLf + vbCrLf + "Please make sure you have taken the necessary precautions to protect your computer and data." + vbCrLf + vbCrLf + "Then click the Yes button to start the test.", "Efficacy Test", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = Windows.Forms.DialogResult.Yes Then

            Dim report As System.IO.StreamWriter
            report = My.Computer.FileSystem.OpenTextFileWriter(userDesktop & "\Report.txt", True)

            report.WriteLine("")
            report.WriteLine("******************** Efficacy test started on " & DateTime.Now & " ********************")

            lbMissed.Text = "Files Missed:"
            lbEfficacy.Text = "Efficacy:"

            btnStop.Visible = True

            Dim count As Integer = 0
            Dim missedCount As Integer = 0

            Dim Path1 As String = tbPath1.Text

            If IO.Directory.Exists(Path1) Then

                For Each item As String In Directory.GetFiles(Path1)

                    If UserClosedApp = True Then Exit For

                    count = count + 1

                    lbPath.Text = item

                    Application.DoEvents()

                    If IO.File.Exists(item) Then

                        Try

                            Process.Start(item)

                            report.WriteLine("Allowed!! " & item)

                            missedCount = missedCount + 1

                        Catch ex As Win32Exception

                            report.WriteLine("Blocked: " & item)

                            Continue For

                        Finally

                            lbMissed.Text = "Files Missed: (" & missedCount & " / " & count & ")"
                            lbEfficacy.Text = "Efficacy: " & Math.Round((100 - ((missedCount / count) * 100)), 1) & "%"

                            Application.DoEvents()

                            If nudSleep.Value > 0 Then wait(nudSleep.Value * 1000)

                        End Try

                    End If

                Next

            End If

            btnStop.Visible = False
            MsgBox("Complete!")

            report.WriteLine("")
            report.WriteLine(lbMissed.Text)
            report.WriteLine(lbEfficacy.Text)

            report.Close()

            count = 0
            missedCount = 0

        End If

    End Sub

    Private Sub wait(ByVal interval As Integer)

        Dim stopW As New Stopwatch
        stopW.Start()
        Do While stopW.ElapsedMilliseconds < interval
            ' Allows your UI to remain responsive
            Application.DoEvents()
        Loop
        stopW.Stop()

    End Sub

    Private Sub tbPath1_MouseDoubleClick(sender As Object, e As EventArgs) Handles tbPath1.MouseDoubleClick

        Dim fbd As New FolderBrowserDialog()

        Dim result As DialogResult = fbd.ShowDialog()

        If Not String.IsNullOrEmpty(fbd.SelectedPath) Then
            tbPath1.Text = fbd.SelectedPath
        End If

    End Sub

    Private Sub cbRandom_Click(sender As Object, e As EventArgs) Handles cbRandom.Click

        If Not IO.Directory.Exists(tbPath1.Text & "\Random Files") Then
            IO.Directory.CreateDirectory(tbPath1.Text & "\Random Files")
        End If

        If IO.Directory.Exists(tbPath1.Text & "\Random Files") Then
            Dim filePaths As String() = Directory.GetFiles(tbPath1.Text & "\Random Files")
            For Each filePath As String In filePaths
                FileIO.FileSystem.DeleteFile(filePath, FileIO.UIOption.OnlyErrorDialogs, FileIO.RecycleOption.SendToRecycleBin)
            Next
        End If

        If (Directory.GetFiles(tbPath1.Text, "*.exe").Count) = 0 Then
            MsgBox("No files found in " & tbPath1.Text)
            Return
        End If

        If Directory.GetFiles(tbPath1.Text, "*.exe").Count < nudRandom.Value Then
            MsgBox("There are not " & nudRandom.Value & " files in " & tbPath1.Text)
            Return
        End If

        While True

            Dim FileToCopy As String = Randomize()

            If Not IO.File.Exists(tbPath1.Text & "\Random Files\" & Path.GetFileName(FileToCopy)) Then
                IO.File.Copy(FileToCopy, tbPath1.Text & "\Random Files\" & Path.GetFileName(FileToCopy))
            End If

            If Directory.GetFiles(tbPath1.Text & "\Random Files", "*.exe").Count = nudRandom.Value Then Exit While

        End While

        MsgBox("Complete!")

    End Sub

    Private Function Randomize()

        Dim rand = New Random()
        Dim files = Directory.GetFiles(tbPath1.Text, "*.exe")
        Return files(rand.[Next](files.Length))

    End Function


    Private Sub EfficacyTest_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        UserClosedApp = True
    End Sub

    Private Sub EfficacyTest_Load(sender As Object, e As EventArgs) Handles Me.Load

        lbPath.Text = Nothing
        tbPath1.Text = "C:\Malware"

    End Sub

    Private Sub btnStop_Click(sender As Object, e As EventArgs) Handles btnStop.Click

        UserClosedApp = True
        Environment.Exit(-1)

    End Sub

    <StructLayout(LayoutKind.Sequential)> _
    Public Structure ParentProcessUtilities
        ' These members must match PROCESS_BASIC_INFORMATION
        Friend Reserved1 As IntPtr
        Friend PebBaseAddress As IntPtr
        Friend Reserved2_0 As IntPtr
        Friend Reserved2_1 As IntPtr
        Friend UniqueProcessId As IntPtr
        Friend InheritedFromUniqueProcessId As IntPtr

        <DllImport("ntdll.dll")> _
        Private Shared Function NtQueryInformationProcess(processHandle As IntPtr, processInformationClass As Integer, ByRef processInformation As ParentProcessUtilities, processInformationLength As Integer, ByRef returnLength As Integer) As Integer
        End Function

        Public Shared Function GetParentProcess() As Process
            Return GetParentProcess(Process.GetCurrentProcess().Handle)
        End Function

        Public Shared Function GetParentProcess(id As Integer) As Process
            Dim process__1 As Process = Process.GetProcessById(id)
            Return GetParentProcess(process__1.Handle)
        End Function

        Public Shared Function GetParentProcess(handle As IntPtr) As Process
            Dim pbi As New ParentProcessUtilities()
            Dim returnLength As Integer
            Dim status As Integer = NtQueryInformationProcess(handle, 0, pbi, Marshal.SizeOf(pbi), returnLength)
            If status <> 0 Then
                Return Nothing
            End If

            Try
                Return Process.GetProcessById(pbi.InheritedFromUniqueProcessId.ToInt32())
            Catch generatedExceptionName As ArgumentException
                ' not found
                Return Nothing
            End Try
        End Function
    End Structure

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        CloseKernellErrorDialog()
    End Sub

    Private Sub CloseKernellErrorDialog()

        Dim title As String = "Unsupported 16-Bit Application"

        Dim hwnd As Integer

        hwnd = FindWindow("#32770", title)
        If hwnd <> 0 Then SendMessage(hwnd, WM_CLOSE, 0, 0)

    End Sub

    Public Const WM_CLOSE As Integer = &H10

    <DllImport("user32.dll", SetLastError:=True, CharSet:=CharSet.Unicode)> _
    Public Shared Function FindWindow(ByVal lpClassName As String, ByVal lpWindowName As String) As IntPtr
    End Function

    <DllImport("user32.dll", SetLastError:=True, CharSet:=CharSet.Auto)> _
    Public Shared Function SendMessage(ByVal hWnd As IntPtr, ByVal Msg As UInteger, ByVal wParam As IntPtr, ByVal lParam As IntPtr) As IntPtr
    End Function

End Class
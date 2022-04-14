Imports System.Text
Imports System.Runtime.InteropServices

Public Class SoundPlayer

    <DllImport("winmm.dll")> Private Shared Function mciSendString(ByVal command As String, ByVal buffer As StringBuilder, ByVal bufferSize As Integer, ByVal hwndCallback As IntPtr) As Integer
    End Function

    Public Sub PlayMusic()

        mciSendString("open " & Chr(34) & "C:\Users\drmci\Downloads\Men.Wav" & Chr(34) & " type waveaudio alias MediaSound", Nothing, 0, IntPtr.Zero)
        mciSendString("setaudio MediaSound volume to 1000", Nothing, 0, IntPtr.Zero)

        ' There should be a function here that make the sound start at the input value

        mciSendString("play MediaSound", Nothing, 0, IntPtr.Zero)

    End Sub

End Class

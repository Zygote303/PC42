Imports System.Text
Imports System.Runtime.InteropServices

Public Class SlicersForm

    <DllImport("winmm.dll")> Private Shared Function mciSendString(ByVal command As String, ByVal buffer As StringBuilder, ByVal bufferSize As Integer, ByVal hwndCallback As IntPtr) As Integer
    End Function

    ' consts used by GameProcessing to determine who is calling it
    Const GAMETIMER = 96
    Const MOVECARDTOKEN = 98
    Const RESETGAME = 97
    Const C1TOKEN = 0
    Const C2TOKEN = 1
    Const C3TOKEN = 2
    Const C4TOKEN = 3
    Const C5TOKEN = 4
    Const C6TOKEN = 5
    Const C7TOKEN = 6
    Const C8TOKEN = 7
    Const C9TOKEN = 8
    Const C10TOKEN = 9
    Const C11TOKEN = 10
    Const C12TOKEN = 11
    Const C13TOKEN = 12
    Const C14TOKEN = 13
    Const C15TOKEN = 14
    Const C16TOKEN = 15
    Const C17TOKEN = 16
    Const C18TOKEN = 17
    Const C19TOKEN = 18
    Const C20TOKEN = 19
    Const C21TOKEN = 20
    Const C22TOKEN = 21
    Const C23TOKEN = 22
    Const C24TOKEN = 23
    Const C25TOKEN = 24
    Const C26TOKEN = 25
    Const C27TOKEN = 26
    Const C28TOKEN = 27



    Structure DefectStruct

        Dim Group As String
        Dim Priority As Integer
        Dim Name As String
        Dim TotalString As String

        Public Sub New(g As String, p As Integer, n As String, ts As String)
            Group = g
            Priority = p
            Name = n
            TotalString = ts
        End Sub

    End Structure

    Dim Defects() As DefectStruct = New DefectStruct() {New DefectStruct("Potato", 1, "Greening", "Priority 1" & vbNewLine & "Greening"),
        New DefectStruct("Potato Defects", 2, "Undesirable Colour", "Priority 2" & vbNewLine & "Undesirable" & vbNewLine & "Colour"),
        New DefectStruct("Potato Defects", 3, "Internal Discolouration", "Priority 3" & vbNewLine & "Internal" & vbNewLine & "Discolouration"),
        New DefectStruct("Potato Defects", 4, "External Discolouration", "Priority 4" & vbNewLine & "External" & vbNewLine & "Discolouration"),
        New DefectStruct("Process Defects", 1, "Soft Centres", "Priority 1" & vbNewLine & "Soft Centres"),
        New DefectStruct("Process Defects", 2, "Excess Peel", "Priority 2" & vbNewLine & "Excess Peel"),
        New DefectStruct("Process Defects", 3, "Peel Fleck", "Priority 3" & vbNewLine & "Peel Fleck"),
        New DefectStruct("Process Defects", 4, "Clusters", "Priority 4" & vbNewLine & "Clusters"),
        New DefectStruct("Process Defects", 5, "Oily Chips", "Priority 5" & vbNewLine & "Oily"),
        New DefectStruct("Process Defects", 6, "Blisters", "Priority 6" & vbNewLine & "Blisters"),
        New DefectStruct("Other Defects", 1, "Fold Overs", "Priority 1" & vbNewLine & "Fold Overs"),
        New DefectStruct("Team Leader", 1, "Peter", "Team Leader" & vbNewLine & "Peter"),
        New DefectStruct("Team Leader", 2, "Shiva", "Team Leader" & vbNewLine & "Shiva"),
        New DefectStruct("Team Leader", 3, "Robert", "Team Leader" & vbNewLine & "Robert")}


    ' array of 28 defects, 28 defect names, defect groups, defect priorities

    Dim RandomizedCardArray(28) As Integer
    Dim RandomizedDefectName(28) As String
    Dim RandomizedDefectGroup(28) As String
    Dim RandomizedDefectPriority(28) As Integer
    Dim LoadedArrayFlag(28) As Boolean

    Const LOOKING = 0
    Const FOUND = 1

    Const NOTFLIPPED = 99

    Private Sub PlayAgainButton_Click(sender As Object, e As EventArgs) Handles PlayAgainButton.Click

        Dim frm = New SlicersForm               '' Change the class name if necessary
        frm.Show()
        Me.Close()



    End Sub

    Friend Sub SlicersForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim PassIndex, Index, MyMin, MyMax, LoadingFlag, ArrayPosition, LoadingCounter As Integer
        Dim Generator As System.Random = New System.Random()
        Dim CardInfo() As Label = {CardInfo1, CardInfo2, CardInfo3, CardInfo4, CardInfo5, CardInfo6, CardInfo7, CardInfo8, CardInfo9, CardInfo10, CardInfo11, CardInfo12, CardInfo13, CardInfo14, CardInfo15, CardInfo16, CardInfo17, CardInfo18, CardInfo19, CardInfo20, CardInfo21, CardInfo22, CardInfo23, CardInfo24, CardInfo25, CardInfo26, CardInfo27, CardInfo28}


        For Index = 0 To 27

            LoadedArrayFlag(Index) = False
            CardInfo(Index).BringToFront()
            CardInfo(Index).Visible = False

        Next Index

        For PassIndex = 0 To 1

            LoadingCounter = 14
            For Index = 0 To 13

                ' Get a random number >= MyMin and <= MyMax

                LoadingFlag = LOOKING
                While LoadingFlag <> FOUND And LoadingCounter > 0

                    MyMin = 0
                    MyMax = 27
                    ArrayPosition = Generator.Next(MyMin, MyMax + 1)

                    If LoadedArrayFlag(ArrayPosition) = False Then

                        RandomizedDefectGroup(ArrayPosition) = Defects(Index).Group
                        RandomizedDefectPriority(ArrayPosition) = Defects(Index).Priority
                        RandomizedDefectName(ArrayPosition) = Defects(Index).Name
                        LoadedArrayFlag(ArrayPosition) = True
                        CardInfo(ArrayPosition).Tag = Defects(Index).TotalString
                        LoadingFlag = FOUND
                        LoadingCounter -= 1
                    End If

                End While

            Next Index
        Next PassIndex

        SoundToggle.Checked = True

    End Sub



    ' function that deals with cards being clicked and the game timer
    Function GameProcessing(e As Integer)

        Dim Cards() As PictureBox = {C1, C2, C3, C4, C5, C6, C7, C8, C9, C10, C11, C12, C13, C14, C15, C16, C17, C18, C19, C20, C21, C22, C23, C24, C25, C26, C27, C28}
        Dim CardInfo() As Label = {CardInfo1, CardInfo2, CardInfo3, CardInfo4, CardInfo5, CardInfo6, CardInfo7, CardInfo8, CardInfo9, CardInfo10, CardInfo11, CardInfo12, CardInfo13, CardInfo14, CardInfo15, CardInfo16, CardInfo17, CardInfo18, CardInfo19, CardInfo20, CardInfo21, CardInfo22, CardInfo23, CardInfo24, CardInfo25, CardInfo26, CardInfo27, CardInfo28}
        Static Dim FlipCard1 = NOTFLIPPED
        Static Dim FlipCard2 = NOTFLIPPED
        Static Dim Score As Integer = 0
        Static Dim CardsLeft As Integer = 28
        Dim SoundMediaClick As New Media.SoundPlayer("Click.wav")
        Dim SoundMediaAwww As New Media.SoundPlayer("Awww.wav")
        Dim SoundMediaCheer As New Media.SoundPlayer("Cheer.wav")
        Dim SoundMediaSong As New Media.SoundPlayer("Men.Wav")
        Static Dim SongFlag As Boolean = False



        If SongFlag = False Then

            mciSendString("open " & Chr(34) & "Men.Wav" & Chr(34) & " type waveaudio alias MediaSound", Nothing, 0, IntPtr.Zero)
            mciSendString("setaudio MediaSound volume to 1000", Nothing, 0, IntPtr.Zero)

            ' There should be a function here that make the sound start at the input value

            mciSendString("play MediaSound", Nothing, 0, IntPtr.Zero)

        End If

        If e = RESETGAME Then


            ScoreTimer.Enabled = False
            HighlightTimer.Enabled = False
            MemoryTimer.Enabled = True
            ScoreLabel.ForeColor = Color.Gray
            FlipCard1 = NOTFLIPPED
            FlipCard2 = NOTFLIPPED
            Score = 0
            InfoText4.Visible = False
            InfoText2.Text = "P.A.E MEMORY"
            InfoText1.Text = ""
            InfoText3.Text = ""
            InfoText2.ForeColor = Color.Gray
            ScoreLabel.Text = "Score: 0"
            PlayAgainButton.Visible = False

        End If

        If FlipCard1 = NOTFLIPPED And e <> GAMETIMER Then

            Dim tempstring As String
            Dim tempindex As Integer

            FlipCard1 = e
            Cards(e).BackgroundImage = My.Resources.CardFront
            CardInfo(e).Text = RandomizedDefectName(e)
            CardInfo(e).Visible = True
            'CardInfo(e).BringToFront()

            tempstring = "Priority: " & Convert.ToString(RandomizedDefectPriority(e))
            InfoText4.Visible = True
            InfoText2.Text = tempstring
            InfoText1.Text = RandomizedDefectName(e)
            InfoText3.Text = RandomizedDefectGroup(e)
            HighlightTimer.Enabled = True

            If SoundToggle.Checked = True Then SoundMediaClick.Play()

            For tempindex = 0 To 27

                If tempindex <> e Then

                    If RandomizedDefectPriority(tempindex) = RandomizedDefectPriority(e) Then

                        If AssistanceBox.Checked = True Then Cards(tempindex).BackColor = Color.Green

                    End If

                End If

            Next

        ElseIf FlipCard2 = NOTFLIPPED And e <> GAMETIMER Then

            FlipCard2 = e
            Cards(e).BackgroundImage = My.Resources.CardFront
            CardInfo(e).Text = RandomizedDefectName(e)
            CardInfo(e).Visible = True
            'CardInfo(e).BringToFront()

            If SoundToggle.Checked = True Then SoundMediaClick.Play()

            If RandomizedDefectName(FlipCard1) = RandomizedDefectName(FlipCard2) Then

                If SoundToggle.Checked = True Then SoundMediaCheer.Play()
                Score += 100
                ScoreTimer.Enabled = True
                ScoreLabel.Text = Convert.ToString(Score)


                CardInfo(FlipCard1).Text = CardInfo(FlipCard1).Tag
                CardInfo(FlipCard2).Text = CardInfo(FlipCard2).Tag
                Cards(FlipCard1).Enabled = False
                Cards(FlipCard2).Enabled = False
                Cards(FlipCard1).Tag = True
                Cards(FlipCard2).Tag = True
                CardsLeft -= 2

                HighlightTimer.Enabled = False

                InfoText4.Visible = False
                InfoText2.Text = "P.A.E MEMORY"
                InfoText1.Text = ""
                InfoText3.Text = ""
                InfoText2.ForeColor = Color.Gray

                For tempindex = 0 To 27

                    Cards(tempindex).BackColor = SystemColors.ScrollBar
                Next

                FlipCard1 = NOTFLIPPED
                FlipCard2 = NOTFLIPPED

            Else

                If SoundToggle.Checked = True Then SoundMediaAwww.Play()

            End If

        End If

        If e = GAMETIMER Then
            For tempindex = 0 To 27

                If Cards(tempindex).Tag = False Then Cards(tempindex).BackColor = SystemColors.ScrollBar

            Next

            ScoreTimer.Enabled = False
            ScoreLabel.ForeColor = Color.Gray

        End If


        If e = GAMETIMER And FlipCard2 <> NOTFLIPPED Then

            Cards(FlipCard1).BackgroundImage = My.Resources.CardBack
            Cards(FlipCard2).BackgroundImage = My.Resources.CardBack

            CardInfo(FlipCard1).Visible = False
            'CardInfo(FlipCard1).SendToBack()

            CardInfo(FlipCard2).Visible = False
            'CardInfo(FlipCard2).SendToBack()

            HighlightTimer.Enabled = False

            InfoText4.Visible = False
            InfoText2.Text = "P.A.E MEMORY"
            InfoText2.ForeColor = Color.Gray
            InfoText1.Text = ""
            InfoText3.Text = ""

            For tempindex = 0 To 27

                Cards(tempindex).BackColor = SystemColors.ScrollBar
            Next

            FlipCard1 = NOTFLIPPED
            FlipCard2 = NOTFLIPPED

            Score -= 20
            ScoreTimer.Enabled = True
            ScoreLabel.Text = Convert.ToString(Score)

        End If

        If CardsLeft = 0 Then

            Score = Score + 100
            ScoreTimer.Enabled = True
            ScoreLabel.Text = Convert.ToString(Score)
            InfoText2.Text = "YOU WIN!!!!"
            MemoryTimer.Enabled = False
            HighlightTimer.Enabled = True
            PlayAgainButton.Visible = True
            If SoundToggle.Checked = True Then SoundMediaCheer.Play()
        End If

        Return e

    End Function

    Private Sub MemoryTimer_Tick(sender As Object, e As EventArgs) Handles MemoryTimer.Tick

        GameProcessing(GAMETIMER)

    End Sub

    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click

        Me.Close()
        ControlScreenForm.Visible = True

    End Sub

    Private Sub C1_Click(sender As Object, e As EventArgs) Handles C1.Click

        GameProcessing(C1TOKEN)

    End Sub

    Private Sub C2_Click(sender As Object, e As EventArgs) Handles C2.Click

        GameProcessing(C2TOKEN)

    End Sub

    Private Sub C3_Click(sender As Object, e As EventArgs) Handles C3.Click

        GameProcessing(C3TOKEN)

    End Sub

    Private Sub C4_Click(sender As Object, e As EventArgs) Handles C4.Click

        GameProcessing(C4TOKEN)

    End Sub

    Private Sub C5_Click(sender As Object, e As EventArgs) Handles C5.Click

        GameProcessing(C5TOKEN)

    End Sub

    Private Sub C6_Click(sender As Object, e As EventArgs) Handles C6.Click

        GameProcessing(C6TOKEN)

    End Sub

    Private Sub C7_Click(sender As Object, e As EventArgs) Handles C7.Click

        GameProcessing(C7TOKEN)

    End Sub

    Private Sub C8_Click(sender As Object, e As EventArgs) Handles C8.Click

        GameProcessing(C8TOKEN)

    End Sub

    Private Sub C9_Click(sender As Object, e As EventArgs) Handles C9.Click

        GameProcessing(C9TOKEN)

    End Sub

    Private Sub C10_Click(sender As Object, e As EventArgs) Handles C10.Click

        GameProcessing(C10TOKEN)

    End Sub

    Private Sub C11_Click(sender As Object, e As EventArgs) Handles C11.Click

        GameProcessing(C11TOKEN)

    End Sub

    Private Sub C12_Click(sender As Object, e As EventArgs) Handles C12.Click

        GameProcessing(C12TOKEN)

    End Sub

    Private Sub C13_Click(sender As Object, e As EventArgs) Handles C13.Click

        GameProcessing(C13TOKEN)

    End Sub

    Private Sub C14_Click(sender As Object, e As EventArgs) Handles C14.Click

        GameProcessing(C14TOKEN)

    End Sub

    Private Sub C15_Click(sender As Object, e As EventArgs) Handles C15.Click

        GameProcessing(C15TOKEN)

    End Sub

    Private Sub C16_Click(sender As Object, e As EventArgs) Handles C16.Click

        GameProcessing(C16TOKEN)

    End Sub

    Private Sub C17_Click(sender As Object, e As EventArgs) Handles C17.Click

        GameProcessing(C17TOKEN)

    End Sub

    Private Sub C18_Click(sender As Object, e As EventArgs) Handles C18.Click

        GameProcessing(C18TOKEN)

    End Sub

    Private Sub C19_Click(sender As Object, e As EventArgs) Handles C19.Click

        GameProcessing(C19TOKEN)

    End Sub

    Private Sub C20_Click(sender As Object, e As EventArgs) Handles C20.Click

        GameProcessing(C20TOKEN)

    End Sub

    Private Sub C21_Click(sender As Object, e As EventArgs) Handles C21.Click

        GameProcessing(C21TOKEN)

    End Sub

    Private Sub C22_Click(sender As Object, e As EventArgs) Handles C22.Click

        GameProcessing(C22TOKEN)

    End Sub

    Private Sub C23_Click(sender As Object, e As EventArgs) Handles C23.Click

        GameProcessing(C23TOKEN)

    End Sub

    Private Sub C24_Click(sender As Object, e As EventArgs) Handles C24.Click

        GameProcessing(C24TOKEN)

    End Sub

    Private Sub C25_Click(sender As Object, e As EventArgs) Handles C25.Click

        GameProcessing(C25TOKEN)

    End Sub

    Private Sub C26_Click(sender As Object, e As EventArgs) Handles C26.Click

        GameProcessing(C26TOKEN)

    End Sub

    Private Sub C27_Click(sender As Object, e As EventArgs) Handles C27.Click

        GameProcessing(C27TOKEN)

    End Sub

    Private Sub C28_Click(sender As Object, e As EventArgs) Handles C28.Click

        GameProcessing(C28TOKEN)

    End Sub


    Private Sub HighlightTimer_Tick(sender As Object, e As EventArgs) Handles HighlightTimer.Tick

        Static Dim SwitchFlag As Boolean = False

        If SwitchFlag = False Then InfoText2.ForeColor = Color.Crimson Else InfoText2.ForeColor = Color.Black

        If SwitchFlag = False Then SwitchFlag = True Else SwitchFlag = False

    End Sub

    Private Sub MoveCardTimer_Tick(sender As Object, e As EventArgs) Handles MoveCardTimer.Tick

        GameProcessing(MOVECARDTOKEN)

    End Sub

    Private Sub ScoreTimer_Tick(sender As Object, e As EventArgs) Handles ScoreTimer.Tick

        Static Dim SwitchFlag As Boolean = False

        If SwitchFlag = False Then ScoreLabel.ForeColor = Color.Yellow Else ScoreLabel.ForeColor = Color.Black

        If SwitchFlag = False Then SwitchFlag = True Else SwitchFlag = False

    End Sub

    Private Sub GlowTimer_Tick(sender As Object, e As EventArgs) Handles GlowTimer.Tick

        Dim CardIndex As Integer
        Static Dim DirectionFlag As Boolean = True
        Static Dim GreenCount As Integer = 50
        Dim RGBValue As Integer
        Dim Cards() As PictureBox = {C1, C2, C3, C4, C5, C6, C7, C8, C9, C10, C11, C12, C13, C14, C15, C16, C17, C18, C19, C20, C21, C22, C23, C24, C25, C26, C27, C28}
        Dim CardInfo() As Label = {CardInfo1, CardInfo2, CardInfo3, CardInfo4, CardInfo5, CardInfo6, CardInfo7, CardInfo8, CardInfo9, CardInfo10, CardInfo11, CardInfo12, CardInfo13, CardInfo14, CardInfo15, CardInfo16, CardInfo17, CardInfo18, CardInfo19, CardInfo20, CardInfo21, CardInfo22, CardInfo23, CardInfo24, CardInfo25, CardInfo26, CardInfo27, CardInfo28}



        If DirectionFlag = True Then

            RGBValue = RGB(GreenCount, 0, 0)
            Panel1.BackColor = Color.FromArgb(255, RGBValue, 0, 0)
            Panel2.BackColor = Color.FromArgb(255, RGBValue, 0, 0)
            GameScreenPanel.BackColor = Color.FromArgb(255, RGBValue, 0, 0)

            For CardIndex = 0 To 27

                If Cards(CardIndex).Tag = True Then

                    Cards(CardIndex).BackColor = Color.FromArgb(255, RGBValue, 0, 0)
                    CardInfo(CardIndex).BackColor = Color.FromArgb(255, RGBValue, 0, 0)
                    CardInfo(CardIndex).ForeColor = Color.Yellow

                End If

            Next CardIndex

            GreenCount += 1

            If GreenCount > 150 Then DirectionFlag = False

        Else

            RGBValue = RGB(GreenCount, 0, 0)
            Panel1.BackColor = Color.FromArgb(255, RGBValue, 0, 0)
            Panel2.BackColor = Color.FromArgb(255, RGBValue, 0, 0)
            GameScreenPanel.BackColor = Color.FromArgb(255, RGBValue, 0, 0)

            For CardIndex = 0 To 27

                If Cards(CardIndex).Tag = True Then

                    Cards(CardIndex).BackColor = Color.FromArgb(255, RGBValue, 0, 0)
                    CardInfo(CardIndex).BackColor = Color.FromArgb(255, RGBValue, 0, 0)
                    CardInfo(CardIndex).ForeColor = Color.Yellow

                End If

            Next CardIndex

            GreenCount -= 1

            If GreenCount < 50 Then DirectionFlag = True

        End If


    End Sub
End Class
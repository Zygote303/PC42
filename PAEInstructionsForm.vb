Public Class PAEInstructions

    Dim PageMax As Integer = 4
    Dim PageMin As Integer = 1

    Dim HeadingStrings() As String = {"Filler", "Potato Defects",
                                      "Process Defects",
                                      "Other",
                                      "Breakage"}




    Private Sub ExitButton_Click(sender As Object, e As EventArgs)

        Me.Close()

    End Sub



    Private Sub PAEInstructions_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        PageNumberLabel.Text = 1
        UpdateCells()

    End Sub

    Private Sub PAETNxtInfo_Click(sender As Object, e As EventArgs) Handles PAETNxtInfo.Click

        If Int(PageNumberLabel.Text) < PageMax Then PageNumberLabel.Text = Int(PageNumberLabel.Text) + 1
        Call UpdateCells()

    End Sub



    Private Sub UpdateCells()

        Dim InfoCells(,) As Object = {{DefectPriority1Label, DefectType1Label, DefectColour1Label, DefectLocation1Label, DefectSize1Label},
        {DefectPriority2Label, DefectType2Label, DefectColour2Label, DefectLocation2Label, DefectSize2Label},
         {DefectPriority3Label, DefectType3Label, DefectColour3Label, DefectLocation3Label, DefectSize3Label},
         {DefectPriority4Label, DefectType4Label, DefectColour4Label, DefectLocation4Label, DefectSize4Label},
         {DefectPriority5Label, DefectType5Label, DefectColour5Label, DefectLocation5Label, DefectSize5Label},
         {DefectPriority6Label, DefectType6Label, DefectColour6Label, DefectLocation6Label, DefectSize6Label}}

        Dim InfoText1(,) As String = {{"1", "Greening.", "A green colouration, of any size or intensity, showing on any portion of the chip.", "Anywhere on chip but usually occurs on the outer edge.", "Any size."},
            {"2", "Undesirable Colour.", "Brown - Equal to or darker than the approved colour and or black, grey, white, purple or blue.", "Anywhere on chip.", "Total area - greater than or equal to 50% of the chip surface."},
            {"3", "Internal Discolouration.", "Brown - Equal to or darker than the approved colour and or black, grey, white, purple or blue.", "Not touching edge of chip.", "Contained area (ie. a spot) 4mm - 17.5mm on any one axis."},
        {"4", "External Discolouration.", "Brown - Equal to or darker than the approved colour and or black, grey, white, purple or blue.", "Touching edge of chip.", "Contained area (ie. a spot) 4mm - 17.5mm on any one axis."}}

        Dim InfoText2(,) As String = {{"1", "Soft Centres.", "Any uncooked area within a chip giving the area a slimy feel/translucent appearance and/or allowing the chip to bend without breaking cleanly. Readily detected by feeling the chip between the fingers.", "Anywhere on chip.", "Any Amount."},
            {"2", "Excess Peel.", "A chip where greater than or equal to one third of the outside edge has potato skin adhering to it.", "N/A", "N/A"},
            {"3", "Peel Fleck.", "Chips which contain four or more flakes of potato related material or cooked starch on (at least one side of) the surface of the chip.", "N/A", "N/A"},
        {"4", "Clusters.", "2 fully cooked chips which are stuck together.", "N/A", "N/A"},
        {"5", "Oily Chips.", "Chip with dark, oily or translucent (see through) over greater than or equal to 50% of the chip surface area.  Readily identified by viewing the chip against black background.", "N/A", "N/A"},
        {"7", "Blisters.", "One or more bubbles (separation of layers) which in combination, cover more than 50% of the chip surface area.  They can either be intact or broken.", "N/A", "N/A"}}

        Dim InfoText3(,) As String = {{"1", "Fold Overs.", "Chips which are folded until the ends touch.", "N/A", "N/A"}}

        Dim InfoText4(,) As String = {{"1", "Whole chip - Unbroken chip.", "A complete (ie. unbroken chip) of any size or a large chip with less than 25% of the chip missing.", "N/A", "N/A"},
            {"2", "Partial.", "A chip which is not whole but is greater than 30mm in diametre on both axes.", "N/A", "N/A"},
            {"3", "Scrap.", "A chip which is not whole but is less than or equal to 30mm on both axes.", "N/A", "N/A"}}


        Dim InfoStrings(100, 100)

        Dim CounterX As Integer
        Dim CounterY As Integer

        Dim Rows As Integer
        Dim Columns As Integer

        DefectHeadingLabel.Text = HeadingStrings(Int(PageNumberLabel.Text))

        Select Case Int(PageNumberLabel.Text)

            Case 1

                Rows = 3
                Columns = 4
                InfoStrings = InfoText1

            Case 2

                Rows = 5
                Columns = 4
                InfoStrings = InfoText2

            Case 3

                Rows = 0
                Columns = 4
                InfoStrings = InfoText3

            Case 4

                Rows = 2
                Columns = 4
                InfoStrings = InfoText4



            Case Else

                Return

        End Select

        For CounterX = 0 To 5

            For CounterY = 0 To 4

                InfoCells(CounterX, CounterY).visible = False

            Next CounterY
        Next CounterX

        For CounterX = 0 To Rows

            For CounterY = 0 To Columns

                InfoCells(CounterX, CounterY).visible = True
                InfoCells(CounterX, CounterY).text = InfoStrings(CounterX, CounterY)

            Next CounterY

        Next CounterX

    End Sub

    Private Sub PAETPrevInfo_Click_1(sender As Object, e As EventArgs) Handles PAETPrevInfo.Click

        If Int(PageNumberLabel.Text) > PageMin Then PageNumberLabel.Text = Int(PageNumberLabel.Text) - 1
        Call UpdateCells()

    End Sub

    Private Sub ExitButton_Click_1(sender As Object, e As EventArgs) Handles ExitButton.Click

        Me.Close()

    End Sub
End Class


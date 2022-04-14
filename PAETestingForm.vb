Public Class PAETestingForm

    Dim Count As Integer = 0
    Dim ButtonIndex As Integer

    Dim MouseX As Integer
    Dim MouseY As Integer
    Dim MouseLock As Boolean = True

    Const UNDESIRABLE = 0
    Const GREEN = 1
    Const EXTERNAL = 2
    Const INTERNAL = 3
    Const EXCESSPEEL = 4
    Const SOFT = 5
    Const OILSOAK = 6
    Const CLUSTER = 7
    Const BLISTER = 8
    Const PEELFLK = 9
    Const FOLD = 10
    Const NEWCHIP = 11

    Const PAETUTINTRO = 0
    Const PAETUTEND = 17
    Const PAEUNLOCKSCALES = 7
    Const PAEUNLOCKPOTATODEFECTBUTTONS = 13
    Const PAEANALYSIS = 13

    Const WEIGHTTAB = 0
    Const ANALYSISTAB = 1
    Const CALCTAB = 2
    Const PAEHELP = 3
    Const PAECALC = 4
    Const PAERULER = 5
    Const PAETIMER = 6

    Dim PAETutIndex = PAETUTINTRO

    Dim TextStrings() = {"Welcome to the Product Assurance Engineering tutorial.

PAE testing is a process which is used to determine the quality characteristics of a product and to detect and identify the types and quantity of defects within that product.

The PAE process requires us to collect a sample of product, weigh out a known quantity (200g in our case) and then analyse that product using established guidelines and procedures.

Performing PAE requires that one knows where to take the sample from, what the sample size should be, the order in which the sample is to be assessed (Potato Defects, Process Defects, and Other Defects) and the priority of the defects within those groups.

One also has to have knowledge of the equipment required for proper analysis to take place.

Click the Next Button to continue",
"PAE Apparatus Required

To perform your PAE you will require the following things:

1. A clean workbench and space to arrange your materials.

2. A balance or scale that can measure to 0.1 g accuracy.

3. 2 Sample bowls or trays.

4. A PAE Sheet for the product being assessed (different products will have different specifications).

5. A Potato Defect Size and Colour Template tool (obtainable from your QA department).

6. A Black Mat or Black Cardboard - Black viewing background to assess oiley chips.

Click Next to continue.",
"PAE Procedure

1. Collect a sample of product from the optical sorter exit point in your sample tray or bowl.

2. Weigh out 200g using the balance or scale.

3. Record the exact weight of the sample.

4. Examine each chip in the sample for Potato Defects scoring any defect on each chip that has the highest priority.

5. Weigh each category of potato defects to the nearests 0.1 grams.

6. Calculate the % of each category, to the accuracy of 1 decimal place, by using the following calculation:

Defect % = Weight of Defect Category divided by total sample weight (200g) multiplied by 100.

Example: 2 grams of oiley chips / 200 = 0.1 * 100 = 1% oiley chips.

Click Next to continue.",
"Process Defects

Now we need to assess the sample for Process Defects.  To do this we must recombine all the chips, both the Potato defective chips we just assessed and non-defective chips back into a single 200g sample.

1. Examine each chip in the sample for Process Defects.  Defects are scored in priority order.  If more than one defect exists on the chip then you score only that defect and ignore the others.

2. Weigh each priority group of potato defects to the nearests 0.1 grams.

3. Calculate the % of each category, to the accuracy of 1 decimal place, by using the following calculation:

Defect % = Weight of Defect Category divided by total sample weight (200g) multiplied by 100.

Example: 2 grams of soft chips / 200 = 0.1 * 100 = 1% soft chips.

Click Next to continue.",
"Other Defects

We now need to recombine all the chips again to assess the Other category of defects.

1. Examine each chip in the sample for Other Defects - this category only consists of Foldovers.

2. Weigh all the foldovers to the nearest 0.1 grams.

3. Calculate the % of foldovers, to the accuracy of 1 decimal place, by using the following calculation:

Defect % = Weight of foldovers divided by total sample weight (200g) multiplied by 100.

Example: 2 grams of foldovers / 200 = 0.1 * 100 = 1% foldovers.

Click Next to continue.",
"Our last task is now to calculate the total defects for each category:

1. Calculate the Total Potato Defects by adding % Greening + % Undesirable Colour + % Internal Discolouration + % External Discolouration.

2. Calculate the Total Process Defects by adding % Soft Centres + % Peel + % Peel Fleck + % Oiley + % Clusters + % Blisters.

3. Record the results on the PAE Sheet as well as any actions taken to address any out of specification results.",
"Additional Information:

1. For each category - Potato Defect and Process Defect each chip is scored ONLY ONCE for that category.  

Example - Potato Defect - a chip has Greening and Peel defects.  The chip is only scored as Greening because Greening is higher in priority than Peel and both are in the same group of defects.

Example - Process Defect - a chip has Soft Centres and Oily defects.  The chip is only scored as Soft Centre as Soft Centre is higher in priority than Oily and both are in the same group of defects.

2. A chip can be scored more than once throughout the entire process if they're in different groups.

Example - A chip has Greening and Soft Centre defects.  It is scored once in Potato defects (Greening) and once in Process defects (Soft Centre) as they're in different groups.

Click Next to continue.
",
"Lets now perform a PAE on some virtual chips.

To start we will need to zero our scales so we can clear any extraneous weight and ensure our sample is exactly 200g. 

STEP 1: Click the Zero button on the virtual scales on the left.

STEP 2: Click the [Get Sample] Button next to the scales to add some chips to the scale.

Step 3 - Click the [Add Chip] and [Remove Chip] buttons to add and remove small amounts of chips until we have exactly 200g.

Step 4 - When the scales turn green we have completed our task and can move to the next stage.

Click the [Next] button to continue.",
"Before we continue lets change to the Step 2 - Assessment tab.  You can find this tab on the top left of the screen.  

STEP 1: Click the Step 2 - Assess tab in the top left of the screen.

The Assessment tab simulates the process of inspecting and sorting the chips we weighed earlier to establish the ratio's of defects it contains.  Lets explore the Assessment tab interface now.


Click [Next] to continue.",
"Analysis Controls

On the far left of the screen you'll find the Analysis Controls.  These controls consist of 11 buttons divided into 3 groups (Potato Defects, Process Defects and Other Defects).  These buttons are used to tag a chip with a particular defect type based on your assessment of the chip being examined.


The Chip Window

To the right of the Analysis Controls you'll see an window with an image of a potato chip surrounded by three small buttons.  

This window displays the current chip to be analysed from your sample of chips.   

The [Flip] button on the left top of the window will flip the chip over so you can inspect both sides.  Clicking the [Flip] button again will reflip the chip to its original position.

The [Previous] and [Next] buttons will allow you to view each chip in your sample so you can analyse and score it.

Click [Next] to continue.
",
"The Defect Selector

Superimposed over the image of the chip in the Chip Window you will see one large red circle and one small yellow circle.  The red circle has a circumference of 17.5mm and the small circle a circumferance of 4mm. These circles allow you to measure the size of the defects on the chip.

If you click in the Chip Window the Defect Selector will follow your mouse and allow you to hover over or click on a defect to measure it.  

If you click on a defect while the Defect Selector is following your mouse the Defect Selector will attach itself to the defect.  Clicking again will detach the Defect Selector.

Click [Next] to continue.",
"The Ruler Tool

Underneath the Chip Window you will find the Ruler Tool.  The Ruler tool has a 4mm yellow coloured rule, a 17.5mm red coloured rule and an approved colour sample which can be used to measure a defect colour to assess a defect.  The ruler can be dragged around the screen using its title bar and mouse.

To deactivate or reactivate the Ruler Tool you can click the [Ruler] button located at the top of the Instructions window.


The Assessed Chips Window

The Assessed Chips Window is located underneath the Ruler Tool.

The Assessed Chips Window lists the number and types of defects which you have attached to individual chips in your sample.  Whenever you tag or untag a chip with a defect using the Analysis Controls that defect types counter will increase or decrease in the Assessed Chips Window.

Click [Next] to continue.",
"The Help Tool

The purpose of this PAE Tutorial is to allow you to learn to perform real life PAE Analysis.  This can only be accomplished if you know how to assess a chip properly with the highest priority defect that it exhibits.

The [Help] Tool provides you with the information that you need to learn the defect types and priorities so you can correctly choose the highest priority defect that the chip exhibits.

The [Help] Tool can be activated by clicking the [Help] button to the right of the [Ruler] button.

The tool displays the priorities and descriptions of the defects that can be found on the potato chips you are assessing.   The tool contains 4 catagories of defects (Potato Defects, Process Defects, Other Defects and Breakage Defects).  You can move between the different defect types using the [Next] and [Previous] buttons.

Click [Next] to continue.",
"Performing a PAE Assessment.

Now that we know how to use the elements of the Assessment tab lets discuss the process of performing a PAE Analysis in real life.

Your first task is to understand the steps in the PAE process. 

The Steps are:

1. Perform a Potato Defect analysis of all the chips in your sample.
2. Each time you identify the highest priority Potato defect that a chip exhibits (if it has one) you put that chip aside in its own pile (or in this program you tag it in the chip window) 
3. When you have completed your Potato Defect assessment you weigh the piles and record the results.
4. You then put all the chips together, both the Potato Defect chips you removed and the non-defect chips so that you have a 200g sample once again.
5. You then perform the analysis again but this time you perform a Process Defect analysis.
6. You identify the highest priority Process defects and place those into piles based on Process defects. 
7. You then weigh those piles and record the results.
8. Once again you put all the chips back so you have a 200g sample again.
9. The next step is to perform an analysis to assess the 200g sample for Other Defects - this catagory only consists of Foldovers.
10. Weigh the foldovers that you discovered and record the results.
11. Now you're almost done.  All that is left to do is your calculations.

Click [Next] to continue.",
"Lets Perform a PAE Analysis of our sample now.

Step 1. Using the Chip Window and the Help Tool, Ruler and Defect Selector, identify the Potato Defect of the chip in the window.  Don't forget to flip the chip over to see if it contains a higher level defect than the side that is showing.

Step 2: Once you have identified the highest priority defect on the chip attach a defect to it by clicking the appropriate button in the Potato Defects group under Analysis Controls.

Step 3: Click the [Next] button located at the bottom of the Chip Window until you find a Process Defect and tag that with the appropriate button from the Process Defects group.

Step 4: Next cycle through the Chip Window until you find an Other Defect or Foldover.  Tag that chip as a Foldover.

Step 5: Click the large [Analysis Complete] button on the bottom left of the screen and then click the Weigh and Calculate tab to move to the last step of the PAE Process.",
"In a real life PAE you will weigh your piles of defect chips as you perform your three PAE analyses.  For brevity this tutorial allows you to weigh your virtual piles after all three analyses are complete.  

The Weigh and Calculate screen is a synopsis of defects that you identified in your three PAE analyses.  

It is divided into Potato Defects, Process Defects and Other Defects.   Any defect types that you identified show as coloured lightblue rows.  All we need to do now is to calculate the weight of the piles and then perform the required calculation to establish the % of that type of defect in our sample.

We will then add all the defects in each category to establish the Total Defects per category.

Click [Next] to continue.",
"1. Lets start by clicking the first of the light blue highlighted [weigh] buttons.  This will provide us with a weight in grams for the first row of defects we discovered.

2. Click the [Calc] button to activate the calculator if it is not already visible.

3. On the calculator enter the weight we just obtained for the Grams column of the first light blue row.  Using the calculator divide the number by 200. Now multiply the result by 100 to get the final result.

4. You now have your first percentage value.  

5. To save our percentage click the cell to the right of the Grams value we just used to save the result from the calculator into the % cell. 

6. Repeat the above for each light blue row until we have calculated our percentages for all defect rows.

7. Add up the percentages from each catagory in the calculator and save the values into the total cells by clicking inside the total % cells.

Click [Next] to continue.",
"You're DONE!  You should now have a basic understanding of the PAE process. You can practice your PAE anytime in this tutorial to reinforce and expand your PAE knowledge.  To exit this tutorial click the [Close] button.  "}
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click

        Me.Close()
        RulerForm.Visible = False
        RulerForm.Close()
        PAEInstructions.Visible = False
        PAEInstructions.Close()

        ControlScreenForm.Visible = True

    End Sub

    Private Sub PAETestingHelpButton_Click(sender As Object, e As EventArgs) Handles PAETestingHelpButton.Click

        Tools(PAEHELP)

    End Sub

    Private Sub NextPAEChipButton_Click(sender As Object, e As EventArgs) Handles NextPAEChipButton.Click

        If Count < 76 Then Count += 2

        If Count > 76 Then Count = 76

        PAEChipImage.BackgroundImage = ImageList1.Images.Item(Count)

        ButtonIndex = NEWCHIP
        Call PAEProcessing()

    End Sub

    Private Sub PrevPAEChipButton_Click(sender As Object, e As EventArgs) Handles PrevPAEChipButton.Click

        If Count > 0 Then Count -= 2

        If Count < 0 Then Count = 0

        PAEChipImage.BackgroundImage = ImageList1.Images.Item(Count)

        ButtonIndex = NEWCHIP
        Call PAEProcessing()

    End Sub

    Sub PAEProcessing()

        Static Dim StartFlag As Boolean = False
        Static Dim ProcessedChips(100, 3) As Integer

        If StartFlag = False Then

            Dim x As Integer
            Dim y As Integer

            For x = 0 To 99

                For y = 0 To 2

                    ProcessedChips(x, y) = 99

                Next y
            Next x

            StartFlag = True

        End If

        Dim SavedColor As Color
        Dim LoopIndex As Integer = 0

        Dim DefectButtonArray() As Object = {UCButton, GCButton, EDButton, IDButton, EPButton, SCButton,
        OSButton, CButton, BButton, PFButton, FOButton}

        Dim DefectCountArray() As Object = {UCCount, GCount, EDCount, IDCount, EPCOUNT, SCCount,
        OSCount, CCount, BCount, ClmpCount, FldCount}

        If ButtonIndex = NEWCHIP Then

            For LoopIndex = UNDESIRABLE To FOLD

                DefectButtonArray(LoopIndex).backcolor = Color.Gainsboro

            Next LoopIndex

            If ProcessedChips(Count, 0) <> 99 Then

                ButtonIndex = ProcessedChips(Count, 0)
                DefectButtonArray(ButtonIndex).BackColor = Color.LightGreen

            End If

            If ProcessedChips(Count, 1) <> 99 Then

                ButtonIndex = ProcessedChips(Count, 1)
                DefectButtonArray(ButtonIndex).BackColor = Color.LightGreen

            End If

            If ProcessedChips(Count, 2) <> 99 Then

                ButtonIndex = ProcessedChips(Count, 2)
                DefectButtonArray(ButtonIndex).BackColor = Color.LightGreen

            End If

            Return

        End If

        SavedColor = DefectButtonArray(ButtonIndex).backcolor

        If ButtonIndex <= INTERNAL Then

            For LoopIndex = UNDESIRABLE To INTERNAL

                If DefectButtonArray(LoopIndex).backcolor = Color.LightGreen Then

                    DefectCountArray(LoopIndex).text = Int(DefectCountArray(LoopIndex).text) - 1
                    DefectButtonArray(LoopIndex).backcolor = Color.Gainsboro

                    ProcessedChips(Count, 0) = 99

                End If

            Next LoopIndex

            For LoopIndex = EXCESSPEEL To PEELFLK

                If DefectButtonArray(LoopIndex).backcolor = Color.LightGreen Then

                    DefectCountArray(LoopIndex).text = Int(DefectCountArray(LoopIndex).text) - 1
                    DefectButtonArray(LoopIndex).backcolor = Color.Gainsboro

                    ProcessedChips(Count, 2) = 99

                End If

            Next LoopIndex

        ElseIf ButtonIndex >= EXCESSPEEL And ButtonIndex <= FOLD Then

            For LoopIndex = EXCESSPEEL To FOLD

                If DefectButtonArray(LoopIndex).backcolor = Color.LightGreen Then

                    DefectCountArray(LoopIndex).text = Int(DefectCountArray(LoopIndex).text) - 1
                    DefectButtonArray(LoopIndex).backcolor = Color.Gainsboro

                    ProcessedChips(Count, 1) = 99

                End If

            Next LoopIndex

            If DefectButtonArray(FOLD).backcolor = Color.LightGreen Then

                DefectCountArray(FOLD).text = Int(DefectCountArray(FOLD).text) - 1
                DefectButtonArray(FOLD).backcolor = Color.Gainsboro

                ProcessedChips(Count, 2) = 99

            End If



        ElseIf ButtonIndex >= PEELFLK Then

            If DefectButtonArray(FOLD).backcolor = Color.LightGreen Then

                DefectCountArray(FOLD).text = Int(DefectCountArray(FOLD).text) - 1
                DefectButtonArray(FOLD).backcolor = Color.Gainsboro

                ProcessedChips(Count, 2) = 99

            End If


            For LoopIndex = UNDESIRABLE To INTERNAL

                If DefectButtonArray(LoopIndex).backcolor = Color.LightGreen Then Return

            Next LoopIndex

            For LoopIndex = EXCESSPEEL To PEELFLK

                If DefectButtonArray(LoopIndex).backcolor = Color.LightGreen Then Return

            Next LoopIndex

        End If

        If SavedColor = Color.LightGreen Then

            DefectButtonArray(ButtonIndex).backcolor = Color.Gainsboro
        Else
            DefectCountArray(ButtonIndex).Text = Int(Val(DefectCountArray(ButtonIndex).text + 1))
            DefectButtonArray(ButtonIndex).BackColor = Color.LightGreen

            If ButtonIndex <= INTERNAL Then
                ProcessedChips(Count, 0) = ButtonIndex
            ElseIf ButtonIndex >= EXCESSPEEL And ButtonIndex <= PEELFLK Then
                ProcessedChips(Count, 1) = ButtonIndex
            ElseIf ButtonIndex >= FOLD Then
                ProcessedChips(Count, 2) = ButtonIndex
            End If
        End If

    End Sub

    Private Sub UCButton_Click(sender As Object, e As EventArgs) Handles UCButton.Click

        ButtonIndex = UNDESIRABLE

        Call PAEProcessing()

    End Sub

    Private Sub GCButton_Click(sender As Object, e As EventArgs) Handles GCButton.Click

        ButtonIndex = GREEN

        Call PAEProcessing()

    End Sub

    Private Sub EDButton_Click(sender As Object, e As EventArgs) Handles EDButton.Click

        ButtonIndex = EXTERNAL

        Call PAEProcessing()

    End Sub

    Private Sub IDButton_Click(sender As Object, e As EventArgs) Handles IDButton.Click

        ButtonIndex = INTERNAL

        Call PAEProcessing()

    End Sub

    Private Sub EPButton_Click(sender As Object, e As EventArgs) Handles EPButton.Click

        ButtonIndex = EXCESSPEEL

        Call PAEProcessing()

    End Sub

    Private Sub SCButton_Click(sender As Object, e As EventArgs) Handles SCButton.Click

        ButtonIndex = SOFT

        Call PAEProcessing()

    End Sub

    Private Sub OSButton_Click(sender As Object, e As EventArgs) Handles OSButton.Click

        ButtonIndex = OILSOAK

        Call PAEProcessing()

    End Sub

    Private Sub CButton_Click(sender As Object, e As EventArgs) Handles CButton.Click

        ButtonIndex = CLUSTER

        Call PAEProcessing()

    End Sub

    Private Sub BButton_Click(sender As Object, e As EventArgs) Handles BButton.Click

        ButtonIndex = BLISTER

        Call PAEProcessing()

    End Sub



    Private Sub FOButton_Click(sender As Object, e As EventArgs) Handles FOButton.Click

        ButtonIndex = FOLD

        Call PAEProcessing()

    End Sub

    Private Sub ClmpButton_Click(sender As Object, e As EventArgs) Handles PFButton.Click

        ButtonIndex = PEELFLK

        Call PAEProcessing()

    End Sub

    Private Sub PAETestingForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        InstructionText.Text = TextStrings(PAETUTINTRO)

    End Sub


    Private Sub FlipButton_Click(sender As Object, e As EventArgs) Handles FlipButton.Click

        Static FlipFlag As Boolean = False
        Static SavedCount As Integer = Count

        If SavedCount <> Count Then

            FlipFlag = False
            SavedCount = Count

        End If

        If FlipFlag = False Then

            PAEChipImage.BackgroundImage = ImageList1.Images.Item(Count + 1)
        Else
            PAEChipImage.BackgroundImage = ImageList1.Images.Item(Count)

        End If

        If FlipFlag = False Then FlipFlag = True Else FlipFlag = False

    End Sub

    Private Sub AddChipsButton_Click(sender As Object, e As EventArgs) Handles AddChipsButton.Click

        Dim MyMin As Decimal
        Dim MyMax As Decimal
        Dim Generator As System.Random = New System.Random()
        Dim Pour As Decimal
        Dim DecPar As Decimal

        If SampleChips.Visible = True Then Return

        ' Show Sample Pic

        SampleChips.Visible = True


        ' Get a random number >= MyMin and <= MyMax

        MyMin = 195.0
        MyMax = 205
        Pour = Generator.Next(MyMin, MyMax + 1)

        If CDec(Val(ScalesOutputLabel.Text)) > 0 Then Return

        ScalesOutputLabel.Text = Format(Pour, "0.0 g.")

        AddChipButton1.Enabled = True
        RemoveChipButton1.Enabled = True

    End Sub

    Private Sub ZeroScalesButton_Click(sender As Object, e As EventArgs) Handles ZeroScalesButton.Click

        ScalesOutputLabel.Text = Format(0, "0.0 g.")
        AddChipsButton.Enabled = True

    End Sub

    Private Sub AddChipButton1_Click(sender As Object, e As EventArgs) Handles AddChipButton1.Click

        If CDec(Val(ScalesOutputLabel.Text)) <= 0 Then Return
        If ScalesOutputLabel.ForeColor = Color.LimeGreen Then Return

        ScalesOutputLabel.Text = Format(CDec(Val(ScalesOutputLabel.Text)) + 1, "0.0 g.")

        If CDec(Val(ScalesOutputLabel.Text)) = 200 Then
            ScalesOutputLabel.ForeColor = Color.LimeGreen
            Return
        End If

    End Sub

    Private Sub RemoveChipButton1_Click(sender As Object, e As EventArgs) Handles RemoveChipButton1.Click

        If CDec(Val(ScalesOutputLabel.Text)) <= 0 Then Return
        If ScalesOutputLabel.ForeColor = Color.LimeGreen Then Return


        If CDec(Val(ScalesOutputLabel.Text)) > 0.01 Then ScalesOutputLabel.Text = Format(CDec(Val(ScalesOutputLabel.Text)) - 1, "0.0 g.")

        If CDec(Val(ScalesOutputLabel.Text)) = 200 Then
            ScalesOutputLabel.ForeColor = Color.LimeGreen
            Return
        End If

    End Sub

    Sub ColorResults()

        Dim DefectCountArray() As Object = {UCCount, GCount, EDCount, IDCount, EPCOUNT, SCCount,
        OSCount, CCount, BCount, ClmpCount, FldCount}
        Dim Counter As Integer

        For Counter = 0 To DefectCountArray.Length - 1

            If DefectCountArray(Counter).text <> "0" Then

                DefectCountArray(Counter).backcolor = Color.LightBlue
            Else
                DefectCountArray(Counter).backcolor = Color.Gainsboro

            End If

        Next



    End Sub




    ' Sub to ensure tools appear and disappear appropriate based on the tutorial tab we are in.
    Sub Tools(e As Integer)

        Static Dim Help As Boolean = True
        Static Dim Calc As Boolean = True
        Static Dim RulerFlag As Boolean = True

        ' Based on which sub called the routine do 

        Select Case e

            'if Timer called the routine do checks for errant tools

            Case PAETIMER

                If PAETTabControl.SelectedIndex = WEIGHTTAB Then

                    CalculatorForm.Close()
                    RulerForm.Close()
                    RulerFlag = True
                    Calc = True

                End If

                If PAETTabControl.SelectedIndex = ANALYSISTAB Then

                    CalculatorForm.Close()
                    Calc = True

                End If

                If PAETTabControl.SelectedIndex = CALCTAB Then

                    RulerForm.Close()
                    RulerFlag = True

                End If

                ' if the [Help] button called the sub activate the help window

            Case PAEHELP

                If PAEInstructions.Visible = False Then Help = True

                If Help = True Then
                    PAEInstructions.Visible = True
                    PAEInstructions.TopMost = True
                Else
                    PAEInstructions.Visible = False
                End If

                If Help = True Then Help = False Else Help = True

            Case PAECALC

                ' if the [Calc] button called the sub check if we are in calculation tab
                ' and if so activate the calc

                If Calc = True And PAETTabControl.SelectedIndex = CALCTAB Then
                    CalculatorForm.Visible = True
                    CalculatorForm.TopMost = True
                Else
                    CalculatorForm.Visible = False
                End If

                If Calc = True Then Calc = False Else Calc = True

            Case PAERULER

                ' if the [Ruler] button called the sub check if we are in Analysis tab
                ' and if so activate the ruler

                If RulerFlag = True And PAETTabControl.SelectedIndex = ANALYSISTAB Then

                    RulerForm.Visible = True
                    RulerForm.TopMost = True

                Else

                    RulerForm.Visible = False

                End If

                If RulerFlag = True Then RulerFlag = False Else RulerFlag = True


        End Select


    End Sub

    Private Sub TutorialTimer_Tick(sender As Object, e As EventArgs) Handles TutorialTimer.Tick

        ColorResults()

        Tools(PAETIMER)

        ' display the tutorial text in the strings array indexed by page counter
        InstructionText.Text = TextStrings(PAETutIndex)

    End Sub

    Private Sub PAENext_Click(sender As Object, e As EventArgs) Handles PAENext.Click



        If PAETutIndex = PAETUTEND Then Return

        PAETutIndex += 1

    End Sub

    Private Sub PAEPrevious_Click(sender As Object, e As EventArgs) Handles PAEPrevious.Click

        If PAETutIndex = PAETUTINTRO Then Return
        PAETutIndex -= 1

    End Sub



    Private Sub PAETestingRulerButton_Click(sender As Object, e As EventArgs) Handles PAETestingRulerButton.Click

        Tools(PAERULER)

    End Sub

    Private Sub PAETestingCalcButton_Click(sender As Object, e As EventArgs) Handles PAETestingCalcButton.Click

        Tools(PAECALC)

    End Sub

    Private Sub DrawCircle(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs)

        'cast the sender object to a Panel. This panel will be the one that is raising the Paint Event

        Dim PaintCircle As PictureBox = DirectCast(sender, PictureBox)

        'use the (e.Graphics) object passed to this sub to draw on the panel that raised this event

        e.Graphics.DrawEllipse(Pens.Red, 0, 0, PaintCircle.Width - 1, PaintCircle.Height - 1)

    End Sub



    Private Sub PAEChipImage_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles PAEChipImage.Paint

        Static Dim InitFlag As Boolean = False
        Dim Pen1 As New Pen(Color.Red, 2)
        Dim Pen2 As New Pen(Color.Yellow, 2)

        Dim StartPosX1 As Integer = ((PAEChipImage.Width / 2) - 34)
        Dim StartPosY1 As Integer = ((PAEChipImage.Height / 2) - 34)

        If InitFlag = False Then

            e.Graphics.DrawEllipse(Pen1, StartPosX1, StartPosY1, 68, 68)

            StartPosX1 = (PAEChipImage.Width / 2) - 10
            StartPosY1 = (PAEChipImage.Height / 2) - 10

            e.Graphics.DrawEllipse(Pen2, StartPosX1, StartPosY1, 20, 20)

            InitFlag = True

            Return

        End If

        e.Graphics.DrawEllipse(Pen1, MouseX - 34, MouseY - 34, 68, 68)
        e.Graphics.DrawEllipse(Pen2, MouseX - 10, MouseY - 10, 20, 20)

    End Sub

    Private Sub PAEChipImage_MouseMove(sender As Object, ByVal e As MouseEventArgs) Handles PAEChipImage.MouseMove

        If MouseLock = True Then Return

        MouseX = e.X
        MouseY = e.Y
        PAEChipImage.Invalidate()

    End Sub

    Private Sub PAEChipImage_MouseClick(sender As Object, e As MouseEventArgs) Handles PAEChipImage.MouseClick

        If MouseLock = True Then MouseLock = False Else MouseLock = True

        MouseX = e.X
        MouseY = e.Y
        PAEChipImage.Invalidate()


    End Sub

    Private Sub AnalysisCompleteButton_Click(sender As Object, e As EventArgs) Handles AnalysisCompleteButton.Click

        Dim IndexX, IndexY As Integer

        Dim DefectCountArray() As Object = {UCCount, GCount, EDCount, IDCount, EPCOUNT, SCCount,
        OSCount, CCount, BCount, ClmpCount, FldCount}

        Dim DefectCountArray2() As Object = {UCChipsLabel, GChipsLabel, EDChipsLabel, IDChipsLabel,
            EPChipsLabel, SCChipsLabel, OSChipsLabel, CLChipsLabel, BLChipsLabel, PFChipsLabel, FLDChipsLabel}

        Dim UCArray() As Object = {UCLabel, UCChipsLabel, UCWeighButton, UCGramsLabel, UCPercentLabel}
        Dim GArray() As Object = {GLabel, GChipsLabel, GWeighButton, GGramsLabel, GPercentLabel}
        Dim EDArray() As Object = {EDLabel, EDChipsLabel, EDWeighButton, EDGramsLabel, EDPercentLabel}
        Dim IDArray() As Object = {IDLabel, IDChipsLabel, IDWeighButton, IDGramsLabel, IDPercentLabel}

        Dim EPArray() As Object = {EPLabel, EPChipsLabel, EPWeighButton, EPGramsLabel, EPPercentLabel}
        Dim SCArray() As Object = {SCLabel, SCChipsLabel, SCWeighButton, SCGramsLabel, SCPercentLabel}
        Dim OSArray() As Object = {OSLabel, OSChipsLabel, OSWeighButton, OSGramsLabel, OSPercentLabel}
        Dim CLArray() As Object = {CLLabel, CLChipsLabel, CLWeighButton, CLGramsLabel, CLPercentLabel}
        Dim BLArray() As Object = {BLLabel, BLChipsLabel, BLWeighLabel, BLGramsLabel, BLPercentLabel}
        Dim CLPArray() As Object = {PfLabel, PFChipsLabel, PFWeighButton, PFGramsLabel, PFPercentLabel}

        Dim FLDArray() As Object = {FLDLabel, FLDChipsLabel, FLDWeighLabel, FLDGramsLabel, FLDPercentLabel}



        Dim MultiArray() As Object = {UCArray, GArray, EDArray, IDArray,
            EPArray, SCArray, OSArray, CLArray, BLArray, CLPArray, FLDArray}

        For IndexX = 0 To 10

            DefectCountArray2(IndexX).text = DefectCountArray(IndexX).text

        Next IndexX

        For IndexX = 0 To 10

            For IndexY = 0 To 4

                MultiArray(IndexX)(IndexY).enabled = False
                MultiArray(IndexX)(IndexY).Backcolor = Color.LightGray

            Next IndexY
        Next IndexX

        For IndexX = 0 To 10

            If Int(MultiArray(IndexX)(1).text) <> 0 Then

                For IndexY = 0 To 4

                    MultiArray(IndexX)(IndexY).Enabled = True
                    MultiArray(IndexX)(IndexY).Backcolor = Color.LightBlue

                Next IndexY

            End If
        Next IndexX

        PAETTabControl.SelectedIndex = 2
        PAETutIndex += 1
        PAENext.Enabled = True



    End Sub

    Function RandomWeight(w As Decimal)

        Dim Index As Integer
        Dim MyMin As Decimal
        Dim MyMax As Decimal
        Dim Generator As System.Random = New System.Random()
        Dim Sample As Decimal
        Dim DecPar As Decimal

        ' Get a random number >= MyMin and <= MyMax

        Sample = 0
        For Index = 0 To w


            MyMin = 0.5
            MyMax = 2.0
            Sample += Generator.Next(MyMin, MyMax + 1)

        Next Index


        MyMin = 1
        MyMax = 3

        For Index = 0 To w

            DecPar = Generator.Next(MyMin, MyMax + 1)

            DecPar /= 9

            Sample += DecPar

        Next Index

        Return Sample

    End Function

    Private Sub UCWeighButton_Click(sender As Object, e As EventArgs) Handles UCWeighButton.Click

        UCGramsLabel.Text = Format(RandomWeight(CDec(UCChipsLabel.Text)), "0.0")

    End Sub

    Private Sub GWeighButton_Click(sender As Object, e As EventArgs) Handles GWeighButton.Click

        GGramsLabel.Text = Format(RandomWeight(CDec(GChipsLabel.Text)), "0.0")

    End Sub

    Private Sub IDWeighButton_Click(sender As Object, e As EventArgs) Handles IDWeighButton.Click

        IDGramsLabel.Text = Format(RandomWeight(CDec(IDChipsLabel.Text)), "0.0")

    End Sub

    Private Sub EDWeighButton_Click(sender As Object, e As EventArgs) Handles EDWeighButton.Click

        EDGramsLabel.Text = Format(RandomWeight(CDec(EDChipsLabel.Text)), "0.0")

    End Sub



    Private Sub EPWeighButton_Click(sender As Object, e As EventArgs) Handles EPWeighButton.Click

        EPGramsLabel.Text = Format(RandomWeight(CDec(EPChipsLabel.Text)), "0.0")

    End Sub

    Private Sub SCWeighButton_Click(sender As Object, e As EventArgs) Handles SCWeighButton.Click

        SCGramsLabel.Text = Format(RandomWeight(CDec(SCChipsLabel.Text)), "0.0")

    End Sub

    Private Sub OSWeighButton_Click(sender As Object, e As EventArgs) Handles OSWeighButton.Click

        OSGramsLabel.Text = Format(RandomWeight(CDec(OSChipsLabel.Text)), "0.0")

    End Sub

    Private Sub CLWeighButton_Click(sender As Object, e As EventArgs) Handles CLWeighButton.Click

        CLGramsLabel.Text = Format(RandomWeight(CDec(CLChipsLabel.Text)), "0.0")

    End Sub

    Private Sub BLWeighLabel_Click(sender As Object, e As EventArgs) Handles BLWeighLabel.Click

        BLGramsLabel.Text = Format(RandomWeight(CDec(BLChipsLabel.Text)), "0.0")

    End Sub

    Private Sub CLPWeighButton_Click(sender As Object, e As EventArgs) Handles PFWeighButton.Click

        PFGramsLabel.Text = Format(RandomWeight(CDec(PFChipsLabel.Text)), "0.0")

    End Sub

    Private Sub FLDWeighLabel_Click(sender As Object, e As EventArgs) Handles FLDWeighLabel.Click

        FLDGramsLabel.Text = Format(RandomWeight(CDec(FLDChipsLabel.Text)), "0.0")

    End Sub


    Private Sub UCPercentLabel_Click(sender As Object, e As EventArgs) Handles UCPercentLabel.Click

        UCPercentLabel.Text = Format(CDec(CalculatorForm.CalcScreen.Text), "0.0") & "%"

    End Sub

    Private Sub GPercentLabel_Click(sender As Object, e As EventArgs) Handles GPercentLabel.Click

        GPercentLabel.Text = Format(CDec(CalculatorForm.CalcScreen.Text), "0.0") & "%"

    End Sub

    Private Sub IDPercentLabel_Click(sender As Object, e As EventArgs) Handles IDPercentLabel.Click

        IDPercentLabel.Text = Format(CDec(CalculatorForm.CalcScreen.Text), "0.0") & "%"

    End Sub

    Private Sub EDPercentLabel_Click(sender As Object, e As EventArgs) Handles EDPercentLabel.Click

        EDPercentLabel.Text = Format(CDec(CalculatorForm.CalcScreen.Text), "0.0") & "%"

    End Sub

    Private Sub EPPercentLabel_Click(sender As Object, e As EventArgs) Handles EPPercentLabel.Click

        EPPercentLabel.Text = Format(CDec(CalculatorForm.CalcScreen.Text), "0.0") & "%"

    End Sub

    Private Sub SCPercentLabel_Click(sender As Object, e As EventArgs) Handles SCPercentLabel.Click

        SCPercentLabel.Text = Format(CDec(CalculatorForm.CalcScreen.Text), "0.0") & "%"

    End Sub

    Private Sub OSPercentLabel_Click(sender As Object, e As EventArgs) Handles OSPercentLabel.Click

        OSPercentLabel.Text = Format(CDec(CalculatorForm.CalcScreen.Text), "0.0") & "%"

    End Sub

    Private Sub CLPercentLabel_Click(sender As Object, e As EventArgs) Handles CLPercentLabel.Click

        CLPercentLabel.Text = Format(CDec(CalculatorForm.CalcScreen.Text), "0.0") & "%"

    End Sub

    Private Sub BLPercentLabel_Click(sender As Object, e As EventArgs) Handles BLPercentLabel.Click

        BLPercentLabel.Text = Format(CDec(CalculatorForm.CalcScreen.Text), "0.0") & "%"

    End Sub

    Private Sub CLPPercentLabel_Click(sender As Object, e As EventArgs) Handles PFPercentLabel.Click

        PFPercentLabel.Text = Format(CDec(CalculatorForm.CalcScreen.Text), "0.0") & "%"

    End Sub

    Private Sub FLDPercentLabel_Click(sender As Object, e As EventArgs) Handles FLDPercentLabel.Click

        FLDPercentLabel.Text = Format(CDec(CalculatorForm.CalcScreen.Text), "0.0") & "%"

    End Sub


    Private Sub TotalPotatoDefectsLabel_Click(sender As Object, e As EventArgs) Handles TotalPotatoDefectsLabel.Click

        TotalPotatoDefectsLabel.Text = Format(CDec(CalculatorForm.CalcScreen.Text), "0.0") & "%"
        If TotalPotatoDefectsLabel.Text <> "0" Then TotalPotatoDefectsLabel.BackColor = Color.LightBlue

    End Sub

    Private Sub Label32_Click(sender As Object, e As EventArgs) Handles Label32.Click

        Label32.Text = Format(CDec(CalculatorForm.CalcScreen.Text), "0.0") & "%"
        If Label32.Text <> "0" Then Label32.BackColor = Color.LightBlue


    End Sub

    Private Sub Label34_Click(sender As Object, e As EventArgs) Handles Label34.Click

        Label34.Text = Format(CDec(CalculatorForm.CalcScreen.Text), "0.0") & "%"
        If Label34.Text <> "0" Then Label34.BackColor = Color.LightBlue


    End Sub

    Private Sub PAETestingForm_Closed(sender As Object, e As EventArgs) Handles Me.Closed

        RulerForm.Close()
        CalculatorForm.Close()
        PAEInstructions.Close()

    End Sub


End Class
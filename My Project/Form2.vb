Public Class Form2
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        Dim rowcounter As Integer

        ' Add any initialization after the InitializeComponent() call.

        rowcounter = 1
        While rowcounter < 15

            DataGridView1.Rows.Add()
            rowcounter = rowcounter + 1

        End While

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick



    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Me.Visible = False

    End Sub
End Class
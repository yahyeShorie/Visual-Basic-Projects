Public Class Form1
    'Dim Allscore(0) As Integer
    Dim Total As Integer = 0
    Dim count As Integer = 0
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim Studentdata(3) As String
        Dim data As ListViewItem

        Dim Id As String = txtID.Text
        Dim Subject As String = txtSubjects.Text
        Dim Scores As String = txtMarks.Text
        Studentdata(0) = Id
        Studentdata(1) = Subject
        Studentdata(2) = Scores
        Total += CInt(Scores)
        count += 1

        data = New ListViewItem(Studentdata)
        Display.Items.Add(data)


    End Sub

    Private Sub btnCal_Click(sender As Object, e As EventArgs) Handles btnCal.Click

        txtTotal.Text = Total
        txtAvg.Text = Total / count
    End Sub

End Class

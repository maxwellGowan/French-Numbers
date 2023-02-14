Public Class frmNumbers
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblInstructions.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnOne.Click
        lblFrench.Visible = True
        lblFrench.Text = "un"
    End Sub

    Private Sub frmNumbers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblFrench.Visible = False

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub Label1_Click_1(sender As Object, e As EventArgs) Handles lblFrench.Click

    End Sub

    Private Sub btnTwo_Click(sender As Object, e As EventArgs) Handles btnTwo.Click
        lblFrench.Visible = True
        lblFrench.Text = "duex"
    End Sub

    Private Sub btnThree_Click(sender As Object, e As EventArgs) Handles btnThree.Click
        lblFrench.Visible = True
        lblFrench.Text = "trois"
    End Sub

    Private Sub btnFour_Click(sender As Object, e As EventArgs) Handles btnFour.Click
        lblFrench.Visible = True
        lblFrench.Text = "quatre"
    End Sub

    Private Sub btnFive_Click(sender As Object, e As EventArgs) Handles btnFive.Click
        lblFrench.Visible = True
        lblFrench.Text = "cinq"
    End Sub
End Class

Public Class Form1
    Dim Firstnum As Decimal
    Dim SecondNum As Decimal
    Dim Operations As Integer
    Dim Operator_Selector As Boolean = False


    Private Sub btnADD_Click(sender As Object, e As EventArgs) Handles btnADD.Click
        Firstnum = txtBox1.Text
        SecondNum = txtBox2.Text
        Operator_Selector = True
        Operations = 1

    End Sub

    Private Sub btnSUBTRACT_Click(sender As Object, e As EventArgs) Handles btnSUBTRACT.Click
        Firstnum = txtBox1.Text
        SecondNum = txtBox2.Text
        Operator_Selector = True
        Operations = 2
    End Sub

    Private Sub btnMULTIPLY_Click(sender As Object, e As EventArgs) Handles btnMULTIPLY.Click
        Firstnum = txtBox1.Text
        SecondNum = txtBox2.Text
        Operator_Selector = True
        Operations = 3
    End Sub

    Private Sub btnDIVIDE_Click(sender As Object, e As EventArgs) Handles btnDIVIDE.Click
        Firstnum = txtBox1.Text
        SecondNum = txtBox2.Text
        Operator_Selector = True
        Operations = 4
    End Sub
    Private Sub btnAnswer_Click(sender As Object, e As EventArgs) Handles btnAnswer.Click
        If Operations = 1 Then
            txtBox3.Text = Firstnum + SecondNum
        ElseIf Operations = 2 Then
            txtBox3.Text = Firstnum - SecondNum
        ElseIf Operations = 3 Then
            txtBox3.Text = Firstnum * SecondNum
        ElseIf Operations = 4 Then
            txtBox3.Text = Firstnum / SecondNum
        End If
        Operator_Selector = False


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtBox1.Text = ""
        txtBox2.Text = ""
        txtBox3.Text = ""
    End Sub
End Class

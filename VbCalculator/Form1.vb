Public Class Form1

    Dim firstNumber, secondNumber As Decimal
    Dim opperations As Integer
    Dim operator_Selector As Boolean = False

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        If txtResults.Text <> "0" Then
            txtResults.Text += "1"
        Else
            txtResults.Text = "1"
        End If
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        If txtResults.Text <> "0" Then
            txtResults.Text += "2"
        Else
            txtResults.Text = "2"
        End If
    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        If txtResults.Text <> "0" Then
            txtResults.Text += "3"
        Else
            txtResults.Text = "3"
        End If
    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        If txtResults.Text <> "0" Then
            txtResults.Text += "4"
        Else
            txtResults.Text = "4"
        End If
    End Sub

    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        If txtResults.Text <> "0" Then
            txtResults.Text += "5"
        Else
            txtResults.Text = "5"
        End If
    End Sub

    Private Sub btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click
        If txtResults.Text <> "0" Then
            txtResults.Text += "6"
        Else
            txtResults.Text = "6"
        End If
    End Sub

    Private Sub btn7_Click(sender As Object, e As EventArgs) Handles btn7.Click
        If txtResults.Text <> "0" Then
            txtResults.Text += "7"
        Else
            txtResults.Text = "7"
        End If
    End Sub

    Private Sub btn8_Click(sender As Object, e As EventArgs) Handles btn8.Click
        If txtResults.Text <> "0" Then
            txtResults.Text += "8"
        Else
            txtResults.Text = "8"
        End If
    End Sub

    Private Sub btn9_Click(sender As Object, e As EventArgs) Handles btn9.Click
        If txtResults.Text <> "0" Then
            txtResults.Text += "9"
        Else
            txtResults.Text = "9"
        End If
    End Sub

    Private Sub btnZero_Click(sender As Object, e As EventArgs) Handles btnZero.Click
        If txtResults.Text <> "0" Then
            txtResults.Text += "0"

        End If
    End Sub

    Private Sub btnDot_Click(sender As Object, e As EventArgs) Handles btnDot.Click
        If Not (txtResults.Text.Contains(".")) Then
            txtResults.Text += "."

        End If
    End Sub

    Private Sub btnC_Click(sender As Object, e As EventArgs) Handles btnC.Click
        txtResults.Text = "0"
    End Sub

    Private Sub btnPlus_Click(sender As Object, e As EventArgs) Handles btnPlus.Click
        firstNumber = txtResults.Text
        firstNumber = txtResults.Text
            operator_Selector = True
            opperations = 1 ' = +

    End Sub

    Private Sub btnMinus_Click(sender As Object, e As EventArgs) Handles btnMinus.Click
        firstNumber = txtResults.Text
        txtResults.Text = "0"
        operator_Selector = True
        opperations = 2 ' = -
    End Sub

    Private Sub btnMalti_Click(sender As Object, e As EventArgs) Handles btnMalti.Click
        firstNumber = txtResults.Text
        txtResults.Text = "0"
        operator_Selector = True
        opperations = 3 ' = *
    End Sub

    Private Sub btnDiv_Click(sender As Object, e As EventArgs) Handles btnDiv.Click
        firstNumber = txtResults.Text
        txtResults.Text = "0"
        operator_Selector = True
        opperations = 4 '  /
    End Sub

    Private Sub btnEqual_Click(sender As Object, e As EventArgs) Handles btnEqual.Click
        If operator_Selector = True Then
            secondNumber = txtResults.Text
            If opperations = 1 Then
                txtResults.Text = firstNumber + secondNumber
            ElseIf opperations = 2 Then
                txtResults.Text = firstNumber - secondNumber
            ElseIf opperations = 3 Then
                txtResults.Text = firstNumber * secondNumber
            Else
                If secondNumber = 0 Then
                    txtResults.Text = "Error"

                Else
                    txtResults.Text = firstNumber / secondNumber
                End If
            End If
            operator_Selector = False
        End If
          
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class

Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBoxDistance.Enabled = False
    End Sub

    Private Sub RadioButtonDistance_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonDistance.CheckedChanged
        If RadioButtonDistance.Checked Then
            ClearTextBox()
            TextBoxDistance.Enabled = False
            TextBoxSpeed.Enabled = True
            TextBoxTime.Enabled = True
        End If
    End Sub

    Private Sub RadioButtonSpeed_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonSpeed.CheckedChanged
        If RadioButtonSpeed.Checked Then
            ClearTextBox()
            TextBoxDistance.Enabled = True
            TextBoxSpeed.Enabled = False
            TextBoxTime.Enabled = True
        End If
    End Sub

    Private Sub RadioButtonTime_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonTime.CheckedChanged
        If RadioButtonTime.Checked Then
            ClearTextBox()
            TextBoxDistance.Enabled = True
            TextBoxSpeed.Enabled = True
            TextBoxTime.Enabled = False
        End If
    End Sub

    Private Sub ButtonClean_Click(sender As Object, e As EventArgs) Handles ButtonClean.Click
        ClearTextBox()
    End Sub

    Private Sub TextBoxDistance_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxDistance.KeyPress
        OnlyNumbers(e)
    End Sub

    Private Sub TextBoxSpeed_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxSpeed.KeyPress
        OnlyNumbers(e)
    End Sub

    Private Sub TextBoxTime_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxTime.KeyPress
        OnlyNumbers(e)
    End Sub

    Private Sub TextBoxSpeed_TextChanged(sender As Object, e As EventArgs) Handles TextBoxSpeed.TextChanged
        CalculateValue()
    End Sub

    Private Sub TextBoxTime_TextChanged(sender As Object, e As EventArgs) Handles TextBoxTime.TextChanged
        CalculateValue()
    End Sub

    Private Sub TextBoxDistance_TextChanged(sender As Object, e As EventArgs) Handles TextBoxDistance.TextChanged
        CalculateValue()
    End Sub

    Private Sub CalculateValue()
        If RadioButtonDistance.Checked Then
            CalculateDistance()
        ElseIf RadioButtonTime.Checked Then
            CalculateTime()
        ElseIf RadioButtonSpeed.Checked Then
            CalculateSpeed()
        End If
    End Sub
    Private Sub OnlyNumbers(e As KeyPressEventArgs)
        '48 - 57  = Ascii codes for numbers

        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub ClearTextBox()
        TextBoxDistance.Text = ""
        TextBoxSpeed.Text = ""
        TextBoxTime.Text = ""
    End Sub

    Private Sub CalculateDistance()

        Dim speed As Decimal
        Dim time As Decimal

        If Decimal.TryParse(TextBoxSpeed.Text, speed) And Decimal.TryParse(TextBoxTime.Text, time) Then
            Dim timeInHours As Decimal = time / 60
            TextBoxDistance.Text = Format(timeInHours * speed, "0.00")
        End If
    End Sub

    Private Sub CalculateTime()

        Dim speed As Decimal
        Dim distance As Decimal
        Dim time As Decimal

        If Decimal.TryParse(TextBoxSpeed.Text, speed) And Decimal.TryParse(TextBoxDistance.Text, distance) Then
            If speed > 0 Then
                time = (distance / speed) * 60
                TextBoxTime.Text = Format(time, "0.00")
            End If
        End If
    End Sub

    Private Sub CalculateSpeed()

        Dim speed As Decimal
        Dim distance As Decimal
        Dim time As Decimal

        If Decimal.TryParse(TextBoxTime.Text, time) And Decimal.TryParse(TextBoxDistance.Text, distance) Then
            If distance > 0 Then
                speed = 60 / (time / distance)
                TextBoxSpeed.Text = Format(speed, "0.00")
            End If
        End If
    End Sub
End Class

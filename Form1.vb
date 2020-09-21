'Author: Robert Zeelie
'Version: 1.0.0

'A simple currency converter that asks the user to input an amount in US Dollars (USD) and converts it to British Pound (GBP) for them. The first page tells them what to do and the second is where the conversion is done

Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Proceed_Click(sender As Object, e As EventArgs) Handles Proceed.Click
        'display form 2 and close this one
        Form2.Show()
        Close()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles versionlable1.Click
        'An easter egg :)
        MessageBox.Show("This app is part of my visual programing module." & vbNewLine & vbNewLine & "This is still the first version but i plan on expanding it to accomodate for other currency pairs." & vbNewLine & vbNewLine & "Well done on finding the egg!" & vbNewLine & "Robert Zeelie B )", "Easter Egg!")
    End Sub
End Class

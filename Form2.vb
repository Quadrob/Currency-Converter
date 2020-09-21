'Author: Robert Zeelie
'Version: 1.0.0

'A simple currency converter that asks the user to input an amount in US Dollars (USD) and converts it to British Pound (GBP) for them. The first page tells them what to do and the second is where the conversion is done

Public Class Form2
    'Declare variables
    Dim USD As Double
    'Exchange rate on 12/07/2020 11:03 UTC = £0,79 to $1
    Private Const GBPConvert As Double = 0.79
    Dim GBP As Double

    Private Sub Close_Click(sender As Object, e As EventArgs) Handles CloseBtn.Click
        'Display a thank you message box and close app
        MessageBox.Show("Thank you for using my App!" & vbNewLine & vbNewLine & "Robert Zeelie", "Goodbye!")
        Me.Close()
    End Sub



    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub USDText_TextChanged(sender As Object, e As EventArgs) Handles USDText.TextChanged

    End Sub

    Private Sub ConvertBtn_Click(sender As Object, e As EventArgs) Handles ConvertBtn.Click
        'When the convert btn is hit it stores the value from the textbox in USD and calculates the value before displaying the value to the user
        Try
            USD = Double.Parse(USDText.Text)
            GBP = (GBPConvert * USD)
            pound.Text = (GBP.ToString("0.00"))

        Catch ex As Exception
            pound.Text = "Invalid"
            MessageBox.Show(ex.Message & vbNewLine & "Please try again!", "Invalid Entry")
        End Try
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles versionlable2.Click
        'An easter egg for the user :)
        MessageBox.Show("This app is part of my visual programing module." & vbNewLine & vbNewLine & "This is still the first version but i plan on expanding it to accomodate for other currency pairs." & vbNewLine & vbNewLine & "Well done on finding the egg!" & vbNewLine & "Robert Zeelie B )", "Easter Egg!")
    End Sub
End Class
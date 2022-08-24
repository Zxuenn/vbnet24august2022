Public Class Form1

    Dim totalDiscountDouble, totalAmountDueDouble
    Dim noofcustomerInteger As Integer
    Private Sub CalButton_Click(sender As Object, e As EventArgs) Handles CalButton.Click
        ' declare variable'
        Dim priceDouble, amountDueDouble, discountDouble As Double
        Dim quantityInterger As Integer

        ' read input '
        priceDouble = Double.Parse(priceTextBox.Text)
        discountDouble = Double.Parse(discountTextBox.Text)

        quantityInterger = Integer.Parse(quantityTextBox.Text)

        ' Calculation '
        amountDueDouble = (priceDouble * quantityInterger) - discountDouble

        'Display data '
        amountTextBox.Text = "RM " + amountDueDouble.ToString

        'Process summary data'
        noofcustomerInteger = noofcustomerInteger + 1
        totalDiscountDouble += discountDouble
        totalAmountDueDouble += amountDueDouble

        'Display data summary'
        noofcustomerTextBox.Text = noofcustomerInteger.ToString
        totaldiscountTextBox.Text = totalDiscountDouble.ToString
        amountdueTextBox.Text = totalAmountDueDouble.ToString
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        priceTextBox.Clear()
        discountTextBox.Clear()
        amountTextBox.Clear()
        quantityTextBox.Clear()
        noofcustomerTextBox.Clear()
        totaldiscountTextBox.Clear()
        amountdueTextBox.Clear()

    End Sub
End Class

Public Class TaxCalculator
	Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblAmount.Click

	End Sub

	Private Sub Label1_Click_1(sender As Object, e As EventArgs) Handles lblPercent.Click

	End Sub

	Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
		Dim amount As Decimal
		amount = txtAmount.Text
		If Not Decimal.TryParse(txtAmount.Text, amount) Then
			MessageBox.Show("Please Enter a valid numeric amount.")
			Exit Sub
		End If
		CalculateSubByCities()
	End Sub

	Public Sub CalculateSubByCities()
		Dim amount As Decimal
		If Not Decimal.TryParse(txtAmount.Text, amount) Then
			Return
		End If
		Dim selectedRate As Decimal = GetCityTaxRate(lstCities.Text)

		If selectedRate > 0 Then

			Dim taxAmount As Decimal = amount * (selectedRate / 100)
			Dim totalAmount As Decimal = amount + taxAmount

			txtTaxRateResult.Text = taxAmount.ToString("C2")
			txtTotalResult.Text = totalAmount.ToString("C2")
		Else
			txtTaxRateResult.Text = "N/A"
			txtTotalResult.Text = amount.ToString("C2")
		End If
	End Sub

	Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
		txtAmount.Clear()
		txtTaxRateResult.Clear()
		txtTotalResult.Clear()
		txtAmount.Focus()
	End Sub

	Private Sub lstCities_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstCities.SelectedIndexChanged
		CalculateSubByCities()
	End Sub

	Public Function GetCityTaxRate(cityName As String) As String
		Select Case cityName
			Case "San Diego"
				Return 7.75D
			Case "Chula Vista"
				Return 8.75D
			Case "Los Angeles"
				Return 9.5D
			Case Else
				Return 0D
		End Select
	End Function
End Class
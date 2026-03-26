<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TaxCalculator
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        lblAmount = New Label()
        txtAmount = New TextBox()
        btnCalculate = New Button()
        txtTaxRateResult = New TextBox()
        txtTotalResult = New TextBox()
        lblTaxes = New Label()
        lblTotal = New Label()
        lblPercent = New Label()
        btnClear = New Button()
        lstCities = New ListBox()
        lblSelectCity = New Label()
        SuspendLayout()
        ' 
        ' lblAmount
        ' 
        lblAmount.AutoSize = True
        lblAmount.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblAmount.Location = New Point(19, 92)
        lblAmount.Name = "lblAmount"
        lblAmount.Size = New Size(79, 25)
        lblAmount.TabIndex = 0
        lblAmount.Text = "Amount"
        ' 
        ' txtAmount
        ' 
        txtAmount.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        txtAmount.Location = New Point(113, 94)
        txtAmount.Name = "txtAmount"
        txtAmount.Size = New Size(217, 23)
        txtAmount.TabIndex = 1
        ' 
        ' btnCalculate
        ' 
        btnCalculate.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(128))
        btnCalculate.ForeColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        btnCalculate.Location = New Point(336, 96)
        btnCalculate.Name = "btnCalculate"
        btnCalculate.Size = New Size(75, 23)
        btnCalculate.TabIndex = 2
        btnCalculate.Text = "Calculate"
        btnCalculate.UseVisualStyleBackColor = False
        ' 
        ' txtTaxRateResult
        ' 
        txtTaxRateResult.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        txtTaxRateResult.ForeColor = Color.Black
        txtTaxRateResult.Location = New Point(115, 148)
        txtTaxRateResult.Name = "txtTaxRateResult"
        txtTaxRateResult.Size = New Size(149, 23)
        txtTaxRateResult.TabIndex = 3
        ' 
        ' txtTotalResult
        ' 
        txtTotalResult.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        txtTotalResult.ForeColor = Color.Black
        txtTotalResult.Location = New Point(270, 148)
        txtTotalResult.Name = "txtTotalResult"
        txtTotalResult.Size = New Size(141, 23)
        txtTotalResult.TabIndex = 4
        ' 
        ' lblTaxes
        ' 
        lblTaxes.AutoSize = True
        lblTaxes.Location = New Point(115, 130)
        lblTaxes.Name = "lblTaxes"
        lblTaxes.Size = New Size(24, 15)
        lblTaxes.TabIndex = 5
        lblTaxes.Text = "Tax"
        ' 
        ' lblTotal
        ' 
        lblTotal.AutoSize = True
        lblTotal.Location = New Point(270, 130)
        lblTotal.Name = "lblTotal"
        lblTotal.Size = New Size(33, 15)
        lblTotal.TabIndex = 6
        lblTotal.Text = "Total"
        ' 
        ' lblPercent
        ' 
        lblPercent.AutoSize = True
        lblPercent.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblPercent.Location = New Point(19, 148)
        lblPercent.Name = "lblPercent"
        lblPercent.Size = New Size(41, 21)
        lblPercent.TabIndex = 7
        lblPercent.Text = "20%"
        ' 
        ' btnClear
        ' 
        btnClear.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(128))
        btnClear.ForeColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        btnClear.Location = New Point(417, 96)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(75, 23)
        btnClear.TabIndex = 8
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = False
        ' 
        ' lstCities
        ' 
        lstCities.BackColor = SystemColors.Info
        lstCities.FormattingEnabled = True
        lstCities.Items.AddRange(New Object() {"San Diego", "Los Angeles", "Chula Vista"})
        lstCities.Location = New Point(110, 12)
        lstCities.Name = "lstCities"
        lstCities.Size = New Size(121, 49)
        lstCities.TabIndex = 9
        ' 
        ' lblSelectCity
        ' 
        lblSelectCity.AutoSize = True
        lblSelectCity.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblSelectCity.Location = New Point(19, 21)
        lblSelectCity.Name = "lblSelectCity"
        lblSelectCity.Size = New Size(85, 21)
        lblSelectCity.TabIndex = 10
        lblSelectCity.Text = "Select City:"
        ' 
        ' TaxCalculator
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(192))
        ClientSize = New Size(510, 191)
        Controls.Add(lblSelectCity)
        Controls.Add(lstCities)
        Controls.Add(btnClear)
        Controls.Add(lblPercent)
        Controls.Add(lblTotal)
        Controls.Add(lblTaxes)
        Controls.Add(txtTotalResult)
        Controls.Add(txtTaxRateResult)
        Controls.Add(btnCalculate)
        Controls.Add(txtAmount)
        Controls.Add(lblAmount)
        MaximumSize = New Size(526, 230)
        MinimumSize = New Size(526, 230)
        Name = "TaxCalculator"
        Text = "TaxCalculator"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblAmount As Label
    Friend WithEvents txtAmount As TextBox
    Friend WithEvents btnCalculate As Button
    Friend WithEvents txtTaxRateResult As TextBox
    Friend WithEvents txtTotalResult As TextBox
    Friend WithEvents lblTaxes As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents lblPercent As Label
    Friend WithEvents btnClear As Button
    Friend WithEvents lstCities As ListBox
    Friend WithEvents lblSelectCity As Label
End Class

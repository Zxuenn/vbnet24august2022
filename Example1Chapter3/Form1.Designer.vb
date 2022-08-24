<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.priceTextBox = New System.Windows.Forms.TextBox()
        Me.quantityTextBox = New System.Windows.Forms.TextBox()
        Me.discountTextBox = New System.Windows.Forms.TextBox()
        Me.amountTextBox = New System.Windows.Forms.TextBox()
        Me.CalButton = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.amountdueTextBox = New System.Windows.Forms.TextBox()
        Me.totaldiscountTextBox = New System.Windows.Forms.TextBox()
        Me.noofcustomerTextBox = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(107, 91)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 38)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Price :"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(107, 158)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 38)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Quantity :"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(107, 234)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 38)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Discounts :"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(107, 412)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(94, 38)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Amount :"
        '
        'priceTextBox
        '
        Me.priceTextBox.Location = New System.Drawing.Point(265, 92)
        Me.priceTextBox.Name = "priceTextBox"
        Me.priceTextBox.Size = New System.Drawing.Size(150, 31)
        Me.priceTextBox.TabIndex = 5
        '
        'quantityTextBox
        '
        Me.quantityTextBox.Location = New System.Drawing.Point(265, 165)
        Me.quantityTextBox.Name = "quantityTextBox"
        Me.quantityTextBox.Size = New System.Drawing.Size(150, 31)
        Me.quantityTextBox.TabIndex = 6
        '
        'discountTextBox
        '
        Me.discountTextBox.Location = New System.Drawing.Point(265, 234)
        Me.discountTextBox.Name = "discountTextBox"
        Me.discountTextBox.Size = New System.Drawing.Size(150, 31)
        Me.discountTextBox.TabIndex = 7
        '
        'amountTextBox
        '
        Me.amountTextBox.Location = New System.Drawing.Point(265, 409)
        Me.amountTextBox.Name = "amountTextBox"
        Me.amountTextBox.Size = New System.Drawing.Size(150, 31)
        Me.amountTextBox.TabIndex = 8
        '
        'CalButton
        '
        Me.CalButton.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.CalButton.Location = New System.Drawing.Point(53, 258)
        Me.CalButton.Name = "CalButton"
        Me.CalButton.Size = New System.Drawing.Size(229, 53)
        Me.CalButton.TabIndex = 9
        Me.CalButton.Text = "Calculation"
        Me.CalButton.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ClearButton)
        Me.GroupBox1.Controls.Add(Me.CalButton)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Location = New System.Drawing.Point(54, 46)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(480, 450)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Book Sales "
        '
        'ClearButton
        '
        Me.ClearButton.BackColor = System.Drawing.Color.LightCoral
        Me.ClearButton.Location = New System.Drawing.Point(313, 258)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(112, 53)
        Me.ClearButton.TabIndex = 12
        Me.ClearButton.Text = "Clear"
        Me.ClearButton.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Location = New System.Drawing.Point(527, 0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(364, 450)
        Me.GroupBox2.TabIndex = 11
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Book Sales "
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.amountdueTextBox)
        Me.GroupBox3.Controls.Add(Me.totaldiscountTextBox)
        Me.GroupBox3.Controls.Add(Me.noofcustomerTextBox)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Location = New System.Drawing.Point(573, 46)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(372, 430)
        Me.GroupBox3.TabIndex = 11
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Sales Summary"
        '
        'amountdueTextBox
        '
        Me.amountdueTextBox.Enabled = False
        Me.amountdueTextBox.Location = New System.Drawing.Point(26, 240)
        Me.amountdueTextBox.Name = "amountdueTextBox"
        Me.amountdueTextBox.Size = New System.Drawing.Size(244, 31)
        Me.amountdueTextBox.TabIndex = 5
        Me.amountdueTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'totaldiscountTextBox
        '
        Me.totaldiscountTextBox.Enabled = False
        Me.totaldiscountTextBox.Location = New System.Drawing.Point(26, 153)
        Me.totaldiscountTextBox.Name = "totaldiscountTextBox"
        Me.totaldiscountTextBox.Size = New System.Drawing.Size(244, 31)
        Me.totaldiscountTextBox.TabIndex = 4
        Me.totaldiscountTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'noofcustomerTextBox
        '
        Me.noofcustomerTextBox.Enabled = False
        Me.noofcustomerTextBox.Location = New System.Drawing.Point(26, 73)
        Me.noofcustomerTextBox.Name = "noofcustomerTextBox"
        Me.noofcustomerTextBox.Size = New System.Drawing.Size(244, 31)
        Me.noofcustomerTextBox.TabIndex = 3
        Me.noofcustomerTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(26, 212)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(165, 25)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Total Amount Due :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(26, 125)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(141, 25)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Total Discounts :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(26, 45)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(149, 25)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "No of Customer :"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1010, 560)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.amountTextBox)
        Me.Controls.Add(Me.discountTextBox)
        Me.Controls.Add(Me.quantityTextBox)
        Me.Controls.Add(Me.priceTextBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Book Sales Form"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents priceTextBox As TextBox
    Friend WithEvents quantityTextBox As TextBox
    Friend WithEvents discountTextBox As TextBox
    Friend WithEvents amountTextBox As TextBox
    Friend WithEvents CalButton As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents amountdueTextBox As TextBox
    Friend WithEvents totaldiscountTextBox As TextBox
    Friend WithEvents noofcustomerTextBox As TextBox
    Friend WithEvents ClearButton As Button
End Class

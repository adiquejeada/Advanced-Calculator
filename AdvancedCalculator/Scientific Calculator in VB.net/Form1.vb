Public Class Form1

    Dim f As Double
    Dim s As Double
    Dim a As Double
    Dim op As String
    Dim n As Int64

    Private Sub Button_Click(sender As System.Object, e As System.EventArgs) Handles btn1.Click, btn2.Click, btn3.Click, btn7.Click, btn6.Click, btn5.Click, btn4.Click, btn0.Click, btn9.Click, btn8.Click, btnDecimal.Click
        ' Code for button 1 to 9, 0, .
        Dim b As Button = sender
        If lblScreen.Text = "0" Then
            lblScreen.Text = b.Text
        Else
            lblScreen.Text = lblScreen.Text + b.Text
        End If
    End Sub

    Private Sub btnC_Click(sender As System.Object, e As System.EventArgs) Handles btnC.Click
        ' Clear
        lblScreen.Text = "0"
        Label2.Text = ""
    End Sub

    Private Sub btnCE_Click(sender As System.Object, e As System.EventArgs) Handles btnCE.Click
        ' Clear
        lblScreen.Text = "0"
        Label2.Text = ""
    End Sub

    Private Sub arithmetic_function(sender As System.Object, e As System.EventArgs) Handles btnPlus.Click, btnMinus.Click, btnTimes.Click, btnDivide.Click, btnExp.Click, btnMod.Click
        ' Code for +, -, *, /, Mod, Exp
        Dim ops As Button = sender
        f = lblScreen.Text
        Label2.Text = lblScreen.Text
        lblScreen.Text = ""
        op = ops.Text
        Label2.Text = Label2.Text + " " + op
    End Sub

    Private Sub btnEquals_Click(sender As System.Object, e As System.EventArgs) Handles btnEquals.Click
        ' Lines of code for the Equal
        s = lblScreen.Text
        If op = "+" Then
            a = f + s
            lblScreen.Text = a
            Label2.Text = ""
        ElseIf op = "-" Then
            a = f - s
            lblScreen.Text = a
            Label2.Text = ""
        ElseIf op = "/" Then
            a = f / s
            lblScreen.Text = a
            Label2.Text = ""
        ElseIf op = "*" Then
            a = f * s
            lblScreen.Text = a
            Label2.Text = ""
        ElseIf op = "Mod" Then
            a = f Mod s
            lblScreen.Text = a
            Label2.Text = ""
        ElseIf op = "Exp" Then
            a = f ^ s
            lblScreen.Text = a
            Label2.Text = ""
        End If
    End Sub

    Private Sub btnBin_Click(sender As System.Object, e As System.EventArgs) Handles btnBin.Click
        ' Code for Binary
        If Int64.TryParse(lblScreen.Text, n) Then
            lblScreen.Text = Convert.ToString(n, 2)
        Else
            lblScreen.Text = ""
        End If
    End Sub

    Private Sub btnSin_Click(sender As System.Object, e As System.EventArgs) Handles btnSin.Click
        ' Code for Sine
        a = Math.Sin(lblScreen.Text)
        lblScreen.Text = a
        Label2.Text = ""
    End Sub

    Private Sub btnCos_Click(sender As System.Object, e As System.EventArgs) Handles btnCos.Click
        ' Code for Cosine
        a = Math.Cos(lblScreen.Text)
        lblScreen.Text = a
        Label2.Text = ""
    End Sub

    Private Sub btnTan_Click(sender As System.Object, e As System.EventArgs) Handles btnTan.Click
        ' Code for Tangent
        a = Math.Tan(lblScreen.Text)
        lblScreen.Text = a
        Label2.Text = ""
    End Sub

    Private Sub btnLog_Click(sender As System.Object, e As System.EventArgs) Handles btnLog.Click
        ' Code for Log
        a = Math.Log(lblScreen.Text)
        lblScreen.Text = a
        Label2.Text = ""
    End Sub

    Private Sub btnHex_Click(sender As System.Object, e As System.EventArgs) Handles btnHex.Click
        ' Code for Hex
        If Int64.TryParse(lblScreen.Text, n) Then
            lblScreen.Text = Convert.ToString(n, 16)
        Else
            lblScreen.Text = ""
        End If
    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        ' Code to load data in combo box
        Me.Height = 382
        Me.Width = 248
        lblScreen.Height = 59
        lblScreen.Width = 202

        cmbUnitConversion.Text = "Choose one..."
        cmbUnitConversion.Items.Add("Celcius to Fahrenheit")
        cmbUnitConversion.Items.Add("Fahrenheit to Celcius")
        cmbUnitConversion.Items.Add("Miles to Kilometres")
        cmbUnitConversion.Items.Add("Kilometres to Miles")
        cmbUnitConversion.Items.Add("Centimetre to Metres")
    End Sub

    Private Sub btnConvert_Click(sender As System.Object, e As System.EventArgs) Handles btnConvert.Click
        ' Code for Unit Conversion
        Dim convt As Double
        If cmbUnitConversion.Text = "Celcius to Fahrenheit" Then
            convt = (9 / 5 * txtConvert.Text) + 32
            Label3.Text = (convt) & " Fahrenheit"
        ElseIf cmbUnitConversion.Text = "Fahrenheit to Celcius" Then
            convt = 5 / 9 * (txtConvert.Text - 32)
            Label3.Text = (convt) & " Celcius"
        ElseIf cmbUnitConversion.Text = "Kilometres to Miles" Then
            convt = (txtConvert.Text / 1.609344)
            Label3.Text = (convt) & " Miles"
        ElseIf cmbUnitConversion.Text = "Miles to Kilometres" Then
            convt = (txtConvert.Text * 1.609344)
            Label3.Text = (convt) & " Kilometres"
        ElseIf cmbUnitConversion.Text = "Choose one..." Or txtConvert.Text = "" Then
            MsgBox("Select a unit of conversion", "Calculator Plus", vbInformation)
        End If
    End Sub

    Private Sub btnClear_Click(sender As System.Object, e As System.EventArgs) Handles btnClear.Click
        ' Clear
        Label3.Text = ""
        txtConvert.Text = ""
    End Sub

    Private Sub ScientificToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ScientificToolStripMenuItem.Click
        ' Code to extend the form
        Me.Height = 382
        Me.Width = 362
        lblScreen.Height = 59
        lblScreen.Width = 316
        btnEquals.Width = 212
    End Sub

    Private Sub UnitConversionToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles UnitConversionToolStripMenuItem.Click
        ' Code to extend the form
        Me.Height = 382
        Me.Width = 616
        lblScreen.Height = 59
        lblScreen.Width = 316
        btnEquals.Width = 212
    End Sub

    Private Sub StandardToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles StandardToolStripMenuItem.Click
        ' Code to extend the form
        Me.Height = 382
        Me.Width = 248
        lblScreen.Height = 59
        lblScreen.Width = 202
        btnEquals.Width = 98
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        ' Code to exit
        Application.Exit()
    End Sub
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.lblScreen = New System.Windows.Forms.Label()
        Me.btn1 = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StandardToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ScientificToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UnitConversionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btn2 = New System.Windows.Forms.Button()
        Me.btn3 = New System.Windows.Forms.Button()
        Me.btnPlus = New System.Windows.Forms.Button()
        Me.btn4 = New System.Windows.Forms.Button()
        Me.btn5 = New System.Windows.Forms.Button()
        Me.btn6 = New System.Windows.Forms.Button()
        Me.btnMinus = New System.Windows.Forms.Button()
        Me.btn7 = New System.Windows.Forms.Button()
        Me.btn8 = New System.Windows.Forms.Button()
        Me.btn9 = New System.Windows.Forms.Button()
        Me.btnDivide = New System.Windows.Forms.Button()
        Me.btn0 = New System.Windows.Forms.Button()
        Me.btnC = New System.Windows.Forms.Button()
        Me.btnDecimal = New System.Windows.Forms.Button()
        Me.btnTimes = New System.Windows.Forms.Button()
        Me.btnCE = New System.Windows.Forms.Button()
        Me.btnSin = New System.Windows.Forms.Button()
        Me.btnMod = New System.Windows.Forms.Button()
        Me.btnCos = New System.Windows.Forms.Button()
        Me.btnBin = New System.Windows.Forms.Button()
        Me.btnTan = New System.Windows.Forms.Button()
        Me.btnLog = New System.Windows.Forms.Button()
        Me.btnHex = New System.Windows.Forms.Button()
        Me.btnExp = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtConvert = New System.Windows.Forms.TextBox()
        Me.btnConvert = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbUnitConversion = New System.Windows.Forms.ComboBox()
        Me.btnEquals = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblScreen
        '
        Me.lblScreen.BackColor = System.Drawing.Color.White
        Me.lblScreen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblScreen.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScreen.Location = New System.Drawing.Point(15, 33)
        Me.lblScreen.Name = "lblScreen"
        Me.lblScreen.Size = New System.Drawing.Size(316, 59)
        Me.lblScreen.TabIndex = 0
        Me.lblScreen.Text = "0"
        Me.lblScreen.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'btn1
        '
        Me.btn1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn1.Location = New System.Drawing.Point(15, 104)
        Me.btn1.Name = "btn1"
        Me.btn1.Size = New System.Drawing.Size(46, 40)
        Me.btn1.TabIndex = 1
        Me.btn1.Text = "1"
        Me.btn1.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViewToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(600, 24)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ViewToolStripMenuItem
        '
        Me.ViewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StandardToolStripMenuItem, Me.ScientificToolStripMenuItem, Me.UnitConversionToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        Me.ViewToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.ViewToolStripMenuItem.Text = "View"
        '
        'StandardToolStripMenuItem
        '
        Me.StandardToolStripMenuItem.Name = "StandardToolStripMenuItem"
        Me.StandardToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.StandardToolStripMenuItem.Text = "Standard"
        '
        'ScientificToolStripMenuItem
        '
        Me.ScientificToolStripMenuItem.Name = "ScientificToolStripMenuItem"
        Me.ScientificToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.ScientificToolStripMenuItem.Text = "Scientific"
        '
        'UnitConversionToolStripMenuItem
        '
        Me.UnitConversionToolStripMenuItem.Name = "UnitConversionToolStripMenuItem"
        Me.UnitConversionToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.UnitConversionToolStripMenuItem.Text = "Unit Conversion"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'btn2
        '
        Me.btn2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn2.Location = New System.Drawing.Point(67, 104)
        Me.btn2.Name = "btn2"
        Me.btn2.Size = New System.Drawing.Size(46, 40)
        Me.btn2.TabIndex = 3
        Me.btn2.Text = "2"
        Me.btn2.UseVisualStyleBackColor = True
        '
        'btn3
        '
        Me.btn3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn3.Location = New System.Drawing.Point(119, 104)
        Me.btn3.Name = "btn3"
        Me.btn3.Size = New System.Drawing.Size(46, 40)
        Me.btn3.TabIndex = 4
        Me.btn3.Text = "3"
        Me.btn3.UseVisualStyleBackColor = True
        '
        'btnPlus
        '
        Me.btnPlus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPlus.Location = New System.Drawing.Point(171, 104)
        Me.btnPlus.Name = "btnPlus"
        Me.btnPlus.Size = New System.Drawing.Size(46, 40)
        Me.btnPlus.TabIndex = 5
        Me.btnPlus.Text = "+"
        Me.btnPlus.UseVisualStyleBackColor = True
        '
        'btn4
        '
        Me.btn4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn4.Location = New System.Drawing.Point(15, 150)
        Me.btn4.Name = "btn4"
        Me.btn4.Size = New System.Drawing.Size(46, 40)
        Me.btn4.TabIndex = 6
        Me.btn4.Text = "4"
        Me.btn4.UseVisualStyleBackColor = True
        '
        'btn5
        '
        Me.btn5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn5.Location = New System.Drawing.Point(67, 150)
        Me.btn5.Name = "btn5"
        Me.btn5.Size = New System.Drawing.Size(46, 40)
        Me.btn5.TabIndex = 7
        Me.btn5.Text = "5"
        Me.btn5.UseVisualStyleBackColor = True
        '
        'btn6
        '
        Me.btn6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn6.Location = New System.Drawing.Point(119, 150)
        Me.btn6.Name = "btn6"
        Me.btn6.Size = New System.Drawing.Size(46, 40)
        Me.btn6.TabIndex = 8
        Me.btn6.Text = "6"
        Me.btn6.UseVisualStyleBackColor = True
        '
        'btnMinus
        '
        Me.btnMinus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMinus.Location = New System.Drawing.Point(171, 150)
        Me.btnMinus.Name = "btnMinus"
        Me.btnMinus.Size = New System.Drawing.Size(46, 40)
        Me.btnMinus.TabIndex = 9
        Me.btnMinus.Text = "-"
        Me.btnMinus.UseVisualStyleBackColor = True
        '
        'btn7
        '
        Me.btn7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn7.Location = New System.Drawing.Point(15, 196)
        Me.btn7.Name = "btn7"
        Me.btn7.Size = New System.Drawing.Size(46, 40)
        Me.btn7.TabIndex = 10
        Me.btn7.Text = "7"
        Me.btn7.UseVisualStyleBackColor = True
        '
        'btn8
        '
        Me.btn8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn8.Location = New System.Drawing.Point(67, 196)
        Me.btn8.Name = "btn8"
        Me.btn8.Size = New System.Drawing.Size(46, 40)
        Me.btn8.TabIndex = 11
        Me.btn8.Text = "8"
        Me.btn8.UseVisualStyleBackColor = True
        '
        'btn9
        '
        Me.btn9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn9.Location = New System.Drawing.Point(119, 196)
        Me.btn9.Name = "btn9"
        Me.btn9.Size = New System.Drawing.Size(46, 40)
        Me.btn9.TabIndex = 12
        Me.btn9.Text = "9"
        Me.btn9.UseVisualStyleBackColor = True
        '
        'btnDivide
        '
        Me.btnDivide.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDivide.Location = New System.Drawing.Point(171, 196)
        Me.btnDivide.Name = "btnDivide"
        Me.btnDivide.Size = New System.Drawing.Size(46, 40)
        Me.btnDivide.TabIndex = 13
        Me.btnDivide.Text = "/"
        Me.btnDivide.UseVisualStyleBackColor = True
        '
        'btn0
        '
        Me.btn0.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn0.Location = New System.Drawing.Point(15, 242)
        Me.btn0.Name = "btn0"
        Me.btn0.Size = New System.Drawing.Size(46, 40)
        Me.btn0.TabIndex = 14
        Me.btn0.Text = "0"
        Me.btn0.UseVisualStyleBackColor = True
        '
        'btnC
        '
        Me.btnC.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnC.Location = New System.Drawing.Point(67, 242)
        Me.btnC.Name = "btnC"
        Me.btnC.Size = New System.Drawing.Size(46, 40)
        Me.btnC.TabIndex = 15
        Me.btnC.Text = "C"
        Me.btnC.UseVisualStyleBackColor = True
        '
        'btnDecimal
        '
        Me.btnDecimal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDecimal.Location = New System.Drawing.Point(119, 242)
        Me.btnDecimal.Name = "btnDecimal"
        Me.btnDecimal.Size = New System.Drawing.Size(46, 40)
        Me.btnDecimal.TabIndex = 16
        Me.btnDecimal.Text = "."
        Me.btnDecimal.UseVisualStyleBackColor = True
        '
        'btnTimes
        '
        Me.btnTimes.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTimes.Location = New System.Drawing.Point(171, 242)
        Me.btnTimes.Name = "btnTimes"
        Me.btnTimes.Size = New System.Drawing.Size(46, 40)
        Me.btnTimes.TabIndex = 17
        Me.btnTimes.Text = "*"
        Me.btnTimes.UseVisualStyleBackColor = True
        '
        'btnCE
        '
        Me.btnCE.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCE.Location = New System.Drawing.Point(15, 288)
        Me.btnCE.Name = "btnCE"
        Me.btnCE.Size = New System.Drawing.Size(98, 40)
        Me.btnCE.TabIndex = 18
        Me.btnCE.Text = "CE"
        Me.btnCE.UseVisualStyleBackColor = True
        '
        'btnSin
        '
        Me.btnSin.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSin.Location = New System.Drawing.Point(233, 105)
        Me.btnSin.Name = "btnSin"
        Me.btnSin.Size = New System.Drawing.Size(46, 40)
        Me.btnSin.TabIndex = 20
        Me.btnSin.Text = "Sin"
        Me.btnSin.UseVisualStyleBackColor = True
        '
        'btnMod
        '
        Me.btnMod.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMod.Location = New System.Drawing.Point(285, 105)
        Me.btnMod.Name = "btnMod"
        Me.btnMod.Size = New System.Drawing.Size(46, 40)
        Me.btnMod.TabIndex = 21
        Me.btnMod.Text = "Mod"
        Me.btnMod.UseVisualStyleBackColor = True
        '
        'btnCos
        '
        Me.btnCos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCos.Location = New System.Drawing.Point(233, 151)
        Me.btnCos.Name = "btnCos"
        Me.btnCos.Size = New System.Drawing.Size(46, 40)
        Me.btnCos.TabIndex = 22
        Me.btnCos.Text = "Cos"
        Me.btnCos.UseVisualStyleBackColor = True
        '
        'btnBin
        '
        Me.btnBin.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBin.Location = New System.Drawing.Point(285, 151)
        Me.btnBin.Name = "btnBin"
        Me.btnBin.Size = New System.Drawing.Size(46, 40)
        Me.btnBin.TabIndex = 23
        Me.btnBin.Text = "Bin"
        Me.btnBin.UseVisualStyleBackColor = True
        '
        'btnTan
        '
        Me.btnTan.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTan.Location = New System.Drawing.Point(233, 196)
        Me.btnTan.Name = "btnTan"
        Me.btnTan.Size = New System.Drawing.Size(46, 40)
        Me.btnTan.TabIndex = 24
        Me.btnTan.Text = "Tan"
        Me.btnTan.UseVisualStyleBackColor = True
        '
        'btnLog
        '
        Me.btnLog.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLog.Location = New System.Drawing.Point(285, 196)
        Me.btnLog.Name = "btnLog"
        Me.btnLog.Size = New System.Drawing.Size(46, 40)
        Me.btnLog.TabIndex = 25
        Me.btnLog.Text = "Log"
        Me.btnLog.UseVisualStyleBackColor = True
        '
        'btnHex
        '
        Me.btnHex.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHex.Location = New System.Drawing.Point(233, 242)
        Me.btnHex.Name = "btnHex"
        Me.btnHex.Size = New System.Drawing.Size(46, 40)
        Me.btnHex.TabIndex = 26
        Me.btnHex.Text = "Hex"
        Me.btnHex.UseVisualStyleBackColor = True
        '
        'btnExp
        '
        Me.btnExp.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExp.Location = New System.Drawing.Point(285, 242)
        Me.btnExp.Name = "btnExp"
        Me.btnExp.Size = New System.Drawing.Size(46, 40)
        Me.btnExp.TabIndex = 27
        Me.btnExp.Text = "Exp"
        Me.btnExp.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(37, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 16)
        Me.Label2.TabIndex = 28
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.txtConvert)
        Me.GroupBox1.Controls.Add(Me.btnConvert)
        Me.GroupBox1.Controls.Add(Me.btnClear)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.cmbUnitConversion)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(348, 33)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(236, 295)
        Me.GroupBox1.TabIndex = 29
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Unit Conversion"
        '
        'txtConvert
        '
        Me.txtConvert.Location = New System.Drawing.Point(20, 164)
        Me.txtConvert.Multiline = True
        Me.txtConvert.Name = "txtConvert"
        Me.txtConvert.Size = New System.Drawing.Size(196, 55)
        Me.txtConvert.TabIndex = 5
        Me.txtConvert.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnConvert
        '
        Me.btnConvert.Location = New System.Drawing.Point(20, 238)
        Me.btnConvert.Name = "btnConvert"
        Me.btnConvert.Size = New System.Drawing.Size(91, 40)
        Me.btnConvert.TabIndex = 4
        Me.btnConvert.Text = "Convert"
        Me.btnConvert.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(125, 238)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(91, 40)
        Me.btnClear.TabIndex = 3
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Location = New System.Drawing.Point(13, 81)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(211, 63)
        Me.Label3.TabIndex = 2
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmbUnitConversion
        '
        Me.cmbUnitConversion.FormattingEnabled = True
        Me.cmbUnitConversion.Location = New System.Drawing.Point(12, 32)
        Me.cmbUnitConversion.Name = "cmbUnitConversion"
        Me.cmbUnitConversion.Size = New System.Drawing.Size(211, 28)
        Me.cmbUnitConversion.TabIndex = 0
        '
        'btnEquals
        '
        Me.btnEquals.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEquals.Location = New System.Drawing.Point(119, 288)
        Me.btnEquals.Name = "btnEquals"
        Me.btnEquals.Size = New System.Drawing.Size(98, 40)
        Me.btnEquals.TabIndex = 19
        Me.btnEquals.Text = "="
        Me.btnEquals.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(600, 343)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnExp)
        Me.Controls.Add(Me.btnHex)
        Me.Controls.Add(Me.btnLog)
        Me.Controls.Add(Me.btnTan)
        Me.Controls.Add(Me.btnBin)
        Me.Controls.Add(Me.btnCos)
        Me.Controls.Add(Me.btnMod)
        Me.Controls.Add(Me.btnSin)
        Me.Controls.Add(Me.btnEquals)
        Me.Controls.Add(Me.btnCE)
        Me.Controls.Add(Me.btnTimes)
        Me.Controls.Add(Me.btnDecimal)
        Me.Controls.Add(Me.btnC)
        Me.Controls.Add(Me.btn0)
        Me.Controls.Add(Me.btnDivide)
        Me.Controls.Add(Me.btn9)
        Me.Controls.Add(Me.btn8)
        Me.Controls.Add(Me.btn7)
        Me.Controls.Add(Me.btnMinus)
        Me.Controls.Add(Me.btn6)
        Me.Controls.Add(Me.btn5)
        Me.Controls.Add(Me.btn4)
        Me.Controls.Add(Me.btnPlus)
        Me.Controls.Add(Me.btn3)
        Me.Controls.Add(Me.btn2)
        Me.Controls.Add(Me.btn1)
        Me.Controls.Add(Me.lblScreen)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Calculator"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblScreen As System.Windows.Forms.Label
    Friend WithEvents btn1 As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ViewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StandardToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ScientificToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UnitConversionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btn2 As System.Windows.Forms.Button
    Friend WithEvents btn3 As System.Windows.Forms.Button
    Friend WithEvents btnPlus As System.Windows.Forms.Button
    Friend WithEvents btn4 As System.Windows.Forms.Button
    Friend WithEvents btn5 As System.Windows.Forms.Button
    Friend WithEvents btn6 As System.Windows.Forms.Button
    Friend WithEvents btnMinus As System.Windows.Forms.Button
    Friend WithEvents btn7 As System.Windows.Forms.Button
    Friend WithEvents btn8 As System.Windows.Forms.Button
    Friend WithEvents btn9 As System.Windows.Forms.Button
    Friend WithEvents btnDivide As System.Windows.Forms.Button
    Friend WithEvents btn0 As System.Windows.Forms.Button
    Friend WithEvents btnC As System.Windows.Forms.Button
    Friend WithEvents btnDecimal As System.Windows.Forms.Button
    Friend WithEvents btnTimes As System.Windows.Forms.Button
    Friend WithEvents btnCE As System.Windows.Forms.Button
    Friend WithEvents btnSin As System.Windows.Forms.Button
    Friend WithEvents btnMod As System.Windows.Forms.Button
    Friend WithEvents btnCos As System.Windows.Forms.Button
    Friend WithEvents btnBin As System.Windows.Forms.Button
    Friend WithEvents btnTan As System.Windows.Forms.Button
    Friend WithEvents btnLog As System.Windows.Forms.Button
    Friend WithEvents btnHex As System.Windows.Forms.Button
    Friend WithEvents btnExp As System.Windows.Forms.Button
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmbUnitConversion As System.Windows.Forms.ComboBox
    Friend WithEvents btnConvert As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtConvert As System.Windows.Forms.TextBox
    Friend WithEvents btnEquals As System.Windows.Forms.Button

End Class

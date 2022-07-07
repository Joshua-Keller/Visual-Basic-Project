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
        Me.LblPractice = New System.Windows.Forms.Label()
        Me.btnAnswer = New System.Windows.Forms.Button()
        Me.txtBox1 = New System.Windows.Forms.TextBox()
        Me.txtBox2 = New System.Windows.Forms.TextBox()
        Me.txtBox3 = New System.Windows.Forms.TextBox()
        Me.lblPlus = New System.Windows.Forms.Label()
        Me.lblEqualsign = New System.Windows.Forms.Label()
        Me.btnADD = New System.Windows.Forms.Button()
        Me.btnSUBTRACT = New System.Windows.Forms.Button()
        Me.btnMULTIPLY = New System.Windows.Forms.Button()
        Me.btnDIVIDE = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LblPractice
        '
        Me.LblPractice.AutoSize = True
        Me.LblPractice.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LblPractice.Location = New System.Drawing.Point(219, 45)
        Me.LblPractice.Name = "LblPractice"
        Me.LblPractice.Size = New System.Drawing.Size(135, 21)
        Me.LblPractice.TabIndex = 0
        Me.LblPractice.Text = "Basic Calculator "
        '
        'btnAnswer
        '
        Me.btnAnswer.Location = New System.Drawing.Point(288, 168)
        Me.btnAnswer.Name = "btnAnswer"
        Me.btnAnswer.Size = New System.Drawing.Size(129, 23)
        Me.btnAnswer.TabIndex = 1
        Me.btnAnswer.Text = "Check Answer"
        Me.btnAnswer.UseVisualStyleBackColor = True
        '
        'txtBox1
        '
        Me.txtBox1.Location = New System.Drawing.Point(95, 107)
        Me.txtBox1.Name = "txtBox1"
        Me.txtBox1.Size = New System.Drawing.Size(100, 23)
        Me.txtBox1.TabIndex = 2
        '
        'txtBox2
        '
        Me.txtBox2.Location = New System.Drawing.Point(233, 107)
        Me.txtBox2.Name = "txtBox2"
        Me.txtBox2.Size = New System.Drawing.Size(100, 23)
        Me.txtBox2.TabIndex = 3
        '
        'txtBox3
        '
        Me.txtBox3.Location = New System.Drawing.Point(393, 107)
        Me.txtBox3.Name = "txtBox3"
        Me.txtBox3.Size = New System.Drawing.Size(100, 23)
        Me.txtBox3.TabIndex = 4
        '
        'lblPlus
        '
        Me.lblPlus.AutoSize = True
        Me.lblPlus.Location = New System.Drawing.Point(205, 112)
        Me.lblPlus.Name = "lblPlus"
        Me.lblPlus.Size = New System.Drawing.Size(0, 15)
        Me.lblPlus.TabIndex = 5
        '
        'lblEqualsign
        '
        Me.lblEqualsign.AutoSize = True
        Me.lblEqualsign.Location = New System.Drawing.Point(351, 112)
        Me.lblEqualsign.Name = "lblEqualsign"
        Me.lblEqualsign.Size = New System.Drawing.Size(15, 15)
        Me.lblEqualsign.TabIndex = 6
        Me.lblEqualsign.Text = "="
        '
        'btnADD
        '
        Me.btnADD.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnADD.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnADD.Location = New System.Drawing.Point(95, 168)
        Me.btnADD.Name = "btnADD"
        Me.btnADD.Size = New System.Drawing.Size(75, 23)
        Me.btnADD.TabIndex = 7
        Me.btnADD.Text = "+"
        Me.btnADD.UseVisualStyleBackColor = False
        '
        'btnSUBTRACT
        '
        Me.btnSUBTRACT.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnSUBTRACT.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnSUBTRACT.Location = New System.Drawing.Point(95, 197)
        Me.btnSUBTRACT.Name = "btnSUBTRACT"
        Me.btnSUBTRACT.Size = New System.Drawing.Size(75, 23)
        Me.btnSUBTRACT.TabIndex = 8
        Me.btnSUBTRACT.Text = "-"
        Me.btnSUBTRACT.UseVisualStyleBackColor = False
        '
        'btnMULTIPLY
        '
        Me.btnMULTIPLY.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnMULTIPLY.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnMULTIPLY.Location = New System.Drawing.Point(95, 226)
        Me.btnMULTIPLY.Name = "btnMULTIPLY"
        Me.btnMULTIPLY.Size = New System.Drawing.Size(75, 23)
        Me.btnMULTIPLY.TabIndex = 9
        Me.btnMULTIPLY.Text = "*"
        Me.btnMULTIPLY.UseVisualStyleBackColor = False
        '
        'btnDIVIDE
        '
        Me.btnDIVIDE.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnDIVIDE.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnDIVIDE.Location = New System.Drawing.Point(95, 255)
        Me.btnDIVIDE.Name = "btnDIVIDE"
        Me.btnDIVIDE.Size = New System.Drawing.Size(75, 23)
        Me.btnDIVIDE.TabIndex = 10
        Me.btnDIVIDE.Text = "/"
        Me.btnDIVIDE.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.Red
        Me.btnClear.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnClear.Location = New System.Drawing.Point(322, 197)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 11
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnDIVIDE)
        Me.Controls.Add(Me.btnMULTIPLY)
        Me.Controls.Add(Me.btnSUBTRACT)
        Me.Controls.Add(Me.btnADD)
        Me.Controls.Add(Me.lblEqualsign)
        Me.Controls.Add(Me.lblPlus)
        Me.Controls.Add(Me.txtBox3)
        Me.Controls.Add(Me.txtBox2)
        Me.Controls.Add(Me.txtBox1)
        Me.Controls.Add(Me.btnAnswer)
        Me.Controls.Add(Me.LblPractice)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblPractice As Label
    Friend WithEvents btnAnswer As Button
    Friend WithEvents txtBox1 As TextBox
    Friend WithEvents txtBox2 As TextBox
    Friend WithEvents txtBox3 As TextBox
    Friend WithEvents lblPlus As Label
    Friend WithEvents lblEqualsign As Label
    Friend WithEvents btnADD As Button
    Friend WithEvents btnSUBTRACT As Button
    Friend WithEvents btnMULTIPLY As Button
    Friend WithEvents btnDIVIDE As Button
    Friend WithEvents btnClear As Button
End Class

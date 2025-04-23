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
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnAverage = New System.Windows.Forms.Button()
        Me.btnSum = New System.Windows.Forms.Button()
        Me.lblAverage = New System.Windows.Forms.Label()
        Me.lblSum = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtNum3 = New System.Windows.Forms.TextBox()
        Me.txtNum2 = New System.Windows.Forms.TextBox()
        Me.txtNum1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(265, 187)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(113, 49)
        Me.btnExit.TabIndex = 16
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnAverage
        '
        Me.btnAverage.Location = New System.Drawing.Point(144, 187)
        Me.btnAverage.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnAverage.Name = "btnAverage"
        Me.btnAverage.Size = New System.Drawing.Size(113, 49)
        Me.btnAverage.TabIndex = 15
        Me.btnAverage.Text = "Show &Average"
        Me.btnAverage.UseVisualStyleBackColor = True
        '
        'btnSum
        '
        Me.btnSum.Location = New System.Drawing.Point(23, 187)
        Me.btnSum.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnSum.Name = "btnSum"
        Me.btnSum.Size = New System.Drawing.Size(113, 49)
        Me.btnSum.TabIndex = 14
        Me.btnSum.Text = "Show &Sum"
        Me.btnSum.UseVisualStyleBackColor = True
        '
        'lblAverage
        '
        Me.lblAverage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAverage.Location = New System.Drawing.Point(245, 80)
        Me.lblAverage.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAverage.Name = "lblAverage"
        Me.lblAverage.Size = New System.Drawing.Size(133, 28)
        Me.lblAverage.TabIndex = 18
        Me.lblAverage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblSum
        '
        Me.lblSum.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSum.Location = New System.Drawing.Point(245, 48)
        Me.lblSum.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSum.Name = "lblSum"
        Me.lblSum.Size = New System.Drawing.Size(133, 28)
        Me.lblSum.TabIndex = 17
        Me.lblSum.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(171, 86)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 17)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "Average:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(196, 52)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 17)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Sum:"
        '
        'txtNum3
        '
        Me.txtNum3.Location = New System.Drawing.Point(16, 112)
        Me.txtNum3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtNum3.Name = "txtNum3"
        Me.txtNum3.Size = New System.Drawing.Size(132, 23)
        Me.txtNum3.TabIndex = 13
        '
        'txtNum2
        '
        Me.txtNum2.Location = New System.Drawing.Point(16, 80)
        Me.txtNum2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtNum2.Name = "txtNum2"
        Me.txtNum2.Size = New System.Drawing.Size(132, 23)
        Me.txtNum2.TabIndex = 12
        '
        'txtNum1
        '
        Me.txtNum1.Location = New System.Drawing.Point(16, 48)
        Me.txtNum1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtNum1.Name = "txtNum1"
        Me.txtNum1.Size = New System.Drawing.Size(132, 23)
        Me.txtNum1.TabIndex = 11
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(24, 18)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(113, 17)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Enter 3 numbers"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(395, 254)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnAverage)
        Me.Controls.Add(Me.btnSum)
        Me.Controls.Add(Me.lblAverage)
        Me.Controls.Add(Me.lblSum)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtNum3)
        Me.Controls.Add(Me.txtNum2)
        Me.Controls.Add(Me.txtNum1)
        Me.Controls.Add(Me.Label3)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Form1"
        Me.Text = "Find the Error"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnAverage As System.Windows.Forms.Button
    Friend WithEvents btnSum As System.Windows.Forms.Button
    Friend WithEvents lblAverage As System.Windows.Forms.Label
    Friend WithEvents lblSum As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtNum3 As System.Windows.Forms.TextBox
    Friend WithEvents txtNum2 As System.Windows.Forms.TextBox
    Friend WithEvents txtNum1 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label

End Class

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
        Me.lblMessage = New System.Windows.Forms.Label()
        Me.btnFirst = New System.Windows.Forms.Button()
        Me.btnSecond = New System.Windows.Forms.Button()
        Me.btnThird = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblMessage
        '
        Me.lblMessage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblMessage.Location = New System.Drawing.Point(21, 13)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(260, 31)
        Me.lblMessage.TabIndex = 0
        Me.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnFirst
        '
        Me.btnFirst.Location = New System.Drawing.Point(10, 56)
        Me.btnFirst.Name = "btnFirst"
        Me.btnFirst.Size = New System.Drawing.Size(90, 23)
        Me.btnFirst.TabIndex = 1
        Me.btnFirst.Text = "First Button"
        Me.btnFirst.UseVisualStyleBackColor = True
        '
        'btnSecond
        '
        Me.btnSecond.Location = New System.Drawing.Point(106, 56)
        Me.btnSecond.Name = "btnSecond"
        Me.btnSecond.Size = New System.Drawing.Size(90, 23)
        Me.btnSecond.TabIndex = 2
        Me.btnSecond.Text = "Second Button"
        Me.btnSecond.UseVisualStyleBackColor = True
        '
        'btnThird
        '
        Me.btnThird.Location = New System.Drawing.Point(202, 56)
        Me.btnThird.Name = "btnThird"
        Me.btnThird.Size = New System.Drawing.Size(90, 23)
        Me.btnThird.TabIndex = 3
        Me.btnThird.Text = "Third Button"
        Me.btnThird.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(302, 98)
        Me.Controls.Add(Me.btnThird)
        Me.Controls.Add(Me.btnSecond)
        Me.Controls.Add(Me.btnFirst)
        Me.Controls.Add(Me.lblMessage)
        Me.Name = "Form1"
        Me.Text = "Multiple Buttons"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblMessage As Label
    Friend WithEvents btnFirst As Button
    Friend WithEvents btnSecond As Button
    Friend WithEvents btnThird As Button
End Class

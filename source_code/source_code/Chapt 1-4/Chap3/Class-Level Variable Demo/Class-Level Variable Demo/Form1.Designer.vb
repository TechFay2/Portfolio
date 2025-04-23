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
        Me.btnShowValue = New System.Windows.Forms.Button()
        Me.btnSetValue = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnShowValue
        '
        Me.btnShowValue.Location = New System.Drawing.Point(183, 41)
        Me.btnShowValue.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnShowValue.Name = "btnShowValue"
        Me.btnShowValue.Size = New System.Drawing.Size(100, 28)
        Me.btnShowValue.TabIndex = 7
        Me.btnShowValue.Text = "Show Value"
        Me.btnShowValue.UseVisualStyleBackColor = True
        '
        'btnSetValue
        '
        Me.btnSetValue.Location = New System.Drawing.Point(61, 41)
        Me.btnSetValue.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnSetValue.Name = "btnSetValue"
        Me.btnSetValue.Size = New System.Drawing.Size(100, 28)
        Me.btnSetValue.TabIndex = 6
        Me.btnSetValue.Text = "Set Value"
        Me.btnSetValue.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(345, 110)
        Me.Controls.Add(Me.btnShowValue)
        Me.Controls.Add(Me.btnSetValue)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Form1"
        Me.Text = "Class-Level Variable Demo"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnShowValue As System.Windows.Forms.Button
    Friend WithEvents btnSetValue As System.Windows.Forms.Button

End Class

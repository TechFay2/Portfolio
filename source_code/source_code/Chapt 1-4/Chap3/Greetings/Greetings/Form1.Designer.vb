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
        Me.btnShowGreeting = New System.Windows.Forms.Button()
        Me.lblGreeting = New System.Windows.Forms.Label()
        Me.txtUserName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(201, 172)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(100, 43)
        Me.btnExit.TabIndex = 19
        Me.btnExit.Text = "Exit"
        '
        'btnShowGreeting
        '
        Me.btnShowGreeting.Location = New System.Drawing.Point(84, 172)
        Me.btnShowGreeting.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnShowGreeting.Name = "btnShowGreeting"
        Me.btnShowGreeting.Size = New System.Drawing.Size(100, 43)
        Me.btnShowGreeting.TabIndex = 18
        Me.btnShowGreeting.Text = "Show Greeting"
        '
        'lblGreeting
        '
        Me.lblGreeting.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblGreeting.Location = New System.Drawing.Point(35, 117)
        Me.lblGreeting.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblGreeting.Name = "lblGreeting"
        Me.lblGreeting.Size = New System.Drawing.Size(320, 30)
        Me.lblGreeting.TabIndex = 17
        Me.lblGreeting.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtUserName
        '
        Me.txtUserName.Location = New System.Drawing.Point(77, 68)
        Me.txtUserName.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.Size = New System.Drawing.Size(223, 23)
        Me.txtUserName.TabIndex = 16
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(120, 28)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(128, 28)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Enter Your Name"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(389, 244)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnShowGreeting)
        Me.Controls.Add(Me.lblGreeting)
        Me.Controls.Add(Me.txtUserName)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Form1"
        Me.Text = "Greetings"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnShowGreeting As System.Windows.Forms.Button
    Friend WithEvents lblGreeting As System.Windows.Forms.Label
    Friend WithEvents txtUserName As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class

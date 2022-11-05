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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.LabelWrongsText = New System.Windows.Forms.Label()
        Me.LabelWrongs = New System.Windows.Forms.Label()
        Me.LabelCurrentPi = New System.Windows.Forms.Label()
        Me.LabelPi = New System.Windows.Forms.Label()
        Me.CheckBoxShowHide = New System.Windows.Forms.CheckBox()
        Me.TextBoxCurrentDigit = New System.Windows.Forms.TextBox()
        Me.LabelDigitCountText = New System.Windows.Forms.Label()
        Me.LabelDigitCount = New System.Windows.Forms.Label()
        Me.ButtonReset = New System.Windows.Forms.Button()
        Me.TimerPi = New System.Windows.Forms.Timer(Me.components)
        Me.LabelElapsed = New System.Windows.Forms.Label()
        Me.ButtonStop = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LabelWrongsText
        '
        Me.LabelWrongsText.AutoSize = True
        Me.LabelWrongsText.Location = New System.Drawing.Point(168, 10)
        Me.LabelWrongsText.Name = "LabelWrongsText"
        Me.LabelWrongsText.Size = New System.Drawing.Size(75, 25)
        Me.LabelWrongsText.TabIndex = 0
        Me.LabelWrongsText.Text = "Wrongs"
        '
        'LabelWrongs
        '
        Me.LabelWrongs.AutoSize = True
        Me.LabelWrongs.Location = New System.Drawing.Point(249, 10)
        Me.LabelWrongs.Name = "LabelWrongs"
        Me.LabelWrongs.Size = New System.Drawing.Size(22, 25)
        Me.LabelWrongs.TabIndex = 1
        Me.LabelWrongs.Text = "0"
        '
        'LabelCurrentPi
        '
        Me.LabelCurrentPi.Location = New System.Drawing.Point(10, 42)
        Me.LabelCurrentPi.Name = "LabelCurrentPi"
        Me.LabelCurrentPi.Size = New System.Drawing.Size(649, 242)
        Me.LabelCurrentPi.TabIndex = 2
        Me.LabelCurrentPi.Text = "3."
        '
        'LabelPi
        '
        Me.LabelPi.Location = New System.Drawing.Point(10, 42)
        Me.LabelPi.Name = "LabelPi"
        Me.LabelPi.Size = New System.Drawing.Size(624, 250)
        Me.LabelPi.TabIndex = 3
        Me.LabelPi.Text = resources.GetString("LabelPi.Text")
        Me.LabelPi.UseCompatibleTextRendering = True
        Me.LabelPi.Visible = False
        '
        'CheckBoxShowHide
        '
        Me.CheckBoxShowHide.Appearance = System.Windows.Forms.Appearance.Button
        Me.CheckBoxShowHide.AutoSize = True
        Me.CheckBoxShowHide.Location = New System.Drawing.Point(456, 3)
        Me.CheckBoxShowHide.Name = "CheckBoxShowHide"
        Me.CheckBoxShowHide.Size = New System.Drawing.Size(80, 35)
        Me.CheckBoxShowHide.TabIndex = 4
        Me.CheckBoxShowHide.Text = "&Display"
        Me.CheckBoxShowHide.UseVisualStyleBackColor = True
        '
        'TextBoxCurrentDigit
        '
        Me.TextBoxCurrentDigit.Location = New System.Drawing.Point(10, 4)
        Me.TextBoxCurrentDigit.MaxLength = 1
        Me.TextBoxCurrentDigit.Name = "TextBoxCurrentDigit"
        Me.TextBoxCurrentDigit.Size = New System.Drawing.Size(31, 31)
        Me.TextBoxCurrentDigit.TabIndex = 5
        '
        'LabelDigitCountText
        '
        Me.LabelDigitCountText.AutoSize = True
        Me.LabelDigitCountText.Location = New System.Drawing.Point(292, 10)
        Me.LabelDigitCountText.Name = "LabelDigitCountText"
        Me.LabelDigitCountText.Size = New System.Drawing.Size(103, 25)
        Me.LabelDigitCountText.TabIndex = 6
        Me.LabelDigitCountText.Text = "Digit Count"
        '
        'LabelDigitCount
        '
        Me.LabelDigitCount.AutoSize = True
        Me.LabelDigitCount.Location = New System.Drawing.Point(401, 10)
        Me.LabelDigitCount.Name = "LabelDigitCount"
        Me.LabelDigitCount.Size = New System.Drawing.Size(22, 25)
        Me.LabelDigitCount.TabIndex = 7
        Me.LabelDigitCount.Text = "0"
        '
        'ButtonReset
        '
        Me.ButtonReset.Location = New System.Drawing.Point(542, 4)
        Me.ButtonReset.Name = "ButtonReset"
        Me.ButtonReset.Size = New System.Drawing.Size(78, 34)
        Me.ButtonReset.TabIndex = 8
        Me.ButtonReset.Text = "&Reset"
        Me.ButtonReset.UseVisualStyleBackColor = True
        '
        'TimerPi
        '
        Me.TimerPi.Interval = 1
        '
        'LabelElapsed
        '
        Me.LabelElapsed.AutoSize = True
        Me.LabelElapsed.Location = New System.Drawing.Point(38, 10)
        Me.LabelElapsed.Name = "LabelElapsed"
        Me.LabelElapsed.Size = New System.Drawing.Size(124, 25)
        Me.LabelElapsed.TabIndex = 9
        Me.LabelElapsed.Text = "00:00:00:000"
        '
        'ButtonStop
        '
        Me.ButtonStop.Location = New System.Drawing.Point(626, 4)
        Me.ButtonStop.Name = "ButtonStop"
        Me.ButtonStop.Size = New System.Drawing.Size(78, 34)
        Me.ButtonStop.TabIndex = 10
        Me.ButtonStop.Text = "&Stop"
        Me.ButtonStop.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(715, 280)
        Me.Controls.Add(Me.ButtonStop)
        Me.Controls.Add(Me.LabelElapsed)
        Me.Controls.Add(Me.ButtonReset)
        Me.Controls.Add(Me.LabelDigitCount)
        Me.Controls.Add(Me.LabelDigitCountText)
        Me.Controls.Add(Me.TextBoxCurrentDigit)
        Me.Controls.Add(Me.CheckBoxShowHide)
        Me.Controls.Add(Me.LabelWrongs)
        Me.Controls.Add(Me.LabelWrongsText)
        Me.Controls.Add(Me.LabelCurrentPi)
        Me.Controls.Add(Me.LabelPi)
        Me.Name = "Form1"
        Me.Text = "Pi"
        Me.ResumeLayout(False)
        Me.PerformLayout()
        Me.TextBoxCurrentDigit.Select()
    End Sub

    Friend WithEvents LabelWrongsText As Label
    Friend WithEvents LabelWrongs As Label
    Friend WithEvents LabelCurrentPi As Label
    Friend WithEvents LabelPi As Label
    Friend WithEvents CheckBoxShowHide As CheckBox
    Friend WithEvents TextBoxCurrentDigit As TextBox
    Friend WithEvents LabelDigitCountText As Label
    Friend WithEvents LabelDigitCount As Label
    Friend WithEvents ButtonReset As Button
    Friend WithEvents TimerPi As Timer
    Friend WithEvents LabelElapsed As Label
    Friend WithEvents ButtonStop As Button
End Class

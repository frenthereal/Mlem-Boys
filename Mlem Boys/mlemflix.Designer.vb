<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mlemflix
    Inherits MetroSuite.MetroForm

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(mlemflix))
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.MetroButton1 = New MetroSuite.MetroButton()
        Me.MetroButton2 = New MetroSuite.MetroButton()
        Me.MetroButton3 = New MetroSuite.MetroButton()
        Me.MetroButton4 = New MetroSuite.MetroButton()
        Me.MetroButton5 = New MetroSuite.MetroButton()
        Me.SuspendLayout()
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WebBrowser1.Location = New System.Drawing.Point(0, 0)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(938, 476)
        Me.WebBrowser1.TabIndex = 0
        Me.WebBrowser1.Url = New System.Uri("https://www.youtube.com/watch?v=J5jRWnwPaw4&list=PLAGN1RanQQj-pgKk34gCHAnbQWVbLgL" &
        "cc", System.UriKind.Absolute)
        '
        'MetroButton1
        '
        Me.MetroButton1.BackColor = System.Drawing.Color.Transparent
        Me.MetroButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.MetroButton1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.MetroButton1.DefaultColor = System.Drawing.Color.White
        Me.MetroButton1.DisabledColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.MetroButton1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.MetroButton1.HoverColor = System.Drawing.Color.White
        Me.MetroButton1.Location = New System.Drawing.Point(84, 0)
        Me.MetroButton1.Name = "MetroButton1"
        Me.MetroButton1.PressedColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.MetroButton1.RoundingArc = 10
        Me.MetroButton1.Size = New System.Drawing.Size(70, 10)
        Me.MetroButton1.TabIndex = 1
        Me.MetroButton1.Text = ">"
        '
        'MetroButton2
        '
        Me.MetroButton2.BackColor = System.Drawing.Color.Transparent
        Me.MetroButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.MetroButton2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.MetroButton2.DefaultColor = System.Drawing.Color.White
        Me.MetroButton2.DisabledColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.MetroButton2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.MetroButton2.HoverColor = System.Drawing.Color.White
        Me.MetroButton2.Location = New System.Drawing.Point(12, 0)
        Me.MetroButton2.Name = "MetroButton2"
        Me.MetroButton2.PressedColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.MetroButton2.RoundingArc = 10
        Me.MetroButton2.Size = New System.Drawing.Size(79, 10)
        Me.MetroButton2.TabIndex = 2
        Me.MetroButton2.Text = "<"
        '
        'MetroButton3
        '
        Me.MetroButton3.BackColor = System.Drawing.Color.Transparent
        Me.MetroButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.MetroButton3.BorderColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.MetroButton3.DefaultColor = System.Drawing.Color.White
        Me.MetroButton3.DisabledColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.MetroButton3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.MetroButton3.HoverColor = System.Drawing.Color.White
        Me.MetroButton3.Location = New System.Drawing.Point(842, 0)
        Me.MetroButton3.Name = "MetroButton3"
        Me.MetroButton3.PressedColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.MetroButton3.RoundingArc = 10
        Me.MetroButton3.Size = New System.Drawing.Size(84, 10)
        Me.MetroButton3.TabIndex = 3
        Me.MetroButton3.Text = "Back"
        '
        'MetroButton4
        '
        Me.MetroButton4.BackColor = System.Drawing.Color.Transparent
        Me.MetroButton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.MetroButton4.BorderColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.MetroButton4.DefaultColor = System.Drawing.Color.White
        Me.MetroButton4.DisabledColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.MetroButton4.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.MetroButton4.HoverColor = System.Drawing.Color.White
        Me.MetroButton4.Location = New System.Drawing.Point(761, 0)
        Me.MetroButton4.Name = "MetroButton4"
        Me.MetroButton4.PressedColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.MetroButton4.RoundingArc = 10
        Me.MetroButton4.Size = New System.Drawing.Size(84, 10)
        Me.MetroButton4.TabIndex = 4
        Me.MetroButton4.Text = "Fullscreen"
        '
        'MetroButton5
        '
        Me.MetroButton5.BackColor = System.Drawing.Color.Transparent
        Me.MetroButton5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.MetroButton5.BorderColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.MetroButton5.DefaultColor = System.Drawing.Color.White
        Me.MetroButton5.DisabledColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.MetroButton5.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.MetroButton5.HoverColor = System.Drawing.Color.White
        Me.MetroButton5.Location = New System.Drawing.Point(665, 0)
        Me.MetroButton5.Name = "MetroButton5"
        Me.MetroButton5.PressedColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.MetroButton5.RoundingArc = 10
        Me.MetroButton5.Size = New System.Drawing.Size(101, 10)
        Me.MetroButton5.TabIndex = 5
        Me.MetroButton5.Text = "Quit Fullscreen"
        '
        'mlemflix
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(938, 476)
        Me.Controls.Add(Me.MetroButton5)
        Me.Controls.Add(Me.MetroButton4)
        Me.Controls.Add(Me.MetroButton3)
        Me.Controls.Add(Me.MetroButton2)
        Me.Controls.Add(Me.MetroButton1)
        Me.Controls.Add(Me.WebBrowser1)
        Me.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "mlemflix"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.State = MetroSuite.MetroForm.FormState.Normal
        Me.Style = MetroSuite.Design.Style.Dark
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents WebBrowser1 As WebBrowser
    Friend WithEvents MetroButton1 As MetroSuite.MetroButton
    Friend WithEvents MetroButton2 As MetroSuite.MetroButton
    Friend WithEvents MetroButton3 As MetroSuite.MetroButton
    Friend WithEvents MetroButton4 As MetroSuite.MetroButton
    Friend WithEvents MetroButton5 As MetroSuite.MetroButton
End Class

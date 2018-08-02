<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class pccheck
    Inherits MetroSuite.MetroForm

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(pccheck))
        Me.MetroLabel1 = New MetroSuite.MetroLabel()
        Me.MetroNavigationButton1 = New MetroSuite.MetroNavigationButton()
        Me.MetroLabel2 = New MetroSuite.MetroLabel()
        Me.MetroLabel3 = New MetroSuite.MetroLabel()
        Me.MetroLabel4 = New MetroSuite.MetroLabel()
        Me.MetroLabel5 = New MetroSuite.MetroLabel()
        Me.SuspendLayout()
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.BackColor = System.Drawing.Color.Transparent
        Me.MetroLabel1.Font = New System.Drawing.Font("Comic Sans MS", 20.0!)
        Me.MetroLabel1.Location = New System.Drawing.Point(14, 22)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(97, 38)
        Me.MetroLabel1.TabIndex = 0
        Me.MetroLabel1.Text = "$RAM"
        '
        'MetroNavigationButton1
        '
        Me.MetroNavigationButton1.ArrowColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.MetroNavigationButton1.ArrowHoverColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.MetroNavigationButton1.ArrowPressedColor = System.Drawing.Color.White
        Me.MetroNavigationButton1.AutoStyle = False
        Me.MetroNavigationButton1.BackColor = System.Drawing.Color.Transparent
        Me.MetroNavigationButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.MetroNavigationButton1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.MetroNavigationButton1.BorderHoverColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.MetroNavigationButton1.BorderPressedColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.MetroNavigationButton1.DefaultColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.MetroNavigationButton1.DisabledArrowColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.MetroNavigationButton1.DisabledColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.MetroNavigationButton1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.MetroNavigationButton1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.MetroNavigationButton1.HoverColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.MetroNavigationButton1.Location = New System.Drawing.Point(789, 12)
        Me.MetroNavigationButton1.Name = "MetroNavigationButton1"
        Me.MetroNavigationButton1.PressedColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.MetroNavigationButton1.Size = New System.Drawing.Size(28, 28)
        Me.MetroNavigationButton1.Style = MetroSuite.Design.Style.Dark
        Me.MetroNavigationButton1.TabIndex = 11
        Me.MetroNavigationButton1.Text = "MetroNavigationButton1"
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.BackColor = System.Drawing.Color.Transparent
        Me.MetroLabel2.Font = New System.Drawing.Font("Segoe UI", 30.0!)
        Me.MetroLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MetroLabel2.Location = New System.Drawing.Point(14, 164)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(495, 54)
        Me.MetroLabel2.TabIndex = 12
        Me.MetroLabel2.Text = "YOU CAN RUN THE GAME!"
        Me.MetroLabel2.Visible = False
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.BackColor = System.Drawing.Color.Transparent
        Me.MetroLabel3.Font = New System.Drawing.Font("Segoe UI", 30.0!)
        Me.MetroLabel3.ForeColor = System.Drawing.Color.Red
        Me.MetroLabel3.Location = New System.Drawing.Point(14, 164)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(574, 54)
        Me.MetroLabel3.TabIndex = 13
        Me.MetroLabel3.Text = "YOU CANNOT RUN THE GAME!"
        Me.MetroLabel3.Visible = False
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.BackColor = System.Drawing.Color.Transparent
        Me.MetroLabel4.Font = New System.Drawing.Font("Comic Sans MS", 20.0!)
        Me.MetroLabel4.Location = New System.Drawing.Point(14, 66)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(158, 38)
        Me.MetroLabel4.TabIndex = 14
        Me.MetroLabel4.Text = "$GRAPHIC"
        '
        'MetroLabel5
        '
        Me.MetroLabel5.AutoSize = True
        Me.MetroLabel5.BackColor = System.Drawing.Color.Transparent
        Me.MetroLabel5.Font = New System.Drawing.Font("Comic Sans MS", 20.0!)
        Me.MetroLabel5.Location = New System.Drawing.Point(14, 110)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(86, 38)
        Me.MetroLabel5.TabIndex = 15
        Me.MetroLabel5.Text = "$CPU"
        '
        'pccheck
        '
        Me.AccentColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.AllowResize = False
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(831, 246)
        Me.Controls.Add(Me.MetroLabel5)
        Me.Controls.Add(Me.MetroLabel4)
        Me.Controls.Add(Me.MetroLabel3)
        Me.Controls.Add(Me.MetroLabel2)
        Me.Controls.Add(Me.MetroNavigationButton1)
        Me.Controls.Add(Me.MetroLabel1)
        Me.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "pccheck"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.State = MetroSuite.MetroForm.FormState.Busy
        Me.Style = MetroSuite.Design.Style.Dark
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MetroLabel1 As MetroSuite.MetroLabel
    Friend WithEvents MetroNavigationButton1 As MetroSuite.MetroNavigationButton
    Friend WithEvents MetroLabel2 As MetroSuite.MetroLabel
    Friend WithEvents MetroLabel3 As MetroSuite.MetroLabel
    Friend WithEvents MetroLabel4 As MetroSuite.MetroLabel
    Friend WithEvents MetroLabel5 As MetroSuite.MetroLabel
End Class

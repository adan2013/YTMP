<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MODalb
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MODalb))
        Me.btnok = New System.Windows.Forms.Button()
        Me.txtname = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnwyk = New System.Windows.Forms.Button()
        Me.lblwyk = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnok
        '
        Me.btnok.Location = New System.Drawing.Point(297, 52)
        Me.btnok.Name = "btnok"
        Me.btnok.Size = New System.Drawing.Size(75, 23)
        Me.btnok.TabIndex = 8
        Me.btnok.Text = "Dodaj"
        Me.btnok.UseVisualStyleBackColor = True
        '
        'txtname
        '
        Me.txtname.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.txtname.Location = New System.Drawing.Point(68, 52)
        Me.txtname.MaxLength = 30
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(207, 21)
        Me.txtname.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label1.Location = New System.Drawing.Point(14, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 15)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Nazwa:"
        '
        'btnwyk
        '
        Me.btnwyk.Location = New System.Drawing.Point(12, 15)
        Me.btnwyk.Name = "btnwyk"
        Me.btnwyk.Size = New System.Drawing.Size(50, 23)
        Me.btnwyk.TabIndex = 11
        Me.btnwyk.Text = "Zmień"
        Me.btnwyk.UseVisualStyleBackColor = True
        '
        'lblwyk
        '
        Me.lblwyk.AutoSize = True
        Me.lblwyk.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lblwyk.Location = New System.Drawing.Point(71, 18)
        Me.lblwyk.Margin = New System.Windows.Forms.Padding(6, 6, 3, 0)
        Me.lblwyk.Name = "lblwyk"
        Me.lblwyk.Size = New System.Drawing.Size(39, 17)
        Me.lblwyk.TabIndex = 10
        Me.lblwyk.Text = "WYK"
        '
        'MODalb
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(384, 92)
        Me.Controls.Add(Me.btnwyk)
        Me.Controls.Add(Me.lblwyk)
        Me.Controls.Add(Me.btnok)
        Me.Controls.Add(Me.txtname)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MODalb"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Nowy album"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnok As Button
    Friend WithEvents txtname As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnwyk As Button
    Friend WithEvents lblwyk As Label
End Class

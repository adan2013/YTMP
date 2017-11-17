<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MODpl
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MODpl))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtname = New System.Windows.Forms.TextBox()
        Me.btnok = New System.Windows.Forms.Button()
        Me.btndodaj = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nazwa:"
        '
        'txtname
        '
        Me.txtname.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.txtname.Location = New System.Drawing.Point(15, 27)
        Me.txtname.MaxLength = 30
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(207, 21)
        Me.txtname.TabIndex = 1
        '
        'btnok
        '
        Me.btnok.Location = New System.Drawing.Point(147, 76)
        Me.btnok.Name = "btnok"
        Me.btnok.Size = New System.Drawing.Size(75, 23)
        Me.btnok.TabIndex = 2
        Me.btnok.Text = "Dodaj"
        Me.btnok.UseVisualStyleBackColor = True
        '
        'btndodaj
        '
        Me.btndodaj.Location = New System.Drawing.Point(15, 64)
        Me.btndodaj.Name = "btndodaj"
        Me.btndodaj.Size = New System.Drawing.Size(109, 35)
        Me.btndodaj.TabIndex = 3
        Me.btndodaj.Text = "Dodaj nowe utwory do playlisty"
        Me.btndodaj.UseVisualStyleBackColor = True
        Me.btndodaj.Visible = False
        '
        'MODpl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(234, 111)
        Me.Controls.Add(Me.btndodaj)
        Me.Controls.Add(Me.btnok)
        Me.Controls.Add(Me.txtname)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MODpl"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Nowa playlista"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtname As TextBox
    Friend WithEvents btnok As Button
    Friend WithEvents btndodaj As Button
End Class

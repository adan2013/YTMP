<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class newitemform
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(newitemform))
        Me.btnW = New System.Windows.Forms.Button()
        Me.btnA = New System.Windows.Forms.Button()
        Me.btnU = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnW
        '
        Me.btnW.BackColor = System.Drawing.SystemColors.Control
        Me.btnW.FlatAppearance.BorderSize = 2
        Me.btnW.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkRed
        Me.btnW.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.btnW.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnW.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.btnW.Image = Global.YTMP.My.Resources.Resources.man_user
        Me.btnW.Location = New System.Drawing.Point(12, 12)
        Me.btnW.Name = "btnW"
        Me.btnW.Size = New System.Drawing.Size(138, 138)
        Me.btnW.TabIndex = 0
        Me.btnW.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Wykonawca"
        Me.btnW.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnW.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnW.UseVisualStyleBackColor = False
        '
        'btnA
        '
        Me.btnA.FlatAppearance.BorderSize = 2
        Me.btnA.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkRed
        Me.btnA.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.btnA.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnA.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.btnA.Image = Global.YTMP.My.Resources.Resources.music_album
        Me.btnA.Location = New System.Drawing.Point(156, 12)
        Me.btnA.Name = "btnA"
        Me.btnA.Size = New System.Drawing.Size(138, 138)
        Me.btnA.TabIndex = 1
        Me.btnA.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Album"
        Me.btnA.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnA.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnA.UseVisualStyleBackColor = True
        '
        'btnU
        '
        Me.btnU.FlatAppearance.BorderSize = 2
        Me.btnU.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkRed
        Me.btnU.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.btnU.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnU.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.btnU.Image = Global.YTMP.My.Resources.Resources.music_file
        Me.btnU.Location = New System.Drawing.Point(300, 12)
        Me.btnU.Name = "btnU"
        Me.btnU.Size = New System.Drawing.Size(138, 138)
        Me.btnU.TabIndex = 2
        Me.btnU.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Utwór"
        Me.btnU.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnU.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnU.UseVisualStyleBackColor = True
        '
        'newitemform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(454, 162)
        Me.Controls.Add(Me.btnU)
        Me.Controls.Add(Me.btnA)
        Me.Controls.Add(Me.btnW)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "newitemform"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Dodaj nowy"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnW As Button
    Friend WithEvents btnA As Button
    Friend WithEvents btnU As Button
End Class

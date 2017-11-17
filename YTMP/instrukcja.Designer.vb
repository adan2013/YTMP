<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class instrukcja
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(instrukcja))
        Me.img = New System.Windows.Forms.PictureBox()
        Me.btnnext = New System.Windows.Forms.Button()
        Me.btnprev = New System.Windows.Forms.Button()
        Me.btnskip = New System.Windows.Forms.Button()
        Me.lbltytul = New System.Windows.Forms.Label()
        Me.lblopis = New System.Windows.Forms.Label()
        CType(Me.img, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'img
        '
        Me.img.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.img.Location = New System.Drawing.Point(12, 12)
        Me.img.Name = "img"
        Me.img.Size = New System.Drawing.Size(400, 300)
        Me.img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.img.TabIndex = 0
        Me.img.TabStop = False
        '
        'btnnext
        '
        Me.btnnext.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.btnnext.Location = New System.Drawing.Point(632, 322)
        Me.btnnext.Name = "btnnext"
        Me.btnnext.Size = New System.Drawing.Size(90, 28)
        Me.btnnext.TabIndex = 1
        Me.btnnext.Text = "Dalej   >"
        Me.btnnext.UseVisualStyleBackColor = True
        '
        'btnprev
        '
        Me.btnprev.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.btnprev.Location = New System.Drawing.Point(536, 322)
        Me.btnprev.Name = "btnprev"
        Me.btnprev.Size = New System.Drawing.Size(90, 28)
        Me.btnprev.TabIndex = 2
        Me.btnprev.Text = "<   Wstecz"
        Me.btnprev.UseVisualStyleBackColor = True
        '
        'btnskip
        '
        Me.btnskip.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.btnskip.Location = New System.Drawing.Point(12, 322)
        Me.btnskip.Name = "btnskip"
        Me.btnskip.Size = New System.Drawing.Size(90, 28)
        Me.btnskip.TabIndex = 3
        Me.btnskip.Text = "Pomiń"
        Me.btnskip.UseVisualStyleBackColor = True
        '
        'lbltytul
        '
        Me.lbltytul.AutoSize = True
        Me.lbltytul.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lbltytul.Location = New System.Drawing.Point(418, 16)
        Me.lbltytul.Name = "lbltytul"
        Me.lbltytul.Size = New System.Drawing.Size(74, 24)
        Me.lbltytul.TabIndex = 4
        Me.lbltytul.Text = "TYTUŁ"
        '
        'lblopis
        '
        Me.lblopis.AutoSize = True
        Me.lblopis.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lblopis.Location = New System.Drawing.Point(420, 47)
        Me.lblopis.Name = "lblopis"
        Me.lblopis.Size = New System.Drawing.Size(40, 17)
        Me.lblopis.TabIndex = 5
        Me.lblopis.Text = "OPIS"
        '
        'instrukcja
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(734, 362)
        Me.Controls.Add(Me.lblopis)
        Me.Controls.Add(Me.lbltytul)
        Me.Controls.Add(Me.btnskip)
        Me.Controls.Add(Me.btnprev)
        Me.Controls.Add(Me.btnnext)
        Me.Controls.Add(Me.img)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "instrukcja"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "YTMP - Wprowadzenie"
        CType(Me.img, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents img As PictureBox
    Friend WithEvents btnnext As Button
    Friend WithEvents btnprev As Button
    Friend WithEvents btnskip As Button
    Friend WithEvents lbltytul As Label
    Friend WithEvents lblopis As Label
End Class

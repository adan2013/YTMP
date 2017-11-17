<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ytbrowser
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ytbrowser))
        Me.btnback = New System.Windows.Forms.Button()
        Me.txturl = New System.Windows.Forms.TextBox()
        Me.btnaddutw = New System.Windows.Forms.Button()
        Me.lblinfo = New System.Windows.Forms.Label()
        Me.btnhome = New System.Windows.Forms.Button()
        Me.akt = New System.Windows.Forms.Timer(Me.components)
        Me.btnaddpl = New System.Windows.Forms.Button()
        Me.btnforward = New System.Windows.Forms.Button()
        Me.btnreload = New System.Windows.Forms.Button()
        Me.btncanceledit = New System.Windows.Forms.Button()
        Me.btnokedit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnback
        '
        Me.btnback.Image = Global.YTMP.My.Resources.Resources.left_arrow_browser
        Me.btnback.Location = New System.Drawing.Point(12, 12)
        Me.btnback.Name = "btnback"
        Me.btnback.Size = New System.Drawing.Size(60, 30)
        Me.btnback.TabIndex = 0
        Me.btnback.UseVisualStyleBackColor = True
        '
        'txturl
        '
        Me.txturl.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.txturl.Location = New System.Drawing.Point(278, 13)
        Me.txturl.Margin = New System.Windows.Forms.Padding(5, 3, 3, 3)
        Me.txturl.Name = "txturl"
        Me.txturl.ReadOnly = True
        Me.txturl.Size = New System.Drawing.Size(744, 29)
        Me.txturl.TabIndex = 1
        '
        'btnaddutw
        '
        Me.btnaddutw.Image = Global.YTMP.My.Resources.Resources.video_camera
        Me.btnaddutw.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnaddutw.Location = New System.Drawing.Point(912, 620)
        Me.btnaddutw.Name = "btnaddutw"
        Me.btnaddutw.Padding = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.btnaddutw.Size = New System.Drawing.Size(110, 30)
        Me.btnaddutw.TabIndex = 2
        Me.btnaddutw.Text = "Dodaj utwór"
        Me.btnaddutw.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnaddutw.UseVisualStyleBackColor = True
        '
        'lblinfo
        '
        Me.lblinfo.AutoSize = True
        Me.lblinfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lblinfo.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblinfo.Location = New System.Drawing.Point(12, 629)
        Me.lblinfo.Name = "lblinfo"
        Me.lblinfo.Size = New System.Drawing.Size(673, 17)
        Me.lblinfo.TabIndex = 3
        Me.lblinfo.Text = "Znajdź i przejdź do interesującego Ciebie filmiku lub playlisty, a następnie doda" &
    "j go do biblioteki programu"
        '
        'btnhome
        '
        Me.btnhome.Image = Global.YTMP.My.Resources.Resources.home
        Me.btnhome.Location = New System.Drawing.Point(144, 12)
        Me.btnhome.Name = "btnhome"
        Me.btnhome.Size = New System.Drawing.Size(60, 30)
        Me.btnhome.TabIndex = 4
        Me.btnhome.UseVisualStyleBackColor = True
        '
        'akt
        '
        Me.akt.Enabled = True
        '
        'btnaddpl
        '
        Me.btnaddpl.Image = Global.YTMP.My.Resources.Resources.playlist_add
        Me.btnaddpl.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnaddpl.Location = New System.Drawing.Point(786, 620)
        Me.btnaddpl.Name = "btnaddpl"
        Me.btnaddpl.Padding = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.btnaddpl.Size = New System.Drawing.Size(120, 30)
        Me.btnaddpl.TabIndex = 5
        Me.btnaddpl.Text = "Dodaj playlistę"
        Me.btnaddpl.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnaddpl.UseVisualStyleBackColor = True
        '
        'btnforward
        '
        Me.btnforward.Image = Global.YTMP.My.Resources.Resources.right_arrow_browser
        Me.btnforward.Location = New System.Drawing.Point(78, 12)
        Me.btnforward.Name = "btnforward"
        Me.btnforward.Size = New System.Drawing.Size(60, 30)
        Me.btnforward.TabIndex = 6
        Me.btnforward.UseVisualStyleBackColor = True
        '
        'btnreload
        '
        Me.btnreload.Image = Global.YTMP.My.Resources.Resources.rotate_option
        Me.btnreload.Location = New System.Drawing.Point(210, 13)
        Me.btnreload.Name = "btnreload"
        Me.btnreload.Size = New System.Drawing.Size(60, 30)
        Me.btnreload.TabIndex = 7
        Me.btnreload.UseVisualStyleBackColor = True
        '
        'btncanceledit
        '
        Me.btncanceledit.Image = Global.YTMP.My.Resources.Resources.remove_symbol
        Me.btncanceledit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btncanceledit.Location = New System.Drawing.Point(786, 584)
        Me.btncanceledit.Name = "btncanceledit"
        Me.btncanceledit.Padding = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.btncanceledit.Size = New System.Drawing.Size(120, 30)
        Me.btncanceledit.TabIndex = 8
        Me.btncanceledit.Text = "Anuluj edycję"
        Me.btncanceledit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btncanceledit.UseVisualStyleBackColor = True
        Me.btncanceledit.Visible = False
        '
        'btnokedit
        '
        Me.btnokedit.Enabled = False
        Me.btnokedit.Image = Global.YTMP.My.Resources.Resources.ok_black
        Me.btnokedit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnokedit.Location = New System.Drawing.Point(912, 584)
        Me.btnokedit.Name = "btnokedit"
        Me.btnokedit.Padding = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.btnokedit.Size = New System.Drawing.Size(110, 30)
        Me.btnokedit.TabIndex = 9
        Me.btnokedit.Text = "Zatwierdź"
        Me.btnokedit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnokedit.UseVisualStyleBackColor = True
        Me.btnokedit.Visible = False
        '
        'ytbrowser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GrayText
        Me.ClientSize = New System.Drawing.Size(1034, 662)
        Me.Controls.Add(Me.btnokedit)
        Me.Controls.Add(Me.btncanceledit)
        Me.Controls.Add(Me.btnreload)
        Me.Controls.Add(Me.btnforward)
        Me.Controls.Add(Me.btnaddpl)
        Me.Controls.Add(Me.btnhome)
        Me.Controls.Add(Me.lblinfo)
        Me.Controls.Add(Me.btnaddutw)
        Me.Controls.Add(Me.txturl)
        Me.Controls.Add(Me.btnback)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(1050, 700)
        Me.Name = "ytbrowser"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "YouTube browser - YTMP"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnback As Button
    Friend WithEvents txturl As TextBox
    Friend WithEvents btnaddutw As Button
    Friend WithEvents lblinfo As Label
    Friend WithEvents btnhome As Button
    Friend WithEvents akt As Timer
    Friend WithEvents btnaddpl As Button
    Friend WithEvents btnforward As Button
    Friend WithEvents btnreload As Button
    Friend WithEvents btncanceledit As Button
    Friend WithEvents btnokedit As Button
End Class

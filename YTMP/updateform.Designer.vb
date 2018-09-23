<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class updateform
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(updateform))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lbltytul = New System.Windows.Forms.Label()
        Me.lblopis = New System.Windows.Forms.Label()
        Me.linkgithub = New System.Windows.Forms.LinkLabel()
        Me.btn3 = New System.Windows.Forms.Button()
        Me.btn2 = New System.Windows.Forms.Button()
        Me.pnlback = New System.Windows.Forms.Panel()
        Me.lblproc = New System.Windows.Forms.Label()
        Me.ruch = New System.Windows.Forms.Timer(Me.components)
        Me.btn1 = New System.Windows.Forms.Button()
        Me.BWunzip = New System.ComponentModel.BackgroundWorker()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.YTMP.My.Resources.Resources.logo128
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(128, 128)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'lbltytul
        '
        Me.lbltytul.AutoSize = True
        Me.lbltytul.Font = New System.Drawing.Font("Trebuchet MS", 17.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lbltytul.Location = New System.Drawing.Point(147, 21)
        Me.lbltytul.Name = "lbltytul"
        Me.lbltytul.Size = New System.Drawing.Size(465, 28)
        Me.lbltytul.TabIndex = 1
        Me.lbltytul.Text = "Dostępna jest nowa wersja aplikacji YTMP"
        '
        'lblopis
        '
        Me.lblopis.AutoSize = True
        Me.lblopis.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lblopis.Location = New System.Drawing.Point(148, 62)
        Me.lblopis.Name = "lblopis"
        Me.lblopis.Size = New System.Drawing.Size(449, 38)
        Me.lblopis.TabIndex = 2
        Me.lblopis.Text = "Możesz ją zainstalować samodzielnie pobierając jej pliki z serwisu GitHub" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "lub sk" &
    "orzystać z automatycznej aktualizacji"
        '
        'linkgithub
        '
        Me.linkgithub.AutoSize = True
        Me.linkgithub.Cursor = System.Windows.Forms.Cursors.Hand
        Me.linkgithub.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.linkgithub.Location = New System.Drawing.Point(149, 125)
        Me.linkgithub.Name = "linkgithub"
        Me.linkgithub.Size = New System.Drawing.Size(243, 15)
        Me.linkgithub.TabIndex = 3
        Me.linkgithub.TabStop = True
        Me.linkgithub.Text = "Przejdź do repozytorium YTMP na GitHubie"
        '
        'btn3
        '
        Me.btn3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.btn3.Location = New System.Drawing.Point(492, 180)
        Me.btn3.Name = "btn3"
        Me.btn3.Size = New System.Drawing.Size(140, 30)
        Me.btn3.TabIndex = 4
        Me.btn3.Text = "Pobierz aktualizację"
        Me.btn3.UseVisualStyleBackColor = True
        '
        'btn2
        '
        Me.btn2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.btn2.Location = New System.Drawing.Point(346, 180)
        Me.btn2.Name = "btn2"
        Me.btn2.Size = New System.Drawing.Size(140, 30)
        Me.btn2.TabIndex = 5
        Me.btn2.Text = "Odłóż na później"
        Me.btn2.UseVisualStyleBackColor = True
        '
        'pnlback
        '
        Me.pnlback.BackColor = System.Drawing.Color.Gainsboro
        Me.pnlback.Location = New System.Drawing.Point(152, 103)
        Me.pnlback.Name = "pnlback"
        Me.pnlback.Size = New System.Drawing.Size(480, 16)
        Me.pnlback.TabIndex = 6
        '
        'lblproc
        '
        Me.lblproc.AutoSize = True
        Me.lblproc.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lblproc.Location = New System.Drawing.Point(149, 122)
        Me.lblproc.Name = "lblproc"
        Me.lblproc.Size = New System.Drawing.Size(23, 15)
        Me.lblproc.TabIndex = 7
        Me.lblproc.Text = "0%"
        '
        'ruch
        '
        Me.ruch.Interval = 4
        '
        'btn1
        '
        Me.btn1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.btn1.Location = New System.Drawing.Point(200, 180)
        Me.btn1.Name = "btn1"
        Me.btn1.Size = New System.Drawing.Size(140, 30)
        Me.btn1.TabIndex = 8
        Me.btn1.Text = "Usuń ją z komputera"
        Me.btn1.UseVisualStyleBackColor = True
        '
        'BWunzip
        '
        '
        'updateform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.ClientSize = New System.Drawing.Size(644, 223)
        Me.Controls.Add(Me.linkgithub)
        Me.Controls.Add(Me.btn1)
        Me.Controls.Add(Me.lblproc)
        Me.Controls.Add(Me.pnlback)
        Me.Controls.Add(Me.btn2)
        Me.Controls.Add(Me.btn3)
        Me.Controls.Add(Me.lblopis)
        Me.Controls.Add(Me.lbltytul)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "updateform"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Aktualizacja"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lbltytul As Label
    Friend WithEvents lblopis As Label
    Friend WithEvents linkgithub As LinkLabel
    Friend WithEvents btn3 As Button
    Friend WithEvents btn2 As Button
    Friend WithEvents pnlback As Panel
    Friend WithEvents lblproc As Label
    Friend WithEvents ruch As Timer
    Friend WithEvents btn1 As Button
    Friend WithEvents BWunzip As System.ComponentModel.BackgroundWorker
End Class

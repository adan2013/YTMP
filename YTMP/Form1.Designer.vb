﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Me.tabs = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.pnlodtwarzacz = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.pnlsound = New System.Windows.Forms.Panel()
        Me.btnmute = New System.Windows.Forms.PictureBox()
        Me.pnlrewind = New System.Windows.Forms.Panel()
        Me.btnrep = New System.Windows.Forms.PictureBox()
        Me.btnran = New System.Windows.Forms.PictureBox()
        Me.btnsettings = New System.Windows.Forms.PictureBox()
        Me.btnrewindR = New System.Windows.Forms.PictureBox()
        Me.btnrewindL = New System.Windows.Forms.PictureBox()
        Me.btnplay = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnwyczysc = New System.Windows.Forms.Button()
        Me.btnodtwall = New System.Windows.Forms.Button()
        Me.btndodaj = New System.Windows.Forms.Button()
        Me.btncofnij = New System.Windows.Forms.Button()
        Me.lblinfo = New System.Windows.Forms.Label()
        Me.pnllista = New System.Windows.Forms.Panel()
        Me.txtsearch = New System.Windows.Forms.TextBox()
        Me.akt = New System.Windows.Forms.Timer(Me.components)
        Me.notify = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.contextnotify = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.PlayPauseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PoprzedniUtwórToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NastępnyUtwórToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.WyciszOdciszToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ZmniejszGłośnośćToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ZwiększGłośnośćToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ZakończToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnsearchoff = New System.Windows.Forms.Button()
        Me.tabs.SuspendLayout()
        Me.pnlodtwarzacz.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnmute, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnrep, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnran, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnsettings, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnrewindR, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnrewindL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnplay, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.contextnotify.SuspendLayout()
        Me.SuspendLayout()
        '
        'tabs
        '
        Me.tabs.Controls.Add(Me.TabPage1)
        Me.tabs.Controls.Add(Me.TabPage2)
        Me.tabs.Controls.Add(Me.TabPage3)
        Me.tabs.Location = New System.Drawing.Point(23, 12)
        Me.tabs.Name = "tabs"
        Me.tabs.Padding = New System.Drawing.Point(14, 8)
        Me.tabs.SelectedIndex = 0
        Me.tabs.Size = New System.Drawing.Size(270, 29)
        Me.tabs.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Location = New System.Drawing.Point(4, 32)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(262, 0)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Lista odtwarzania"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Location = New System.Drawing.Point(4, 32)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(262, 0)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Utwory"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.Location = New System.Drawing.Point(4, 32)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(262, 0)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Playlisty"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'pnlodtwarzacz
        '
        Me.pnlodtwarzacz.BackColor = System.Drawing.Color.White
        Me.pnlodtwarzacz.Controls.Add(Me.PictureBox1)
        Me.pnlodtwarzacz.Controls.Add(Me.pnlsound)
        Me.pnlodtwarzacz.Controls.Add(Me.btnmute)
        Me.pnlodtwarzacz.Controls.Add(Me.pnlrewind)
        Me.pnlodtwarzacz.Controls.Add(Me.btnrep)
        Me.pnlodtwarzacz.Controls.Add(Me.btnran)
        Me.pnlodtwarzacz.Controls.Add(Me.btnsettings)
        Me.pnlodtwarzacz.Controls.Add(Me.btnrewindR)
        Me.pnlodtwarzacz.Controls.Add(Me.btnrewindL)
        Me.pnlodtwarzacz.Controls.Add(Me.btnplay)
        Me.pnlodtwarzacz.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlodtwarzacz.Location = New System.Drawing.Point(0, 366)
        Me.pnlodtwarzacz.Name = "pnlodtwarzacz"
        Me.pnlodtwarzacz.Size = New System.Drawing.Size(534, 120)
        Me.pnlodtwarzacz.TabIndex = 1
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(399, 94)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(17, 17)
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'pnlsound
        '
        Me.pnlsound.BackColor = System.Drawing.Color.LightGray
        Me.pnlsound.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlsound.Location = New System.Drawing.Point(422, 94)
        Me.pnlsound.Name = "pnlsound"
        Me.pnlsound.Size = New System.Drawing.Size(100, 17)
        Me.pnlsound.TabIndex = 7
        '
        'btnmute
        '
        Me.btnmute.BackColor = System.Drawing.Color.LightGray
        Me.btnmute.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.btnmute.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnmute.Image = CType(resources.GetObject("btnmute.Image"), System.Drawing.Image)
        Me.btnmute.Location = New System.Drawing.Point(364, 53)
        Me.btnmute.Name = "btnmute"
        Me.btnmute.Size = New System.Drawing.Size(35, 35)
        Me.btnmute.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.btnmute.TabIndex = 9
        Me.btnmute.TabStop = False
        '
        'pnlrewind
        '
        Me.pnlrewind.BackColor = System.Drawing.Color.LightGray
        Me.pnlrewind.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlrewind.Location = New System.Drawing.Point(60, 10)
        Me.pnlrewind.Name = "pnlrewind"
        Me.pnlrewind.Size = New System.Drawing.Size(414, 20)
        Me.pnlrewind.TabIndex = 6
        '
        'btnrep
        '
        Me.btnrep.BackColor = System.Drawing.Color.LightGray
        Me.btnrep.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.btnrep.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnrep.Image = CType(resources.GetObject("btnrep.Image"), System.Drawing.Image)
        Me.btnrep.Location = New System.Drawing.Point(405, 53)
        Me.btnrep.Name = "btnrep"
        Me.btnrep.Size = New System.Drawing.Size(35, 35)
        Me.btnrep.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.btnrep.TabIndex = 5
        Me.btnrep.TabStop = False
        '
        'btnran
        '
        Me.btnran.BackColor = System.Drawing.Color.LightGray
        Me.btnran.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.btnran.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnran.Image = CType(resources.GetObject("btnran.Image"), System.Drawing.Image)
        Me.btnran.Location = New System.Drawing.Point(446, 53)
        Me.btnran.Name = "btnran"
        Me.btnran.Size = New System.Drawing.Size(35, 35)
        Me.btnran.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.btnran.TabIndex = 4
        Me.btnran.TabStop = False
        '
        'btnsettings
        '
        Me.btnsettings.BackColor = System.Drawing.Color.LightGray
        Me.btnsettings.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.btnsettings.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnsettings.Image = CType(resources.GetObject("btnsettings.Image"), System.Drawing.Image)
        Me.btnsettings.Location = New System.Drawing.Point(487, 53)
        Me.btnsettings.Name = "btnsettings"
        Me.btnsettings.Size = New System.Drawing.Size(35, 35)
        Me.btnsettings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.btnsettings.TabIndex = 3
        Me.btnsettings.TabStop = False
        '
        'btnrewindR
        '
        Me.btnrewindR.BackColor = System.Drawing.Color.LightGray
        Me.btnrewindR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.btnrewindR.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnrewindR.Image = CType(resources.GetObject("btnrewindR.Image"), System.Drawing.Image)
        Me.btnrewindR.Location = New System.Drawing.Point(109, 53)
        Me.btnrewindR.Name = "btnrewindR"
        Me.btnrewindR.Size = New System.Drawing.Size(35, 35)
        Me.btnrewindR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.btnrewindR.TabIndex = 2
        Me.btnrewindR.TabStop = False
        '
        'btnrewindL
        '
        Me.btnrewindL.BackColor = System.Drawing.Color.LightGray
        Me.btnrewindL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.btnrewindL.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnrewindL.Image = CType(resources.GetObject("btnrewindL.Image"), System.Drawing.Image)
        Me.btnrewindL.Location = New System.Drawing.Point(68, 53)
        Me.btnrewindL.Name = "btnrewindL"
        Me.btnrewindL.Size = New System.Drawing.Size(35, 35)
        Me.btnrewindL.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.btnrewindL.TabIndex = 1
        Me.btnrewindL.TabStop = False
        '
        'btnplay
        '
        Me.btnplay.BackColor = System.Drawing.Color.LightGray
        Me.btnplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.btnplay.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnplay.Image = CType(resources.GetObject("btnplay.Image"), System.Drawing.Image)
        Me.btnplay.Location = New System.Drawing.Point(12, 38)
        Me.btnplay.Name = "btnplay"
        Me.btnplay.Size = New System.Drawing.Size(50, 50)
        Me.btnplay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.btnplay.TabIndex = 0
        Me.btnplay.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.btnwyczysc)
        Me.Panel1.Controls.Add(Me.btnodtwall)
        Me.Panel1.Controls.Add(Me.btndodaj)
        Me.Panel1.Controls.Add(Me.btncofnij)
        Me.Panel1.Controls.Add(Me.lblinfo)
        Me.Panel1.Controls.Add(Me.pnllista)
        Me.Panel1.Location = New System.Drawing.Point(12, 42)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(510, 313)
        Me.Panel1.TabIndex = 2
        '
        'btnwyczysc
        '
        Me.btnwyczysc.Enabled = False
        Me.btnwyczysc.Image = CType(resources.GetObject("btnwyczysc.Image"), System.Drawing.Image)
        Me.btnwyczysc.Location = New System.Drawing.Point(11, 161)
        Me.btnwyczysc.Margin = New System.Windows.Forms.Padding(3, 3, 3, 0)
        Me.btnwyczysc.Name = "btnwyczysc"
        Me.btnwyczysc.Size = New System.Drawing.Size(75, 60)
        Me.btnwyczysc.TabIndex = 10
        Me.btnwyczysc.TabStop = False
        Me.btnwyczysc.Text = "Wyczyść"
        Me.btnwyczysc.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnwyczysc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnwyczysc.UseVisualStyleBackColor = True
        '
        'btnodtwall
        '
        Me.btnodtwall.Enabled = False
        Me.btnodtwall.Image = CType(resources.GetObject("btnodtwall.Image"), System.Drawing.Image)
        Me.btnodtwall.Location = New System.Drawing.Point(11, 224)
        Me.btnodtwall.Margin = New System.Windows.Forms.Padding(3, 3, 3, 0)
        Me.btnodtwall.Name = "btnodtwall"
        Me.btnodtwall.Size = New System.Drawing.Size(75, 70)
        Me.btnodtwall.TabIndex = 9
        Me.btnodtwall.TabStop = False
        Me.btnodtwall.Text = "Odtwórz wszystkie"
        Me.btnodtwall.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnodtwall.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnodtwall.UseVisualStyleBackColor = True
        '
        'btndodaj
        '
        Me.btndodaj.Enabled = False
        Me.btndodaj.Image = CType(resources.GetObject("btndodaj.Image"), System.Drawing.Image)
        Me.btndodaj.Location = New System.Drawing.Point(11, 98)
        Me.btndodaj.Margin = New System.Windows.Forms.Padding(3, 3, 3, 0)
        Me.btndodaj.Name = "btndodaj"
        Me.btndodaj.Size = New System.Drawing.Size(75, 60)
        Me.btndodaj.TabIndex = 7
        Me.btndodaj.TabStop = False
        Me.btndodaj.Text = "Dodaj nowy"
        Me.btndodaj.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btndodaj.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btndodaj.UseVisualStyleBackColor = True
        '
        'btncofnij
        '
        Me.btncofnij.Enabled = False
        Me.btncofnij.Image = CType(resources.GetObject("btncofnij.Image"), System.Drawing.Image)
        Me.btncofnij.Location = New System.Drawing.Point(11, 35)
        Me.btncofnij.Margin = New System.Windows.Forms.Padding(3, 3, 3, 0)
        Me.btncofnij.Name = "btncofnij"
        Me.btncofnij.Size = New System.Drawing.Size(75, 60)
        Me.btncofnij.TabIndex = 6
        Me.btncofnij.TabStop = False
        Me.btncofnij.Text = "Cofnij"
        Me.btncofnij.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btncofnij.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btncofnij.UseVisualStyleBackColor = True
        '
        'lblinfo
        '
        Me.lblinfo.AutoSize = True
        Me.lblinfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lblinfo.Location = New System.Drawing.Point(94, 10)
        Me.lblinfo.Name = "lblinfo"
        Me.lblinfo.Size = New System.Drawing.Size(94, 15)
        Me.lblinfo.TabIndex = 5
        Me.lblinfo.Text = "Ilość utworów: 0"
        '
        'pnllista
        '
        Me.pnllista.AutoScroll = True
        Me.pnllista.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnllista.Location = New System.Drawing.Point(91, 35)
        Me.pnllista.Margin = New System.Windows.Forms.Padding(10)
        Me.pnllista.Name = "pnllista"
        Me.pnllista.Size = New System.Drawing.Size(409, 268)
        Me.pnllista.TabIndex = 5
        '
        'txtsearch
        '
        Me.txtsearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.txtsearch.ForeColor = System.Drawing.Color.Gray
        Me.txtsearch.Location = New System.Drawing.Point(342, 13)
        Me.txtsearch.Name = "txtsearch"
        Me.txtsearch.Size = New System.Drawing.Size(180, 23)
        Me.txtsearch.TabIndex = 99
        Me.txtsearch.TabStop = False
        Me.txtsearch.Text = "Szukaj..."
        '
        'akt
        '
        Me.akt.Interval = 300
        '
        'notify
        '
        Me.notify.BalloonTipTitle = "YouTubeMediaPlayer"
        Me.notify.ContextMenuStrip = Me.contextnotify
        Me.notify.Icon = CType(resources.GetObject("notify.Icon"), System.Drawing.Icon)
        Me.notify.Text = "YouTubeMediaPlayer"
        Me.notify.Visible = True
        '
        'contextnotify
        '
        Me.contextnotify.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PlayPauseToolStripMenuItem, Me.PoprzedniUtwórToolStripMenuItem, Me.NastępnyUtwórToolStripMenuItem, Me.ToolStripMenuItem1, Me.WyciszOdciszToolStripMenuItem, Me.ZmniejszGłośnośćToolStripMenuItem, Me.ZwiększGłośnośćToolStripMenuItem, Me.ToolStripMenuItem2, Me.ZakończToolStripMenuItem})
        Me.contextnotify.Name = "contextnotify"
        Me.contextnotify.Size = New System.Drawing.Size(172, 170)
        '
        'PlayPauseToolStripMenuItem
        '
        Me.PlayPauseToolStripMenuItem.Name = "PlayPauseToolStripMenuItem"
        Me.PlayPauseToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.PlayPauseToolStripMenuItem.Text = "Play/Pause"
        '
        'PoprzedniUtwórToolStripMenuItem
        '
        Me.PoprzedniUtwórToolStripMenuItem.Name = "PoprzedniUtwórToolStripMenuItem"
        Me.PoprzedniUtwórToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.PoprzedniUtwórToolStripMenuItem.Text = "Poprzedni utwór"
        '
        'NastępnyUtwórToolStripMenuItem
        '
        Me.NastępnyUtwórToolStripMenuItem.Name = "NastępnyUtwórToolStripMenuItem"
        Me.NastępnyUtwórToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.NastępnyUtwórToolStripMenuItem.Text = "Następny utwór"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(168, 6)
        '
        'WyciszOdciszToolStripMenuItem
        '
        Me.WyciszOdciszToolStripMenuItem.Name = "WyciszOdciszToolStripMenuItem"
        Me.WyciszOdciszToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.WyciszOdciszToolStripMenuItem.Text = "Wycisz/Odcisz"
        '
        'ZmniejszGłośnośćToolStripMenuItem
        '
        Me.ZmniejszGłośnośćToolStripMenuItem.Name = "ZmniejszGłośnośćToolStripMenuItem"
        Me.ZmniejszGłośnośćToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.ZmniejszGłośnośćToolStripMenuItem.Text = "Zmniejsz głośność"
        '
        'ZwiększGłośnośćToolStripMenuItem
        '
        Me.ZwiększGłośnośćToolStripMenuItem.Name = "ZwiększGłośnośćToolStripMenuItem"
        Me.ZwiększGłośnośćToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.ZwiększGłośnośćToolStripMenuItem.Text = "Zwiększ głośność"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(168, 6)
        '
        'ZakończToolStripMenuItem
        '
        Me.ZakończToolStripMenuItem.Name = "ZakończToolStripMenuItem"
        Me.ZakończToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.ZakończToolStripMenuItem.Text = "Zakończ"
        '
        'btnsearchoff
        '
        Me.btnsearchoff.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.btnsearchoff.Location = New System.Drawing.Point(499, 12)
        Me.btnsearchoff.Name = "btnsearchoff"
        Me.btnsearchoff.Size = New System.Drawing.Size(23, 23)
        Me.btnsearchoff.TabIndex = 100
        Me.btnsearchoff.TabStop = False
        Me.btnsearchoff.Text = "X"
        Me.btnsearchoff.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(534, 486)
        Me.Controls.Add(Me.txtsearch)
        Me.Controls.Add(Me.btnsearchoff)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.pnlodtwarzacz)
        Me.Controls.Add(Me.tabs)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "YouTube Media Player"
        Me.tabs.ResumeLayout(False)
        Me.pnlodtwarzacz.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnmute, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnrep, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnran, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnsettings, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnrewindR, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnrewindL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnplay, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.contextnotify.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tabs As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents pnlodtwarzacz As Panel
    Friend WithEvents pnlrewind As Panel
    Friend WithEvents btnrep As PictureBox
    Friend WithEvents btnran As PictureBox
    Friend WithEvents btnsettings As PictureBox
    Friend WithEvents btnrewindR As PictureBox
    Friend WithEvents btnrewindL As PictureBox
    Friend WithEvents btnplay As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtsearch As TextBox
    Friend WithEvents pnllista As Panel
    Friend WithEvents lblinfo As Label
    Friend WithEvents btnodtwall As Button
    Friend WithEvents btndodaj As Button
    Friend WithEvents btncofnij As Button
    Friend WithEvents btnwyczysc As Button
    Friend WithEvents btnmute As PictureBox
    Friend WithEvents pnlsound As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents akt As Timer
    Friend WithEvents notify As NotifyIcon
    Friend WithEvents contextnotify As ContextMenuStrip
    Friend WithEvents PlayPauseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PoprzedniUtwórToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NastępnyUtwórToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripSeparator
    Friend WithEvents WyciszOdciszToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ZmniejszGłośnośćToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ZwiększGłośnośćToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripSeparator
    Friend WithEvents ZakończToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnsearchoff As Button
End Class

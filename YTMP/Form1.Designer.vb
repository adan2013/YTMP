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
        Me.pnlodtwarzacz = New System.Windows.Forms.Panel()
        Me.btnupdate = New System.Windows.Forms.PictureBox()
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
        Me.belkapnl = New System.Windows.Forms.Panel()
        Me.btnOPNCLS = New System.Windows.Forms.PictureBox()
        Me.btnM = New System.Windows.Forms.PictureBox()
        Me.btnX = New System.Windows.Forms.PictureBox()
        Me.mainlbl = New System.Windows.Forms.PictureBox()
        Me.tab1 = New System.Windows.Forms.PictureBox()
        Me.tab2 = New System.Windows.Forms.PictureBox()
        Me.tab3 = New System.Windows.Forms.PictureBox()
        Me.searchdelay = New System.Windows.Forms.Timer(Me.components)
        Me.pnllista = New YTMP.LISTcontrol()
        Me.pnlodtwarzacz.SuspendLayout()
        CType(Me.btnupdate, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.belkapnl.SuspendLayout()
        CType(Me.btnOPNCLS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnM, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnX, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mainlbl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tab1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tab2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tab3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlodtwarzacz
        '
        Me.pnlodtwarzacz.BackColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.pnlodtwarzacz.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlodtwarzacz.Controls.Add(Me.btnupdate)
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
        Me.pnlodtwarzacz.Location = New System.Drawing.Point(0, 390)
        Me.pnlodtwarzacz.Name = "pnlodtwarzacz"
        Me.pnlodtwarzacz.Size = New System.Drawing.Size(534, 120)
        Me.pnlodtwarzacz.TabIndex = 1
        '
        'btnupdate
        '
        Me.btnupdate.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnupdate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.btnupdate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnupdate.Image = Global.YTMP.My.Resources.Resources.aktualizacja
        Me.btnupdate.Location = New System.Drawing.Point(150, 53)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.Size = New System.Drawing.Size(125, 35)
        Me.btnupdate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.btnupdate.TabIndex = 11
        Me.btnupdate.TabStop = False
        Me.btnupdate.Visible = False
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
        Me.pnlsound.BackColor = System.Drawing.Color.WhiteSmoke
        Me.pnlsound.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlsound.Location = New System.Drawing.Point(422, 94)
        Me.pnlsound.Name = "pnlsound"
        Me.pnlsound.Size = New System.Drawing.Size(100, 17)
        Me.pnlsound.TabIndex = 7
        '
        'btnmute
        '
        Me.btnmute.BackColor = System.Drawing.Color.WhiteSmoke
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
        Me.pnlrewind.BackColor = System.Drawing.Color.WhiteSmoke
        Me.pnlrewind.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlrewind.Location = New System.Drawing.Point(60, 10)
        Me.pnlrewind.Name = "pnlrewind"
        Me.pnlrewind.Size = New System.Drawing.Size(414, 20)
        Me.pnlrewind.TabIndex = 6
        '
        'btnrep
        '
        Me.btnrep.BackColor = System.Drawing.Color.WhiteSmoke
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
        Me.btnran.BackColor = System.Drawing.Color.WhiteSmoke
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
        Me.btnsettings.BackColor = System.Drawing.Color.WhiteSmoke
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
        Me.btnrewindR.BackColor = System.Drawing.Color.WhiteSmoke
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
        Me.btnrewindL.BackColor = System.Drawing.Color.WhiteSmoke
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
        Me.btnplay.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.btnplay.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnplay.Image = Global.YTMP.My.Resources.Resources.play_button
        Me.btnplay.Location = New System.Drawing.Point(12, 38)
        Me.btnplay.Name = "btnplay"
        Me.btnplay.Size = New System.Drawing.Size(50, 50)
        Me.btnplay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.btnplay.TabIndex = 0
        Me.btnplay.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Silver
        Me.Panel1.Controls.Add(Me.pnllista)
        Me.Panel1.Controls.Add(Me.btnwyczysc)
        Me.Panel1.Controls.Add(Me.btnodtwall)
        Me.Panel1.Controls.Add(Me.btndodaj)
        Me.Panel1.Controls.Add(Me.btncofnij)
        Me.Panel1.Controls.Add(Me.lblinfo)
        Me.Panel1.Location = New System.Drawing.Point(12, 71)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(510, 313)
        Me.Panel1.TabIndex = 2
        '
        'btnwyczysc
        '
        Me.btnwyczysc.BackColor = System.Drawing.Color.Gainsboro
        Me.btnwyczysc.Enabled = False
        Me.btnwyczysc.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.btnwyczysc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke
        Me.btnwyczysc.FlatStyle = System.Windows.Forms.FlatStyle.Flat
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
        Me.btnwyczysc.UseVisualStyleBackColor = False
        '
        'btnodtwall
        '
        Me.btnodtwall.BackColor = System.Drawing.Color.Gainsboro
        Me.btnodtwall.Enabled = False
        Me.btnodtwall.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.btnodtwall.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke
        Me.btnodtwall.FlatStyle = System.Windows.Forms.FlatStyle.Flat
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
        Me.btnodtwall.UseVisualStyleBackColor = False
        '
        'btndodaj
        '
        Me.btndodaj.BackColor = System.Drawing.Color.Gainsboro
        Me.btndodaj.Enabled = False
        Me.btndodaj.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.btndodaj.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke
        Me.btndodaj.FlatStyle = System.Windows.Forms.FlatStyle.Flat
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
        Me.btndodaj.UseVisualStyleBackColor = False
        '
        'btncofnij
        '
        Me.btncofnij.BackColor = System.Drawing.Color.Gainsboro
        Me.btncofnij.Enabled = False
        Me.btncofnij.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.btncofnij.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke
        Me.btncofnij.FlatStyle = System.Windows.Forms.FlatStyle.Flat
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
        Me.btncofnij.UseVisualStyleBackColor = False
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
        'txtsearch
        '
        Me.txtsearch.BackColor = System.Drawing.Color.Gainsboro
        Me.txtsearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.txtsearch.ForeColor = System.Drawing.Color.Gray
        Me.txtsearch.Location = New System.Drawing.Point(342, 42)
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
        Me.notify.BalloonTipTitle = "YouTube Media Player"
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
        Me.btnsearchoff.BackColor = System.Drawing.Color.Gainsboro
        Me.btnsearchoff.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.btnsearchoff.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke
        Me.btnsearchoff.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnsearchoff.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.btnsearchoff.Location = New System.Drawing.Point(499, 42)
        Me.btnsearchoff.Name = "btnsearchoff"
        Me.btnsearchoff.Size = New System.Drawing.Size(23, 23)
        Me.btnsearchoff.TabIndex = 100
        Me.btnsearchoff.TabStop = False
        Me.btnsearchoff.Text = "X"
        Me.btnsearchoff.UseVisualStyleBackColor = False
        '
        'belkapnl
        '
        Me.belkapnl.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.belkapnl.Controls.Add(Me.btnOPNCLS)
        Me.belkapnl.Controls.Add(Me.btnM)
        Me.belkapnl.Controls.Add(Me.btnX)
        Me.belkapnl.Controls.Add(Me.mainlbl)
        Me.belkapnl.Location = New System.Drawing.Point(0, 0)
        Me.belkapnl.Name = "belkapnl"
        Me.belkapnl.Size = New System.Drawing.Size(534, 30)
        Me.belkapnl.TabIndex = 101
        '
        'btnOPNCLS
        '
        Me.btnOPNCLS.Image = Global.YTMP.My.Resources.Resources.belkaopen
        Me.btnOPNCLS.Location = New System.Drawing.Point(414, 0)
        Me.btnOPNCLS.Name = "btnOPNCLS"
        Me.btnOPNCLS.Size = New System.Drawing.Size(40, 30)
        Me.btnOPNCLS.TabIndex = 104
        Me.btnOPNCLS.TabStop = False
        '
        'btnM
        '
        Me.btnM.Image = Global.YTMP.My.Resources.Resources.belkaM
        Me.btnM.Location = New System.Drawing.Point(454, 0)
        Me.btnM.Name = "btnM"
        Me.btnM.Size = New System.Drawing.Size(40, 30)
        Me.btnM.TabIndex = 103
        Me.btnM.TabStop = False
        '
        'btnX
        '
        Me.btnX.Image = Global.YTMP.My.Resources.Resources.belkaX
        Me.btnX.Location = New System.Drawing.Point(494, 0)
        Me.btnX.Name = "btnX"
        Me.btnX.Size = New System.Drawing.Size(40, 30)
        Me.btnX.TabIndex = 102
        Me.btnX.TabStop = False
        '
        'mainlbl
        '
        Me.mainlbl.Image = Global.YTMP.My.Resources.Resources.belka
        Me.mainlbl.Location = New System.Drawing.Point(8, 0)
        Me.mainlbl.Name = "mainlbl"
        Me.mainlbl.Size = New System.Drawing.Size(300, 30)
        Me.mainlbl.TabIndex = 0
        Me.mainlbl.TabStop = False
        '
        'tab1
        '
        Me.tab1.Image = Global.YTMP.My.Resources.Resources.btntab1
        Me.tab1.Location = New System.Drawing.Point(23, 42)
        Me.tab1.Margin = New System.Windows.Forms.Padding(1)
        Me.tab1.Name = "tab1"
        Me.tab1.Size = New System.Drawing.Size(126, 38)
        Me.tab1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.tab1.TabIndex = 102
        Me.tab1.TabStop = False
        '
        'tab2
        '
        Me.tab2.Image = Global.YTMP.My.Resources.Resources.btntab2
        Me.tab2.Location = New System.Drawing.Point(149, 42)
        Me.tab2.Margin = New System.Windows.Forms.Padding(1)
        Me.tab2.Name = "tab2"
        Me.tab2.Size = New System.Drawing.Size(68, 38)
        Me.tab2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.tab2.TabIndex = 103
        Me.tab2.TabStop = False
        '
        'tab3
        '
        Me.tab3.Image = Global.YTMP.My.Resources.Resources.btntab3
        Me.tab3.Location = New System.Drawing.Point(217, 42)
        Me.tab3.Margin = New System.Windows.Forms.Padding(1)
        Me.tab3.Name = "tab3"
        Me.tab3.Size = New System.Drawing.Size(74, 38)
        Me.tab3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.tab3.TabIndex = 104
        Me.tab3.TabStop = False
        '
        'searchdelay
        '
        Me.searchdelay.Interval = 900
        '
        'pnllista
        '
        Me.pnllista.BackColor = System.Drawing.Color.White
        Me.pnllista.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnllista.Location = New System.Drawing.Point(92, 35)
        Me.pnllista.Name = "pnllista"
        Me.pnllista.Size = New System.Drawing.Size(409, 268)
        Me.pnllista.TabIndex = 11
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(534, 510)
        Me.Controls.Add(Me.belkapnl)
        Me.Controls.Add(Me.txtsearch)
        Me.Controls.Add(Me.btnsearchoff)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.pnlodtwarzacz)
        Me.Controls.Add(Me.tab1)
        Me.Controls.Add(Me.tab2)
        Me.Controls.Add(Me.tab3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "YouTube Media Player"
        Me.pnlodtwarzacz.ResumeLayout(False)
        CType(Me.btnupdate, System.ComponentModel.ISupportInitialize).EndInit()
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
        Me.belkapnl.ResumeLayout(False)
        CType(Me.btnOPNCLS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnM, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnX, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mainlbl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tab1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tab2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tab3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
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
    Friend WithEvents btnupdate As PictureBox
    Friend WithEvents belkapnl As Panel
    Friend WithEvents mainlbl As PictureBox
    Friend WithEvents btnM As PictureBox
    Friend WithEvents btnX As PictureBox
    Friend WithEvents tab1 As PictureBox
    Friend WithEvents tab2 As PictureBox
    Friend WithEvents tab3 As PictureBox
    Friend WithEvents btnOPNCLS As PictureBox
    Friend WithEvents pnllista As LISTcontrol
    Friend WithEvents searchdelay As Timer
End Class

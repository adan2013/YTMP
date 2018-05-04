<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IMPORTplaylist
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(IMPORTplaylist))
        Me.txtprogress = New System.Windows.Forms.TextBox()
        Me.tabela = New System.Windows.Forms.DataGridView()
        Me.k1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.k2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.k3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.k4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.k5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.k6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnimport = New System.Windows.Forms.Button()
        Me.radioauto = New System.Windows.Forms.RadioButton()
        Me.radiodirect = New System.Windows.Forms.RadioButton()
        Me.chkboxedit = New System.Windows.Forms.CheckBox()
        Me.btnpath = New System.Windows.Forms.Button()
        Me.lblpath = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.akt = New System.Windows.Forms.Timer(Me.components)
        Me.btndelete = New System.Windows.Forms.Button()
        Me.chkboxpl = New System.Windows.Forms.CheckBox()
        Me.lstpl = New System.Windows.Forms.ComboBox()
        Me.btnnewpl = New System.Windows.Forms.Button()
        Me.GRpostep = New System.Windows.Forms.GroupBox()
        Me.GRopcje = New System.Windows.Forms.GroupBox()
        Me.GRzarzadzanie = New System.Windows.Forms.GroupBox()
        Me.GRimport = New System.Windows.Forms.GroupBox()
        Me.btnanuluj = New System.Windows.Forms.Button()
        CType(Me.tabela, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GRpostep.SuspendLayout()
        Me.GRopcje.SuspendLayout()
        Me.GRzarzadzanie.SuspendLayout()
        Me.GRimport.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtprogress
        '
        Me.txtprogress.BackColor = System.Drawing.Color.AliceBlue
        Me.txtprogress.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.txtprogress.Location = New System.Drawing.Point(7, 23)
        Me.txtprogress.Margin = New System.Windows.Forms.Padding(4)
        Me.txtprogress.Multiline = True
        Me.txtprogress.Name = "txtprogress"
        Me.txtprogress.ReadOnly = True
        Me.txtprogress.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtprogress.Size = New System.Drawing.Size(412, 155)
        Me.txtprogress.TabIndex = 0
        '
        'tabela
        '
        Me.tabela.AllowUserToAddRows = False
        Me.tabela.AllowUserToDeleteRows = False
        Me.tabela.AllowUserToResizeRows = False
        Me.tabela.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.tabela.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tabela.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.k1, Me.k2, Me.k3, Me.k4, Me.k5, Me.k6})
        Me.tabela.Dock = System.Windows.Forms.DockStyle.Top
        Me.tabela.Location = New System.Drawing.Point(0, 0)
        Me.tabela.MultiSelect = False
        Me.tabela.Name = "tabela"
        Me.tabela.ReadOnly = True
        Me.tabela.Size = New System.Drawing.Size(984, 207)
        Me.tabela.TabIndex = 3
        '
        'k1
        '
        Me.k1.HeaderText = "Tytuł"
        Me.k1.Name = "k1"
        Me.k1.ReadOnly = True
        Me.k1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.k1.Width = 38
        '
        'k2
        '
        Me.k2.HeaderText = "Identyfikator"
        Me.k2.Name = "k2"
        Me.k2.ReadOnly = True
        Me.k2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.k2.Width = 71
        '
        'k3
        '
        Me.k3.HeaderText = "Odczyt wykonawcy"
        Me.k3.Name = "k3"
        Me.k3.ReadOnly = True
        Me.k3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.k3.Width = 95
        '
        'k4
        '
        Me.k4.HeaderText = "Wykonawca"
        Me.k4.Name = "k4"
        Me.k4.ReadOnly = True
        Me.k4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.k4.Width = 73
        '
        'k5
        '
        Me.k5.HeaderText = "Album"
        Me.k5.Name = "k5"
        Me.k5.ReadOnly = True
        Me.k5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.k5.Width = 42
        '
        'k6
        '
        Me.k6.HeaderText = "Tytuł pobrany z YouTube'a"
        Me.k6.Name = "k6"
        Me.k6.ReadOnly = True
        '
        'btnimport
        '
        Me.btnimport.Enabled = False
        Me.btnimport.Image = Global.YTMP.My.Resources.Resources.playlist_add
        Me.btnimport.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnimport.Location = New System.Drawing.Point(116, 22)
        Me.btnimport.Name = "btnimport"
        Me.btnimport.Padding = New System.Windows.Forms.Padding(5, 8, 5, 5)
        Me.btnimport.Size = New System.Drawing.Size(160, 60)
        Me.btnimport.TabIndex = 4
        Me.btnimport.Text = "Rozpocznij import"
        Me.btnimport.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnimport.UseVisualStyleBackColor = True
        '
        'radioauto
        '
        Me.radioauto.AutoSize = True
        Me.radioauto.Checked = True
        Me.radioauto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.radioauto.Location = New System.Drawing.Point(6, 102)
        Me.radioauto.Name = "radioauto"
        Me.radioauto.Size = New System.Drawing.Size(263, 19)
        Me.radioauto.TabIndex = 5
        Me.radioauto.TabStop = True
        Me.radioauto.Text = "Kieruj się wykonawcami i albumami z tabeli"
        Me.radioauto.UseVisualStyleBackColor = True
        '
        'radiodirect
        '
        Me.radiodirect.AutoSize = True
        Me.radiodirect.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.radiodirect.Location = New System.Drawing.Point(6, 127)
        Me.radiodirect.Name = "radiodirect"
        Me.radiodirect.Size = New System.Drawing.Size(241, 19)
        Me.radiodirect.TabIndex = 6
        Me.radiodirect.Text = "Dodawaj utwory pod następujący adres:"
        Me.radiodirect.UseVisualStyleBackColor = True
        '
        'chkboxedit
        '
        Me.chkboxedit.AutoSize = True
        Me.chkboxedit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.chkboxedit.Location = New System.Drawing.Point(6, 22)
        Me.chkboxedit.Name = "chkboxedit"
        Me.chkboxedit.Size = New System.Drawing.Size(261, 19)
        Me.chkboxedit.TabIndex = 7
        Me.chkboxedit.Text = "Otwórz okno edycji utworu przed dodaniem"
        Me.chkboxedit.UseVisualStyleBackColor = True
        '
        'btnpath
        '
        Me.btnpath.Enabled = False
        Me.btnpath.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.btnpath.Location = New System.Drawing.Point(6, 152)
        Me.btnpath.Name = "btnpath"
        Me.btnpath.Size = New System.Drawing.Size(50, 23)
        Me.btnpath.TabIndex = 29
        Me.btnpath.Text = "Zmień"
        Me.btnpath.UseVisualStyleBackColor = True
        '
        'lblpath
        '
        Me.lblpath.AutoSize = True
        Me.lblpath.Enabled = False
        Me.lblpath.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lblpath.Location = New System.Drawing.Point(65, 155)
        Me.lblpath.Margin = New System.Windows.Forms.Padding(6, 6, 3, 0)
        Me.lblpath.Name = "lblpath"
        Me.lblpath.Size = New System.Drawing.Size(39, 17)
        Me.lblpath.TabIndex = 28
        Me.lblpath.Text = "WYK"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DimGray
        Me.Label3.Location = New System.Drawing.Point(94, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(465, 60)
        Me.Label3.TabIndex = 30
        Me.Label3.Text = resources.GetString("Label3.Text")
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'akt
        '
        Me.akt.Interval = 150
        '
        'btndelete
        '
        Me.btndelete.Enabled = False
        Me.btndelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.btndelete.Image = Global.YTMP.My.Resources.Resources.delete__2_
        Me.btndelete.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btndelete.Location = New System.Drawing.Point(7, 22)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Padding = New System.Windows.Forms.Padding(5, 8, 5, 5)
        Me.btndelete.Size = New System.Drawing.Size(81, 60)
        Me.btndelete.TabIndex = 31
        Me.btndelete.Text = "Usuń wpis"
        Me.btndelete.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btndelete.UseVisualStyleBackColor = True
        '
        'chkboxpl
        '
        Me.chkboxpl.AutoSize = True
        Me.chkboxpl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.chkboxpl.Location = New System.Drawing.Point(6, 47)
        Me.chkboxpl.Name = "chkboxpl"
        Me.chkboxpl.Size = New System.Drawing.Size(162, 19)
        Me.chkboxpl.TabIndex = 32
        Me.chkboxpl.Text = "Dodaj utwory do playlisty:"
        Me.chkboxpl.UseVisualStyleBackColor = True
        '
        'lstpl
        '
        Me.lstpl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.lstpl.Enabled = False
        Me.lstpl.FormattingEnabled = True
        Me.lstpl.Location = New System.Drawing.Point(25, 72)
        Me.lstpl.Name = "lstpl"
        Me.lstpl.Size = New System.Drawing.Size(201, 24)
        Me.lstpl.TabIndex = 33
        '
        'btnnewpl
        '
        Me.btnnewpl.Enabled = False
        Me.btnnewpl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.btnnewpl.Location = New System.Drawing.Point(232, 70)
        Me.btnnewpl.Name = "btnnewpl"
        Me.btnnewpl.Size = New System.Drawing.Size(100, 24)
        Me.btnnewpl.TabIndex = 34
        Me.btnnewpl.Text = "Nowa playlista"
        Me.btnnewpl.UseVisualStyleBackColor = True
        '
        'GRpostep
        '
        Me.GRpostep.Controls.Add(Me.txtprogress)
        Me.GRpostep.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.GRpostep.Location = New System.Drawing.Point(15, 420)
        Me.GRpostep.Name = "GRpostep"
        Me.GRpostep.Size = New System.Drawing.Size(426, 185)
        Me.GRpostep.TabIndex = 35
        Me.GRpostep.TabStop = False
        Me.GRpostep.Text = "Postęp importu danych"
        '
        'GRopcje
        '
        Me.GRopcje.Controls.Add(Me.chkboxpl)
        Me.GRopcje.Controls.Add(Me.lstpl)
        Me.GRopcje.Controls.Add(Me.btnnewpl)
        Me.GRopcje.Controls.Add(Me.chkboxedit)
        Me.GRopcje.Controls.Add(Me.lblpath)
        Me.GRopcje.Controls.Add(Me.btnpath)
        Me.GRopcje.Controls.Add(Me.radioauto)
        Me.GRopcje.Controls.Add(Me.radiodirect)
        Me.GRopcje.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.GRopcje.Location = New System.Drawing.Point(447, 420)
        Me.GRopcje.Name = "GRopcje"
        Me.GRopcje.Size = New System.Drawing.Size(426, 185)
        Me.GRopcje.TabIndex = 1
        Me.GRopcje.TabStop = False
        Me.GRopcje.Text = "Dodatkowe opcje"
        '
        'GRzarzadzanie
        '
        Me.GRzarzadzanie.Controls.Add(Me.btndelete)
        Me.GRzarzadzanie.Controls.Add(Me.Label3)
        Me.GRzarzadzanie.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.GRzarzadzanie.Location = New System.Drawing.Point(15, 318)
        Me.GRzarzadzanie.Name = "GRzarzadzanie"
        Me.GRzarzadzanie.Size = New System.Drawing.Size(570, 96)
        Me.GRzarzadzanie.TabIndex = 36
        Me.GRzarzadzanie.TabStop = False
        Me.GRzarzadzanie.Text = "Zarządzanie listą utworów"
        '
        'GRimport
        '
        Me.GRimport.Controls.Add(Me.btnanuluj)
        Me.GRimport.Controls.Add(Me.btnimport)
        Me.GRimport.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.GRimport.Location = New System.Drawing.Point(591, 318)
        Me.GRimport.Name = "GRimport"
        Me.GRimport.Size = New System.Drawing.Size(282, 96)
        Me.GRimport.TabIndex = 37
        Me.GRimport.TabStop = False
        Me.GRimport.Text = "Importuj"
        '
        'btnanuluj
        '
        Me.btnanuluj.Enabled = False
        Me.btnanuluj.Image = Global.YTMP.My.Resources.Resources.left_arrow_browser
        Me.btnanuluj.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnanuluj.Location = New System.Drawing.Point(6, 22)
        Me.btnanuluj.Name = "btnanuluj"
        Me.btnanuluj.Padding = New System.Windows.Forms.Padding(5, 8, 5, 5)
        Me.btnanuluj.Size = New System.Drawing.Size(104, 60)
        Me.btnanuluj.TabIndex = 5
        Me.btnanuluj.Text = "Anuluj"
        Me.btnanuluj.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnanuluj.UseVisualStyleBackColor = True
        '
        'IMPORTplaylist
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 632)
        Me.Controls.Add(Me.GRimport)
        Me.Controls.Add(Me.GRzarzadzanie)
        Me.Controls.Add(Me.GRopcje)
        Me.Controls.Add(Me.GRpostep)
        Me.Controls.Add(Me.tabela)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(1000, 670)
        Me.Name = "IMPORTplaylist"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Import playlisty"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.tabela, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GRpostep.ResumeLayout(False)
        Me.GRpostep.PerformLayout()
        Me.GRopcje.ResumeLayout(False)
        Me.GRopcje.PerformLayout()
        Me.GRzarzadzanie.ResumeLayout(False)
        Me.GRzarzadzanie.PerformLayout()
        Me.GRimport.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents txtprogress As TextBox
    Friend WithEvents tabela As DataGridView
    Friend WithEvents btnimport As Button
    Friend WithEvents radioauto As RadioButton
    Friend WithEvents radiodirect As RadioButton
    Friend WithEvents chkboxedit As CheckBox
    Friend WithEvents btnpath As Button
    Friend WithEvents lblpath As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents akt As Timer
    Friend WithEvents btndelete As Button
    Friend WithEvents chkboxpl As CheckBox
    Friend WithEvents lstpl As ComboBox
    Friend WithEvents btnnewpl As Button
    Friend WithEvents k1 As DataGridViewTextBoxColumn
    Friend WithEvents k2 As DataGridViewTextBoxColumn
    Friend WithEvents k3 As DataGridViewTextBoxColumn
    Friend WithEvents k4 As DataGridViewTextBoxColumn
    Friend WithEvents k5 As DataGridViewTextBoxColumn
    Friend WithEvents k6 As DataGridViewTextBoxColumn
    Friend WithEvents GRpostep As GroupBox
    Friend WithEvents GRopcje As GroupBox
    Friend WithEvents GRzarzadzanie As GroupBox
    Friend WithEvents GRimport As GroupBox
    Friend WithEvents btnanuluj As Button
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class settingsform
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(settingsform))
        Me.tabs = New System.Windows.Forms.TabControl()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.lstdefaulttab = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.chkboxhidealbums = New System.Windows.Forms.CheckBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.nropoznienie = New System.Windows.Forms.NumericUpDown()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.chkboxhide = New System.Windows.Forms.CheckBox()
        Me.chkboxczas = New System.Windows.Forms.CheckBox()
        Me.chkboxprzejdz = New System.Windows.Forms.CheckBox()
        Me.chkboxdymek = New System.Windows.Forms.CheckBox()
        Me.chkboxpocz = New System.Windows.Forms.RadioButton()
        Me.chkboxkoniec = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.chkboxmkeys = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.skrotygrid = New System.Windows.Forms.DataGridView()
        Me.akcja = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.skrot = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btngeneruj = New System.Windows.Forms.Button()
        Me.btnzapisz = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnwgraj = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lstkopie = New System.Windows.Forms.ComboBox()
        Me.btnprzywroc = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnwgrajcalosc = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btndelete = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnlocalsave = New System.Windows.Forms.Button()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblver = New System.Windows.Forms.Label()
        Me.lblname = New System.Windows.Forms.Label()
        Me.savedialog = New System.Windows.Forms.SaveFileDialog()
        Me.opendialog = New System.Windows.Forms.OpenFileDialog()
        Me.btnpdf = New System.Windows.Forms.Button()
        Me.tabs.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.nropoznienie, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage1.SuspendLayout()
        CType(Me.skrotygrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tabs
        '
        Me.tabs.Controls.Add(Me.TabPage2)
        Me.tabs.Controls.Add(Me.TabPage1)
        Me.tabs.Controls.Add(Me.TabPage3)
        Me.tabs.Controls.Add(Me.TabPage4)
        Me.tabs.Location = New System.Drawing.Point(12, 12)
        Me.tabs.Name = "tabs"
        Me.tabs.Padding = New System.Drawing.Point(14, 8)
        Me.tabs.SelectedIndex = 0
        Me.tabs.Size = New System.Drawing.Size(560, 267)
        Me.tabs.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.lstdefaulttab)
        Me.TabPage2.Controls.Add(Me.Label11)
        Me.TabPage2.Controls.Add(Me.chkboxhidealbums)
        Me.TabPage2.Controls.Add(Me.Label5)
        Me.TabPage2.Controls.Add(Me.nropoznienie)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Controls.Add(Me.chkboxhide)
        Me.TabPage2.Controls.Add(Me.chkboxczas)
        Me.TabPage2.Controls.Add(Me.chkboxprzejdz)
        Me.TabPage2.Controls.Add(Me.chkboxdymek)
        Me.TabPage2.Controls.Add(Me.chkboxpocz)
        Me.TabPage2.Controls.Add(Me.chkboxkoniec)
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 32)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(552, 231)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Odtwarzacz"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'lstdefaulttab
        '
        Me.lstdefaulttab.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.lstdefaulttab.FormattingEnabled = True
        Me.lstdefaulttab.Items.AddRange(New Object() {"Lista odtwarzania", "Utwory", "Playlisty"})
        Me.lstdefaulttab.Location = New System.Drawing.Point(9, 162)
        Me.lstdefaulttab.Name = "lstdefaulttab"
        Me.lstdefaulttab.Size = New System.Drawing.Size(137, 21)
        Me.lstdefaulttab.TabIndex = 1
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label11.Location = New System.Drawing.Point(6, 144)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(147, 15)
        Me.Label11.TabIndex = 12
        Me.Label11.Text = "Domyślnie wybrana karta:"
        '
        'chkboxhidealbums
        '
        Me.chkboxhidealbums.AutoSize = True
        Me.chkboxhidealbums.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.chkboxhidealbums.Location = New System.Drawing.Point(204, 144)
        Me.chkboxhidealbums.Name = "chkboxhidealbums"
        Me.chkboxhidealbums.Size = New System.Drawing.Size(142, 19)
        Me.chkboxhidealbums.TabIndex = 11
        Me.chkboxhidealbums.Text = "Ukryj wybór albumów"
        Me.chkboxhidealbums.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label5.Location = New System.Drawing.Point(94, 118)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(24, 15)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "ms"
        '
        'nropoznienie
        '
        Me.nropoznienie.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.nropoznienie.Location = New System.Drawing.Point(9, 112)
        Me.nropoznienie.Maximum = New Decimal(New Integer() {5000, 0, 0, 0})
        Me.nropoznienie.Name = "nropoznienie"
        Me.nropoznienie.Size = New System.Drawing.Size(79, 21)
        Me.nropoznienie.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 79)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(140, 30)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Opóźnienie odtwarzania" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "następnych utworów:"
        '
        'chkboxhide
        '
        Me.chkboxhide.AutoSize = True
        Me.chkboxhide.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.chkboxhide.Location = New System.Drawing.Point(204, 119)
        Me.chkboxhide.Name = "chkboxhide"
        Me.chkboxhide.Size = New System.Drawing.Size(203, 19)
        Me.chkboxhide.TabIndex = 7
        Me.chkboxhide.Text = "Ukryj okno po zminimalizowaniu"
        Me.chkboxhide.UseVisualStyleBackColor = True
        '
        'chkboxczas
        '
        Me.chkboxczas.AutoSize = True
        Me.chkboxczas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.chkboxczas.Location = New System.Drawing.Point(204, 79)
        Me.chkboxczas.Name = "chkboxczas"
        Me.chkboxczas.Size = New System.Drawing.Size(173, 34)
        Me.chkboxczas.TabIndex = 6
        Me.chkboxczas.Text = "Wyświetlaj czasy przycięcia" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "nagrania"
        Me.chkboxczas.UseVisualStyleBackColor = True
        '
        'chkboxprzejdz
        '
        Me.chkboxprzejdz.AutoSize = True
        Me.chkboxprzejdz.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.chkboxprzejdz.Location = New System.Drawing.Point(204, 39)
        Me.chkboxprzejdz.Name = "chkboxprzejdz"
        Me.chkboxprzejdz.Size = New System.Drawing.Size(191, 34)
        Me.chkboxprzejdz.TabIndex = 5
        Me.chkboxprzejdz.Text = "Przejdź do nowo utworzonego" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "wykonawcy/albumu/playlisty"
        Me.chkboxprzejdz.UseVisualStyleBackColor = True
        '
        'chkboxdymek
        '
        Me.chkboxdymek.AutoSize = True
        Me.chkboxdymek.Checked = True
        Me.chkboxdymek.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkboxdymek.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.chkboxdymek.Location = New System.Drawing.Point(204, 14)
        Me.chkboxdymek.Name = "chkboxdymek"
        Me.chkboxdymek.Size = New System.Drawing.Size(188, 19)
        Me.chkboxdymek.TabIndex = 2
        Me.chkboxdymek.Text = "Wyświetl tytuł utworu w dymku"
        Me.chkboxdymek.UseVisualStyleBackColor = True
        '
        'chkboxpocz
        '
        Me.chkboxpocz.AutoSize = True
        Me.chkboxpocz.Location = New System.Drawing.Point(9, 53)
        Me.chkboxpocz.Name = "chkboxpocz"
        Me.chkboxpocz.Size = New System.Drawing.Size(106, 17)
        Me.chkboxpocz.TabIndex = 4
        Me.chkboxpocz.Text = "Na początku listy"
        Me.chkboxpocz.UseVisualStyleBackColor = True
        '
        'chkboxkoniec
        '
        Me.chkboxkoniec.AutoSize = True
        Me.chkboxkoniec.Checked = True
        Me.chkboxkoniec.Location = New System.Drawing.Point(9, 30)
        Me.chkboxkoniec.Name = "chkboxkoniec"
        Me.chkboxkoniec.Size = New System.Drawing.Size(92, 17)
        Me.chkboxkoniec.TabIndex = 3
        Me.chkboxkoniec.TabStop = True
        Me.chkboxkoniec.Text = "Na końcu listy"
        Me.chkboxkoniec.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Dodawaj nową pozycję:"
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.chkboxmkeys)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.skrotygrid)
        Me.TabPage1.Location = New System.Drawing.Point(4, 32)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(552, 231)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Sterowanie"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'chkboxmkeys
        '
        Me.chkboxmkeys.AutoSize = True
        Me.chkboxmkeys.CheckAlign = System.Drawing.ContentAlignment.TopLeft
        Me.chkboxmkeys.Checked = True
        Me.chkboxmkeys.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkboxmkeys.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.chkboxmkeys.Location = New System.Drawing.Point(412, 6)
        Me.chkboxmkeys.Name = "chkboxmkeys"
        Me.chkboxmkeys.Size = New System.Drawing.Size(124, 49)
        Me.chkboxmkeys.TabIndex = 3
        Me.chkboxmkeys.Text = "Obsługuj przyciski" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "multimedialne" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "na klawiaturze"
        Me.chkboxmkeys.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(219, 215)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(187, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Kliknij dwukrotnie, aby edytować skrót"
        '
        'skrotygrid
        '
        Me.skrotygrid.AllowUserToAddRows = False
        Me.skrotygrid.AllowUserToDeleteRows = False
        Me.skrotygrid.AllowUserToOrderColumns = True
        Me.skrotygrid.AllowUserToResizeColumns = False
        Me.skrotygrid.AllowUserToResizeRows = False
        Me.skrotygrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.skrotygrid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.skrotygrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.skrotygrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.akcja, Me.skrot})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.skrotygrid.DefaultCellStyle = DataGridViewCellStyle2
        Me.skrotygrid.Location = New System.Drawing.Point(6, 6)
        Me.skrotygrid.Name = "skrotygrid"
        Me.skrotygrid.ReadOnly = True
        Me.skrotygrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.skrotygrid.Size = New System.Drawing.Size(400, 206)
        Me.skrotygrid.TabIndex = 0
        '
        'akcja
        '
        Me.akcja.HeaderText = "Akcja"
        Me.akcja.Name = "akcja"
        Me.akcja.ReadOnly = True
        '
        'skrot
        '
        Me.skrot.HeaderText = "Przypisany skrót"
        Me.skrot.Name = "skrot"
        Me.skrot.ReadOnly = True
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.GroupBox3)
        Me.TabPage3.Controls.Add(Me.GroupBox2)
        Me.TabPage3.Controls.Add(Me.GroupBox1)
        Me.TabPage3.Location = New System.Drawing.Point(4, 32)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(552, 231)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Biblioteka utworów"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btngeneruj)
        Me.GroupBox3.Controls.Add(Me.btnzapisz)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.btnwgraj)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Location = New System.Drawing.Point(6, 157)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(540, 68)
        Me.GroupBox3.TabIndex = 5
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Import/eksport utworów"
        '
        'btngeneruj
        '
        Me.btngeneruj.Location = New System.Drawing.Point(434, 38)
        Me.btngeneruj.Margin = New System.Windows.Forms.Padding(3, 5, 3, 10)
        Me.btngeneruj.Name = "btngeneruj"
        Me.btngeneruj.Size = New System.Drawing.Size(100, 23)
        Me.btngeneruj.TabIndex = 10
        Me.btngeneruj.Text = "Generuj"
        Me.btngeneruj.UseVisualStyleBackColor = True
        '
        'btnzapisz
        '
        Me.btnzapisz.Location = New System.Drawing.Point(178, 38)
        Me.btnzapisz.Margin = New System.Windows.Forms.Padding(3, 5, 3, 10)
        Me.btnzapisz.Name = "btnzapisz"
        Me.btnzapisz.Size = New System.Drawing.Size(100, 23)
        Me.btnzapisz.TabIndex = 9
        Me.btnzapisz.Text = "Zapisz"
        Me.btnzapisz.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(296, 16)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(223, 13)
        Me.Label10.TabIndex = 8
        Me.Label10.Text = "Generuj listę utworów zapisanych w bibliotece"
        '
        'btnwgraj
        '
        Me.btnwgraj.Location = New System.Drawing.Point(72, 38)
        Me.btnwgraj.Margin = New System.Windows.Forms.Padding(3, 5, 3, 10)
        Me.btnwgraj.Name = "btnwgraj"
        Me.btnwgraj.Size = New System.Drawing.Size(100, 23)
        Me.btnwgraj.TabIndex = 7
        Me.btnwgraj.Text = "Wgraj"
        Me.btnwgraj.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 16)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(224, 13)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "Importuj/eksportuj utwory do biblioteki lokalnej"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lstkopie)
        Me.GroupBox2.Controls.Add(Me.btnprzywroc)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(284, 145)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Kopia zapasowa"
        '
        'lstkopie
        '
        Me.lstkopie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.lstkopie.FormattingEnabled = True
        Me.lstkopie.Items.AddRange(New Object() {"Wyłączone", "Włączone"})
        Me.lstkopie.Location = New System.Drawing.Point(178, 59)
        Me.lstkopie.Name = "lstkopie"
        Me.lstkopie.Size = New System.Drawing.Size(100, 21)
        Me.lstkopie.TabIndex = 5
        '
        'btnprzywroc
        '
        Me.btnprzywroc.Location = New System.Drawing.Point(178, 108)
        Me.btnprzywroc.Margin = New System.Windows.Forms.Padding(3, 5, 3, 10)
        Me.btnprzywroc.Name = "btnprzywroc"
        Me.btnprzywroc.Size = New System.Drawing.Size(100, 23)
        Me.btnprzywroc.TabIndex = 4
        Me.btnprzywroc.Text = "Przywróć"
        Me.btnprzywroc.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 90)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(185, 13)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Przywróć bibliotekę z kopii kapasowej"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 26)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(250, 26)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Twórz kopie zapasowe biblioteki, aby zabezpieczyć" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "się przed utratą danych"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnwgrajcalosc)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.btndelete)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.btnlocalsave)
        Me.GroupBox1.Location = New System.Drawing.Point(296, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(250, 145)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Magazyn lokalny"
        '
        'btnwgrajcalosc
        '
        Me.btnwgrajcalosc.Location = New System.Drawing.Point(38, 57)
        Me.btnwgrajcalosc.Margin = New System.Windows.Forms.Padding(3, 5, 3, 10)
        Me.btnwgrajcalosc.Name = "btnwgrajcalosc"
        Me.btnwgrajcalosc.Size = New System.Drawing.Size(100, 23)
        Me.btnwgrajcalosc.TabIndex = 10
        Me.btnwgrajcalosc.Text = "Wgraj"
        Me.btnwgrajcalosc.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 90)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(214, 13)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Usuń bezpowrotnie całą bibliotekę utworów"
        '
        'btndelete
        '
        Me.btndelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.btndelete.ForeColor = System.Drawing.Color.Red
        Me.btndelete.Location = New System.Drawing.Point(144, 108)
        Me.btndelete.Margin = New System.Windows.Forms.Padding(3, 5, 3, 10)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(100, 23)
        Me.btndelete.TabIndex = 2
        Me.btndelete.Text = "Usuń"
        Me.btndelete.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(214, 26)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Zapisz bibliotekę utworów do pliku lub wgraj" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "całą zawartość pliku do biblioteki"
        '
        'btnlocalsave
        '
        Me.btnlocalsave.Location = New System.Drawing.Point(144, 57)
        Me.btnlocalsave.Margin = New System.Windows.Forms.Padding(3, 5, 3, 10)
        Me.btnlocalsave.Name = "btnlocalsave"
        Me.btnlocalsave.Size = New System.Drawing.Size(100, 23)
        Me.btnlocalsave.TabIndex = 0
        Me.btnlocalsave.Text = "Zapisz"
        Me.btnlocalsave.UseVisualStyleBackColor = True
        '
        'TabPage4
        '
        Me.TabPage4.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.TabPage4.Controls.Add(Me.btnpdf)
        Me.TabPage4.Controls.Add(Me.PictureBox1)
        Me.TabPage4.Controls.Add(Me.lblver)
        Me.TabPage4.Controls.Add(Me.lblname)
        Me.TabPage4.Location = New System.Drawing.Point(4, 32)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(552, 231)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Informacje"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.YTMP.My.Resources.Resources.text3408_128
        Me.PictureBox1.Location = New System.Drawing.Point(23, 88)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(128, 128)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'lblver
        '
        Me.lblver.AutoSize = True
        Me.lblver.Font = New System.Drawing.Font("Consolas", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lblver.ForeColor = System.Drawing.Color.White
        Me.lblver.Location = New System.Drawing.Point(435, 60)
        Me.lblver.Name = "lblver"
        Me.lblver.Size = New System.Drawing.Size(96, 26)
        Me.lblver.TabIndex = 1
        Me.lblver.Text = "VERSION"
        '
        'lblname
        '
        Me.lblname.AutoSize = True
        Me.lblname.Font = New System.Drawing.Font("Consolas", 26.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lblname.ForeColor = System.Drawing.Color.White
        Me.lblname.Location = New System.Drawing.Point(171, 19)
        Me.lblname.Name = "lblname"
        Me.lblname.Size = New System.Drawing.Size(360, 41)
        Me.lblname.TabIndex = 0
        Me.lblname.Text = "YouTubeMediaPlayer"
        '
        'savedialog
        '
        Me.savedialog.Filter = "Plik magazynu (*.ytmp)|*.ytmp"
        Me.savedialog.Title = "Wybierz ścieżkę i nazwę pliku"
        '
        'opendialog
        '
        Me.opendialog.Filter = "Plik magazynu (*.ytmp)|*.ytmp"
        Me.opendialog.Title = "Wskaż plik"
        '
        'btnpdf
        '
        Me.btnpdf.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnpdf.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnpdf.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.btnpdf.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnpdf.Location = New System.Drawing.Point(431, 200)
        Me.btnpdf.Name = "btnpdf"
        Me.btnpdf.Size = New System.Drawing.Size(115, 25)
        Me.btnpdf.TabIndex = 3
        Me.btnpdf.Text = "Instrukcja PDF"
        Me.btnpdf.UseVisualStyleBackColor = True
        '
        'settingsform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 291)
        Me.Controls.Add(Me.tabs)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "settingsform"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Ustawienia"
        Me.tabs.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.nropoznienie, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.skrotygrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tabs As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents skrotygrid As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents akcja As DataGridViewTextBoxColumn
    Friend WithEvents skrot As DataGridViewTextBoxColumn
    Friend WithEvents chkboxpocz As RadioButton
    Friend WithEvents chkboxkoniec As RadioButton
    Friend WithEvents Label2 As Label
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents lblver As Label
    Friend WithEvents lblname As Label
    Friend WithEvents chkboxprzejdz As CheckBox
    Friend WithEvents chkboxdymek As CheckBox
    Friend WithEvents chkboxczas As CheckBox
    Friend WithEvents chkboxhide As CheckBox
    Friend WithEvents Label5 As Label
    Friend WithEvents nropoznienie As NumericUpDown
    Friend WithEvents Label4 As Label
    Friend WithEvents chkboxmkeys As CheckBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents btndelete As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents btnlocalsave As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lstkopie As ComboBox
    Friend WithEvents btnprzywroc As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btnzapisz As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents btnwgraj As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents savedialog As SaveFileDialog
    Friend WithEvents opendialog As OpenFileDialog
    Friend WithEvents btnwgrajcalosc As Button
    Friend WithEvents btngeneruj As Button
    Friend WithEvents chkboxhidealbums As CheckBox
    Friend WithEvents Label11 As Label
    Friend WithEvents lstdefaulttab As ComboBox
    Friend WithEvents btnpdf As Button
End Class

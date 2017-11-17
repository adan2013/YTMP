<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class genraport
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(genraport))
        Me.btngen = New System.Windows.Forms.Button()
        Me.btncb = New System.Windows.Forms.Button()
        Me.txtpodglad = New System.Windows.Forms.TextBox()
        Me.btnlokalny = New System.Windows.Forms.Button()
        Me.btnzpliku = New System.Windows.Forms.Button()
        Me.lblpath = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lstsep = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.radioopis = New System.Windows.Forms.RadioButton()
        Me.radiocsv = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.chkboxalfabet = New System.Windows.Forms.CheckBox()
        Me.lst3 = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lst2 = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lst1 = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.chkboxutw = New System.Windows.Forms.CheckBox()
        Me.chkboxalb = New System.Windows.Forms.CheckBox()
        Me.chkboxwyk = New System.Windows.Forms.CheckBox()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.savedialog = New System.Windows.Forms.SaveFileDialog()
        Me.opendialog = New System.Windows.Forms.OpenFileDialog()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btngen
        '
        Me.btngen.Location = New System.Drawing.Point(472, 327)
        Me.btngen.Name = "btngen"
        Me.btngen.Size = New System.Drawing.Size(100, 23)
        Me.btngen.TabIndex = 0
        Me.btngen.Text = "Generuj raport"
        Me.btngen.UseVisualStyleBackColor = True
        '
        'btncb
        '
        Me.btncb.Location = New System.Drawing.Point(316, 327)
        Me.btncb.Name = "btncb"
        Me.btncb.Size = New System.Drawing.Size(150, 23)
        Me.btncb.TabIndex = 1
        Me.btncb.Text = "Skopiuj do schowka"
        Me.btncb.UseVisualStyleBackColor = True
        '
        'txtpodglad
        '
        Me.txtpodglad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.txtpodglad.Location = New System.Drawing.Point(12, 197)
        Me.txtpodglad.Multiline = True
        Me.txtpodglad.Name = "txtpodglad"
        Me.txtpodglad.ReadOnly = True
        Me.txtpodglad.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtpodglad.Size = New System.Drawing.Size(560, 124)
        Me.txtpodglad.TabIndex = 2
        Me.txtpodglad.WordWrap = False
        '
        'btnlokalny
        '
        Me.btnlokalny.Location = New System.Drawing.Point(12, 12)
        Me.btnlokalny.Name = "btnlokalny"
        Me.btnlokalny.Size = New System.Drawing.Size(75, 23)
        Me.btnlokalny.TabIndex = 3
        Me.btnlokalny.Text = "Lokalny"
        Me.btnlokalny.UseVisualStyleBackColor = True
        '
        'btnzpliku
        '
        Me.btnzpliku.Location = New System.Drawing.Point(93, 12)
        Me.btnzpliku.Name = "btnzpliku"
        Me.btnzpliku.Size = New System.Drawing.Size(75, 23)
        Me.btnzpliku.TabIndex = 4
        Me.btnzpliku.Text = "Z pliku"
        Me.btnzpliku.UseVisualStyleBackColor = True
        '
        'lblpath
        '
        Me.lblpath.AutoSize = True
        Me.lblpath.Location = New System.Drawing.Point(174, 17)
        Me.lblpath.Name = "lblpath"
        Me.lblpath.Size = New System.Drawing.Size(90, 13)
        Me.lblpath.TabIndex = 5
        Me.lblpath.Text = "Biblioteka lokalna"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lstsep)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.radioopis)
        Me.GroupBox1.Controls.Add(Me.radiocsv)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 41)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(130, 110)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Prezentacja danych"
        '
        'lstsep
        '
        Me.lstsep.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.lstsep.FormattingEnabled = True
        Me.lstsep.Items.AddRange(New Object() {",", ".", "->", ">>", "-", "/", "\", "_"})
        Me.lstsep.Location = New System.Drawing.Point(68, 68)
        Me.lstsep.Name = "lstsep"
        Me.lstsep.Size = New System.Drawing.Size(56, 21)
        Me.lstsep.TabIndex = 14
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 70)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 13)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Separator:"
        '
        'radioopis
        '
        Me.radioopis.AutoSize = True
        Me.radioopis.Location = New System.Drawing.Point(6, 42)
        Me.radioopis.Name = "radioopis"
        Me.radioopis.Size = New System.Drawing.Size(65, 17)
        Me.radioopis.TabIndex = 1
        Me.radioopis.Text = "Opisowy"
        Me.radioopis.UseVisualStyleBackColor = True
        '
        'radiocsv
        '
        Me.radiocsv.AutoSize = True
        Me.radiocsv.Checked = True
        Me.radiocsv.Location = New System.Drawing.Point(6, 19)
        Me.radiocsv.Name = "radiocsv"
        Me.radiocsv.Size = New System.Drawing.Size(81, 17)
        Me.radiocsv.TabIndex = 0
        Me.radiocsv.TabStop = True
        Me.radiocsv.Text = "Format CSV"
        Me.radiocsv.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.chkboxalfabet)
        Me.GroupBox2.Controls.Add(Me.lst3)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.lst2)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.lst1)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.chkboxutw)
        Me.GroupBox2.Controls.Add(Me.chkboxalb)
        Me.GroupBox2.Controls.Add(Me.chkboxwyk)
        Me.GroupBox2.Location = New System.Drawing.Point(148, 41)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(424, 110)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Opcje widoku"
        '
        'chkboxalfabet
        '
        Me.chkboxalfabet.AutoSize = True
        Me.chkboxalfabet.Location = New System.Drawing.Point(6, 89)
        Me.chkboxalfabet.Name = "chkboxalfabet"
        Me.chkboxalfabet.Size = New System.Drawing.Size(143, 17)
        Me.chkboxalfabet.TabIndex = 14
        Me.chkboxalfabet.Text = "Sortuj linijki alfabetycznie"
        Me.chkboxalfabet.UseVisualStyleBackColor = True
        '
        'lst3
        '
        Me.lst3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.lst3.FormattingEnabled = True
        Me.lst3.Items.AddRange(New Object() {"(pusty)", "Tytuł utworu", "Album", "Wykonawca"})
        Me.lst3.Location = New System.Drawing.Point(269, 73)
        Me.lst3.Name = "lst3"
        Me.lst3.Size = New System.Drawing.Size(121, 21)
        Me.lst3.TabIndex = 13
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(209, 77)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "3 miejsce:"
        '
        'lst2
        '
        Me.lst2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.lst2.FormattingEnabled = True
        Me.lst2.Items.AddRange(New Object() {"(pusty)", "Tytuł utworu", "Album", "Wykonawca"})
        Me.lst2.Location = New System.Drawing.Point(269, 46)
        Me.lst2.Name = "lst2"
        Me.lst2.Size = New System.Drawing.Size(121, 21)
        Me.lst2.TabIndex = 11
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(209, 50)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "2 miejsce:"
        '
        'lst1
        '
        Me.lst1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.lst1.FormattingEnabled = True
        Me.lst1.Items.AddRange(New Object() {"(pusty)", "Tytuł utworu", "Album", "Wykonawca"})
        Me.lst1.Location = New System.Drawing.Point(269, 19)
        Me.lst1.Name = "lst1"
        Me.lst1.Size = New System.Drawing.Size(121, 21)
        Me.lst1.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(209, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "1 miejsce:"
        '
        'chkboxutw
        '
        Me.chkboxutw.AutoSize = True
        Me.chkboxutw.Location = New System.Drawing.Point(6, 66)
        Me.chkboxutw.Name = "chkboxutw"
        Me.chkboxutw.Size = New System.Drawing.Size(153, 17)
        Me.chkboxutw.TabIndex = 3
        Me.chkboxutw.Text = "Dodaj cudzysłów do tytułu"
        Me.chkboxutw.UseVisualStyleBackColor = True
        '
        'chkboxalb
        '
        Me.chkboxalb.AutoSize = True
        Me.chkboxalb.Location = New System.Drawing.Point(6, 19)
        Me.chkboxalb.Name = "chkboxalb"
        Me.chkboxalb.Size = New System.Drawing.Size(133, 17)
        Me.chkboxalb.TabIndex = 2
        Me.chkboxalb.Text = "Nie pisz: (brak albumu)"
        Me.chkboxalb.UseVisualStyleBackColor = True
        '
        'chkboxwyk
        '
        Me.chkboxwyk.AutoSize = True
        Me.chkboxwyk.Location = New System.Drawing.Point(6, 43)
        Me.chkboxwyk.Name = "chkboxwyk"
        Me.chkboxwyk.Size = New System.Drawing.Size(155, 17)
        Me.chkboxwyk.TabIndex = 1
        Me.chkboxwyk.Text = "Nie pisz: (brak wykonawcy)"
        Me.chkboxwyk.UseVisualStyleBackColor = True
        '
        'btnsave
        '
        Me.btnsave.Location = New System.Drawing.Point(210, 327)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(100, 23)
        Me.btnsave.TabIndex = 8
        Me.btnsave.Text = "Zapisz do pliku"
        Me.btnsave.UseVisualStyleBackColor = True
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
        'genraport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 362)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblpath)
        Me.Controls.Add(Me.btnzpliku)
        Me.Controls.Add(Me.btnlokalny)
        Me.Controls.Add(Me.txtpodglad)
        Me.Controls.Add(Me.btncb)
        Me.Controls.Add(Me.btngen)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "genraport"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Generuj raport"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btngen As Button
    Friend WithEvents btncb As Button
    Friend WithEvents txtpodglad As TextBox
    Friend WithEvents btnlokalny As Button
    Friend WithEvents btnzpliku As Button
    Friend WithEvents lblpath As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents radioopis As RadioButton
    Friend WithEvents radiocsv As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents chkboxwyk As CheckBox
    Friend WithEvents chkboxutw As CheckBox
    Friend WithEvents chkboxalb As CheckBox
    Friend WithEvents lst2 As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents lst1 As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lst3 As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents lstsep As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents btnsave As Button
    Friend WithEvents savedialog As SaveFileDialog
    Friend WithEvents opendialog As OpenFileDialog
    Friend WithEvents chkboxalfabet As CheckBox
End Class

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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tabela = New System.Windows.Forms.DataGridView()
        Me.k1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.k2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.k3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.k4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.k5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        CType(Me.tabela, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtprogress
        '
        Me.txtprogress.Location = New System.Drawing.Point(12, 283)
        Me.txtprogress.Margin = New System.Windows.Forms.Padding(4)
        Me.txtprogress.Multiline = True
        Me.txtprogress.Name = "txtprogress"
        Me.txtprogress.ReadOnly = True
        Me.txtprogress.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtprogress.Size = New System.Drawing.Size(350, 125)
        Me.txtprogress.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 262)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(157, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Postęp importu danych:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(175, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Utwory gotowe do importu:"
        '
        'tabela
        '
        Me.tabela.AllowUserToAddRows = False
        Me.tabela.AllowUserToDeleteRows = False
        Me.tabela.AllowUserToResizeRows = False
        Me.tabela.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.tabela.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tabela.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.k1, Me.k2, Me.k3, Me.k4, Me.k5})
        Me.tabela.Location = New System.Drawing.Point(12, 30)
        Me.tabela.MultiSelect = False
        Me.tabela.Name = "tabela"
        Me.tabela.ReadOnly = True
        Me.tabela.Size = New System.Drawing.Size(960, 207)
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
        'btnimport
        '
        Me.btnimport.Enabled = False
        Me.btnimport.Location = New System.Drawing.Point(872, 381)
        Me.btnimport.Name = "btnimport"
        Me.btnimport.Size = New System.Drawing.Size(100, 28)
        Me.btnimport.TabIndex = 4
        Me.btnimport.Text = "Importuj"
        Me.btnimport.UseVisualStyleBackColor = True
        '
        'radioauto
        '
        Me.radioauto.AutoSize = True
        Me.radioauto.Checked = True
        Me.radioauto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.radioauto.Location = New System.Drawing.Point(369, 331)
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
        Me.radiodirect.Location = New System.Drawing.Point(369, 356)
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
        Me.chkboxedit.Location = New System.Drawing.Point(369, 309)
        Me.chkboxedit.Name = "chkboxedit"
        Me.chkboxedit.Size = New System.Drawing.Size(261, 19)
        Me.chkboxedit.TabIndex = 7
        Me.chkboxedit.Text = "Otwórz okno edycji utworu przed dodaniem"
        Me.chkboxedit.UseVisualStyleBackColor = True
        '
        'btnpath
        '
        Me.btnpath.Enabled = False
        Me.btnpath.Location = New System.Drawing.Point(369, 381)
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
        Me.lblpath.Location = New System.Drawing.Point(428, 384)
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
        Me.Label3.Location = New System.Drawing.Point(732, 320)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(213, 30)
        Me.Label3.TabIndex = 30
        Me.Label3.Text = "Kliknij dwukrotnie na tytuł, wykonawcę" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "lub album, aby edytować wpis"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'akt
        '
        Me.akt.Interval = 150
        '
        'btndelete
        '
        Me.btndelete.Location = New System.Drawing.Point(891, 243)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(81, 25)
        Me.btndelete.TabIndex = 31
        Me.btndelete.Text = "Usuń wpis"
        Me.btndelete.UseVisualStyleBackColor = True
        '
        'chkboxpl
        '
        Me.chkboxpl.AutoSize = True
        Me.chkboxpl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.chkboxpl.Location = New System.Drawing.Point(369, 284)
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
        Me.lstpl.Location = New System.Drawing.Point(537, 284)
        Me.lstpl.Name = "lstpl"
        Me.lstpl.Size = New System.Drawing.Size(201, 21)
        Me.lstpl.TabIndex = 33
        '
        'btnnewpl
        '
        Me.btnnewpl.Enabled = False
        Me.btnnewpl.Location = New System.Drawing.Point(744, 284)
        Me.btnnewpl.Name = "btnnewpl"
        Me.btnnewpl.Size = New System.Drawing.Size(90, 21)
        Me.btnnewpl.TabIndex = 34
        Me.btnnewpl.Text = "Nowa playlista"
        Me.btnnewpl.UseVisualStyleBackColor = True
        '
        'IMPORTplaylist
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 421)
        Me.Controls.Add(Me.btnnewpl)
        Me.Controls.Add(Me.lstpl)
        Me.Controls.Add(Me.chkboxpl)
        Me.Controls.Add(Me.btndelete)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnpath)
        Me.Controls.Add(Me.lblpath)
        Me.Controls.Add(Me.chkboxedit)
        Me.Controls.Add(Me.radiodirect)
        Me.Controls.Add(Me.radioauto)
        Me.Controls.Add(Me.btnimport)
        Me.Controls.Add(Me.tabela)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtprogress)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "IMPORTplaylist"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Import playlisty"
        CType(Me.tabela, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtprogress As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents tabela As DataGridView
    Friend WithEvents btnimport As Button
    Friend WithEvents radioauto As RadioButton
    Friend WithEvents radiodirect As RadioButton
    Friend WithEvents chkboxedit As CheckBox
    Friend WithEvents btnpath As Button
    Friend WithEvents lblpath As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents k1 As DataGridViewTextBoxColumn
    Friend WithEvents k2 As DataGridViewTextBoxColumn
    Friend WithEvents k3 As DataGridViewTextBoxColumn
    Friend WithEvents k4 As DataGridViewTextBoxColumn
    Friend WithEvents k5 As DataGridViewTextBoxColumn
    Friend WithEvents akt As Timer
    Friend WithEvents btndelete As Button
    Friend WithEvents chkboxpl As CheckBox
    Friend WithEvents lstpl As ComboBox
    Friend WithEvents btnnewpl As Button
End Class

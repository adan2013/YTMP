<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MODutw
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MODutw))
        Me.btnok = New System.Windows.Forms.Button()
        Me.txtname = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnzmienid = New System.Windows.Forms.Button()
        Me.lblid = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.nrstartm = New System.Windows.Forms.NumericUpDown()
        Me.chkboxstart = New System.Windows.Forms.CheckBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.nrstarts = New System.Windows.Forms.NumericUpDown()
        Me.nrkoniecs = New System.Windows.Forms.NumericUpDown()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.chkboxkoniec = New System.Windows.Forms.CheckBox()
        Me.nrkoniecm = New System.Windows.Forms.NumericUpDown()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnpozycja = New System.Windows.Forms.Button()
        Me.btnpath = New System.Windows.Forms.Button()
        Me.lblpath = New System.Windows.Forms.Label()
        Me.btnyt = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.nrstartm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nrstarts, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nrkoniecs, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nrkoniecm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnok
        '
        Me.btnok.Location = New System.Drawing.Point(277, 327)
        Me.btnok.Name = "btnok"
        Me.btnok.Size = New System.Drawing.Size(75, 23)
        Me.btnok.TabIndex = 11
        Me.btnok.Text = "Dodaj"
        Me.btnok.UseVisualStyleBackColor = True
        '
        'txtname
        '
        Me.txtname.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.txtname.Location = New System.Drawing.Point(15, 72)
        Me.txtname.MaxLength = 50
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(337, 21)
        Me.txtname.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 15)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Tytuł utworu:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnzmienid)
        Me.GroupBox1.Controls.Add(Me.lblid)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 202)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(340, 80)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Identyfikator filmu"
        '
        'btnzmienid
        '
        Me.btnzmienid.Location = New System.Drawing.Point(234, 51)
        Me.btnzmienid.Name = "btnzmienid"
        Me.btnzmienid.Size = New System.Drawing.Size(100, 23)
        Me.btnzmienid.TabIndex = 29
        Me.btnzmienid.Text = "Zmień ID filmu"
        Me.btnzmienid.UseVisualStyleBackColor = True
        Me.btnzmienid.Visible = False
        '
        'lblid
        '
        Me.lblid.AutoSize = True
        Me.lblid.Font = New System.Drawing.Font("Consolas", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lblid.Location = New System.Drawing.Point(16, 22)
        Me.lblid.Name = "lblid"
        Me.lblid.Size = New System.Drawing.Size(150, 22)
        Me.lblid.TabIndex = 13
        Me.lblid.Text = "Nie przypisano"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 111)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(130, 15)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Początek odtwarzania:"
        '
        'nrstartm
        '
        Me.nrstartm.Enabled = False
        Me.nrstartm.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.nrstartm.Location = New System.Drawing.Point(15, 129)
        Me.nrstartm.Maximum = New Decimal(New Integer() {29, 0, 0, 0})
        Me.nrstartm.Name = "nrstartm"
        Me.nrstartm.Size = New System.Drawing.Size(60, 26)
        Me.nrstartm.TabIndex = 14
        '
        'chkboxstart
        '
        Me.chkboxstart.AutoSize = True
        Me.chkboxstart.Checked = True
        Me.chkboxstart.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkboxstart.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.chkboxstart.Location = New System.Drawing.Point(15, 161)
        Me.chkboxstart.Name = "chkboxstart"
        Me.chkboxstart.Size = New System.Drawing.Size(94, 19)
        Me.chkboxstart.TabIndex = 15
        Me.chkboxstart.Text = "Od początku"
        Me.chkboxstart.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label5.Location = New System.Drawing.Point(81, 129)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(19, 26)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = ":"
        '
        'nrstarts
        '
        Me.nrstarts.Enabled = False
        Me.nrstarts.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.nrstarts.Location = New System.Drawing.Point(106, 129)
        Me.nrstarts.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
        Me.nrstarts.Name = "nrstarts"
        Me.nrstarts.Size = New System.Drawing.Size(60, 26)
        Me.nrstarts.TabIndex = 17
        '
        'nrkoniecs
        '
        Me.nrkoniecs.Enabled = False
        Me.nrkoniecs.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.nrkoniecs.Location = New System.Drawing.Point(292, 129)
        Me.nrkoniecs.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
        Me.nrkoniecs.Name = "nrkoniecs"
        Me.nrkoniecs.Size = New System.Drawing.Size(60, 26)
        Me.nrkoniecs.TabIndex = 22
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label6.Location = New System.Drawing.Point(267, 129)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(19, 26)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = ":"
        '
        'chkboxkoniec
        '
        Me.chkboxkoniec.AutoSize = True
        Me.chkboxkoniec.Checked = True
        Me.chkboxkoniec.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkboxkoniec.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.chkboxkoniec.Location = New System.Drawing.Point(201, 161)
        Me.chkboxkoniec.Name = "chkboxkoniec"
        Me.chkboxkoniec.Size = New System.Drawing.Size(78, 19)
        Me.chkboxkoniec.TabIndex = 20
        Me.chkboxkoniec.Text = "Do końca"
        Me.chkboxkoniec.UseVisualStyleBackColor = True
        '
        'nrkoniecm
        '
        Me.nrkoniecm.Enabled = False
        Me.nrkoniecm.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.nrkoniecm.Location = New System.Drawing.Point(201, 129)
        Me.nrkoniecm.Maximum = New Decimal(New Integer() {29, 0, 0, 0})
        Me.nrkoniecm.Name = "nrkoniecm"
        Me.nrkoniecm.Size = New System.Drawing.Size(60, 26)
        Me.nrkoniecm.TabIndex = 19
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label7.Location = New System.Drawing.Point(198, 111)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(118, 15)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Koniec odtwarzania:"
        '
        'btnpozycja
        '
        Me.btnpozycja.Location = New System.Drawing.Point(12, 327)
        Me.btnpozycja.Name = "btnpozycja"
        Me.btnpozycja.Size = New System.Drawing.Size(150, 23)
        Me.btnpozycja.TabIndex = 24
        Me.btnpozycja.Text = "Zmień pozycję w albumie"
        Me.btnpozycja.UseVisualStyleBackColor = True
        Me.btnpozycja.Visible = False
        '
        'btnpath
        '
        Me.btnpath.Location = New System.Drawing.Point(12, 12)
        Me.btnpath.Name = "btnpath"
        Me.btnpath.Size = New System.Drawing.Size(50, 23)
        Me.btnpath.TabIndex = 27
        Me.btnpath.Text = "Zmień"
        Me.btnpath.UseVisualStyleBackColor = True
        '
        'lblpath
        '
        Me.lblpath.AutoSize = True
        Me.lblpath.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lblpath.Location = New System.Drawing.Point(71, 15)
        Me.lblpath.Margin = New System.Windows.Forms.Padding(6, 6, 3, 0)
        Me.lblpath.Name = "lblpath"
        Me.lblpath.Size = New System.Drawing.Size(39, 17)
        Me.lblpath.TabIndex = 26
        Me.lblpath.Text = "WYK"
        '
        'btnyt
        '
        Me.btnyt.Location = New System.Drawing.Point(12, 298)
        Me.btnyt.Name = "btnyt"
        Me.btnyt.Size = New System.Drawing.Size(150, 23)
        Me.btnyt.TabIndex = 28
        Me.btnyt.Text = "Otwórz w serwisie YouTube"
        Me.btnyt.UseVisualStyleBackColor = True
        Me.btnyt.Visible = False
        '
        'MODutw
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(364, 362)
        Me.Controls.Add(Me.btnyt)
        Me.Controls.Add(Me.btnpath)
        Me.Controls.Add(Me.lblpath)
        Me.Controls.Add(Me.btnpozycja)
        Me.Controls.Add(Me.nrkoniecs)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.chkboxkoniec)
        Me.Controls.Add(Me.nrkoniecm)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.nrstarts)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.chkboxstart)
        Me.Controls.Add(Me.nrstartm)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnok)
        Me.Controls.Add(Me.txtname)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MODutw"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Nowy utwór"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.nrstartm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nrstarts, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nrkoniecs, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nrkoniecm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnok As Button
    Friend WithEvents txtname As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblid As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents nrstartm As NumericUpDown
    Friend WithEvents chkboxstart As CheckBox
    Friend WithEvents Label5 As Label
    Friend WithEvents nrstarts As NumericUpDown
    Friend WithEvents nrkoniecs As NumericUpDown
    Friend WithEvents Label6 As Label
    Friend WithEvents chkboxkoniec As CheckBox
    Friend WithEvents nrkoniecm As NumericUpDown
    Friend WithEvents Label7 As Label
    Friend WithEvents btnpozycja As Button
    Friend WithEvents btnpath As Button
    Friend WithEvents lblpath As Label
    Friend WithEvents btnyt As Button
    Friend WithEvents btnzmienid As Button
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class selectdata
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(selectdata))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lstw = New System.Windows.Forms.ListBox()
        Me.lsta = New System.Windows.Forms.ListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnalla = New System.Windows.Forms.Button()
        Me.btnallw = New System.Windows.Forms.Button()
        Me.btnadd = New System.Windows.Forms.Button()
        Me.lstu = New System.Windows.Forms.ListBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btndel = New System.Windows.Forms.Button()
        Me.lst = New System.Windows.Forms.ListBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnclear = New System.Windows.Forms.Button()
        Me.btnok = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Wykonawcy:"
        '
        'lstw
        '
        Me.lstw.FormattingEnabled = True
        Me.lstw.Location = New System.Drawing.Point(15, 29)
        Me.lstw.Name = "lstw"
        Me.lstw.ScrollAlwaysVisible = True
        Me.lstw.Size = New System.Drawing.Size(200, 225)
        Me.lstw.TabIndex = 1
        '
        'lsta
        '
        Me.lsta.FormattingEnabled = True
        Me.lsta.Location = New System.Drawing.Point(221, 29)
        Me.lsta.Name = "lsta"
        Me.lsta.ScrollAlwaysVisible = True
        Me.lsta.Size = New System.Drawing.Size(200, 225)
        Me.lsta.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label2.Location = New System.Drawing.Point(218, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Albumy:"
        '
        'btnalla
        '
        Me.btnalla.Enabled = False
        Me.btnalla.Location = New System.Drawing.Point(271, 260)
        Me.btnalla.Name = "btnalla"
        Me.btnalla.Size = New System.Drawing.Size(150, 23)
        Me.btnalla.TabIndex = 4
        Me.btnalla.Text = "Dodaj wszystkie z albumu"
        Me.btnalla.UseVisualStyleBackColor = True
        '
        'btnallw
        '
        Me.btnallw.Enabled = False
        Me.btnallw.Location = New System.Drawing.Point(65, 260)
        Me.btnallw.Name = "btnallw"
        Me.btnallw.Size = New System.Drawing.Size(150, 23)
        Me.btnallw.TabIndex = 5
        Me.btnallw.Text = "Dodaj wszystkie wykonawcy"
        Me.btnallw.UseVisualStyleBackColor = True
        '
        'btnadd
        '
        Me.btnadd.Enabled = False
        Me.btnadd.Location = New System.Drawing.Point(477, 260)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(150, 23)
        Me.btnadd.TabIndex = 8
        Me.btnadd.Text = "Dodaj utwór"
        Me.btnadd.UseVisualStyleBackColor = True
        '
        'lstu
        '
        Me.lstu.FormattingEnabled = True
        Me.lstu.Location = New System.Drawing.Point(427, 29)
        Me.lstu.Name = "lstu"
        Me.lstu.ScrollAlwaysVisible = True
        Me.lstu.Size = New System.Drawing.Size(200, 225)
        Me.lstu.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label3.Location = New System.Drawing.Point(424, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 17)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Utwory:"
        '
        'btndel
        '
        Me.btndel.Enabled = False
        Me.btndel.Location = New System.Drawing.Point(817, 260)
        Me.btndel.Name = "btndel"
        Me.btndel.Size = New System.Drawing.Size(75, 23)
        Me.btndel.TabIndex = 11
        Me.btndel.Text = "Usuń z listy"
        Me.btndel.UseVisualStyleBackColor = True
        '
        'lst
        '
        Me.lst.FormattingEnabled = True
        Me.lst.Location = New System.Drawing.Point(662, 29)
        Me.lst.Name = "lst"
        Me.lst.ScrollAlwaysVisible = True
        Me.lst.Size = New System.Drawing.Size(230, 225)
        Me.lst.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label4.Location = New System.Drawing.Point(659, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(130, 17)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Utwory do dodania:"
        '
        'btnclear
        '
        Me.btnclear.Enabled = False
        Me.btnclear.Location = New System.Drawing.Point(662, 260)
        Me.btnclear.Name = "btnclear"
        Me.btnclear.Size = New System.Drawing.Size(90, 23)
        Me.btnclear.TabIndex = 12
        Me.btnclear.Text = "Wyczyść listę"
        Me.btnclear.UseVisualStyleBackColor = True
        '
        'btnok
        '
        Me.btnok.Enabled = False
        Me.btnok.Location = New System.Drawing.Point(742, 306)
        Me.btnok.Name = "btnok"
        Me.btnok.Size = New System.Drawing.Size(150, 23)
        Me.btnok.TabIndex = 13
        Me.btnok.Text = "Zatwierdź transfer utworów"
        Me.btnok.UseVisualStyleBackColor = True
        '
        'selectdata
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(904, 341)
        Me.Controls.Add(Me.btnok)
        Me.Controls.Add(Me.btnclear)
        Me.Controls.Add(Me.btndel)
        Me.Controls.Add(Me.lst)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnadd)
        Me.Controls.Add(Me.lstu)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnallw)
        Me.Controls.Add(Me.btnalla)
        Me.Controls.Add(Me.lsta)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lstw)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "selectdata"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Wybór elementów biblioteki"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lstw As ListBox
    Friend WithEvents lsta As ListBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnalla As Button
    Friend WithEvents btnallw As Button
    Friend WithEvents btnadd As Button
    Friend WithEvents lstu As ListBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btndel As Button
    Friend WithEvents lst As ListBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btnclear As Button
    Friend WithEvents btnok As Button
End Class

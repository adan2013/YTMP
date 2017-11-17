<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class selectform
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(selectform))
        Me.btnok = New System.Windows.Forms.Button()
        Me.txtsearch = New System.Windows.Forms.TextBox()
        Me.lista = New System.Windows.Forms.ListBox()
        Me.lbltytul = New System.Windows.Forms.Label()
        Me.btnnowy = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnok
        '
        Me.btnok.Location = New System.Drawing.Point(277, 327)
        Me.btnok.Name = "btnok"
        Me.btnok.Size = New System.Drawing.Size(75, 23)
        Me.btnok.TabIndex = 1
        Me.btnok.Text = "Wybierz"
        Me.btnok.UseVisualStyleBackColor = True
        '
        'txtsearch
        '
        Me.txtsearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.txtsearch.ForeColor = System.Drawing.Color.Gray
        Me.txtsearch.Location = New System.Drawing.Point(12, 64)
        Me.txtsearch.Name = "txtsearch"
        Me.txtsearch.Size = New System.Drawing.Size(340, 23)
        Me.txtsearch.TabIndex = 0
        Me.txtsearch.Text = "Szukaj..."
        '
        'lista
        '
        Me.lista.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lista.FormattingEnabled = True
        Me.lista.ItemHeight = 16
        Me.lista.Location = New System.Drawing.Point(12, 93)
        Me.lista.Name = "lista"
        Me.lista.ScrollAlwaysVisible = True
        Me.lista.Size = New System.Drawing.Size(340, 228)
        Me.lista.TabIndex = 2
        Me.lista.TabStop = False
        '
        'lbltytul
        '
        Me.lbltytul.AutoSize = True
        Me.lbltytul.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lbltytul.Location = New System.Drawing.Point(12, 9)
        Me.lbltytul.Name = "lbltytul"
        Me.lbltytul.Size = New System.Drawing.Size(78, 48)
        Me.lbltytul.TabIndex = 3
        Me.lbltytul.Text = "Wybierz" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Wybierz"
        '
        'btnnowy
        '
        Me.btnnowy.Location = New System.Drawing.Point(12, 327)
        Me.btnnowy.Name = "btnnowy"
        Me.btnnowy.Size = New System.Drawing.Size(100, 23)
        Me.btnnowy.TabIndex = 4
        Me.btnnowy.Text = "Nowa pozycja"
        Me.btnnowy.UseVisualStyleBackColor = True
        '
        'selectform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(364, 362)
        Me.Controls.Add(Me.btnnowy)
        Me.Controls.Add(Me.lbltytul)
        Me.Controls.Add(Me.lista)
        Me.Controls.Add(Me.txtsearch)
        Me.Controls.Add(Me.btnok)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "selectform"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Wybierz obiekt"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnok As Button
    Friend WithEvents txtsearch As TextBox
    Friend WithEvents lista As ListBox
    Friend WithEvents lbltytul As Label
    Friend WithEvents btnnowy As Button
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class instrukcja
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(instrukcja))
        Me.btnstart = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnpdf = New System.Windows.Forms.Button()
        Me.pnlbtn = New System.Windows.Forms.Panel()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlbtn.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnstart
        '
        Me.btnstart.Location = New System.Drawing.Point(159, 3)
        Me.btnstart.Name = "btnstart"
        Me.btnstart.Size = New System.Drawing.Size(150, 35)
        Me.btnstart.TabIndex = 0
        Me.btnstart.Text = "Uruchom aplikację"
        Me.btnstart.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(710, 289)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'btnpdf
        '
        Me.btnpdf.Location = New System.Drawing.Point(3, 3)
        Me.btnpdf.Name = "btnpdf"
        Me.btnpdf.Size = New System.Drawing.Size(150, 35)
        Me.btnpdf.TabIndex = 2
        Me.btnpdf.Text = "Otwórz instrukcję PDF"
        Me.btnpdf.UseVisualStyleBackColor = True
        '
        'pnlbtn
        '
        Me.pnlbtn.Controls.Add(Me.btnpdf)
        Me.pnlbtn.Controls.Add(Me.btnstart)
        Me.pnlbtn.Location = New System.Drawing.Point(211, 307)
        Me.pnlbtn.Name = "pnlbtn"
        Me.pnlbtn.Size = New System.Drawing.Size(312, 42)
        Me.pnlbtn.TabIndex = 3
        '
        'instrukcja
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(734, 361)
        Me.Controls.Add(Me.pnlbtn)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "instrukcja"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "YTMP - Wprowadzenie"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlbtn.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnstart As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnpdf As Button
    Friend WithEvents pnlbtn As Panel
End Class

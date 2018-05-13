<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.pnltop = New System.Windows.Forms.Panel()
        Me.lbl2 = New System.Windows.Forms.Label()
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.txtlog = New System.Windows.Forms.TextBox()
        Me.btnclose = New System.Windows.Forms.Button()
        Me.BWinstall = New System.ComponentModel.BackgroundWorker()
        Me.pnltop.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnltop
        '
        Me.pnltop.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.pnltop.Controls.Add(Me.lbl2)
        Me.pnltop.Controls.Add(Me.lbl1)
        Me.pnltop.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnltop.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.pnltop.Location = New System.Drawing.Point(0, 0)
        Me.pnltop.Name = "pnltop"
        Me.pnltop.Size = New System.Drawing.Size(484, 60)
        Me.pnltop.TabIndex = 0
        '
        'lbl2
        '
        Me.lbl2.AutoSize = True
        Me.lbl2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lbl2.Location = New System.Drawing.Point(12, 28)
        Me.lbl2.Margin = New System.Windows.Forms.Padding(6, 0, 3, 0)
        Me.lbl2.Name = "lbl2"
        Me.lbl2.Size = New System.Drawing.Size(215, 15)
        Me.lbl2.TabIndex = 1
        Me.lbl2.Text = "Proszę czekać, może to chwilę zająć..."
        '
        'lbl1
        '
        Me.lbl1.AutoSize = True
        Me.lbl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lbl1.Location = New System.Drawing.Point(12, 12)
        Me.lbl1.Margin = New System.Windows.Forms.Padding(3, 3, 3, 0)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(355, 16)
        Me.lbl1.TabIndex = 0
        Me.lbl1.Text = "Trwa aktualizacja aplikacji YouTube Media Player"
        '
        'txtlog
        '
        Me.txtlog.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtlog.Font = New System.Drawing.Font("Consolas", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.txtlog.Location = New System.Drawing.Point(19, 73)
        Me.txtlog.Margin = New System.Windows.Forms.Padding(10)
        Me.txtlog.Multiline = True
        Me.txtlog.Name = "txtlog"
        Me.txtlog.ReadOnly = True
        Me.txtlog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtlog.Size = New System.Drawing.Size(446, 246)
        Me.txtlog.TabIndex = 1
        '
        'btnclose
        '
        Me.btnclose.Enabled = False
        Me.btnclose.Location = New System.Drawing.Point(365, 332)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(100, 28)
        Me.btnclose.TabIndex = 2
        Me.btnclose.Text = "Zamknij"
        Me.btnclose.UseVisualStyleBackColor = True
        '
        'BWinstall
        '
        Me.BWinstall.WorkerSupportsCancellation = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(484, 372)
        Me.Controls.Add(Me.btnclose)
        Me.Controls.Add(Me.txtlog)
        Me.Controls.Add(Me.pnltop)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Aktualizacja YTMP"
        Me.pnltop.ResumeLayout(False)
        Me.pnltop.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pnltop As Panel
    Friend WithEvents lbl2 As Label
    Friend WithEvents lbl1 As Label
    Friend WithEvents txtlog As TextBox
    Friend WithEvents btnclose As Button
    Friend WithEvents BWinstall As System.ComponentModel.BackgroundWorker
End Class

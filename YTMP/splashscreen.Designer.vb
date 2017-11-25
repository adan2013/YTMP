<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class splashscreen
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(splashscreen))
        Me.img = New System.Windows.Forms.PictureBox()
        Me.tmr = New System.Windows.Forms.Timer(Me.components)
        CType(Me.img, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'img
        '
        Me.img.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.img.Dock = System.Windows.Forms.DockStyle.Fill
        Me.img.Image = Global.YTMP.My.Resources.Resources.splashscreen
        Me.img.Location = New System.Drawing.Point(0, 0)
        Me.img.Name = "img"
        Me.img.Size = New System.Drawing.Size(710, 289)
        Me.img.TabIndex = 0
        Me.img.TabStop = False
        '
        'tmr
        '
        Me.tmr.Enabled = True
        Me.tmr.Interval = 1200
        '
        'splashscreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(710, 289)
        Me.Controls.Add(Me.img)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "splashscreen"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "YTMP"
        Me.TopMost = True
        CType(Me.img, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents img As PictureBox
    Friend WithEvents tmr As Timer
End Class

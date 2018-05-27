<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LISTcontrol
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.flp = New System.Windows.Forms.FlowLayoutPanel()
        Me.SuspendLayout()
        '
        'flp
        '
        Me.flp.AutoScroll = True
        Me.flp.Dock = System.Windows.Forms.DockStyle.Fill
        Me.flp.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.flp.Location = New System.Drawing.Point(0, 0)
        Me.flp.Name = "flp"
        Me.flp.Size = New System.Drawing.Size(150, 150)
        Me.flp.TabIndex = 0
        '
        'LISTcontrol
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.flp)
        Me.Name = "LISTcontrol"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents flp As FlowLayoutPanel
End Class

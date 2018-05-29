<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LISTitem
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
        Me.components = New System.ComponentModel.Container()
        Me.btn3 = New System.Windows.Forms.PictureBox()
        Me.btn2 = New System.Windows.Forms.PictureBox()
        Me.btn1 = New System.Windows.Forms.PictureBox()
        Me.lbldodano = New System.Windows.Forms.Label()
        Me.tmrhidelbl = New System.Windows.Forms.Timer(Me.components)
        CType(Me.btn3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn3
        '
        Me.btn3.BackColor = System.Drawing.Color.Transparent
        Me.btn3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn3.Image = Global.YTMP.My.Resources.Resources.grayDelete
        Me.btn3.Location = New System.Drawing.Point(350, 38)
        Me.btn3.Margin = New System.Windows.Forms.Padding(4, 3, 4, 8)
        Me.btn3.Name = "btn3"
        Me.btn3.Size = New System.Drawing.Size(24, 24)
        Me.btn3.TabIndex = 1
        Me.btn3.TabStop = False
        Me.btn3.Visible = False
        '
        'btn2
        '
        Me.btn2.BackColor = System.Drawing.Color.Transparent
        Me.btn2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn2.Image = Global.YTMP.My.Resources.Resources.grayEdit
        Me.btn2.Location = New System.Drawing.Point(318, 38)
        Me.btn2.Margin = New System.Windows.Forms.Padding(4, 3, 4, 8)
        Me.btn2.Name = "btn2"
        Me.btn2.Size = New System.Drawing.Size(24, 24)
        Me.btn2.TabIndex = 2
        Me.btn2.TabStop = False
        Me.btn2.Visible = False
        '
        'btn1
        '
        Me.btn1.BackColor = System.Drawing.Color.Transparent
        Me.btn1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn1.Image = Global.YTMP.My.Resources.Resources.grayAdd
        Me.btn1.Location = New System.Drawing.Point(286, 38)
        Me.btn1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 8)
        Me.btn1.Name = "btn1"
        Me.btn1.Size = New System.Drawing.Size(24, 24)
        Me.btn1.TabIndex = 3
        Me.btn1.TabStop = False
        Me.btn1.Visible = False
        '
        'lbldodano
        '
        Me.lbldodano.AutoSize = True
        Me.lbldodano.BackColor = System.Drawing.Color.Transparent
        Me.lbldodano.Font = New System.Drawing.Font("Segoe UI Black", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lbldodano.ForeColor = System.Drawing.Color.ForestGreen
        Me.lbldodano.Location = New System.Drawing.Point(218, 47)
        Me.lbldodano.Margin = New System.Windows.Forms.Padding(3, 0, 5, 8)
        Me.lbldodano.Name = "lbldodano"
        Me.lbldodano.Size = New System.Drawing.Size(59, 15)
        Me.lbldodano.TabIndex = 4
        Me.lbldodano.Text = "Dodano!"
        Me.lbldodano.Visible = False
        '
        'tmrhidelbl
        '
        Me.tmrhidelbl.Interval = 1000
        '
        'LISTitem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.lbldodano)
        Me.Controls.Add(Me.btn1)
        Me.Controls.Add(Me.btn2)
        Me.Controls.Add(Me.btn3)
        Me.Name = "LISTitem"
        Me.Size = New System.Drawing.Size(395, 70)
        CType(Me.btn3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn3 As PictureBox
    Friend WithEvents btn2 As PictureBox
    Friend WithEvents btn1 As PictureBox
    Friend WithEvents lbldodano As Label
    Friend WithEvents tmrhidelbl As Timer
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class loadingscreen
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pbloading = New System.Windows.Forms.ProgressBar()
        Me.lbl_context = New System.Windows.Forms.Label()
        Me.lbl_percentprog = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Maroon
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(721, 100)
        Me.Panel1.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.project1.My.Resources.Resources.logo_transparent
        Me.PictureBox1.Location = New System.Drawing.Point(269, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(177, 100)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Maroon
        Me.Label1.Location = New System.Drawing.Point(47, 137)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(613, 32)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = " STA'S ATTENDANCE MONITORING SYSTEM"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'pbloading
        '
        Me.pbloading.Location = New System.Drawing.Point(172, 199)
        Me.pbloading.Name = "pbloading"
        Me.pbloading.Size = New System.Drawing.Size(409, 32)
        Me.pbloading.TabIndex = 2
        '
        'lbl_context
        '
        Me.lbl_context.AutoSize = True
        Me.lbl_context.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_context.Location = New System.Drawing.Point(168, 234)
        Me.lbl_context.Name = "lbl_context"
        Me.lbl_context.Size = New System.Drawing.Size(217, 19)
        Me.lbl_context.TabIndex = 3
        Me.lbl_context.Text = "LAUNCHING APLICATION"
        '
        'lbl_percentprog
        '
        Me.lbl_percentprog.AutoSize = True
        Me.lbl_percentprog.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_percentprog.Location = New System.Drawing.Point(538, 234)
        Me.lbl_percentprog.Name = "lbl_percentprog"
        Me.lbl_percentprog.Size = New System.Drawing.Size(52, 19)
        Me.lbl_percentprog.TabIndex = 4
        Me.lbl_percentprog.Text = "000%"
        Me.lbl_percentprog.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 40
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = Global.project1.My.Resources.Resources.y3Hm3
        Me.PictureBox2.Location = New System.Drawing.Point(298, 269)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(162, 99)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 5
        Me.PictureBox2.TabStop = False
        '
        'loadingscreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(721, 403)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.lbl_percentprog)
        Me.Controls.Add(Me.lbl_context)
        Me.Controls.Add(Me.pbloading)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "loadingscreen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "loadingscreen"
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents pbloading As ProgressBar
    Friend WithEvents lbl_context As Label
    Friend WithEvents lbl_percentprog As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents PictureBox2 As PictureBox
End Class

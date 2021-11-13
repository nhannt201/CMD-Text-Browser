<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class browser2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(browser2))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.access = New System.Windows.Forms.TextBox()
        Me.brtext = New System.Windows.Forms.Button()
        Me.brcmd = New System.Windows.Forms.Button()
        Me.pb1 = New System.Windows.Forms.PictureBox()
        Me.pbline = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.status = New System.Windows.Forms.Label()
        Me.timetruyvan = New System.Windows.Forms.Timer(Me.components)
        CType(Me.pb1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbline, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(538, 251)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(276, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Please enter the address"
        Me.Label1.Visible = False
        '
        'access
        '
        Me.access.Location = New System.Drawing.Point(466, 288)
        Me.access.Name = "access"
        Me.access.Size = New System.Drawing.Size(419, 20)
        Me.access.TabIndex = 1
        Me.access.Text = "cmd>presscoder.net>tasklist"
        Me.access.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.access.Visible = False
        '
        'brtext
        '
        Me.brtext.BackColor = System.Drawing.Color.White
        Me.brtext.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.brtext.Location = New System.Drawing.Point(515, 317)
        Me.brtext.Name = "brtext"
        Me.brtext.Size = New System.Drawing.Size(149, 41)
        Me.brtext.TabIndex = 2
        Me.brtext.Text = "&Browse Texts"
        Me.brtext.UseVisualStyleBackColor = False
        Me.brtext.Visible = False
        '
        'brcmd
        '
        Me.brcmd.BackColor = System.Drawing.Color.White
        Me.brcmd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.brcmd.Location = New System.Drawing.Point(693, 317)
        Me.brcmd.Name = "brcmd"
        Me.brcmd.Size = New System.Drawing.Size(156, 41)
        Me.brcmd.TabIndex = 3
        Me.brcmd.Text = "&Browse Command And BAT"
        Me.brcmd.UseVisualStyleBackColor = False
        Me.brcmd.Visible = False
        '
        'pb1
        '
        Me.pb1.BackColor = System.Drawing.Color.Transparent
        Me.pb1.Image = Global.CMD_Text_Browser.My.Resources.Resources.logo2
        Me.pb1.Location = New System.Drawing.Point(546, 64)
        Me.pb1.Name = "pb1"
        Me.pb1.Size = New System.Drawing.Size(268, 141)
        Me.pb1.TabIndex = 4
        Me.pb1.TabStop = False
        Me.pb1.Visible = False
        '
        'pbline
        '
        Me.pbline.BackColor = System.Drawing.Color.White
        Me.pbline.Location = New System.Drawing.Point(257, 383)
        Me.pbline.Name = "pbline"
        Me.pbline.Size = New System.Drawing.Size(857, 1)
        Me.pbline.TabIndex = 5
        Me.pbline.TabStop = False
        Me.pbline.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(538, 398)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(242, 18)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Created by Nguyen Trung Nhan"
        Me.Label2.Visible = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'status
        '
        Me.status.AutoSize = True
        Me.status.BackColor = System.Drawing.Color.Transparent
        Me.status.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.status.ForeColor = System.Drawing.Color.White
        Me.status.Location = New System.Drawing.Point(606, 219)
        Me.status.Name = "status"
        Me.status.Size = New System.Drawing.Size(155, 18)
        Me.status.TabIndex = 7
        Me.status.Text = "Server CMD On All."
        Me.status.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.status.Visible = False
        '
        'timetruyvan
        '
        Me.timetruyvan.Interval = 500
        '
        'browser2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(1348, 733)
        Me.Controls.Add(Me.status)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.pbline)
        Me.Controls.Add(Me.pb1)
        Me.Controls.Add(Me.brcmd)
        Me.Controls.Add(Me.brtext)
        Me.Controls.Add(Me.access)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "browser2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CMD Text Browser"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.pb1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbline, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents access As TextBox
    Friend WithEvents brtext As Button
    Friend WithEvents brcmd As Button
    Friend WithEvents pb1 As PictureBox
    Friend WithEvents pbline As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents status As Label
    Friend WithEvents timetruyvan As Timer
End Class

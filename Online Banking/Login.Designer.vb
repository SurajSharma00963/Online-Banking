<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Admin = New System.Windows.Forms.PictureBox()
        Me.User = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Staff = New System.Windows.Forms.PictureBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Admin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.User, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Staff, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.LightSlateGray
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button1.Location = New System.Drawing.Point(173, 132)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(155, 23)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Product And Services"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.LightSlateGray
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button3.Location = New System.Drawing.Point(12, 132)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(155, 23)
        Me.Button3.TabIndex = 8
        Me.Button3.Text = "Home"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(204, 114)
        Me.PictureBox2.TabIndex = 7
        Me.PictureBox2.TabStop = False
        '
        'Admin
        '
        Me.Admin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Admin.Image = CType(resources.GetObject("Admin.Image"), System.Drawing.Image)
        Me.Admin.Location = New System.Drawing.Point(119, 228)
        Me.Admin.Name = "Admin"
        Me.Admin.Size = New System.Drawing.Size(375, 188)
        Me.Admin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Admin.TabIndex = 10
        Me.Admin.TabStop = False
        Me.Admin.Visible = False
        '
        'User
        '
        Me.User.Cursor = System.Windows.Forms.Cursors.Hand
        Me.User.Image = CType(resources.GetObject("User.Image"), System.Drawing.Image)
        Me.User.Location = New System.Drawing.Point(119, 228)
        Me.User.Name = "User"
        Me.User.Size = New System.Drawing.Size(375, 188)
        Me.User.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.User.TabIndex = 11
        Me.User.TabStop = False
        Me.User.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Silver
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(1194, 692)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 31)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Back"
        '
        'Staff
        '
        Me.Staff.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Staff.Image = CType(resources.GetObject("Staff.Image"), System.Drawing.Image)
        Me.Staff.Location = New System.Drawing.Point(119, 228)
        Me.Staff.Name = "Staff"
        Me.Staff.Size = New System.Drawing.Size(375, 188)
        Me.Staff.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Staff.TabIndex = 13
        Me.Staff.TabStop = False
        Me.Staff.Visible = False
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"ADMIN LOGIN", "STAFF LOGIN", "USER LOGIN"})
        Me.ComboBox1.Location = New System.Drawing.Point(119, 176)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(375, 29)
        Me.ComboBox1.TabIndex = 14
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleTurquoise
        Me.ClientSize = New System.Drawing.Size(1370, 772)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Staff)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.User)
        Me.Controls.Add(Me.Admin)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.PictureBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Admin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.User, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Staff, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Admin As System.Windows.Forms.PictureBox
    Friend WithEvents User As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Staff As System.Windows.Forms.PictureBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
End Class

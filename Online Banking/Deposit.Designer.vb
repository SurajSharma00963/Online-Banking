<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Deposit
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Deposit))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.amount = New System.Windows.Forms.TextBox()
        Me.amountlbl = New System.Windows.Forms.Label()
        Me.Close_but = New System.Windows.Forms.Button()
        Me.Depositbtn = New System.Windows.Forms.Button()
        Me.Account_no = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Customername = New System.Windows.Forms.TextBox()
        Me.Cname = New System.Windows.Forms.Label()
        Me.Go = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Label2.Font = New System.Drawing.Font("Modern No. 20", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label2.Location = New System.Drawing.Point(208, 94)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(219, 31)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Deposit Amount"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Online_Banking.My.Resources.Resources.Deposit1
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(190, 113)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'amount
        '
        Me.amount.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.amount.Location = New System.Drawing.Point(490, 318)
        Me.amount.Name = "amount"
        Me.amount.Size = New System.Drawing.Size(304, 30)
        Me.amount.TabIndex = 33
        Me.amount.Visible = False
        '
        'amountlbl
        '
        Me.amountlbl.AutoSize = True
        Me.amountlbl.BackColor = System.Drawing.Color.AliceBlue
        Me.amountlbl.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.amountlbl.Location = New System.Drawing.Point(305, 322)
        Me.amountlbl.Name = "amountlbl"
        Me.amountlbl.Size = New System.Drawing.Size(83, 24)
        Me.amountlbl.TabIndex = 32
        Me.amountlbl.Text = "Amount"
        Me.amountlbl.Visible = False
        '
        'Close_but
        '
        Me.Close_but.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Close_but.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Close_but.Location = New System.Drawing.Point(800, 377)
        Me.Close_but.Name = "Close_but"
        Me.Close_but.Size = New System.Drawing.Size(104, 32)
        Me.Close_but.TabIndex = 31
        Me.Close_but.Text = "Close"
        Me.Close_but.UseVisualStyleBackColor = True
        Me.Close_but.Visible = False
        '
        'Depositbtn
        '
        Me.Depositbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Depositbtn.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Depositbtn.Location = New System.Drawing.Point(690, 377)
        Me.Depositbtn.Name = "Depositbtn"
        Me.Depositbtn.Size = New System.Drawing.Size(104, 32)
        Me.Depositbtn.TabIndex = 30
        Me.Depositbtn.Text = "Deposit"
        Me.Depositbtn.UseVisualStyleBackColor = True
        Me.Depositbtn.Visible = False
        '
        'Account_no
        '
        Me.Account_no.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Account_no.Location = New System.Drawing.Point(339, 185)
        Me.Account_no.Name = "Account_no"
        Me.Account_no.Size = New System.Drawing.Size(304, 30)
        Me.Account_no.TabIndex = 29
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.AliceBlue
        Me.Label8.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(154, 185)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(134, 24)
        Me.Label8.TabIndex = 28
        Me.Label8.Text = "Account No.*"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.AliceBlue
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(38, 128)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(980, 331)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Deposit"
        '
        'Customername
        '
        Me.Customername.Enabled = False
        Me.Customername.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Customername.Location = New System.Drawing.Point(490, 271)
        Me.Customername.Name = "Customername"
        Me.Customername.Size = New System.Drawing.Size(304, 30)
        Me.Customername.TabIndex = 35
        Me.Customername.Visible = False
        '
        'Cname
        '
        Me.Cname.AutoSize = True
        Me.Cname.BackColor = System.Drawing.Color.AliceBlue
        Me.Cname.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cname.Location = New System.Drawing.Point(305, 275)
        Me.Cname.Name = "Cname"
        Me.Cname.Size = New System.Drawing.Size(63, 24)
        Me.Cname.TabIndex = 34
        Me.Cname.Text = "Name"
        Me.Cname.Visible = False
        '
        'Go
        '
        Me.Go.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Go.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Go.Location = New System.Drawing.Point(539, 221)
        Me.Go.Name = "Go"
        Me.Go.Size = New System.Drawing.Size(104, 32)
        Me.Go.TabIndex = 36
        Me.Go.Text = "Go"
        Me.Go.UseVisualStyleBackColor = True
        '
        'Deposit
        '
        Me.AccessibleDescription = ""
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MediumTurquoise
        Me.ClientSize = New System.Drawing.Size(1064, 513)
        Me.Controls.Add(Me.Go)
        Me.Controls.Add(Me.Customername)
        Me.Controls.Add(Me.Cname)
        Me.Controls.Add(Me.amount)
        Me.Controls.Add(Me.amountlbl)
        Me.Controls.Add(Me.Close_but)
        Me.Controls.Add(Me.Depositbtn)
        Me.Controls.Add(Me.Account_no)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Deposit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add_Balance"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents amount As System.Windows.Forms.TextBox
    Friend WithEvents amountlbl As System.Windows.Forms.Label
    Friend WithEvents Close_but As System.Windows.Forms.Button
    Friend WithEvents Depositbtn As System.Windows.Forms.Button
    Friend WithEvents Account_no As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Customername As System.Windows.Forms.TextBox
    Friend WithEvents Cname As System.Windows.Forms.Label
    Friend WithEvents Go As System.Windows.Forms.Button
End Class

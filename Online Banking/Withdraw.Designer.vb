<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Withdraw
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Withdraw))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.amount = New System.Windows.Forms.TextBox()
        Me.Amountlbl = New System.Windows.Forms.Label()
        Me.Back = New System.Windows.Forms.Button()
        Me.withdraw_but = New System.Windows.Forms.Button()
        Me.Account_no = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.CustomerName = New System.Windows.Forms.TextBox()
        Me.cname = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label1.Location = New System.Drawing.Point(264, 126)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(251, 31)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Withdraw Amount"
        '
        'amount
        '
        Me.amount.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.amount.Location = New System.Drawing.Point(626, 376)
        Me.amount.Name = "amount"
        Me.amount.Size = New System.Drawing.Size(304, 30)
        Me.amount.TabIndex = 39
        Me.amount.Visible = False
        '
        'Amountlbl
        '
        Me.Amountlbl.AutoSize = True
        Me.Amountlbl.BackColor = System.Drawing.Color.AliceBlue
        Me.Amountlbl.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Amountlbl.Location = New System.Drawing.Point(441, 380)
        Me.Amountlbl.Name = "Amountlbl"
        Me.Amountlbl.Size = New System.Drawing.Size(83, 24)
        Me.Amountlbl.TabIndex = 38
        Me.Amountlbl.Text = "Amount"
        Me.Amountlbl.Visible = False
        '
        'Back
        '
        Me.Back.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Back.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Back.Location = New System.Drawing.Point(977, 462)
        Me.Back.Name = "Back"
        Me.Back.Size = New System.Drawing.Size(104, 32)
        Me.Back.TabIndex = 37
        Me.Back.Text = "Back"
        Me.Back.UseVisualStyleBackColor = True
        Me.Back.Visible = False
        '
        'withdraw_but
        '
        Me.withdraw_but.Cursor = System.Windows.Forms.Cursors.Hand
        Me.withdraw_but.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.withdraw_but.Location = New System.Drawing.Point(837, 462)
        Me.withdraw_but.Name = "withdraw_but"
        Me.withdraw_but.Size = New System.Drawing.Size(134, 32)
        Me.withdraw_but.TabIndex = 36
        Me.withdraw_but.Text = "Withdraw"
        Me.withdraw_but.UseVisualStyleBackColor = True
        Me.withdraw_but.Visible = False
        '
        'Account_no
        '
        Me.Account_no.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Account_no.Location = New System.Drawing.Point(365, 194)
        Me.Account_no.Name = "Account_no"
        Me.Account_no.Size = New System.Drawing.Size(304, 30)
        Me.Account_no.TabIndex = 35
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.AliceBlue
        Me.Label8.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(180, 194)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(134, 24)
        Me.Label8.TabIndex = 34
        Me.Label8.Text = "Account No.*"
        '
        'CustomerName
        '
        Me.CustomerName.Enabled = False
        Me.CustomerName.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CustomerName.Location = New System.Drawing.Point(626, 331)
        Me.CustomerName.Name = "CustomerName"
        Me.CustomerName.Size = New System.Drawing.Size(304, 30)
        Me.CustomerName.TabIndex = 41
        Me.CustomerName.Visible = False
        '
        'cname
        '
        Me.cname.AutoSize = True
        Me.cname.BackColor = System.Drawing.Color.AliceBlue
        Me.cname.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cname.Location = New System.Drawing.Point(441, 335)
        Me.cname.Name = "cname"
        Me.cname.Size = New System.Drawing.Size(154, 24)
        Me.cname.TabIndex = 40
        Me.cname.Text = "Customer Name"
        Me.cname.Visible = False
        '
        'Button1
        '
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(565, 230)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(104, 32)
        Me.Button1.TabIndex = 42
        Me.Button1.Text = "Go"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(56, 44)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(202, 113)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'Withdraw
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MediumAquamarine
        Me.ClientSize = New System.Drawing.Size(1378, 780)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.CustomerName)
        Me.Controls.Add(Me.cname)
        Me.Controls.Add(Me.amount)
        Me.Controls.Add(Me.Amountlbl)
        Me.Controls.Add(Me.Back)
        Me.Controls.Add(Me.withdraw_but)
        Me.Controls.Add(Me.Account_no)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Withdraw"
        Me.Text = "Withdraw "
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents amount As System.Windows.Forms.TextBox
    Friend WithEvents Amountlbl As System.Windows.Forms.Label
    Friend WithEvents Back As System.Windows.Forms.Button
    Friend WithEvents withdraw_but As System.Windows.Forms.Button
    Friend WithEvents Account_no As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents CustomerName As System.Windows.Forms.TextBox
    Friend WithEvents cname As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class

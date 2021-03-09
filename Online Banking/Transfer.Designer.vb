<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Transfer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Transfer))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.banklbl = New System.Windows.Forms.Label()
        Me.amountlbl = New System.Windows.Forms.Label()
        Me.Accountno = New System.Windows.Forms.TextBox()
        Me.bank = New System.Windows.Forms.TextBox()
        Me.amount = New System.Windows.Forms.TextBox()
        Me.transfr = New System.Windows.Forms.Button()
        Me.close1 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.go = New System.Windows.Forms.Button()
        Me.name1 = New System.Windows.Forms.TextBox()
        Me.Namelbl = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.LightSlateGray
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.Control
        Me.Button1.Location = New System.Drawing.Point(172, 148)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(133, 23)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "About"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.LightSlateGray
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.Control
        Me.Button2.Location = New System.Drawing.Point(33, 148)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(133, 23)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "Products /Services"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.CadetBlue
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(111, 204)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(786, 344)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Fund Transfer"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(208, 259)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(128, 26)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Account No."
        '
        'banklbl
        '
        Me.banklbl.Enabled = False
        Me.banklbl.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.banklbl.Location = New System.Drawing.Point(236, 402)
        Me.banklbl.Name = "banklbl"
        Me.banklbl.Size = New System.Drawing.Size(128, 26)
        Me.banklbl.TabIndex = 10
        Me.banklbl.Text = "Bank"
        Me.banklbl.Visible = False
        '
        'amountlbl
        '
        Me.amountlbl.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.amountlbl.Location = New System.Drawing.Point(236, 447)
        Me.amountlbl.Name = "amountlbl"
        Me.amountlbl.Size = New System.Drawing.Size(128, 26)
        Me.amountlbl.TabIndex = 11
        Me.amountlbl.Text = "Amount"
        Me.amountlbl.Visible = False
        '
        'Accountno
        '
        Me.Accountno.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Accountno.Location = New System.Drawing.Point(400, 256)
        Me.Accountno.Name = "Accountno"
        Me.Accountno.Size = New System.Drawing.Size(275, 28)
        Me.Accountno.TabIndex = 12
        '
        'bank
        '
        Me.bank.Enabled = False
        Me.bank.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bank.Location = New System.Drawing.Point(428, 399)
        Me.bank.Name = "bank"
        Me.bank.Size = New System.Drawing.Size(275, 28)
        Me.bank.TabIndex = 13
        Me.bank.Visible = False
        '
        'amount
        '
        Me.amount.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.amount.Location = New System.Drawing.Point(428, 444)
        Me.amount.Name = "amount"
        Me.amount.Size = New System.Drawing.Size(275, 28)
        Me.amount.TabIndex = 14
        Me.amount.Visible = False
        '
        'transfr
        '
        Me.transfr.BackColor = System.Drawing.Color.LightSlateGray
        Me.transfr.Cursor = System.Windows.Forms.Cursors.Hand
        Me.transfr.Font = New System.Drawing.Font("Modern No. 20", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.transfr.ForeColor = System.Drawing.SystemColors.Control
        Me.transfr.Location = New System.Drawing.Point(534, 500)
        Me.transfr.Name = "transfr"
        Me.transfr.Size = New System.Drawing.Size(134, 37)
        Me.transfr.TabIndex = 15
        Me.transfr.Text = "Transfer"
        Me.transfr.UseVisualStyleBackColor = False
        Me.transfr.Visible = False
        '
        'close1
        '
        Me.close1.BackColor = System.Drawing.Color.LightSlateGray
        Me.close1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.close1.Font = New System.Drawing.Font("Modern No. 20", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.close1.ForeColor = System.Drawing.SystemColors.Control
        Me.close1.Location = New System.Drawing.Point(674, 500)
        Me.close1.Name = "close1"
        Me.close1.Size = New System.Drawing.Size(134, 37)
        Me.close1.TabIndex = 16
        Me.close1.Text = "Close"
        Me.close1.UseVisualStyleBackColor = False
        Me.close1.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(33, 28)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(202, 114)
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'go
        '
        Me.go.BackColor = System.Drawing.Color.LightSlateGray
        Me.go.Cursor = System.Windows.Forms.Cursors.Hand
        Me.go.Font = New System.Drawing.Font("Modern No. 20", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.go.ForeColor = System.Drawing.SystemColors.Control
        Me.go.Location = New System.Drawing.Point(583, 290)
        Me.go.Name = "go"
        Me.go.Size = New System.Drawing.Size(92, 38)
        Me.go.TabIndex = 17
        Me.go.Text = "Transfer"
        Me.go.UseVisualStyleBackColor = False
        '
        'name1
        '
        Me.name1.Enabled = False
        Me.name1.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.name1.Location = New System.Drawing.Point(428, 350)
        Me.name1.Name = "name1"
        Me.name1.Size = New System.Drawing.Size(275, 28)
        Me.name1.TabIndex = 19
        Me.name1.Visible = False
        '
        'Namelbl
        '
        Me.Namelbl.Enabled = False
        Me.Namelbl.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Namelbl.Location = New System.Drawing.Point(236, 353)
        Me.Namelbl.Name = "Namelbl"
        Me.Namelbl.Size = New System.Drawing.Size(128, 26)
        Me.Namelbl.TabIndex = 18
        Me.Namelbl.Text = "Name"
        Me.Namelbl.Visible = False
        '
        'Transfer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(1009, 599)
        Me.Controls.Add(Me.name1)
        Me.Controls.Add(Me.Namelbl)
        Me.Controls.Add(Me.go)
        Me.Controls.Add(Me.close1)
        Me.Controls.Add(Me.transfr)
        Me.Controls.Add(Me.amount)
        Me.Controls.Add(Me.bank)
        Me.Controls.Add(Me.Accountno)
        Me.Controls.Add(Me.amountlbl)
        Me.Controls.Add(Me.banklbl)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Transfer"
        Me.Text = "Transfer"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents banklbl As System.Windows.Forms.Label
    Friend WithEvents amountlbl As System.Windows.Forms.Label
    Friend WithEvents Accountno As System.Windows.Forms.TextBox
    Friend WithEvents bank As System.Windows.Forms.TextBox
    Friend WithEvents amount As System.Windows.Forms.TextBox
    Friend WithEvents transfr As System.Windows.Forms.Button
    Friend WithEvents close1 As System.Windows.Forms.Button
    Friend WithEvents go As System.Windows.Forms.Button
    Friend WithEvents name1 As System.Windows.Forms.TextBox
    Friend WithEvents Namelbl As System.Windows.Forms.Label
End Class

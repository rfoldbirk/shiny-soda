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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.back = New System.Windows.Forms.Button()
        Me.btn1 = New System.Windows.Forms.Button()
        Me.btn2 = New System.Windows.Forms.Button()
        Me.btn5 = New System.Windows.Forms.Button()
        Me.btn10 = New System.Windows.Forms.Button()
        Me.btn20 = New System.Windows.Forms.Button()
        Me.enter = New System.Windows.Forms.Button()
        Me.right = New System.Windows.Forms.Button()
        Me.left = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.show = New System.Windows.Forms.Label()
        Me.price = New System.Windows.Forms.Label()
        Me.cart = New System.Windows.Forms.Label()
        Me.output = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.instruct = New System.Windows.Forms.Label()
        Me.reset = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Panel1.Controls.Add(Me.reset)
        Me.Panel1.Controls.Add(Me.back)
        Me.Panel1.Controls.Add(Me.btn1)
        Me.Panel1.Controls.Add(Me.btn2)
        Me.Panel1.Controls.Add(Me.btn5)
        Me.Panel1.Controls.Add(Me.btn10)
        Me.Panel1.Controls.Add(Me.btn20)
        Me.Panel1.Controls.Add(Me.enter)
        Me.Panel1.Controls.Add(Me.right)
        Me.Panel1.Controls.Add(Me.left)
        Me.Panel1.Location = New System.Drawing.Point(15, 261)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(346, 177)
        Me.Panel1.TabIndex = 2
        '
        'back
        '
        Me.back.Location = New System.Drawing.Point(215, 132)
        Me.back.Name = "back"
        Me.back.Size = New System.Drawing.Size(113, 27)
        Me.back.TabIndex = 20
        Me.back.Text = "Gå tilbage"
        Me.back.UseVisualStyleBackColor = True
        '
        'btn1
        '
        Me.btn1.Location = New System.Drawing.Point(19, 132)
        Me.btn1.Name = "btn1"
        Me.btn1.Size = New System.Drawing.Size(75, 23)
        Me.btn1.TabIndex = 19
        Me.btn1.Text = "1"
        Me.btn1.UseVisualStyleBackColor = True
        '
        'btn2
        '
        Me.btn2.Location = New System.Drawing.Point(19, 103)
        Me.btn2.Name = "btn2"
        Me.btn2.Size = New System.Drawing.Size(75, 23)
        Me.btn2.TabIndex = 18
        Me.btn2.Text = "2"
        Me.btn2.UseVisualStyleBackColor = True
        '
        'btn5
        '
        Me.btn5.Location = New System.Drawing.Point(19, 74)
        Me.btn5.Name = "btn5"
        Me.btn5.Size = New System.Drawing.Size(75, 23)
        Me.btn5.TabIndex = 17
        Me.btn5.Text = "5"
        Me.btn5.UseVisualStyleBackColor = True
        '
        'btn10
        '
        Me.btn10.Location = New System.Drawing.Point(19, 45)
        Me.btn10.Name = "btn10"
        Me.btn10.Size = New System.Drawing.Size(75, 23)
        Me.btn10.TabIndex = 16
        Me.btn10.Text = "10"
        Me.btn10.UseVisualStyleBackColor = True
        '
        'btn20
        '
        Me.btn20.Location = New System.Drawing.Point(19, 16)
        Me.btn20.Name = "btn20"
        Me.btn20.Size = New System.Drawing.Size(75, 23)
        Me.btn20.TabIndex = 15
        Me.btn20.Text = "20"
        Me.btn20.UseVisualStyleBackColor = True
        '
        'enter
        '
        Me.enter.Location = New System.Drawing.Point(261, 60)
        Me.enter.Name = "enter"
        Me.enter.Size = New System.Drawing.Size(80, 51)
        Me.enter.TabIndex = 14
        Me.enter.Text = "Enter"
        Me.enter.UseVisualStyleBackColor = True
        '
        'right
        '
        Me.right.Location = New System.Drawing.Point(203, 65)
        Me.right.Name = "right"
        Me.right.Size = New System.Drawing.Size(52, 41)
        Me.right.TabIndex = 11
        Me.right.Text = "Right"
        Me.right.UseVisualStyleBackColor = True
        '
        'left
        '
        Me.left.Location = New System.Drawing.Point(145, 65)
        Me.left.Name = "left"
        Me.left.Size = New System.Drawing.Size(52, 41)
        Me.left.TabIndex = 10
        Me.left.Text = "Left"
        Me.left.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel2.Controls.Add(Me.show)
        Me.Panel2.Controls.Add(Me.price)
        Me.Panel2.Controls.Add(Me.cart)
        Me.Panel2.Controls.Add(Me.output)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.instruct)
        Me.Panel2.Location = New System.Drawing.Point(15, 23)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(346, 218)
        Me.Panel2.TabIndex = 3
        '
        'show
        '
        Me.show.AutoSize = True
        Me.show.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.show.Location = New System.Drawing.Point(98, 130)
        Me.show.Name = "show"
        Me.show.Padding = New System.Windows.Forms.Padding(20, 0, 20, 0)
        Me.show.Size = New System.Drawing.Size(129, 13)
        Me.show.TabIndex = 5
        Me.show.Text = "cola koster 15 kr."
        Me.show.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'price
        '
        Me.price.AutoSize = True
        Me.price.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.price.Location = New System.Drawing.Point(260, 195)
        Me.price.Name = "price"
        Me.price.Padding = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.price.Size = New System.Drawing.Size(68, 13)
        Me.price.TabIndex = 4
        Me.price.Text = "Pris: 0 kr"
        Me.price.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'cart
        '
        Me.cart.AutoSize = True
        Me.cart.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.cart.Location = New System.Drawing.Point(3, 195)
        Me.cart.Name = "cart"
        Me.cart.Size = New System.Drawing.Size(72, 13)
        Me.cart.TabIndex = 3
        Me.cart.Text = "Indkøbsvogn:"
        '
        'output
        '
        Me.output.AutoSize = True
        Me.output.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.output.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.output.Location = New System.Drawing.Point(51, 91)
        Me.output.Name = "output"
        Me.output.Size = New System.Drawing.Size(234, 20)
        Me.output.TabIndex = 2
        Me.output.Text = "[ cola ]   fanta   sprite  pepsi  køb"
        Me.output.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(125, 71)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'instruct
        '
        Me.instruct.AutoSize = True
        Me.instruct.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.instruct.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.instruct.Location = New System.Drawing.Point(51, 20)
        Me.instruct.Name = "instruct"
        Me.instruct.Padding = New System.Windows.Forms.Padding(50, 0, 50, 0)
        Me.instruct.Size = New System.Drawing.Size(245, 20)
        Me.instruct.TabIndex = 0
        Me.instruct.Text = "Vælg din sodavand"
        Me.instruct.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'reset
        '
        Me.reset.Location = New System.Drawing.Point(19, 157)
        Me.reset.Name = "reset"
        Me.reset.Size = New System.Drawing.Size(75, 20)
        Me.reset.TabIndex = 21
        Me.reset.Text = "reset"
        Me.reset.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents enter As Button
    Friend WithEvents right As Button
    Friend WithEvents left As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents instruct As Label
    Friend WithEvents output As Label
    Friend WithEvents cart As Label
    Friend WithEvents price As Label
    Friend WithEvents show As Label
    Friend WithEvents btn1 As Button
    Friend WithEvents btn2 As Button
    Friend WithEvents btn5 As Button
    Friend WithEvents btn10 As Button
    Friend WithEvents btn20 As Button
    Friend WithEvents back As Button
    Friend WithEvents reset As Button
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmOrder
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Grb_order = New System.Windows.Forms.GroupBox()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.Txt_totalprice = New System.Windows.Forms.TextBox()
        Me.Txt_Price = New System.Windows.Forms.TextBox()
        Me.Txt_Productname = New System.Windows.Forms.TextBox()
        Me.Lbl_totalprice = New System.Windows.Forms.Label()
        Me.Lbl_Quantity = New System.Windows.Forms.Label()
        Me.Lbl_price = New System.Windows.Forms.Label()
        Me.Lbl_name = New System.Windows.Forms.Label()
        Me.Btn_Add = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Btn_cancel = New System.Windows.Forms.Button()
        Me.Grb_pic = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Lbl_stock = New System.Windows.Forms.Label()
        Me.Grb_order.SuspendLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.Grb_pic.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Grb_order
        '
        Me.Grb_order.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Grb_order.Controls.Add(Me.NumericUpDown1)
        Me.Grb_order.Controls.Add(Me.Txt_totalprice)
        Me.Grb_order.Controls.Add(Me.Txt_Price)
        Me.Grb_order.Controls.Add(Me.Txt_Productname)
        Me.Grb_order.Controls.Add(Me.Lbl_totalprice)
        Me.Grb_order.Controls.Add(Me.Lbl_Quantity)
        Me.Grb_order.Controls.Add(Me.Lbl_price)
        Me.Grb_order.Controls.Add(Me.Lbl_name)
        Me.Grb_order.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Grb_order.Location = New System.Drawing.Point(385, 26)
        Me.Grb_order.Name = "Grb_order"
        Me.Grb_order.Size = New System.Drawing.Size(333, 301)
        Me.Grb_order.TabIndex = 1
        Me.Grb_order.TabStop = False
        Me.Grb_order.Text = "รายการสั่งซื้อสินค้า"
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Location = New System.Drawing.Point(16, 195)
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(228, 28)
        Me.NumericUpDown1.TabIndex = 4
        '
        'Txt_totalprice
        '
        Me.Txt_totalprice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt_totalprice.Location = New System.Drawing.Point(18, 262)
        Me.Txt_totalprice.Multiline = True
        Me.Txt_totalprice.Name = "Txt_totalprice"
        Me.Txt_totalprice.Size = New System.Drawing.Size(272, 26)
        Me.Txt_totalprice.TabIndex = 1
        '
        'Txt_Price
        '
        Me.Txt_Price.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt_Price.Location = New System.Drawing.Point(93, 95)
        Me.Txt_Price.Multiline = True
        Me.Txt_Price.Name = "Txt_Price"
        Me.Txt_Price.Size = New System.Drawing.Size(221, 26)
        Me.Txt_Price.TabIndex = 1
        '
        'Txt_Productname
        '
        Me.Txt_Productname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt_Productname.Location = New System.Drawing.Point(93, 40)
        Me.Txt_Productname.Multiline = True
        Me.Txt_Productname.Name = "Txt_Productname"
        Me.Txt_Productname.Size = New System.Drawing.Size(221, 26)
        Me.Txt_Productname.TabIndex = 1
        '
        'Lbl_totalprice
        '
        Me.Lbl_totalprice.AutoSize = True
        Me.Lbl_totalprice.Location = New System.Drawing.Point(14, 237)
        Me.Lbl_totalprice.Name = "Lbl_totalprice"
        Me.Lbl_totalprice.Size = New System.Drawing.Size(81, 22)
        Me.Lbl_totalprice.TabIndex = 0
        Me.Lbl_totalprice.Text = "ราคารวม"
        '
        'Lbl_Quantity
        '
        Me.Lbl_Quantity.AutoSize = True
        Me.Lbl_Quantity.Location = New System.Drawing.Point(14, 156)
        Me.Lbl_Quantity.Name = "Lbl_Quantity"
        Me.Lbl_Quantity.Size = New System.Drawing.Size(230, 22)
        Me.Lbl_Quantity.TabIndex = 0
        Me.Lbl_Quantity.Text = "โปรดระบุจำนวนสินค้าที่สั้่งซื้อ"
        '
        'Lbl_price
        '
        Me.Lbl_price.AutoSize = True
        Me.Lbl_price.Location = New System.Drawing.Point(14, 99)
        Me.Lbl_price.Name = "Lbl_price"
        Me.Lbl_price.Size = New System.Drawing.Size(78, 22)
        Me.Lbl_price.TabIndex = 0
        Me.Lbl_price.Text = "ราคา/ชิ้น"
        '
        'Lbl_name
        '
        Me.Lbl_name.AutoSize = True
        Me.Lbl_name.Location = New System.Drawing.Point(14, 44)
        Me.Lbl_name.Name = "Lbl_name"
        Me.Lbl_name.Size = New System.Drawing.Size(79, 22)
        Me.Lbl_name.TabIndex = 0
        Me.Lbl_name.Text = "ชื่อสินค้า:"
        '
        'Btn_Add
        '
        Me.Btn_Add.Location = New System.Drawing.Point(82, 352)
        Me.Btn_Add.Name = "Btn_Add"
        Me.Btn_Add.Size = New System.Drawing.Size(287, 62)
        Me.Btn_Add.TabIndex = 2
        Me.Btn_Add.Text = "เพิ่ม"
        Me.Btn_Add.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.Btn_cancel)
        Me.GroupBox2.Location = New System.Drawing.Point(13, 337)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(714, 84)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        '
        'Btn_cancel
        '
        Me.Btn_cancel.Location = New System.Drawing.Point(375, 15)
        Me.Btn_cancel.Name = "Btn_cancel"
        Me.Btn_cancel.Size = New System.Drawing.Size(287, 62)
        Me.Btn_cancel.TabIndex = 2
        Me.Btn_cancel.Text = "ยกเลิก"
        Me.Btn_cancel.UseVisualStyleBackColor = True
        '
        'Grb_pic
        '
        Me.Grb_pic.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Grb_pic.Controls.Add(Me.PictureBox1)
        Me.Grb_pic.Location = New System.Drawing.Point(13, 14)
        Me.Grb_pic.Name = "Grb_pic"
        Me.Grb_pic.Size = New System.Drawing.Size(356, 313)
        Me.Grb_pic.TabIndex = 4
        Me.Grb_pic.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox1.Location = New System.Drawing.Point(19, 27)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(318, 273)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Lbl_stock
        '
        Me.Lbl_stock.AutoSize = True
        Me.Lbl_stock.BackColor = System.Drawing.Color.DarkGreen
        Me.Lbl_stock.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Lbl_stock.ForeColor = System.Drawing.Color.White
        Me.Lbl_stock.Location = New System.Drawing.Point(313, 2)
        Me.Lbl_stock.Name = "Lbl_stock"
        Me.Lbl_stock.Size = New System.Drawing.Size(142, 25)
        Me.Lbl_stock.TabIndex = 5
        Me.Lbl_stock.Text = "มีสินค้าเหลืออยู่ :"
        '
        'FrmOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 22.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(731, 429)
        Me.Controls.Add(Me.Lbl_stock)
        Me.Controls.Add(Me.Grb_pic)
        Me.Controls.Add(Me.Btn_Add)
        Me.Controls.Add(Me.Grb_order)
        Me.Controls.Add(Me.GroupBox2)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximumSize = New System.Drawing.Size(753, 485)
        Me.MinimumSize = New System.Drawing.Size(753, 485)
        Me.Name = "FrmOrder"
        Me.Text = "Form3"
        Me.Grb_order.ResumeLayout(False)
        Me.Grb_order.PerformLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.Grb_pic.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Grb_order As GroupBox
    Friend WithEvents Btn_Add As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Btn_cancel As Button
    Friend WithEvents Grb_pic As GroupBox
    Friend WithEvents Lbl_totalprice As Label
    Friend WithEvents Lbl_Quantity As Label
    Friend WithEvents Lbl_price As Label
    Friend WithEvents Lbl_name As Label
    Friend WithEvents Txt_Productname As TextBox
    Friend WithEvents Txt_totalprice As TextBox
    Friend WithEvents Txt_Price As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Lbl_stock As Label
    Friend WithEvents NumericUpDown1 As NumericUpDown

    'Private Sub DomainUpDown1_SelectedItemChanged(sender As Object, e As EventArgs) Handles DomainUpDown1.SelectedItemChanged

    'End Sub

    'Private Sub Btn_Add_Click(sender As Object, e As EventArgs) Handles Btn_Add.Click

    'End Sub
End Class

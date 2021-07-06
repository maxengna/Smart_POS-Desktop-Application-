<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Stock
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
        Me.Btn_refresh = New System.Windows.Forms.Button()
        Me.Btn_Search = New System.Windows.Forms.Button()
        Me.Btn_Delete = New System.Windows.Forms.Button()
        Me.Btn_Clear = New System.Windows.Forms.Button()
        Me.Btn_Update = New System.Windows.Forms.Button()
        Me.Btn_Add = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Lbl_Pic = New System.Windows.Forms.Label()
        Me.Lbl_Safety_Stock = New System.Windows.Forms.Label()
        Me.Lbl_UnitCost = New System.Windows.Forms.Label()
        Me.Lbl_Unitprice = New System.Windows.Forms.Label()
        Me.Lbl_Quantity = New System.Windows.Forms.Label()
        Me.Lbl_Price = New System.Windows.Forms.Label()
        Me.LblTotal = New System.Windows.Forms.Label()
        Me.Lbl_Productname = New System.Windows.Forms.Label()
        Me.Lbl_Id_Product = New System.Windows.Forms.Label()
        Me.Lbl_PurchaseDate = New System.Windows.Forms.Label()
        Me.Lbl_Id_purchase = New System.Windows.Forms.Label()
        Me.Grp_Purchase = New System.Windows.Forms.GroupBox()
        Me.Btn_minus = New System.Windows.Forms.Button()
        Me.Btn_plus = New System.Windows.Forms.Button()
        Me.Lbl_Staffname = New System.Windows.Forms.Label()
        Me.Lbl_staff = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Lbl_BathPrice = New System.Windows.Forms.Label()
        Me.Btn_browseimg = New System.Windows.Forms.Button()
        Me.Dtpick_purchasdatee = New System.Windows.Forms.DateTimePicker()
        Me.Txt_Safety_stock = New System.Windows.Forms.TextBox()
        Me.Txt_Unitprice = New System.Windows.Forms.TextBox()
        Me.Txt_Unitcost = New System.Windows.Forms.TextBox()
        Me.Txt_TotalPrice = New System.Windows.Forms.TextBox()
        Me.Txt_Price = New System.Windows.Forms.TextBox()
        Me.Txt_Quantity = New System.Windows.Forms.TextBox()
        Me.Txt_Productname = New System.Windows.Forms.TextBox()
        Me.Txt_Pic = New System.Windows.Forms.TextBox()
        Me.Txt_IdProduct = New System.Windows.Forms.TextBox()
        Me.Txt_IdPurchase = New System.Windows.Forms.TextBox()
        Me.Grp_Supplier = New System.Windows.Forms.GroupBox()
        Me.TxtAddress_Sup = New System.Windows.Forms.TextBox()
        Me.Lbl_Address_Sup = New System.Windows.Forms.Label()
        Me.Txt_SupplierName = New System.Windows.Forms.TextBox()
        Me.Lbl_Name_Supplier = New System.Windows.Forms.Label()
        Me.Txt_Id_Supplier = New System.Windows.Forms.TextBox()
        Me.Lbl_Id_Supplier = New System.Windows.Forms.Label()
        Me.My_DatabaseDataSet1 = New Smart_POS.My_DatabaseDataSet()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Grp_Purchase.SuspendLayout()
        Me.Grp_Supplier.SuspendLayout()
        CType(Me.My_DatabaseDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.LightCoral
        Me.Panel1.Controls.Add(Me.Btn_refresh)
        Me.Panel1.Controls.Add(Me.Btn_Search)
        Me.Panel1.Controls.Add(Me.Btn_Delete)
        Me.Panel1.Controls.Add(Me.Btn_Clear)
        Me.Panel1.Controls.Add(Me.Btn_Update)
        Me.Panel1.Controls.Add(Me.Btn_Add)
        Me.Panel1.Location = New System.Drawing.Point(12, 566)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1261, 72)
        Me.Panel1.TabIndex = 1
        '
        'Btn_refresh
        '
        Me.Btn_refresh.BackColor = System.Drawing.Color.SpringGreen
        Me.Btn_refresh.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btn_refresh.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Btn_refresh.Location = New System.Drawing.Point(1102, 8)
        Me.Btn_refresh.Name = "Btn_refresh"
        Me.Btn_refresh.Size = New System.Drawing.Size(139, 57)
        Me.Btn_refresh.TabIndex = 1
        Me.Btn_refresh.Text = "คืนค่า"
        Me.Btn_refresh.UseVisualStyleBackColor = False
        '
        'Btn_Search
        '
        Me.Btn_Search.BackColor = System.Drawing.Color.SpringGreen
        Me.Btn_Search.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btn_Search.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Btn_Search.Location = New System.Drawing.Point(890, 9)
        Me.Btn_Search.Name = "Btn_Search"
        Me.Btn_Search.Size = New System.Drawing.Size(139, 57)
        Me.Btn_Search.TabIndex = 0
        Me.Btn_Search.Text = "ค้นหา"
        Me.Btn_Search.UseVisualStyleBackColor = False
        '
        'Btn_Delete
        '
        Me.Btn_Delete.BackColor = System.Drawing.Color.Red
        Me.Btn_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btn_Delete.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Btn_Delete.ForeColor = System.Drawing.Color.White
        Me.Btn_Delete.Location = New System.Drawing.Point(680, 9)
        Me.Btn_Delete.Name = "Btn_Delete"
        Me.Btn_Delete.Size = New System.Drawing.Size(139, 57)
        Me.Btn_Delete.TabIndex = 0
        Me.Btn_Delete.Text = "ลบสินค้า"
        Me.Btn_Delete.UseVisualStyleBackColor = False
        '
        'Btn_Clear
        '
        Me.Btn_Clear.BackColor = System.Drawing.Color.Red
        Me.Btn_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btn_Clear.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Btn_Clear.ForeColor = System.Drawing.Color.White
        Me.Btn_Clear.Location = New System.Drawing.Point(460, 9)
        Me.Btn_Clear.Name = "Btn_Clear"
        Me.Btn_Clear.Size = New System.Drawing.Size(139, 57)
        Me.Btn_Clear.TabIndex = 0
        Me.Btn_Clear.Text = "ล้างข้อมูล"
        Me.Btn_Clear.UseVisualStyleBackColor = False
        '
        'Btn_Update
        '
        Me.Btn_Update.BackColor = System.Drawing.Color.Blue
        Me.Btn_Update.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btn_Update.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Btn_Update.ForeColor = System.Drawing.Color.White
        Me.Btn_Update.Location = New System.Drawing.Point(254, 9)
        Me.Btn_Update.Name = "Btn_Update"
        Me.Btn_Update.Size = New System.Drawing.Size(139, 57)
        Me.Btn_Update.TabIndex = 0
        Me.Btn_Update.Text = "แก้ไข"
        Me.Btn_Update.UseVisualStyleBackColor = False
        '
        'Btn_Add
        '
        Me.Btn_Add.BackColor = System.Drawing.Color.Blue
        Me.Btn_Add.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btn_Add.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Btn_Add.ForeColor = System.Drawing.Color.White
        Me.Btn_Add.Location = New System.Drawing.Point(54, 9)
        Me.Btn_Add.Name = "Btn_Add"
        Me.Btn_Add.Size = New System.Drawing.Size(139, 57)
        Me.Btn_Add.TabIndex = 0
        Me.Btn_Add.Text = "เพิ่ม"
        Me.Btn_Add.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.Panel2.Controls.Add(Me.Lbl_Pic)
        Me.Panel2.Controls.Add(Me.Lbl_Safety_Stock)
        Me.Panel2.Controls.Add(Me.Lbl_UnitCost)
        Me.Panel2.Controls.Add(Me.Lbl_Unitprice)
        Me.Panel2.Controls.Add(Me.Lbl_Quantity)
        Me.Panel2.Controls.Add(Me.Lbl_Price)
        Me.Panel2.Controls.Add(Me.LblTotal)
        Me.Panel2.Controls.Add(Me.Lbl_Productname)
        Me.Panel2.Controls.Add(Me.Lbl_Id_Product)
        Me.Panel2.Controls.Add(Me.Lbl_PurchaseDate)
        Me.Panel2.Controls.Add(Me.Lbl_Id_purchase)
        Me.Panel2.Controls.Add(Me.Grp_Purchase)
        Me.Panel2.Controls.Add(Me.Grp_Supplier)
        Me.Panel2.Location = New System.Drawing.Point(12, 13)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(583, 539)
        Me.Panel2.TabIndex = 2
        '
        'Lbl_Pic
        '
        Me.Lbl_Pic.AutoSize = True
        Me.Lbl_Pic.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Lbl_Pic.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Lbl_Pic.Location = New System.Drawing.Point(62, 150)
        Me.Lbl_Pic.Name = "Lbl_Pic"
        Me.Lbl_Pic.Size = New System.Drawing.Size(62, 20)
        Me.Lbl_Pic.TabIndex = 8
        Me.Lbl_Pic.Text = "เลือกรูป"
        '
        'Lbl_Safety_Stock
        '
        Me.Lbl_Safety_Stock.AutoSize = True
        Me.Lbl_Safety_Stock.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Lbl_Safety_Stock.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Lbl_Safety_Stock.Location = New System.Drawing.Point(34, 325)
        Me.Lbl_Safety_Stock.Name = "Lbl_Safety_Stock"
        Me.Lbl_Safety_Stock.Size = New System.Drawing.Size(90, 20)
        Me.Lbl_Safety_Stock.TabIndex = 7
        Me.Lbl_Safety_Stock.Text = "สต็อกขั้นต่ำ:"
        '
        'Lbl_UnitCost
        '
        Me.Lbl_UnitCost.AutoSize = True
        Me.Lbl_UnitCost.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Lbl_UnitCost.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Lbl_UnitCost.Location = New System.Drawing.Point(45, 267)
        Me.Lbl_UnitCost.Name = "Lbl_UnitCost"
        Me.Lbl_UnitCost.Size = New System.Drawing.Size(80, 20)
        Me.Lbl_UnitCost.TabIndex = 6
        Me.Lbl_UnitCost.Text = "ต้นทุน/ชิ้น:"
        '
        'Lbl_Unitprice
        '
        Me.Lbl_Unitprice.AutoSize = True
        Me.Lbl_Unitprice.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Lbl_Unitprice.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Lbl_Unitprice.Location = New System.Drawing.Point(49, 296)
        Me.Lbl_Unitprice.Name = "Lbl_Unitprice"
        Me.Lbl_Unitprice.Size = New System.Drawing.Size(75, 20)
        Me.Lbl_Unitprice.TabIndex = 5
        Me.Lbl_Unitprice.Text = "ราคาขาย:"
        '
        'Lbl_Quantity
        '
        Me.Lbl_Quantity.AutoSize = True
        Me.Lbl_Quantity.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Lbl_Quantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Lbl_Quantity.Location = New System.Drawing.Point(68, 177)
        Me.Lbl_Quantity.Name = "Lbl_Quantity"
        Me.Lbl_Quantity.Size = New System.Drawing.Size(59, 20)
        Me.Lbl_Quantity.TabIndex = 4
        Me.Lbl_Quantity.Text = "จำนวน:"
        '
        'Lbl_Price
        '
        Me.Lbl_Price.AutoSize = True
        Me.Lbl_Price.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Lbl_Price.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Lbl_Price.Location = New System.Drawing.Point(48, 210)
        Me.Lbl_Price.Name = "Lbl_Price"
        Me.Lbl_Price.Size = New System.Drawing.Size(78, 20)
        Me.Lbl_Price.TabIndex = 3
        Me.Lbl_Price.Text = "ราคา/ชิ้น :"
        '
        'LblTotal
        '
        Me.LblTotal.AutoSize = True
        Me.LblTotal.BackColor = System.Drawing.SystemColors.ControlDark
        Me.LblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.LblTotal.Location = New System.Drawing.Point(32, 239)
        Me.LblTotal.Name = "LblTotal"
        Me.LblTotal.Size = New System.Drawing.Size(93, 20)
        Me.LblTotal.TabIndex = 2
        Me.LblTotal.Text = "รวมเป็นเงิน:"
        '
        'Lbl_Productname
        '
        Me.Lbl_Productname.AutoSize = True
        Me.Lbl_Productname.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Lbl_Productname.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Lbl_Productname.Location = New System.Drawing.Point(62, 121)
        Me.Lbl_Productname.Name = "Lbl_Productname"
        Me.Lbl_Productname.Size = New System.Drawing.Size(70, 20)
        Me.Lbl_Productname.TabIndex = 1
        Me.Lbl_Productname.Text = "ชื่อสินค้า:"
        '
        'Lbl_Id_Product
        '
        Me.Lbl_Id_Product.AutoSize = True
        Me.Lbl_Id_Product.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Lbl_Id_Product.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Lbl_Id_Product.Location = New System.Drawing.Point(53, 92)
        Me.Lbl_Id_Product.Name = "Lbl_Id_Product"
        Me.Lbl_Id_Product.Size = New System.Drawing.Size(78, 20)
        Me.Lbl_Id_Product.TabIndex = 0
        Me.Lbl_Id_Product.Text = "รหัสสินค้า:"
        '
        'Lbl_PurchaseDate
        '
        Me.Lbl_PurchaseDate.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Lbl_PurchaseDate.AutoSize = True
        Me.Lbl_PurchaseDate.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Lbl_PurchaseDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Lbl_PurchaseDate.Location = New System.Drawing.Point(52, 63)
        Me.Lbl_PurchaseDate.Name = "Lbl_PurchaseDate"
        Me.Lbl_PurchaseDate.Size = New System.Drawing.Size(79, 20)
        Me.Lbl_PurchaseDate.TabIndex = 0
        Me.Lbl_PurchaseDate.Text = "วันที่สั่งซื้อ:"
        '
        'Lbl_Id_purchase
        '
        Me.Lbl_Id_purchase.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Lbl_Id_purchase.AutoSize = True
        Me.Lbl_Id_purchase.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Lbl_Id_purchase.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Lbl_Id_purchase.Location = New System.Drawing.Point(28, 32)
        Me.Lbl_Id_purchase.MaximumSize = New System.Drawing.Size(0, 40)
        Me.Lbl_Id_purchase.Name = "Lbl_Id_purchase"
        Me.Lbl_Id_purchase.Size = New System.Drawing.Size(103, 20)
        Me.Lbl_Id_purchase.TabIndex = 0
        Me.Lbl_Id_purchase.Text = "รหัสการสั่งซื้อ:"
        '
        'Grp_Purchase
        '
        Me.Grp_Purchase.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Grp_Purchase.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Grp_Purchase.Controls.Add(Me.Btn_minus)
        Me.Grp_Purchase.Controls.Add(Me.Btn_plus)
        Me.Grp_Purchase.Controls.Add(Me.Lbl_Staffname)
        Me.Grp_Purchase.Controls.Add(Me.Lbl_staff)
        Me.Grp_Purchase.Controls.Add(Me.Label2)
        Me.Grp_Purchase.Controls.Add(Me.Label1)
        Me.Grp_Purchase.Controls.Add(Me.Lbl_BathPrice)
        Me.Grp_Purchase.Controls.Add(Me.Btn_browseimg)
        Me.Grp_Purchase.Controls.Add(Me.Dtpick_purchasdatee)
        Me.Grp_Purchase.Controls.Add(Me.Txt_Safety_stock)
        Me.Grp_Purchase.Controls.Add(Me.Txt_Unitprice)
        Me.Grp_Purchase.Controls.Add(Me.Txt_Unitcost)
        Me.Grp_Purchase.Controls.Add(Me.Txt_TotalPrice)
        Me.Grp_Purchase.Controls.Add(Me.Txt_Price)
        Me.Grp_Purchase.Controls.Add(Me.Txt_Quantity)
        Me.Grp_Purchase.Controls.Add(Me.Txt_Productname)
        Me.Grp_Purchase.Controls.Add(Me.Txt_Pic)
        Me.Grp_Purchase.Controls.Add(Me.Txt_IdProduct)
        Me.Grp_Purchase.Controls.Add(Me.Txt_IdPurchase)
        Me.Grp_Purchase.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Grp_Purchase.ForeColor = System.Drawing.Color.Blue
        Me.Grp_Purchase.Location = New System.Drawing.Point(20, 10)
        Me.Grp_Purchase.Name = "Grp_Purchase"
        Me.Grp_Purchase.Size = New System.Drawing.Size(544, 359)
        Me.Grp_Purchase.TabIndex = 9
        Me.Grp_Purchase.TabStop = False
        Me.Grp_Purchase.Text = "Purchase"
        '
        'Btn_minus
        '
        Me.Btn_minus.BackColor = System.Drawing.Color.Red
        Me.Btn_minus.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btn_minus.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Btn_minus.ForeColor = System.Drawing.Color.AliceBlue
        Me.Btn_minus.Location = New System.Drawing.Point(457, 164)
        Me.Btn_minus.Name = "Btn_minus"
        Me.Btn_minus.Size = New System.Drawing.Size(46, 29)
        Me.Btn_minus.TabIndex = 6
        Me.Btn_minus.Text = "-"
        Me.Btn_minus.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Btn_minus.UseVisualStyleBackColor = False
        '
        'Btn_plus
        '
        Me.Btn_plus.BackColor = System.Drawing.Color.DarkGreen
        Me.Btn_plus.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btn_plus.ForeColor = System.Drawing.Color.AliceBlue
        Me.Btn_plus.Location = New System.Drawing.Point(415, 164)
        Me.Btn_plus.Name = "Btn_plus"
        Me.Btn_plus.Size = New System.Drawing.Size(46, 29)
        Me.Btn_plus.TabIndex = 6
        Me.Btn_plus.Text = "+"
        Me.Btn_plus.UseVisualStyleBackColor = False
        '
        'Lbl_Staffname
        '
        Me.Lbl_Staffname.AutoSize = True
        Me.Lbl_Staffname.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Lbl_Staffname.Location = New System.Drawing.Point(473, 336)
        Me.Lbl_Staffname.Name = "Lbl_Staffname"
        Me.Lbl_Staffname.Size = New System.Drawing.Size(63, 20)
        Me.Lbl_Staffname.TabIndex = 5
        Me.Lbl_Staffname.Text = "642001"
        '
        'Lbl_staff
        '
        Me.Lbl_staff.AutoSize = True
        Me.Lbl_staff.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Lbl_staff.Location = New System.Drawing.Point(419, 336)
        Me.Lbl_staff.Name = "Lbl_staff"
        Me.Lbl_staff.Size = New System.Drawing.Size(48, 20)
        Me.Lbl_staff.TabIndex = 5
        Me.Lbl_staff.Text = "Staff:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(421, 286)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "บาท"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(420, 229)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 20)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "บาท"
        '
        'Lbl_BathPrice
        '
        Me.Lbl_BathPrice.AutoSize = True
        Me.Lbl_BathPrice.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Lbl_BathPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Lbl_BathPrice.ForeColor = System.Drawing.Color.Black
        Me.Lbl_BathPrice.Location = New System.Drawing.Point(420, 199)
        Me.Lbl_BathPrice.Name = "Lbl_BathPrice"
        Me.Lbl_BathPrice.Size = New System.Drawing.Size(38, 20)
        Me.Lbl_BathPrice.TabIndex = 4
        Me.Lbl_BathPrice.Text = "บาท"
        '
        'Btn_browseimg
        '
        Me.Btn_browseimg.BackColor = System.Drawing.Color.DimGray
        Me.Btn_browseimg.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Btn_browseimg.ForeColor = System.Drawing.Color.Black
        Me.Btn_browseimg.Location = New System.Drawing.Point(415, 125)
        Me.Btn_browseimg.Name = "Btn_browseimg"
        Me.Btn_browseimg.Size = New System.Drawing.Size(52, 38)
        Me.Btn_browseimg.TabIndex = 2
        Me.Btn_browseimg.Text = "..."
        Me.Btn_browseimg.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Btn_browseimg.UseVisualStyleBackColor = False
        '
        'Dtpick_purchasdatee
        '
        Me.Dtpick_purchasdatee.Location = New System.Drawing.Point(134, 49)
        Me.Dtpick_purchasdatee.Name = "Dtpick_purchasdatee"
        Me.Dtpick_purchasdatee.Size = New System.Drawing.Size(280, 26)
        Me.Dtpick_purchasdatee.TabIndex = 1
        '
        'Txt_Safety_stock
        '
        Me.Txt_Safety_stock.BackColor = System.Drawing.Color.Red
        Me.Txt_Safety_stock.ForeColor = System.Drawing.Color.White
        Me.Txt_Safety_stock.Location = New System.Drawing.Point(133, 310)
        Me.Txt_Safety_stock.Name = "Txt_Safety_stock"
        Me.Txt_Safety_stock.Size = New System.Drawing.Size(281, 26)
        Me.Txt_Safety_stock.TabIndex = 0
        '
        'Txt_Unitprice
        '
        Me.Txt_Unitprice.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Txt_Unitprice.ForeColor = System.Drawing.Color.Blue
        Me.Txt_Unitprice.Location = New System.Drawing.Point(134, 282)
        Me.Txt_Unitprice.Name = "Txt_Unitprice"
        Me.Txt_Unitprice.Size = New System.Drawing.Size(281, 26)
        Me.Txt_Unitprice.TabIndex = 0
        '
        'Txt_Unitcost
        '
        Me.Txt_Unitcost.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Txt_Unitcost.ForeColor = System.Drawing.Color.Blue
        Me.Txt_Unitcost.Location = New System.Drawing.Point(134, 252)
        Me.Txt_Unitcost.Name = "Txt_Unitcost"
        Me.Txt_Unitcost.Size = New System.Drawing.Size(281, 26)
        Me.Txt_Unitcost.TabIndex = 0
        '
        'Txt_TotalPrice
        '
        Me.Txt_TotalPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Txt_TotalPrice.ForeColor = System.Drawing.Color.Blue
        Me.Txt_TotalPrice.Location = New System.Drawing.Point(134, 223)
        Me.Txt_TotalPrice.Name = "Txt_TotalPrice"
        Me.Txt_TotalPrice.Size = New System.Drawing.Size(281, 26)
        Me.Txt_TotalPrice.TabIndex = 0
        '
        'Txt_Price
        '
        Me.Txt_Price.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Txt_Price.ForeColor = System.Drawing.Color.Blue
        Me.Txt_Price.Location = New System.Drawing.Point(134, 194)
        Me.Txt_Price.Name = "Txt_Price"
        Me.Txt_Price.Size = New System.Drawing.Size(281, 26)
        Me.Txt_Price.TabIndex = 0
        '
        'Txt_Quantity
        '
        Me.Txt_Quantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Txt_Quantity.ForeColor = System.Drawing.Color.Blue
        Me.Txt_Quantity.Location = New System.Drawing.Point(134, 165)
        Me.Txt_Quantity.Name = "Txt_Quantity"
        Me.Txt_Quantity.Size = New System.Drawing.Size(281, 26)
        Me.Txt_Quantity.TabIndex = 0
        '
        'Txt_Productname
        '
        Me.Txt_Productname.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Txt_Productname.ForeColor = System.Drawing.Color.Blue
        Me.Txt_Productname.Location = New System.Drawing.Point(134, 107)
        Me.Txt_Productname.Name = "Txt_Productname"
        Me.Txt_Productname.Size = New System.Drawing.Size(281, 26)
        Me.Txt_Productname.TabIndex = 0
        '
        'Txt_Pic
        '
        Me.Txt_Pic.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Txt_Pic.ForeColor = System.Drawing.Color.Blue
        Me.Txt_Pic.Location = New System.Drawing.Point(134, 136)
        Me.Txt_Pic.Name = "Txt_Pic"
        Me.Txt_Pic.Size = New System.Drawing.Size(281, 26)
        Me.Txt_Pic.TabIndex = 0
        '
        'Txt_IdProduct
        '
        Me.Txt_IdProduct.BackColor = System.Drawing.SystemColors.Control
        Me.Txt_IdProduct.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Txt_IdProduct.ForeColor = System.Drawing.Color.Red
        Me.Txt_IdProduct.Location = New System.Drawing.Point(134, 78)
        Me.Txt_IdProduct.Name = "Txt_IdProduct"
        Me.Txt_IdProduct.Size = New System.Drawing.Size(281, 26)
        Me.Txt_IdProduct.TabIndex = 0
        '
        'Txt_IdPurchase
        '
        Me.Txt_IdPurchase.BackColor = System.Drawing.SystemColors.Control
        Me.Txt_IdPurchase.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Txt_IdPurchase.ForeColor = System.Drawing.Color.Red
        Me.Txt_IdPurchase.Location = New System.Drawing.Point(134, 20)
        Me.Txt_IdPurchase.Name = "Txt_IdPurchase"
        Me.Txt_IdPurchase.Size = New System.Drawing.Size(281, 26)
        Me.Txt_IdPurchase.TabIndex = 0
        '
        'Grp_Supplier
        '
        Me.Grp_Supplier.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Grp_Supplier.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Grp_Supplier.Controls.Add(Me.TxtAddress_Sup)
        Me.Grp_Supplier.Controls.Add(Me.Lbl_Address_Sup)
        Me.Grp_Supplier.Controls.Add(Me.Txt_SupplierName)
        Me.Grp_Supplier.Controls.Add(Me.Lbl_Name_Supplier)
        Me.Grp_Supplier.Controls.Add(Me.Txt_Id_Supplier)
        Me.Grp_Supplier.Controls.Add(Me.Lbl_Id_Supplier)
        Me.Grp_Supplier.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Grp_Supplier.ForeColor = System.Drawing.Color.Blue
        Me.Grp_Supplier.Location = New System.Drawing.Point(20, 375)
        Me.Grp_Supplier.Name = "Grp_Supplier"
        Me.Grp_Supplier.Size = New System.Drawing.Size(544, 152)
        Me.Grp_Supplier.TabIndex = 10
        Me.Grp_Supplier.TabStop = False
        Me.Grp_Supplier.Text = "Supplier"
        '
        'TxtAddress_Sup
        '
        Me.TxtAddress_Sup.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.TxtAddress_Sup.ForeColor = System.Drawing.Color.Blue
        Me.TxtAddress_Sup.Location = New System.Drawing.Point(137, 90)
        Me.TxtAddress_Sup.Multiline = True
        Me.TxtAddress_Sup.Name = "TxtAddress_Sup"
        Me.TxtAddress_Sup.Size = New System.Drawing.Size(383, 54)
        Me.TxtAddress_Sup.TabIndex = 3
        '
        'Lbl_Address_Sup
        '
        Me.Lbl_Address_Sup.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Lbl_Address_Sup.AutoSize = True
        Me.Lbl_Address_Sup.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Lbl_Address_Sup.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Lbl_Address_Sup.ForeColor = System.Drawing.Color.Black
        Me.Lbl_Address_Sup.Location = New System.Drawing.Point(22, 106)
        Me.Lbl_Address_Sup.MaximumSize = New System.Drawing.Size(0, 40)
        Me.Lbl_Address_Sup.Name = "Lbl_Address_Sup"
        Me.Lbl_Address_Sup.Size = New System.Drawing.Size(82, 20)
        Me.Lbl_Address_Sup.TabIndex = 4
        Me.Lbl_Address_Sup.Text = "ที่อยู่ผู้ผลิต:"
        '
        'Txt_SupplierName
        '
        Me.Txt_SupplierName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Txt_SupplierName.ForeColor = System.Drawing.Color.Blue
        Me.Txt_SupplierName.Location = New System.Drawing.Point(137, 59)
        Me.Txt_SupplierName.Name = "Txt_SupplierName"
        Me.Txt_SupplierName.Size = New System.Drawing.Size(281, 26)
        Me.Txt_SupplierName.TabIndex = 1
        '
        'Lbl_Name_Supplier
        '
        Me.Lbl_Name_Supplier.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Lbl_Name_Supplier.AutoSize = True
        Me.Lbl_Name_Supplier.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Lbl_Name_Supplier.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Lbl_Name_Supplier.ForeColor = System.Drawing.Color.Black
        Me.Lbl_Name_Supplier.Location = New System.Drawing.Point(33, 63)
        Me.Lbl_Name_Supplier.MaximumSize = New System.Drawing.Size(0, 40)
        Me.Lbl_Name_Supplier.Name = "Lbl_Name_Supplier"
        Me.Lbl_Name_Supplier.Size = New System.Drawing.Size(72, 20)
        Me.Lbl_Name_Supplier.TabIndex = 2
        Me.Lbl_Name_Supplier.Text = "ชื่อผู้ผลิต:"
        '
        'Txt_Id_Supplier
        '
        Me.Txt_Id_Supplier.BackColor = System.Drawing.SystemColors.Control
        Me.Txt_Id_Supplier.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Txt_Id_Supplier.ForeColor = System.Drawing.Color.Red
        Me.Txt_Id_Supplier.Location = New System.Drawing.Point(137, 28)
        Me.Txt_Id_Supplier.Name = "Txt_Id_Supplier"
        Me.Txt_Id_Supplier.Size = New System.Drawing.Size(281, 26)
        Me.Txt_Id_Supplier.TabIndex = 1
        '
        'Lbl_Id_Supplier
        '
        Me.Lbl_Id_Supplier.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Lbl_Id_Supplier.AutoSize = True
        Me.Lbl_Id_Supplier.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Lbl_Id_Supplier.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Lbl_Id_Supplier.ForeColor = System.Drawing.Color.Black
        Me.Lbl_Id_Supplier.Location = New System.Drawing.Point(24, 32)
        Me.Lbl_Id_Supplier.MaximumSize = New System.Drawing.Size(0, 40)
        Me.Lbl_Id_Supplier.Name = "Lbl_Id_Supplier"
        Me.Lbl_Id_Supplier.Size = New System.Drawing.Size(80, 20)
        Me.Lbl_Id_Supplier.TabIndex = 2
        Me.Lbl_Id_Supplier.Text = "รหัสผู้ผลิต:"
        '
        'My_DatabaseDataSet1
        '
        Me.My_DatabaseDataSet1.DataSetName = "My_DatabaseDataSet"
        Me.My_DatabaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(601, 13)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidth = 62
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(681, 539)
        Me.DataGridView1.TabIndex = 3
        '
        'Frm_Stock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1294, 650)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.MaximumSize = New System.Drawing.Size(1316, 706)
        Me.Name = "Frm_Stock"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "StockIn-StockOut"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Grp_Purchase.ResumeLayout(False)
        Me.Grp_Purchase.PerformLayout()
        Me.Grp_Supplier.ResumeLayout(False)
        Me.Grp_Supplier.PerformLayout()
        CType(Me.My_DatabaseDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Lbl_Pic As Label
    Friend WithEvents Lbl_Safety_Stock As Label
    Friend WithEvents Lbl_UnitCost As Label
    Friend WithEvents Lbl_Unitprice As Label
    Friend WithEvents Lbl_Quantity As Label
    Friend WithEvents Lbl_Price As Label
    Friend WithEvents LblTotal As Label
    Friend WithEvents Lbl_Productname As Label
    Friend WithEvents Lbl_Id_Product As Label
    Friend WithEvents Lbl_PurchaseDate As Label
    Friend WithEvents Lbl_Id_purchase As Label
    Friend WithEvents Grp_Purchase As GroupBox
    Friend WithEvents Grp_Supplier As GroupBox
    Friend WithEvents Txt_Safety_stock As TextBox
    Friend WithEvents Txt_Unitprice As TextBox
    Friend WithEvents Txt_Unitcost As TextBox
    Friend WithEvents Txt_TotalPrice As TextBox
    Friend WithEvents Txt_Price As TextBox
    Friend WithEvents Txt_Quantity As TextBox
    Friend WithEvents Txt_Productname As TextBox
    Friend WithEvents Txt_Pic As TextBox
    Friend WithEvents Txt_IdProduct As TextBox
    Friend WithEvents Txt_IdPurchase As TextBox
    Friend WithEvents Dtpick_purchasdatee As DateTimePicker
    Friend WithEvents Btn_browseimg As Button
    Friend WithEvents Lbl_BathPrice As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtAddress_Sup As TextBox
    Friend WithEvents Lbl_Address_Sup As Label
    Friend WithEvents Txt_SupplierName As TextBox
    Friend WithEvents Lbl_Name_Supplier As Label
    Friend WithEvents Txt_Id_Supplier As TextBox
    Friend WithEvents Lbl_Id_Supplier As Label
    Friend WithEvents Btn_Delete As Button
    Friend WithEvents Btn_Clear As Button
    Friend WithEvents Btn_Update As Button
    Friend WithEvents Btn_Add As Button
    Friend WithEvents Btn_Search As Button
    Friend WithEvents Lbl_Staffname As Label
    Friend WithEvents Lbl_staff As Label
    Friend WithEvents My_DatabaseDataSet1 As My_DatabaseDataSet
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Btn_refresh As Button
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Btn_minus As Button
    Friend WithEvents Btn_plus As Button
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Report
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
        Dim TreeNode6 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("รายวัน")
        Dim TreeNode7 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("รายงานยอดขาย", New System.Windows.Forms.TreeNode() {TreeNode6})
        Dim TreeNode8 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("รายวัน")
        Dim TreeNode9 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("ช่วงวันที่")
        Dim TreeNode10 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("รายงานสั่งซื้อ", New System.Windows.Forms.TreeNode() {TreeNode8, TreeNode9})
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TreeView1 = New System.Windows.Forms.TreeView()
        Me.Dgv_report = New System.Windows.Forms.DataGridView()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Btn_showReport = New System.Windows.Forms.Button()
        Me.Dpk_PurcEnd = New System.Windows.Forms.DateTimePicker()
        Me.Dpk_Purcstart = New System.Windows.Forms.DateTimePicker()
        Me.Lbl_purch_Enddate = New System.Windows.Forms.Label()
        Me.Lbl_purch_startdate = New System.Windows.Forms.Label()
        Me.Rdb_rangedate_purchase = New System.Windows.Forms.RadioButton()
        Me.Rdb_datepurchase = New System.Windows.Forms.RadioButton()
        Me.Lbl_purchaseDate = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Dpk_Ordersend = New System.Windows.Forms.DateTimePicker()
        Me.Dpk_Orderstart = New System.Windows.Forms.DateTimePicker()
        Me.Lbl_Orderdateend = New System.Windows.Forms.Label()
        Me.Lbl_Orderdatestart = New System.Windows.Forms.Label()
        Me.Rdb_daterange = New System.Windows.Forms.RadioButton()
        Me.Rdb_date = New System.Windows.Forms.RadioButton()
        Me.Txt_productname = New System.Windows.Forms.TextBox()
        Me.Txt_supplier = New System.Windows.Forms.TextBox()
        Me.Txt_productid = New System.Windows.Forms.TextBox()
        Me.Lbl_supplier = New System.Windows.Forms.Label()
        Me.Lbl_productname = New System.Windows.Forms.Label()
        Me.Lbl_Order_date = New System.Windows.Forms.Label()
        Me.Lbl_Id_products = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Btn_Print = New System.Windows.Forms.Button()
        Me.Btn_clear = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.Dgv_report, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.TreeView1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(170, 636)
        Me.Panel1.TabIndex = 0
        '
        'TreeView1
        '
        Me.TreeView1.Location = New System.Drawing.Point(6, 3)
        Me.TreeView1.Name = "TreeView1"
        TreeNode6.Name = "Child_dailySale_node"
        TreeNode6.Text = "รายวัน"
        TreeNode7.Name = "Daily_sale_node"
        TreeNode7.Text = "รายงานยอดขาย"
        TreeNode8.Name = "Child_purchase_nodedate"
        TreeNode8.Text = "รายวัน"
        TreeNode9.Name = "Child_purchase_noderangedt"
        TreeNode9.Text = "ช่วงวันที่"
        TreeNode10.Name = "Purchase_report_node"
        TreeNode10.Text = "รายงานสั่งซื้อ"
        Me.TreeView1.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode7, TreeNode10})
        Me.TreeView1.Size = New System.Drawing.Size(161, 633)
        Me.TreeView1.TabIndex = 0
        '
        'Dgv_report
        '
        Me.Dgv_report.ColumnHeadersHeight = 30
        Me.Dgv_report.Location = New System.Drawing.Point(171, 223)
        Me.Dgv_report.Name = "Dgv_report"
        Me.Dgv_report.RowHeadersWidth = 62
        Me.Dgv_report.RowTemplate.Height = 28
        Me.Dgv_report.Size = New System.Drawing.Size(883, 366)
        Me.Dgv_report.TabIndex = 4
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Btn_showReport)
        Me.Panel2.Controls.Add(Me.Dpk_PurcEnd)
        Me.Panel2.Controls.Add(Me.Dpk_Purcstart)
        Me.Panel2.Controls.Add(Me.Lbl_purch_Enddate)
        Me.Panel2.Controls.Add(Me.Lbl_purch_startdate)
        Me.Panel2.Controls.Add(Me.Rdb_rangedate_purchase)
        Me.Panel2.Controls.Add(Me.Rdb_datepurchase)
        Me.Panel2.Controls.Add(Me.Lbl_purchaseDate)
        Me.Panel2.Controls.Add(Me.GroupBox2)
        Me.Panel2.Controls.Add(Me.Dpk_Ordersend)
        Me.Panel2.Controls.Add(Me.Dpk_Orderstart)
        Me.Panel2.Controls.Add(Me.Lbl_Orderdateend)
        Me.Panel2.Controls.Add(Me.Lbl_Orderdatestart)
        Me.Panel2.Controls.Add(Me.Rdb_daterange)
        Me.Panel2.Controls.Add(Me.Rdb_date)
        Me.Panel2.Controls.Add(Me.Txt_productname)
        Me.Panel2.Controls.Add(Me.Txt_supplier)
        Me.Panel2.Controls.Add(Me.Txt_productid)
        Me.Panel2.Controls.Add(Me.Lbl_supplier)
        Me.Panel2.Controls.Add(Me.Lbl_productname)
        Me.Panel2.Controls.Add(Me.Lbl_Order_date)
        Me.Panel2.Controls.Add(Me.Lbl_Id_products)
        Me.Panel2.Controls.Add(Me.GroupBox1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(170, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(896, 221)
        Me.Panel2.TabIndex = 5
        '
        'Btn_showReport
        '
        Me.Btn_showReport.BackColor = System.Drawing.Color.ForestGreen
        Me.Btn_showReport.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Btn_showReport.ForeColor = System.Drawing.Color.White
        Me.Btn_showReport.Location = New System.Drawing.Point(783, 182)
        Me.Btn_showReport.Name = "Btn_showReport"
        Me.Btn_showReport.Size = New System.Drawing.Size(106, 37)
        Me.Btn_showReport.TabIndex = 18
        Me.Btn_showReport.Text = "Show"
        Me.Btn_showReport.UseVisualStyleBackColor = False
        '
        'Dpk_PurcEnd
        '
        Me.Dpk_PurcEnd.Location = New System.Drawing.Point(636, 149)
        Me.Dpk_PurcEnd.Name = "Dpk_PurcEnd"
        Me.Dpk_PurcEnd.Size = New System.Drawing.Size(200, 26)
        Me.Dpk_PurcEnd.TabIndex = 16
        '
        'Dpk_Purcstart
        '
        Me.Dpk_Purcstart.Location = New System.Drawing.Point(399, 148)
        Me.Dpk_Purcstart.Name = "Dpk_Purcstart"
        Me.Dpk_Purcstart.Size = New System.Drawing.Size(200, 26)
        Me.Dpk_Purcstart.TabIndex = 17
        '
        'Lbl_purch_Enddate
        '
        Me.Lbl_purch_Enddate.AutoSize = True
        Me.Lbl_purch_Enddate.Location = New System.Drawing.Point(605, 154)
        Me.Lbl_purch_Enddate.Name = "Lbl_purch_Enddate"
        Me.Lbl_purch_Enddate.Size = New System.Drawing.Size(25, 20)
        Me.Lbl_purch_Enddate.TabIndex = 14
        Me.Lbl_purch_Enddate.Text = "ถึง"
        '
        'Lbl_purch_startdate
        '
        Me.Lbl_purch_startdate.AutoSize = True
        Me.Lbl_purch_startdate.Location = New System.Drawing.Point(360, 154)
        Me.Lbl_purch_startdate.Name = "Lbl_purch_startdate"
        Me.Lbl_purch_startdate.Size = New System.Drawing.Size(35, 20)
        Me.Lbl_purch_startdate.TabIndex = 13
        Me.Lbl_purch_startdate.Text = "วันที่"
        '
        'Rdb_rangedate_purchase
        '
        Me.Rdb_rangedate_purchase.AutoSize = True
        Me.Rdb_rangedate_purchase.Location = New System.Drawing.Point(252, 150)
        Me.Rdb_rangedate_purchase.Name = "Rdb_rangedate_purchase"
        Me.Rdb_rangedate_purchase.Size = New System.Drawing.Size(83, 24)
        Me.Rdb_rangedate_purchase.TabIndex = 11
        Me.Rdb_rangedate_purchase.TabStop = True
        Me.Rdb_rangedate_purchase.Text = "ช่วงวันที่"
        Me.Rdb_rangedate_purchase.UseVisualStyleBackColor = True
        '
        'Rdb_datepurchase
        '
        Me.Rdb_datepurchase.AutoSize = True
        Me.Rdb_datepurchase.Location = New System.Drawing.Point(157, 149)
        Me.Rdb_datepurchase.Name = "Rdb_datepurchase"
        Me.Rdb_datepurchase.Size = New System.Drawing.Size(72, 24)
        Me.Rdb_datepurchase.TabIndex = 12
        Me.Rdb_datepurchase.TabStop = True
        Me.Rdb_datepurchase.Text = "รายวัน"
        Me.Rdb_datepurchase.UseVisualStyleBackColor = True
        '
        'Lbl_purchaseDate
        '
        Me.Lbl_purchaseDate.AutoSize = True
        Me.Lbl_purchaseDate.Location = New System.Drawing.Point(14, 153)
        Me.Lbl_purchaseDate.Name = "Lbl_purchaseDate"
        Me.Lbl_purchaseDate.Size = New System.Drawing.Size(122, 20)
        Me.Lbl_purchaseDate.TabIndex = 10
        Me.Lbl_purchaseDate.Text = "โปรดระบุวันที่สั่งซื้อ"
        '
        'GroupBox2
        '
        Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GroupBox2.Location = New System.Drawing.Point(9, 128)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(355, 63)
        Me.GroupBox2.TabIndex = 15
        Me.GroupBox2.TabStop = False
        '
        'Dpk_Ordersend
        '
        Me.Dpk_Ordersend.CustomFormat = "dd/M/yyyy"
        Me.Dpk_Ordersend.Location = New System.Drawing.Point(634, 72)
        Me.Dpk_Ordersend.Name = "Dpk_Ordersend"
        Me.Dpk_Ordersend.Size = New System.Drawing.Size(200, 26)
        Me.Dpk_Ordersend.TabIndex = 9
        Me.Dpk_Ordersend.Value = New Date(2021, 6, 22, 0, 0, 0, 0)
        '
        'Dpk_Orderstart
        '
        Me.Dpk_Orderstart.CustomFormat = "dd/M/yyyy"
        Me.Dpk_Orderstart.Location = New System.Drawing.Point(397, 71)
        Me.Dpk_Orderstart.Name = "Dpk_Orderstart"
        Me.Dpk_Orderstart.Size = New System.Drawing.Size(200, 26)
        Me.Dpk_Orderstart.TabIndex = 9
        Me.Dpk_Orderstart.Value = New Date(2021, 6, 22, 0, 0, 0, 0)
        '
        'Lbl_Orderdateend
        '
        Me.Lbl_Orderdateend.AutoSize = True
        Me.Lbl_Orderdateend.Location = New System.Drawing.Point(603, 77)
        Me.Lbl_Orderdateend.Name = "Lbl_Orderdateend"
        Me.Lbl_Orderdateend.Size = New System.Drawing.Size(25, 20)
        Me.Lbl_Orderdateend.TabIndex = 5
        Me.Lbl_Orderdateend.Text = "ถึง"
        '
        'Lbl_Orderdatestart
        '
        Me.Lbl_Orderdatestart.AutoSize = True
        Me.Lbl_Orderdatestart.Location = New System.Drawing.Point(358, 77)
        Me.Lbl_Orderdatestart.Name = "Lbl_Orderdatestart"
        Me.Lbl_Orderdatestart.Size = New System.Drawing.Size(35, 20)
        Me.Lbl_Orderdatestart.TabIndex = 4
        Me.Lbl_Orderdatestart.Text = "วันที่"
        '
        'Rdb_daterange
        '
        Me.Rdb_daterange.AutoSize = True
        Me.Rdb_daterange.Location = New System.Drawing.Point(249, 73)
        Me.Rdb_daterange.Name = "Rdb_daterange"
        Me.Rdb_daterange.Size = New System.Drawing.Size(83, 24)
        Me.Rdb_daterange.TabIndex = 3
        Me.Rdb_daterange.TabStop = True
        Me.Rdb_daterange.Text = "ช่วงวันที่"
        Me.Rdb_daterange.UseVisualStyleBackColor = True
        '
        'Rdb_date
        '
        Me.Rdb_date.AutoSize = True
        Me.Rdb_date.Location = New System.Drawing.Point(155, 72)
        Me.Rdb_date.Name = "Rdb_date"
        Me.Rdb_date.Size = New System.Drawing.Size(72, 24)
        Me.Rdb_date.TabIndex = 3
        Me.Rdb_date.TabStop = True
        Me.Rdb_date.Text = "รายวัน"
        Me.Rdb_date.UseVisualStyleBackColor = True
        '
        'Txt_productname
        '
        Me.Txt_productname.Location = New System.Drawing.Point(326, 11)
        Me.Txt_productname.Name = "Txt_productname"
        Me.Txt_productname.Size = New System.Drawing.Size(228, 26)
        Me.Txt_productname.TabIndex = 1
        '
        'Txt_supplier
        '
        Me.Txt_supplier.Location = New System.Drawing.Point(683, 11)
        Me.Txt_supplier.Name = "Txt_supplier"
        Me.Txt_supplier.Size = New System.Drawing.Size(206, 26)
        Me.Txt_supplier.TabIndex = 1
        '
        'Txt_productid
        '
        Me.Txt_productid.Location = New System.Drawing.Point(84, 11)
        Me.Txt_productid.Name = "Txt_productid"
        Me.Txt_productid.Size = New System.Drawing.Size(171, 26)
        Me.Txt_productid.TabIndex = 1
        '
        'Lbl_supplier
        '
        Me.Lbl_supplier.AutoSize = True
        Me.Lbl_supplier.Location = New System.Drawing.Point(560, 17)
        Me.Lbl_supplier.Name = "Lbl_supplier"
        Me.Lbl_supplier.Size = New System.Drawing.Size(109, 20)
        Me.Lbl_supplier.TabIndex = 0
        Me.Lbl_supplier.Text = "บริษัทจัดจำหน่าย"
        '
        'Lbl_productname
        '
        Me.Lbl_productname.AutoSize = True
        Me.Lbl_productname.Location = New System.Drawing.Point(262, 17)
        Me.Lbl_productname.Name = "Lbl_productname"
        Me.Lbl_productname.Size = New System.Drawing.Size(59, 20)
        Me.Lbl_productname.TabIndex = 0
        Me.Lbl_productname.Text = "ชื่อสินค้า"
        '
        'Lbl_Order_date
        '
        Me.Lbl_Order_date.AutoSize = True
        Me.Lbl_Order_date.Location = New System.Drawing.Point(12, 76)
        Me.Lbl_Order_date.Name = "Lbl_Order_date"
        Me.Lbl_Order_date.Size = New System.Drawing.Size(114, 20)
        Me.Lbl_Order_date.TabIndex = 0
        Me.Lbl_Order_date.Text = "โปรดระบุวันที่ขาย"
        '
        'Lbl_Id_products
        '
        Me.Lbl_Id_products.AutoSize = True
        Me.Lbl_Id_products.Location = New System.Drawing.Point(12, 17)
        Me.Lbl_Id_products.Name = "Lbl_Id_products"
        Me.Lbl_Id_products.Size = New System.Drawing.Size(66, 20)
        Me.Lbl_Id_products.TabIndex = 0
        Me.Lbl_Id_products.Text = "รหัสสินค้า"
        '
        'GroupBox1
        '
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GroupBox1.Location = New System.Drawing.Point(7, 51)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(349, 63)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        '
        'Btn_Print
        '
        Me.Btn_Print.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.Btn_Print.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Btn_Print.ForeColor = System.Drawing.Color.White
        Me.Btn_Print.Location = New System.Drawing.Point(953, 596)
        Me.Btn_Print.Name = "Btn_Print"
        Me.Btn_Print.Size = New System.Drawing.Size(106, 37)
        Me.Btn_Print.TabIndex = 18
        Me.Btn_Print.Text = "Print"
        Me.Btn_Print.UseVisualStyleBackColor = False
        '
        'Btn_clear
        '
        Me.Btn_clear.BackColor = System.Drawing.Color.Red
        Me.Btn_clear.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Btn_clear.ForeColor = System.Drawing.Color.White
        Me.Btn_clear.Location = New System.Drawing.Point(841, 596)
        Me.Btn_clear.Name = "Btn_clear"
        Me.Btn_clear.Size = New System.Drawing.Size(106, 37)
        Me.Btn_clear.TabIndex = 19
        Me.Btn_clear.Text = "Clear"
        Me.Btn_clear.UseVisualStyleBackColor = False
        '
        'Frm_Report
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1066, 636)
        Me.Controls.Add(Me.Btn_clear)
        Me.Controls.Add(Me.Btn_Print)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Dgv_report)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Frm_Report"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Frm_Report"
        Me.Panel1.ResumeLayout(False)
        CType(Me.Dgv_report, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Dgv_report As DataGridView
    Friend WithEvents TreeView1 As TreeView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Txt_productname As TextBox
    Friend WithEvents Txt_supplier As TextBox
    Friend WithEvents Txt_productid As TextBox
    Friend WithEvents Lbl_supplier As Label
    Friend WithEvents Lbl_productname As Label
    Friend WithEvents Lbl_Id_products As Label
    Friend WithEvents Rdb_daterange As RadioButton
    Friend WithEvents Rdb_date As RadioButton
    Friend WithEvents Lbl_Order_date As Label
    Friend WithEvents Lbl_Orderdateend As Label
    Friend WithEvents Lbl_Orderdatestart As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Dpk_Ordersend As DateTimePicker
    Friend WithEvents Dpk_Orderstart As DateTimePicker
    Friend WithEvents Dpk_PurcEnd As DateTimePicker
    Friend WithEvents Dpk_Purcstart As DateTimePicker
    Friend WithEvents Lbl_purch_Enddate As Label
    Friend WithEvents Lbl_purch_startdate As Label
    Friend WithEvents Rdb_rangedate_purchase As RadioButton
    Friend WithEvents Rdb_datepurchase As RadioButton
    Friend WithEvents Lbl_purchaseDate As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Btn_showReport As Button
    Friend WithEvents Btn_Print As Button
    Friend WithEvents Btn_clear As Button
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_ViewProd
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
        Me.GrpB_viewProd = New System.Windows.Forms.GroupBox()
        Me.Rdb_ViewPurchase = New System.Windows.Forms.RadioButton()
        Me.Rdb_Details = New System.Windows.Forms.RadioButton()
        Me.Lbl_QuestView = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Btn_Select = New System.Windows.Forms.Button()
        Me.GrpB_viewProd.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GrpB_viewProd
        '
        Me.GrpB_viewProd.Controls.Add(Me.Rdb_ViewPurchase)
        Me.GrpB_viewProd.Controls.Add(Me.Rdb_Details)
        Me.GrpB_viewProd.Controls.Add(Me.Lbl_QuestView)
        Me.GrpB_viewProd.Controls.Add(Me.GroupBox1)
        Me.GrpB_viewProd.Location = New System.Drawing.Point(12, 23)
        Me.GrpB_viewProd.Name = "GrpB_viewProd"
        Me.GrpB_viewProd.Size = New System.Drawing.Size(503, 287)
        Me.GrpB_viewProd.TabIndex = 0
        Me.GrpB_viewProd.TabStop = False
        '
        'Rdb_ViewPurchase
        '
        Me.Rdb_ViewPurchase.AutoSize = True
        Me.Rdb_ViewPurchase.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Rdb_ViewPurchase.Location = New System.Drawing.Point(95, 147)
        Me.Rdb_ViewPurchase.Name = "Rdb_ViewPurchase"
        Me.Rdb_ViewPurchase.Size = New System.Drawing.Size(253, 29)
        Me.Rdb_ViewPurchase.TabIndex = 1
        Me.Rdb_ViewPurchase.TabStop = True
        Me.Rdb_ViewPurchase.Text = "เลือกดูประวัติการสั้่งซื้อสินค้า"
        Me.Rdb_ViewPurchase.UseVisualStyleBackColor = True
        '
        'Rdb_Details
        '
        Me.Rdb_Details.AutoSize = True
        Me.Rdb_Details.BackColor = System.Drawing.SystemColors.Control
        Me.Rdb_Details.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Rdb_Details.Location = New System.Drawing.Point(95, 83)
        Me.Rdb_Details.Name = "Rdb_Details"
        Me.Rdb_Details.Size = New System.Drawing.Size(219, 29)
        Me.Rdb_Details.TabIndex = 1
        Me.Rdb_Details.TabStop = True
        Me.Rdb_Details.Text = "เลือกดูรายละเอียดสินค้า"
        Me.Rdb_Details.UseVisualStyleBackColor = False
        '
        'Lbl_QuestView
        '
        Me.Lbl_QuestView.AutoSize = True
        Me.Lbl_QuestView.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Lbl_QuestView.Location = New System.Drawing.Point(140, 19)
        Me.Lbl_QuestView.Name = "Lbl_QuestView"
        Me.Lbl_QuestView.Size = New System.Drawing.Size(187, 25)
        Me.Lbl_QuestView.TabIndex = 0
        Me.Lbl_QuestView.Text = "เลือกมุมุมองที่ต้องการดู"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Btn_Select)
        Me.GroupBox1.Location = New System.Drawing.Point(17, 52)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(460, 204)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        '
        'Btn_Select
        '
        Me.Btn_Select.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Btn_Select.Location = New System.Drawing.Point(75, 158)
        Me.Btn_Select.Name = "Btn_Select"
        Me.Btn_Select.Size = New System.Drawing.Size(281, 40)
        Me.Btn_Select.TabIndex = 0
        Me.Btn_Select.Text = "เลือก"
        Me.Btn_Select.UseVisualStyleBackColor = True
        '
        'Frm_ViewProd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(527, 349)
        Me.Controls.Add(Me.GrpB_viewProd)
        Me.Name = "Frm_ViewProd"
        Me.Text = "เลือกรายการ"
        Me.GrpB_viewProd.ResumeLayout(False)
        Me.GrpB_viewProd.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GrpB_viewProd As GroupBox
    Friend WithEvents Rdb_ViewPurchase As RadioButton
    Friend WithEvents Rdb_Details As RadioButton
    Friend WithEvents Lbl_QuestView As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Btn_Select As Button
End Class

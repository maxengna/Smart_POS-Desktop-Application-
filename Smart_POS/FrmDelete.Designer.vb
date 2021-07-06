<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDelete
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmDelete))
        Me.Pnl_Top_del = New System.Windows.Forms.Panel()
        Me.Lbl_delete_item = New System.Windows.Forms.Label()
        Me.Grpbox_delete = New System.Windows.Forms.GroupBox()
        Me.Rdb_Delstock = New System.Windows.Forms.RadioButton()
        Me.Rdb_delproduct = New System.Windows.Forms.RadioButton()
        Me.Btn_confirm = New System.Windows.Forms.Button()
        Me.Btn_cancel = New System.Windows.Forms.Button()
        Me.PicExit__del = New System.Windows.Forms.PictureBox()
        Me.Pnl_Top_del.SuspendLayout()
        Me.Grpbox_delete.SuspendLayout()
        CType(Me.PicExit__del, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Pnl_Top_del
        '
        Me.Pnl_Top_del.BackColor = System.Drawing.Color.Goldenrod
        Me.Pnl_Top_del.Controls.Add(Me.PicExit__del)
        Me.Pnl_Top_del.Controls.Add(Me.Lbl_delete_item)
        Me.Pnl_Top_del.Dock = System.Windows.Forms.DockStyle.Top
        Me.Pnl_Top_del.Location = New System.Drawing.Point(0, 0)
        Me.Pnl_Top_del.Name = "Pnl_Top_del"
        Me.Pnl_Top_del.Size = New System.Drawing.Size(563, 66)
        Me.Pnl_Top_del.TabIndex = 0
        '
        'Lbl_delete_item
        '
        Me.Lbl_delete_item.AutoSize = True
        Me.Lbl_delete_item.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Lbl_delete_item.Location = New System.Drawing.Point(123, 22)
        Me.Lbl_delete_item.Name = "Lbl_delete_item"
        Me.Lbl_delete_item.Size = New System.Drawing.Size(362, 32)
        Me.Lbl_delete_item.TabIndex = 0
        Me.Lbl_delete_item.Text = "โปรดระบุรายการที่จะทำการลบ"
        Me.Lbl_delete_item.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Grpbox_delete
        '
        Me.Grpbox_delete.Controls.Add(Me.Rdb_Delstock)
        Me.Grpbox_delete.Controls.Add(Me.Rdb_delproduct)
        Me.Grpbox_delete.Location = New System.Drawing.Point(17, 93)
        Me.Grpbox_delete.Name = "Grpbox_delete"
        Me.Grpbox_delete.Size = New System.Drawing.Size(524, 177)
        Me.Grpbox_delete.TabIndex = 1
        Me.Grpbox_delete.TabStop = False
        '
        'Rdb_Delstock
        '
        Me.Rdb_Delstock.AutoSize = True
        Me.Rdb_Delstock.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Rdb_Delstock.Location = New System.Drawing.Point(65, 99)
        Me.Rdb_Delstock.Name = "Rdb_Delstock"
        Me.Rdb_Delstock.Size = New System.Drawing.Size(206, 26)
        Me.Rdb_Delstock.TabIndex = 0
        Me.Rdb_Delstock.TabStop = True
        Me.Rdb_Delstock.Text = "ลดสต็อกสินค้าที่เลือก"
        Me.Rdb_Delstock.UseVisualStyleBackColor = True
        '
        'Rdb_delproduct
        '
        Me.Rdb_delproduct.AutoSize = True
        Me.Rdb_delproduct.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Rdb_delproduct.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Rdb_delproduct.Location = New System.Drawing.Point(65, 42)
        Me.Rdb_delproduct.Name = "Rdb_delproduct"
        Me.Rdb_delproduct.Size = New System.Drawing.Size(427, 26)
        Me.Rdb_delproduct.TabIndex = 0
        Me.Rdb_delproduct.TabStop = True
        Me.Rdb_delproduct.Text = "ลบรายการสินค้าที่เลือกออกจากฐานข้อมูลปัจจุบัน"
        Me.Rdb_delproduct.UseVisualStyleBackColor = True
        '
        'Btn_confirm
        '
        Me.Btn_confirm.BackColor = System.Drawing.Color.Green
        Me.Btn_confirm.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Btn_confirm.ForeColor = System.Drawing.SystemColors.Control
        Me.Btn_confirm.Location = New System.Drawing.Point(92, 291)
        Me.Btn_confirm.Name = "Btn_confirm"
        Me.Btn_confirm.Size = New System.Drawing.Size(160, 49)
        Me.Btn_confirm.TabIndex = 2
        Me.Btn_confirm.Text = "ยืนยัน"
        Me.Btn_confirm.UseVisualStyleBackColor = False
        '
        'Btn_cancel
        '
        Me.Btn_cancel.BackColor = System.Drawing.Color.Red
        Me.Btn_cancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Btn_cancel.ForeColor = System.Drawing.SystemColors.Control
        Me.Btn_cancel.Location = New System.Drawing.Point(292, 291)
        Me.Btn_cancel.Name = "Btn_cancel"
        Me.Btn_cancel.Size = New System.Drawing.Size(160, 49)
        Me.Btn_cancel.TabIndex = 2
        Me.Btn_cancel.Text = "ยกเลิก"
        Me.Btn_cancel.UseVisualStyleBackColor = False
        '
        'PicExit__del
        '
        Me.PicExit__del.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PicExit__del.BackColor = System.Drawing.Color.Transparent
        Me.PicExit__del.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PicExit__del.Image = CType(resources.GetObject("PicExit__del.Image"), System.Drawing.Image)
        Me.PicExit__del.Location = New System.Drawing.Point(519, 1)
        Me.PicExit__del.Name = "PicExit__del"
        Me.PicExit__del.Size = New System.Drawing.Size(44, 42)
        Me.PicExit__del.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PicExit__del.TabIndex = 36
        Me.PicExit__del.TabStop = False
        '
        'FrmDelete
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(563, 378)
        Me.Controls.Add(Me.Btn_cancel)
        Me.Controls.Add(Me.Btn_confirm)
        Me.Controls.Add(Me.Grpbox_delete)
        Me.Controls.Add(Me.Pnl_Top_del)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmDelete"
        Me.Text = "FrmDelete"
        Me.Pnl_Top_del.ResumeLayout(False)
        Me.Pnl_Top_del.PerformLayout()
        Me.Grpbox_delete.ResumeLayout(False)
        Me.Grpbox_delete.PerformLayout()
        CType(Me.PicExit__del, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Pnl_Top_del As Panel
    Friend WithEvents Lbl_delete_item As Label
    Friend WithEvents Grpbox_delete As GroupBox
    Friend WithEvents Btn_confirm As Button
    Friend WithEvents Btn_cancel As Button
    Friend WithEvents Rdb_Delstock As RadioButton
    Friend WithEvents Rdb_delproduct As RadioButton
    Friend WithEvents PicExit__del As PictureBox
End Class

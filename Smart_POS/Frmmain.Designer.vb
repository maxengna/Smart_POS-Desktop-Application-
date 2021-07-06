<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frmmain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frmmain))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.HomeTlstrip = New System.Windows.Forms.ToolStripMenuItem()
        Me.MemberTlstrip = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewMemberToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductTlstrip = New System.Windows.Forms.ToolStripMenuItem()
        Me.StockTlstrip = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportTlstrip = New System.Windows.Forms.ToolStripMenuItem()
        Me.LockoutTlstrip = New System.Windows.Forms.ToolStripMenuItem()
        Me.PicExit_Regis = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PicExit_Regis, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HomeTlstrip, Me.MemberTlstrip, Me.ProductTlstrip, Me.StockTlstrip, Me.ReportTlstrip, Me.LockoutTlstrip})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1487, 36)
        Me.MenuStrip1.Stretch = False
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'HomeTlstrip
        '
        Me.HomeTlstrip.BackColor = System.Drawing.Color.Aqua
        Me.HomeTlstrip.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HomeTlstrip.Name = "HomeTlstrip"
        Me.HomeTlstrip.Size = New System.Drawing.Size(72, 32)
        Me.HomeTlstrip.Text = "Home"
        '
        'MemberTlstrip
        '
        Me.MemberTlstrip.BackColor = System.Drawing.Color.Gray
        Me.MemberTlstrip.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewMemberToolStripMenuItem})
        Me.MemberTlstrip.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MemberTlstrip.Name = "MemberTlstrip"
        Me.MemberTlstrip.Size = New System.Drawing.Size(94, 32)
        Me.MemberTlstrip.Text = "Member "
        '
        'NewMemberToolStripMenuItem
        '
        Me.NewMemberToolStripMenuItem.Name = "NewMemberToolStripMenuItem"
        Me.NewMemberToolStripMenuItem.Size = New System.Drawing.Size(270, 34)
        Me.NewMemberToolStripMenuItem.Text = "New Member"
        '
        'ProductTlstrip
        '
        Me.ProductTlstrip.BackColor = System.Drawing.Color.LawnGreen
        Me.ProductTlstrip.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProductTlstrip.Name = "ProductTlstrip"
        Me.ProductTlstrip.Size = New System.Drawing.Size(86, 32)
        Me.ProductTlstrip.Text = "Product"
        '
        'StockTlstrip
        '
        Me.StockTlstrip.BackColor = System.Drawing.Color.Tomato
        Me.StockTlstrip.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StockTlstrip.Name = "StockTlstrip"
        Me.StockTlstrip.Size = New System.Drawing.Size(68, 32)
        Me.StockTlstrip.Text = "Stock"
        '
        'ReportTlstrip
        '
        Me.ReportTlstrip.BackColor = System.Drawing.Color.Yellow
        Me.ReportTlstrip.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReportTlstrip.Name = "ReportTlstrip"
        Me.ReportTlstrip.Size = New System.Drawing.Size(77, 32)
        Me.ReportTlstrip.Text = "Report"
        '
        'LockoutTlstrip
        '
        Me.LockoutTlstrip.BackColor = System.Drawing.Color.Red
        Me.LockoutTlstrip.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LockoutTlstrip.Name = "LockoutTlstrip"
        Me.LockoutTlstrip.Size = New System.Drawing.Size(93, 32)
        Me.LockoutTlstrip.Text = "Lock Out"
        '
        'PicExit_Regis
        '
        Me.PicExit_Regis.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PicExit_Regis.BackColor = System.Drawing.Color.Transparent
        Me.PicExit_Regis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PicExit_Regis.Image = CType(resources.GetObject("PicExit_Regis.Image"), System.Drawing.Image)
        Me.PicExit_Regis.Location = New System.Drawing.Point(1422, 0)
        Me.PicExit_Regis.Name = "PicExit_Regis"
        Me.PicExit_Regis.Size = New System.Drawing.Size(65, 43)
        Me.PicExit_Regis.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PicExit_Regis.TabIndex = 37
        Me.PicExit_Regis.TabStop = False
        '
        'Frmmain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleTurquoise
        Me.ClientSize = New System.Drawing.Size(1487, 657)
        Me.Controls.Add(Me.PicExit_Regis)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Frmmain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Frmmain"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PicExit_Regis, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents HomeTlstrip As ToolStripMenuItem
    Friend WithEvents MemberTlstrip As ToolStripMenuItem
    Friend WithEvents ProductTlstrip As ToolStripMenuItem
    Friend WithEvents StockTlstrip As ToolStripMenuItem
    Friend WithEvents ReportTlstrip As ToolStripMenuItem
    Friend WithEvents LockoutTlstrip As ToolStripMenuItem
    Friend WithEvents NewMemberToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PicExit_Regis As PictureBox
End Class

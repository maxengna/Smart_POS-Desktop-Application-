<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmLogin))
        Me.Lblusername = New System.Windows.Forms.Label()
        Me.Lbl_Password = New System.Windows.Forms.Label()
        Me.Txt_username = New System.Windows.Forms.TextBox()
        Me.Txtp_pass = New System.Windows.Forms.TextBox()
        Me.Btn_submit = New System.Windows.Forms.Button()
        Me.Btn_cancel = New System.Windows.Forms.Button()
        Me.Link_regis = New System.Windows.Forms.LinkLabel()
        Me.Lbllogo = New System.Windows.Forms.Label()
        Me.PicExit_Regis = New System.Windows.Forms.PictureBox()
        Me.ChkPass = New System.Windows.Forms.CheckBox()
        Me.Lbl_checkLogin = New System.Windows.Forms.Label()
        CType(Me.PicExit_Regis, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Lblusername
        '
        Me.Lblusername.AutoSize = True
        Me.Lblusername.BackColor = System.Drawing.Color.Transparent
        Me.Lblusername.Font = New System.Drawing.Font("Bernard MT Condensed", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblusername.ForeColor = System.Drawing.Color.White
        Me.Lblusername.Location = New System.Drawing.Point(334, 263)
        Me.Lblusername.Name = "Lblusername"
        Me.Lblusername.Size = New System.Drawing.Size(177, 47)
        Me.Lblusername.TabIndex = 0
        Me.Lblusername.Text = "Username"
        '
        'Lbl_Password
        '
        Me.Lbl_Password.AutoSize = True
        Me.Lbl_Password.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_Password.Font = New System.Drawing.Font("Bernard MT Condensed", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Password.ForeColor = System.Drawing.Color.White
        Me.Lbl_Password.Location = New System.Drawing.Point(334, 386)
        Me.Lbl_Password.Name = "Lbl_Password"
        Me.Lbl_Password.Size = New System.Drawing.Size(174, 47)
        Me.Lbl_Password.TabIndex = 1
        Me.Lbl_Password.Text = "Password"
        '
        'Txt_username
        '
        Me.Txt_username.BackColor = System.Drawing.Color.Gainsboro
        Me.Txt_username.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_username.Font = New System.Drawing.Font("Angsana New", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_username.HideSelection = False
        Me.Txt_username.Location = New System.Drawing.Point(506, 263)
        Me.Txt_username.Multiline = True
        Me.Txt_username.Name = "Txt_username"
        Me.Txt_username.Size = New System.Drawing.Size(410, 47)
        Me.Txt_username.TabIndex = 2
        '
        'Txtp_pass
        '
        Me.Txtp_pass.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.Txtp_pass.Font = New System.Drawing.Font("AngsanaUPC", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtp_pass.Location = New System.Drawing.Point(506, 386)
        Me.Txtp_pass.Multiline = True
        Me.Txtp_pass.Name = "Txtp_pass"
        Me.Txtp_pass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Txtp_pass.Size = New System.Drawing.Size(400, 49)
        Me.Txtp_pass.TabIndex = 3
        '
        'Btn_submit
        '
        Me.Btn_submit.BackColor = System.Drawing.Color.Blue
        Me.Btn_submit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Btn_submit.ForeColor = System.Drawing.Color.White
        Me.Btn_submit.Location = New System.Drawing.Point(450, 499)
        Me.Btn_submit.Name = "Btn_submit"
        Me.Btn_submit.Size = New System.Drawing.Size(150, 52)
        Me.Btn_submit.TabIndex = 4
        Me.Btn_submit.Text = "Submit"
        Me.Btn_submit.UseVisualStyleBackColor = False
        '
        'Btn_cancel
        '
        Me.Btn_cancel.BackColor = System.Drawing.Color.Red
        Me.Btn_cancel.ForeColor = System.Drawing.Color.White
        Me.Btn_cancel.Location = New System.Drawing.Point(734, 499)
        Me.Btn_cancel.Name = "Btn_cancel"
        Me.Btn_cancel.Size = New System.Drawing.Size(150, 52)
        Me.Btn_cancel.TabIndex = 4
        Me.Btn_cancel.Text = "Cancel"
        Me.Btn_cancel.UseVisualStyleBackColor = False
        '
        'Link_regis
        '
        Me.Link_regis.AutoSize = True
        Me.Link_regis.BackColor = System.Drawing.Color.Transparent
        Me.Link_regis.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Link_regis.Font = New System.Drawing.Font("Berlin Sans FB", 25.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Link_regis.ForeColor = System.Drawing.Color.Yellow
        Me.Link_regis.ImageAlign = System.Drawing.ContentAlignment.TopRight
        Me.Link_regis.LinkColor = System.Drawing.Color.Lime
        Me.Link_regis.Location = New System.Drawing.Point(1120, 632)
        Me.Link_regis.Name = "Link_regis"
        Me.Link_regis.Size = New System.Drawing.Size(223, 63)
        Me.Link_regis.TabIndex = 5
        Me.Link_regis.TabStop = True
        Me.Link_regis.Text = "Register"
        '
        'Lbllogo
        '
        Me.Lbllogo.AutoSize = True
        Me.Lbllogo.BackColor = System.Drawing.Color.Transparent
        Me.Lbllogo.Font = New System.Drawing.Font("Calibri", 30.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbllogo.ForeColor = System.Drawing.Color.Red
        Me.Lbllogo.Location = New System.Drawing.Point(298, 9)
        Me.Lbllogo.Name = "Lbllogo"
        Me.Lbllogo.Size = New System.Drawing.Size(927, 73)
        Me.Lbllogo.TabIndex = 6
        Me.Lbllogo.Text = "SMART POS MANAGEMENT SYSTEM"
        '
        'PicExit_Regis
        '
        Me.PicExit_Regis.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PicExit_Regis.BackColor = System.Drawing.Color.Transparent
        Me.PicExit_Regis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PicExit_Regis.Image = CType(resources.GetObject("PicExit_Regis.Image"), System.Drawing.Image)
        Me.PicExit_Regis.Location = New System.Drawing.Point(1436, 0)
        Me.PicExit_Regis.Name = "PicExit_Regis"
        Me.PicExit_Regis.Size = New System.Drawing.Size(63, 48)
        Me.PicExit_Regis.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PicExit_Regis.TabIndex = 36
        Me.PicExit_Regis.TabStop = False
        '
        'ChkPass
        '
        Me.ChkPass.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkPass.AutoSize = True
        Me.ChkPass.BackColor = System.Drawing.Color.Transparent
        Me.ChkPass.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkPass.Location = New System.Drawing.Point(820, 438)
        Me.ChkPass.Margin = New System.Windows.Forms.Padding(0)
        Me.ChkPass.Name = "ChkPass"
        Me.ChkPass.Size = New System.Drawing.Size(121, 23)
        Me.ChkPass.TabIndex = 37
        Me.ChkPass.Text = "Show Pass"
        Me.ChkPass.UseVisualStyleBackColor = False
        '
        'Lbl_checkLogin
        '
        Me.Lbl_checkLogin.AutoSize = True
        Me.Lbl_checkLogin.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_checkLogin.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_checkLogin.ForeColor = System.Drawing.Color.Red
        Me.Lbl_checkLogin.Location = New System.Drawing.Point(584, 236)
        Me.Lbl_checkLogin.Name = "Lbl_checkLogin"
        Me.Lbl_checkLogin.Size = New System.Drawing.Size(264, 24)
        Me.Lbl_checkLogin.TabIndex = 38
        Me.Lbl_checkLogin.Text = "User or Password Invalid"
        '
        'FrmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 28.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1500, 913)
        Me.Controls.Add(Me.Lbl_checkLogin)
        Me.Controls.Add(Me.ChkPass)
        Me.Controls.Add(Me.PicExit_Regis)
        Me.Controls.Add(Me.Lbllogo)
        Me.Controls.Add(Me.Link_regis)
        Me.Controls.Add(Me.Btn_cancel)
        Me.Controls.Add(Me.Btn_submit)
        Me.Controls.Add(Me.Txtp_pass)
        Me.Controls.Add(Me.Txt_username)
        Me.Controls.Add(Me.Lbl_Password)
        Me.Controls.Add(Me.Lblusername)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Font = New System.Drawing.Font("Bernard MT Condensed", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "FrmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PicExit_Regis, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Lblusername As Label
    Friend WithEvents Lbl_Password As Label
    Friend WithEvents Txt_username As TextBox
    Friend WithEvents Txtp_pass As TextBox
    Friend WithEvents Btn_submit As Button
    Friend WithEvents Btn_cancel As Button
    Friend WithEvents Link_regis As LinkLabel
    Friend WithEvents Lbllogo As Label
    Friend WithEvents PicExit_Regis As PictureBox
    Friend WithEvents ChkPass As CheckBox
    Friend WithEvents Lbl_checkLogin As Label
End Class

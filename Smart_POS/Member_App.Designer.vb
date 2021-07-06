<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Member_App
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Member_App))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PicExit_Regis = New System.Windows.Forms.PictureBox()
        Me.Lbl_register = New System.Windows.Forms.Label()
        Me.Lbl_username = New System.Windows.Forms.Label()
        Me.Lbl_password = New System.Windows.Forms.Label()
        Me.Txt_username = New System.Windows.Forms.TextBox()
        Me.Txt_password = New System.Windows.Forms.TextBox()
        Me.Txt_confirm = New System.Windows.Forms.TextBox()
        Me.Lbl_Crm_pass = New System.Windows.Forms.Label()
        Me.LblFirstname = New System.Windows.Forms.Label()
        Me.LblPosition = New System.Windows.Forms.Label()
        Me.Txt_Firstname = New System.Windows.Forms.TextBox()
        Me.TxtPosition = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.TxtId = New System.Windows.Forms.TextBox()
        Me.LblId = New System.Windows.Forms.Label()
        Me.Txt_condition = New System.Windows.Forms.TextBox()
        Me.TxtTel = New System.Windows.Forms.TextBox()
        Me.TxtLastname = New System.Windows.Forms.TextBox()
        Me.LblTel = New System.Windows.Forms.Label()
        Me.LblLastname = New System.Windows.Forms.Label()
        Me.BtnClear = New System.Windows.Forms.Button()
        Me.BtnSubmit = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.PicExit_Regis, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Chartreuse
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(146, 650)
        Me.Panel1.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(74, 62)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 36
        Me.PictureBox1.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.PicExit_Regis)
        Me.Panel2.Controls.Add(Me.Lbl_register)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(146, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1083, 94)
        Me.Panel2.TabIndex = 40
        '
        'PicExit_Regis
        '
        Me.PicExit_Regis.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PicExit_Regis.BackColor = System.Drawing.Color.Transparent
        Me.PicExit_Regis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PicExit_Regis.Image = CType(resources.GetObject("PicExit_Regis.Image"), System.Drawing.Image)
        Me.PicExit_Regis.Location = New System.Drawing.Point(1019, 3)
        Me.PicExit_Regis.Name = "PicExit_Regis"
        Me.PicExit_Regis.Size = New System.Drawing.Size(63, 48)
        Me.PicExit_Regis.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PicExit_Regis.TabIndex = 35
        Me.PicExit_Regis.TabStop = False
        '
        'Lbl_register
        '
        Me.Lbl_register.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_register.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_register.Font = New System.Drawing.Font("Tahoma", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_register.ForeColor = System.Drawing.Color.Red
        Me.Lbl_register.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Lbl_register.Location = New System.Drawing.Point(306, 25)
        Me.Lbl_register.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Lbl_register.Name = "Lbl_register"
        Me.Lbl_register.Size = New System.Drawing.Size(429, 48)
        Me.Lbl_register.TabIndex = 0
        Me.Lbl_register.Text = " Register Member"
        Me.Lbl_register.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Lbl_username
        '
        Me.Lbl_username.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.Lbl_username.AutoSize = True
        Me.Lbl_username.BackColor = System.Drawing.Color.LightSalmon
        Me.Lbl_username.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Lbl_username.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Lbl_username.Location = New System.Drawing.Point(119, 211)
        Me.Lbl_username.Name = "Lbl_username"
        Me.Lbl_username.Size = New System.Drawing.Size(113, 46)
        Me.Lbl_username.TabIndex = 47
        Me.Lbl_username.Text = "Username"
        '
        'Lbl_password
        '
        Me.Lbl_password.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.Lbl_password.AutoSize = True
        Me.Lbl_password.BackColor = System.Drawing.Color.LightSalmon
        Me.Lbl_password.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Lbl_password.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Lbl_password.Location = New System.Drawing.Point(123, 301)
        Me.Lbl_password.Name = "Lbl_password"
        Me.Lbl_password.Size = New System.Drawing.Size(109, 46)
        Me.Lbl_password.TabIndex = 48
        Me.Lbl_password.Text = "Password"
        '
        'Txt_username
        '
        Me.Txt_username.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.Txt_username.Location = New System.Drawing.Point(238, 208)
        Me.Txt_username.Name = "Txt_username"
        Me.Txt_username.Size = New System.Drawing.Size(238, 52)
        Me.Txt_username.TabIndex = 49
        '
        'Txt_password
        '
        Me.Txt_password.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.Txt_password.Location = New System.Drawing.Point(238, 295)
        Me.Txt_password.Name = "Txt_password"
        Me.Txt_password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Txt_password.Size = New System.Drawing.Size(238, 52)
        Me.Txt_password.TabIndex = 50
        '
        'Txt_confirm
        '
        Me.Txt_confirm.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.Txt_confirm.Location = New System.Drawing.Point(238, 387)
        Me.Txt_confirm.Name = "Txt_confirm"
        Me.Txt_confirm.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Txt_confirm.Size = New System.Drawing.Size(238, 52)
        Me.Txt_confirm.TabIndex = 51
        '
        'Lbl_Crm_pass
        '
        Me.Lbl_Crm_pass.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.Lbl_Crm_pass.AutoSize = True
        Me.Lbl_Crm_pass.BackColor = System.Drawing.Color.LightSalmon
        Me.Lbl_Crm_pass.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Lbl_Crm_pass.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Lbl_Crm_pass.Location = New System.Drawing.Point(132, 393)
        Me.Lbl_Crm_pass.Name = "Lbl_Crm_pass"
        Me.Lbl_Crm_pass.Size = New System.Drawing.Size(100, 46)
        Me.Lbl_Crm_pass.TabIndex = 52
        Me.Lbl_Crm_pass.Text = "Confirm"
        '
        'LblFirstname
        '
        Me.LblFirstname.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.LblFirstname.AutoSize = True
        Me.LblFirstname.BackColor = System.Drawing.Color.LightSalmon
        Me.LblFirstname.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblFirstname.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.LblFirstname.Location = New System.Drawing.Point(122, 45)
        Me.LblFirstname.Name = "LblFirstname"
        Me.LblFirstname.Size = New System.Drawing.Size(115, 46)
        Me.LblFirstname.TabIndex = 53
        Me.LblFirstname.Text = "Firstname"
        '
        'LblPosition
        '
        Me.LblPosition.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.LblPosition.AutoSize = True
        Me.LblPosition.BackColor = System.Drawing.Color.LightSalmon
        Me.LblPosition.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblPosition.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.LblPosition.Location = New System.Drawing.Point(123, 130)
        Me.LblPosition.Name = "LblPosition"
        Me.LblPosition.Size = New System.Drawing.Size(111, 46)
        Me.LblPosition.TabIndex = 54
        Me.LblPosition.Text = "Position   "
        Me.LblPosition.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Txt_Firstname
        '
        Me.Txt_Firstname.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.Txt_Firstname.Location = New System.Drawing.Point(240, 39)
        Me.Txt_Firstname.Name = "Txt_Firstname"
        Me.Txt_Firstname.Size = New System.Drawing.Size(240, 52)
        Me.Txt_Firstname.TabIndex = 55
        '
        'TxtPosition
        '
        Me.TxtPosition.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.TxtPosition.Location = New System.Drawing.Point(240, 124)
        Me.TxtPosition.Name = "TxtPosition"
        Me.TxtPosition.Size = New System.Drawing.Size(240, 52)
        Me.TxtPosition.TabIndex = 56
        '
        'Panel3
        '
        Me.Panel3.AutoScroll = True
        Me.Panel3.Controls.Add(Me.TxtId)
        Me.Panel3.Controls.Add(Me.LblId)
        Me.Panel3.Controls.Add(Me.Txt_condition)
        Me.Panel3.Controls.Add(Me.TxtTel)
        Me.Panel3.Controls.Add(Me.TxtLastname)
        Me.Panel3.Controls.Add(Me.LblTel)
        Me.Panel3.Controls.Add(Me.LblLastname)
        Me.Panel3.Controls.Add(Me.BtnClear)
        Me.Panel3.Controls.Add(Me.BtnSubmit)
        Me.Panel3.Controls.Add(Me.TxtPosition)
        Me.Panel3.Controls.Add(Me.Txt_Firstname)
        Me.Panel3.Controls.Add(Me.LblPosition)
        Me.Panel3.Controls.Add(Me.LblFirstname)
        Me.Panel3.Controls.Add(Me.Lbl_Crm_pass)
        Me.Panel3.Controls.Add(Me.Txt_confirm)
        Me.Panel3.Controls.Add(Me.Txt_password)
        Me.Panel3.Controls.Add(Me.Txt_username)
        Me.Panel3.Controls.Add(Me.Lbl_password)
        Me.Panel3.Controls.Add(Me.Lbl_username)
        Me.Panel3.Font = New System.Drawing.Font("AngsanaUPC", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Panel3.Location = New System.Drawing.Point(146, 90)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1079, 557)
        Me.Panel3.TabIndex = 41
        '
        'TxtId
        '
        Me.TxtId.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.TxtId.Location = New System.Drawing.Point(725, 205)
        Me.TxtId.Name = "TxtId"
        Me.TxtId.Size = New System.Drawing.Size(240, 52)
        Me.TxtId.TabIndex = 64
        '
        'LblId
        '
        Me.LblId.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.LblId.AutoSize = True
        Me.LblId.BackColor = System.Drawing.Color.Yellow
        Me.LblId.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblId.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.LblId.Location = New System.Drawing.Point(668, 211)
        Me.LblId.Name = "LblId"
        Me.LblId.Size = New System.Drawing.Size(42, 46)
        Me.LblId.TabIndex = 63
        Me.LblId.Text = "Id"
        Me.LblId.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Txt_condition
        '
        Me.Txt_condition.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Txt_condition.ForeColor = System.Drawing.Color.DarkRed
        Me.Txt_condition.Location = New System.Drawing.Point(602, 280)
        Me.Txt_condition.Multiline = True
        Me.Txt_condition.Name = "Txt_condition"
        Me.Txt_condition.Size = New System.Drawing.Size(363, 173)
        Me.Txt_condition.TabIndex = 62
        Me.Txt_condition.Text = "Password consist :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "1.Total charecter Greater than or equal to 8 characters" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "2." &
    "Upper charecter at least 1" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "3.Lower charecter at least 1" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "4.Numeric at least 1" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) &
    "5.Special charecter at least 1" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'TxtTel
        '
        Me.TxtTel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.TxtTel.Location = New System.Drawing.Point(725, 124)
        Me.TxtTel.Name = "TxtTel"
        Me.TxtTel.Size = New System.Drawing.Size(240, 52)
        Me.TxtTel.TabIndex = 61
        '
        'TxtLastname
        '
        Me.TxtLastname.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.TxtLastname.Location = New System.Drawing.Point(725, 39)
        Me.TxtLastname.Name = "TxtLastname"
        Me.TxtLastname.Size = New System.Drawing.Size(240, 52)
        Me.TxtLastname.TabIndex = 60
        '
        'LblTel
        '
        Me.LblTel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.LblTel.AutoSize = True
        Me.LblTel.BackColor = System.Drawing.Color.LightSalmon
        Me.LblTel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblTel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.LblTel.Location = New System.Drawing.Point(668, 130)
        Me.LblTel.Name = "LblTel"
        Me.LblTel.Size = New System.Drawing.Size(51, 46)
        Me.LblTel.TabIndex = 59
        Me.LblTel.Text = "Tel"
        Me.LblTel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblLastname
        '
        Me.LblLastname.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.LblLastname.AutoSize = True
        Me.LblLastname.BackColor = System.Drawing.Color.LightSalmon
        Me.LblLastname.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblLastname.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.LblLastname.Location = New System.Drawing.Point(607, 45)
        Me.LblLastname.Name = "LblLastname"
        Me.LblLastname.Size = New System.Drawing.Size(112, 46)
        Me.LblLastname.TabIndex = 58
        Me.LblLastname.Text = "Lastname"
        '
        'BtnClear
        '
        Me.BtnClear.BackColor = System.Drawing.Color.Red
        Me.BtnClear.ForeColor = System.Drawing.Color.White
        Me.BtnClear.Location = New System.Drawing.Point(553, 476)
        Me.BtnClear.Name = "BtnClear"
        Me.BtnClear.Size = New System.Drawing.Size(166, 60)
        Me.BtnClear.TabIndex = 57
        Me.BtnClear.Text = "Clear"
        Me.BtnClear.UseVisualStyleBackColor = False
        '
        'BtnSubmit
        '
        Me.BtnSubmit.BackColor = System.Drawing.Color.Blue
        Me.BtnSubmit.ForeColor = System.Drawing.Color.White
        Me.BtnSubmit.Location = New System.Drawing.Point(311, 476)
        Me.BtnSubmit.Name = "BtnSubmit"
        Me.BtnSubmit.Size = New System.Drawing.Size(166, 60)
        Me.BtnSubmit.TabIndex = 57
        Me.BtnSubmit.Text = "Submit"
        Me.BtnSubmit.UseVisualStyleBackColor = False
        '
        'Member_App
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1229, 650)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximumSize = New System.Drawing.Size(1251, 719)
        Me.Name = "Member_App"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Member_App"
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.PicExit_Regis, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PicExit_Regis As PictureBox
    Friend WithEvents Lbl_register As Label
    Friend WithEvents Lbl_username As Label
    Friend WithEvents Lbl_password As Label
    Friend WithEvents Txt_username As TextBox
    Friend WithEvents Txt_password As TextBox
    Friend WithEvents Txt_confirm As TextBox
    Friend WithEvents Lbl_Crm_pass As Label
    Friend WithEvents LblFirstname As Label
    Friend WithEvents LblPosition As Label
    Friend WithEvents Txt_Firstname As TextBox
    Friend WithEvents TxtPosition As TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents BtnClear As Button
    Friend WithEvents BtnSubmit As Button
    Friend WithEvents TxtTel As TextBox
    Friend WithEvents TxtLastname As TextBox
    Friend WithEvents LblTel As Label
    Friend WithEvents LblLastname As Label
    Friend WithEvents Txt_condition As TextBox
    Friend WithEvents TxtId As TextBox
    Friend WithEvents LblId As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class

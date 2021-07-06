<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_member
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_member))
        Me.Lbl_register = New System.Windows.Forms.Label()
        Me.Lbl_firstname = New System.Windows.Forms.Label()
        Me.Lbl_lastname = New System.Windows.Forms.Label()
        Me.Lbl_position = New System.Windows.Forms.Label()
        Me.Lbl_address = New System.Windows.Forms.Label()
        Me.Lbl_tambon = New System.Windows.Forms.Label()
        Me.Lbl_province = New System.Windows.Forms.Label()
        Me.Lbl_amper = New System.Windows.Forms.Label()
        Me.Lbl_zipcode = New System.Windows.Forms.Label()
        Me.Txt_firstname = New System.Windows.Forms.TextBox()
        Me.Txt_lastname = New System.Windows.Forms.TextBox()
        Me.Txt_tel = New System.Windows.Forms.TextBox()
        Me.Txt_address = New System.Windows.Forms.TextBox()
        Me.Txt_tambon = New System.Windows.Forms.TextBox()
        Me.Txt_amper = New System.Windows.Forms.TextBox()
        Me.Txt_province = New System.Windows.Forms.TextBox()
        Me.Txt_zipcode = New System.Windows.Forms.TextBox()
        Me.Txt_position = New System.Windows.Forms.TextBox()
        Me.Lbl_username = New System.Windows.Forms.Label()
        Me.Lbl_password = New System.Windows.Forms.Label()
        Me.Txt_username = New System.Windows.Forms.TextBox()
        Me.Txt_password = New System.Windows.Forms.TextBox()
        Me.Txt_confirm = New System.Windows.Forms.TextBox()
        Me.Btn_submit = New System.Windows.Forms.Button()
        Me.Btn_update = New System.Windows.Forms.Button()
        Me.Btn_search = New System.Windows.Forms.Button()
        Me.Btn_Clear = New System.Windows.Forms.Button()
        Me.Cbo_typeuser = New System.Windows.Forms.ComboBox()
        Me.Lbl_typeuser = New System.Windows.Forms.Label()
        Me.Txt_id = New System.Windows.Forms.TextBox()
        Me.Lbl_Id_customer = New System.Windows.Forms.Label()
        Me.Btn_del_member = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Lblupdate = New System.Windows.Forms.Label()
        Me.Txt_Update = New System.Windows.Forms.TextBox()
        Me.Lbl_Crm_pass = New System.Windows.Forms.Label()
        Me.Lbl_Tel = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Lbl_register
        '
        Me.Lbl_register.AutoSize = True
        Me.Lbl_register.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_register.Font = New System.Drawing.Font("Tahoma", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_register.ForeColor = System.Drawing.Color.Red
        Me.Lbl_register.Location = New System.Drawing.Point(389, -1)
        Me.Lbl_register.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Lbl_register.Name = "Lbl_register"
        Me.Lbl_register.Size = New System.Drawing.Size(632, 48)
        Me.Lbl_register.TabIndex = 0
        Me.Lbl_register.Text = " Member Management System"
        Me.Lbl_register.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Lbl_firstname
        '
        Me.Lbl_firstname.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_firstname.AutoSize = True
        Me.Lbl_firstname.BackColor = System.Drawing.Color.LightSalmon
        Me.Lbl_firstname.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Lbl_firstname.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Lbl_firstname.Location = New System.Drawing.Point(98, 125)
        Me.Lbl_firstname.Name = "Lbl_firstname"
        Me.Lbl_firstname.Size = New System.Drawing.Size(115, 46)
        Me.Lbl_firstname.TabIndex = 1
        Me.Lbl_firstname.Text = "Firstname"
        '
        'Lbl_lastname
        '
        Me.Lbl_lastname.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_lastname.AutoSize = True
        Me.Lbl_lastname.BackColor = System.Drawing.Color.LightSalmon
        Me.Lbl_lastname.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Lbl_lastname.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Lbl_lastname.Location = New System.Drawing.Point(673, 129)
        Me.Lbl_lastname.Name = "Lbl_lastname"
        Me.Lbl_lastname.Size = New System.Drawing.Size(112, 46)
        Me.Lbl_lastname.TabIndex = 2
        Me.Lbl_lastname.Text = "Lastname"
        '
        'Lbl_position
        '
        Me.Lbl_position.AutoSize = True
        Me.Lbl_position.BackColor = System.Drawing.Color.LightSalmon
        Me.Lbl_position.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Lbl_position.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Lbl_position.Location = New System.Drawing.Point(674, 184)
        Me.Lbl_position.Name = "Lbl_position"
        Me.Lbl_position.Size = New System.Drawing.Size(111, 46)
        Me.Lbl_position.TabIndex = 4
        Me.Lbl_position.Text = "Position   "
        Me.Lbl_position.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Lbl_address
        '
        Me.Lbl_address.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Lbl_address.AutoSize = True
        Me.Lbl_address.BackColor = System.Drawing.Color.LightSalmon
        Me.Lbl_address.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Lbl_address.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Lbl_address.Location = New System.Drawing.Point(115, 245)
        Me.Lbl_address.Name = "Lbl_address"
        Me.Lbl_address.Size = New System.Drawing.Size(95, 46)
        Me.Lbl_address.TabIndex = 5
        Me.Lbl_address.Text = "Address"
        '
        'Lbl_tambon
        '
        Me.Lbl_tambon.AutoSize = True
        Me.Lbl_tambon.BackColor = System.Drawing.Color.LightSalmon
        Me.Lbl_tambon.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Lbl_tambon.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Lbl_tambon.Location = New System.Drawing.Point(110, 303)
        Me.Lbl_tambon.Name = "Lbl_tambon"
        Me.Lbl_tambon.Size = New System.Drawing.Size(100, 46)
        Me.Lbl_tambon.TabIndex = 6
        Me.Lbl_tambon.Text = "Tombon"
        '
        'Lbl_province
        '
        Me.Lbl_province.AutoSize = True
        Me.Lbl_province.BackColor = System.Drawing.Color.LightSalmon
        Me.Lbl_province.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Lbl_province.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Lbl_province.Location = New System.Drawing.Point(110, 358)
        Me.Lbl_province.Name = "Lbl_province"
        Me.Lbl_province.Size = New System.Drawing.Size(102, 46)
        Me.Lbl_province.TabIndex = 7
        Me.Lbl_province.Text = "Province"
        '
        'Lbl_amper
        '
        Me.Lbl_amper.AutoSize = True
        Me.Lbl_amper.BackColor = System.Drawing.Color.LightSalmon
        Me.Lbl_amper.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Lbl_amper.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Lbl_amper.Location = New System.Drawing.Point(674, 300)
        Me.Lbl_amper.Name = "Lbl_amper"
        Me.Lbl_amper.Size = New System.Drawing.Size(110, 46)
        Me.Lbl_amper.TabIndex = 8
        Me.Lbl_amper.Text = "Amper     "
        Me.Lbl_amper.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Lbl_zipcode
        '
        Me.Lbl_zipcode.AutoSize = True
        Me.Lbl_zipcode.BackColor = System.Drawing.Color.LightSalmon
        Me.Lbl_zipcode.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Lbl_zipcode.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Lbl_zipcode.Location = New System.Drawing.Point(678, 355)
        Me.Lbl_zipcode.Name = "Lbl_zipcode"
        Me.Lbl_zipcode.Size = New System.Drawing.Size(106, 46)
        Me.Lbl_zipcode.TabIndex = 9
        Me.Lbl_zipcode.Text = "Zip_code"
        '
        'Txt_firstname
        '
        Me.Txt_firstname.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Txt_firstname.Location = New System.Drawing.Point(216, 123)
        Me.Txt_firstname.Name = "Txt_firstname"
        Me.Txt_firstname.Size = New System.Drawing.Size(412, 52)
        Me.Txt_firstname.TabIndex = 11
        '
        'Txt_lastname
        '
        Me.Txt_lastname.Location = New System.Drawing.Point(791, 123)
        Me.Txt_lastname.Name = "Txt_lastname"
        Me.Txt_lastname.Size = New System.Drawing.Size(419, 52)
        Me.Txt_lastname.TabIndex = 12
        '
        'Txt_tel
        '
        Me.Txt_tel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Txt_tel.Location = New System.Drawing.Point(216, 181)
        Me.Txt_tel.Name = "Txt_tel"
        Me.Txt_tel.Size = New System.Drawing.Size(412, 52)
        Me.Txt_tel.TabIndex = 13
        '
        'Txt_address
        '
        Me.Txt_address.Location = New System.Drawing.Point(216, 239)
        Me.Txt_address.Name = "Txt_address"
        Me.Txt_address.Size = New System.Drawing.Size(994, 52)
        Me.Txt_address.TabIndex = 14
        '
        'Txt_tambon
        '
        Me.Txt_tambon.Location = New System.Drawing.Point(216, 297)
        Me.Txt_tambon.Name = "Txt_tambon"
        Me.Txt_tambon.Size = New System.Drawing.Size(417, 52)
        Me.Txt_tambon.TabIndex = 15
        '
        'Txt_amper
        '
        Me.Txt_amper.Location = New System.Drawing.Point(791, 294)
        Me.Txt_amper.Name = "Txt_amper"
        Me.Txt_amper.Size = New System.Drawing.Size(419, 52)
        Me.Txt_amper.TabIndex = 16
        '
        'Txt_province
        '
        Me.Txt_province.Location = New System.Drawing.Point(216, 355)
        Me.Txt_province.Name = "Txt_province"
        Me.Txt_province.Size = New System.Drawing.Size(417, 52)
        Me.Txt_province.TabIndex = 17
        '
        'Txt_zipcode
        '
        Me.Txt_zipcode.Location = New System.Drawing.Point(791, 352)
        Me.Txt_zipcode.Name = "Txt_zipcode"
        Me.Txt_zipcode.Size = New System.Drawing.Size(419, 52)
        Me.Txt_zipcode.TabIndex = 18
        '
        'Txt_position
        '
        Me.Txt_position.Location = New System.Drawing.Point(791, 178)
        Me.Txt_position.Name = "Txt_position"
        Me.Txt_position.Size = New System.Drawing.Size(419, 52)
        Me.Txt_position.TabIndex = 19
        '
        'Lbl_username
        '
        Me.Lbl_username.AutoSize = True
        Me.Lbl_username.BackColor = System.Drawing.Color.LightSalmon
        Me.Lbl_username.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Lbl_username.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Lbl_username.Location = New System.Drawing.Point(102, 416)
        Me.Lbl_username.Name = "Lbl_username"
        Me.Lbl_username.Size = New System.Drawing.Size(113, 46)
        Me.Lbl_username.TabIndex = 20
        Me.Lbl_username.Text = "Username"
        '
        'Lbl_password
        '
        Me.Lbl_password.AutoSize = True
        Me.Lbl_password.BackColor = System.Drawing.Color.LightSalmon
        Me.Lbl_password.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Lbl_password.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Lbl_password.Location = New System.Drawing.Point(106, 477)
        Me.Lbl_password.Name = "Lbl_password"
        Me.Lbl_password.Size = New System.Drawing.Size(109, 46)
        Me.Lbl_password.TabIndex = 21
        Me.Lbl_password.Text = "Password"
        '
        'Txt_username
        '
        Me.Txt_username.Location = New System.Drawing.Point(216, 413)
        Me.Txt_username.Name = "Txt_username"
        Me.Txt_username.Size = New System.Drawing.Size(417, 52)
        Me.Txt_username.TabIndex = 23
        '
        'Txt_password
        '
        Me.Txt_password.Location = New System.Drawing.Point(216, 474)
        Me.Txt_password.Name = "Txt_password"
        Me.Txt_password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Txt_password.Size = New System.Drawing.Size(417, 52)
        Me.Txt_password.TabIndex = 24
        '
        'Txt_confirm
        '
        Me.Txt_confirm.Location = New System.Drawing.Point(216, 532)
        Me.Txt_confirm.Name = "Txt_confirm"
        Me.Txt_confirm.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Txt_confirm.Size = New System.Drawing.Size(417, 52)
        Me.Txt_confirm.TabIndex = 25
        '
        'Btn_submit
        '
        Me.Btn_submit.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.Btn_submit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_submit.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Btn_submit.ForeColor = System.Drawing.Color.Blue
        Me.Btn_submit.Image = CType(resources.GetObject("Btn_submit.Image"), System.Drawing.Image)
        Me.Btn_submit.Location = New System.Drawing.Point(110, 590)
        Me.Btn_submit.Name = "Btn_submit"
        Me.Btn_submit.Size = New System.Drawing.Size(165, 86)
        Me.Btn_submit.TabIndex = 26
        Me.Btn_submit.Text = "Register"
        Me.Btn_submit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_submit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_submit.UseVisualStyleBackColor = False
        '
        'Btn_update
        '
        Me.Btn_update.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Btn_update.ForeColor = System.Drawing.Color.Blue
        Me.Btn_update.Image = CType(resources.GetObject("Btn_update.Image"), System.Drawing.Image)
        Me.Btn_update.Location = New System.Drawing.Point(330, 590)
        Me.Btn_update.Name = "Btn_update"
        Me.Btn_update.Size = New System.Drawing.Size(165, 86)
        Me.Btn_update.TabIndex = 27
        Me.Btn_update.Text = "Update"
        Me.Btn_update.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_update.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_update.UseVisualStyleBackColor = False
        '
        'Btn_search
        '
        Me.Btn_search.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Btn_search.ForeColor = System.Drawing.Color.Blue
        Me.Btn_search.Image = CType(resources.GetObject("Btn_search.Image"), System.Drawing.Image)
        Me.Btn_search.Location = New System.Drawing.Point(557, 590)
        Me.Btn_search.Name = "Btn_search"
        Me.Btn_search.Size = New System.Drawing.Size(165, 86)
        Me.Btn_search.TabIndex = 28
        Me.Btn_search.Text = "Search"
        Me.Btn_search.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_search.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_search.UseVisualStyleBackColor = False
        '
        'Btn_Clear
        '
        Me.Btn_Clear.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Btn_Clear.ForeColor = System.Drawing.Color.Blue
        Me.Btn_Clear.Image = CType(resources.GetObject("Btn_Clear.Image"), System.Drawing.Image)
        Me.Btn_Clear.Location = New System.Drawing.Point(791, 590)
        Me.Btn_Clear.Name = "Btn_Clear"
        Me.Btn_Clear.Size = New System.Drawing.Size(165, 86)
        Me.Btn_Clear.TabIndex = 29
        Me.Btn_Clear.Text = "Clear"
        Me.Btn_Clear.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Clear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_Clear.UseVisualStyleBackColor = False
        '
        'Cbo_typeuser
        '
        Me.Cbo_typeuser.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Cbo_typeuser.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.Cbo_typeuser.FormattingEnabled = True
        Me.Cbo_typeuser.Items.AddRange(New Object() {"Staff", "Customer"})
        Me.Cbo_typeuser.Location = New System.Drawing.Point(216, 65)
        Me.Cbo_typeuser.Name = "Cbo_typeuser"
        Me.Cbo_typeuser.Size = New System.Drawing.Size(121, 52)
        Me.Cbo_typeuser.TabIndex = 30
        '
        'Lbl_typeuser
        '
        Me.Lbl_typeuser.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_typeuser.AutoSize = True
        Me.Lbl_typeuser.BackColor = System.Drawing.Color.Yellow
        Me.Lbl_typeuser.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Lbl_typeuser.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Lbl_typeuser.Location = New System.Drawing.Point(147, 71)
        Me.Lbl_typeuser.Name = "Lbl_typeuser"
        Me.Lbl_typeuser.Size = New System.Drawing.Size(68, 46)
        Me.Lbl_typeuser.TabIndex = 31
        Me.Lbl_typeuser.Text = "Type"
        '
        'Txt_id
        '
        Me.Txt_id.Location = New System.Drawing.Point(810, 437)
        Me.Txt_id.Name = "Txt_id"
        Me.Txt_id.Size = New System.Drawing.Size(339, 52)
        Me.Txt_id.TabIndex = 33
        '
        'Lbl_Id_customer
        '
        Me.Lbl_Id_customer.AutoSize = True
        Me.Lbl_Id_customer.BackColor = System.Drawing.Color.Blue
        Me.Lbl_Id_customer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Lbl_Id_customer.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Lbl_Id_customer.ForeColor = System.Drawing.Color.White
        Me.Lbl_Id_customer.Location = New System.Drawing.Point(82, 24)
        Me.Lbl_Id_customer.Name = "Lbl_Id_customer"
        Me.Lbl_Id_customer.Size = New System.Drawing.Size(45, 46)
        Me.Lbl_Id_customer.TabIndex = 32
        Me.Lbl_Id_customer.Text = "ID"
        '
        'Btn_del_member
        '
        Me.Btn_del_member.BackColor = System.Drawing.Color.Red
        Me.Btn_del_member.ForeColor = System.Drawing.Color.Snow
        Me.Btn_del_member.Image = CType(resources.GetObject("Btn_del_member.Image"), System.Drawing.Image)
        Me.Btn_del_member.Location = New System.Drawing.Point(999, 590)
        Me.Btn_del_member.Name = "Btn_del_member"
        Me.Btn_del_member.Size = New System.Drawing.Size(195, 86)
        Me.Btn_del_member.TabIndex = 34
        Me.Btn_del_member.Text = "Delete_member"
        Me.Btn_del_member.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_del_member.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_del_member.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(1188, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(63, 48)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 35
        Me.PictureBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Silver
        Me.Panel1.Controls.Add(Me.Lblupdate)
        Me.Panel1.Controls.Add(Me.Txt_Update)
        Me.Panel1.Controls.Add(Me.Lbl_Id_customer)
        Me.Panel1.Location = New System.Drawing.Point(677, 419)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(481, 152)
        Me.Panel1.TabIndex = 36
        '
        'Lblupdate
        '
        Me.Lblupdate.AutoSize = True
        Me.Lblupdate.BackColor = System.Drawing.Color.Blue
        Me.Lblupdate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Lblupdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Lblupdate.ForeColor = System.Drawing.Color.White
        Me.Lblupdate.Location = New System.Drawing.Point(39, 82)
        Me.Lblupdate.Name = "Lblupdate"
        Me.Lblupdate.Size = New System.Drawing.Size(88, 46)
        Me.Lblupdate.TabIndex = 35
        Me.Lblupdate.Text = "Update"
        '
        'Txt_Update
        '
        Me.Txt_Update.Location = New System.Drawing.Point(133, 76)
        Me.Txt_Update.Name = "Txt_Update"
        Me.Txt_Update.Size = New System.Drawing.Size(339, 52)
        Me.Txt_Update.TabIndex = 34
        '
        'Lbl_Crm_pass
        '
        Me.Lbl_Crm_pass.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_Crm_pass.AutoSize = True
        Me.Lbl_Crm_pass.BackColor = System.Drawing.Color.LightSalmon
        Me.Lbl_Crm_pass.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Lbl_Crm_pass.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Lbl_Crm_pass.Location = New System.Drawing.Point(115, 538)
        Me.Lbl_Crm_pass.Name = "Lbl_Crm_pass"
        Me.Lbl_Crm_pass.Size = New System.Drawing.Size(100, 46)
        Me.Lbl_Crm_pass.TabIndex = 37
        Me.Lbl_Crm_pass.Text = "Confirm"
        '
        'Lbl_Tel
        '
        Me.Lbl_Tel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_Tel.AutoSize = True
        Me.Lbl_Tel.BackColor = System.Drawing.Color.LightSalmon
        Me.Lbl_Tel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Lbl_Tel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Lbl_Tel.Location = New System.Drawing.Point(98, 187)
        Me.Lbl_Tel.Name = "Lbl_Tel"
        Me.Lbl_Tel.Size = New System.Drawing.Size(116, 46)
        Me.Lbl_Tel.TabIndex = 38
        Me.Lbl_Tel.Text = "Telephone"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Blue
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.PictureBox2)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Controls.Add(Me.Lbl_register)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1251, 59)
        Me.Panel2.TabIndex = 39
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(-1, -1)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(103, 59)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox2.TabIndex = 36
        Me.PictureBox2.TabStop = False
        '
        'Frm_member
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 44.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MediumSpringGreen
        Me.ClientSize = New System.Drawing.Size(1251, 709)
        Me.Controls.Add(Me.Lbl_Tel)
        Me.Controls.Add(Me.Lbl_Crm_pass)
        Me.Controls.Add(Me.Txt_id)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Btn_del_member)
        Me.Controls.Add(Me.Lbl_typeuser)
        Me.Controls.Add(Me.Cbo_typeuser)
        Me.Controls.Add(Me.Btn_Clear)
        Me.Controls.Add(Me.Btn_search)
        Me.Controls.Add(Me.Btn_update)
        Me.Controls.Add(Me.Btn_submit)
        Me.Controls.Add(Me.Txt_confirm)
        Me.Controls.Add(Me.Txt_password)
        Me.Controls.Add(Me.Txt_username)
        Me.Controls.Add(Me.Lbl_password)
        Me.Controls.Add(Me.Lbl_username)
        Me.Controls.Add(Me.Txt_position)
        Me.Controls.Add(Me.Txt_zipcode)
        Me.Controls.Add(Me.Txt_province)
        Me.Controls.Add(Me.Txt_amper)
        Me.Controls.Add(Me.Txt_tambon)
        Me.Controls.Add(Me.Txt_address)
        Me.Controls.Add(Me.Txt_tel)
        Me.Controls.Add(Me.Txt_lastname)
        Me.Controls.Add(Me.Txt_firstname)
        Me.Controls.Add(Me.Lbl_zipcode)
        Me.Controls.Add(Me.Lbl_amper)
        Me.Controls.Add(Me.Lbl_province)
        Me.Controls.Add(Me.Lbl_tambon)
        Me.Controls.Add(Me.Lbl_address)
        Me.Controls.Add(Me.Lbl_position)
        Me.Controls.Add(Me.Lbl_lastname)
        Me.Controls.Add(Me.Lbl_firstname)
        Me.Controls.Add(Me.Panel2)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Font = New System.Drawing.Font("AngsanaUPC", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
        Me.MinimumSize = New System.Drawing.Size(800, 600)
        Me.Name = "Frm_member"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Lbl_register As Label
    Friend WithEvents Lbl_firstname As Label
    Friend WithEvents Lbl_lastname As Label
    Friend WithEvents Lbl_position As Label
    Friend WithEvents Lbl_address As Label
    Friend WithEvents Lbl_tambon As Label
    Friend WithEvents Lbl_province As Label
    Friend WithEvents Lbl_amper As Label
    Friend WithEvents Lbl_zipcode As Label
    Friend WithEvents Txt_firstname As TextBox
    Friend WithEvents Txt_lastname As TextBox
    Friend WithEvents Txt_tel As TextBox
    Friend WithEvents Txt_address As TextBox
    Friend WithEvents Txt_tambon As TextBox
    Friend WithEvents Txt_amper As TextBox
    Friend WithEvents Txt_province As TextBox
    Friend WithEvents Txt_zipcode As TextBox
    Friend WithEvents Txt_position As TextBox
    Friend WithEvents Lbl_username As Label
    Friend WithEvents Lbl_password As Label
    Friend WithEvents Txt_username As TextBox
    Friend WithEvents Txt_password As TextBox
    Friend WithEvents Txt_confirm As TextBox
    Friend WithEvents Btn_submit As Button
    Friend WithEvents Btn_update As Button
    Friend WithEvents Btn_search As Button
    Friend WithEvents Btn_Clear As Button
    Friend WithEvents Cbo_typeuser As ComboBox
    Friend WithEvents Lbl_typeuser As Label
    Friend WithEvents Txt_id As TextBox
    Friend WithEvents Lbl_Id_customer As Label
    Friend WithEvents Btn_del_member As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Txt_Update As TextBox
    Friend WithEvents Lbl_Crm_pass As Label
    Friend WithEvents Lbl_Tel As Label
    Friend WithEvents Lblupdate As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox2 As PictureBox
End Class

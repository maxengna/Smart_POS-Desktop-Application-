Imports System.Data.SqlClient
Imports System.Data

Public Class Member_App
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PicExit_Regis.Click

        FrmLogin.Show()
        Me.Hide()

    End Sub

    Private Sub BtnSubmit_Click(sender As Object, e As EventArgs) Handles BtnSubmit.Click

        Dim Firstname As String = Txt_Firstname.Text.Trim
        Dim Lastname As String = TxtLastname.Text.Trim
        Dim Position As String = TxtPosition.Text.Trim
        Dim Tel As String = TxtTel.Text.Trim
        Dim User As String = Txt_username.Text.Trim
        Dim Password As String = Txt_password.Text.Trim
        Dim Confirm As String = Txt_confirm.Text.Trim
        Dim Encrypt As String

        If Check_null(Firstname, Lastname, Position, Tel, User, Password, Confirm) = False Then

            If Password = Confirm Then

                If Correctpass(Confirm) = "Password complete" Then

                    Encrypt = EncryptPass2(Confirm)

                    'Add
                    sql = "select count(*) from Authen_staff where Username = '" & User & "' and Password =  '" & Encrypt & "'"


                    Query_Scalar()


                    If i > 0 Then

                        MessageBox.Show("User or Password Duplicate ")

                    Else

                        sql = "INSERT INTO Authen_staff (Username,Password) values('" & User & "','" & Encrypt & "')"
                        Insert_NewMember()

                        table.Clear()

                        sql = "SELECT Id_staff FROM Authen_staff WHERE  Username = '" & User & "'"

                        Query_Table()

                        Id_staff = ""

                        TxtId.Text = table.Rows(0)("Id_staff")
                        Id_staff = TxtId.Text

                        table.Clear()


                        'Insert other fill into other database 

                        sql = "INSERT INTO Staffs values('" & Id_staff & "','" & Firstname & "','" & Lastname & "','" & Position & "')"
                        Insert_NewMember()

                        sql = "INSERT INTO Staff_tel values('" & Id_staff & "','" & Tel & "')"
                        Insert_NewMember()


                        MessageBox.Show("Not Duplicate" & vbNewLine & "Register complete")

                    End If

                Else

                        MsgBox("Password Incorrect to Condition", MessageBoxIcon.Error, "Notification")

                End If


            Else

                MsgBox("Password and Confirm Password not equal", MessageBoxIcon.Error, "Notification")

            End If

        Else

            MsgBox("You do not fill out all the information.", MessageBoxIcon.Error, "Notification")


        End If





    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click

        Txt_Firstname.Text = ""
        TxtLastname.Text = ""
        TxtPosition.Text = ""
        TxtTel.Text = ""
        Txt_username.Text = ""
        Txt_password.Text = ""
        Txt_confirm.Text = ""
        TxtId.Text = ""

    End Sub

    Private Sub PictureBox1_Click_1(sender As Object, e As EventArgs) Handles PictureBox1.Click
        FrmLogin.Show()
        Me.Hide()

    End Sub
End Class
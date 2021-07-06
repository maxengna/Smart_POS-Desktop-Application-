Imports System.Data.SqlClient
Imports System.Data

Public Class FrmLogin

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Lbl_checkLogin.Visible = False
        Txt_username.Select()

    End Sub


    Private Sub Link_regis_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles Link_regis.LinkClicked
        Member_App.Show()
        Me.Hide()
    End Sub

    Private Sub PicExit_Regis_Click(sender As Object, e As EventArgs) Handles PicExit_Regis.Click
        Application.Exit()
    End Sub

    Private Sub ChkPass_CheckedChanged(sender As Object, e As EventArgs) Handles ChkPass.CheckedChanged
        If ChkPass.Checked = True Then

            Txtp_pass.PasswordChar = ""
        Else
            Txtp_pass.PasswordChar = "*"


        End If
    End Sub

    Private Sub Btn_submit_Click(sender As Object, e As EventArgs) Handles Btn_submit.Click

        Dim User As String = Txt_username.Text.Trim
        Userstaff = User

        Dim Password As String = Txtp_pass.Text.Trim
        Dim EncryptLogin As String = EncryptPass2(Password)



        If User = "" Or Password = "" Then

            Lbl_checkLogin.Text = "User or password invalid"
            Lbl_checkLogin.Visible = True

        Else



            sql = "select count(*) from Authen_staff where Username = '" & User & "' and Password =  '" & EncryptLogin & "'"


            Query_Scalar()

            If i = 0 Then

                Lbl_checkLogin.Text = "User or password invalid"
                Lbl_checkLogin.Visible = True
                Txt_username.Text = ""
                Txtp_pass.Text = ""

            ElseIf i = 1 Then

                Txt_username.Text = ""
                Txtp_pass.Text = ""
                Lbl_checkLogin.Visible = False
                Frmmain.Show()
                Me.Hide()

            Else
                Lbl_checkLogin.Text = "User or password duplicate"
                Lbl_checkLogin.Visible = True
                Txt_username.Text = ""
                Txtp_pass.Text = ""

            End If

        End If
    End Sub

    Private Sub Btn_cancel_Click(sender As Object, e As EventArgs) Handles Btn_cancel.Click
        Txt_username.Text = ""
        Txtp_pass.Text = ""
    End Sub
End Class

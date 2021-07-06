'Imports System.Globalization.CultureInfo.InvariantCulture


Public Class Frm_member


    Private Sub Btn_submit_Click(sender As Object, e As EventArgs) Handles Btn_submit.Click

        Dim type As String = Cbo_typeuser.Text.Trim
        Dim Fname As String = Txt_firstname.Text.Trim
        Dim Lastname As String = Txt_lastname.Text.Trim
        Dim Tel As String = Txt_tel.Text.Trim
        Dim position As String = Txt_position.Text.Trim
        Dim User As String = Txt_username.Text.Trim
        Dim Password As String = Txt_password.Text.Trim
        Dim Id As String = Txt_id.Text.Trim
        Dim Confirm_pass As String = Txt_confirm.Text.Trim
        Dim encrypt_Pass As String
        Dim Address As String = Txt_address.Text
        Dim Amper As String = Txt_amper.Text
        Dim Tombon As String = Txt_tambon.Text
        Dim Province As String = Txt_province.Text
        Dim Zip_code As String = Txt_zipcode.Text




        If Check_null(type, Fname, Lastname, Tel, position, User, Password, Confirm_pass) = False Then

            If Password = Confirm_pass Then

                If Correctpass(Confirm_pass) = "Password complete" Then

                    encrypt_Pass = EncryptPass2(Confirm_pass)

                    MessageBox.Show("Welcome To POS_Samart Mr." & Fname)


                    'Check Type Staff

                    If Cbo_typeuser.Text = "Staff" Then



                        'Query >> Check Duplicate User and password in database >> Update More DB 

                        sql = "select count(*) from Authen_staff where Username = '" & User & "' and Password =  '" & encrypt_Pass & "'"


                        Query_Scalar()

                        If i > 0 Then

                            MessageBox.Show("User and Password Duplicate ")

                        Else

                            sql = "insert into Authen_staff (Username,Password) values('" & User & "','" & encrypt_Pass & "')"
                            Insert_NewMember()


                            ' Show ID Staff on textbox

                            sql = "select Id_staff from Authen_staff where Username = '" & User & "'"

                            Query_Table()

                            Txt_id.Text = table.Rows(0)("Id_staff")
                            Id_staff = Txt_id.Text

                            'Insert other fill into other database 

                            sql = "Insert into Staffs values('" & Id_staff & "','" & Fname & "','" & Lastname & "','" & position & "')"
                            Insert_NewMember()

                            sql = "Insert into Staff_tel values('" & Id_staff & "','" & Tel & "')"
                            Insert_NewMember()

                            table.Clear()

                            refresh_data()

                            MessageBox.Show("Not Duplicate" & vbNewLine & "Update complete")



                        End If


                    ElseIf Cbo_typeuser.Text = "Customer" Then


                        'Query >> Check Duplicate User and password in database >> Update More DB 

                        sql = "select count(*) from Authen_Customer where Username = '" & User & "' and Password ='" & encrypt_Pass & "'"


                        Query_Scalar()

                        If i > 0 Then

                            MessageBox.Show("User and Password Duplicate ")

                        Else

                            sql = "insert into Authen_Customer (Username,Password) values('" & User & "','" & encrypt_Pass & "')"
                            Insert_NewMember()


                            ' Show ID Staff on textbox

                            sql = "select Id_customer from Authen_Customer where Username = '" & User & "'"

                            Query_Table()

                            Txt_id.Text = table.Rows(0)("Id_customer")
                            Id_customer = Txt_id.Text


                            'Insert other fill into other database 

                            sql = "Insert into Contact_person(Id_customers,Fname,Lname,Position)values('" & Id_customer & "','" & Fname & "','" & Lastname & "','" & position & "') "
                            Insert_NewMember()


                            table.Clear()

                            sql = "select Id_contact_person from Contact_person where Fname = '" & Fname & "' and Lname = '" & Lastname & "'"


                            Query_Table()


                            Txt_id.Text = table.Rows(0)("Id_contact_person")
                            Id_contactperson = Txt_id.Text


                            sql = "Insert into Customer_tell values('" & Id_contactperson & "','" & Tel & "') "
                            Insert_NewMember()

                            table.Clear()

                            sql = "Insert into Customers values('" & Id_customer & "','" & Address & "','" & Amper & "','" & Tombon & "','" & Province & "','" & Zip_code & "')"

                            Insert_NewMember()

                            table.Clear()

                            refresh_data()

                            MessageBox.Show("Not Duplicate" & vbNewLine & "Update complete")





                        End If



                    End If


                Else

                    MessageBox.Show("InCorrect Password")

                End If

            Else

                MessageBox.Show("Password and Confirm Password Invalid")

            End If
        Else

            MessageBox.Show("Space")


        End If

    End Sub

    Private Sub Cbo_typeuser_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cbo_typeuser.SelectedIndexChanged
        If Cbo_typeuser.Text = "Staff" Then

            Txt_address.Enabled = False
            Txt_address.BackColor = Color.DarkGray

            Txt_tambon.Enabled = False
            Txt_tambon.BackColor = Color.DarkGray

            Txt_amper.Enabled = False
            Txt_amper.BackColor = Color.DarkGray

            Txt_province.Enabled = False
            Txt_province.BackColor = Color.DarkGray

            Txt_zipcode.Enabled = False
            Txt_zipcode.BackColor = Color.DarkGray

        Else

            Txt_address.Enabled = True
            Txt_address.BackColor = Color.White

            Txt_tambon.Enabled = True
            Txt_tambon.BackColor = Color.White

            Txt_amper.Enabled = True
            Txt_amper.BackColor = Color.White

            Txt_province.Enabled = True
            Txt_province.BackColor = Color.White

            Txt_zipcode.Enabled = True
            Txt_zipcode.BackColor = Color.White


        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Frmmain.Show()

        Me.Hide()

    End Sub

    Private Sub Btn_search_Click(sender As Object, e As EventArgs) Handles Btn_search.Click

        Try

            If Cbo_typeuser.Text = "Customer" Then

                sql = "Select T1.Id_customer,T1.Username,T2.Fname,T2.Lname,T2.Position,T3.Customer_Tel,T4.Address,T4.Amper,T4.Tombon,T4.Province,T4.Zip_code,T1.Update_data From Authen_Customer as T1  
               Left Join Contact_person as T2 ON T1.Id_customer = T2.Id_customers  
               Left Join Customer_tell as T3 ON T2.Id_contact_person = T3.Id_contact_person  
               Left Join Customers as T4 ON T1.Id_customer = T4.Id_customer
               Where T2.Fname = '" & Txt_firstname.Text.Trim & "' OR T2.Lname = '" & Txt_lastname.Text.Trim & "' 
               OR T3.Customer_Tel = '" & Txt_tel.Text.Trim & "' "

                Query_Table()

                Txt_firstname.Text = table.Rows(0)("Fname")
                Txt_lastname.Text = table.Rows(0)("Lname")
                Txt_tel.Text = table.Rows(0)("Customer_Tel")

                If table.Rows(0)("Position").ToString = "" Then

                    Txt_position.Text = ""

                Else
                    Txt_position.Text = table.Rows(0)("Position")

                End If

                If table.Rows(0)("Address").ToString = "" Then

                    Txt_address.Text = ""

                Else
                    Txt_address.Text = table.Rows(0)("Address")

                End If

                If table.Rows(0)("Tombon").ToString = "" Then

                    Txt_tambon.Text = ""

                Else
                    Txt_tambon.Text = table.Rows(0)("Tombon")

                End If

                If table.Rows(0)("Amper").ToString = "" Then

                    Txt_amper.Text = ""

                Else
                    Txt_amper.Text = table.Rows(0)("Amper")

                End If


                If table.Rows(0)("Province").ToString = "" Then

                    Txt_province.Text = ""

                Else
                    Txt_province.Text = table.Rows(0)("Province")

                End If

                If table.Rows(0)("Zip_code").ToString = "" Then

                    Txt_zipcode.Text = ""

                Else
                    Txt_zipcode.Text = table.Rows(0)("Zip_code")

                End If


                Txt_id.Text = table.Rows(0)("Id_customer")



                If table.Rows(0)("Update_data").ToString = "" Then

                    Txt_Update.Text = ""

                Else
                    Txt_Update.Text = table.Rows(0)("Update_data")

                End If

                table.Clear()

            End If

        Catch ex As Exception


            MsgBox("Not Found", MessageBoxIcon.Warning, "Error")

            If DialogResult.OK = vbOK Then
                refresh_data()

            End If


        End Try




        Try

            If Cbo_typeuser.Text = "Staff" Then



                sql = "SELECT T1.Id_staff,T1.Update_data,T2.Tel,T3.Fname,T3.Lname,T3.Position FROM Authen_Staff AS T1
                   LEFT JOIN Staff_tel AS T2 ON T1.Id_staff = T2.Id_staff
                   LEFT JOIN Staffs AS T3 ON T1.Id_staff = T3.Id_staff 
                   WHERE T3.Fname = '" & Txt_firstname.Text.Trim & "'
                   OR T3.Lname =  '" & Txt_lastname.Text.Trim & "'
                   OR T2.Tel= '" & Txt_tel.Text.Trim & "' "

                Query_Table()



                Txt_firstname.Text = table.Rows(0)("Fname")
                Txt_lastname.Text = table.Rows(0)("Lname")
                Txt_tel.Text = table.Rows(0)("Tel")

                If table.Rows(0)("Position").ToString = "" Then

                    Txt_position.Text = ""

                Else
                    Txt_position.Text = table(0)("Position")

                End If

                Txt_id.Text = table.Rows(0)("Id_staff")



                If table.Rows(0)("Update_data").ToString = "" Then

                        Txt_Update.Text = ""

                    Else
                        Txt_Update.Text = table.Rows(0)("Update_data")

                    End If

                    table.Clear()

                End If

        Catch ex As Exception


            MsgBox("Not Found", MessageBoxIcon.Warning, "Error")

            If DialogResult.OK = vbOK Then
                refresh_data()

            End If


        End Try


    End Sub

    Private Sub Btn_Clear_Click(sender As Object, e As EventArgs) Handles Btn_Clear.Click
        refresh_data()
    End Sub

    Private Sub Btn_update_Click(sender As Object, e As EventArgs) Handles Btn_update.Click

        Dim Update_date As String = Format(DateTime.Now, "M/dd/yyyy hh:mm:ss")


        If Cbo_typeuser.Text = "Customer" Then

            If Txt_id.Text <> "" Then

                sql = "UPDATE Authen_Customer SET Update_data =  ' " & Update_date & "'
                WHERE Id_customer='" & Txt_id.Text.ToString & "'"
                Query_Clear()

                'Recheck

                sql = "UPDATE Contact_person SET Fname = '" & Txt_firstname.Text.ToString & "' 
                       ,Id_customers = '" & Txt_id.Text.ToString & "'
                       ,Lname = '" & Txt_lastname.Text.ToString & "' 
                       ,Position = '" & Txt_position.Text.ToString & "' 
                        WHERE Id_contact_person =
                                                 (SELECT Id_contact_person FROM Contact_person
                                                  WHERE Id_customers = '" & Txt_id.Text.ToString & "')"

                Query_Clear()


                sql = "UPDATE Customer_tell SET Customer_Tel = '" & Txt_tel.Text.ToString & "'
                       WHERE Id_contact_person =
                                             (SELECT Id_contact_person FROM Contact_person 
                                              WHERE Id_customers= '" & Txt_id.Text.ToString & "')"

                Query_Clear()



                sql = "UPDATE Customers SET Address = '" & Txt_address.Text.ToString & "' 
                       ,Amper = '" & Txt_amper.Text.ToString & "'
                       ,Tombon = '" & Txt_tambon.Text.ToString & "' 
                       ,Province = '" & Txt_province.Text.ToString & "'
                       ,Zip_code = '" & Txt_zipcode.Text.ToString & "'
                       WHERE Id_customer = '" & Txt_id.Text.ToString & "'"

                Update_date = Nothing

                Query_Clear()


                MessageBox.Show("Update Complete")
                refresh_data()


            Else
                MessageBox.Show("Update Failed")


            End If


        ElseIf Cbo_typeuser.Text = "Staff" Then

            If Txt_id.Text <> "" Then

                Update_date = Format(DateTime.Now, "M/dd/yyyy hh:mm:ss")


                sql = "Update Authen_Staff SET Update_data = '" & Update_date & "'
                   WHERE Id_staff = '" & Txt_id.Text.ToString & "'"

                Query_Clear()


                sql = "Update Staff_tel SET Tel = '" & Txt_tel.Text.ToString & "'
                   WHERE Id_staff = '" & Txt_id.Text.ToString & "'"

                Query_Clear()


                sql = "Update Staffs SET Fname = '" & Txt_firstname.Text.ToString & "'
                   ,Lname = '" & Txt_lastname.Text.ToString & "'
                   ,Position = '" & Txt_position.Text.ToString & "'
                   WHERE Id_staff = '" & Txt_id.Text.ToString & "'"
                Query_Clear()


                MessageBox.Show("Update Complete")
                refresh_data()


            Else

                MessageBox.Show("Update Failed")

            End If


        End If

    End Sub

    Private Sub Btn_del_member_Click(sender As Object, e As EventArgs) Handles Btn_del_member.Click

        MsgBox("Do you want to Delete data", MessageBoxIcon.Exclamation, "Confirm Delete")

        If DialogResult.OK = vbOK Then

            If Cbo_typeuser.Text = "Staff" And Txt_id.Text <> "" Then

                sql = "DELETE FROM Staff_tel WHERE Id_staff = '" & Txt_id.Text.ToString & "'"
                Query_Clear()

                sql = "DELETE FROM Staffs WHERE Id_staff = '" & Txt_id.Text.ToString & "' "
                Query_Clear()

                sql = "DELETE FROM Authen_Staff WHERE Id_staff = '" & Txt_id.Text.ToString & "'"
                Query_Clear()

                MessageBox.Show("Delete Completed")
                refresh_data()

            ElseIf Cbo_typeuser.Text = "Customer" And Txt_id.Text <> "" Then

                sql = "DELETE FROM Customers WHERE Id_customer = '" & Txt_id.Text.ToString & "'"
                Query_Clear()

                sql = "DELETE FROM Customer_tell  
                       WHERE Id_contact_person =
                                               (SELECT Id_contact_person FROM Contact_person 
                                               WHERE Id_customers = '" & Txt_id.Text.ToString & "')"



                Query_Clear()


                sql = "DELETE FROM Contact_person WHERE Id_customers = '" & Txt_id.Text.ToString & "' "
                Query_Clear()


                sql = "DELETE FROM Authen_Customer WHERE Id_customer = '" & Txt_id.Text.ToString & "'  "
                Query_Clear()


                MessageBox.Show("Delete Completed")
                refresh_data()


            End If




        End If



    End Sub




End Class
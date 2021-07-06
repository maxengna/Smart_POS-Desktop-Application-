Imports System.Text.RegularExpressions


Module Member

    Private Username As String
    Private Password As String
    Private Confrm_pass As String

    Private newpass As String
    Private ntime As Integer
    Private result As String, result1 As String
    Private num1 As Integer, num2 As Integer, num3 As Integer, num4 As Integer, num5 As Integer
    Private str1 As String
    Private result2 As Boolean, result3 As Boolean
    Private result4 As Boolean

    Public Event show_event As EventHandler


    'Check length of password

    Function Countpassword(str As String) As Boolean

        num1 = str.Length
        If num1 >= 8 Then

            result = True
        Else
            result = False

        End If

        Return result


    End Function


    'Function check Lower and Upper  charecters

    Function Checkletter(val As String) As Boolean

        Dim array() As Char = val.ToCharArray
        Dim i As Integer
        Dim numupper As Integer = 0
        Dim numlower As Integer = 0



        For i = 0 To val.Length - 1

            'Check Upper case
            If Char.IsUpper(array(i)) Then

                numupper += 1

                'Check Lower case
            ElseIf Char.IsLower(array(i)) Then

                numlower += 1

            End If



            If numupper >= 1 And numlower >= 1 Then

                result4 = True

            Else

                result4 = False

            End If

        Next



        Return result4

    End Function

    'Check exist Number in password 
    Function Checknumeric(val As String) As Boolean


        Dim result5 As Boolean
        Const numbers = "0123456789"




        If val.IndexOfAny(numbers.ToArray) > -1 Then

            result5 = True

        Else

            result5 = False

        End If


        Return result5


    End Function


    'Function Check Special Charecter

    Function Recheckspecialcharecter(ByVal str As String) As Boolean


        Dim arr() As Char = str.ToCharArray
        Dim i As Integer
        Dim j As Long
        Dim specialchar As Boolean
        Const specialcha1 = "@$/\,<>!_=%^&*#()?""'.-"

        For i = 0 To str.Length - 1

            If str.IndexOfAny(specialcha1.ToArray) > -1 Then

                specialchar = True
            Else

                specialchar = False

            End If



        Next i

        Return specialchar





    End Function

    'Function Check Condition of password
    Function Correctpass(ByVal value2 As String) As String

        Dim result As String



        If Countpassword(value2) = True Then


            If Checkletter(value2) = True Then

                If Checknumeric(value2) = True Then


                    If Recheckspecialcharecter(value2) = True Then


                        result = "Password complete"


                    Else

                        result = "Password must have special charecter at least 1."

                    End If


                Else


                    result = "Password not found numeric"


                End If



            Else

                result = "Password must contain at least 1 lowercase and uppercase letter each."



            End If


        Else
            result = "Password must have greater than 8 digits. "


        End If

        Return result



    End Function


    'Function Check null 
    Public Function Check_null(ParamArray ByVal val() As String) As Boolean

        Dim cel_val As String
        Dim result As Boolean

        For Each cel_val In val

            If cel_val = "" Then

                result = True
                Exit For
            Else
                result = False


            End If

        Next

        Return result

    End Function



    Public Function EncryptPass(ByVal val As String) As String

        Dim Encrypt_Pass As String = ""
        Dim i As Integer
        Dim Conver_chr As Char


        For Each str As Char In val

            i = Asc(str)
            i += 1

            Conver_chr = ChrW(i)




            Encrypt_Pass += Encrypt_Pass & Conver_chr

            Encrypt_Pass = Encrypt_Pass.Trim


        Next

        Return Encrypt_Pass

    End Function


    Public Function EncryptPass2(ByVal val As String) As String

        Dim Encrypt_Pass As String = ""
        Dim i As Integer
        Dim Chr As Char
        Dim NumChr As Integer
        Dim Final_num_chr As Integer
        Dim FinalChr As String
        Dim Str2 As String



        'Check Number or Charecter




        For Each Demo_chr As Char In val

            'check numeric

            If Regex.IsMatch(Demo_chr, "\d+") = True Then

                Str2 = CStr(Demo_chr)
                NumChr = CInt(Str2) + 1
                FinalChr = CChar(CStr(NumChr))




            Else

                'Check Charecter and special charecter

                Chr = Demo_chr.ToString.ToUpper
                NumChr = Asc(Chr)

                If NumChr = 90 Then

                    Final_num_chr = 65
                    FinalChr = ChrW(Final_num_chr)

                ElseIf NumChr >= 65 And NumChr <= 90 Then

                    NumChr += 1
                    FinalChr = ChrW(NumChr)

                ElseIf NumChr >= 0 And NumChr <= 64 Then

                    NumChr += 1
                    FinalChr = ChrW(NumChr)


                ElseIf NumChr > 90 And NumChr <= 255 Then

                    NumChr += 1
                    FinalChr = ChrW(NumChr)


                End If


            End If

            ' Concat char >>> string

            Encrypt_Pass += FinalChr

            Encrypt_Pass = Encrypt_Pass.Trim


        Next

        Return Encrypt_Pass


    End Function



    Public Function DecryptPass(ByVal val As String) As String

        Dim Encrypt_Pass As String = ""
        Dim i As Integer
        Dim Chr As Char
        Dim NumChr As Integer
        Dim Final_num_chr As Integer
        Dim FinalChr As String
        Dim Str2 As String



        'Check Number or Charecter




        For Each Demo_chr As Char In val

            'check numeric

            If Regex.IsMatch(Demo_chr, "\d+") = True Then

                Str2 = CStr(Demo_chr)
                NumChr = CInt(Str2) - 1
                FinalChr = CChar(CStr(NumChr))



            Else

                'Check Charecter and special charecter

                Chr = Demo_chr.ToString.ToUpper
                NumChr = Asc(Chr)

                If NumChr = 65 Then

                    Final_num_chr = 90
                    FinalChr = ChrW(Final_num_chr)

                ElseIf NumChr >= 65 And NumChr <= 90 Then

                    NumChr -= 1
                    FinalChr = ChrW(NumChr)

                ElseIf NumChr >= 0 And NumChr <= 64 Then

                    NumChr -= 1
                    FinalChr = ChrW(NumChr)


                ElseIf NumChr > 90 And NumChr <= 255 Then

                    NumChr -= 1
                    FinalChr = ChrW(NumChr)


                End If


            End If

            ' Concat char >>> string

            Encrypt_Pass += FinalChr

            Encrypt_Pass = Encrypt_Pass.Trim


        Next

        Return Encrypt_Pass

    End Function


    Public Sub refresh_data()

        With Frm_member

            .Cbo_typeuser.Text = ""
            .Txt_firstname.Text = ""
            .Txt_lastname.Text = ""
            .Txt_tel.Text = ""
            .Txt_position.Text = ""
            .Txt_address.Text = ""
            .Txt_tambon.Text = ""
            .Txt_amper.Text = ""
            .Txt_province.Text = ""
            .Txt_zipcode.Text = ""
            .Txt_username.Text = ""
            .Txt_password.Text = ""
            .Txt_confirm.Text = ""

            .Txt_id.Text = ""
            .Txt_Update.Text = ""




        End With


    End Sub



    Public Sub Clear_data(ParamArray ByVal vals() As String)

        For Each val As String In vals

            If val <> "" Then

                val = ""

            End If

        Next



    End Sub



End Module

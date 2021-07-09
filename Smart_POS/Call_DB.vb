Imports System.Data.SqlClient
Imports System.Data
Imports System.Drawing.Imaging
Imports System.IO
Imports System.Text


Module Call_DB

    Public constring As String = "Your Connection String"
    Public sql As String = ""
    Public con As New SqlConnection
    Public table As New DataTable
    Public i As Integer
    Public cmd As SqlCommand
    Public da As SqlDataAdapter
    Public Id_staff, Id_customer As String
    Public Id_contactperson As String
    Public ExtFile As String = ""
    Public filename As String = ""
    Public File_nameExtn As String = ""
    Public fullpath As String = ""
    Public builder As StringBuilder
    Public Existock As Integer
    Public indexnum As Integer
    Public netprice As Double
    Public UpdateTotalprice As Double = 0
    Public Userstaff As String
    Public product As FrmProduct
    Public result As Double
    Private symbol As Char
    Public resultstr As String




    Public Sub Connect_DB()

        Try

            con = New SqlConnection(constring)

            If con.State Then

                con.Close()
                con.Dispose()
                con.Open()
            Else

                con.Open()

            End If





        Catch ex As Exception

            MessageBox.Show("Connection Failed")

        End Try

    End Sub


    Public Sub Query_Scalar()

        Connect_DB()

        cmd = New SqlCommand(sql, con)


        i = CInt(cmd.ExecuteScalar())



        con.Close()


    End Sub

    Public Sub Insert_NewMember()

        Connect_DB()

        cmd = New SqlCommand(sql, con)

        cmd.ExecuteNonQuery()
        con.Close()

    End Sub

    Public Sub Insert_NewStock()

        Connect_DB()

        cmd = New SqlCommand(sql, con)

        cmd.ExecuteNonQuery()
        con.Close()

    End Sub


    Public Sub Excute_result()

        Connect_DB()

        cmd = New SqlCommand(sql, con)

        cmd.ExecuteNonQuery()
        con.Close()

    End Sub

    Public Sub Query_Table()

        table.Reset()

        Connect_DB()

        cmd = New SqlCommand(sql, con)
        da = New SqlDataAdapter(cmd)


        cmd.ExecuteNonQuery()
        da.Fill(table)

        con.Close()
        con.Dispose()



    End Sub


    Public Sub Query_Clear()

        Query_Table()
        table.Reset()


    End Sub


    Public Sub BrowseFiles(ByVal path As String, ByVal typefile As String)

        Dim ofd As New OpenFileDialog

        ofd.InitialDirectory = path

        ofd.Filter = typefile

        If ofd.ShowDialog = DialogResult.OK Then

            File_nameExtn = ofd.SafeFileName
            filename = Strings.Left(File_nameExtn, InStr(File_nameExtn, ".") - 1)
            fullpath = path & File_nameExtn



            Dim fi As New FileInfo(fullpath)

            ExtFile = fi.Extension


        End If

    End Sub


    Public Function ImageToStream(ByRef filename As String) As Byte()

        Dim stream As New MemoryStream()
        Dim Fi As New FileInfo(filename)

        If File.Exists(filename) = True Then

            Try

                Dim image As New Bitmap(filename)

                Dim extension As String = Fi.Extension


                Select Case extension

                    Case ".jpg"
                        image.Save(stream, ImageFormat.Jpeg)

                    Case ".bmp"
                        image.Save(stream, ImageFormat.Bmp)

                    Case ".png"
                        image.Save(stream, ImageFormat.Png)

                End Select





            Catch ex As Exception


                MessageBox.Show("File type not valid" & vbCrLf _
                                    & "Please choose file type(.jpg ,.bmp ,.png)")


                'Default picture
                Dim name As String = "C:\Users\maxxx\source\repos\Smart_POS\Icons\Button-Close-icon.png"

                Fi = New FileInfo(name)

                Dim image As New Bitmap(name)
                Dim extension As String = Fi.Extension


                Select Case extension

                    Case ".jpg"
                        image.Save(stream, ImageFormat.Jpeg)

                    Case ".bmp"
                        image.Save(stream, ImageFormat.Bmp)

                    Case ".png"
                        image.Save(stream, ImageFormat.Png)

                End Select



            End Try

        Else
            MessageBox.Show("File not exist")

        End If


        Return stream.ToArray()

    End Function


    Public Sub LoadImage(Gridview As DataGridView)



        Using conn As New SqlConnection(constring)

            Using comm As New SqlCommand(sql, conn)

                Using da As New SqlDataAdapter(comm)


                    Dim dtb As New DataTable()

                    dtb.Reset()
                    Gridview.Columns.Clear()

                    conn.Open()
                    comm.ExecuteNonQuery()
                    da.Fill(dtb)

                    conn.Close()

                    With Gridview

                        .AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill
                        .RowTemplate.Height = 200

                        .DataSource = dtb
                        .Show()

                        Dim imgc As New DataGridViewImageColumn()

                        imgc.ImageLayout = DataGridViewImageCellLayout.Stretch


                    End With

                End Using

            End Using



        End Using


    End Sub

    Public Sub CheckNull_textbox(ByRef Cont As Control, ByRef str As String)

        For Each c As Control In Cont.Controls

            If (TypeOf c Is TextBox) Then

                Dim my_control As Control

                my_control = CType(c, TextBox)

                If my_control.Text = "" Then

                    my_control.Text = str

                End If

            Else
                Continue For

            End If


        Next




    End Sub
    'ฟังก์ชั่น หา ช่องว่างใน Control ที่ลูกค้ากรอกไม่ครบ

    Public Function Loop_textval(contrl As Control, ByVal Controlname1 As String, ByVal Controlname2 As String) As Boolean

        Dim result As Boolean

        For Each c As Control In contrl.Controls

            If TypeOf c Is TextBox Then

                If c.Name = Controlname1 Then

                    If c.Text = "" Then

                        MessageBox.Show("คุณยังไม่ได้กรอกช่อง:" & Controlname2)
                        result = False

                    ElseIf c.Text <> "" Then
                        result = True
                        Exit Function

                    End If

                End If

            End If


        Next

        Return result

    End Function

    Public Function Loop_arraytext(ParamArray controls() As Control) As Boolean

        Dim result As Boolean
        Dim i As Integer
        Dim names As New ArrayList

        i = controls.Count

        For Each c As Control In controls

            If TypeOf c Is TextBox Then

                If c.Text.Trim = "" Then

                    c.BackColor = Color.Red

                    Dim Str As String = c.Name
                    Dim Cutstr As String = Right(Str, (Len(Str) - InStr(Str, "_")))

                    names.Add(Cutstr)

                ElseIf c.Text <> "" And c.TabIndex = controls.Count Then
                    result = True
                    Exit Function

                End If

            End If
        Next

        If names.Count > 0 Then


            builder = New StringBuilder("You don't filled data in :").AppendLine

            For Each name As String In names


                builder.Append(name).AppendLine()

            Next



            result = False

        Else

            result = True

        End If

        Return result

    End Function

    'Convert Byte to image 
    Public Function ReadByte_Toimage(ByVal Mybyte As Byte()) As Image

        Dim stream As New MemoryStream(Mybyte)
        Dim ReturnImage As Image = Image.FromStream(stream)

        Return ReturnImage

    End Function


    'Load Product in listview

    Public Sub LoadProduct()

        With FrmProduct.Lstview_pic

            Dim Listviewitem As ListViewItem
            Dim Listviewimagelist As New ImageList
            Dim ByteImg As Byte()


            .View = View.LargeIcon
            .Columns.Add("Picture")
            .Columns.Add("Product")
            .Columns(0).Width = 500
            .Columns(1).Width = 150

            'Query data from database


            sql = "SELECT * FROM Products"


            Query_Table()

            Dim ProductNames As String
            Dim price As String
            Dim product_price As String


            If table.Rows.Count > 0 Then

                Dim row As Integer = table.Rows.Count - 1

                For i As Integer = 0 To row

                    With table

                        ProductNames = Trim(.Rows(i)("Name").ToString)
                        price = Trim(.Rows(i)("Unit_price").ToString)
                        product_price = ProductNames & "|" & price


                        '***
                        Try

                            ByteImg = .Rows(i)("Images")

                        Catch ex As Exception

                            Continue For

                        End Try

                    End With



                    Listviewitem = New ListViewItem(product_price)
                    Listviewitem.IndentCount = 5

                    Listviewimagelist.ImageSize = New Size(50, 50)
                    .LargeImageList = Listviewimagelist


                    Dim stream As New MemoryStream(ByteImg)

                    Listviewitem.ImageIndex = Listviewimagelist.Images.Add(Image.FromStream(stream), Color.Transparent)

                    .Items.Add(Listviewitem)






                Next

            End If





        End With




    End Sub
    'หาคำที่ต้องการจาก Listview แล้วคืนค่าเป็นเลขแถว

    Public Function Find_index(ByVal str As String, lsv As ListView) As Integer





        For Each itm As ListViewItem In lsv.Items

            For Each subitm As ListViewItem.ListViewSubItem In itm.SubItems




                If subitm.Text = str Then

                    indexnum = lsv.Items.IndexOf(itm)
                    Exit Function

                ElseIf subitm.Text <> str Then

                    indexnum = -1


                End If




            Next




        Next


        Return indexnum


    End Function

    'หาผลรวมในแนวคอลัมน์ที่ต้องการใน listview

    Public Function Sumproduct(lsv As ListView, ByRef ecol As Integer, ByRef erow As Integer) As Double

        Dim result As Double = 0
        Dim lastrow As Integer



        lastrow = lsv.Items.Count - 1




        For num As Integer = erow To lastrow


            Dim demo As Integer = CInt(lsv.Items(num).SubItems(ecol).Text)

            result += lsv.Items(num).SubItems(ecol).Text



            Continue For




        Next

        Return result

    End Function


    Public Sub Refresh_data2(ByVal maincontrol As Control)



        For Each ctrl As Control In maincontrol.Controls

            If TypeOf ctrl Is TextBox Or TypeOf ctrl Is ComboBox Then


                If Not ctrl Is Nothing Then

                    ctrl.Text = ""

                End If


            End If

        Next






    End Sub


    Public Function FormatCurrency(ByVal val As Double)

        Dim result As String

        result = Format(val, "#,###.00")

        Return result

    End Function


    Public Function calMultivalue(ByVal str As String)

        Dim index As Integer
        Dim var1, var2 As Double
        Dim cal As New Calculate




        Try

            For Each chr As Char In str.ToCharArray()



                If InStr(str, ChrW(42).ToString) > 1 Then

                    index = InStr(str, ChrW(42).ToString)
                    var1 = CDbl(Strings.Left(str, index - 1))

                    If Strings.Mid(str, index + 1, 1) = String.Empty Then

                        Exit Function

                    Else
                        var2 = CDbl(Strings.Mid(str, index + 1, str.Length - 1))
                        result = cal.Multiply(var1, var2)


                    End If



                    'Plus

                ElseIf InStr(str, ChrW(43).ToString) > 1 Then

                    index = InStr(str, ChrW(43).ToString)
                    var1 = CDbl(Strings.Left(str, index - 1))

                    If Strings.Mid(str, index + 1, 1) = String.Empty Then

                        Exit Function


                    Else
                        var2 = CDbl(Strings.Mid(str, index + 1, str.Length - 1))
                        result = cal.Add(var1, var2)

                    End If


                ElseIf InStr(str, ChrW(45).ToString) > 1 Then

                    index = InStr(str, ChrW(45).ToString)
                    var1 = CDbl(Strings.Left(str, index - 1))

                    If Strings.Mid(str, index + 1, 1) = String.Empty Then

                        Exit Function

                    Else

                        var2 = CDbl(Strings.Mid(str, index + 1, str.Length - 1))
                        result = cal.Minus(var1, var2)

                    End If

                ElseIf InStr(str, ChrW(47).ToString) > 1 Then

                    index = InStr(str, ChrW(47).ToString)
                    var1 = CDbl(Strings.Left(str, index - 1))



                    If Strings.Mid(str, index + 1, 1) = String.Empty Then

                        Exit Function

                    Else

                        var2 = CDbl(Strings.Mid(str, index + 1, str.Length - 1))
                        result = cal.Divide(var1, var2)


                    End If

                    '% Percent

                ElseIf InStr(str, ChrW(37).ToString) > 1 Then

                    index = InStr(str, ChrW(37).ToString)
                    var1 = CDbl(Strings.Left(str, index - 1))



                    If Strings.Mid(str, index + 1, 1) = String.Empty Then

                        Exit Function

                    Else

                        var2 = CDbl(Strings.Mid(str, index + 1, str.Length - 1))
                        result = cal.Percentage(var1, var2)
                        Exit Function


                    End If

                    'คำนวณเลขติดลบ ถ้ามีเครื่องหมายบวกนำหน้า

                ElseIf InStr(str, ChrW(43).ToString) = 1 Then

                        str = Strings.Left(str, 1)
                        index = InStr(str, chr.ToString)
                        var1 = CDbl(Strings.Left(str, index - 1))
                        var2 = CDbl(Strings.Mid(str, index + 1, str.Length - 1))


                        If symbol = ChrW(42) Then

                            result = cal.Multiply(var1, var2)

                        ElseIf symbol = ChrW(43) Then

                            result = cal.Add(var1, var2)

                        ElseIf symbol = ChrW(42) Then

                            result = cal.Minus(var1, var2)

                        ElseIf symbol = ChrW(42) Then

                            result = cal.Divide(var1, var2)

                        End If


                    'คำนวณเลขติดลบ ถ้ามีเครื่องหมายลบนำหน้า

                ElseIf InStr(str, ChrW(45).ToString) = 1 Then




                    index = InStr(2, str, chr.ToString)
                    symbol = Strings.Mid(str, index, index)
                    var1 = CDbl(Strings.Mid(str, 1, index - 1)) * -1
                    var1 *= -1
                    var2 = CDbl(Strings.Mid(str, index + 1, str.Length - 1))

                    If symbol = ChrW(42) Then

                        result = cal.Multiply(var1, var2)

                    ElseIf symbol = ChrW(43) Then

                        result = cal.Add(var1, var2)

                    ElseIf symbol = ChrW(45) Then

                        result = cal.Minus(var1, var2)

                    ElseIf symbol = ChrW(47) Then

                        result = cal.Divide(var1, var2)

                    End If

                    Exit For


                End If

            Next

        Catch es As Exception

            MessageBox.Show("ระบบไม่สามารทำการคำนวณได้", "พบข้อผิดพลาด", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)



        End Try



        Return result And resultstr



    End Function


    Public Sub CleardataOnGrideview(ByVal gridview As DataGridView)

        If gridview.RowCount > 0 Then



            For i As Integer = 0 To gridview.RowCount - 1

                For Each row As DataGridViewRow In gridview.Rows

                    gridview.Rows.Remove(row)



                Next

            Next











        End If


    End Sub

    Function Query_andnewtable(ByVal sql As String)

        Dim newtable As New DataTable

        Connect_DB()

        cmd = New SqlCommand(sql, con)
        da = New SqlDataAdapter(cmd)


        cmd.ExecuteNonQuery()
        da.Fill(newtable)

        con.Close()
        con.Dispose()

        Return newtable

    End Function








End Module

Imports System.IO
Imports System.Drawing
Imports System.Text
Imports System.Data.SqlClient
Imports System.Data





Public Class Frm_Stock



    Public mytext As New TextBox
    Public Final_stock As Integer



    Private Sub Frm_Stock_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        sql = "SELECT * FROM Products"


        Txt_IdPurchase.Enabled = False
        Txt_IdProduct.Enabled = False
        Txt_Id_Supplier.Enabled = False

        LoadImage(DataGridView1)

        table.Clear()




    End Sub

    Private Sub Frm_Stock_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Frmmain.StockTlstrip.Enabled = True
    End Sub

    Private Sub Btn_browseimg_Click(sender As Object, e As EventArgs) Handles Btn_browseimg.Click

        Dim Path As String
        Dim filter As String
        Dim extension As String
        Dim file_name As String
        Dim file_ext As String
        Dim Fullname_path As String

        Path = "C:\Users\maxxx\source\repos\Smart_POS\Picture\"
        filter = "Image Files(*.jpg,*.bmp,*.png)|*.jpg;*.bmp;*.png|All files(*.)|*.*"

        BrowseFiles(Path, filter)

        extension = ExtFile
        file_name = filename
        file_ext = File_nameExtn
        Fullname_path = fullpath

        Txt_Pic.Visible = True
        Txt_Pic.Text = Fullname_path




    End Sub

    Private Sub Btn_Add_Click(sender As Object, e As EventArgs) Handles Btn_Add.Click

        Dim Product_date As String = Format(DateTime.Now, "M/dd/yyyy hh:mm:ss")
        Dim TotalStock As Integer = 0



        If Check_null(Dtpick_purchasdatee.Text, Txt_Pic.Text, Txt_Quantity.Text, Txt_Price.Text,
                       Txt_TotalPrice.Text, Txt_Unitcost.Text, Txt_Unitprice.Text, Txt_Safety_stock.Text, Txt_SupplierName.Text) = False Then


            Dim content As Byte() = ImageToStream(Txt_Pic.Text)

            'Table Products
            'check product exist in database

            table.Clear()
            sql = "SELECT Name FROM Products WHERE Name = '" & Txt_Productname.Text.Trim & "'"
            Query_Table()
            sql = ""

            If table.Rows.Count = 0 Then


                sql = "INSERT INTO Products(Name,Unit_price,Unit_cost,Stock_in,Safety_stock,Supplier_name,Images)
                     VALUES(@Productname,@Unit_price,@Unit_cost,@Stock_in,@Safety_stock,@Supplier_name,@Images)"

                Connect_DB()

                Using Command As New SqlCommand(sql, con)

                    Command.Parameters.AddWithValue("@Productname", Txt_Productname.Text.Trim)
                    Command.Parameters.AddWithValue("@Unit_price", Txt_Unitprice.Text.Trim)
                    Command.Parameters.AddWithValue("@Unit_cost", Txt_Unitcost.Text.Trim)
                    Command.Parameters.AddWithValue("@Stock_in", Txt_Quantity.Text.Trim)
                    Command.Parameters.AddWithValue("@Safety_stock", Txt_Safety_stock.Text.Trim)
                    Command.Parameters.AddWithValue("@Supplier_name", Txt_SupplierName.Text.Trim)
                    Command.Parameters.AddWithValue("@Images", content)


                    Command.ExecuteNonQuery()
                    con.Close()

                    sql = ""

                End Using

            ElseIf table.Rows.Count > 0 Then

                sql = "UPDATE Products SET Unit_price = @unitprice,Unit_cost = @unitcost ,Stock_in = @stockin, Safety_stock = @safetystock ,Supplier_name = @Suppliername,Images = @Images
                       WHERE Name = '" & Txt_Productname.Text.Trim & "'"

                Connect_DB()

                Using Command As New SqlCommand(sql, con)

                    Dim Pic As Byte() = ImageToStream(Txt_Pic.Text.Trim)

                    Command.Parameters.AddWithValue("@unitprice", Txt_Unitprice.Text.Trim)
                    Command.Parameters.AddWithValue("@unitcost", Txt_Unitcost.Text.Trim)
                    Command.Parameters.AddWithValue("@stockin", Txt_Quantity.Text.Trim)
                    Command.Parameters.AddWithValue("@safetystock", Txt_Safety_stock.Text.Trim)
                    Command.Parameters.AddWithValue("@Suppliername", Txt_SupplierName.Text.Trim)
                    Command.Parameters.AddWithValue("@images", Pic)

                    Command.ExecuteNonQuery()
                    con.Close()

                    sql = ""

                End Using


            End If



            table.Clear()

            sql = "SELECT Id_product FROM Products WHERE Name = '" & Txt_Productname.Text.Trim & "'"


            Query_Table()

            Txt_IdProduct.Text = table(0)("Id_product")

            sql = ""
            table.Clear()



            sql = "SELECT SUM(Total_stock) FROM Products WHERE Id_product = '" & Txt_IdProduct.Text.Trim & "' "

            Query_Scalar()

            TotalStock = i


            Dim ChangeStock As Integer = CInt(Txt_Quantity.Text.Trim)

            If TotalStock = 0 And ChangeStock >= TotalStock Then

                'Update
                sql = "UPDATE Products SET Total_stock ='" & ChangeStock & "' WHERE Id_Product =  '" & Txt_IdProduct.Text.Trim & "'"

                Insert_NewStock()

                sql = ""

                Final_stock = Txt_Quantity.Text.Trim



            ElseIf TotalStock > 0 Then

                Dim UpdateTotal As Integer
                UpdateTotal = CInt(TotalStock) + CInt(ChangeStock)



                'Update
                sql = "UPDATE Products SET Total_stock ='" & UpdateTotal & "' WHERE Id_product = '" & Txt_IdProduct.Text.Trim & "'"

                    Insert_NewStock()

                    sql = ""

                    Final_stock = UpdateTotal

                ElseIf ChangeStock < TotalStock Then

                    MessageBox.Show("คุณทำรายการไม่ถูกต้อง หากคุณต้องการลดสต็อกกรุณากดปุ่ม DELETE", "พบข้อผิดพลาด", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                Exit Sub




            End If

            'Table Purchase detail

            sql = "INSERT INTO Purchase_detail (Id_product,Quantity,Price,Unit_price,Total_stock)"
            sql &= "VALUES('" & Txt_IdProduct.Text.Trim & "'"
            sql &= ",'" & Txt_Quantity.Text.Trim & "'"
            sql &= ",'" & Txt_Price.Text.Trim & "'"
            sql &= ",'" & Txt_Unitprice.Text.Trim & "'"
            sql &= ",'" & Final_stock & "')"

            Insert_NewStock()
            sql = ""

            table.Clear()

            sql = "SELECT Id_purchase FROM Purchase_detail WHERE Id_product = '" & Txt_IdProduct.Text.Trim & "'  
                   ORDER BY Id_purchase desc"

            Query_Table()
            sql = ""
            Txt_IdPurchase.Text = table.Rows(0)("Id_purchase")
            table.Clear()



            'Table Supplier

            'Recheck product in table supplier

            sql = "SELECT * FROM Supplier WHERE Name = '" & Txt_SupplierName.Text.Trim & "'"
            Query_Table()

            If table.Rows.Count > 0 Then


                sql = "UPDATE Supplier SET Address= '" & TxtAddress_Sup.Text.Trim & "'
                       WHERE Name = '" & Txt_SupplierName.Text.Trim & "'"

                Insert_NewStock()

                table.Clear()

                sql = "SELECT * FROM Supplier WHERE Name = '" & Txt_SupplierName.Text.Trim & "'"
                Query_Table()
                Txt_Id_Supplier.Text = table.Rows(0)("Id_supplier")

                table.Clear()


            ElseIf table.Rows.Count = 0 Then

                sql = "INSERT INTO Supplier(Name,Address)"
                sql &= "VALUES('" & Txt_SupplierName.Text.Trim & "'"
                sql &= ",'" & TxtAddress_Sup.Text.Trim & "')"


                Insert_NewStock()
                sql = ""

                table.Clear()

                sql = "SELECT * FROM Supplier WHERE Name = '" & Txt_SupplierName.Text.Trim & "'"
                Query_Table()
                Txt_Id_Supplier.Text = table.Rows(0)("Id_supplier")

                table.Clear()

            End If



            'Table Purchase


            Dim Insert_date As String = Format(Dtpick_purchasdatee.Value, "M/dd/yyyy hh:mm:ss")




            sql = "INSERT INTO Purchase(Id_purchase,Id_staff,Id_supplier,Purchase_date,Total)"
            sql &= "VALUES('" & Txt_IdPurchase.Text.Trim & "'"
            sql &= ",'" & Lbl_Staffname.Text.Trim & "'"
            sql &= ",'" & Txt_Id_Supplier.Text.Trim & "'"
            sql &= ",'" & Insert_date & "'"
            sql &= ",'" & Txt_TotalPrice.Text.Trim & "')"

            Insert_NewStock()
            sql = ""

            'Join table > show gridview +เพิ่ม function ดึงภาพจาก database มาแสดงใน datagridview



            sql = "SELECT * FROM Products"



            LoadImage(DataGridView1)

            MessageBox.Show("Add Stock Complete")

            Txt_IdPurchase.Text = ""
            Dtpick_purchasdatee.Text = ""
            Txt_IdProduct.Text = ""
            Txt_Productname.Text = ""
            Txt_Pic.Text = ""
            Txt_Quantity.Text = ""
            Txt_Price.Text = ""
            Txt_TotalPrice.Text = ""
            Txt_Unitcost.Text = ""
            Txt_Unitprice.Text = ""
            Txt_Safety_stock.Text = ""
            Txt_Id_Supplier.Text = ""
            Txt_SupplierName.Text = ""
            TxtAddress_Sup.Text = ""

        Else
            MsgBox("You filed data not complete", MessageBoxIcon.Error, "Notification")


        End If


    End Sub


    Private Sub Btn_Clear_Click(sender As Object, e As EventArgs) Handles Btn_Clear.Click

        Txt_IdPurchase.Text = ""
        Dtpick_purchasdatee.Text = ""
        Txt_IdProduct.Text = ""
        Txt_Productname.Text = ""
        Txt_Pic.Text = ""
        Txt_Quantity.Text = ""
        Txt_Price.Text = ""
        Txt_TotalPrice.Text = ""
        Txt_Unitcost.Text = ""
        Txt_Unitprice.Text = ""
        Txt_Safety_stock.Text = ""
        Txt_Id_Supplier.Text = ""
        Txt_SupplierName.Text = ""
        TxtAddress_Sup.Text = ""
    End Sub


    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim row As Integer




        If e.RowIndex >= 0 And DataGridView1.Columns(0).Name = "Id_product" Then

            row = DataGridView1.CurrentRow.Index

            With DataGridView1

                Try

                    Txt_IdProduct.Text = .Rows(row).Cells("Id_product").Value
                    Txt_Productname.Text = .Rows(row).Cells("Name").Value
                    Txt_Quantity.Text = .Rows(row).Cells("Total_stock").Value
                    Txt_Unitcost.Text = .Rows(row).Cells("Unit_cost").Value
                    Txt_Unitprice.Text = .Rows(row).Cells("Unit_price").Value
                    Txt_Safety_stock.Text = .Rows(row).Cells("Safety_stock").Value
                    Txt_SupplierName.Text = .Rows(row).Cells("Supplier_name").Value

                Catch ex As Exception

                    Txt_Id_Supplier.Text = ""
                    Txt_SupplierName.Text = ""
                    TxtAddress_Sup.Text = ""

                End Try

            End With


            If Txt_SupplierName.Text <> "" Then

                sql = "SELECT * FROM Supplier WHERE Name = '" & Txt_SupplierName.Text.Trim & "'"
                Query_Table()

                TxtAddress_Sup.Text = table.Rows(0)("Address")

                table.Clear()

            Else

                Txt_Id_Supplier.Text = ""
                Txt_SupplierName.Text = ""
                TxtAddress_Sup.Text = ""

            End If


            'เพิ่ม
            sql = "SELECT T2.Id_purchase,T2.Quantity,T2.Price,T3.Purchase_date,T3.Total FROM Products AS T1
                   LEFT JOIN Purchase_detail AS T2 ON T1.Id_product = T2.Id_product
                   LEFT JOIN Purchase AS T3 ON T2.Id_purchase = T3.Id_purchase
                   WHERE T2.Id_product = '" & Txt_IdProduct.Text.Trim & "'
                   ORDER BY T2.Id_purchase DESC"


            Query_Table()

            Try




                With Dtpick_purchasdatee

                    .Text = table.Rows(0)("Purchase_date")
                    .Show()
                    .Refresh()

                End With

                Txt_Price.Text = Math.Round(table.Rows(0)("Price"))
                Txt_TotalPrice.Text = table.Rows(0)("Total")

                table.Clear()
            Catch ex As Exception

                Txt_IdPurchase.Text = ""
                Txt_Price.Text = ""

                table.Clear()
            End Try



        ElseIf e.RowIndex >= 0 And DataGridView1.Columns(0).Name = "Id_purchase" Then

            row = DataGridView1.CurrentRow.Index


            With DataGridView1

                Try

                    Txt_IdPurchase.Text = .Rows(row).Cells("Id_purchase").Value
                    Dtpick_purchasdatee.Text = .Rows(row).Cells("Purchase_date").Value
                    Txt_IdProduct.Text = .Rows(row).Cells("Id_product").Value
                    Txt_Productname.Text = .Rows(row).Cells("Name").Value
                    Txt_Price.Text = .Rows(row).Cells("Price").Value
                    Txt_TotalPrice.Text = .Rows(row).Cells("Total").Value
                    Txt_Unitcost.Text = .Rows(row).Cells("Unit_cost").Value
                    Txt_Unitprice.Text = .Rows(row).Cells("Unit_price").Value
                    Txt_Safety_stock.Text = .Rows(row).Cells("Safety_stock").Value
                    Txt_Id_Supplier.Text = .Rows(row).Cells("Id_supplier").Value
                    Txt_SupplierName.Text = .Rows(row).Cells("Sup_name").Value
                    TxtAddress_Sup.Text = .Rows(row).Cells("Address").Value

                    If .Rows(row).Cells("Total_stock").Value <> "" Then

                        Txt_Quantity.Text = .Rows(row).Cells("Total_stock").Value

                    End If


                Catch ex As Exception

                    Txt_Quantity.Text = 0
                    Exit Try

                End Try


            End With

        ElseIf e.RowIndex >= 0 And DataGridView1.Columns(0).Name = "Id_supplier" Then

            row = DataGridView1.CurrentRow.Index

            With DataGridView1

                Txt_Id_Supplier.Text = .Rows(row).Cells("Id_supplier").Value
                Txt_SupplierName.Text = .Rows(row).Cells("Name").Value
                Txt_IdProduct.Text = .Rows(row).Cells("Id_product").Value
                Txt_Productname.Text = .Rows(row).Cells("Product_name").Value
                Txt_Price.Text = .Rows(row).Cells("Price_Per_Unit").Value
                Txt_Quantity.Text = .Rows(row).Cells("Total_stock").Value


            End With

        End If


    End Sub

    Private Sub Btn_Search_Click(sender As Object, e As EventArgs) Handles Btn_Search.Click



        If Txt_Productname.Text <> "" And Txt_SupplierName.Text = "" Then  'View Product detail

            DataGridView1.Columns.Clear()
            Frm_ViewProd.TopMost = True
            Frm_ViewProd.Show()






        ElseIf Txt_SupplierName.Text <> "" And Txt_Productname.Text = "" Then  'View Supplier detail

            sql = "SELECT T1.Id_supplier,T1.Name,T2.Id_product,T2.Name AS Product_name,T2.Unit_cost AS Price_Per_Unit,T2.Images
                   FROM Supplier T1 LEFT JOIN Products T2 ON T1.Name = T2.Supplier_name
                   WHERE T1.Name LIKE '%" & Txt_SupplierName.Text.Trim & "%'
                   ORDER BY T1.Id_supplier"

            LoadImage(DataGridView1)




        ElseIf Txt_SupplierName.Text <> "" And Txt_Productname.Text <> "" Then 'View Only Product of supplier

            sql = "SELECT T1.Id_supplier,T1.Name,T2.Id_product,T2.Name AS Product_name,T2.Unit_cost AS Price_Per_Unit,T2.Total_stock,T2.Images
                   FROM Supplier T1 LEFT JOIN Products T2 ON T1.Name = T2.Supplier_name
                   WHERE T1.Name LIKE '%" & Txt_SupplierName.Text.Trim & "%' AND T2.Name LIKE '%" & Txt_Productname.Text.Trim & "%'"

            LoadImage(DataGridView1)


        Else

            MsgBox("Product Not Found", MessageBoxIcon.Error, "Notice")

        End If


    End Sub

    Private Sub Btn_refresh_Click(sender As Object, e As EventArgs) Handles Btn_refresh.Click

        sql = "SELECT * FROM Products"
        LoadImage(DataGridView1)

        table.Clear()

    End Sub

    Private Sub Btn_Update_Click(sender As Object, e As EventArgs) Handles Btn_Update.Click

        Dim Product_date As String = Format(DateTime.Now, "M/dd/yyyy hh:mm:ss")
        Dim TotalStock As Integer = 0




        If Check_null(Txt_IdProduct.Text) = False Then


            If Loop_arraytext(Txt_Productname, Txt_Price, Txt_TotalPrice, Txt_Unitcost, Txt_Unitprice _
               , Txt_Safety_stock, Txt_SupplierName, TxtAddress_Sup) = True Then


                'Product  >>>Update with image  
                'Product แก้ไขข้อมูลสินค้า แต่ปรับเปลี่ยนจำนวนสินค้าในสต็อกไม่ได้

                If Txt_Pic.Text <> "" Then

                    sql = "UPDATE Products SET  Name = @name
                                           ,Unit_price = @unitprice
                                           ,Unit_cost = @unitcost
                                           ,Safety_stock = @safetystock                                          
                                           ,Supplier_name = @suppliername
                                           ,Images = @images 
                  
                          WHERE Id_product = '" & Txt_IdProduct.Text.Trim & "'"

                    Using connection As New SqlConnection(constring)

                        Using Command As New SqlCommand(sql, connection)

                            Dim Pic As Byte() = ImageToStream(Txt_Pic.Text.Trim)

                            Command.Parameters.AddWithValue("@name", Txt_Productname.Text.Trim)
                            Command.Parameters.AddWithValue("@unitprice", Txt_Unitprice.Text.Trim)
                            Command.Parameters.AddWithValue("@unitcost", Txt_Unitcost.Text.Trim)
                            Command.Parameters.AddWithValue("@safetystock", Txt_Safety_stock.Text.Trim)
                            Command.Parameters.AddWithValue("@Suppliername", Txt_SupplierName.Text.Trim)
                            Command.Parameters.AddWithValue("@images", Pic)


                            connection.Open()

                            Command.ExecuteNonQuery()
                            connection.Close()



                        End Using

                    End Using

                ElseIf Txt_Pic.Text = "" Then

                    sql = "UPDATE Products SET  Name = @name
                                           ,Unit_price = @unitprice
                                           ,Unit_cost = @unitcost
                                           ,Safety_stock = @safetystock                                          
                                           ,Supplier_name = @suppliername
                                           
                          WHERE Id_product = '" & Txt_IdProduct.Text.Trim & "'"

                    Using connection As New SqlConnection(constring)

                        Using Command As New SqlCommand(sql, connection)


                            Command.Parameters.AddWithValue("@name", Txt_Productname.Text.Trim)
                            Command.Parameters.AddWithValue("@unitprice", Txt_Unitprice.Text.Trim)
                            Command.Parameters.AddWithValue("@unitcost", Txt_Unitcost.Text.Trim)
                            Command.Parameters.AddWithValue("@safetystock", Txt_Safety_stock.Text.Trim)
                            Command.Parameters.AddWithValue("@Suppliername", Txt_SupplierName.Text.Trim)


                            connection.Open()

                            Command.ExecuteNonQuery()
                            connection.Close()



                        End Using

                    End Using





                End If


            Else

                Exit Sub

            End If




            'Supplier

            Dim Old_supplier As String
            Dim Row As Integer = DataGridView1.CurrentRow.Index


            With DataGridView1

                If .Columns.Contains("Supplier_name") = True Then

                    Old_supplier = .Rows(Row).Cells("Supplier_name").Value

                ElseIf .Columns.Contains("Sup_name") = True Then

                    Old_supplier = .Rows(Row).Cells("Sup_name").Value.ToString

                End If

            End With


            sql = "UPDATE Products SET Supplier_name = '" & Txt_SupplierName.Text.Trim & "'
                   WHERE Supplier_name = '" & Old_supplier & "'"

            Insert_NewStock()




            sql = "UPDATE Supplier SET Name = '" & Txt_SupplierName.Text.Trim & "',Address = '" & TxtAddress_Sup.Text.Trim & "'
                   WHERE Name = '" & Old_supplier & "'"


            Insert_NewStock()




            MessageBox.Show("Update Complete")



            sql = "SELECT * FROM Products"

            DataGridView1.Columns.Clear()
            LoadImage(DataGridView1)

        Else

            MessageBox.Show("Process not complete because invalid cells")

        End If

    End Sub

    Private Sub Txt_Productname_Click(sender As Object, e As EventArgs) Handles Txt_Productname.Click

        If Txt_Productname.BackColor <> Color.White Then
            Txt_Productname.BackColor = Color.White

        End If
    End Sub

    Private Sub Txt_Quantity_Click(sender As Object, e As EventArgs) Handles Txt_Quantity.Click

        If Txt_Quantity.BackColor <> Color.White Then
            Txt_Quantity.BackColor = Color.White

        End If
    End Sub

    Private Sub Txt_Price_Click(sender As Object, e As EventArgs) Handles Txt_Price.Click

        If Txt_Price.BackColor <> Color.White Then
            Txt_Price.BackColor = Color.White

        End If
    End Sub

    Private Sub Txt_TotalPrice_Click(sender As Object, e As EventArgs) Handles Txt_TotalPrice.Click

        If Txt_TotalPrice.BackColor <> Color.White Then
            Txt_TotalPrice.BackColor = Color.White

        End If

    End Sub

    Private Sub Txt_Unitcost_Click(sender As Object, e As EventArgs) Handles Txt_Unitcost.Click

        If Txt_Unitcost.BackColor <> Color.White Then
            Txt_Unitcost.BackColor = Color.White

        End If


    End Sub

    Private Sub Txt_Unitprice_Click(sender As Object, e As EventArgs) Handles Txt_Unitprice.Click


        If Txt_Unitprice.BackColor <> Color.White Then
            Txt_Unitprice.BackColor = Color.White

        End If

    End Sub



    Private Sub Txt_SupplierName_Click(sender As Object, e As EventArgs) Handles Txt_SupplierName.Click

        If Txt_SupplierName.BackColor <> Color.White Then
            Txt_SupplierName.BackColor = Color.White

        End If

    End Sub

    Private Sub TxtAddress_Sup_Click(sender As Object, e As EventArgs) Handles TxtAddress_Sup.Click

        If TxtAddress_Sup.BackColor <> Color.White Then
            TxtAddress_Sup.BackColor = Color.White

        End If
    End Sub

    'ตัดสต็อก / ลบรายการสินค้า

    Private Sub Btn_Delete_Click(sender As Object, e As EventArgs) Handles Btn_Delete.Click

        FrmDelete.Show()

    End Sub
    ' เพิ่มสต็อก 

    Private Sub Btn_plus_Click(sender As Object, e As EventArgs) Handles Btn_plus.Click

        Try

            Dim value As Integer = CInt(Txt_Quantity.Text.Trim)


            value += 1
            Txt_Quantity.Text = value

        Catch ex As Exception

            Exit Sub

        End Try


    End Sub

    Private Sub Btn_minus_Click(sender As Object, e As EventArgs) Handles Btn_minus.Click

        Try

            Dim value As Integer = CInt(Txt_Quantity.Text.Trim)


            value -= 1
            Txt_Quantity.Text = value

        Catch ex As Exception

            Exit Sub

        End Try




    End Sub

    Private Sub Txt_TotalPrice_TextChanged(sender As Object, e As EventArgs) Handles Txt_Quantity.TextChanged, Txt_Price.TextChanged
        Try

            If Txt_Quantity.Text.Trim <> "" And Txt_Price.Text.Trim <> "" Then

                Dim Total_price As Integer

                Total_price = CInt(Txt_Quantity.Text.Trim) * CInt(Txt_Price.Text.Trim)

                Txt_TotalPrice.Text = Total_price


            End If


        Catch ex As Exception

        End Try
    End Sub

    Private Sub Txt_Unitcost_TextChanged(sender As Object, e As EventArgs) Handles Txt_Price.TextChanged

        Txt_Unitcost.Text = Txt_Price.Text

    End Sub
End Class
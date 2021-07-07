Imports System.IO
Imports System.Text
Imports System.Collections.Generic
Imports System.Text.RegularExpressions




Public Class FrmProduct


    Private texts As New StringBuilder
    Private str_text As String
    Private id_order As Integer
    Private staffname As String

    Private qty As Integer
    Private totalqty As Integer = 0
    Private product_name As String
    Private PricevatByprod As Double
    Private totalpricevat As Double
    Private discount As Double
    Private afterdiscount As Double
    Private vatbill As Double
    Private totalbyprice As Double

    Private PricevatByprod2 As String
    Private totalpricevat2 As String
    Private discount2 As String
    Private afterdiscount2 As String
    Private vatbill2 As String
    Private totalbyprice2 As String
    Public numui As Double = 0
    Public finalresult As String


    Private Sub Product_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        sql = "SELECT Id_staff FROM Authen_Staff WHERE Username = '" & Userstaff.Trim & "'  "
        Query_Table()

        TxtStaff.Text = table.Rows(0)("Id_staff") & "-" & Userstaff

        With Lstview_pic

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

    Private Sub PicExit_Regis_Click(sender As Object, e As EventArgs)
        Frmmain.Show()
        Me.Hide()


    End Sub

    Private Sub Btn_delitem_Click(sender As Object, e As EventArgs) Handles Btn_delitem.Click

        Dim row As Integer
        Dim nameproduct As String
        Dim lastrow As Integer
        Dim taxsum As Double
        Dim pricesum As Double


        'กรณีต้องการยกเลิกใบเสร็จก่อนหน้า 

        If Txt_IdOrder.Text <> "" And Txt_Orderdate.Text <> "" Then

            sql = "SELECT COUNT(*) FROM Orders WHERE Id_orders = '" & Txt_IdOrder.Text.Trim & "' "
            Query_Scalar()

            If i > 0 Then

                If MessageBox.Show($"ยืนยันการลบรายการสินค้า : {Txt_IdOrder.Text.Trim} อีกครั้ง", "รายการลบสินค้า", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) = DialogResult.OK Then

                    'คืนจำนวนสินค้าเข้าสต็อก
                    For index As Integer = 0 To Lstview_sale.Items.Count - 1

                        Dim inputstock As Integer = CInt(Lstview_sale.Items(index).SubItems(3).Text)
                        Dim outputstock As Integer
                        Dim name_product As String = Lstview_sale.Items(index).SubItems(1).Text
                        Dim stockbalance As Integer ' สต็อกคงเหลือ
                        Dim newtotalstock As Integer 'สต็อกที่คืน + สต็อกคงเหลือ


                        sql = "SELECT Stock_out,Total_stock FROM Products WHERE Name = '" & name_product & "' "
                        Query_Table()

                        stockbalance = CInt(table.Rows(0)("Total_stock"))
                        outputstock = CInt(table.Rows(0)("Stock_out")) - inputstock
                        newtotalstock = stockbalance + inputstock



                        'อัพเดทสต็อก
                        sql = "UPDATE Products SET Stock_in = '" & inputstock & "',Stock_out = '" & outputstock & "',Total_stock = '" & newtotalstock & "'"
                        sql &= "WHERE Name = '" & name_product & "'"
                        Excute_result()

                    Next

                    'ลบ Order ออกจากฐานข้อมูล

                    sql = "DELETE FROM OrderDetails WHERE Id_order = '" & Txt_IdOrder.Text.Trim & "'"
                    Excute_result()

                    sql = "DELETE FROM Orders WHERE Id_orders = '" & Txt_IdOrder.Text.Trim & "'"
                    Excute_result()

                    MessageBox.Show("ลบรายการสินค้าออกจากฐานข้อมูลเรียบร้อยแล้ว", "รายการลบสินค้า", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub

                End If

            End If

        End If

        'ลบ Product ทีละรายการ ก่อนบันทึกลงฐานข้อมูล


        With Lstview_sale

            If Lstview_sale.SelectedItems.Count = 1 Then

                row = Lstview_sale.FocusedItem.Index
                nameproduct = .Items(row).SubItems(1).Text.Trim

                If MessageBox.Show(String.Format("คุณต้องการลบรายการสินค้า :{0} หรือไม่", nameproduct), "รายการลบสินค้า", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = DialogResult.OK Then

                    Lstview_sale.Items(row).Remove()

                    'run number ใหม่
                    lastrow = .Items.Count - 1

                    For i As Integer = 0 To lastrow

                        .Items(i).SubItems(0).Text = i + 1

                    Next

                    'คำนวณ ยอด Total price

                    'tax ทุกสินค้า ไม่รวม ราคาสินค้า

                    taxsum = Sumproduct(Lstview_sale, 4, 0)

                    product.TxtVat.Text = Format(taxsum, "#,###.00")


                    'ราคารวม ทุกสินค้า ไม่รวม tax

                    pricesum = Sumproduct(Lstview_sale, 5, 0) - taxsum

                    product.Txt_Price.Text = Format(pricesum, "#,###.00")



                End If





                'ลบสินค้าทุกรายการ

            ElseIf Lstview_sale.SelectedItems.Count = 0 Then

                If .Items.Count > 0 Then

                    If MessageBox.Show("คุณต้องการลบรายการสินค้าทั้งหมด หรือไม่", "รายการลบสินค้า", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = DialogResult.OK Then

                        For numrow As Integer = .Items.Count - 1 To 0 Step -1

                            .Items(numrow).Remove()

                        Next

                        Txt_Price.Text = ""
                        TxtVat.Text = ""
                        TxtDiscount.Text = ""
                        TxtNetPrice.Text = ""
                        TxtPay.Text = ""
                        TxtChange.Text = ""
                        Txt_IId_Product.Text = ""
                        TxtSupplier.Text = ""
                        Txt_totalstock.Text = ""
                        Txt_balance.Text = ""
                        Txt_safetystock.Text = ""

                        LblUI_Totalcal.Text = 0




                    End If

                End If



            End If

            'แก้ไขรายการสินค้า ตามเลขที่ order 










        End With

    End Sub

    Private Sub Lstview_pic_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Lstview_pic.SelectedIndexChanged



    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles Grpbox_proice.Enter

    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click

        Dim Product_price As String
        Dim productname As String
        Dim Price As Integer
        Dim Totalprice As String
        Dim index As Integer
        Dim ByteImg As Byte()
        Dim stream As MemoryStream
        Dim safetystock As Integer


        With FrmOrder


            .Show()
            .NumericUpDown1.Value = 0
            .Txt_totalprice.Text = ""





            If Lstview_pic.SelectedItems.Count > 0 Then



                Product_price = Lstview_pic.SelectedItems.Item(0).SubItems(0).Text
                index = Product_price.IndexOf("|")

                productname = Product_price.Substring(0, index)

                sql = "SELECT * FROM Products WHERE Name = '" & productname & "'"
                Query_Table()


                Try


                    ByteImg = table.Rows(0)("Images")
                    stream = New MemoryStream(ByteImg)

                    .PictureBox1.Image = Image.FromStream(stream)
                    .PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
                    .PictureBox1.Show()


                Catch ex As Exception

                    Exit Try

                End Try

                .Txt_Productname.Text = table.Rows(0)("Name")
                .Txt_Price.Text = table.Rows(0)("Unit_price")

                Existock = table.Rows(0)("Total_stock")
                safetystock = table.Rows(0)("Safety_stock")

                If Existock > safetystock Then

                    .Lbl_stock.Text = "มีสินค้าอยู่ในสต็อกจำนวน" & Existock & "ชิ้น"
                    .Lbl_stock.BackColor = Color.DarkGreen
                    .Lbl_stock.ForeColor = Color.White


                Else

                    .Lbl_stock.Text = "สินค้าหมด"
                    .Lbl_stock.BackColor = Color.Red
                    .Lbl_stock.ForeColor = Color.White
                    .NumericUpDown1.Enabled = False



                End If






            End If

        End With




    End Sub

    Private Sub TxtDiscount_TextChanged(sender As Object, e As EventArgs) Handles Txt_Price.TextChanged

        Caldiscount()

    End Sub

    Private Sub TxtNetPrice_TextChanged(sender As Object, e As EventArgs) Handles Txt_Price.TextChanged

        Dim valUI As Double
        Dim valtxt As Double

        Try


            If TxtDiscount.Text <> "" Then

                valtxt = (CDbl(Txt_Price.Text) + CDbl(TxtVat.Text)) - CDbl(TxtDiscount.Text)
                TxtNetPrice.Text = Format(valtxt, "#,###.00")


            Else

                valtxt = (CDbl(Txt_Price.Text) + CDbl(TxtVat.Text))
                TxtNetPrice.Text = Format(valtxt, "#,###.00")


            End If

            valUI = CDbl(TxtNetPrice.Text)

            LblUI_Totalcal.Text = Format(valUI, "#,###.00")

        Catch ex As Exception

            Exit Try


        End Try



    End Sub

    Private Sub TxtChange_TextChanged(sender As Object, e As EventArgs) Handles TxtPay.TextChanged, TxtNetPrice.TextChanged

        Try

            If TxtNetPrice.Text <> "" And TxtPay.Text <> "" Then

                Dim change As Double
                change = CDbl(TxtPay.Text) - CDbl(TxtNetPrice.Text)
                TxtChange.Text = Format(change, "#,###.00")


            End If

        Catch ex As Exception

            Exit Try

        End Try



    End Sub

    Private Sub Cbofindprod_TextChanged(sender As Object, e As EventArgs) Handles Cbo_findprod.TextChanged

        If Cbo_findprod.Text <> "" Then


            Dim productname As String


            For Each item As ListViewItem In Lstview_pic.Items

                productname = item.Text.Trim.ToUpper

                If productname.IndexOf(Cbo_findprod.Text.Trim.ToUpper) <> -1 Then

                    item.Selected = True
                    item.EnsureVisible()

                Else

                    item.Selected = False

                End If


            Next

        End If
    End Sub

    Private Sub Btn_Searckprod_Click(sender As Object, e As EventArgs) Handles Btn_Searckprod.Click

        Try


            If Cbo_findprod.Text <> "" Then


                Dim productstr As String
                Dim splitproduct As String

                For Each item As ListViewItem In Lstview_pic.Items

                    productstr = item.Text.Trim
                    splitproduct = Strings.Left(productstr, InStr(productstr, "|") - 1)



                    If splitproduct.ToUpper = Cbo_findprod.Text.Trim.ToUpper Then

                        item.Selected = True
                        item.EnsureVisible()


                    Else

                        item.Selected = False

                    End If


                Next

            ElseIf Cbo_findprod.Text <> "" And CInt(Cbo_findprod.Text) > 0 Then

                'Clear Listview
                If Lstview_sale.Items.Count > 0 Then

                    Dim item As Integer = 0
                    For num = Lstview_sale.Items.Count - 1 To item Step -1

                        Lstview_sale.Items(num).Remove()

                    Next



                End If

                sql = "SELECT T3.Name,T2.Price,T2.Quantity,T1.Order_date,T1.Id_orders FROM Orders as T1 
                   LEFT JOIN OrderDetails as T2 ON T1.Id_orders = T2.Id_order
                   LEFT JOIN Products as T3 ON T2.Id_product = T3.Id_product
                   WHERE T1.Id_orders = '" & Cbo_findprod.Text.Trim & "'"

                Query_Table()

                If table.Rows.Count > 0 Then

                    Dim lastrow As Integer = CInt(table.Rows.Count.ToString)
                    Dim lastcolumn As Integer = CInt(table.Columns.Count)

                    With Lstview_sale


                        Dim listview As ListViewItem
                        Dim resultstr As String
                        Dim resultint As Integer
                        Dim resultdbl As String
                        Dim vatinfo As String
                        Dim totalprice As String





                        For i As Integer = 0 To lastrow - 1  'row

                            'คอลัมน์เลขรัน
                            Dim number As Integer = i + 1
                            listview = New ListViewItem(number)

                            For k As Integer = 0 To lastcolumn - 3  'column

                                'คอลัมน์ product name,qty,price

                                If TypeOf table.Rows(i)(k) Is String Then

                                    resultstr = table.Rows(i)(k).ToString.Trim
                                    listview.SubItems.Add(resultstr)


                                ElseIf TypeOf table.Rows(i)(k) Is Integer Then

                                    resultint = CInt(table.Rows(i)(k))
                                    listview.SubItems.Add(resultint)


                                ElseIf TypeOf table.Rows(i)(k) Is Decimal Then

                                    resultdbl = Format(CDbl(table.Rows(i)(k)), "#,###.00")
                                    listview.SubItems.Add(resultdbl)


                                End If


                                If k = lastcolumn - 3 Then


                                    totalprice = Format(CDbl(table.Rows(i)("Price")) * CDbl(table.Rows(i)("Quantity")), "#,##.00")
                                    vatinfo = Format(CDbl((totalprice * 7) / 100), "#,##.00")

                                    listview.SubItems.Add(vatinfo)
                                    listview.SubItems.Add(totalprice)

                                End If

                            Next


                            .Items.Add(listview)
                            Txt_Orderdate.Text = table.Rows(i)(3)
                            Txt_IdOrder.Text = table.Rows(i)(4)



                        Next

                    End With

                    Dim finalrow As Integer = Lstview_sale.Items.Count - 1

                    Txt_Price.Text = Format(Sumproduct(Lstview_sale, 5, finalrow), "#,##.00")
                    TxtVat.Text = Format(Sumproduct(Lstview_sale, 4, finalrow), "#,##.00")
                    Caldiscount()
                    If TxtDiscount.Text <> "" Then

                        TxtNetPrice.Text = Format((CDbl(Txt_Price.Text) + CDbl(TxtVat.Text)) - CInt(TxtDiscount.Text), "#,##.00")

                    Else

                        TxtNetPrice.Text = Format(CDbl(Txt_Price.Text) + CDbl(TxtVat.Text), "#,##.00")

                    End If

                    LblUI_Totalcal.Text = TxtNetPrice.Text





                End If





            End If

        Catch ex As Exception

            Exit Sub


        End Try





    End Sub


    Private Sub Btn_save_Click(sender As Object, e As EventArgs) Handles Btn_save.Click

        Dim Dateorder As String = Format(DateTime.Now, "M/dd/yyyy hh: mm : ss")
        Dim stocktotal As Integer
        Dim stockupdate As Integer
        Dim stockout As Integer
        Dim lastrow As Integer = Lstview_sale.Items.Count - 1
        Dim prodname As String
        Dim idstaff As Integer = Strings.Left(TxtStaff.Text.Trim, InStr(TxtStaff.Text.Trim, "-") - 1)

        If TxtPay.Text <> "" Then


            'Insert data ลง Table Order

            If Txt_IId_Product.Text <> "" And TxtStaff.Text <> "" And TxtNetPrice.Text <> "" Then

                sql = "INSERT Orders (Id_staff,Order_date,Total)"
                sql &= "VALUES('" & idstaff & "'"
                sql &= ",'" & Dateorder & "'"
                sql &= ",'" & CDbl(TxtNetPrice.Text.Trim) & "')"


                Excute_result()


                sql = "SELECT * FROM Orders Order by Id_orders DESC"

                Query_Table()
                Txt_IdOrder.Text = table.Rows(0)("Id_orders")
                Txt_Orderdate.Text = Format(DateTime.Now, "dd/M/yyyy hh: mm : ss")



            ElseIf Txt_IId_Product.Text <> "" And TxtStaff.Text <> "" And TxtNetPrice.Text <> "" And Txt_Customer.Text <> "" And TxtPay.Text <> "" Then

                sql = "INSERT Orders (Id_staff,Id_customer,Order_date,Total)"
                sql &= "VALUES('" & idstaff & "'"
                sql &= ",'" & Txt_Customer.Text.Trim & "'"
                sql &= ",'" & Dateorder & "'"
                sql &= ",'" & CDbl(TxtNetPrice.Text.Trim) & "')"

                Excute_result()


                sql = "SELECT * FROM Orders Order by Id_orders DESC"

                Query_Table()
                Txt_IdOrder.Text = table.Rows(0)("Id_orders")
                Txt_Orderdate.Text = Format(DateTime.Now, "dd/M/yyyy hh: mm : ss")


            End If

            id_order = CInt(Txt_IdOrder.Text.Trim)
            staffname = TxtStaff.Text.Trim

            'table orderdetails
            For i As Integer = 0 To lastrow

                If Lstview_sale.Items.Count > 0 Then



                    Dim idproduct As Integer
                    Dim quantity As Integer
                    Dim price As Double



                    prodname = Lstview_sale.Items(i).SubItems(1).Text.Trim

                    sql = "SELECT * FROM Products WHERE Name = '" & prodname & "'"
                    Query_Table()

                    idproduct = CInt(table.Rows(0)("Id_product"))
                    stockout = Lstview_sale.Items(i).SubItems(3).Text
                    stocktotal = table.Rows(0)("Total_stock")  'สต็อกคงเหลือก่อนตัดสต็อก
                    stockupdate = stocktotal - CInt(Lstview_sale.Items(i).SubItems(3).Text) 'สต็อกคงเหลือหลังตัดสต็อก
                    quantity = CInt(Lstview_sale.Items(i).SubItems(3).Text)
                    price = CDbl(Lstview_sale.Items(i).SubItems(2).Text)


                    sql = "INSERT OrderDetails VALUES('" & id_order & "'"
                    sql &= ",'" & idproduct & "'"
                    sql &= ",'" & quantity & "'"
                    sql &= ",'" & price & "')"

                    Excute_result()


                    'Update stock table products

                    sql = "UPDATE Products Set Stock_out = '" & stockout & "'"
                    sql &= ",Total_stock = '" & stockupdate & "'"
                    sql &= "WHERE Id_product = '" & idproduct & "'"

                    Excute_result()

                    Dim x As Integer = i
                End If

            Next



            MessageBox.Show("ยืนยันการชำระสินค้าเรียบร้อยแล้ว", "ผลการตรวจสอบ", MessageBoxButtons.OK, MessageBoxIcon.Information)

            If PrintPreviewDialog1.ShowDialog = DialogResult.OK Then

                PrintDocument1.Print()

            End If



        Else

            MessageBox.Show("คุณยังไม่ได้ทำรายการชำระเงิน", "ผลการตรวจสอบ", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If





    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click


        Txt_Orderdate.Text = ""
        Txt_IdOrder.Text = ""
        Txt_IId_Product.Text = ""
        Txt_Customer.Text = ""
        TxtSupplier.Text = ""

        Cbo_findprod.Text = ""
        Txt_totalstock.Text = ""
        Txt_balance.Text = ""
        Txt_safetystock.Text = ""




    End Sub

    Public Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage

        Dim font As New Font("Aerial", 16, FontStyle.Regular)

        Format_print()

        e.Graphics.DrawString(str_text, font, Brushes.Blue, 50, 20)





    End Sub


    'Method print invoice
    Public Sub Format_print()

        With Me.Lstview_sale


            texts.Remove(0, texts.Length)

            If .Items.Count >= 0 Then

                texts.Append(String.Empty & Environment.NewLine)
                texts.Append(String.Empty & Environment.NewLine)
                texts.Append(vbTab & vbTab & "UNPERFECTIONIST  PROGRAMING" & Environment.NewLine)
                texts.Append("******************************************************************************" & Environment.NewLine)
                texts.Append(vbTab & vbTab & "South Carolina" & vbTab & "California" & Environment.NewLine)
                texts.Append(vbTab & vbTab & "United of state America(Head quater)" & Environment.NewLine)
                texts.Append(vbTab & vbTab & "Tel 621-23456781 Email:Codingsoft.email.com" & Environment.NewLine)
                texts.Append("-------------------------------------------------------------------------------------------------" & Environment.NewLine)
                texts.Append(vbTab & "ใบเสร็จเลขที่" & vbTab & vbTab & id_order & Environment.NewLine)
                texts.Append(String.Empty & Environment.NewLine)
                texts.Append("-------------------------------------------------------------------------------------------------" & Environment.NewLine)
                texts.Append(vbTab & "พนักขายเลขที่" & vbTab & vbTab & staffname & Environment.NewLine)
                texts.Append(String.Empty & Environment.NewLine)
                texts.Append(vbTab & "วันที่" & vbTab & vbTab & vbTab & Format(DateAndTime.Now, "dd/M/yyyy hh:mm:ss") & Environment.NewLine)
                texts.Append("-------------------------------------------------------------------------------------------------" & Environment.NewLine)
                texts.Append(String.Empty & Environment.NewLine)

                qty = 0
                totalqty = 0
                product_name = ""
                PricevatByprod = 0.00
                totalpricevat = 0
                discount = 0.00
                afterdiscount = 0.00
                vatbill = 0.00
                totalbyprice = 0.00


                For rowlsv As Integer = 0 To .Items.Count - 1

                    qty = CInt(.Items(rowlsv).SubItems(3).Text.Trim)
                    totalqty += qty
                    product_name = .Items(rowlsv).SubItems(1).Text.Trim
                    PricevatByprod = CDbl(.Items(rowlsv).SubItems(5).Text.Trim)
                    totalpricevat += PricevatByprod



                    If TxtDiscount.Text.Trim <> "" Then

                        discount = CDbl(TxtDiscount.Text.Trim)

                    Else
                        discount = 0.00

                    End If

                    afterdiscount = totalpricevat - discount
                    vatbill = CDbl(TxtVat.Text.Trim)
                    totalbyprice = CDbl(Txt_Price.Text.Trim)

                    PricevatByprod2 = FormatCurrency(PricevatByprod)
                    totalpricevat2 = FormatCurrency(totalpricevat)
                    discount2 = FormatCurrency(discount)
                    afterdiscount2 = FormatCurrency(afterdiscount)
                    vatbill2 = FormatCurrency(vatbill)
                    totalbyprice2 = FormatCurrency(totalbyprice)


                    If product_name.Length >= 8 Then

                        texts.Append(vbTab & qty & vbTab & vbTab & vbTab & product_name & vbTab & PricevatByprod2 & Environment.NewLine)

                    ElseIf product_name.Length < 8 Then

                        texts.Append(vbTab & qty & vbTab & vbTab & vbTab & product_name & vbTab & vbTab & PricevatByprod2 & Environment.NewLine)

                    End If

                    texts.Append(String.Empty & Environment.NewLine)


                Next

                texts.Append("-------------------------------------------------------------------------------------------------" & Environment.NewLine)
                texts.Append(vbTab & "จำนวนรวม" & vbTab & totalqty & Environment.NewLine)
                texts.Append(String.Empty & Environment.NewLine)
                texts.Append(String.Empty & Environment.NewLine)
                texts.Append(vbTab & vbTab & "รวมเป็นเงิน" & vbTab & vbTab & vbTab & totalpricevat2 & Environment.NewLine)
                texts.Append(vbTab & vbTab & "ส่วนลด" & vbTab & vbTab & vbTab & vbTab & discount2 & vbTab & vbTab & vbTab & Environment.NewLine)
                texts.Append(vbTab & vbTab & "จำนวนเงินหลังหักส่วนลด" & vbTab & vbTab & afterdiscount2 & Environment.NewLine)
                texts.Append(vbTab & vbTab & "ภาษีมูลค่าเพิ่ม 7%" & vbTab & vbTab & vbTab & vatbill2 & Environment.NewLine)
                texts.Append(vbTab & vbTab & "ราคาไม่รวมภาษีมูลค่าเพิ่ม" & vbTab & vbTab & totalbyprice2 & Environment.NewLine)
                texts.Append(String.Empty & Environment.NewLine)
                texts.Append("-------------------------------------------------------------------------------------------------" & Environment.NewLine)
                texts.Append(String.Empty & Environment.NewLine)
                texts.Append(vbTab & vbTab & "รวมทั้งสิ้น" & vbTab & vbTab & afterdiscount2 & Environment.NewLine)
                texts.Append(String.Empty & Environment.NewLine)
                texts.Append("-------------------------------------------------------------------------------------------------" & Environment.NewLine)
                texts.Append(String.Empty & Environment.NewLine)
                texts.Append(String.Empty & Environment.NewLine)
                texts.Append(vbTab & vbTab & vbTab & "VAT INCLUDED" & Environment.NewLine)
                texts.Append(vbTab & vbTab & vbTab & "------------")


            End If



        End With

        str_text = texts.ToString


    End Sub


    Public Sub Caldiscount()

        Dim Total_price As Double
        Dim discount As Double

        Try

            If Txt_Price.Text <> "" And TxtVat.Text <> "" Then

                Total_price = CInt(Txt_Price.Text) + CInt(TxtVat.Text)

                'ทุกๆ 1000 บาทลด 10%  แต่ลดสูงสุดไม่เกิน 500 บาท 

                If Total_price >= 1000 Then

                    Dim num As Integer

                    num = (Total_price \ 1000) * 10  '% ที่ลดราคา




                    discount = (Total_price * num) / 100

                    If discount <= 500 Then

                        TxtDiscount.Text = discount
                        Exit Sub

                    Else

                        TxtDiscount.Text = 500
                        Exit Sub

                    End If


                    TxtDiscount.Text = ""

                End If

            Else

                TxtDiscount.Text = ""


            End If

        Catch ex As Exception

            Exit Try

        End Try




    End Sub

    Private Sub Btn_No1_Click(sender As Object, e As EventArgs) Handles Btn_No1.Click

        If LblUI_Totalcal.Text = "0.00" Then

            LblUI_Totalcal.Text = "1"


        Else

            LblUI_Totalcal.Text = LblUI_Totalcal.Text & "1"

        End If
    End Sub

    Private Sub Btn_No2_Click(sender As Object, e As EventArgs) Handles Btn_No2.Click

        If LblUI_Totalcal.Text = "0.00" Then

            LblUI_Totalcal.Text = "2"


        Else

            LblUI_Totalcal.Text = LblUI_Totalcal.Text & "2"

        End If
    End Sub

    Private Sub Btn_No3_Click(sender As Object, e As EventArgs) Handles Btn_No3.Click

        If LblUI_Totalcal.Text = "0.00" Then

            LblUI_Totalcal.Text = "3"


        Else

            LblUI_Totalcal.Text = LblUI_Totalcal.Text & "3"

        End If
    End Sub

    Private Sub Btn_No4_Click(sender As Object, e As EventArgs) Handles Btn_No4.Click

        If LblUI_Totalcal.Text = "0.00" Then

            LblUI_Totalcal.Text = "4"


        Else

            LblUI_Totalcal.Text = LblUI_Totalcal.Text & "4"

        End If
    End Sub


    Private Sub Btn_No5_Click(sender As Object, e As EventArgs) Handles Btn_No5.Click

        If LblUI_Totalcal.Text = "0.00" Then

            LblUI_Totalcal.Text = "5"


        Else

            LblUI_Totalcal.Text = LblUI_Totalcal.Text & "5"

        End If
    End Sub


    Private Sub Btn_No6_Click(sender As Object, e As EventArgs) Handles Btn_No6.Click

        If LblUI_Totalcal.Text = "0.00" Then

            LblUI_Totalcal.Text = "6"


        Else

            LblUI_Totalcal.Text = LblUI_Totalcal.Text & "6"

        End If
    End Sub


    Private Sub Btn_No7_Click(sender As Object, e As EventArgs) Handles Btn_No7.Click

        If LblUI_Totalcal.Text = "0.00" Then

            LblUI_Totalcal.Text = "7"


        Else

            LblUI_Totalcal.Text = LblUI_Totalcal.Text & "7"

        End If
    End Sub


    Private Sub Btn_No8_Click(sender As Object, e As EventArgs) Handles Btn_No8.Click

        If LblUI_Totalcal.Text = "0.00" Then

            LblUI_Totalcal.Text = "8"


        Else

            LblUI_Totalcal.Text = LblUI_Totalcal.Text & "8"

        End If
    End Sub


    Private Sub Btn_No9_Click(sender As Object, e As EventArgs) Handles Btn_No9.Click

        If LblUI_Totalcal.Text = "0.00" Then

            LblUI_Totalcal.Text = "9"


        Else

            LblUI_Totalcal.Text = LblUI_Totalcal.Text & "9"

        End If
    End Sub


    Private Sub Btn_No0_Click(sender As Object, e As EventArgs) Handles Btn_No0.Click

        If LblUI_Totalcal.Text = "0.00" Then

            LblUI_Totalcal.Text = "0"


        Else

            LblUI_Totalcal.Text = LblUI_Totalcal.Text & "0"

        End If
    End Sub

    Private Sub Btn_Percent_Click(sender As Object, e As EventArgs) Handles Btn_Percent.Click

        Dim value As String = LblUI_Totalcal.Text.Trim

        If InStr(value, Chr(42)) > 1 Or InStr(value, Chr(43)) > 1 Or InStr(value, Chr(45)) > 1 Or InStr(value, Chr(47)) > 1 Or InStr(value, Chr(37)) > 0 Then

            calMultivalue(LblUI_Totalcal.Text.Trim)

            If result = 0 Then

                finalresult = Strings.Left(value, value.Length - 1)
                LblUI_Totalcal.Text = finalresult & "%"
            Else


                finalresult = result.ToString.Trim
                LblUI_Totalcal.Text = finalresult & "%"


            End If


        ElseIf Strings.Right(value, 1) = "=" Then

            LblUI_Totalcal.Text = Strings.Left(value, value.Length - 1) & "%"


        Else

            LblUI_Totalcal.Text = LblUI_Totalcal.Text.Trim & "%"

        End If




    End Sub

    Private Sub Btn_Plus_Click(sender As Object, e As EventArgs) Handles Btn_Plus.Click

        Dim value As String = LblUI_Totalcal.Text.Trim

        If InStr(value, Chr(42)) >= 1 Or InStr(value, Chr(43)) >= 1 Or InStr(value, Chr(45)) >= 1 Or InStr(value, Chr(47)) >= 1 Or InStr(value, Chr(37)) >= 1 Then

            Dim idx As Integer = InStr(value, Chr(45))

            calMultivalue(LblUI_Totalcal.Text.Trim)


            If result = 0 Then

                finalresult = Strings.Left(value, value.Length - 1)
                LblUI_Totalcal.Text = finalresult & "+"
            Else

                finalresult = result.ToString & "+"
                LblUI_Totalcal.Text = finalresult

            End If


        ElseIf Strings.Right(value, 1) = "=" Then

            LblUI_Totalcal.Text = Strings.Left(value, value.Length - 1) & "+"


        Else

            LblUI_Totalcal.Text = LblUI_Totalcal.Text.Trim & "+"

        End If

    End Sub

    Private Sub Btn_Minus_Click(sender As Object, e As EventArgs) Handles Btn_Minus.Click

        Dim value As String = LblUI_Totalcal.Text.Trim

        If InStr(value, Chr(42)) >= 1 Or InStr(value, Chr(43)) >= 1 Or InStr(value, Chr(45)) >= 1 Or InStr(value, Chr(47)) >= 1 Or InStr(value, Chr(37)) >= 1 Then

            calMultivalue(LblUI_Totalcal.Text.Trim)

            finalresult = String.Empty

            If result = 0 Then

                finalresult = Strings.Left(value, value.Length - 1)
                LblUI_Totalcal.Text = finalresult & "-"
            Else



                finalresult = result.ToString & "-"
                LblUI_Totalcal.Text = finalresult


            End If



        ElseIf Strings.Right(value, 1) = "=" Then

            LblUI_Totalcal.Text = Strings.Left(value, value.Length - 1) & "-"


        Else

            LblUI_Totalcal.Text = LblUI_Totalcal.Text.Trim & "-"

        End If

    End Sub

    Private Sub Btn_Multiply_Click(sender As Object, e As EventArgs) Handles Btn_Multiply.Click

        Dim value As String = LblUI_Totalcal.Text.Trim

        If InStr(value, Chr(42)) > 1 Or InStr(value, Chr(43)) > 1 Or InStr(value, Chr(45)) > 1 Or InStr(value, Chr(47)) > 1 Or InStr(value, Chr(37)) > 1 Then

            calMultivalue(LblUI_Totalcal.Text.Trim)

            If result = 0 Then

                finalresult = Strings.Left(value, value.Length - 1)
                LblUI_Totalcal.Text = finalresult & "*"

            Else

                finalresult = result.ToString & "*"
                LblUI_Totalcal.Text = finalresult

            End If


        ElseIf Strings.Right(value, 1) = "=" Then

            LblUI_Totalcal.Text = Strings.Left(value, value.Length - 1) & "*"



        Else

            LblUI_Totalcal.Text = LblUI_Totalcal.Text.Trim & "*"

        End If

    End Sub

    Private Sub Btn_Divide_Click(sender As Object, e As EventArgs) Handles Btn_Divide.Click

        Dim value As String = LblUI_Totalcal.Text.Trim

        If InStr(value, Chr(42)) > 1 Or InStr(value, Chr(43)) > 1 Or InStr(value, Chr(45)) > 1 Or InStr(value, Chr(47)) > 1 Or InStr(value, Chr(37)) > 1 Then

            calMultivalue(LblUI_Totalcal.Text.Trim)

            If result = 0 Then


                finalresult = Strings.Left(value, value.Length - 1)
                LblUI_Totalcal.Text = finalresult & "/"

            Else


                finalresult = result.ToString.Trim & "/"
                LblUI_Totalcal.Text = finalresult


            End If


        ElseIf Strings.Right(value, 1) = "=" Then

            LblUI_Totalcal.Text = Strings.Left(value, value.Length - 1) & "/"

        Else

            LblUI_Totalcal.Text = LblUI_Totalcal.Text.Trim & "/"

        End If

    End Sub

    Private Sub BtnStartNo_0_Click(sender As Object, e As EventArgs) Handles BtnStartNo_0.Click
        LblUI_Totalcal.Text = "0.00"

    End Sub

    Private Sub Btn_Equal_Click(sender As Object, e As EventArgs) Handles Btn_Equal.Click

        Dim value As String = LblUI_Totalcal.Text.Trim

        Try

            If value = "0.00" Then

                LblUI_Totalcal.Text = "="

            ElseIf InStr(value, Chr(42)) = 0 And InStr(value, Chr(43)) = 0 And InStr(value, Chr(45)) = 0 And InStr(value, Chr(47)) = 0 And InStr(value, Chr(37)) = 0 And Strings.Right(value, 1) <> "=" Then

                LblUI_Totalcal.Text &= "="


            ElseIf InStr(value, Chr(42)) >= 1 Or InStr(value, Chr(43)) >= 1 Or InStr(value, Chr(45)) >= 1 Or InStr(value, Chr(47)) >= 1 Or InStr(value, Chr(37)) >= 1 Then

                Dim num As Double

                calMultivalue(LblUI_Totalcal.Text.Trim)
                num = result

                LblUI_Totalcal.Text = num

            ElseIf Strings.Right(value, 1) = "=" Then

                LblUI_Totalcal.Text = value

            End If


        Catch ex As Exception

            MessageBox.Show("ระบบไม่สามารทำการคำนวณได้", "พบข้อผิดพลาด", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)


        End Try

    End Sub

    Private Sub Btn_dot_Click(sender As Object, e As EventArgs) Handles Btn_dot.Click
        LblUI_Totalcal.Text = LblUI_Totalcal.Text & "."
    End Sub

    Private Sub PrintDocument2_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument2.PrintPage

        Dim font As New Font("Aerial", 16, FontStyle.Regular)

        Format_print()

        e.Graphics.DrawString(str_text, font, Brushes.Blue, 50, 20)


    End Sub

    Private Sub BtnPrint_Click(sender As Object, e As EventArgs) Handles BtnPrint.Click

        MessageBox.Show("ยืนยันการพิมพ์", "โปรดยืนยันการพิมพ์", MessageBoxButtons.OK, MessageBoxIcon.Information)

        PrintPreviewDialog1.Refresh()
        If PrintPreviewDialog1.ShowDialog = DialogResult.OK Then

            PrintDocument2.Print()

        End If


    End Sub
End Class


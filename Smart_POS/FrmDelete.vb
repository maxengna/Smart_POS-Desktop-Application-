Imports System.Data.SqlClient
Imports System.Data
Imports System.Text

Public Class FrmDelete
    Private Sub Btn_cancel_Click(sender As Object, e As EventArgs) Handles Btn_cancel.Click

        Frmmain.Stock.Show()
        Me.Hide()
    End Sub

    Private Sub Btn_confirm_Click(sender As Object, e As EventArgs) Handles Btn_confirm.Click

        Try

            Dim Id_product As Integer = Frmmain.Stock.Txt_IdProduct.Text.Trim


            If Rdb_delproduct.Checked Then

                Dim result As DialogResult = MessageBox.Show("โปรดยืนยันการลบรายการสินค้าที่เลือกอีกครั้ง", "ยืนยันการลบ", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)


                If result = DialogResult.OK Then

                    With Frmmain.Stock

                        If Loop_arraytext(.Txt_IdProduct, .Txt_Productname) = True Then

                            'Delete table Purchase ,Purchase detail,Order detail,Product

                            'ลบทุกคำสั่งซื้อที่เป็นของ Product ที่จะทำการลบเท่านั้น

                            'Dim Id_product As Integer = .Txt_IdProduct.Text.Trim

                            'หาเลขคำสั่งซื้อทั้งหมดที่เป็นของ Id_product นั้น โดย
                            '1.เก็บ Id_purchase ทั้งหมดของ Product ที่จะลบ จาก Table purchase detail ใส่ใน array

                            sql = "SELECT * FROM Purchase_detail WHERE Id_product = '" & .Txt_IdProduct.Text.Trim & "'"

                            .DataGridView1.Columns.Clear()
                            table.Reset()

                            Query_Table()
                            .DataGridView1.DataSource = table

                            Dim i As Integer
                            Dim Id_purchases As New ArrayList
                            Dim Target_Builder As StringBuilder = New StringBuilder


                            For i = 0 To .DataGridView1.RowCount - 1

                                Id_purchases.Add(.DataGridView1.Rows(i).Cells("Id_purchase").Value.ToString)

                            Next

                            If Id_purchases.Count > 0 Then

                                For Each Id_purchase As Integer In Id_purchases

                                    Target_Builder.Append(",").Append(Id_purchase)


                                Next

                            Else

                                MessageBox.Show("Id_purchase not found")
                                Exit Sub


                            End If


                            'Dim str As String = Target_Builder.ToString
                            Dim j As Integer = Target_Builder.Length - 1
                            Dim Group_Idpurchase As String = Mid(Target_Builder.ToString, 2, j)

                            MessageBox.Show(Group_Idpurchase)


                            '2.วนลูปลบ Id_purchase จากข้อ1 ใน TABLE purchase

                            Dim ids As String() = Group_Idpurchase.Split(New Char() {","c})


                            For Each id As String In ids

                                Dim Convert_id As Integer = CInt(id)



                                sql = "DELETE FROM Purchase WHERE Id_purchase = '" & Convert_id & "'"

                                Excute_result()

                            Next


                            '3.ลบ Id_purchase ใน purchase detail

                            sql = "DELETE FROM Purchase_detail WHERE Id_product = '" & Id_product & "'"

                            Excute_result()

                            '4 ลบ Order ที่เคยสั้งซื้อสินค้าชนิดนี้

                            'หารายการสั่งซื้อทั้งหมดที่เป็นของ Product ชนิดนี้ใส่ใน Array

                            Dim Id_orders As New ArrayList

                            sql = "SELECT * FROM OrderDetails WHERE Id_product = '" & Id_product & "'"

                            .DataGridView1.Columns.Clear()

                            Try

                                Query_Table()

                                .DataGridView1.DataSource = table

                                If .DataGridView1.RowCount > 0 Then

                                    For row As Integer = 0 To .DataGridView1.RowCount - 1

                                        Id_orders.Add(.DataGridView1.Rows(row).Cells("Id_order").Value.ToString)

                                    Next

                                End If

                                sql = "DELETE FROM OrderDetails WHERE Id_product = '" & Id_product & "'"

                                Excute_result()

                                '5.ลบ Id_order ใน Table Orders

                                For Each id_order As String In Id_orders

                                    Dim convert_Idorder As Integer = CInt(id_order)

                                    sql = "DELETE FROM Orders WHERE Id_orders = '" & convert_Idorder & "'"

                                    Excute_result()

                                Next

                                '6 ลบรายการสินค้า ใน Table Products

                                sql = "DELETE FROM Products WHERE Id_product = '" & Id_product & "'"

                                Excute_result()


                                MessageBox.Show("ลบรายการสินค้าเรียบร้อยแล้ว")



                            Catch ex As Exception

                                Exit Try


                            End Try







                        Else

                            MessageBox.Show(builder.ToString)



                        End If



                    End With

                End If









            ElseIf Rdb_Delstock.Checked Then

                With Frmmain.Stock

                    If Loop_arraytext(.Txt_IdProduct, .Txt_Productname, .Txt_Quantity, .Txt_Safety_stock) = True Then


                        sql = "SELECT * FROM Products WHERE Id_product = '" & Id_product & "'"

                        Query_Table()

                        Dim safety_stock As Integer = CInt(table.Rows(0)("Safety_stock"))
                        Dim Change_stock As Integer = CInt(.Txt_Quantity.Text.Trim)
                        Dim Exist_stock As Integer = CInt(table.Rows(0)("Total_stock"))


                        'หายอดที่เบิกได้ในครั้งนี
                        Dim stock_inused As Integer
                        Dim stock_balance As Integer


                        'ตรวจสอบว่ายอดคงเหลือในสต็อกมากกว่า ยอด safety และ มากกว่า ยอดที่เบิกในครั้งนี้

                        If Exist_stock > safety_stock Then

                            stock_inused = Exist_stock - safety_stock  'ยอดที่เบิกได้จริง



                            If Change_stock <= stock_inused And Change_stock > 0 Then   'จำนวนขอเบิกมีน้อยกว่ายอดที่เบิกได้ >> เบิกได้

                                Dim Stock_out As Integer

                                Stock_out = Change_stock  'จำนวนสต็อกที่ทำการลด
                                stock_balance = Exist_stock - Stock_out 'ยอดคงเหลือหลังลบสต็อกออก

                                'Update stock 
                                sql = "UPDATE Products SET Stock_out = '" & Stock_out & "' ,Total_stock = '" & stock_balance & "'
                                      WHERE Id_product = '" & Id_product & "'"


                                Excute_result()


                                'show

                                MessageBox.Show("ดำเนินการลดสต็อกสินค้า: " & .Txt_Productname.Text.Trim & vbNewLine _
                                                & "จำนวน :" & Stock_out & "ชิ้น เรียบร้อยแล้วครับ")

                                sql = "SELECT * FROM Products WHERE Id_product = '" & Id_product & "'"

                                LoadImage(.DataGridView1)


                            ElseIf Change_stock > stock_inused And Change_stock > 0 Then  'เบิกเกินจำนวนที่เบิกได้ >> เบิกไม่ได้

                                MessageBox.Show("คูณทำรายการเบิกเกินจำนวนที่เบิกได้" & Environment.NewLine() _
                                                & "ยอดที่เบิกได้ครั้งนี้ :" & stock_inused)


                            End If


                        ElseIf Exist_stock <= safety_stock Then
                            MessageBox.Show("ยอดสต็อกคงเหลือเท่ากับ Safety Stockc แล้ว")

                        End If





                    ElseIf Loop_arraytext(.Txt_IdProduct, .Txt_Productname, .Txt_Quantity, .Txt_Safety_stock) = False Then


                        MessageBox.Show(builder.ToString)



                    End If



                End With














            End If

        Catch ex As Exception

            Exit Sub

        End Try



    End Sub

    Private Sub PicExit_del_Click(sender As Object, e As EventArgs) Handles PicExit__del.Click
        Frmmain.Stock.Show()
        Me.Close()

    End Sub
End Class
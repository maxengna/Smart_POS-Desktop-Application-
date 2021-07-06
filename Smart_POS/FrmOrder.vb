Public Class FrmOrder

    Public net_totalprice As Double = 0.00
    Public net_tax As Double = 0.00
    Public formatprice As String
    Public formatvat As String
    Public formattotalprice As String
    Public destrow As Integer


    Private Sub Btn_Add_Click(sender As Object, e As EventArgs) Handles Btn_Add.Click

        If Txt_Productname.Text <> "" And Txt_Price.Text <> "" And NumericUpDown1.Text <> "" And Txt_totalprice.Text <> "" Then

            Dim arr(5) As String
            Dim vat As Double = (CInt(Txt_Price.Text) * 7) / 100


            arr(0) = product.Lstview_sale.Items.Count + 1
            arr(1) = Txt_Productname.Text.Trim
            arr(2) = Txt_Price.Text
            arr(3) = NumericUpDown1.Value.ToString
            arr(4) = vat
            arr(5) = CInt(Txt_Price.Text * NumericUpDown1.Value) + vat

            Dim listviewitem As New ListViewItem(arr)

            'กรณีมีการเลือกสินค้าเดิมซ้ำ
            If product.Lstview_sale.Items.Count > 0 Then

                Dim lastrow As Integer = product.Lstview_sale.Items.Count


                For Each itm As ListViewItem In product.Lstview_sale.Items

                    For Each subitm As ListViewItem.ListViewSubItem In itm.SubItems



                        Dim num As Integer



                        If Find_index(Txt_Productname.Text.Trim, product.Lstview_sale) >= 0 Then

                            num = indexnum


                            Dim productname As String = product.Lstview_sale.Items(num).SubItems(1).Text
                            Dim old_qty As String = product.Lstview_sale.Items(num).SubItems(3).Text
                            Dim old_totalprice As String = product.Lstview_sale.Items(num).SubItems(5).Text

                            'บวกเพิ่มจำนวนสินค้า และ ราคารวม และบันทึกลงในช่องเดิม

                            Dim new_qty As Integer = CInt(old_qty) + CInt(NumericUpDown1.Value)

                            Dim new_totalprice As Double = CDbl(Txt_Price.Text * new_qty)
                            Dim Total_price As Double = 0


                            vat = Math.Round((new_totalprice * 7) / 100, 2)
                            Total_price = Math.Round(new_totalprice + vat, 2)




                            product.Lstview_sale.Items(num).SubItems(3).Text = new_qty
                            product.Lstview_sale.Items(num).SubItems(4).Text = vat
                            product.Lstview_sale.Items(num).SubItems(5).Text = Total_price


                            With product.Lstview_sale

                                Dim strfind As String = Txt_Productname.Text.Trim
                                Dim val As Integer


                                If Find_index(strfind, product.Lstview_sale) >= 0 Then

                                    val = indexnum

                                Else



                                End If




                                formatprice = Format(CDbl(.Items(val).SubItems(2).Text), "#,###.00")
                                formatvat = Format(CDbl(.Items(val).SubItems(4).Text), "#,###.00")
                                formattotalprice = Format(CDbl(.Items(val).SubItems(5).Text), "#,###.00")


                                .Items(val).SubItems(2).Text = formatprice
                                .Items(val).SubItems(4).Text = formatvat
                                .Items(val).SubItems(5).Text = formattotalprice



                            End With



                            Me.Hide()

                            Try

                                With product


                                    .Txt_IId_Product.Text = table.Rows(0)("Id_product")

                                    Try
                                        .TxtSupplier.Text = table.Rows(0)("Supplier_name")

                                    Catch ex As Exception

                                        Exit Try

                                    End Try

                                    .Txt_totalstock.Text = table.Rows(0)("Total_stock")
                                    .Txt_balance.Text = NumericUpDown1.Value
                                    .Txt_safetystock.Text = table.Rows(0)("Safety_stock")







                                    'tax ทุกสินค้า ไม่รวม ราคาสินค้า

                                    net_tax = Sumproduct(.Lstview_sale, 4, 0)

                                    product.TxtVat.Text = Format(net_tax, "#,###.00")


                                    'ราคารวม ทุกสินค้า ไม่รวม tax

                                    net_totalprice = Sumproduct(.Lstview_sale, 5, 0) - net_tax

                                    product.Txt_Price.Text = Format(net_totalprice, "#,###.00")

                                End With

                            Catch ex As Exception

                                Continue For

                            End Try





                            Exit Sub




                        ElseIf Find_index(Txt_Productname.Text.Trim, Product.Lstview_sale) < 0 Then

                            Dim arr2(5) As String


                            arr2(0) = product.Lstview_sale.Items.Count + 1
                            arr2(1) = Txt_Productname.Text.Trim
                            arr2(2) = Txt_Price.Text
                            arr2(3) = NumericUpDown1.Value.ToString
                            arr2(4) = vat
                            arr2(5) = CInt(Txt_Price.Text * NumericUpDown1.Value) + vat

                            Dim listviewitem2 As New ListViewItem(arr)


                            product.Lstview_sale.Items.Add(listviewitem2)


                            With product.Lstview_sale

                                destrow = .Items.Count - 1
                                formatprice = Format(CDbl(.Items(destrow).SubItems(2).Text), "#,###.00")
                                formatvat = Format(CDbl(.Items(destrow).SubItems(4).Text), "#,###.00")
                                formattotalprice = Format(CDbl(.Items(destrow).SubItems(5).Text), "#,###.00")


                                .Items(destrow).SubItems(2).Text = formatprice
                                .Items(destrow).SubItems(4).Text = formatvat
                                .Items(destrow).SubItems(5).Text = formattotalprice



                            End With










                            Me.Hide()

                            With product


                                Try

                                    With product


                                        .Txt_IId_Product.Text = table.Rows(0)("Id_product")

                                        Try
                                            .TxtSupplier.Text = table.Rows(0)("Supplier_name")

                                        Catch ex As Exception

                                            Exit Try

                                        End Try

                                        .Txt_totalstock.Text = table.Rows(0)("Total_stock")
                                        .Txt_balance.Text = NumericUpDown1.Value
                                        .Txt_safetystock.Text = table.Rows(0)("Safety_stock")


                                        net_tax = Sumproduct(.Lstview_sale, 4, 0)

                                        product.TxtVat.Text = Format(net_tax, "#,###.00")


                                        'ราคารวม ทุกสินค้า ไม่รวม tax

                                        net_totalprice = Sumproduct(.Lstview_sale, 5, 0) - net_tax

                                        product.Txt_Price.Text = Format(net_totalprice, "#,###.00")


                                    End With

                                Catch ex As Exception

                                    Continue For

                                End Try




                            End With


                            Exit Sub




                        End If


                    Next




                Next

            ElseIf Product.Lstview_sale.Items.Count <= 0 Then

                product.Lstview_sale.Items.Add(listviewitem)


                With product.Lstview_sale

                    destrow = .Items.Count - 1
                    formatprice = Format(CDbl(.Items(destrow).SubItems(2).Text), "#,###.00")
                    formatvat = Format(CDbl(.Items(destrow).SubItems(4).Text), "#,###.00")
                    formattotalprice = Format(CDbl(.Items(destrow).SubItems(5).Text), "#,###.00")


                    .Items(destrow).SubItems(2).Text = formatprice
                    .Items(destrow).SubItems(4).Text = formatvat
                    .Items(destrow).SubItems(5).Text = formattotalprice



                End With




                With product


                    .Txt_IId_Product.Text = table.Rows(0)("Id_product")

                    Try
                        .TxtSupplier.Text = table.Rows(0)("Supplier_name")

                    Catch ex As Exception

                        Exit Try

                    End Try

                    .Txt_totalstock.Text = table.Rows(0)("Total_stock")
                    .Txt_balance.Text = NumericUpDown1.Value
                    .Txt_safetystock.Text = table.Rows(0)("Safety_stock")




                    'tax ทุกสินค้า ไม่รวม ราคาสินค้า

                    net_tax = Sumproduct(.Lstview_sale, 4, 0)

                    product.TxtVat.Text = Format(net_tax, "#,###.00")

                    'ราคารวม ทุกสินค้า ไม่รวม tax

                    net_totalprice = Sumproduct(.Lstview_sale, 5, 0) - net_tax

                    product.Txt_Price.Text = Format(net_totalprice, "#,###.00")





                End With


            End If
        Else

            MessageBox.Show("คุณยังกรอกข้อมูลไม่ครบ")
            Exit Sub

        End If



        Me.Hide()


    End Sub

    Private Sub Txt_totalprice_TextChanged(sender As Object, e As EventArgs) Handles Txt_totalprice.TextChanged, NumericUpDown1.TextChanged

        If Txt_Price.Text <> "" And NumericUpDown1.Text <> "" Then

            Dim totalprice As Double

            totalprice = Val(Txt_Price.Text) * Val(NumericUpDown1.Text)

            Txt_totalprice.Text = totalprice


        End If

    End Sub

    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown1.ValueChanged

        If NumericUpDown1.Value >= Existock Then

            NumericUpDown1.Value = Existock
            NumericUpDown1.Enabled = False

        End If


    End Sub

    Private Sub Btn_cancel_Click(sender As Object, e As EventArgs) Handles Btn_cancel.Click

        NumericUpDown1.Enabled = True
        NumericUpDown1.Value = 0

    End Sub

End Class
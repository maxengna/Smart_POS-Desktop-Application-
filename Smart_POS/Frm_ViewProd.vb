Imports System.Data.SqlClient
Imports System.Data

Public Class Frm_ViewProd



    Private Sub Btn_Select_Click(sender As Object, e As EventArgs) Handles Btn_Select.Click
        If Rdb_ViewPurchase.Checked Then
            'Me.Close()
            Frmmain.Stock.Activate()



            sql = "SELECT  T2.Id_purchase
                     ,T3.Purchase_date
                     ,T1.Id_product
                     ,T1.Name
                     ,T1.Images    
                     ,T2.Quantity
                     ,T2.Price
                     ,T3.Total 
                     ,T2.Price AS Unit_cost
                     ,T2.Unit_price
                     ,T2.Total_stock
                     ,T1.Safety_stock
                     ,T3.Id_supplier
                     ,T4.Name AS Sup_name
                     ,T4.Address

               FROM Products AS T1
               LEFT JOIN Purchase_detail AS T2 ON T1.Id_product = T2.Id_product
               LEFT JOIN Purchase AS T3 ON T2.Id_purchase = T3.Id_purchase
               LEFT JOIN Supplier AS T4 ON T4.Id_supplier = T3.Id_supplier
               WHERE T1.Name LIKE '%" & Frmmain.Stock.Txt_Productname.Text.Trim & "%'
               ORDER BY T2.Id_purchase DESC"

            Frmmain.Stock.DataGridView1.Columns.Clear()
            LoadImage(Frmmain.Stock.DataGridView1)

            'เเสดงยอด total stock แต่ละ Transaction/Product


            Me.Close()




        ElseIf Rdb_Details.Checked Then

            Frmmain.Stock.Activate()


            sql = "SELECT * FROM Products WHERE Name = '" & Frmmain.Stock.Txt_Productname.Text.Trim & "'"

            Frmmain.Stock.DataGridView1.Columns.Clear()
            LoadImage(Frmmain.Stock.DataGridView1)


            With Frmmain.Stock.DataGridView1

                Try


                    If .RowCount > 1 Then

                        Dim i As Integer

                        For i = 1 To .RowCount - 1

                            Frmmain.Stock.DataGridView1.Rows.RemoveAt(i)

                        Next

                    End If

                Catch ex As Exception

                    Exit Sub

                End Try

            End With


            Me.Close()

        End If

    End Sub
End Class
Public Class Frm_Report

    Public newdatatable As New DataTable
    Private Sub Frm_Report_Close(sender As Object, e As EventArgs) Handles MyBase.FormClosed

        Frmmain.ReportTlstrip.Enabled = True


    End Sub



    Private Sub TreeView1_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles TreeView1.AfterSelect

        If TreeView1.Nodes(0).FirstNode.IsSelected Then

            Txt_productid.Enabled = True
            Txt_productname.Enabled = True
            Rdb_date.Enabled = True
            Rdb_daterange.Enabled = True
            Dpk_Orderstart.Enabled = True
            Dpk_Orderstart.CustomFormat = "dd/M/yyyy hh:mm:ss"
            Dpk_Ordersend.Enabled = True
            Dpk_Ordersend.CustomFormat = "dd/M/yyyy hh:mm:ss"
            Btn_showReport.Enabled = True
            Btn_clear.Enabled = True
            Btn_Print.Enabled = True



            Txt_supplier.Enabled = False
            Rdb_datepurchase.Enabled = False
            Rdb_rangedate_purchase.Enabled = False
            Dpk_Purcstart.Enabled = False
            Dpk_PurcEnd.Enabled = False

        ElseIf TreeView1.Nodes(1).Nodes(0).IsSelected Then

            Txt_productid.Enabled = True
            Txt_productname.Enabled = True
            Txt_supplier.Enabled = True
            Rdb_datepurchase.Enabled = True
            Rdb_datepurchase.Checked = True
            Dpk_Purcstart.Enabled = True
            Dpk_PurcEnd.Enabled = False
            Btn_showReport.Enabled = True
            Btn_clear.Enabled = True
            Btn_Print.Enabled = True



            Dpk_Orderstart.Enabled = False
            Dpk_Ordersend.Enabled = False
            Rdb_date.Enabled = False
            Rdb_daterange.Enabled = False
            Rdb_rangedate_purchase.Enabled = False


        ElseIf TreeView1.Nodes(1).Nodes(1).IsSelected Then

            Txt_productid.Enabled = True
            Txt_productname.Enabled = True
            Txt_supplier.Enabled = True
            Rdb_rangedate_purchase.Enabled = True
            Rdb_rangedate_purchase.Checked = True
            Dpk_Purcstart.Enabled = True
            Dpk_PurcEnd.Enabled = True
            Btn_showReport.Enabled = True
            Btn_clear.Enabled = True
            Btn_Print.Enabled = True


            Rdb_datepurchase.Enabled = False
            Dpk_Orderstart.Enabled = False
            Dpk_Ordersend.Enabled = False
            Rdb_date.Enabled = False
            Rdb_daterange.Enabled = False

        End If











    End Sub

    Private Sub Btn_showReport_Click(sender As Object, e As EventArgs) Handles Btn_showReport.Click

        Dim newdt As New DataTable
        Dim startdate As String
        Dim enddate As String
        Dim rawsql As String



        'กรณีเลือกดูสินค้าทั้งหมด 

        If Txt_productid.Text = String.Empty And Txt_productname.Text = String.Empty And Txt_supplier.Text = String.Empty Then

            'เมนู Order
            'เลือกวันที่วันเดียว
            If Rdb_date.Checked And Dpk_Orderstart.Text <> String.Empty Then


                'Dim newdatatable As New DataTable

                startdate = Strings.Mid(Dpk_Orderstart.Value, 7, 4) & "/" & Strings.Mid(Dpk_Orderstart.Value, 4, 2) & "/" & Strings.Mid(Dpk_Orderstart.Value, 1, 2)


                rawsql = "SELECT DISTINCT T1.Id_orders,T2.Id_product,T3.Name AS Product,convert(date,T1.Order_date) as date,sum(T2.Quantity)AS Amount,T1.Total,T1.Id_staff FROM Orders AS T1"
                rawsql &= " LEFT JOIN OrderDetails AS T2 ON T1.Id_orders = T2.Id_order"
                rawsql &= " LEFT JOIN Products AS T3 ON T3.Id_product = T2.Id_product"
                rawsql &= " WHERE CONVERT(date,T1.Order_date) = '" & startdate & "'"
                rawsql &= " GROUP BY T1.Id_orders,T2.Id_product,T3.Name,T1.Order_date,T1.Total,T1.Id_staff"
                rawsql &= " ORDER BY T1.Id_orders "




                newdatatable = Query_andnewtable(rawsql)

                Dgv_report.DataSource = newdatatable


                'เลือกช่วงวันที่

            ElseIf Rdb_daterange.Checked And Dpk_Orderstart.Text <> String.Empty And Dpk_Ordersend.Text <> String.Empty Then

                'Dim newdatatable2 As New DataTable


                startdate = Strings.Mid(Dpk_Orderstart.Value, 7, 4) & "/" & Strings.Mid(Dpk_Orderstart.Value, 4, 2) & "/" & Strings.Mid(Dpk_Orderstart.Value, 1, 2)
                enddate = Strings.Mid(Dpk_Ordersend.Value, 7, 4) & "/" & Strings.Mid(Dpk_Ordersend.Value, 4, 2) & "/" & Strings.Mid(Dpk_Ordersend.Value, 1, 2)



                rawsql = "SELECT DISTINCT T1.Id_orders,T2.Id_product,T3.Name,convert(date,T1.Order_date) as date,sum(T2.Quantity)AS Amount,T1.Total,T1.Id_staff FROM Orders AS T1"
                rawsql &= " LEFT JOIN OrderDetails AS T2 ON T1.Id_orders = T2.Id_order"
                rawsql &= " LEFT JOIN Products AS T3 ON T3.Id_product = T2.Id_product"
                rawsql &= " WHERE convert(date,T1.Order_date) BETWEEN '" & startdate & "' AND '" & enddate & "' "
                rawsql &= " GROUP BY T1.Id_orders,T2.Id_product,T3.Name,T1.Order_date,T1.Total,T1.Id_staff"
                rawsql &= " ORDER BY T1.Id_orders "






                newdatatable = Query_andnewtable(rawsql)

                Dgv_report.DataSource = newdatatable


                'เมนู Purchase (วันที่วันเดียว ,ช่วงวันที่)

            ElseIf Rdb_datepurchase.Checked And Dpk_Purcstart.Text <> String.Empty Then

                'เงื่อนไข กรองวันเดียว 

                'Dim newdatatable3 As New DataTable

                startdate = Strings.Mid(Dpk_Purcstart.Value, 7, 4) & "/" & Strings.Mid(Dpk_Purcstart.Value, 4, 2) & "/" & Strings.Mid(Dpk_Purcstart.Value, 1, 2)


                rawsql = "SELECT T1.Id_purchase,T1.Id_product,T3.Name as Product,CONVERT(date,T2.Purchase_date) AS date,T1.Quantity AS QTY,T1.Price,T2.Total,T4.Name AS Suppllier  FROM Purchase_detail AS T1 "
                rawsql &= " LEFT JOIN Purchase AS T2 ON T1.Id_purchase = T2.Id_purchase"
                rawsql &= " LEFT JOIN Products AS T3 ON T1.Id_product = T3.Id_product"
                rawsql &= " LEFT JOIN Supplier AS T4 ON  T4.Id_supplier = T2.Id_supplier"
                rawsql &= " WHERE CONVERT(date,T2.Purchase_date) = '" & startdate & "'"
                rawsql &= " ORDER BY T1.Id_purchase"



                'startdate = Strings.Mid(Dpk_Purcstart.Value, 7, 4) & "/" & Strings.Mid(Dpk_Purcstart.Value, 4, 2) & "/" & Strings.Mid(Dpk_Purcstart.Value, 1, 2)

                newdatatable = Query_andnewtable(rawsql)

                'newdatatable3 = data.Optiondate_toreport(startdate)
                Dgv_report.DataSource = newdatatable


                'เลือกช่วงวันที่

            ElseIf Rdb_rangedate_purchase.Checked And Dpk_Purcstart.Text <> String.Empty And Dpk_PurcEnd.Text <> String.Empty Then

                'Dim newdatatable4 As New DataTable

                startdate = Strings.Mid(Dpk_Purcstart.Value, 7, 4) & "/" & Strings.Mid(Dpk_Purcstart.Value, 4, 2) & "/" & Strings.Mid(Dpk_Purcstart.Value, 1, 2)
                enddate = Strings.Mid(Dpk_PurcEnd.Value, 7, 4) & "/" & Strings.Mid(Dpk_PurcEnd.Value, 4, 2) & "/" & Strings.Mid(Dpk_PurcEnd.Value, 1, 2)



                rawsql = "SELECT T1.Id_purchase,T1.Id_product,T3.Name as Product,convert(date,T2.Purchase_date) AS date,T1.Quantity AS QTY,T1.Price,T2.Total,T4.Name AS Suppllier  FROM Purchase_detail AS T1 "
                rawsql &= " LEFT JOIN Purchase AS T2 ON T1.Id_purchase = T2.Id_purchase"
                rawsql &= " LEFT JOIN Products AS T3 ON T1.Id_product = T3.Id_product"
                rawsql &= " LEFT JOIN Supplier AS T4 ON  T4.Id_supplier = T2.Id_supplier"
                rawsql &= " WHERE convert(date,T2.Purchase_date) BETWEEN '" & startdate & "' AND '" & enddate & "' "
                rawsql &= " ORDER BY T1.Id_purchase"



                newdatatable = Query_andnewtable(rawsql)

                Dgv_report.DataSource = newdatatable

            End If

            'กรณี เลือกดู สินค้าบางตัว 

        ElseIf Txt_productid.Text <> String.Empty Or Txt_productname.Text <> String.Empty Or Txt_supplier.Text <> String.Empty Then

            If Rdb_date.Checked And Dpk_Orderstart.Text <> String.Empty Then


                startdate = Strings.Mid(Dpk_Orderstart.Value, 7, 4) & "/" & Strings.Mid(Dpk_Orderstart.Value, 4, 2) & "/" & Strings.Mid(Dpk_Orderstart.Value, 1, 2)

                'Order
                'เลือกดูวันเดียว  
                If Txt_productid.Text <> String.Empty Then


                    rawsql = "SELECT DISTINCT T1.Id_orders,T2.Id_product,T3.Name AS Product,convert(date,T1.Order_date) as date,sum(T2.Quantity)AS Amount,T1.Total,T1.Id_staff FROM Orders AS T1"
                    rawsql &= " LEFT JOIN OrderDetails AS T2 ON T1.Id_orders = T2.Id_order"
                    rawsql &= " LEFT JOIN Products AS T3 ON T3.Id_product = T2.Id_product"
                    rawsql &= " WHERE T2.Id_product = '" & Txt_productid.Text.Trim & "'"
                    rawsql &= " AND CONVERT(date,T1.Order_date) = '" & startdate & "'"
                    rawsql &= " GROUP BY T1.Id_orders,T2.Id_product,T3.Name,T1.Order_date,T1.Total,T1.Id_staff"
                    rawsql &= " ORDER BY T1.Id_orders "


                ElseIf Txt_productname.Text <> String.Empty Then

                    rawsql = "SELECT DISTINCT T1.Id_orders,T2.Id_product,T3.Name AS Product,convert(date,T1.Order_date) as date,sum(T2.Quantity)AS Amount,T1.Total,T1.Id_staff FROM Orders AS T1"
                    rawsql &= " LEFT JOIN OrderDetails AS T2 ON T1.Id_orders = T2.Id_order"
                    rawsql &= " LEFT JOIN Products AS T3 ON T3.Id_product = T2.Id_product"
                    rawsql &= " WHERE T3.Name = '" & Txt_productname.Text.Trim & "'"
                    rawsql &= " AND CONVERT(date,T1.Order_date) = '" & startdate & "'"
                    rawsql &= " GROUP BY T1.Id_orders,T2.Id_product,T3.Name,T1.Order_date,T1.Total,T1.Id_staff"
                    rawsql &= " ORDER BY T1.Id_orders "

                End If

                newdatatable = Query_andnewtable(rawsql)
                Dgv_report.DataSource = newdatatable

                'Order
                'เลือกดูเป็นช่วงวันที่

            ElseIf Rdb_daterange.Checked And Dpk_Orderstart.Text <> String.Empty And Dpk_Ordersend.Text <> String.Empty Then


                startdate = Strings.Mid(Dpk_Orderstart.Value, 7, 4) & "/" & Strings.Mid(Dpk_Orderstart.Value, 4, 2) & "/" & Strings.Mid(Dpk_Orderstart.Value, 1, 2)
                enddate = Strings.Mid(Dpk_Ordersend.Value, 7, 4) & "/" & Strings.Mid(Dpk_Ordersend.Value, 4, 2) & "/" & Strings.Mid(Dpk_Ordersend.Value, 1, 2)


                'เลือกดูเป็นช่วงวันที่  
                If Txt_productid.Text <> String.Empty Then


                    rawsql = "SELECT DISTINCT T1.Id_orders,T2.Id_product,T3.Name AS Product,convert(date,T1.Order_date) as date,sum(T2.Quantity)AS Amount,T1.Total,T1.Id_staff FROM Orders AS T1"
                    rawsql &= " LEFT JOIN OrderDetails AS T2 ON T1.Id_orders = T2.Id_order"
                    rawsql &= " LEFT JOIN Products AS T3 ON T3.Id_product = T2.Id_product"
                    rawsql &= " WHERE T2.Id_product = '" & Txt_productid.Text.Trim & "'"
                    rawsql &= " AND CONVERT(date,T1.Order_date) BETWEEN '" & startdate & "' AND '" & enddate & "'"
                    rawsql &= " GROUP BY T1.Id_orders,T2.Id_product,T3.Name,T1.Order_date,T1.Total,T1.Id_staff"
                    rawsql &= " ORDER BY T1.Id_orders "

                ElseIf Txt_productname.Text <> String.Empty Then

                    rawsql = "SELECT DISTINCT T1.Id_orders,T2.Id_product,T3.Name AS Product,convert(date,T1.Order_date) as date,sum(T2.Quantity)AS Amount,T1.Total,T1.Id_staff FROM Orders AS T1"
                    rawsql &= " LEFT JOIN OrderDetails AS T2 ON T1.Id_orders = T2.Id_order"
                    rawsql &= " LEFT JOIN Products AS T3 ON T3.Id_product = T2.Id_product"
                    rawsql &= " WHERE T3.Name = '" & Txt_productname.Text.Trim & "'"
                    rawsql &= " AND CONVERT(date,T1.Order_date) BETWEEN '" & startdate & "' AND '" & enddate & "'"
                    rawsql &= " GROUP BY T1.Id_orders,T2.Id_product,T3.Name,T1.Order_date,T1.Total,T1.Id_staff"
                    rawsql &= " ORDER BY T1.Id_orders "

                End If


                newdatatable = Query_andnewtable(rawsql)
                Dgv_report.DataSource = newdatatable



            ElseIf Rdb_datepurchase.Checked And Dpk_Purcstart.Text <> String.Empty Then

                'เงื่อนไข กรองวันเดียว 


                startdate = Strings.Mid(Dpk_Purcstart.Value, 7, 4) & "/" & Strings.Mid(Dpk_Purcstart.Value, 4, 2) & "/" & Strings.Mid(Dpk_Purcstart.Value, 1, 2)


                If Txt_productid.Text <> String.Empty Then


                    rawsql = "SELECT T1.Id_purchase,T1.Id_product,T3.Name as Product,CONVERT(date,T2.Purchase_date) AS date,T1.Quantity AS QTY,T1.Price,T2.Total,T4.Name AS Suppllier  FROM Purchase_detail AS T1 "
                    rawsql &= " LEFT JOIN Purchase AS T2 ON T1.Id_purchase = T2.Id_purchase"
                    rawsql &= " LEFT JOIN Products AS T3 ON T1.Id_product = T3.Id_product"
                    rawsql &= " LEFT JOIN Supplier AS T4 ON  T4.Id_supplier = T2.Id_supplier"
                    rawsql &= " WHERE CONVERT(date,T2.Purchase_date) = '" & startdate & "'"
                    rawsql &= " AND T1.Id_product = '" & Txt_productid.Text.Trim & "'"
                    rawsql &= " ORDER BY T1.Id_purchase"

                ElseIf Txt_productname.Text <> String.Empty Then

                    rawsql = "SELECT T1.Id_purchase,T1.Id_product,T3.Name as Product,CONVERT(date,T2.Purchase_date) AS date,T1.Quantity AS QTY,T1.Price,T2.Total,T4.Name AS Suppllier  FROM Purchase_detail AS T1 "
                    rawsql &= " LEFT JOIN Purchase AS T2 ON T1.Id_purchase = T2.Id_purchase"
                    rawsql &= " LEFT JOIN Products AS T3 ON T1.Id_product = T3.Id_product"
                    rawsql &= " LEFT JOIN Supplier AS T4 ON  T4.Id_supplier = T2.Id_supplier"
                    rawsql &= " WHERE CONVERT(date,T2.Purchase_date) = '" & startdate & "'"
                    rawsql &= " AND T3.Name = '" & Txt_productname.Text.Trim & "'"
                    rawsql &= " ORDER BY T1.Id_purchase"

                ElseIf Txt_supplier.Text <> String.Empty Then

                    rawsql = "SELECT T1.Id_purchase,T1.Id_product,T3.Name as Product,CONVERT(date,T2.Purchase_date) AS date,T1.Quantity AS QTY,T1.Price,T2.Total,T4.Name AS Suppllier  FROM Purchase_detail AS T1 "
                    rawsql &= " LEFT JOIN Purchase AS T2 ON T1.Id_purchase = T2.Id_purchase"
                    rawsql &= " LEFT JOIN Products AS T3 ON T1.Id_product = T3.Id_product"
                    rawsql &= " LEFT JOIN Supplier AS T4 ON  T4.Id_supplier = T2.Id_supplier"
                    rawsql &= " WHERE CONVERT(date,T2.Purchase_date) = '" & startdate & "'"
                    rawsql &= " AND T4.Name = '" & Txt_supplier.Text.Trim & "'"
                    rawsql &= " ORDER BY T1.Id_purchase"

                End If


                newdatatable = Query_andnewtable(rawsql)

                Dgv_report.DataSource = newdatatable


                'เลือกช่วงวันที่

            ElseIf Rdb_rangedate_purchase.Checked And Dpk_Purcstart.Text <> String.Empty Or Dpk_PurcEnd.Text <> String.Empty Then


                startdate = Strings.Mid(Dpk_Purcstart.Value, 7, 4) & "/" & Strings.Mid(Dpk_Purcstart.Value, 4, 2) & "/" & Strings.Mid(Dpk_Purcstart.Value, 1, 2)
                enddate = Strings.Mid(Dpk_PurcEnd.Value, 7, 4) & "/" & Strings.Mid(Dpk_PurcEnd.Value, 4, 2) & "/" & Strings.Mid(Dpk_PurcEnd.Value, 1, 2)



                If Txt_productid.Text <> String.Empty Then


                    rawsql = "SELECT T1.Id_purchase,T1.Id_product,T3.Name as Product,convert(date,T2.Purchase_date) AS date,T1.Quantity AS QTY,T1.Price,T2.Total,T4.Name AS Suppllier  FROM Purchase_detail AS T1 "
                    rawsql &= " LEFT JOIN Purchase AS T2 ON T1.Id_purchase = T2.Id_purchase"
                    rawsql &= " LEFT JOIN Products AS T3 ON T1.Id_product = T3.Id_product"
                    rawsql &= " LEFT JOIN Supplier AS T4 ON  T4.Id_supplier = T2.Id_supplier"
                    rawsql &= " WHERE T1.Id_product = '" & Txt_productid.Text.Trim & "'"
                    rawsql &= " AND convert(date,T2.Purchase_date) BETWEEN '" & startdate & "' AND '" & enddate & "' "
                    rawsql &= " ORDER BY T1.Id_purchase"

                ElseIf Txt_productname.Text <> String.Empty Then

                    rawsql = "SELECT T1.Id_purchase,T1.Id_product,T3.Name as Product,convert(date,T2.Purchase_date) AS date,T1.Quantity AS QTY,T1.Price,T2.Total,T4.Name AS Suppllier  FROM Purchase_detail AS T1 "
                    rawsql &= " LEFT JOIN Purchase AS T2 ON T1.Id_purchase = T2.Id_purchase"
                    rawsql &= " LEFT JOIN Products AS T3 ON T1.Id_product = T3.Id_product"
                    rawsql &= " LEFT JOIN Supplier AS T4 ON  T4.Id_supplier = T2.Id_supplier"
                    rawsql &= " WHERE T3.Name = '" & Txt_productname.Text.Trim & "'"
                    rawsql &= " AND convert(date,T2.Purchase_date) BETWEEN '" & startdate & "' AND '" & enddate & "' "
                    rawsql &= " ORDER BY T1.Id_purchase"

                ElseIf Txt_supplier.Text <> String.Empty Then

                    rawsql = "SELECT T1.Id_purchase,T1.Id_product,T3.Name as Product,CONVERT(date,T2.Purchase_date) AS date,T1.Quantity AS QTY,T1.Price,T2.Total,T4.Name AS Suppllier  FROM Purchase_detail AS T1 "
                    rawsql &= " LEFT JOIN Purchase AS T2 ON T1.Id_purchase = T2.Id_purchase"
                    rawsql &= " LEFT JOIN Products AS T3 ON T1.Id_product = T3.Id_product"
                    rawsql &= " LEFT JOIN Supplier AS T4 ON  T4.Id_supplier = T2.Id_supplier"
                    rawsql &= " WHERE T4.Name = '" & Txt_supplier.Text.Trim & "'"
                    rawsql &= " AND convert(date,T2.Purchase_date) BETWEEN '" & startdate & "' AND '" & enddate & "' "
                    rawsql &= " ORDER BY T1.Id_purchase"



                End If


                newdatatable = Query_andnewtable(rawsql)

                Dgv_report.DataSource = newdatatable

            End If


        End If



    End Sub

    Private Sub Btn_clear_Click(sender As Object, e As EventArgs) Handles Btn_clear.Click
        CleardataOnGrideview(Dgv_report)
        Txt_productid.Text = ""
        Txt_productname.Text = ""
        Txt_supplier.Text = ""
    End Sub

    Private Sub Rdb_date_CheckedChanged(sender As Object, e As EventArgs) Handles Rdb_date.CheckedChanged
        If Rdb_date.Checked Then
            Dpk_Ordersend.Enabled = False

        Else
            Dpk_Ordersend.Enabled = True



        End If
    End Sub

    Private Sub Btn_Print_Click(sender As Object, e As EventArgs) Handles Btn_Print.Click

        Dim table_demo As New DataTable



        '1.1 Order ของทุกสินค้า
        If Rdb_date.Checked Or Rdb_daterange.Checked Then




            With table_demo

                .Columns.Add("Id_order", System.Type.GetType("System.String"))
                .Columns.Add("Id_product", System.Type.GetType("System.String"))
                .Columns.Add("Name", System.Type.GetType("System.String"))
                .Columns.Add("Order_date", System.Type.GetType("System.String"))
                .Columns.Add("Quantity", System.Type.GetType("System.String"))
                .Columns.Add("Total", System.Type.GetType("System.String"))
                .Columns.Add("Id_staff", System.Type.GetType("System.String"))


            End With


            For Each dr As DataGridViewRow In Dgv_report.Rows




                Try


                    table_demo.Rows.Add(dr.Cells(0).Value, dr.Cells(1).Value, Trim(dr.Cells(2).Value), dr.Cells(3).Value, dr.Cells(4).Value _
                                     , dr.Cells(5).Value, dr.Cells(6).Value)


                Catch ex As Exception

                    Continue For

                End Try




            Next


            Dim rpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument
            rpt = New CrystalReport1
            rpt.SetDataSource(table_demo)
            rpt.SetParameterValue("Product", Txt_productname.Text.Trim)
            Frm_ReportViewer.CrystalReportViewer1.ReportSource = rpt
            Frm_ReportViewer.ShowDialog()
            Frm_ReportViewer.Dispose()



            '2.Report Purchase

            '2.1 Purchase ทุกสินค้า
        ElseIf Rdb_datepurchase.Checked Or Rdb_rangedate_purchase.Checked Then

            With table_demo

                .Columns.Add("Id_purchase", System.Type.GetType("System.String"))
                .Columns.Add("Id_product", System.Type.GetType("System.String"))
                .Columns.Add("Product", System.Type.GetType("System.String"))
                .Columns.Add("date", System.Type.GetType("System.String"))
                .Columns.Add("QTY", System.Type.GetType("System.String"))
                .Columns.Add("Price", System.Type.GetType("System.String"))
                .Columns.Add("Total", System.Type.GetType("System.String"))
                .Columns.Add("Supplier_name", System.Type.GetType("System.String"))


            End With


            For Each dr As DataGridViewRow In Dgv_report.Rows


                Try


                    table_demo.Rows.Add(dr.Cells(0).Value, dr.Cells(1).Value, Trim(dr.Cells(2).Value), dr.Cells(3).Value, dr.Cells(4).Value _
                                     , dr.Cells(5).Value, dr.Cells(6).Value, dr.Cells(7).Value)

                Catch ex As Exception

                    Continue For


                End Try




            Next





            Dim rpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument
            rpt = New CrystalReport2
            rpt.SetDataSource(table_demo)
            rpt.SetParameterValue("Productname", Txt_productname.Text.Trim)
            rpt.SetParameterValue("Supplier", Txt_supplier.Text.Trim)
            Frm_ReportViewer.CrystalReportViewer1.ReportSource = rpt
            Frm_ReportViewer.ShowDialog()
            Frm_ReportViewer.Dispose()



        End If




    End Sub








End Class
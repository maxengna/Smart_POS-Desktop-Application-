Public Class Frmmain

    Public Stock As New Frm_Stock

    Private Sub LockoutTlstrip_Click(sender As Object, e As EventArgs) Handles LockoutTlstrip.Click
        FrmLogin.Show()
        Me.Hide()
    End Sub

    Private Sub MemberTlstrip_Click(sender As Object, e As EventArgs) Handles MemberTlstrip.Click
        Frm_member.Show()
        Me.Hide()
    End Sub

    Private Sub PicExit_Regis_Click(sender As Object, e As EventArgs) Handles PicExit_Regis.Click
        Application.Exit()
    End Sub

    Private Sub ProductTlstrip_Click(sender As Object, e As EventArgs) Handles ProductTlstrip.Click

        product = New FrmProduct
        product.MdiParent = Me
        product.Show()

    End Sub

    Private Sub StockTlstrip_Click(sender As Object, e As EventArgs) Handles StockTlstrip.Click


        Stock.MdiParent = Me
        Stock.Show()
        StockTlstrip.Enabled = False

    End Sub

    Private Sub ReportTlstrip_Click(sender As Object, e As EventArgs) Handles ReportTlstrip.Click
        Dim frmreport As New Frm_Report
        frmreport.MdiParent = Me

        With frmreport

            .Txt_productid.Enabled = False
            .Txt_productname.Enabled = False
            .Txt_supplier.Enabled = False
            .Rdb_date.Enabled = False
            .Rdb_date.Checked = False
            .Rdb_daterange.Enabled = False
            .Rdb_daterange.Checked = False
            .Rdb_datepurchase.Enabled = False
            .Rdb_datepurchase.Checked = False
            .Rdb_rangedate_purchase.Enabled = False
            .Rdb_rangedate_purchase.Checked = False
            .Dpk_Orderstart.Enabled = False
            .Dpk_Ordersend.Enabled = False
            .Dpk_Purcstart.Enabled = False
            .Dpk_PurcEnd.Enabled = False
            .Btn_showReport.Enabled = False
            .Btn_clear.Enabled = False
            .Btn_Print.Enabled = False


        End With





        frmreport.Show()



        ReportTlstrip.Enabled = False



    End Sub
End Class
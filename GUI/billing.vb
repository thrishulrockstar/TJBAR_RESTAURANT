Imports System.Data.OleDb
Imports System.Security.Cryptography
Imports System.Text

Public Class billing

    Dim disAmount As Double
    Dim getProducID As Integer
    Dim getStocks As Integer
    Dim validatestock As Integer
    Dim getUnitPrice As Double
    Dim loadqty As Double
    Dim discount As Boolean
    Private Sub billing_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Left = (Screen.PrimaryScreen.WorkingArea.Width - Me.Width) / 2
        Me.Top = (Screen.PrimaryScreen.WorkingArea.Height - Me.Height) / 2
        getTransactionID()
        GenerateInvoiceNo()
        fillComboproduct()
    End Sub
    Private Sub getTransactionID()
        Try
            Dim trans As New Random
            Dim numbers As Integer = trans.Next(1, 1000000)
            Dim digitss As String = numbers.ToString("000000")
            txttrans.Text = digitss
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub GenerateInvoiceNo()
        lblInvoice.Text = "INV-" & GetUniqueKey(8)
    End Sub
    Public Shared Function GetUniqueKey(ByVal maxSize As Integer) As String
        Dim chars As Char() = New Char(61) {}
        chars = "123456789".ToCharArray()
        Dim data As Byte() = New Byte(0) {}
        Dim crypto As New RNGCryptoServiceProvider()
        crypto.GetNonZeroBytes(data)
        data = New Byte(maxSize - 1) {}
        crypto.GetNonZeroBytes(data)
        Dim result As New StringBuilder(maxSize)
        For Each b As Byte In data
            result.Append(chars(b Mod (chars.Length)))
        Next
        Return result.ToString()
    End Function
    Private Sub fillComboproduct()
        Dim query As String = "Select productname From product order by productname"
        Dim dtproduct As DataTable = getDataTable(query)

        txtproductame.DataSource = dtproduct
        txtproductame.DisplayMember = "productname"
        '   txtproductame.ValueMember = "productID"

        If txtproductame.Items.Count > 0 Then
            txtproductame.SelectedIndex = 0
        End If
    End Sub
    Private Sub clear()
        txtproductID.Text = ""
        txtprice.Text = ""
        txtQuantity.Text = ""
        txtBalance.Text = ""
        txttotal.Text = ""
        txtAmtPaid.Text = ""
        lblSubTotal.Text = "0"
        txtproductame.Text = ""
        lblTotalAmount.Text = "0.00"
        lblSubTotal.Text = "0.00"
        lblTotalItems.Text = "0"
        txtprice.Text = ""
        txtQuantity.Text = "1"
        txttotal.Text = "0.00"
    End Sub
    Private Sub addbills()
        Try
            sqL = "INSERT INTO bills VALUES( '" & txtproductID.Text & "', '" & txtproductame.Text & "','" & txtQuantity.Text & "', '" & txtprice.Text & "','" & txttotal.Text & "', '" & lblInvoice.Text & "', '" & Date.Today & "')"
            ConnDB()
            cmd = New OleDbCommand(sqL, conn)
            Dim i As Integer
            i = cmd.ExecuteNonQuery
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cmd.Dispose()
            conn.Close()
        End Try
    End Sub
    Private Sub loadbills()
        Try
            sqL = "SELECT productID,productname,qty,unitprice FROM bills WHERE invoiceno = '" & Trim(lblInvoice.Text) & "' "
            ConnDB()
            cmd = New OleDbCommand(sqL, conn)
            dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            dgw.Rows.Clear()
            Do While dr.Read = True
                dgw.Rows.Add(dr(0), dr(1), dr(2), dr(3))
            Loop
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub totalamt()
        Try
            sqL = "SELECT sum(totalamt) FROM bills where invoiceno = '" & Trim(lblInvoice.Text) & "' "
            ConnDB()
            cmd = New OleDbCommand(sqL, conn)
            dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            Do While dr.Read = True
                lblTotalAmount.Text = dr(0)
            Loop
        Catch ex As Exception
        End Try
    End Sub
    Private Sub gettotalitems()
        Try

            sqL = "SELECT sum(qty) FROM bills where invoiceno = '" & Trim(lblInvoice.Text) & "' "
            ConnDB()
            cmd = New OleDbCommand(sqL, conn)
            dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            Do While dr.Read = True
                lblTotalItems.Text = dr(0)
            Loop
        Catch ex As Exception
        End Try
    End Sub
    Private Sub saveitems()
        Try
            sqL = "INSERT INTO transactionDetails VALUES('" & txttrans.Text & "','" & lblInvoice.Text & "', '" & lblTotalItems.Text & "', '" & lblTotalAmount.Text & "', '" & txtAmtPaid.Text & "','" & txtBalance.Text & "', '" & cmdpayment.Text & "', '" & Date.Today & "')"
            ConnDB()
            cmd = New OleDbCommand(sqL, conn)
            Dim i As Integer
            i = cmd.ExecuteNonQuery
            If i > 0 Then
                MsgBox("Billing Details Successfully saved", MsgBoxStyle.Information, "Saves Billing Details")
            Else
                MsgBox("Failed in Saves Billing Details", MsgBoxStyle.Information, "Saves Billing Details")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cmd.Dispose()
            conn.Close()
        End Try
    End Sub
    Private Sub txtproductame_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtproductame.SelectedIndexChanged
        Try
            ConnDB()
            Dim da As New OleDbDataAdapter(("select * from product where productname ='" & Trim(txtproductame.Text) & "'"), conn)
            Dim dt As New DataTable
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                Me.txtprice.Text = dt.Rows(0).Item("unitprice") & ""
                Me.txtproductID.Text = dt.Rows(0).Item("productID") & ""
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub txtQuantity_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtQuantity.TextChanged
        txttotal.Text = Val(txtQuantity.Text) * Val(txtprice.Text)
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        getTransactionID()
        GenerateInvoiceNo()
    End Sub
    Private Sub BindToText()
        Try
            With dgw
                lblSubTotal.Text = Val(.SelectedRows(0).Cells("qty").Value) * Val(.SelectedRows(0).Cells("price").Value)
                .SelectedRows(0).Cells("amt").Value = lblSubTotal.Text
            End With
        Catch ex As Exception
        End Try
    End Sub
    Private Sub dgw_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgw.CellClick
        BindToText()
    End Sub
    Private Sub dgw_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgw.SelectionChanged
        BindToText()
    End Sub
    Private Sub txtAmtPaid_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAmtPaid.KeyPress
        Dim ch As Char = e.KeyChar
        If Char.IsLetter(ch) Then   'Ristricting To Input Only Digits(any number)
            e.Handled = True
        End If
    End Sub
    Private Sub txtQuantity_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtQuantity.KeyPress
        Dim ch As Char = e.KeyChar
        If Char.IsLetter(ch) Then   'Ristricting To Input Only Digits(any number)
            e.Handled = True
        End If
    End Sub
    Private Sub btnload_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnload.Click
        Try
            txttotal.Text = Val(txtprice.Text) * Val(txtQuantity.Text)
            If txtproductame.Text = "" Or txtQuantity.Text = "" Then
                MsgBox("Please enter a product Or Quantity before you click load button")
            Else
                addbills()
                loadbills()
                totalamt()
                gettotalitems()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        txttotal.Text = ""
        txtQuantity.Text = ""
    End Sub
    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        If dgw.Rows.Count = 0 Then
            MsgBox("Please load drugs in the cart before saving", MsgBoxStyle.Exclamation, "Validation")
            Exit Sub
        End If

        If txtAmtPaid.Text = "" Then
            MsgBox("Please fill-in Amount Paid by Customer", MsgBoxStyle.Information, "Validation")
            txtAmtPaid.Focus()
            Exit Sub
        ElseIf cmdpayment.Text = "" Then
            MsgBox("Please choose Payment status field", MsgBoxStyle.Information, "Validation")
            cmdpayment.Focus()
            Exit Sub
        End If
        saveitems()
        'DecreaseStocksOnhand()
        'UpdateToDecreaseStocksOnHand()
        btnreceipt.Show()
        getTransactionID()
        '  GenerateInvoiceNo()
        dgw.Rows.Clear()
        '    btnreceipt.Show()
    End Sub
    Private Sub Deleteitem()
        Try
            sqL = "DELETE * FROM bills WHERE productID = '" & dgw.SelectedRows(0).Cells("productID").Value & "'"
            ConnDB()
            cmd = New OleDbCommand(sqL, conn)
            dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            Do While dr.Read = True
                dgw.Rows.Add(dr(0), dr(1), dr(2), dr(3))
            Loop
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cmd.Dispose()
            conn.Close()
        End Try
    End Sub
    Private Sub btnremove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnremove.Click
        If MsgBox("Are you sure you want to remove this Product from Cart", MsgBoxStyle.YesNo, "Validation") = MsgBoxResult.Yes Then
            Deleteitem()
            loadbills()
            gettotalitems()
            totalamt()
            clear()
            txttotal.Text = ""
            txtQuantity.Text = ""
        End If
    End Sub
    Private Sub txtAmtPaid_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAmtPaid.TextChanged
        txtBalance.Text = Val(lblTotalAmount.Text) - Val(txtAmtPaid.Text)
    End Sub
    Private Sub cmdpayment_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdpayment.SelectedIndexChanged
        If cmdpayment.SelectedIndex = 1 Then
            txtAmtPaid.Text = "0"
        End If
    End Sub
    Private Sub btnreceipt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnreceipt.Click
        receipt.lblInvoice.Text = lblInvoice.Text
        receipt.Show()
    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class
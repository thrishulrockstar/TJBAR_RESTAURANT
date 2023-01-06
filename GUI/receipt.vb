Imports System.Data.OleDb

Public Class receipt

    Dim x As Integer = 0
    Dim Y As Integer = 0
    Dim gettotal As Double
    Private Sub receipt_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Left = (Screen.PrimaryScreen.WorkingArea.Width - Me.Width) / 2
        Me.Top = (Screen.PrimaryScreen.WorkingArea.Height - Me.Height) / 2
        loaditems()
        ibldate.Text = Format(Date.Now, "Short Date")
        ibltime.Text = Format(Date.Now, "Long Time")
    End Sub
    Private Sub loaditems()
        Try
            sqL = "SELECT bills.productname,bills.qty,bills.unitprice,bills.totalamt,transactionDetails.amtpaid,transactionDetails.balanceamt FROM bills INNER JOIN transactionDetails ON bills.invoiceno = transactionDetails.invoiceID where bills.invoiceno ='" & Trim(lblInvoice.Text) & " '"
            ConnDB()
            cmd = New OleDbCommand(sqL, conn)
            dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            dgw.Rows.Clear()
            Do While dr.Read = True
                dgw.Rows.Add(dr(1), dr(0), dr(2), dr(3))
                gettotal += dr(3)
                lblCash.Text = dr(4)
                lblbalance.Text = dr(5)
                dgw.Height += 19
                x += 19
            Loop
            ibltotal.Text += Format((gettotal), "0.00")
            Y = x - 30
            dgw.Height = dgw.Height - 20
            TotalAmount.Location = New Point(49, 245 + Y)
            ibltotal.Location = New Point(249, 245 + Y)
            Cash.Location = New Point(49, 262 + Y)
            lblCash.Location = New Point(249, 262 + Y)
            change.Location = New Point(49, 280 + Y)
            lblbalance.Location = New Point(249, 280 + Y)
            lblLine.Location = New Point(52, 299 + Y)
            lblOR.Location = New Point(86, 315 + Y)
            lblThank.Location = New Point(106, 331 + Y)
            btnexit.Location = New Point(198, 369 + Y)
            btnprint.Location = New Point(104, 369 + Y)
            Panel1.Height = Panel1.Height + Y
            Me.Height = Me.Height + Y
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnprint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnprint.Click
        btnexit.Hide()
        btnprint.Hide()
        If dgw.Rows.Count = 0 Then
            MsgBox("Please load Items to print.", MsgBoxStyle.Exclamation, "Report")
            Exit Sub
        End If

        PrintDialog1.Document = Me.PrintDocument1

        Dim ButtonPressed As DialogResult = PrintDialog1.ShowDialog()
        If (ButtonPressed = DialogResult.OK) Then
            Me.Height = Me.Height + Y
            Panel1.Height = Panel1.Height + Y
            PrintDocument1.Print()
        End If
        Me.Close()
    End Sub
    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim bm As New Bitmap(Me.Panel1.Width, Me.Panel1.Height)
        Panel1.DrawToBitmap(bm, New Rectangle(0, 0, Me.Panel1.Width, Me.Panel1.Height))
        e.Graphics.DrawImage(bm, 50, 40)
        Dim aPS As New PageSetupDialog
        aPS.Document = PrintDocument1
    End Sub
    Private Sub btnexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnexit.Click
        Me.Close()
    End Sub
End Class
Imports System.Data.OleDb

Public Class Database
    Public pix As String
    Private Sub Daatabase_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Left = (Screen.PrimaryScreen.WorkingArea.Width - Me.Width) / 2
        Me.Top = (Screen.PrimaryScreen.WorkingArea.Height - Me.Height) / 2
        loadstaff()
        loadproduct()
        loadsales()
        COMSearchBy.Visible = False
        TxtSearch.Visible = False
        SearchClose.Visible = False
        txtsearch1.Visible = False
        Comsearch1.Visible = False
        searchclose1.Visible = False
        txtsearch2.Visible = False
        Comsearch2.Visible = False
        searchclose2.Visible = False
    End Sub
    Private Sub loadstaff()
        Try
            sqL = "SELECT * FROM staff "
            ConnDB()
            cmd = New OleDbCommand(sqL, conn)
            dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            dgw.Rows.Clear()
            Do While dr.Read = True
                dgw.Rows.Add(dr(0), dr(1), dr(2), dr(3), dr(4), dr(5), dr(6))
            Loop
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub loadproduct()
        Try
            sqL = "SELECT * FROM product "
            ConnDB()
            cmd = New OleDbCommand(sqL, conn)
            dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            dgw1.Rows.Clear()
            Do While dr.Read = True
                dgw1.Rows.Add(dr(0), dr(1), dr(2), dr(3))
            Loop
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub loadsales()
        Try
            sqL = "SELECT * FROM transactionDetails "
            ConnDB()
            cmd = New OleDbCommand(sqL, conn)
            dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            dgw2.Rows.Clear()
            Do While dr.Read = True
                dgw2.Rows.Add(dr(0), dr(1), dr(2), dr(3), dr(4), dr(5), dr(6), dr(7))
            Loop
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BindToText()
        With dgw
            pix = .CurrentRow.Cells(0).Value
        End With
    End Sub
    Private Sub Staffpix()
        Try
            ConnDB()
            Dim arrImage() As Byte
            Dim myMS As New IO.MemoryStream
            Dim da As New OleDbDataAdapter(("select * from staff where staffID ='" & pix & "'"), conn)

            Dim dt As New DataTable
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                If Not IsDBNull(dt.Rows(0).Item("photo")) Then
                    arrImage = dt.Rows(0).Item("photo")
                    For Each ar As Byte In arrImage
                        myMS.WriteByte(ar)
                    Next
                    Me.staffpic.Image = System.Drawing.Image.FromStream(myMS)
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub
    Private Sub dgw_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgw.CellClick
        BindToText()
    End Sub
    Private Sub dgw_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgw.SelectionChanged
        BindToText()
        Staffpix()
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        TxtSearch.Visible = True
        SearchClose.Visible = True
        COMSearchBy.Visible = True
    End Sub

    Private Sub TxtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtSearch.TextChanged
        ConnDB()
        If COMSearchBy.SelectedIndex = 0 Then
            Try
                sqL = "SELECT * FROM staff WHERE staffname LIKE '" & TxtSearch.Text & "%'"
                ConnDB()
                cmd = New OleDbCommand(sqL, conn)
                dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
                dgw.Rows.Clear()
                Do While dr.Read = True
                    dgw.Rows.Add(dr(0), dr(1), dr(2), dr(3), dr(4), dr(5), dr(6))
                Loop
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                cmd.Dispose()
                conn.Close()
            End Try
        Else
            Try
                sqL = "SELECT * FROM staff WHERE staffID LIKE '" & TxtSearch.Text & "%'"
                ConnDB()
                cmd = New OleDbCommand(sqL, conn)
                dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
                dgw.Rows.Clear()
                Do While dr.Read = True
                    dgw.Rows.Add(dr(0), dr(1), dr(2), dr(3), dr(4), dr(5), dr(6))
                Loop
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                cmd.Dispose()
                conn.Close()
            End Try
        End If
    End Sub
    Private Sub SearchClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchClose.Click
        TxtSearch.Visible = False
        COMSearchBy.Visible = False
        SearchClose.Visible = False
    End Sub
    Private Sub searchclose1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles searchclose1.Click
        txtsearch1.Visible = False
        Comsearch1.Visible = False
        searchclose1.Visible = False
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        txtsearch1.Visible = True
        Comsearch1.Visible = True
        searchclose1.Visible = True
    End Sub

    Private Sub txtsearch1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtsearch1.TextChanged
        ConnDB()
        If Comsearch1.SelectedIndex = 0 Then
            Try
                sqL = "SELECT * FROM product WHERE productID LIKE '" & txtsearch1.Text & "%'"
                ConnDB()
                cmd = New OleDbCommand(sqL, conn)
                dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
                dgw1.Rows.Clear()
                Do While dr.Read = True
                    dgw1.Rows.Add(dr(0), dr(1), dr(2), dr(3))
                Loop
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                cmd.Dispose()
                conn.Close()
            End Try
        End If
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        txtsearch2.Visible = True
        Comsearch2.Visible = True
        searchclose2.Visible = True
    End Sub
    Private Sub searchclose2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles searchclose2.Click
        txtsearch2.Visible = False
        Comsearch2.Visible = False
        searchclose2.Visible = False
    End Sub

    Private Sub txtsearch2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtsearch2.TextChanged
        ConnDB()
        If Comsearch2.SelectedIndex = 0 Then
            Try
                sqL = "SELECT * FROM transactionDetails WHERE transactionID LIKE '" & txtsearch2.Text & "%'"
                ConnDB()
                cmd = New OleDbCommand(sqL, conn)
                dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
                dgw2.Rows.Clear()
                Do While dr.Read = True
                    dgw2.Rows.Add(dr(0), dr(1), dr(2), dr(3), dr(4), dr(5), dr(6), dr(7))
                Loop
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                cmd.Dispose()
                conn.Close()
            End Try
        Else
            Try
                sqL = "SELECT * FROM transactionDetails WHERE transactiondate LIKE '" & txtsearch2.Text & "%' ORDER By transactiondate "
                ConnDB()
                cmd = New OleDbCommand(sqL, conn)
                dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
                dgw2.Rows.Clear()
                Do While dr.Read = True
                    dgw2.Rows.Add(dr(0), dr(1), dr(2), dr(3), dr(4), dr(5), dr(6), dr(7))
                Loop
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                cmd.Dispose()
                conn.Close()
            End Try
        End If
    End Sub

    Private Sub Comsearch1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Comsearch1.SelectedIndexChanged

    End Sub
End Class
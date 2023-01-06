Imports System.Data.OleDb

Public Class addproduct
    Private Sub Addproduct()
        Try
            sqL = "INSERT INTO product VALUES('" & txtproductID.Text & "', '" & txtproductName.Text & "', '" & txtmanuf.Text & "', '" & txtprice.Text & "', '" & "0" & "')"
            ConnDB()
            cmd = New OleDbCommand(sqL, conn)
            Dim i As Integer
            i = cmd.ExecuteNonQuery
            If i > 0 Then
                MsgBox("Product Added Successfully", MsgBoxStyle.Information, "Add Product")
            Else
                MsgBox("Failed in Adding Product", MsgBoxStyle.Information, "Add Product")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cmd.Dispose()
            conn.Close()
        End Try
    End Sub
    Private Sub Updateproduct()
        Try
            sqL = "UPDATE product SET productname = '" & txtproductName.Text & "', man_company = '" & txtmanuf.Text & "', unitprice = '" & txtprice.Text & "' WHERE productID = '" & txtproductID.Text & "'"
            ConnDB()
            cmd = New OleDbCommand(sqL, conn)
            Dim i As Integer
            i = cmd.ExecuteNonQuery
            If i > 0 Then
                MsgBox("Product Successfully Updated", MsgBoxStyle.Information, "Update product")
            Else
                MsgBox("Failed in Updating product", MsgBoxStyle.Information, "Update product")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cmd.Dispose()
            conn.Close()
        End Try
    End Sub
    Private Sub Searchproduct()
        Dim strSearch As String
        strSearch = InputBox("Enter product Name : ", "Search Product")
        Try
            sqL = "SELECT * FROM product WHERE productname LIKE '" & strSearch & "%'"
            ConnDB()
            cmd = New OleDbCommand(sqL, conn)
            dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            ' dgw.Rows.Clear()
            Do While dr.Read = True
                ' dgw.Rows.Add(dr(0), dr(1), dr(2), dr(3), dr(4))
                txtmanuf.Text = dr(2)
                txtprice.Text = dr(3)
                txtproductID.Text = dr(0)
                txtproductName.Text = dr(1)
            Loop
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cmd.Dispose()
            conn.Close()
        End Try
    End Sub
    Private Sub Deleteproduct()
        Try
            sqL = "DELETE * FROM product WHERE productID = '" & txtproductID.Text & "'"
            ConnDB()
            cmd = New OleDbCommand(sqL, conn)
            dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            Do While dr.Read = True
                'dgw.Rows.Add(dr(0), dr(1), dr(2), dr(3), dr(4))
                MsgBox("product successfully Deleted")

            Loop
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cmd.Dispose()
            conn.Close()
        End Try
    End Sub
    Private Sub clear()
        txtmanuf.Text = ""
        txtproductName.Text = ""
        txtprice.Text = ""
    End Sub
    Private Sub getproductID()
        Try
            Dim productID As New Random
            Dim numbers As Integer = productID.Next(1, 10000)
            Dim digitss As String = numbers.ToString("0000")
            txtproductID.Text = "P" & digitss
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub addproduct_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Left = (Screen.PrimaryScreen.WorkingArea.Width - Me.Width) / 2
        Me.Top = (Screen.PrimaryScreen.WorkingArea.Height - Me.Height) / 2
        getproductID()
    End Sub
    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        If txtproductName.Text = "" Then
            MsgBox("Please fill-in product Name field", MsgBoxStyle.Information, "Validation")
            txtproductName.Focus()
            Exit Sub
        ElseIf txtmanuf.Text = "" Then
            MsgBox("Please fill-in Manufacturing Company field", MsgBoxStyle.Information, "Validation")
            txtmanuf.Focus()
            Exit Sub
        ElseIf txtprice.Text = "" Then
            MsgBox("Please fill-in Price field", MsgBoxStyle.Information, "Validation")
            txtprice.Focus()
            Exit Sub
        End If
        Addproduct()
        clear()
        getproductID()
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Searchproduct()
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Updateproduct()
    End Sub
    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        Me.Close()
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If MsgBox("Are you sure you want to delete this product", MsgBoxStyle.YesNo, "Validation") = MsgBoxResult.Yes Then
            Deleteproduct()
            clear()
            txtproductID.Text = ""
        End If
    End Sub
    Private Sub btnclear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclear.Click
        clear()
    End Sub
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        clear()
        getproductID()
    End Sub
End Class
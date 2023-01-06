Imports System.Data.OleDb

Public Class adduser

    Private Sub changepin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Left = (Screen.PrimaryScreen.WorkingArea.Width - Me.Width) / 2
        Me.Top = (Screen.PrimaryScreen.WorkingArea.Height - Me.Height) / 2
        getstaffID()
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim OpenFile As New OpenFileDialog()
        Try
            With OpenFile
                .FileName = ""
                .Title = "Staff Image"
                .Filter = "Image file (*.jpg)|*.jpg|(*.jpeg)|*.jpeg"

                If .ShowDialog = Windows.Forms.DialogResult.OK Then
                    Me.staffpic.Image = System.Drawing.Bitmap.FromFile(.FileName)
                Else
                End If
            End With
        Catch ex As Exception
            MsgBox(ex.Message())
        End Try
    End Sub
    Private Sub addstaff()
        Try
            Dim cn As New OleDbConnection
            cn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & System.Environment.CurrentDirectory & "\beer.mdb"
            cn.Open()

            Dim arrImage() As Byte
            Dim strImage As String
            Dim myMs As New IO.MemoryStream
            '
            If Not IsNothing(Me.staffpic.Image) Then
                Me.staffpic.Image.Save(myMs, Me.staffpic.Image.RawFormat)
                arrImage = myMs.GetBuffer
                strImage = "?"
            Else
                arrImage = Nothing
                strImage = "NULL"
            End If

            Dim cmd As New OleDbCommand
            cmd.Connection = cn
            cmd.CommandText = "INSERT INTO staff([staffID],[staffname],[datebirth],[phone],[address],[designation],[dateregistration],[username],[password],photo) " & _
                                      "VALUES('" & Me.txtstaffid.Text & "', " & _
                                       "'" & Me.txtname.Text & "', " & _
                                    "'" & Me.dateofbirth.Text & "', " & _
                                        "'" & Me.txtphone.Text & "', " & _
                                         "'" & Me.txtaddress.Text & "', " & _
                                       "'" & Me.txtdesignation.Text & "', " & _
                                      "'" & Now() & "', " & _
                                        "'" & Me.txtusername.Text & "', " & _
                                        "'" & Me.txtpassword.Text & "', " & _
                                         "" & strImage & ")"
            If strImage = "?" Then
                cmd.Parameters.Add(strImage, OleDbType.Binary).Value = arrImage
            End If
            MsgBox("Staff Info save successfully!")

            cmd.ExecuteNonQuery()
            cn.Close()
        Catch ex As Exception
        End Try
    End Sub
    Private Sub getstaffID()
        Try
            Dim staffID As New Random
            Dim numbers As Integer = staffID.Next(1, 100000)
            Dim digitss As String = numbers.ToString("00000")
            txtstaffid.Text = digitss
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub chkstaffusername()
        Try
            sqL = "SELECT username FROM staff WHERE  [username] = '" & Trim(txtusername.Text) & "'"
            ConnDB()
            cmd = New OleDbCommand(sqL, conn)
            dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            If dr.HasRows Then
                MsgBox("Username already exist, try another one")
            Else
                addstaff()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cmd.Dispose()
            conn.Close()
        End Try
    End Sub
    Private Sub cleartextbox()
        txtname.Text = ""
        txtphone.Text = ""
        txtaddress.Text = ""
        txtdesignation.Text = ""
        txtusername.Text = ""
        txtpassword.Text = ""
        txtpassword2.Text = ""
        cmdsex.Text = ""
    End Sub
    Private Sub btnclear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclear.Click
        cleartextbox()
        getstaffID()
    End Sub

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        If txtname.Text = "" Then
            MsgBox("Please fill-in Staff Name field", MsgBoxStyle.Information, "Validation")
            txtname.Focus()
            Exit Sub
        ElseIf cmdsex.Text = "" Then
            MsgBox("Please fill-in Sex field", MsgBoxStyle.Information, "Validation")
            txtphone.Focus()
            Exit Sub
        ElseIf txtphone.Text = "" Then
            MsgBox("Please fill-in Phone Number field", MsgBoxStyle.Information, "Validation")
            txtphone.Focus()
            Exit Sub
        ElseIf txtaddress.Text = "" Then
            MsgBox("Please fill-in Address field", MsgBoxStyle.Information, "Validation")
            txtaddress.Focus()
            Exit Sub
        ElseIf txtdesignation.Text = "" Then
            MsgBox("Please fill-in Staff Designation field", MsgBoxStyle.Information, "Validation")
            txtdesignation.Focus()
            Exit Sub
        ElseIf txtusername.Text = "" Then
            MsgBox("Please fill-in Username field", MsgBoxStyle.Information, "Validation")
            txtusername.Focus()
            Exit Sub
        ElseIf txtpassword.Text = "" Then
            MsgBox("Please fill-in Password field", MsgBoxStyle.Information, "Validation")
            txtpassword.Focus()
            Exit Sub
        End If

        If txtpassword.Text <> txtpassword2.Text Then
            MsgBox("Two password fields are not compatitble!")
        ElseIf txtpassword.TextLength < 6 Then
            MsgBox("password lenght should be less than 6 !")
        Else
            chkstaffusername()
        End If
    End Sub

    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        Me.Close()
    End Sub
End Class
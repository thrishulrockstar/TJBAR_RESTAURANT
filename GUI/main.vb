Public Class main
    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuExit.Click
        Application.Exit()
    End Sub
    Private Sub BillingToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BillingToolStripMenuItem.Click
        billing.Show()
    End Sub
    Private Sub AddProductToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddProductToolStripMenuItem.Click
        addproduct.Show()
    End Sub
    Private Sub AddUsersToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddUsersToolStripMenuItem.Click
        adduser.Show()
    End Sub
    Private Sub ExitToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toolmenuexit.Click
        Application.Exit()
    End Sub
    Private Sub NotepadToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NotepadToolStripMenuItem.Click
        Try
            System.Diagnostics.Process.Start("Notepad.exe")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub MsWordToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MsWordToolStripMenuItem.Click
        Try
            System.Diagnostics.Process.Start("winword.exe")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub CalculatorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CalculatorToolStripMenuItem.Click
        Try
            System.Diagnostics.Process.Start("calc.exe")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub DatabaseToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DatabaseToolStripMenuItem.Click
        Database.Show()
    End Sub
    Private Sub LogOutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toolmenulogout.Click
        menuExit.Enabled = False
        menuTool.Enabled = False
        menuTransactions.Enabled = False
        menuuser.Enabled = False
        menuview.Enabled = False
        toolmenuexit.Enabled = False
        toolmenulogout.Enabled = False
    End Sub

    Private Sub toolmenuLogIn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toolmenuLogIn.Click
        Login.Show()
    End Sub
End Class
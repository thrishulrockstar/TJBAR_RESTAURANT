<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class main
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(main))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.menufile = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolmenuLogIn = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolmenulogout = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolmenuexit = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuuser = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddUsersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuview = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddProductToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DatabaseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuTransactions = New System.Windows.Forms.ToolStripMenuItem()
        Me.BillingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuTool = New System.Windows.Forms.ToolStripMenuItem()
        Me.MsWordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NotepadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CalculatorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.Left
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menufile, Me.menuuser, Me.menuview, Me.menuTransactions, Me.menuTool, Me.menuExit})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(178, 508)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = Global.beerparlourbillingsystem.My.Resources.Resources.beer_icon
        Me.PictureBox1.Location = New System.Drawing.Point(178, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(781, 508)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'menufile
        '
        Me.menufile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolmenuLogIn, Me.toolmenulogout, Me.toolmenuexit})
        Me.menufile.Image = Global.beerparlourbillingsystem.My.Resources.Resources.canva_folder_file_yellow_document_info_icon__vector_graphic_MAB7OE9Jppw
        Me.menufile.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.menufile.Name = "menufile"
        Me.menufile.Size = New System.Drawing.Size(165, 79)
        Me.menufile.Text = "&File"
        '
        'toolmenuLogIn
        '
        Me.toolmenuLogIn.Name = "toolmenuLogIn"
        Me.toolmenuLogIn.Size = New System.Drawing.Size(124, 22)
        Me.toolmenuLogIn.Text = "Log In"
        '
        'toolmenulogout
        '
        Me.toolmenulogout.Name = "toolmenulogout"
        Me.toolmenulogout.Size = New System.Drawing.Size(124, 22)
        Me.toolmenulogout.Text = "Log out"
        '
        'toolmenuexit
        '
        Me.toolmenuexit.Name = "toolmenuexit"
        Me.toolmenuexit.Size = New System.Drawing.Size(124, 22)
        Me.toolmenuexit.Text = "&Exit"
        '
        'menuuser
        '
        Me.menuuser.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddUsersToolStripMenuItem})
        Me.menuuser.Image = Global.beerparlourbillingsystem.My.Resources.Resources.multiple_512
        Me.menuuser.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.menuuser.Name = "menuuser"
        Me.menuuser.Size = New System.Drawing.Size(165, 79)
        Me.menuuser.Text = "&Users"
        '
        'AddUsersToolStripMenuItem
        '
        Me.AddUsersToolStripMenuItem.Name = "AddUsersToolStripMenuItem"
        Me.AddUsersToolStripMenuItem.Size = New System.Drawing.Size(138, 22)
        Me.AddUsersToolStripMenuItem.Text = "Add Users"
        '
        'menuview
        '
        Me.menuview.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddProductToolStripMenuItem, Me.DatabaseToolStripMenuItem})
        Me.menuview.Image = Global.beerparlourbillingsystem.My.Resources.Resources.dbb
        Me.menuview.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.menuview.Name = "menuview"
        Me.menuview.Size = New System.Drawing.Size(165, 79)
        Me.menuview.Text = "&Views"
        '
        'AddProductToolStripMenuItem
        '
        Me.AddProductToolStripMenuItem.Name = "AddProductToolStripMenuItem"
        Me.AddProductToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.AddProductToolStripMenuItem.Text = "Add Product"
        '
        'DatabaseToolStripMenuItem
        '
        Me.DatabaseToolStripMenuItem.Name = "DatabaseToolStripMenuItem"
        Me.DatabaseToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.DatabaseToolStripMenuItem.Text = "&Database"
        '
        'menuTransactions
        '
        Me.menuTransactions.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BillingToolStripMenuItem})
        Me.menuTransactions.Image = Global.beerparlourbillingsystem.My.Resources.Resources._2912
        Me.menuTransactions.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.menuTransactions.Name = "menuTransactions"
        Me.menuTransactions.Size = New System.Drawing.Size(165, 79)
        Me.menuTransactions.Text = "&Transactions"
        '
        'BillingToolStripMenuItem
        '
        Me.BillingToolStripMenuItem.Name = "BillingToolStripMenuItem"
        Me.BillingToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.BillingToolStripMenuItem.Text = "&Billing"
        '
        'menuTool
        '
        Me.menuTool.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MsWordToolStripMenuItem, Me.NotepadToolStripMenuItem, Me.CalculatorToolStripMenuItem})
        Me.menuTool.Image = Global.beerparlourbillingsystem.My.Resources.Resources.tools
        Me.menuTool.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.menuTool.Name = "menuTool"
        Me.menuTool.Size = New System.Drawing.Size(165, 79)
        Me.menuTool.Text = "Tool"
        '
        'MsWordToolStripMenuItem
        '
        Me.MsWordToolStripMenuItem.Name = "MsWordToolStripMenuItem"
        Me.MsWordToolStripMenuItem.Size = New System.Drawing.Size(138, 22)
        Me.MsWordToolStripMenuItem.Text = "&Ms Word"
        '
        'NotepadToolStripMenuItem
        '
        Me.NotepadToolStripMenuItem.Name = "NotepadToolStripMenuItem"
        Me.NotepadToolStripMenuItem.Size = New System.Drawing.Size(138, 22)
        Me.NotepadToolStripMenuItem.Text = "&Notepad"
        '
        'CalculatorToolStripMenuItem
        '
        Me.CalculatorToolStripMenuItem.Name = "CalculatorToolStripMenuItem"
        Me.CalculatorToolStripMenuItem.Size = New System.Drawing.Size(138, 22)
        Me.CalculatorToolStripMenuItem.Text = "&Calculator"
        '
        'menuExit
        '
        Me.menuExit.Image = Global.beerparlourbillingsystem.My.Resources.Resources.logout
        Me.menuExit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.menuExit.Name = "menuExit"
        Me.menuExit.Size = New System.Drawing.Size(165, 54)
        Me.menuExit.Text = "&Exit"
        '
        'main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(959, 508)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "main"
        Me.Text = "BEER PARLOUR BILLING SYSTEM "
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents menufile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolmenuLogIn As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolmenulogout As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolmenuexit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuuser As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddUsersToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuview As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddProductToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuTransactions As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BillingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuTool As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MsWordToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NotepadToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CalculatorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents DatabaseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class

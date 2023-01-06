<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class billing
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(billing))
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnremove = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnload = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.dgw = New System.Windows.Forms.DataGridView()
        Me.productid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.drugname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.qty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.amt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Panel13 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txttotal = New System.Windows.Forms.TextBox()
        Me.txtproductame = New System.Windows.Forms.ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txttrans = New System.Windows.Forms.TextBox()
        Me.txtprice = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtproductID = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtQuantity = New System.Windows.Forms.TextBox()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.cmdpayment = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtBalance = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lblInvoice = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.txtAmtPaid = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Panel14 = New System.Windows.Forms.Panel()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnreceipt = New System.Windows.Forms.Button()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.lblTotalAmount = New System.Windows.Forms.Label()
        Me.lblSubTotal = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.lblTotalItems = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.dgw, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel13.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel10.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.Panel12.SuspendLayout()
        Me.Panel14.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.Panel11.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(15, 79)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(96, 23)
        Me.Button2.TabIndex = 306
        Me.Button2.Text = "Refresh "
        Me.Button2.UseVisualStyleBackColor = True
        '
        'btnremove
        '
        Me.btnremove.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnremove.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnremove.Location = New System.Drawing.Point(15, 50)
        Me.btnremove.Name = "btnremove"
        Me.btnremove.Size = New System.Drawing.Size(128, 23)
        Me.btnremove.TabIndex = 303
        Me.btnremove.Text = "&Remove Item"
        Me.btnremove.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnremove.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnload)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.btnremove)
        Me.GroupBox1.Location = New System.Drawing.Point(581, 122)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(149, 114)
        Me.GroupBox1.TabIndex = 307
        Me.GroupBox1.TabStop = False
        '
        'btnload
        '
        Me.btnload.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnload.Image = Global.beerparlourbillingsystem.My.Resources.Resources.images
        Me.btnload.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnload.Location = New System.Drawing.Point(15, 16)
        Me.btnload.Name = "btnload"
        Me.btnload.Size = New System.Drawing.Size(128, 28)
        Me.btnload.TabIndex = 3
        Me.btnload.Text = "&Add To Cart"
        Me.btnload.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnload.UseVisualStyleBackColor = True
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.DarkRed
        Me.Panel4.Controls.Add(Me.GroupBox1)
        Me.Panel4.Controls.Add(Me.dgw)
        Me.Panel4.Location = New System.Drawing.Point(14, 98)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(733, 370)
        Me.Panel4.TabIndex = 43
        '
        'dgw
        '
        Me.dgw.AllowUserToAddRows = False
        Me.dgw.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FloralWhite
        Me.dgw.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgw.BackgroundColor = System.Drawing.Color.White
        Me.dgw.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgw.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkRed
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightSteelBlue
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgw.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgw.ColumnHeadersHeight = 24
        Me.dgw.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.productid, Me.drugname, Me.qty, Me.price, Me.amt})
        Me.dgw.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dgw.EnableHeadersVisualStyles = False
        Me.dgw.GridColor = System.Drawing.Color.White
        Me.dgw.Location = New System.Drawing.Point(6, 76)
        Me.dgw.MultiSelect = False
        Me.dgw.Name = "dgw"
        Me.dgw.ReadOnly = True
        Me.dgw.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.NavajoWhite
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.DarkSalmon
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgw.RowHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dgw.RowHeadersWidth = 25
        Me.dgw.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.DarkSalmon
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White
        Me.dgw.RowsDefaultCellStyle = DataGridViewCellStyle6
        Me.dgw.RowTemplate.Height = 18
        Me.dgw.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgw.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgw.Size = New System.Drawing.Size(569, 258)
        Me.dgw.TabIndex = 42
        '
        'productid
        '
        Me.productid.HeaderText = "Product ID"
        Me.productid.Name = "productid"
        Me.productid.ReadOnly = True
        Me.productid.Width = 80
        '
        'drugname
        '
        Me.drugname.HeaderText = "Product Name"
        Me.drugname.Name = "drugname"
        Me.drugname.ReadOnly = True
        Me.drugname.Width = 230
        '
        'qty
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.qty.DefaultCellStyle = DataGridViewCellStyle3
        Me.qty.HeaderText = "Quantity"
        Me.qty.Name = "qty"
        Me.qty.ReadOnly = True
        Me.qty.Width = 65
        '
        'price
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.price.DefaultCellStyle = DataGridViewCellStyle4
        Me.price.HeaderText = "Price"
        Me.price.Name = "price"
        Me.price.ReadOnly = True
        Me.price.Width = 65
        '
        'amt
        '
        Me.amt.HeaderText = "Amount"
        Me.amt.Name = "amt"
        Me.amt.ReadOnly = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.White
        Me.Label12.Font = New System.Drawing.Font("Impact", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.DarkRed
        Me.Label12.Location = New System.Drawing.Point(302, 11)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(409, 43)
        Me.Label12.TabIndex = 1
        Me.Label12.Text = "Beer Parlour Billing System"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel13
        '
        Me.Panel13.BackColor = System.Drawing.Color.White
        Me.Panel13.Controls.Add(Me.Label12)
        Me.Panel13.Location = New System.Drawing.Point(10, 5)
        Me.Panel13.Name = "Panel13"
        Me.Panel13.Size = New System.Drawing.Size(1015, 67)
        Me.Panel13.TabIndex = 58
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel2.Controls.Add(Me.Panel13)
        Me.Panel2.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Panel2.Location = New System.Drawing.Point(7, 7)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1032, 86)
        Me.Panel2.TabIndex = 0
        '
        'Panel10
        '
        Me.Panel10.BackColor = System.Drawing.Color.DarkRed
        Me.Panel10.Controls.Add(Me.Label2)
        Me.Panel10.Controls.Add(Me.txttotal)
        Me.Panel10.Controls.Add(Me.txtproductame)
        Me.Panel10.Controls.Add(Me.Label15)
        Me.Panel10.Controls.Add(Me.txttrans)
        Me.Panel10.Controls.Add(Me.txtprice)
        Me.Panel10.Controls.Add(Me.Label10)
        Me.Panel10.Controls.Add(Me.txtproductID)
        Me.Panel10.Controls.Add(Me.Label3)
        Me.Panel10.Controls.Add(Me.Label4)
        Me.Panel10.Controls.Add(Me.Label1)
        Me.Panel10.Controls.Add(Me.txtQuantity)
        Me.Panel10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel10.ForeColor = System.Drawing.Color.White
        Me.Panel10.Location = New System.Drawing.Point(3, 5)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(606, 56)
        Me.Panel10.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(531, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 15)
        Me.Label2.TabIndex = 306
        Me.Label2.Text = "Total"
        '
        'txttotal
        '
        Me.txttotal.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txttotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttotal.ForeColor = System.Drawing.Color.Yellow
        Me.txttotal.Location = New System.Drawing.Point(534, 28)
        Me.txttotal.Name = "txttotal"
        Me.txttotal.Size = New System.Drawing.Size(59, 21)
        Me.txttotal.TabIndex = 305
        Me.txttotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtproductame
        '
        Me.txtproductame.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtproductame.FormattingEnabled = True
        Me.txtproductame.Location = New System.Drawing.Point(220, 28)
        Me.txtproductame.Name = "txtproductame"
        Me.txtproductame.Size = New System.Drawing.Size(172, 23)
        Me.txtproductame.TabIndex = 304
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Location = New System.Drawing.Point(3, 7)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(86, 15)
        Me.Label15.TabIndex = 28
        Me.Label15.Text = "Transaction ID"
        '
        'txttrans
        '
        Me.txttrans.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.txttrans.Location = New System.Drawing.Point(3, 28)
        Me.txttrans.Name = "txttrans"
        Me.txttrans.Size = New System.Drawing.Size(99, 21)
        Me.txttrans.TabIndex = 27
        '
        'txtprice
        '
        Me.txtprice.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtprice.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtprice.ForeColor = System.Drawing.Color.Yellow
        Me.txtprice.Location = New System.Drawing.Point(398, 28)
        Me.txtprice.Name = "txtprice"
        Me.txtprice.ReadOnly = True
        Me.txtprice.Size = New System.Drawing.Size(59, 21)
        Me.txtprice.TabIndex = 25
        Me.txtprice.Text = "0.00"
        Me.txtprice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Location = New System.Drawing.Point(108, 7)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(64, 15)
        Me.Label10.TabIndex = 23
        Me.Label10.Text = "Product ID"
        '
        'txtproductID
        '
        Me.txtproductID.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.txtproductID.Location = New System.Drawing.Point(108, 28)
        Me.txtproductID.Name = "txtproductID"
        Me.txtproductID.Size = New System.Drawing.Size(106, 21)
        Me.txtproductID.TabIndex = 22
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(221, 7)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 15)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Products Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(397, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 15)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Price"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(462, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 15)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Quantity(s)"
        '
        'txtQuantity
        '
        Me.txtQuantity.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtQuantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQuantity.ForeColor = System.Drawing.Color.Yellow
        Me.txtQuantity.Location = New System.Drawing.Point(465, 28)
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.Size = New System.Drawing.Size(59, 21)
        Me.txtQuantity.TabIndex = 2
        Me.txtQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel9.Controls.Add(Me.Panel10)
        Me.Panel9.Location = New System.Drawing.Point(20, 104)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(617, 64)
        Me.Panel9.TabIndex = 1
        '
        'cmdpayment
        '
        Me.cmdpayment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmdpayment.FormattingEnabled = True
        Me.cmdpayment.Items.AddRange(New Object() {"Cash", "Credit"})
        Me.cmdpayment.Location = New System.Drawing.Point(116, 46)
        Me.cmdpayment.Name = "cmdpayment"
        Me.cmdpayment.Size = New System.Drawing.Size(142, 23)
        Me.cmdpayment.TabIndex = 5
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.White
        Me.Label13.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(4, 48)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(110, 16)
        Me.Label13.TabIndex = 303
        Me.Label13.Text = "Payment Option"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.White
        Me.Label14.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(5, 72)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(81, 16)
        Me.Label14.TabIndex = 301
        Me.Label14.Text = "Balance (N)"
        '
        'txtBalance
        '
        Me.txtBalance.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtBalance.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBalance.ForeColor = System.Drawing.Color.Gold
        Me.txtBalance.Location = New System.Drawing.Point(116, 71)
        Me.txtBalance.Name = "txtBalance"
        Me.txtBalance.ReadOnly = True
        Me.txtBalance.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtBalance.Size = New System.Drawing.Size(142, 22)
        Me.txtBalance.TabIndex = 300
        Me.txtBalance.TabStop = False
        Me.txtBalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.White
        Me.Label11.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(3, 26)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(111, 16)
        Me.Label11.TabIndex = 299
        Me.Label11.Text = "Amount Paid (N)"
        '
        'lblInvoice
        '
        Me.lblInvoice.BackColor = System.Drawing.Color.Transparent
        Me.lblInvoice.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInvoice.ForeColor = System.Drawing.Color.White
        Me.lblInvoice.Location = New System.Drawing.Point(105, 16)
        Me.lblInvoice.Name = "lblInvoice"
        Me.lblInvoice.Size = New System.Drawing.Size(150, 26)
        Me.lblInvoice.TabIndex = 2
        Me.lblInvoice.Text = "INV-38846828"
        Me.lblInvoice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Impact", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(1, 14)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(109, 26)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Invoice No :"
        '
        'Panel12
        '
        Me.Panel12.BackColor = System.Drawing.Color.DarkRed
        Me.Panel12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel12.Controls.Add(Me.lblInvoice)
        Me.Panel12.Controls.Add(Me.Label6)
        Me.Panel12.Location = New System.Drawing.Point(5, 5)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(262, 54)
        Me.Panel12.TabIndex = 0
        '
        'txtAmtPaid
        '
        Me.txtAmtPaid.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtAmtPaid.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAmtPaid.ForeColor = System.Drawing.Color.Gold
        Me.txtAmtPaid.Location = New System.Drawing.Point(116, 22)
        Me.txtAmtPaid.Name = "txtAmtPaid"
        Me.txtAmtPaid.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtAmtPaid.Size = New System.Drawing.Size(143, 22)
        Me.txtAmtPaid.TabIndex = 4
        Me.txtAmtPaid.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(5, 3)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(139, 15)
        Me.Label22.TabIndex = 7
        Me.Label22.Text = "Payment Information"
        '
        'Panel14
        '
        Me.Panel14.BackColor = System.Drawing.SystemColors.Info
        Me.Panel14.Controls.Add(Me.cmdpayment)
        Me.Panel14.Controls.Add(Me.Label13)
        Me.Panel14.Controls.Add(Me.Label14)
        Me.Panel14.Controls.Add(Me.txtBalance)
        Me.Panel14.Controls.Add(Me.Label11)
        Me.Panel14.Controls.Add(Me.txtAmtPaid)
        Me.Panel14.Controls.Add(Me.Label22)
        Me.Panel14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel14.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Panel14.Location = New System.Drawing.Point(7, 8)
        Me.Panel14.Name = "Panel14"
        Me.Panel14.Size = New System.Drawing.Size(262, 104)
        Me.Panel14.TabIndex = 2
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.DarkRed
        Me.Panel8.Controls.Add(Me.Panel14)
        Me.Panel8.Location = New System.Drawing.Point(764, 347)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(275, 121)
        Me.Panel8.TabIndex = 50
        '
        'Panel11
        '
        Me.Panel11.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel11.Controls.Add(Me.Panel12)
        Me.Panel11.Location = New System.Drawing.Point(764, 96)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(272, 64)
        Me.Panel11.TabIndex = 49
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Panel8)
        Me.Panel1.Controls.Add(Me.btnreceipt)
        Me.Panel1.Controls.Add(Me.btnsave)
        Me.Panel1.Controls.Add(Me.Panel11)
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.Panel9)
        Me.Panel1.Controls.Add(Me.Panel5)
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Location = New System.Drawing.Point(13, 14)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1057, 521)
        Me.Panel1.TabIndex = 53
        '
        'btnreceipt
        '
        Me.btnreceipt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnreceipt.Image = Global.beerparlourbillingsystem.My.Resources.Resources.kwrite
        Me.btnreceipt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnreceipt.Location = New System.Drawing.Point(97, 476)
        Me.btnreceipt.Name = "btnreceipt"
        Me.btnreceipt.Size = New System.Drawing.Size(127, 33)
        Me.btnreceipt.TabIndex = 7
        Me.btnreceipt.Text = "Generate receipt"
        Me.btnreceipt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnreceipt.UseVisualStyleBackColor = True
        Me.btnreceipt.Visible = False
        '
        'btnsave
        '
        Me.btnsave.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsave.Image = Global.beerparlourbillingsystem.My.Resources.Resources.Add_1
        Me.btnsave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnsave.Location = New System.Drawing.Point(15, 476)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(76, 33)
        Me.btnsave.TabIndex = 6
        Me.btnsave.Text = "&Save"
        Me.btnsave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Image = Global.beerparlourbillingsystem.My.Resources.Resources.close
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.Location = New System.Drawing.Point(231, 476)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(67, 33)
        Me.Button3.TabIndex = 49
        Me.Button3.Text = "E&xit"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.DarkRed
        Me.Panel5.Controls.Add(Me.Panel7)
        Me.Panel5.Location = New System.Drawing.Point(764, 174)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(274, 160)
        Me.Panel5.TabIndex = 46
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.SystemColors.Info
        Me.Panel7.Controls.Add(Me.lblTotalAmount)
        Me.Panel7.Controls.Add(Me.lblSubTotal)
        Me.Panel7.Controls.Add(Me.Label20)
        Me.Panel7.Controls.Add(Me.lblTotalItems)
        Me.Panel7.Controls.Add(Me.Label17)
        Me.Panel7.Controls.Add(Me.Label18)
        Me.Panel7.Controls.Add(Me.Label19)
        Me.Panel7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel7.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Panel7.Location = New System.Drawing.Point(7, 8)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(262, 140)
        Me.Panel7.TabIndex = 0
        '
        'lblTotalAmount
        '
        Me.lblTotalAmount.BackColor = System.Drawing.Color.Black
        Me.lblTotalAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotalAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalAmount.ForeColor = System.Drawing.Color.Yellow
        Me.lblTotalAmount.Location = New System.Drawing.Point(116, 81)
        Me.lblTotalAmount.Name = "lblTotalAmount"
        Me.lblTotalAmount.Size = New System.Drawing.Size(133, 30)
        Me.lblTotalAmount.TabIndex = 10
        Me.lblTotalAmount.Text = "0.00"
        Me.lblTotalAmount.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblSubTotal
        '
        Me.lblSubTotal.BackColor = System.Drawing.Color.Black
        Me.lblSubTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSubTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubTotal.ForeColor = System.Drawing.Color.Yellow
        Me.lblSubTotal.Location = New System.Drawing.Point(130, 58)
        Me.lblSubTotal.Name = "lblSubTotal"
        Me.lblSubTotal.Size = New System.Drawing.Size(118, 20)
        Me.lblSubTotal.TabIndex = 10
        Me.lblSubTotal.Text = "0.00"
        Me.lblSubTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(1, 89)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(119, 15)
        Me.Label20.TabIndex = 9
        Me.Label20.Text = "Total Amount(N) :"
        '
        'lblTotalItems
        '
        Me.lblTotalItems.BackColor = System.Drawing.Color.Black
        Me.lblTotalItems.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotalItems.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalItems.ForeColor = System.Drawing.Color.Yellow
        Me.lblTotalItems.Location = New System.Drawing.Point(130, 34)
        Me.lblTotalItems.Name = "lblTotalItems"
        Me.lblTotalItems.Size = New System.Drawing.Size(118, 20)
        Me.lblTotalItems.TabIndex = 11
        Me.lblTotalItems.Text = "0"
        Me.lblTotalItems.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(10, 58)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(82, 15)
        Me.Label17.TabIndex = 9
        Me.Label17.Text = "Sub Total (N):"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(10, 35)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(73, 15)
        Me.Label18.TabIndex = 8
        Me.Label18.Text = "Total Items :"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(5, 3)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(125, 15)
        Me.Label19.TabIndex = 7
        Me.Label19.Text = "Billing Information"
        '
        'billing
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkRed
        Me.ClientSize = New System.Drawing.Size(1085, 549)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "billing"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Point of Sale (BEER PARLOUR BILLING SYSTEM "
        Me.GroupBox1.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        CType(Me.dgw, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel13.ResumeLayout(False)
        Me.Panel13.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel10.ResumeLayout(False)
        Me.Panel10.PerformLayout()
        Me.Panel9.ResumeLayout(False)
        Me.Panel12.ResumeLayout(False)
        Me.Panel12.PerformLayout()
        Me.Panel14.ResumeLayout(False)
        Me.Panel14.PerformLayout()
        Me.Panel8.ResumeLayout(False)
        Me.Panel11.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnload As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents btnremove As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents btnreceipt As System.Windows.Forms.Button
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents dgw As System.Windows.Forms.DataGridView
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Panel13 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel10 As System.Windows.Forms.Panel
    Friend WithEvents txtproductame As System.Windows.Forms.ComboBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txttrans As System.Windows.Forms.TextBox
    Friend WithEvents txtprice As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtproductID As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtQuantity As System.Windows.Forms.TextBox
    Friend WithEvents Panel9 As System.Windows.Forms.Panel
    Friend WithEvents cmdpayment As System.Windows.Forms.ComboBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtBalance As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents lblInvoice As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Panel12 As System.Windows.Forms.Panel
    Friend WithEvents txtAmtPaid As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Panel14 As System.Windows.Forms.Panel
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents Panel11 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents lblTotalAmount As System.Windows.Forms.Label
    Friend WithEvents lblSubTotal As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents lblTotalItems As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txttotal As System.Windows.Forms.TextBox
    Friend WithEvents productid As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents drugname As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents qty As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents price As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents amt As System.Windows.Forms.DataGridViewTextBoxColumn
End Class

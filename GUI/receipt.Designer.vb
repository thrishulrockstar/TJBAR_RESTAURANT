<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class receipt
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
        Dim DataGridViewCellStyle25 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle26 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle31 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle32 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle27 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle28 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle29 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle30 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.btnprint = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnexit = New System.Windows.Forms.Button()
        Me.lblThank = New System.Windows.Forms.Label()
        Me.lblOR = New System.Windows.Forms.Label()
        Me.lblbalance = New System.Windows.Forms.Label()
        Me.lblCash = New System.Windows.Forms.Label()
        Me.change = New System.Windows.Forms.Label()
        Me.Cash = New System.Windows.Forms.Label()
        Me.ibltotal = New System.Windows.Forms.Label()
        Me.TotalAmount = New System.Windows.Forms.Label()
        Me.dgw = New System.Windows.Forms.DataGridView()
        Me.ItemQuantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Description = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UnitPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ibltime = New System.Windows.Forms.Label()
        Me.lblEmpName = New System.Windows.Forms.Label()
        Me.ibldate = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblInvoice = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblLine = New System.Windows.Forms.Label()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.Panel1.SuspendLayout()
        CType(Me.dgw, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'btnprint
        '
        Me.btnprint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnprint.Location = New System.Drawing.Point(129, 372)
        Me.btnprint.Name = "btnprint"
        Me.btnprint.Size = New System.Drawing.Size(86, 22)
        Me.btnprint.TabIndex = 307
        Me.btnprint.Text = "Print"
        Me.btnprint.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.btnprint)
        Me.Panel1.Controls.Add(Me.btnexit)
        Me.Panel1.Controls.Add(Me.lblThank)
        Me.Panel1.Controls.Add(Me.lblOR)
        Me.Panel1.Controls.Add(Me.lblbalance)
        Me.Panel1.Controls.Add(Me.lblCash)
        Me.Panel1.Controls.Add(Me.change)
        Me.Panel1.Controls.Add(Me.Cash)
        Me.Panel1.Controls.Add(Me.ibltotal)
        Me.Panel1.Controls.Add(Me.TotalAmount)
        Me.Panel1.Controls.Add(Me.dgw)
        Me.Panel1.Controls.Add(Me.ibltime)
        Me.Panel1.Controls.Add(Me.lblEmpName)
        Me.Panel1.Controls.Add(Me.ibldate)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.lblInvoice)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.lblLine)
        Me.Panel1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(17, 15)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(383, 405)
        Me.Panel1.TabIndex = 2
        '
        'btnexit
        '
        Me.btnexit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnexit.Location = New System.Drawing.Point(223, 372)
        Me.btnexit.Name = "btnexit"
        Me.btnexit.Size = New System.Drawing.Size(60, 22)
        Me.btnexit.TabIndex = 306
        Me.btnexit.Text = "E&xit"
        Me.btnexit.UseVisualStyleBackColor = True
        '
        'lblThank
        '
        Me.lblThank.AutoSize = True
        Me.lblThank.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblThank.Location = New System.Drawing.Point(122, 333)
        Me.lblThank.Name = "lblThank"
        Me.lblThank.Size = New System.Drawing.Size(160, 13)
        Me.lblThank.TabIndex = 45
        Me.lblThank.Text = "Thank You Come Again!"
        '
        'lblOR
        '
        Me.lblOR.AutoSize = True
        Me.lblOR.Location = New System.Drawing.Point(106, 311)
        Me.lblOR.Name = "lblOR"
        Me.lblOR.Size = New System.Drawing.Size(200, 13)
        Me.lblOR.TabIndex = 45
        Me.lblOR.Text = "THIS IS YOUR OFFICIAL RECEPIT"
        '
        'lblbalance
        '
        Me.lblbalance.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblbalance.Location = New System.Drawing.Point(263, 252)
        Me.lblbalance.Name = "lblbalance"
        Me.lblbalance.Size = New System.Drawing.Size(80, 16)
        Me.lblbalance.TabIndex = 42
        Me.lblbalance.Text = "0.00"
        Me.lblbalance.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblCash
        '
        Me.lblCash.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCash.Location = New System.Drawing.Point(263, 230)
        Me.lblCash.Name = "lblCash"
        Me.lblCash.Size = New System.Drawing.Size(80, 15)
        Me.lblCash.TabIndex = 42
        Me.lblCash.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'change
        '
        Me.change.AutoSize = True
        Me.change.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.change.Location = New System.Drawing.Point(63, 252)
        Me.change.Name = "change"
        Me.change.Size = New System.Drawing.Size(97, 18)
        Me.change.TabIndex = 43
        Me.change.Text = "Balance    :"
        '
        'Cash
        '
        Me.Cash.AutoSize = True
        Me.Cash.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cash.Location = New System.Drawing.Point(63, 230)
        Me.Cash.Name = "Cash"
        Me.Cash.Size = New System.Drawing.Size(105, 13)
        Me.Cash.TabIndex = 43
        Me.Cash.Text = "Cash Paid         :"
        '
        'ibltotal
        '
        Me.ibltotal.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ibltotal.Location = New System.Drawing.Point(263, 210)
        Me.ibltotal.Name = "ibltotal"
        Me.ibltotal.Size = New System.Drawing.Size(80, 13)
        Me.ibltotal.TabIndex = 40
        Me.ibltotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TotalAmount
        '
        Me.TotalAmount.AutoSize = True
        Me.TotalAmount.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalAmount.Location = New System.Drawing.Point(63, 210)
        Me.TotalAmount.Name = "TotalAmount"
        Me.TotalAmount.Size = New System.Drawing.Size(119, 13)
        Me.TotalAmount.TabIndex = 41
        Me.TotalAmount.Text = "Total Amount Due :"
        '
        'dgw
        '
        Me.dgw.AllowUserToAddRows = False
        Me.dgw.AllowUserToDeleteRows = False
        DataGridViewCellStyle25.BackColor = System.Drawing.Color.White
        Me.dgw.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle25
        Me.dgw.BackgroundColor = System.Drawing.Color.White
        Me.dgw.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgw.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle26.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle26.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle26.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle26.SelectionBackColor = System.Drawing.Color.LightSteelBlue
        DataGridViewCellStyle26.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle26.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgw.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle26
        Me.dgw.ColumnHeadersHeight = 24
        Me.dgw.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ItemQuantity, Me.Description, Me.UnitPrice, Me.Column1})
        Me.dgw.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dgw.EnableHeadersVisualStyles = False
        Me.dgw.GridColor = System.Drawing.Color.White
        Me.dgw.Location = New System.Drawing.Point(51, 137)
        Me.dgw.MultiSelect = False
        Me.dgw.Name = "dgw"
        Me.dgw.ReadOnly = True
        Me.dgw.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle31.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle31.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle31.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle31.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle31.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle31.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle31.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgw.RowHeadersDefaultCellStyle = DataGridViewCellStyle31
        Me.dgw.RowHeadersWidth = 25
        Me.dgw.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle32.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle32.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle32.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle32.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle32.SelectionForeColor = System.Drawing.Color.Black
        Me.dgw.RowsDefaultCellStyle = DataGridViewCellStyle32
        Me.dgw.RowTemplate.Height = 18
        Me.dgw.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgw.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgw.Size = New System.Drawing.Size(294, 70)
        Me.dgw.TabIndex = 39
        '
        'ItemQuantity
        '
        DataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.ItemQuantity.DefaultCellStyle = DataGridViewCellStyle27
        Me.ItemQuantity.FillWeight = 7.575758!
        Me.ItemQuantity.HeaderText = "Qty"
        Me.ItemQuantity.Name = "ItemQuantity"
        Me.ItemQuantity.ReadOnly = True
        Me.ItemQuantity.Width = 30
        '
        'Description
        '
        DataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Description.DefaultCellStyle = DataGridViewCellStyle28
        Me.Description.FillWeight = 69.97607!
        Me.Description.HeaderText = "Items"
        Me.Description.Name = "Description"
        Me.Description.ReadOnly = True
        Me.Description.Width = 130
        '
        'UnitPrice
        '
        DataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle29.Format = "#,##0.00"
        DataGridViewCellStyle29.NullValue = Nothing
        Me.UnitPrice.DefaultCellStyle = DataGridViewCellStyle29
        Me.UnitPrice.FillWeight = 131.1945!
        Me.UnitPrice.HeaderText = "Price"
        Me.UnitPrice.Name = "UnitPrice"
        Me.UnitPrice.ReadOnly = True
        Me.UnitPrice.Width = 50
        '
        'Column1
        '
        DataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Column1.DefaultCellStyle = DataGridViewCellStyle30
        Me.Column1.HeaderText = "Total"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 50
        '
        'ibltime
        '
        Me.ibltime.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ibltime.Location = New System.Drawing.Point(250, 113)
        Me.ibltime.Name = "ibltime"
        Me.ibltime.Size = New System.Drawing.Size(93, 13)
        Me.ibltime.TabIndex = 1
        Me.ibltime.Text = "Time"
        Me.ibltime.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblEmpName
        '
        Me.lblEmpName.AutoSize = True
        Me.lblEmpName.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmpName.Location = New System.Drawing.Point(141, 113)
        Me.lblEmpName.Name = "lblEmpName"
        Me.lblEmpName.Size = New System.Drawing.Size(42, 15)
        Me.lblEmpName.TabIndex = 1
        Me.lblEmpName.Text = "Admin"
        '
        'ibldate
        '
        Me.ibldate.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ibldate.Location = New System.Drawing.Point(237, 98)
        Me.ibldate.Name = "ibldate"
        Me.ibldate.Size = New System.Drawing.Size(103, 13)
        Me.ibldate.TabIndex = 1
        Me.ibldate.Text = "Date"
        Me.ibldate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(64, 113)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(60, 13)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Cashier :"
        '
        'lblInvoice
        '
        Me.lblInvoice.AutoSize = True
        Me.lblInvoice.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInvoice.Location = New System.Drawing.Point(141, 98)
        Me.lblInvoice.Name = "lblInvoice"
        Me.lblInvoice.Size = New System.Drawing.Size(56, 15)
        Me.lblInvoice.TabIndex = 1
        Me.lblInvoice.Text = "Invoice"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(64, 98)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Invoice No :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(117, 52)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(160, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Contact No : 08067236311"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(116, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(173, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Akwa Ibom State, Nigeria"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(90, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(239, 14)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Villa park Garden City, Ikot Ekpene"
        '
        'lblLine
        '
        Me.lblLine.AutoSize = True
        Me.lblLine.Location = New System.Drawing.Point(64, 271)
        Me.lblLine.Name = "lblLine"
        Me.lblLine.Size = New System.Drawing.Size(277, 13)
        Me.lblLine.TabIndex = 44
        Me.lblLine.Text = "=============================="
        '
        'PrintDocument1
        '
        '
        'receipt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(418, 440)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "receipt"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgw, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
    Friend WithEvents btnprint As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnexit As System.Windows.Forms.Button
    Friend WithEvents lblThank As System.Windows.Forms.Label
    Friend WithEvents lblOR As System.Windows.Forms.Label
    Friend WithEvents lblbalance As System.Windows.Forms.Label
    Friend WithEvents lblCash As System.Windows.Forms.Label
    Friend WithEvents change As System.Windows.Forms.Label
    Friend WithEvents Cash As System.Windows.Forms.Label
    Friend WithEvents ibltotal As System.Windows.Forms.Label
    Friend WithEvents TotalAmount As System.Windows.Forms.Label
    Friend WithEvents dgw As System.Windows.Forms.DataGridView
    Friend WithEvents ItemQuantity As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Description As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UnitPrice As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ibltime As System.Windows.Forms.Label
    Friend WithEvents lblEmpName As System.Windows.Forms.Label
    Friend WithEvents ibldate As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblInvoice As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblLine As System.Windows.Forms.Label
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
End Class

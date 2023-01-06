<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class adduser
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(adduser))
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnclear = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btncancel = New System.Windows.Forms.Button()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.txtpassword2 = New System.Windows.Forms.TextBox()
        Me.txtpassword = New System.Windows.Forms.TextBox()
        Me.txtusername = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtdesignation = New System.Windows.Forms.TextBox()
        Me.txtaddress = New System.Windows.Forms.TextBox()
        Me.txtphone = New System.Windows.Forms.TextBox()
        Me.txtname = New System.Windows.Forms.TextBox()
        Me.txtstaffid = New System.Windows.Forms.TextBox()
        Me.dateofbirth = New System.Windows.Forms.DateTimePicker()
        Me.cmdsex = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.staffpic = New System.Windows.Forms.PictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.staffpic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(47, 101)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Fullname"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(47, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Staff ID"
        '
        'btnclear
        '
        Me.btnclear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnclear.Location = New System.Drawing.Point(103, 7)
        Me.btnclear.Name = "btnclear"
        Me.btnclear.Size = New System.Drawing.Size(82, 23)
        Me.btnclear.TabIndex = 19
        Me.btnclear.Text = "Clear"
        Me.btnclear.UseVisualStyleBackColor = True
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.btncancel)
        Me.Panel4.Controls.Add(Me.btnclear)
        Me.Panel4.Controls.Add(Me.btnsave)
        Me.Panel4.Location = New System.Drawing.Point(10, 438)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(322, 39)
        Me.Panel4.TabIndex = 3
        '
        'btncancel
        '
        Me.btncancel.BackColor = System.Drawing.Color.White
        Me.btncancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btncancel.Image = CType(resources.GetObject("btncancel.Image"), System.Drawing.Image)
        Me.btncancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btncancel.Location = New System.Drawing.Point(191, 7)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(82, 23)
        Me.btncancel.TabIndex = 60
        Me.btncancel.Text = "   &Cancel"
        Me.btncancel.UseVisualStyleBackColor = False
        '
        'btnsave
        '
        Me.btnsave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnsave.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsave.Image = Global.beerparlourbillingsystem.My.Resources.Resources.Add_1
        Me.btnsave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnsave.Location = New System.Drawing.Point(13, 7)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(84, 23)
        Me.btnsave.TabIndex = 18
        Me.btnsave.Text = "Save"
        Me.btnsave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'Panel5
        '
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Controls.Add(Me.txtpassword2)
        Me.Panel5.Controls.Add(Me.txtpassword)
        Me.Panel5.Controls.Add(Me.txtusername)
        Me.Panel5.Controls.Add(Me.Label8)
        Me.Panel5.Controls.Add(Me.Label11)
        Me.Panel5.Controls.Add(Me.Label10)
        Me.Panel5.Location = New System.Drawing.Point(10, 300)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(322, 104)
        Me.Panel5.TabIndex = 2
        '
        'txtpassword2
        '
        Me.txtpassword2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtpassword2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtpassword2.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpassword2.Location = New System.Drawing.Point(136, 64)
        Me.txtpassword2.Name = "txtpassword2"
        Me.txtpassword2.Size = New System.Drawing.Size(163, 22)
        Me.txtpassword2.TabIndex = 10
        Me.txtpassword2.UseSystemPasswordChar = True
        '
        'txtpassword
        '
        Me.txtpassword.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtpassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtpassword.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpassword.Location = New System.Drawing.Point(136, 33)
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.Size = New System.Drawing.Size(163, 22)
        Me.txtpassword.TabIndex = 9
        Me.txtpassword.UseSystemPasswordChar = True
        '
        'txtusername
        '
        Me.txtusername.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtusername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtusername.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtusername.Location = New System.Drawing.Point(136, 6)
        Me.txtusername.Name = "txtusername"
        Me.txtusername.Size = New System.Drawing.Size(163, 22)
        Me.txtusername.TabIndex = 8
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(39, 36)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(53, 13)
        Me.Label8.TabIndex = 25
        Me.Label8.Text = "Password"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(39, 64)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(91, 13)
        Me.Label11.TabIndex = 16
        Me.Label11.Text = "Confirm Password"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(39, 6)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(55, 13)
        Me.Label10.TabIndex = 13
        Me.Label10.Text = "Username"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Panel5)
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Location = New System.Drawing.Point(11, 10)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(533, 495)
        Me.Panel1.TabIndex = 59
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.Button1)
        Me.Panel3.Controls.Add(Me.txtdesignation)
        Me.Panel3.Controls.Add(Me.txtaddress)
        Me.Panel3.Controls.Add(Me.txtphone)
        Me.Panel3.Controls.Add(Me.txtname)
        Me.Panel3.Controls.Add(Me.txtstaffid)
        Me.Panel3.Controls.Add(Me.dateofbirth)
        Me.Panel3.Controls.Add(Me.cmdsex)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.Label9)
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.staffpic)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Location = New System.Drawing.Point(10, 65)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(511, 231)
        Me.Panel3.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(373, 155)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(89, 23)
        Me.Button1.TabIndex = 22
        Me.Button1.Text = "Browse Image"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtdesignation
        '
        Me.txtdesignation.BackColor = System.Drawing.Color.MistyRose
        Me.txtdesignation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtdesignation.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdesignation.Location = New System.Drawing.Point(136, 199)
        Me.txtdesignation.Name = "txtdesignation"
        Me.txtdesignation.Size = New System.Drawing.Size(163, 22)
        Me.txtdesignation.TabIndex = 7
        '
        'txtaddress
        '
        Me.txtaddress.BackColor = System.Drawing.Color.MistyRose
        Me.txtaddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtaddress.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtaddress.Location = New System.Drawing.Point(136, 144)
        Me.txtaddress.Multiline = True
        Me.txtaddress.Name = "txtaddress"
        Me.txtaddress.Size = New System.Drawing.Size(185, 49)
        Me.txtaddress.TabIndex = 6
        '
        'txtphone
        '
        Me.txtphone.BackColor = System.Drawing.Color.MistyRose
        Me.txtphone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtphone.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtphone.Location = New System.Drawing.Point(136, 116)
        Me.txtphone.Name = "txtphone"
        Me.txtphone.Size = New System.Drawing.Size(163, 22)
        Me.txtphone.TabIndex = 5
        '
        'txtname
        '
        Me.txtname.BackColor = System.Drawing.Color.MistyRose
        Me.txtname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtname.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtname.Location = New System.Drawing.Point(136, 33)
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(163, 22)
        Me.txtname.TabIndex = 2
        '
        'txtstaffid
        '
        Me.txtstaffid.BackColor = System.Drawing.Color.MistyRose
        Me.txtstaffid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtstaffid.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtstaffid.Location = New System.Drawing.Point(136, 7)
        Me.txtstaffid.Name = "txtstaffid"
        Me.txtstaffid.Size = New System.Drawing.Size(163, 22)
        Me.txtstaffid.TabIndex = 1
        '
        'dateofbirth
        '
        Me.dateofbirth.CalendarMonthBackground = System.Drawing.Color.MistyRose
        Me.dateofbirth.Location = New System.Drawing.Point(136, 89)
        Me.dateofbirth.Name = "dateofbirth"
        Me.dateofbirth.Size = New System.Drawing.Size(163, 20)
        Me.dateofbirth.TabIndex = 4
        '
        'cmdsex
        '
        Me.cmdsex.BackColor = System.Drawing.Color.MistyRose
        Me.cmdsex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmdsex.FormattingEnabled = True
        Me.cmdsex.Items.AddRange(New Object() {"Male", "Female"})
        Me.cmdsex.Location = New System.Drawing.Point(136, 62)
        Me.cmdsex.Name = "cmdsex"
        Me.cmdsex.Size = New System.Drawing.Size(133, 21)
        Me.cmdsex.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(39, 65)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(25, 13)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Sex"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(39, 119)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(38, 13)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "Phone"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(39, 151)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(45, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Address"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(36, 93)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Date of Birth"
        '
        'staffpic
        '
        Me.staffpic.Image = Global.beerparlourbillingsystem.My.Resources.Resources.photo_not_available_large
        Me.staffpic.Location = New System.Drawing.Point(352, 11)
        Me.staffpic.Name = "staffpic"
        Me.staffpic.Size = New System.Drawing.Size(130, 138)
        Me.staffpic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.staffpic.TabIndex = 2
        Me.staffpic.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(39, 204)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 13)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Designation"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DarkRed
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(10, 7)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(511, 52)
        Me.Panel2.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(206, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(224, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Staff/Users Registration"
        '
        'adduser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkRed
        Me.ClientSize = New System.Drawing.Size(556, 515)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "adduser"
        Me.Text = "Add user"
        Me.Panel4.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.staffpic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnclear As System.Windows.Forms.Button
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents txtpassword2 As System.Windows.Forms.TextBox
    Friend WithEvents txtpassword As System.Windows.Forms.TextBox
    Friend WithEvents txtusername As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txtdesignation As System.Windows.Forms.TextBox
    Friend WithEvents txtaddress As System.Windows.Forms.TextBox
    Friend WithEvents txtphone As System.Windows.Forms.TextBox
    Friend WithEvents txtname As System.Windows.Forms.TextBox
    Friend WithEvents txtstaffid As System.Windows.Forms.TextBox
    Friend WithEvents dateofbirth As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmdsex As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents staffpic As System.Windows.Forms.PictureBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btncancel As System.Windows.Forms.Button
End Class

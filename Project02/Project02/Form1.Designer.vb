<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtStuId = New System.Windows.Forms.TextBox()
        Me.txtExt_Name = New System.Windows.Forms.TextBox()
        Me.txtLast_Name = New System.Windows.Forms.TextBox()
        Me.txtMiddle_Name = New System.Windows.Forms.TextBox()
        Me.txtFirst_Name = New System.Windows.Forms.TextBox()
        Me.cbAge = New System.Windows.Forms.ComboBox()
        Me.cbGender = New System.Windows.Forms.ComboBox()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.PhoneNo = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.dgErollment = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Searchtext = New System.Windows.Forms.TextBox()
        Me.txtYear = New System.Windows.Forms.ComboBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtGuardian = New System.Windows.Forms.TextBox()
        Me.txtContact = New System.Windows.Forms.TextBox()
        Me.txtPlace = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.View = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgErollment, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(104, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(402, 35)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Student Information System"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(44, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Padding = New System.Windows.Forms.Padding(0, 3, 10, 3)
        Me.Label2.Size = New System.Drawing.Size(143, 30)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Student ID:"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(42, 419)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(144, 29)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Address:"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(46, 373)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(144, 37)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Gender :"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(46, 328)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(144, 32)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Age :"
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(44, 238)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(143, 32)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Course:"
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(44, 191)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(142, 35)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Last Name:"
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(43, 146)
        Me.Label8.Name = "Label8"
        Me.Label8.Padding = New System.Windows.Forms.Padding(0, 3, 10, 3)
        Me.Label8.Size = New System.Drawing.Size(143, 29)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Middle Name:"
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(44, 98)
        Me.Label9.Name = "Label9"
        Me.Label9.Padding = New System.Windows.Forms.Padding(0, 3, 10, 3)
        Me.Label9.Size = New System.Drawing.Size(143, 32)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "First Name :"
        '
        'txtStuId
        '
        Me.txtStuId.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStuId.Location = New System.Drawing.Point(205, 51)
        Me.txtStuId.Multiline = True
        Me.txtStuId.Name = "txtStuId"
        Me.txtStuId.Size = New System.Drawing.Size(446, 36)
        Me.txtStuId.TabIndex = 9
        '
        'txtExt_Name
        '
        Me.txtExt_Name.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtExt_Name.Location = New System.Drawing.Point(205, 233)
        Me.txtExt_Name.Multiline = True
        Me.txtExt_Name.Name = "txtExt_Name"
        Me.txtExt_Name.Size = New System.Drawing.Size(446, 38)
        Me.txtExt_Name.TabIndex = 10
        '
        'txtLast_Name
        '
        Me.txtLast_Name.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLast_Name.Location = New System.Drawing.Point(205, 191)
        Me.txtLast_Name.Multiline = True
        Me.txtLast_Name.Name = "txtLast_Name"
        Me.txtLast_Name.Size = New System.Drawing.Size(446, 36)
        Me.txtLast_Name.TabIndex = 11
        '
        'txtMiddle_Name
        '
        Me.txtMiddle_Name.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMiddle_Name.Location = New System.Drawing.Point(205, 140)
        Me.txtMiddle_Name.Multiline = True
        Me.txtMiddle_Name.Name = "txtMiddle_Name"
        Me.txtMiddle_Name.Size = New System.Drawing.Size(446, 43)
        Me.txtMiddle_Name.TabIndex = 12
        '
        'txtFirst_Name
        '
        Me.txtFirst_Name.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFirst_Name.Location = New System.Drawing.Point(205, 93)
        Me.txtFirst_Name.Multiline = True
        Me.txtFirst_Name.Name = "txtFirst_Name"
        Me.txtFirst_Name.Size = New System.Drawing.Size(446, 41)
        Me.txtFirst_Name.TabIndex = 13
        '
        'cbAge
        '
        Me.cbAge.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbAge.FormattingEnabled = True
        Me.cbAge.Items.AddRange(New Object() {"6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40"})
        Me.cbAge.Location = New System.Drawing.Point(205, 327)
        Me.cbAge.Name = "cbAge"
        Me.cbAge.Size = New System.Drawing.Size(446, 33)
        Me.cbAge.TabIndex = 14
        '
        'cbGender
        '
        Me.cbGender.DisplayMember = "1"
        Me.cbGender.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbGender.FormattingEnabled = True
        Me.cbGender.Items.AddRange(New Object() {"FEMALE", "MALE"})
        Me.cbGender.Location = New System.Drawing.Point(205, 366)
        Me.cbGender.Name = "cbGender"
        Me.cbGender.Size = New System.Drawing.Size(446, 33)
        Me.cbGender.TabIndex = 15
        '
        'txtAddress
        '
        Me.txtAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddress.Location = New System.Drawing.Point(205, 405)
        Me.txtAddress.Multiline = True
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(446, 35)
        Me.txtAddress.TabIndex = 16
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.Khaki
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(35, 491)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(190, 46)
        Me.btnSave.TabIndex = 20
        Me.btnSave.Text = "Add"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Khaki
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(1095, 491)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(190, 48)
        Me.btnExit.TabIndex = 24
        Me.btnExit.Text = "EXIT"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(43, 457)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(145, 28)
        Me.Label10.TabIndex = 26
        Me.Label10.Text = "Phone No."
        '
        'PhoneNo
        '
        Me.PhoneNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PhoneNo.Location = New System.Drawing.Point(205, 446)
        Me.PhoneNo.Multiline = True
        Me.PhoneNo.Name = "PhoneNo"
        Me.PhoneNo.Size = New System.Drawing.Size(446, 39)
        Me.PhoneNo.TabIndex = 27
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(45, 277)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(143, 36)
        Me.Label11.TabIndex = 28
        Me.Label11.Text = "Year:"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Silver
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(935, 51)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(209, 190)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 30
        Me.PictureBox1.TabStop = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(602, 249)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(0, 29)
        Me.Label12.TabIndex = 31
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.Khaki
        Me.btnUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.Location = New System.Drawing.Point(245, 491)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(194, 46)
        Me.btnUpdate.TabIndex = 21
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.Khaki
        Me.btnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(461, 487)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(190, 49)
        Me.btnDelete.TabIndex = 19
        Me.btnDelete.Text = "DELETE"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.Khaki
        Me.btnSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.Location = New System.Drawing.Point(934, 489)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(142, 48)
        Me.btnSearch.TabIndex = 22
        Me.btnSearch.Text = "SEARCH"
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'dgErollment
        '
        Me.dgErollment.AllowUserToAddRows = False
        Me.dgErollment.AllowUserToDeleteRows = False
        Me.dgErollment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgErollment.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.View, Me.id})
        Me.dgErollment.Location = New System.Drawing.Point(35, 542)
        Me.dgErollment.Name = "dgErollment"
        Me.dgErollment.ReadOnly = True
        Me.dgErollment.Size = New System.Drawing.Size(1250, 162)
        Me.dgErollment.TabIndex = 25
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Khaki
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(934, 232)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(210, 53)
        Me.Button1.TabIndex = 32
        Me.Button1.Text = "Upload Picture"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Searchtext
        '
        Me.Searchtext.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Searchtext.Location = New System.Drawing.Point(667, 489)
        Me.Searchtext.Multiline = True
        Me.Searchtext.Name = "Searchtext"
        Me.Searchtext.Size = New System.Drawing.Size(277, 48)
        Me.Searchtext.TabIndex = 33
        '
        'txtYear
        '
        Me.txtYear.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtYear.FormattingEnabled = True
        Me.txtYear.Items.AddRange(New Object() {"1st Year", "2nd Year", "3rd Year", "4th Year"})
        Me.txtYear.Location = New System.Drawing.Point(205, 280)
        Me.txtYear.Name = "txtYear"
        Me.txtYear.Size = New System.Drawing.Size(446, 37)
        Me.txtYear.TabIndex = 34
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(687, 366)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(107, 25)
        Me.Label13.TabIndex = 35
        Me.Label13.Text = "Guadian:"
        '
        'txtGuardian
        '
        Me.txtGuardian.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGuardian.Location = New System.Drawing.Point(839, 349)
        Me.txtGuardian.Multiline = True
        Me.txtGuardian.Name = "txtGuardian"
        Me.txtGuardian.Size = New System.Drawing.Size(446, 39)
        Me.txtGuardian.TabIndex = 36
        '
        'txtContact
        '
        Me.txtContact.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContact.Location = New System.Drawing.Point(839, 394)
        Me.txtContact.Multiline = True
        Me.txtContact.Name = "txtContact"
        Me.txtContact.Size = New System.Drawing.Size(446, 40)
        Me.txtContact.TabIndex = 37
        '
        'txtPlace
        '
        Me.txtPlace.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPlace.Location = New System.Drawing.Point(839, 440)
        Me.txtPlace.Multiline = True
        Me.txtPlace.Name = "txtPlace"
        Me.txtPlace.Size = New System.Drawing.Size(446, 43)
        Me.txtPlace.TabIndex = 38
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(685, 412)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(104, 20)
        Me.Label14.TabIndex = 39
        Me.Label14.Text = "Contact No:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(687, 457)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(105, 25)
        Me.Label15.TabIndex = 40
        Me.Label15.Text = "Address:"
        '
        'View
        '
        Me.View.HeaderText = ""
        Me.View.Name = "View"
        Me.View.ReadOnly = True
        Me.View.Text = "View ID"
        Me.View.UseColumnTextForButtonValue = True
        '
        'id
        '
        Me.id.DataPropertyName = "student_id"
        Me.id.HeaderText = "Student_id"
        Me.id.Name = "id"
        Me.id.ReadOnly = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightCoral
        Me.ClientSize = New System.Drawing.Size(1309, 691)
        Me.Controls.Add(Me.txtPlace)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.txtContact)
        Me.Controls.Add(Me.txtGuardian)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtYear)
        Me.Controls.Add(Me.Searchtext)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.PhoneNo)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.dgErollment)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.cbGender)
        Me.Controls.Add(Me.cbAge)
        Me.Controls.Add(Me.txtFirst_Name)
        Me.Controls.Add(Me.txtMiddle_Name)
        Me.Controls.Add(Me.txtLast_Name)
        Me.Controls.Add(Me.txtExt_Name)
        Me.Controls.Add(Me.txtStuId)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "`"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgErollment, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtStuId As TextBox
    Friend WithEvents txtExt_Name As TextBox
    Friend WithEvents txtLast_Name As TextBox
    Friend WithEvents txtMiddle_Name As TextBox
    Friend WithEvents txtFirst_Name As TextBox
    Friend WithEvents cbAge As ComboBox
    Friend WithEvents cbGender As ComboBox
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents btnSave As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents PhoneNo As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label12 As Label
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnSearch As Button
    Friend WithEvents dgErollment As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents Searchtext As TextBox
    Friend WithEvents txtYear As ComboBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Label13 As Label
    Friend WithEvents txtGuardian As TextBox
    Friend WithEvents txtContact As TextBox
    Friend WithEvents txtPlace As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents View As DataGridViewButtonColumn
    Friend WithEvents id As DataGridViewTextBoxColumn
End Class

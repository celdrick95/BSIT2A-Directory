<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBSIT2ADirectory
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
        Me.btnConnectDB = New System.Windows.Forms.Button()
        Me.dgvStudents = New System.Windows.Forms.DataGridView()
        Me.lblStudentNumber = New System.Windows.Forms.Label()
        Me.txtStudentNum = New System.Windows.Forms.TextBox()
        Me.txtSurname = New System.Windows.Forms.TextBox()
        Me.lblSurname = New System.Windows.Forms.Label()
        Me.txtFirstname = New System.Windows.Forms.TextBox()
        Me.lblFirstname = New System.Windows.Forms.Label()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.btnNewRecord = New System.Windows.Forms.Button()
        Me.btnUpdateSelectedRecord = New System.Windows.Forms.Button()
        Me.btnDeleteSelectedRecord = New System.Windows.Forms.Button()
        Me.txtSearchRecord = New System.Windows.Forms.TextBox()
        Me.lblSearchStudentNumber = New System.Windows.Forms.Label()
        Me.btnSearch = New System.Windows.Forms.Button()
        CType(Me.dgvStudents, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnConnectDB
        '
        Me.btnConnectDB.Location = New System.Drawing.Point(426, 296)
        Me.btnConnectDB.Name = "btnConnectDB"
        Me.btnConnectDB.Size = New System.Drawing.Size(119, 28)
        Me.btnConnectDB.TabIndex = 0
        Me.btnConnectDB.Text = "Connect to Database"
        Me.btnConnectDB.UseVisualStyleBackColor = True
        '
        'dgvStudents
        '
        Me.dgvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvStudents.Location = New System.Drawing.Point(14, 19)
        Me.dgvStudents.Name = "dgvStudents"
        Me.dgvStudents.Size = New System.Drawing.Size(531, 271)
        Me.dgvStudents.TabIndex = 1
        '
        'lblStudentNumber
        '
        Me.lblStudentNumber.AutoSize = True
        Me.lblStudentNumber.Location = New System.Drawing.Point(551, 22)
        Me.lblStudentNumber.Name = "lblStudentNumber"
        Me.lblStudentNumber.Size = New System.Drawing.Size(87, 13)
        Me.lblStudentNumber.TabIndex = 2
        Me.lblStudentNumber.Text = "Student Number:"
        '
        'txtStudentNum
        '
        Me.txtStudentNum.Location = New System.Drawing.Point(644, 19)
        Me.txtStudentNum.Name = "txtStudentNum"
        Me.txtStudentNum.Size = New System.Drawing.Size(148, 20)
        Me.txtStudentNum.TabIndex = 3
        '
        'txtSurname
        '
        Me.txtSurname.Location = New System.Drawing.Point(609, 45)
        Me.txtSurname.Name = "txtSurname"
        Me.txtSurname.Size = New System.Drawing.Size(183, 20)
        Me.txtSurname.TabIndex = 5
        '
        'lblSurname
        '
        Me.lblSurname.AutoSize = True
        Me.lblSurname.Location = New System.Drawing.Point(551, 48)
        Me.lblSurname.Name = "lblSurname"
        Me.lblSurname.Size = New System.Drawing.Size(52, 13)
        Me.lblSurname.TabIndex = 4
        Me.lblSurname.Text = "Surname:"
        '
        'txtFirstname
        '
        Me.txtFirstname.Location = New System.Drawing.Point(609, 71)
        Me.txtFirstname.Name = "txtFirstname"
        Me.txtFirstname.Size = New System.Drawing.Size(183, 20)
        Me.txtFirstname.TabIndex = 7
        '
        'lblFirstname
        '
        Me.lblFirstname.AutoSize = True
        Me.lblFirstname.Location = New System.Drawing.Point(551, 74)
        Me.lblFirstname.Name = "lblFirstname"
        Me.lblFirstname.Size = New System.Drawing.Size(55, 13)
        Me.lblFirstname.TabIndex = 6
        Me.lblFirstname.Text = "Firstname:"
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(599, 97)
        Me.txtAddress.Multiline = True
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(193, 68)
        Me.txtAddress.TabIndex = 9
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Location = New System.Drawing.Point(551, 100)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(48, 13)
        Me.lblAddress.TabIndex = 8
        Me.lblAddress.Text = "Address:"
        '
        'btnNewRecord
        '
        Me.btnNewRecord.Location = New System.Drawing.Point(699, 171)
        Me.btnNewRecord.Name = "btnNewRecord"
        Me.btnNewRecord.Size = New System.Drawing.Size(93, 53)
        Me.btnNewRecord.TabIndex = 10
        Me.btnNewRecord.Text = "Save as New Record"
        Me.btnNewRecord.UseVisualStyleBackColor = True
        '
        'btnUpdateSelectedRecord
        '
        Me.btnUpdateSelectedRecord.Location = New System.Drawing.Point(599, 171)
        Me.btnUpdateSelectedRecord.Name = "btnUpdateSelectedRecord"
        Me.btnUpdateSelectedRecord.Size = New System.Drawing.Size(94, 53)
        Me.btnUpdateSelectedRecord.TabIndex = 11
        Me.btnUpdateSelectedRecord.Text = "Update Selected Record"
        Me.btnUpdateSelectedRecord.UseVisualStyleBackColor = True
        '
        'btnDeleteSelectedRecord
        '
        Me.btnDeleteSelectedRecord.Location = New System.Drawing.Point(599, 230)
        Me.btnDeleteSelectedRecord.Name = "btnDeleteSelectedRecord"
        Me.btnDeleteSelectedRecord.Size = New System.Drawing.Size(94, 53)
        Me.btnDeleteSelectedRecord.TabIndex = 12
        Me.btnDeleteSelectedRecord.Text = "Delete Selected Record"
        Me.btnDeleteSelectedRecord.UseVisualStyleBackColor = True
        '
        'txtSearchRecord
        '
        Me.txtSearchRecord.Location = New System.Drawing.Point(145, 301)
        Me.txtSearchRecord.Name = "txtSearchRecord"
        Me.txtSearchRecord.Size = New System.Drawing.Size(148, 20)
        Me.txtSearchRecord.TabIndex = 14
        '
        'lblSearchStudentNumber
        '
        Me.lblSearchStudentNumber.AutoSize = True
        Me.lblSearchStudentNumber.Location = New System.Drawing.Point(15, 304)
        Me.lblSearchStudentNumber.Name = "lblSearchStudentNumber"
        Me.lblSearchStudentNumber.Size = New System.Drawing.Size(124, 13)
        Me.lblSearchStudentNumber.TabIndex = 13
        Me.lblSearchStudentNumber.Text = "Search Student Number:"
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(299, 296)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(58, 28)
        Me.btnSearch.TabIndex = 15
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'frmBSIT2ADirectory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(804, 334)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.txtSearchRecord)
        Me.Controls.Add(Me.lblSearchStudentNumber)
        Me.Controls.Add(Me.btnDeleteSelectedRecord)
        Me.Controls.Add(Me.btnUpdateSelectedRecord)
        Me.Controls.Add(Me.btnNewRecord)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.lblAddress)
        Me.Controls.Add(Me.txtFirstname)
        Me.Controls.Add(Me.lblFirstname)
        Me.Controls.Add(Me.txtSurname)
        Me.Controls.Add(Me.lblSurname)
        Me.Controls.Add(Me.txtStudentNum)
        Me.Controls.Add(Me.lblStudentNumber)
        Me.Controls.Add(Me.btnConnectDB)
        Me.Controls.Add(Me.dgvStudents)
        Me.Name = "frmBSIT2ADirectory"
        Me.Text = "BSIT 2A Directory"
        CType(Me.dgvStudents, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnConnectDB As System.Windows.Forms.Button
    Friend WithEvents dgvStudents As System.Windows.Forms.DataGridView
    Friend WithEvents lblStudentNumber As System.Windows.Forms.Label
    Friend WithEvents txtStudentNum As System.Windows.Forms.TextBox
    Friend WithEvents txtSurname As System.Windows.Forms.TextBox
    Friend WithEvents lblSurname As System.Windows.Forms.Label
    Friend WithEvents txtFirstname As System.Windows.Forms.TextBox
    Friend WithEvents lblFirstname As System.Windows.Forms.Label
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents lblAddress As System.Windows.Forms.Label
    Friend WithEvents btnNewRecord As System.Windows.Forms.Button
    Friend WithEvents btnUpdateSelectedRecord As System.Windows.Forms.Button
    Friend WithEvents btnDeleteSelectedRecord As System.Windows.Forms.Button
    Friend WithEvents txtSearchRecord As System.Windows.Forms.TextBox
    Friend WithEvents lblSearchStudentNumber As System.Windows.Forms.Label
    Friend WithEvents btnSearch As System.Windows.Forms.Button

End Class

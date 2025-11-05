Imports System.Data.OleDb

Public Class frmBSIT2ADirectory
    Sub displayRecordsOnTexboxes() Handles dgvStudents.CellContentClick, dgvStudents.RowStateChanged 'Sub function to minimize redundant codings
        Try
            txtStudentNum.Text = dgvStudents.SelectedRows(0).Cells(0).Value.ToString()
            txtSurname.Text = dgvStudents.SelectedRows(0).Cells(1).Value.ToString()
            txtFirstname.Text = dgvStudents.SelectedRows(0).Cells(2).Value.ToString()
            txtAddress.Text = dgvStudents.SelectedRows(0).Cells(3).Value.ToString()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnConnectDB_Click(sender As Object, e As EventArgs) Handles btnConnectDB.Click
        'con.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\BSIT2ADirectory.mdb"

        con.Open()
        MessageBox.Show("Database connected.")

        Dim daStudents As New OleDbDataAdapter("SELECT * FROM Student", con) 'SQL commands
        Dim dtStudents As New DataTable

        daStudents.Fill(dtStudents)

        dgvStudents.DataSource = dtStudents

        con.Close()
        dgvStudents.Focus()
    End Sub

    Private Sub frmBSIT2ADirectory_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Me.Hide()
        frmLogin.Show()
    End Sub

    Private Sub frmBSIT2ADirectory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvStudents.AllowUserToAddRows = False
        dgvStudents.EditMode = DataGridViewEditMode.EditProgrammatically
        dgvStudents.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvStudents.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right Or AnchorStyles.Top
        btnConnectDB.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        txtStudentNum.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtSurname.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtFirstname.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtAddress.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        lblStudentNumber.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        lblSurname.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        lblFirstname.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        lblAddress.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnNewRecord.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnUpdateSelectedRecord.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnDeleteSelectedRecord.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        lblSearchStudentNumber.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        txtSearchRecord.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        btnSearch.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
    End Sub

    Private Sub btnNewRecord_Click(sender As Object, e As EventArgs) Handles btnNewRecord.Click
        Dim newStudentNumber, newSurname, newFirstname, newAddress As String

        newStudentNumber = txtStudentNum.Text
        newSurname = txtSurname.Text
        newFirstname = txtFirstname.Text
        newAddress = txtAddress.Text

        con.Open()

        Dim cmd_AddNewRecord As New OleDbCommand("INSERT INTO Student (StudentNumber,Surname,Firstname,Address)" & _
                                                 "VALUES ('" & newStudentNumber & "','" & newSurname & "','" & _
                                                 newFirstname & "','" & newAddress & "')", con)
        'Dim cmd_AddNewRecord As New OleDbCommand("INSERT INTO Student (StudentNumber,Surname,Firstname,Address) VALUES ('20211106','Babbage','Charles','NYC, Camarin')", con)
        cmd_AddNewRecord.ExecuteNonQuery()

        con.Close()
        btnConnectDB.PerformClick()

    End Sub

    Private Sub btnUpdateSelectedRecord_Click(sender As Object, e As EventArgs) Handles btnUpdateSelectedRecord.Click
        Dim strStudentNumber As String

        strStudentNumber = txtStudentNum.Text

        con.Open()

        Dim cmd_UpdateSelectedRecord As New OleDbCommand("UPDATE Student SET Surname='" & _
                                                         txtSurname.Text & "',Firstname='" & _
                                                         txtFirstname.Text & "',Address='" & _
                                                         txtAddress.Text & "' WHERE StudentNumber='" & _
                                                         strStudentNumber & "'", con)
        cmd_UpdateSelectedRecord.ExecuteNonQuery()

        con.Close()
        btnConnectDB.PerformClick()

    End Sub

    Private Sub btnDeleteSelectedRecord_Click(sender As Object, e As EventArgs) Handles btnDeleteSelectedRecord.Click
        Dim strStudentNumber As String

        strStudentNumber = txtStudentNum.Text

        con.Open()

        Dim cmd_UpdateSelectedRecord As New OleDbCommand("DELETE FROM Student WHERE StudentNumber='" & _
                                                         strStudentNumber & "'", con)
        cmd_UpdateSelectedRecord.ExecuteNonQuery()

        con.Close()
        btnConnectDB.PerformClick()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        con.Open()

        Dim daSearchStudent As New OleDbDataAdapter("SELECT * FROM Student WHERE StudentNumber='" & _
                                                  txtSearchRecord.Text & "'", con)
        Dim dtSearchStudent As New DataTable

        daSearchStudent.Fill(dtSearchStudent)

        dgvStudents.DataSource = dtSearchStudent

        con.Close()

        dgvStudents.Focus()
    End Sub
End Class

Imports MySql.Data.MySqlClient
Imports System.IO
Public Class Form1

    Dim imgpath As String
    Dim arrimage() As Byte
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnSearch.Click

        Try
            reload("SELECT * FROM " + tb + " WHERE CONCAT(  First_Name, ' ',  Middle_Name, ' ', Last_Name) LIKE '%" & Searchtext.Text & "%'", dgErollment)
        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try


    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim mstream As New System.IO.MemoryStream()
        PictureBox1.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
        arrimage = mstream.GetBuffer()
        Dim Filesize As UInt32
        Filesize = mstream.Length

        If connection() = True Then
                Try
                Dim updateCommand As New MySqlCommand(" UPDATE " + tb + " SET  First_Name = @First_Name, Middle_Name = @Middle_Name, Last_Name = @Last_Name, Course = @Course, Year = @Year, Age = @Age, Gender = @Gender, Address = @Address, PhoneNo = @PhoneNo, picture = @picture, Guardian = @Guardian, ContactNo = @ContactNo, Parent_Address = @Parent_Address WHERE student_id = @student_id", conn)
                With updateCommand.Parameters
                    .AddWithValue("@student_id", txtStuId.Text)
                    .AddWithValue("@First_Name", txtFirst_Name.Text)
                    .AddWithValue("@Middle_Name", txtMiddle_Name.Text)
                    .AddWithValue("@Last_Name", txtLast_Name.Text)
                    .AddWithValue("@Course", txtExt_Name.Text)
                    .AddWithValue("@Year", txtYear.Text)
                    .AddWithValue("@Age", cbAge.Text)
                    .AddWithValue("@Gender", cbGender.Text)
                    .AddWithValue("@Address", txtAddress.Text)
                    .AddWithValue("@PhoneNo", PhoneNo.Text)
                    .AddWithValue("@picture", arrimage)
                    .AddWithValue("@Guardian", txtGuardian.Text)
                    .AddWithValue("@ContactNo", txtContact.Text)
                    .AddWithValue("@Parent_Address", txtPlace.Text)
                End With
                updateCommand.ExecuteNonQuery()
                MessageBox.Show("Student information updated succesfully!", "Update saved!", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Catch ex As Exception
                MessageBox.Show(ex.Message, "Database Query Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
        If conn.State = ConnectionState.Open Then conn.Close()
        display_data_to_datagrid()
        txtStuId.Text = ""
        txtFirst_Name.Text = ""
        txtMiddle_Name.Text = ""
        txtLast_Name.Text = ""
        txtExt_Name.Text = ""
        txtYear.Text = ""
        cbAge.Text = ""
        cbGender.Text = ""
        txtAddress.Text = ""
        PhoneNo.Text = ""
        PictureBox1.Image = Nothing
        txtGuardian.Text = ""
        txtContact.Text = ""
        txtPlace.Text = ""




    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim ans As Integer = MessageBox.Show("Are you sure you want to delete selected Data?", "Delete selected Data?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If ans = vbYes Then
            If connection() = True Then
                Try
                    sqlCmd = New MySqlCommand("DELETE FROM " & tb & " WHERE student_id = '" & txtStuId.Text & "' ", conn)
                    sqlDR = sqlCmd.ExecuteReader

                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Database Query Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
            If conn.State = ConnectionState.Open Then conn.Close()
            display_data_to_datagrid()
        End If

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles txtAddress.TextChanged

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles txtExt_Name.TextChanged

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbGender.SelectedIndexChanged

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbAge.SelectedIndexChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim mstream As New System.IO.MemoryStream()
        PictureBox1.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
        arrimage = mstream.GetBuffer()
        Dim Filesize As UInt32
        Filesize = mstream.Length

        mstream.Close()


        If MessageBox.Show("Gustu jud ka e save ni?", "Save jud nimo ni!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            If connection() = True Then
                Try
                    Dim saveCommand As New MySqlCommand("INSERT INTO " + tb + " (student_id, First_Name, Middle_Name, Last_Name, Course, Year, Age, Gender, Address, PhoneNo, picture, Guardian, ContactNo, Parent_Address) " +
                        " VALUES (@student_id, @First_Name, @Middle_Name, @Last_Name, @Course, @Year, @Age, @Gender, @Address, @PhoneNo, @picture, @Guardian, @ContactNo, @Parent_Address)", conn)
                    With saveCommand.Parameters
                        .AddWithValue("@student_id", txtStuId.Text)
                        .AddWithValue("@First_Name", txtFirst_Name.Text)
                        .AddWithValue("@Middle_Name", txtMiddle_Name.Text)
                        .AddWithValue("@Last_Name", txtLast_Name.Text)
                        .AddWithValue("@Course", txtExt_Name.Text)
                        .AddWithValue("@Year", txtYear.Text)
                        .AddWithValue("@Age", cbAge.Text)
                        .AddWithValue("@Gender", cbGender.Text)
                        .AddWithValue("@Address", txtAddress.Text)
                        .AddWithValue("@PhoneNo", PhoneNo.Text)
                        .AddWithValue("@picture", arrimage)
                        .AddWithValue("@Guardian", txtGuardian.Text)
                        .AddWithValue("@ContactNo", txtContact.Text)
                        .AddWithValue("@Parent_Address", txtPlace.Text)

                    End With
                    saveCommand.ExecuteNonQuery()
                    MessageBox.Show("Student information succesfully save!", "Successfully saved!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    'Clear_Data()
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Database Query Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
            If conn.State = ConnectionState.Open Then conn.Close()
            display_data_to_datagrid()
            txtStuId.Text = ""
            txtFirst_Name.Text = ""
            txtMiddle_Name.Text = ""
            txtLast_Name.Text = ""
            txtExt_Name.Text = ""
            txtYear.Text = ""
            cbAge.Text = ""
            cbGender.Text = ""
            txtAddress.Text = ""
            PhoneNo.Text = ""
            PictureBox1.Image = Nothing
            txtGuardian.Text = ""
            txtContact.Text = ""
            txtPlace.Text = ""

            'dgErollment()
        End If
    End Sub

    Private Sub Button6_Click_1(sender As Object, e As EventArgs) Handles btnExit.Click
        End

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtStuId.TextChanged

    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles txtFirst_Name.TextChanged

    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles txtMiddle_Name.TextChanged

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles txtLast_Name.TextChanged

    End Sub

    Public Sub display_data_to_datagrid()
        If connection() = True Then
            Try
                sqlCmd = New MySqlCommand("Select * from " + tb + "", conn)
                sqlDA = New MySqlDataAdapter(sqlCmd)
                sqlDS = New DataSet
                sqlDA.Fill(sqlDS, tb)
                dgErollment.DataSource = sqlDS.Tables(tb)

            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error on Query!",
                                MessageBoxButtons.OK, MessageBoxIcon.Error)

            End Try
        End If
        If conn.State = ConnectionState.Open Then conn.Close()
    End Sub
    Private Sub dgErollment_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgErollment.CellContentClick
        txtStuId.Text = dgErollment.CurrentRow.Cells(1).Value
        txtFirst_Name.Text = dgErollment.CurrentRow.Cells(2).Value
        txtLast_Name.Text = dgErollment.CurrentRow.Cells(3).Value
        txtMiddle_Name.Text = dgErollment.CurrentRow.Cells(4).Value
        txtExt_Name.Text = dgErollment.CurrentRow.Cells(5).Value
        txtYear.Text = dgErollment.CurrentRow.Cells(6).Value
        cbAge.Text = dgErollment.CurrentRow.Cells(7).Value
        cbGender.Text = dgErollment.CurrentRow.Cells(8).Value
        txtAddress.Text = dgErollment.CurrentRow.Cells(9).Value
        PhoneNo.Text = dgErollment.CurrentRow.Cells(10).Value
        txtGuardian.Text = dgErollment.CurrentRow.Cells(12).Value
        txtContact.Text = dgErollment.CurrentRow.Cells(13).Value
        txtPlace.Text = dgErollment.CurrentRow.Cells(14).Value












    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        display_data_to_datagrid()

    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click

    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click

    End Sub

    Private Sub TextBox1_TextChanged_1(sender As Object, e As EventArgs) Handles PhoneNo.TextChanged

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles Label12.Click

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim OFD As FileDialog = New OpenFileDialog()
            OFD.Filter = "Image File (*.jpg;*.bmp;*.gif)| *.jpg;*.bmp;*.gif"

            If OFD.ShowDialog() = DialogResult.OK Then
                imgpath = OFD.FileName
                PictureBox1.ImageLocation = imgpath
            End If
            OFD = Nothing
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try

    End Sub

    Private Sub Searchtext_TextChanged(sender As Object, e As EventArgs) Handles Searchtext.TextChanged

    End Sub

    Private Sub dgErollment_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgErollment.CellClick
        Dim colname As String = dgErollment.Columns(e.ColumnIndex).Name
        If colname = "View" Then
            Try
                Dim row As DataGridViewRow = dgErollment.Rows(e.RowIndex)
                Dim IdLayout As New Form2
                Form2.studentId = row.Cells("id").Value
                Form2.ShowDialog()
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub Label15_Click(sender As Object, e As EventArgs) Handles Label15.Click

    End Sub

    Private Sub TextBox2_TextChanged_1(sender As Object, e As EventArgs) Handles txtPlace.TextChanged

    End Sub
End Class

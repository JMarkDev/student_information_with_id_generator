Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Drawing
Public Class Form2
    Dim arrimage() As Byte
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
    Public Shared studentId As String

    Public Sub IdLayout()



        Try
            reloadtxt("SELECT  * FROM " + tb + " WHERE student_id = '" & studentId & "' ")

            If dt.Rows.Count > 0 Then
                number.Text = dt.Rows(0).Item("student_id").ToString
                Label13.Text = dt.Rows(0).Item("Course").ToString
                Label15.Text = dt.Rows(0).Item("First_Name").ToString
                Label4.Text = dt.Rows(0).Item("Middle_Name").ToString
                Label28.Text = dt.Rows(0).Item("Last_Name").ToString
                Label22.Text = dt.Rows(0).Item("Guardian").ToString
                Label23.Text = dt.Rows(0).Item("Parent_Address").ToString
                Label24.Text = dt.Rows(0).Item("ContactNo").ToString
                'PictureBox3.Image = dt.Rows(0).Item("picture".ToString
                If String.IsNullOrEmpty(dt.Rows(0).Item("picture").ToString) Then
                    PictureBox3.ImageLocation = Application.StartupPath & "\Pictures\download.jpg"
                Else
                    PictureBox3.ImageLocation = Application.StartupPath & dt.Rows(0).Item("picture").ToString

                End If
            End If

        Catch ex As Exception

                End Try
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label17_Click(sender As Object, e As EventArgs) Handles Label17.Click

    End Sub

    Private Sub Label19_Click(sender As Object, e As EventArgs) Handles Label19.Click

    End Sub

    Private Sub Label15_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        IdLayout()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label28_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub number_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Label31_Click(sender As Object, e As EventArgs) Handles Label31.Click

    End Sub

    Private Sub Label34_Click(sender As Object, e As EventArgs) Handles number.Click

    End Sub

    Private Sub Label30_Click(sender As Object, e As EventArgs) Handles Label30.Click

    End Sub

    Private Sub Label15_Click_1(sender As Object, e As EventArgs) Handles Label15.Click

    End Sub
End Class
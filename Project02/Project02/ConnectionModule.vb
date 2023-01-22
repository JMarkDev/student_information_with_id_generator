Imports MySql.Data.MySqlClient

Module module_Connection
    Friend result As Boolean
    Friend sqlDS As DataSet
    Friend sqlDA As MySqlDataAdapter
    Friend conn As MySqlConnection
    Friend sqlDR As MySqlDataReader
    Friend sqlCmd As MySqlCommand


    Friend strConn As String
    ''' - - - DATABASE CREDENTIALS - - - '''                    
    Friend dbhost = "localhost"
    Friend dbuser = "root"
    Friend dbpass = "jmseroy"
    Friend dbname = "id_generator"
    Friend dbport = "3306"
    ' ' ' - - LIST OF TABLES - - ' ' '
    Friend tb As String = "tbl_student"
    Public dt As New DataTable

    'Friend tb2 As String = "tbl_enrollment"
    ' Friend tb3 As String = "tbl_subject"


    Public Function connection() As Boolean
        Try
            conn = New MySqlConnection
            If conn.State = ConnectionState.Open Then conn.Close()
            strConn = "SERVER=" + dbhost + "; USERNAME=" + dbuser + ";PASSWORD=" + dbpass + ";DATABASE=" + dbname + ";PORT=" + dbport + ";"
            conn.ConnectionString = strConn
            conn.Open()
            result = True
        Catch ex As MySqlException
            result = False
            MessageBox.Show(ex.Message, "Database Connection Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return result
    End Function
    Public Sub reload(ByVal sql As String, ByVal dgv As Object)
        Try
            dt = New DataTable
            conn.Open()
            With sqlCmd
                .Connection = conn
                .CommandText = sql
            End With
            sqlDA.SelectCommand = sqlCmd
            sqlDA.Fill(dt)
            dgv.datasource = dt

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Close()
            sqlDA.Dispose()
        End Try
    End Sub
    Public Sub reloadtxt(ByVal sql As String)
        Try
            conn.Open()
            With sqlCmd
                .Connection = conn
                .CommandText = sql
            End With
            dt = New DataTable
            sqlDA = New MySqlDataAdapter(sql, conn)
            sqlDA.Fill(dt)

        Catch ex As Exception
            '   MsgBox(ex.Message & "reloadtxt")
        Finally

            conn.Close()
            sqlDA.Dispose()

        End Try
    End Sub
End Module

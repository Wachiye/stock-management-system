Imports MySql.Data.MySqlClient
Public Class DbController
    'gloabl variables
    'mysql connection
    Private conn As MySqlConnection = New MySqlConnection("host=localhost;user=root;password=4sirah@123;database=stock;port=3306;")
    'mysql command
    Private cmd As MySqlCommand
    'dataset
    'data adapter
    Private adapter As MySqlDataAdapter
    Private dataset As DataSet

    Public Property Conn1 As MySqlConnection
        Get
            Return conn
        End Get
        Set(value As MySqlConnection)
            conn = value
        End Set
    End Property

    'create database
    Public Sub CreateDatabase()

    End Sub

    'function to access the database
    Private Sub Connect()
        Try
            'display message
            DisplayMessage("Connecting ...")
            'check if db is open
            If Conn1.State = ConnectionState.Closed Then
                'open the database and return the connection
                Conn1.Open()
                DisplayMessage("Connected")
            End If
        Catch ex As MySqlException
            MessageBox.Show(ex.Message, "Connection failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub Disconnect()
        'check if db is open
        Try
            'if db is open
            If Conn1.State = ConnectionState.Open Then
                DisplayMessage("Server is idle. Disconnected")
                'close the connection
                Conn1.Close()
                DisplayMessage("Ready")
            End If
        Catch ex As Exception
            MsgBox("Connection failure")
        End Try
    End Sub
    'function to create tables
    Public Function CreateTables(sourcefile As String) As Boolean
        'return parameter
        Dim success As Boolean = False
        Try
            'get the text in the source file
            Dim mysql As String = IO.File.ReadAllText(sourcefile)
            'initialize new command
            cmd = New mysqlCommand
            With cmd
                'set command connection
                .Connection = conn
                'set the command text
                .CommandText = mysql
                'connect to db
                Connect()
                'execute the text commands
                .ExecuteNonQuery()
                'disconnect 
                Disconnect()
                'set return variable to true
                success = True
            End With
        Catch ex As Exception
            'set return value to false
            success = False
        End Try

        Return success
    End Function
    'function to execute  insert, update and delete queries
    Public Function InsertData(mysql As String) As Integer
        Try
            cmd = New mysqlCommand

            With cmd
                .Connection = conn
                .CommandType = CommandType.Text
                .CommandText = mysql
            End With

            Connect()
            cmd.ExecuteNonQuery()
            Return 1
        Catch ex As Exception
            MessageBox.Show(ex.Message & vbNewLine & mysql, "Server Response")
            Return 0
        Finally
            Disconnect()
        End Try
    End Function

    'function to execute SELECT queries
    Public Function SelectData(mysql As String, table As String) As DataSet
        Try
            cmd = New MySqlCommand
            adapter = New MySqlDataAdapter
            dataset = New DataSet
            With cmd
                .Connection = conn
                .CommandType = CommandType.Text
                .CommandText = mysql
            End With
            adapter.SelectCommand = cmd
            Connect()
            adapter.Fill(dataset, table)
            Return dataset
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Server Response")
            Return dataset
        Finally
            Disconnect()
        End Try
    End Function
End Class

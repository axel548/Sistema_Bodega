Imports System.Data.SqlClient

Public Class Form1


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        '    Try
        '        Dim cn As New SqlConnection(My.Settings.cadconex)
        '        AddHandler cn.InfoMessage, AddressOf cn_InfoMessage

        '        cn.Open()
        '        Dim cmd As New SqlCommand("GetCustomers")
        '        cmd.CommandType = CommandType.StoredProcedure
        '        cmd.Connection = cn

        '        cmd.Parameters.Add(New SqlParameter("@CustomerID1", SqlDbType.NVarChar, 5))
        '        cmd.Parameters.Add(New SqlParameter("@CustomerID2", SqlDbType.NVarChar, 5))

        '        cmd.Parameters("@CustomerID1").Value = TextBox1.Text
        '        cmd.Parameters("@CustomerID2").Value = TextBox2.Text

        '        Dim myReader As SqlDataReader = cmd.ExecuteReader()
        '        Dim RecordCount As Integer = 0

        '        'You must check the nextresult method because there is a possiblity that the
        '        'stored procedure may return multiple resultsets; the NextResult method
        '        'positions the DataReader at the next result in the resultset if you 
        '        'have multiple results, otherwise it will return false.
        '        Do
        '            Do While myReader.Read()
        '                Debug.WriteLine("Found customer ID : " & myReader(0))
        '            Loop
        '        Loop While myReader.NextResult()

        '        myReader.Close()

        '    Catch SqlEx As SqlException
        '        Dim myError As SqlError
        '        Debug.WriteLine("Errors Count:" & SqlEx.Errors.Count)
        '        For Each myError In SqlEx.Errors
        '            Debug.WriteLine(myError.Number & " - " & myError.Message)
        '        Next
        '    End Try
    End Sub

    Private Sub Form1_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        TextBox1.Width = Me.Width - 100
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class

'Public Sub cn_InfoMessage(ByVal sender As Object, ByVal e As System.Data.SqlClient.SqlInfoMessageEventArgs)
'    Debug.WriteLine("info message event: " & e.Message)
'End Sub
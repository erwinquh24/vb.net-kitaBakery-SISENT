Imports System.Data.Odbc
Imports MySql.Data.MySqlClient

Module modkoneksi
    Public conn As OdbcConnection
    Public da As OdbcDataAdapter
    Public ds As DataSet
    Public dr As OdbcDataReader
    Public oc As OdbcCommand
    Public dt As DataTable
    Public tabel, simpan, hapus, edi_data, create, login, register As String
    Public konek As Boolean = False
    Public str As String
    Sub koneksi()
        str = "driver={mysql odbc 3.51 driver};database=sisent;server=localhost;uid=root"
        conn = New OdbcConnection(str)
        If conn.State = ConnectionState.Closed Then
            conn.Open()
            konek = True
        End If

    End Sub

    Public kon As MySqlConnection
    Public myCommand As MySqlCommand
    Public myDataReader As MySqlDataReader
    Public dataset As DataSet
    Public myadp As MySqlDataAdapter
    Public datatable As DataTable

    Public Sub myKoneksi()
        kon = New MySqlConnection
        kon.ConnectionString = "server=localhost; uid=root; password=; database=sisent"
        kon.Open()
    End Sub

End Module

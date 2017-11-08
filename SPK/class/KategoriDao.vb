Imports MySql.Data.MySqlClient
Imports SPK
Public Class KategoriDao
    Private _idKategoi As Integer
    Private _kategori As String
    Private _bobot As Integer

    Public Property idKategori() As Integer
        Get
            Return _idKategoi
        End Get
        Set(ByVal value As Integer)
            _idKategoi = value
        End Set
    End Property
    Public Property bobot() As Integer
        Get
            Return _bobot
        End Get
        Set(ByVal value As Integer)
            _bobot = value
        End Set
    End Property

    Public Property kategori() As String
        Get
            Return _kategori
        End Get
        Set(ByVal value As String)
            _kategori = value
        End Set
    End Property



    Public Function insert() As Boolean
        Try
            sql = "INSERT INTO kategori VALUES (null,'" + Kategori.ToString + "',+'" + bobot.ToString + "')"
            CRUD_data(sql)
            Return True
        Catch ex As Exception
            MsgBox(ex.ToString)
            Return False
        End Try
    End Function



    Public Function update() As Boolean
        Try
            sql = "UPDATE kategori SET kategori= '" + Kategori.ToString + "', bobot = '" + bobot.ToString + "'WHERE idKategori= " & idKategori.ToString & ""
            CRUD_data(sql)
            Return True
        Catch ex As Exception
            MsgBox(ex.ToString)
            Return False
        End Try
    End Function

    Public Function delete() As Boolean
        Try
            sql = "DELETE FROM kategori WHERE idKategori= " & idKategori & ""
            CRUD_data(sql)
            Return True
        Catch ex As Exception
            MsgBox(ex.ToString)
            Return False
        End Try
    End Function
    Public Function selectAll() As List(Of KategoriDao)
        Dim listPasien As New List(Of KategoriDao)
        sql = "SELECT * FROM kategori "
        dtTable = get_dttable(sql)
        listPasien = (From row As DataRow In dtTable.Rows
                    Select New KategoriDao() With
                           {.idKategori = row("idKategori"),
                            .kategori = row("kategori"),
                            .bobot = row("bobot")
                            }).ToList
        Return listPasien

    End Function
    Public Function selectByNama(nama As String) As List(Of KategoriDao)
        Dim listPasien As New List(Of KategoriDao)
        sql = "SELECT * FROM Kategori WHERE kategori like '%" + nama.ToString + "%'"
        dtTable = get_dttable(sql)
        listPasien = (From row As DataRow In dtTable.Rows
                    Select New KategoriDao() With
                            {.idKategori = row("idKategori"),
                            .kategori = row("kategori"),
                            .bobot = row("bobot")
                            }).ToList
        Return listPasien

    End Function

End Class

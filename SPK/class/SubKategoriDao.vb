Imports MySql.Data.MySqlClient
Imports SPK
Public Class SubKategoriDao
    Private _idSubKategori As Integer
    Private _subKategori As String
    Private _bobot As Integer
    Private _idKategori As String
    Private _kategori As String
    Public Property kategori() As String
        Get
            Return _kategori
        End Get
        Set(ByVal value As String)
            _kategori = value
        End Set
    End Property


    Public Property idsubKategori() As Integer
        Get
            Return _idSubKategori
        End Get
        Set(ByVal value As Integer)
            _idSubKategori = value
        End Set
    End Property
    Public Property subKategori() As String
        Get
            Return _subKategori
        End Get
        Set(ByVal value As String)
            _subKategori = value
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

    Public Property idKategori() As String
        Get
            Return _idKategori
        End Get
        Set(ByVal value As String)
            _idKategori = value
        End Set
    End Property

    Public Function insert() As Boolean
        Try
            sql = "INSERT INTO subKategori VALUES (null,'" + subKategori.ToString + "',+'" + bobot.ToString + "')"
            CRUD_data(sql)
            Return True
        Catch ex As Exception
            MsgBox(ex.ToString)
            Return False
        End Try
    End Function



    Public Function update() As Boolean
        Try
            sql = "UPDATE subKategori SET subKategori= '" + subKategori.ToString + "', bobot = '" + bobot.ToString + "'WHERE idsubKategori= " & idsubKategori.ToString & ""
            CRUD_data(sql)
            Return True
        Catch ex As Exception
            MsgBox(ex.ToString)
            Return False
        End Try
    End Function

    Public Function delete() As Boolean
        Try
            sql = "DELETE FROM subKategori WHERE idsubKategori= " & idsubKategori & ""
            CRUD_data(sql)
            Return True
        Catch ex As Exception
            MsgBox(ex.ToString)
            Return False
        End Try
    End Function
    Public Function selectAll() As List(Of SubKategoriDao)
        Dim listSubKategori As New List(Of SubKategoriDao)
        sql = "SELECT sk.idSubKategori,sk.subKategori,sk.bobot,k.kategori FROM subKategori sk join kategori k on  sk.idKategori = k.idKategori"
        dtTable = get_dttable(sql)
        listSubKategori = (From row As DataRow In dtTable.Rows
                    Select New SubKategoriDao() With
                           {.idsubKategori = row("idSubKategori"),
                            .subKategori = row("subKategori"),
                            .bobot = row("bobot"),
                            .kategori = row("kategori")
                            }).ToList
        Return listSubKategori

    End Function
    Public Function selectByNama(nama As String) As List(Of SubKategoriDao)
        Dim listPasien As New List(Of SubKategoriDao)
        sql = "SELECT * FROM subKategori WHERE subKategori like '%" + nama.ToString + "%'"
        dtTable = get_dttable(sql)
        listPasien = (From row As DataRow In dtTable.Rows
                    Select New SubKategoriDao() With
                            {.idsubKategori = row("idsubKategori"),
                            .subKategori = row("kategori"),
                            .bobot = row("bobot")
                            }).ToList
        Return listPasien

    End Function

    Private Function _idSubsubKategori() As Integer
        Throw New NotImplementedException
    End Function

End Class

Imports MySql.Data.MySqlClient
Imports SPK

Public Class PendudukDao
    Private Property _idPenduduk As Integer
    Private Property _noKtp As String
    Private Property _nama As String
    Private Property _gender As String
    Private Property _skor As String
    Private Property _alamat As String
    Private Property _noTelp As String
    Private Property _keterangan As String


    Public Property skor() As String
        Get
            Return _skor
        End Get
        Set(ByVal value As String)
            _skor = value
        End Set
    End Property

    Public Property idPenduduk() As Integer
        Set(value As Integer)
            _idPenduduk = value
        End Set
        Get
            Return _idPenduduk
        End Get
    End Property

    Public Property noKtp() As String
        Set(value As String)
            _noKtp = value
        End Set
        Get
            Return _noKtp
        End Get
    End Property

    Public Property nama() As String
        Set(value As String)
            _nama = value
        End Set
        Get
            Return _nama
        End Get
    End Property

    Public Property gender() As String
        Set(value As String)
            _gender = value
        End Set
        Get
            Return _gender
        End Get
    End Property
    Public Property alamat() As String
        Set(value As String)
            _alamat = value
        End Set
        Get
            Return _alamat
        End Get
    End Property
    Public Property noTelp() As String
        Set(value As String)
            _noTelp = value
        End Set
        Get
            Return _noTelp
        End Get
    End Property
    Public Property keterangan() As String
        Set(value As String)
            _keterangan = value
        End Set
        Get
            Return _keterangan
        End Get
    End Property


    Public Function insert() As Boolean
        Try
            sql = "INSERT INTO Penduduk VALUES (null,'" + noKtp.ToString + "',+'" + nama.ToString + "', '" + gender.ToString + "', '" + alamat.ToString + "', '" + noTelp.ToString + "',0, '" + keterangan.ToString + "')"
            CRUD_data(sql)
            Return True
        Catch ex As Exception
            MsgBox(ex.ToString)
            Return False
        End Try
    End Function

    Public Function updateHitung(skor As Double, id As Integer) As Boolean
        Try
            sql = "UPDATE Penduduk SET  skor = '" + skor.ToString + "' WHERE idPenduduk= " & id.ToString & ""
            CRUD_data(sql)
            Return True
        Catch ex As Exception
            MsgBox(ex.ToString)
            Return False
        End Try
    End Function

    Public Function update() As Boolean
        Try
            sql = "UPDATE Penduduk SET noKtp = '" + noKtp.ToString + "', nama = '" + nama.ToString + "', gender= '" + gender.ToString + "', alamat = '" + alamat.ToString + "', noTelp = '" + noTelp.ToString + "' WHERE noKtp= " & noKtp.ToString & ""
            CRUD_data(sql)
            Return True
        Catch ex As Exception
            MsgBox(ex.ToString)
            Return False
        End Try
    End Function

    Public Function delete() As Boolean
        Try
            sql = "DELETE FROM Penduduk WHERE noKtp= " & noKtp & ""
            CRUD_data(sql)
            Return True
        Catch ex As Exception
            MsgBox(ex.ToString)
            Return False
        End Try
    End Function
    Public Function selectAll() As List(Of PendudukDao)
        Dim listPasien As New List(Of PendudukDao)
        sql = "SELECT * FROM Penduduk "
        dtTable = get_dttable(sql)
        listPasien = (From row As DataRow In dtTable.Rows
                    Select New PendudukDao() With
                           {.idPenduduk = row("idPenduduk"),
                            .noKtp = row("noKtp"),
                            .nama = row("nama"),
                            .gender = row("gender"),
                            .alamat = row("alamat"),
                            .noTelp = row("noTelp"),
                            .skor = row("skor"),
                            .keterangan = row("keterangan")
                            }).ToList
        Return listPasien

    End Function
    Public Function selectByNama(nama As String) As List(Of PendudukDao)
        Dim listPasien As New List(Of PendudukDao)
        sql = "SELECT * FROM Penduduk WHERE nama like '%" + nama.ToString + "%'"
        dtTable = get_dttable(sql)
        listPasien = (From row As DataRow In dtTable.Rows
                    Select New PendudukDao() With
                            {.idPenduduk = row("idPenduduk"),
                            .noKtp = row("noKtp"),
                            .nama = row("nama"),
                            .gender = row("gender"),
                            .alamat = row("alamat"),
                            .noTelp = row("noTelp"),
                             .skor = row("skor"),
                            .keterangan = row("keterangan")
                            }).ToList
        Return listPasien

    End Function



End Class


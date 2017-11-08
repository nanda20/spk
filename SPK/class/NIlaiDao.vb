Imports MySql.Data.MySqlClient
Imports SPK
Public Class NIlaiDao
    Private _idNilai As Integer
    Private _idPenduduk As Integer
    'Private _idKategori As Integer
    'Private _idSubKategori As Integer
    Private _nilai As Integer
    Private _nama As String
    Private _alamat As String
    Private _kategori As String
    Private _subKategori As String
    Public Property subKategori() As String
        Get
            Return _subKategori
        End Get
        Set(ByVal value As String)
            _subKategori = value
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

    Public Property alamat() As String
        Get
            Return _alamat
        End Get
        Set(ByVal value As String)
            _alamat = value
        End Set
    End Property

    Public Property nama() As String
        Get
            Return _nama
        End Get
        Set(ByVal value As String)
            _nama = value
        End Set
    End Property


    Public Property nilai() As Integer
        Get
            Return _nilai
        End Get
        Set(ByVal value As Integer)
            _nilai = value
        End Set
    End Property

    'Public Property idSubKategori() As Integer
    '    Get
    '        Return _idSubKategori
    '    End Get
    '    Set(ByVal value As Integer)
    '        _idSubKategori = value
    '    End Set
    'End Property

    'Public Property idKategori() As Integer
    '    Get
    '        Return _idKategori
    '    End Get
    '    Set(ByVal value As Integer)
    '        _idKategori = value
    '    End Set
    'End Property

    Public Property idPenduduk() As Integer
        Get
            Return _idPenduduk
        End Get
        Set(ByVal value As Integer)
            _idPenduduk = value
        End Set
    End Property

    Public Property idNilai() As Integer
        Get
            Return _idNilai
        End Get
        Set(ByVal value As Integer)
            _idNilai = value
        End Set
    End Property

    Public Function selectAll() As List(Of NIlaiDao)
        Dim nilai As New List(Of NIlaiDao)
        sql = "SELECT n.*,p.nama,p.alamat,k.kategori,sk.subKategori FROM nilai n join kategori k on k.idKategori=n.idKategori join subkategori sk on sk.idSubKategori = n.idSubKategori join penduduk p on p.idPenduduk = n.idPenduduk order by n.idPenduduk"
        'sql = "SELECT idNilai,nilai FROM nilai "
        dtTable = get_dttable(sql)
        nilai = (From row As DataRow In dtTable.Rows
                    Select New NIlaiDao() With
                           {
                               .idNilai = row("idNilai"),
                               .idPenduduk = row("idPenduduk"),
                                .nama = row("nama"),
                               .subKategori = row("subKategori"),
                               .kategori = row("kategori"),
                                .nilai = row("nilai")
                            }).ToList
        Return nilai

    End Function
End Class

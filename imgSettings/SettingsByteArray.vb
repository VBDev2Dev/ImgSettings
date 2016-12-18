<Serializable()>
Public Class SettingsByteArray

    Private _Data As Byte()
    Public Property Data() As Byte()
        Get
            Return _Data
        End Get
        Set(ByVal value As Byte())
            _Data = value
        End Set
    End Property

End Class

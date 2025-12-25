Public Class Day
    Private title As String
    Private col_pos As Integer
    Public Sub New(ByVal title As String)
        Me.title = title
        Me.col_pos = 0
    End Sub
    Public Property day As String
        Get
            Return title
        End Get
        Set(ByVal value As String)
            title = value
        End Set
    End Property
    Public Property color_pos As Integer
        Get
            Return col_pos
        End Get
        Set(ByVal value As Integer)
            col_pos = value
        End Set
    End Property
End Class

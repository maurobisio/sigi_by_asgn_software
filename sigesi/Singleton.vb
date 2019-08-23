Public NotInheritable Class Singleton

    Private Shared _Instance As Singleton = Nothing
    Private Shared ReadOnly _Sync As New Object

    Private Sub New()
    End Sub

    Public Shared ReadOnly Property Instance() As Singleton
        Get
            If _Instance Is Nothing Then
                SyncLock _Sync
                    If _Instance Is Nothing Then
                        _Instance = New Singleton()
                    End If
                End SyncLock
            End If
            Return _Instance
        End Get
    End Property

    Sub HacerAlgo()
        Throw New NotImplementedException
    End Sub

End Class

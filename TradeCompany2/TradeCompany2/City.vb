'------------------------------------------------------------------------------
' <auto-generated>
'     Этот код создан по шаблону.
'
'     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
'     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Collections.Generic

Partial Public Class City
    Public Property Id As Integer
    Public Property Value As String

    Public Overridable Property Counterparties As ICollection(Of Counterparty) = New HashSet(Of Counterparty)

End Class

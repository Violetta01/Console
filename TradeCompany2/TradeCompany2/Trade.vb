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

Partial Public Class Trade
    Public Property Id As Integer
    Public Property [Date] As Date
    Public Property SalesmanId As Integer
    Public Property BuyerId As Integer

    Public Overridable Property Counterparty As Counterparty
    Public Overridable Property Counterparty1 As Counterparty
    Public Overridable Property Goods As ICollection(Of Good) = New HashSet(Of Good)

End Class

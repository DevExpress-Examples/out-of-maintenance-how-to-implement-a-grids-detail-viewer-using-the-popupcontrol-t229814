Imports System
Imports DevExpress.Web

Partial Public Class _Default
    Inherits System.Web.UI.Page

    Protected Sub PopupControl_WindowCallback(ByVal source As Object, ByVal e As DevExpress.Web.PopupWindowCallbackArgs)
        Dim popup As ASPxPopupControl = TryCast(source, ASPxPopupControl)
        If Not String.IsNullOrEmpty(e.Parameter) Then
            CreateOrderContent(popup, Int32.Parse(e.Parameter))
        End If
    End Sub

    Private Sub CreateOrderContent(ByVal popup As ASPxPopupControl, ByVal visibleIndex As Integer)
        popup.Controls.Clear()
        Dim data() As Object = CType(GridView.GetRowValues(visibleIndex, New String() { "OrderID", "OrderDate", "ShipCountry" }), Object())
        Dim OrderID As String = data(0).ToString()

        Dim labelID As New ASPxLabel() With {.ID = "IDLabel" & OrderID, .Text = String.Format("Order ID: {0}" & ControlChars.Lf, OrderID)}
        popup.Controls.Add(labelID)

        Dim labelOrderDate As New ASPxLabel() With {.ID = "OrderDateLabel" & OrderID, .Text = String.Format("Order Date: {0}" & ControlChars.Lf, DirectCast(data(1), Date).ToUniversalTime())}
        popup.Controls.Add(labelOrderDate)

        Dim labelShipCountry As New ASPxLabel() With {.ID = "ShipCountryLabel" & OrderID, .Text = String.Format("Ship Country: {0}" & ControlChars.Lf, data(2))}
        popup.Controls.Add(labelShipCountry)
    End Sub
End Class
using System;
using DevExpress.Web;

public partial class _Default : System.Web.UI.Page {
    protected void PopupControl_WindowCallback(object source, DevExpress.Web.PopupWindowCallbackArgs e) {
        ASPxPopupControl popup = source as ASPxPopupControl;
        if(!string.IsNullOrEmpty(e.Parameter)) {
            CreateOrderContent(popup, Int32.Parse(e.Parameter));
        }
    }

    void CreateOrderContent(ASPxPopupControl popup, int visibleIndex) {
        popup.Controls.Clear();
        object[] data = (object[])GridView.GetRowValues(visibleIndex, new string[] { "OrderID", "OrderDate", "ShipCountry" });
        string OrderID = data[0].ToString();

        ASPxLabel labelID = new ASPxLabel() {
            ID = "IDLabel" + OrderID,
            Text = string.Format("Order ID: {0}\n", OrderID)
        };
        popup.Controls.Add(labelID);

        ASPxLabel labelOrderDate = new ASPxLabel() {
            ID = "OrderDateLabel" + OrderID,
            Text = string.Format("Order Date: {0}\n", ((DateTime)data[1]).ToUniversalTime())
        };
        popup.Controls.Add(labelOrderDate);

        ASPxLabel labelShipCountry = new ASPxLabel() {
            ID = "ShipCountryLabel" + OrderID,
            Text = string.Format("Ship Country: {0}\n", data[2])
        };
        popup.Controls.Add(labelShipCountry);
    }
}
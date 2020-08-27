<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<%@ Register Assembly="DevExpress.Web.v14.2, Version=14.2.17.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>How to implement a grid's detail viewer using the PopupControl</title>
    <script>
        function ShowOrderDetails(element, index) {
            if (PopupControl.GetVisible()) {
                PopupControl.SetContentHtml("");
                PopupControl.Hide();
            }
            PopupControl.ShowAtElement(element)
            PopupControl.PerformCallback(index);
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <dx:ASPxPopupControl ID="PopupControl" ClientInstanceName="PopupControl" 
            runat="server"
            HeaderText="Order Details"
            Width="250px"  
            CloseAction="CloseButton" 
            OnWindowCallback="PopupControl_WindowCallback" >
        </dx:ASPxPopupControl>

        <dx:ASPxGridView ID="GridView" ClientInstanceName="GridView" 
            runat="server" 
            DataSourceID="OrderDataSource" 
            AutoGenerateColumns="False" 
            KeyFieldName="OrderID" 
            EnableRowsCache="false">
            <Columns>
                <dx:GridViewDataTextColumn FieldName="OrderID" ReadOnly="True" VisibleIndex="0">
                    <EditFormSettings Visible="False"></EditFormSettings>
                </dx:GridViewDataTextColumn>
                <dx:GridViewDataDateColumn FieldName="OrderDate" VisibleIndex="1"></dx:GridViewDataDateColumn>
                <dx:GridViewDataColumn Caption="Show Details" VisibleIndex="2">
                    <DataItemTemplate>
                        <a href="javascript:void(0);" onclick="ShowOrderDetails(this, <%# Container.VisibleIndex %>)">Show Details ...</a>
                    </DataItemTemplate>
                </dx:GridViewDataColumn>
            </Columns>
        </dx:ASPxGridView>

        <asp:AccessDataSource ID="OrderDataSource" runat="server"
            DataFile="~/App_Data/nwind.mdb"
            SelectCommand="SELECT * FROM [Orders]">
        </asp:AccessDataSource>
    </form>
</body>
</html>

<!-- default file list -->
*Files to look at*:

* [Default.aspx](./CS/Default.aspx) (VB: [Default.aspx](./VB/Default.aspx))
* [Default.aspx.cs](./CS/Default.aspx.cs) (VB: [Default.aspx.vb](./VB/Default.aspx.vb))
<!-- default file list end -->
# How to implement a grid's detail viewer using the PopupControl


<p>This example demonstrates how to implement ASPxGridView's detail viewer using ASPxPopupControl. In this scenario, data is taken from a single data source. Not all data fields are displayed in the grid. To obtain values that are not present in the grid but exist in the data source, use ASPxGridView.GetRowValues with corresponding field names. Don't forget to disable the row cache to obtain all the values from a DataItem.</p>
<p>This example is a simplified version of <a href="http://demos.devexpress.com/aspxgridviewdemos/templates/template.aspx">this</a> demo.</p>

<br/>



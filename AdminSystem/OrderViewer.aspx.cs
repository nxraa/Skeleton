using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;
public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        clsOrders AnOrders = new clsOrders();
        AnOrders = (clsOrders)Session["AnOrders"];
        Response.Write(AnOrders.DeliveryType);
        Response.Write(AnOrders.OrderId);
        Response.Write(AnOrders.ProductId);
        Response.Write(AnOrders.QuantityNo);
        Response.Write(AnOrders.Completed);
        Response.Write(AnOrders.Date);

    }
}
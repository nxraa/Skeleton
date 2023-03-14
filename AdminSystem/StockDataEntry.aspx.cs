using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnOk_Click(object sender, EventArgs e)
    {
        //create a new instance of clsStock
        clsStock AnStock = new clsStock();
        //capture the stock number
        AnStock.ProductId = Convert.ToInt32(txtProductId.Text);
        AnStock.Name = txtName.Text;
        AnStock.Description = txtDescription.Text;
        AnStock.Price = Convert.ToInt32(txtPrice.Text);
        AnStock.StockLevel = Convert.ToInt32(txtStockLevel.Text);
        AnStock.DateAdded = Convert.ToDateTime(txtDateAdded.Text);
        AnStock.AvailableInStore = chkAvailableInStore.Checked;
        //store the address in the session object
        Session["AnStock"] = AnStock;
        //Navigate to viewer Page
        Response.Redirect("StockViewer.aspx");
    }
}
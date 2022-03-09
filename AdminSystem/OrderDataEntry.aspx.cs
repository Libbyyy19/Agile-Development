﻿using System;
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
        //new instance of clsOrder
        clsOrder AnOrder = new clsOrder();
        //get data from the session object
        AnOrder = (clsOrder)Session["AnAddress"];
        //display the user id on the page
        Response.Write(AnOrder.CustomerUserId);
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //new instance of clsOrder
        clsOrder AnOrder = new clsOrder();
        //capture order details
        AnOrder.OrderNo = txtOrderNo.Text;
        AnOrder.CustomerUserId = txtCustomerUserId.Text;
        AnOrder.OrderDate = DateTime.Parse(txtOrderDate.Text);
        AnOrder.ShippingAddress = txtShippingAddress.Text;
        AnOrder.PaymentMethod = txtPaymentMethod.Text;
        AnOrder.PaymentReceived = chkPaymentReceived.Checked;
        AnOrder.OrderStatus = txtOrderStatus.Text;
        //store the details in the session object
        Session["AnOrder"] = AnOrder;
        //navigate to the viewer page
        Response.Redirect("OrderViewer.aspx");
    }
}
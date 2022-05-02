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

    }

    protected void btnOk_Click(object sender, EventArgs e)
    {
        //create a new instance of clsStaff
        clsStaff AnStaff = new clsStaff();

        //capture the StaffFirstName
        AnStaff.StaffId = txtStaffId.Text;
        AnStaff.StaffFirstName = txtStaffFirstName.Text;
        AnStaff.StaffLastName = txtStaffLastName.Text;
        AnStaff.StaffEmail = txtStaffEmail.Text;
        AnStaff. StaffPhoneNumber = txtStaffPhoneNumber.Text;
        AnStaff. StaffWeeklyContractedHours = txtStaffPhoneNumber.Text;
        //store the StaffFirstName in the session object
        Session["AnStaff"] = AnStaff;
        //navigate to the viewer page
        Response.Redirect("StaffViewer.aspx");


    }
}
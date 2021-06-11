using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WFDB.Models;
using WFDB.Data;

namespace WFDB
{
    public partial class Edit : System.Web.UI.Page
    {
        Customer customer;
        ContextDemo context = new ContextDemo();
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = int.Parse(Request.QueryString["id"].ToString());
            LblID1.Text = id + "";
            customer = context.Customers.SingleOrDefault(c=>c.Id==id);
            if (customer == null)
            {
                Label label = new Label();
                label.ID = "LblResult";
                label.Text = "The Customer with this Id does not exists";
                label.Visible = true;
                HyperLink hlink = new HyperLink();
                hlink.Text = "Go Back To Home Page";
                hlink.NavigateUrl = "Default.aspx";
                hlink.ID = "HLinkHome";
                hlink.Visible = true;
                div1.Controls.Add(label);
                div1.Controls.Add(hlink);
                TxtDOB.Visible = false;
                TxtName.Visible = false;
                BtnSave.Visible = false;
            }
            else
            {
                if (!Page.IsPostBack)
                {
                    TxtDOB.Text = customer.DateOfBirth.ToString();
                    TxtName.Text = customer.Name;
                }
                
            }
            
        }

        protected void BtnSave_Click(object sender, EventArgs e)
        {
            int id = int.Parse(Request.QueryString["id"].ToString());
        //    LblID1.Text = id + "";
            customer = context.Customers.SingleOrDefault(c => c.Id == id);

            string name = TxtName.Text;
            DateTime dob = Convert.ToDateTime(TxtDOB.Text);
            customer.Name = name;
            customer.DateOfBirth = dob;
            context.SaveChanges();
          //  context.Dispose();
            Response.Redirect("Default.aspx");
            
        }
    }
}
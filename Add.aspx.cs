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
    public partial class Add : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnSave_Click(object sender, EventArgs e)
        {
            string name = TxtName.Text;
            DateTime DOB =  Convert.ToDateTime(TxtDOB.Text);
            string password = TxtPassword.Text;

            Customer customer = new Customer
            {
                Name = name,
                DateOfBirth = DOB,
                Password = password
            };
            ContextDemo context = new ContextDemo();
            context.Customers.Add(customer);
            context.SaveChanges();
            Response.Redirect("Default.aspx");
        }
    }
}
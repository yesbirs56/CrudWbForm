using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Entity;
using WFDB.Data;
using WFDB.Models;

namespace WFDB
{
    public partial class Default : System.Web.UI.Page
    {
        public void Update()
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<ContextDemo>());
            IEnumerable<object> customers;
            using (ContextDemo context = new ContextDemo())
            {
                context.Database.Initialize(true); // for enforcing to start the Database
                customers = context.Customers.ToList().Select(c => new { Id = c.Id, Name = c.Name, DateOfBirth = c.DateOfBirth }).ToList();
            }
            GridView1.DataSource = customers;

            GridView1.DataBind();
        }
        protected void Page_Load(object sender, EventArgs e)
        {

            Update();

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void BtnAdd_Click(object sender, EventArgs e)
        {
            Response.Redirect("Add.aspx");
        }

        protected void BtnEdit_Click(object sender, EventArgs e)
        {
            string id = TxtID.Text;
            string qs = "?id=" + id;
            Response.Redirect("Edit.aspx" + qs);
        }

        protected void BtnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse( TxtID.Text);
            using(ContextDemo context = new ContextDemo())
            {
                //Customer customer = context.Customers.SingleOrDefault(c => c.Id == id);
                //context.Customers.Remove(customer);
                //context.SaveChanges();
            }
            Update();
        }

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using opdblib_ado;

namespace OrderProcessing
{
    public partial class CustomerForm : System.Web.UI.Page
    {
        Order mdb;

        public CustomerForm() { mdb = new Order("ism6236", "ism6236bo"); }

        private void PopulateCustomerSection(String cid)
        {
            tbxCName.Text = mdb.getCustomer(cid);

            List<String> o = mdb.getCustomerOrders(cid);
            foreach (String s in o)
            {
                List<String> ods = mdb.getOrderDetails(s);
                foreach (String od in ods)
                    lstOrders.Items.Add(String.Format("{0},{1}", s, od));
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                tbxCid.Text = "1";
                PopulateCustomerSection(tbxCid.Text);
            }
        }

        protected void btnCustomer_Click(object sender, EventArgs e)
        {
            lstOrders.Items.Clear();
            PopulateCustomerSection(tbxCid.Text);
        }

        protected void btnMain_Click(object sender, EventArgs e)
        {
            Session["Cid"] = tbxCid.Text;
            Response.Redirect("Default.html");
        }
    }
}
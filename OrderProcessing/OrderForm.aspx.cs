using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using opdblib_ado;


namespace OrderProcessing
{
    public partial class OrderForm : System.Web.UI.Page
    {
        Order mdb;


        public OrderForm() { mdb = new Order("ism6236", "ism6236bo"); }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                tbxCid.Text = (string)Session["Cid"];

                List<String> pids = mdb.getProductIds();
                foreach (String pid in pids)
                {
                    String p = mdb.getProductDetail(pid);


                    lstProducts.Items.Add(String.Format("{0},{1}", pid, p));
                }
            }
            lblMessage.Visible = false;
        }

        protected void btnBuy_Click(object sender, EventArgs e)
        {
            List<String> l = new List<String>();
            int n = 0;

            int[] sinx = lstProducts.GetSelectedIndices();
            if (sinx.Length > 0) {
                for (int i = 0; i < sinx.Length; i++)
                {
                    String p = lstProducts.Items[sinx[i]].ToString();
                    int j = p.LastIndexOf(',');
                    string px = p.Substring(0, j - 1);
                    String s = String.Format("{0},{1}", px, 1);
                    l.Add(s);
                }

                n = mdb.Purchase(tbxCid.Text, l);
                if (n > 0 && (n == (2 * sinx.Length + 1)))
                    lblMessage.Text = String.Format("{0} products were ordered successfully", sinx.Length);
                else
                    lblMessage.Text = "Error in placing the order";
                

            }
            else lblMessage.Text = "Please select at least one item";

            lblMessage.Visible = true;

        }

        protected void btnMain_Click(object sender, EventArgs e)
        {
            Session["Cid"] = tbxCid.Text;
            Response.Redirect("Default.html");
        }
    }
}
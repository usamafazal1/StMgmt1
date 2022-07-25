using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace testing
{
    public partial class testing : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ViewState["Value"] = TextBox1.Text;
            TextBox1.Text = "0";
            if (IsPostBack)
            {
                int num = Convert.ToInt32(ViewState["Value"]);
                int num1 = num + 1;
                TextBox1.Text = num1.ToString();
            }
        }

    }
}
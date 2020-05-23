using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Login
{
    public partial class Welcome : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string name = "";
            string pwd = "";
            if(this.Session["userName"]!=null && this.Session["pwd"]!=null)
            {
                name = this.Session["userName"].ToString();
                pwd = this.Session["pwd"].ToString();
            }
            this.lb1Info.Text = "欢迎" + name + "登陆";
        }
    }
}
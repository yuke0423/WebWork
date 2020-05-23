using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace Login
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string str = "server=53AF;database=Web;uid=sa;pwd=yk0423yk;Trusted_Connection=no";
            SqlConnection con = new SqlConnection(str);
            con.Open();
            string sql = "select * from userInfo where userName=@userName and userPwd=@password";
            SqlCommand com = new SqlCommand(sql, con);
            com.Parameters.Add("userName", txtUser.Text.Trim());
            com.Parameters.Add("password", txtPwd.Text.Trim());
            SqlDataReader sdr = com.ExecuteReader();
            if (sdr.Read())
            {
                //Session中没有保存用户信息的
                this.Session["userName"] = this.txtUser.Text.Trim();
                this.Session["pwd"] = this.txtPwd.Text.Trim();
                this.Response.Redirect("~/Welcome.aspx");
            }
            else
            {
                this.ClientScript.RegisterStartupScript(
                    this.GetType(),
                    Guid.NewGuid().ToString(),
                    "alert('用户名或密码不正确')",
                    true
                    );

            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using System.Data;
using System.Data.SqlClient;


public partial class main  : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
        if(!IsPostBack)
        {
            
            
        }
    }

    /// <summary>
    /// ��¼
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void btnLogin_Click(object sender, EventArgs e)
    {
        SP.BLL.members bll = new SP.BLL.members();
        //�����û���������õ��û���Ϣ
        DataSet ds = bll.GetList(" lname='" + txt_lname.Text + "' and pass='" + txt_pass.Text + "'");

        //�ж��û��Ƿ����
        if (ds.Tables[0].Rows.Count > 0)
        {
            DataRow dr = ds.Tables[0].Rows[0];


            //���û���Ϣ���뵽Session
            Session["lname"] = dr["lname"].ToString();

            //��ת          
            Response.Redirect("default.aspx");

        }
        else
        {

            Page.ClientScript.RegisterStartupScript(this.GetType(), "alert", "<script>alert('�û������������');</script>");

            return;
        }
    }



    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Session.Abandon();
        Response.Redirect("default.aspx");
    }
}

using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using System.Data;
using System.Data.SqlClient;


public partial class reg  : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
        if(!IsPostBack)
        {
            
            
        }
    }

    
    /// <summary>
    /// ע��
    /// </summary>
    protected void btnSave_Click(object sender, EventArgs e)
    {
        SP.BLL.members bll = new SP.BLL.members();

        //��֤�Ƿ��Ѿ�����
        if (bll.Exists(txt_lname.Text))
        {
            Page.ClientScript.RegisterStartupScript(this.GetType(), "alert", "<script>alert('�õ�¼���Ѵ��ڣ����������룡');</script>");
            return;
        }

        if(txt_pass.Text!=txt_pass2.Text)
        {
            Page.ClientScript.RegisterStartupScript(this.GetType(), "alert", "<script>alert('�����������벻һ�£����������룡');</script>");
            return;
        }

        string addrpic = "";
        if (fppic.HasFile)
        {
            string name = this.fppic.PostedFile.FileName;
            int i = name.LastIndexOf('.');
            string extname = name.Substring(i);
            string filename = DateTime.Now.ToString("yyyyMMddhhmmssfff");
            string path = filename + extname;
            string savePath = Server.MapPath(@"uploads\" + filename + extname);
            fppic.PostedFile.SaveAs(savePath);
            addrpic = path;
        }

        string lname = txt_lname.Text;
        string pass = txt_pass.Text;
        string mname = txt_mname.Text;
        string sex = rtsex.SelectedValue;
        string tel = txt_tel.Text;
        string pic = addrpic;
        DateTime regtime = DateTime.Now;

        SP.Model.members model = new SP.Model.members();
        model.lname = lname;
        model.pass = pass;
        model.mname = mname;
        model.sex = sex;
        model.tel = tel;
        model.pic = pic;
        model.regtime = regtime;

        bll.Add(model);

        Session["lname"] = txt_lname.Text;

        Page.ClientScript.RegisterStartupScript(this.GetType(), "alert", "<script>alert('��ϲ��ע��ɹ�!');location.href='default.aspx';</script>");
    }


}
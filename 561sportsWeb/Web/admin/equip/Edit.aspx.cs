﻿using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Text;
using System.Data.SqlClient;

public partial class equip_Modify : System.Web.UI.Page
{
    SP.BLL.equip bll = new SP.BLL.equip();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            chushi();
        }
    }

   /// <summary>
    /// 初始化
    /// </summary>
    protected void chushi()
    {
        

        //根据编号得到相应的记录
        DataSet ds = bll.GetList("  id=" + Request.QueryString["id"]);
        if (ds.Tables[0].Rows.Count > 0)
        {
            txt_title.Text = ds.Tables[0].Rows[0]["title"].ToString();
            Labelpic.Text = ds.Tables[0].Rows[0]["pic"].ToString();
            if (Labelpic.Text != "" && Labelpic.Text.Length > 3)
            {
               Imagepic.ImageUrl = "../../uploads/" + Labelpic.Text;
               Imagepic.Visible = true;
             }
            Textarea1.Value = ds.Tables[0].Rows[0]["memo"].ToString();
        }
    }

    /// <summary>
    /// 编辑
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void btnSave_Click(object sender, EventArgs e)
    {
        //更新   
        string addrpic = Labelpic.Text;
        if (fppic.HasFile)
        {
            string name = this.fppic.PostedFile.FileName;
            int i = name.LastIndexOf('.');
            string extname = name.Substring(i);
            string filename = DateTime.Now.ToString("yyyyMMddhhmmssfff");
            string path = filename + extname;
            string savePath = Server.MapPath(@"..\..\uploads\" + filename + extname);
            fppic.PostedFile.SaveAs(savePath);
            addrpic = path;
        }

        string title = txt_title.Text;
        string pic = addrpic;
        string memo = Textarea1.Value;


        SP.Model.equip model = new SP.Model.equip();
        model.title = title;
        model.pic = pic;
        model.memo = memo;
        model.id = int.Parse(Request.QueryString["id"]);

        bll.Update(model);

        Page.ClientScript.RegisterStartupScript(this.GetType(), "alert", "<script>alert('操作成功，请返回!');location.href='List.aspx';</script>");
    }

}


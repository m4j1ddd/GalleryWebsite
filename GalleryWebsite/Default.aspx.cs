using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Data.OleDb;

namespace Website
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                String str;
                str = "provider=Microsoft.ACE.oledb.12.0; Data source=" + Server.MapPath("db/db.accdb") + "; persist security info = false;";
                OleDbConnection cn = new OleDbConnection(str);
                cn.Open();
                String st;
                st = "select * from table1 order by ID Desc";
                OleDbCommand cmd = new OleDbCommand(st, cn);
                OleDbDataReader dr;
                dr = cmd.ExecuteReader();
                ListView1.DataSource = dr;
                ListView1.DataBind();
                cn.Close();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text != "" && DropDownList1.SelectedIndex != 0)
            {
                String type = FileUpload1.PostedFile.ContentType;
                if (type.Contains("image"))
                {
                    String str;
                    str = "provider=Microsoft.ACE.oledb.12.0; Data source=" + Server.MapPath("db/db.accdb") + "; persist security info = false;";
                    OleDbConnection cn = new OleDbConnection(str);
                    cn.Open();
                    String st;
                    st = "select ID from table1 order by ID Desc";
                    OleDbCommand cmd = new OleDbCommand(st, cn);
                    OleDbDataReader dr;
                    dr = cmd.ExecuteReader();
                    int count = 0;
                    if (dr.Read())
                    {
                        count = int.Parse(dr.GetValue(0).ToString());
                    }
                    dr.Close();
                    count = count + 1;
                    String[] t = new String[2];

                    String nam = FileUpload1.FileName;
                    t = nam.Split('.');
                    FileUpload1.SaveAs("D:/Works/GalleryWebsite/GalleryWebsite/images/" + count + "." + t[1]);
                    String sub = DropDownList1.SelectedValue;
                    String url = "images/" + count + "." + t[1];
                    String stcmd;
                    stcmd = "insert into table1(nam, sub, url) values('" + TextBox1.Text + "', '" + sub + "', '" + url + "')";
                    cmd.CommandText = stcmd;
                    cmd.ExecuteNonQuery();
                    cn.Close();
                }
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            String str;
            str = "provider=Microsoft.ACE.oledb.12.0; Data source=" + Server.MapPath("db/db.accdb") + "; persist security info = false;";
            OleDbConnection cn = new OleDbConnection(str);
            cn.Open();
            String st;
            st = "select * from table1  where nam like '%" + TextBox2.Text + "%' order by ID Desc";
            OleDbCommand cmd = new OleDbCommand(st, cn);
            OleDbDataReader dr;
            dr = cmd.ExecuteReader();
            ListView1.DataSource = dr;
            ListView1.DataBind();
            cn.Close();
            Label1.Text = "نتایج برای جستجوی '" + TextBox2.Text + "'";
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            String str;
            str = "provider=Microsoft.ACE.oledb.12.0; Data source=" + Server.MapPath("db/db.accdb") + "; persist security info = false;";
            OleDbConnection cn = new OleDbConnection(str);
            cn.Open();
            String st;
            st = "select top 5 * from table1 order by ID Desc";
            OleDbCommand cmd = new OleDbCommand(st, cn);
            OleDbDataReader dr;
            dr = cmd.ExecuteReader();
            ListView1.DataSource = dr;
            ListView1.DataBind();
            cn.Close();
            Label1.Text = "جدیدترین عکس ها";
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            String str;
            str = "provider=Microsoft.ACE.oledb.12.0; Data source=" + Server.MapPath("db/db.accdb") + "; persist security info = false;";
            OleDbConnection cn = new OleDbConnection(str);
            cn.Open();
            String st;
            st = "select * from table1 where sub = 'سرگرمی' order by ID Desc";
            OleDbCommand cmd = new OleDbCommand(st, cn);
            OleDbDataReader dr;
            dr = cmd.ExecuteReader();
            ListView1.DataSource = dr;
            ListView1.DataBind();
            cn.Close();
            Label1.Text = "سرگرمی";
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            String str;
            str = "provider=Microsoft.ACE.oledb.12.0; Data source=" + Server.MapPath("db/db.accdb") + "; persist security info = false;";
            OleDbConnection cn = new OleDbConnection(str);
            cn.Open();
            String st;
            st = "select * from table1 where sub = 'علمی' order by ID Desc";
            OleDbCommand cmd = new OleDbCommand(st, cn);
            OleDbDataReader dr;
            dr = cmd.ExecuteReader();
            ListView1.DataSource = dr;
            ListView1.DataBind();
            cn.Close();
            Label1.Text = "علمی";
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            String str;
            str = "provider=Microsoft.ACE.oledb.12.0; Data source=" + Server.MapPath("db/db.accdb") + "; persist security info = false;";
            OleDbConnection cn = new OleDbConnection(str);
            cn.Open();
            String st;
            st = "select * from table1 where sub = 'ورزشی' order by ID Desc";
            OleDbCommand cmd = new OleDbCommand(st, cn);
            OleDbDataReader dr;
            dr = cmd.ExecuteReader();
            ListView1.DataSource = dr;
            ListView1.DataBind();
            cn.Close();
            Label1.Text = "ورزشی";
        }
    }
}

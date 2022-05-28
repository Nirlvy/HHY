using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using utils.Service;

namespace HHY
{
    public partial class list : Form
    {
        private DBService dbIris = DBService.getInstance("HHY");

        public list()
        {
            InitializeComponent();
        }

        private DataTable dt1 = new DataTable();
        private DataTable dt2 = new DataTable();
        private DataTable dt3 = new DataTable();
        private string sql1 = "SELECT id AS 书号,book AS 书名,state AS 状态,number AS 次数,user_id AS 借阅人,time AS 时间 FROM [Library].[dbo].[book]";
        private string sql2 = "SELECT time AS 借阅或归还时间,user_id AS 借阅人ID,book_id AS 书号,state AS 状态 FROM [Library].[dbo].[borrow_log]";
        private string sql3 = "SELECT [id] AS 人员ID,[name] AS 姓名,[face] AS 人脸信息,[admin] AS 管理员,[password] AS 密码 FROM [Library].[dbo].[user]";
        private SqlCommand cmd = new SqlCommand();
        private string connString = "Data Source=.;Initial Catalog=Library;Integrated Security=SSPI;";

        private void list_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connString);
            SqlDataAdapter da1 = new SqlDataAdapter(sql1, conn);
            SqlDataAdapter da2 = new SqlDataAdapter(sql2, conn);
            SqlDataAdapter da3 = new SqlDataAdapter(sql3, conn);
            da1.Fill(dt1);
            da2.Fill(dt2);
            da3.Fill(dt3);
            DGV1.DataSource = dt1;
            DGV2.DataSource = dt2;
            DGV3.DataSource = dt3;
            DGV3.Columns["人脸信息"].ReadOnly = true;
        }

        private void save_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connString);
            cmd = conn.CreateCommand();
            if (tabControl.SelectedIndex == 0)
            {
                cmd.CommandText = sql1;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                new SqlCommandBuilder(da);
                da.Update(dt1);
                dt1.Clear();
                dt2.Clear();
                dt3.Clear();
            }
            else if (tabControl.SelectedIndex == 1)
            {
                cmd.CommandText = sql2;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                new SqlCommandBuilder(da);
                da.Update(dt2);
                dt1.Clear();
                dt2.Clear();
                dt3.Clear();
            }
            else
            {
                cmd.CommandText = sql3;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                new SqlCommandBuilder(da);
                da.Update(dt3);
                dt1.Clear();
                dt2.Clear();
                dt3.Clear();
            }
            list_Load(null, null);
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Close();
            common.list = null;
            common.getAdminForm().Show();
        }
    }
}
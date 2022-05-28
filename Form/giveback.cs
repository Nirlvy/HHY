using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using utils.Service;

namespace HHY
{
    public partial class giveback : Form
    {
        private DBService dbIris = DBService.getInstance("HHY");

        public giveback()
        {
            InitializeComponent();
        }

        private DataSet ds = new DataSet();
        private string sql = "SELECT id AS 书号,book AS 书名,time AS 借阅时间 FROM [Library].[dbo].[book] WHERE user_id = '" + login.ID + "'";
        private string connString = "Data Source=.;Initial Catalog=Library;Integrated Security=SSPI;";

        private int line;

        private void giveback_Load(object sender, System.EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connString);
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            da.Fill(ds);
            DGV.DataSource = ds.Tables[0];
        }

        private void back_Click(object sender, System.EventArgs e)
        {
            this.Close();
            common.giveback = null;
            common.getUser1Form().Show();
        }

        private void DGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            line = e.RowIndex;
        }

        private void btn_giveback_Click(object sender, System.EventArgs e)
        {
            DialogResult dr = MessageBox.Show("确认要归还" + ds.Tables[0].Rows[line][1].ToString() + "吗", "确认", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                dbIris.ExecuteSql(@"UPDATE [Library].[dbo].[book] SET state = '库存' ,user_id = NULL , time = NULL WHERE id = '" + ds.Tables[0].Rows[line][0].ToString() + "'");
                dbIris.ExecuteSql(@"INSERT INTO [Library].[dbo].[borrow_log] (time,user_id,book_id,state) VALUES ('" + DateTime.Now.ToString() + "' ,'" + login.ID + "','" + ds.Tables[0].Rows[line][0] + "','归还')");
                ds.Clear();
                giveback_Load(null, null);
            }
        }
    }
}
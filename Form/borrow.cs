using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using utils.Service;

namespace HHY
{
    public partial class borrow : Form
    {
        private DBService dbIris = DBService.getInstance("HHY");

        public borrow()
        {
            InitializeComponent();
        }

        private DataSet ds = new DataSet();
        private string sql = "SELECT id AS 书号,book AS 书名,book_count AS 库存,borrow_count AS 借阅次数 FROM [Library].[dbo].[book] AS TEMP WHERE book_count != 0 AND id NOT IN (SELECT book_id AS borrow_id FROM [Library].[dbo].[book_borrow] WHERE user_id = " + login.ID + " )";
        private string connString = "Data Source=.;Initial Catalog=Library;Integrated Security=SSPI;";

        private int line;

        private void borrow_Load(object sender, System.EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connString);
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            da.Fill(ds);
            DGV.DataSource = ds.Tables[0];
        }

        private void back_Click(object sender, System.EventArgs e)
        {
            this.Close();
            common.borrow = null;
            common.getUser1Form().Show();
        }

        private void DGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            line = e.RowIndex;
        }

        private void btn_borrow_Click(object sender, System.EventArgs e)
        {
            DialogResult dr = MessageBox.Show("确认要借阅" + ds.Tables[0].Rows[line][1].ToString() + "吗", "确认", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                dbIris.ExecuteSql(@"UPDATE [Library].[dbo].[book] SET borrow_count = '" + (int.Parse(ds.Tables[0].Rows[line][3].ToString()) + 1).ToString() + "',book_count = '" + (int.Parse(ds.Tables[0].Rows[line][2].ToString()) - 1).ToString() + "' WHERE id = " + int.Parse(ds.Tables[0].Rows[line][0].ToString()) + "");
                dbIris.ExecuteSql(@"INSERT INTO [Library].[dbo].[book_borrow] (book_id,user_id,time) VALUES(" + int.Parse(ds.Tables[0].Rows[line][0].ToString()) + "," + login.ID + ",'" + DateTime.Now.ToString("d") + "')");
                dbIris.ExecuteSql(@"INSERT INTO [Library].[dbo].[borrow_log] (time,user_id,book_id,state) VALUES ('" + DateTime.Now.ToString("G") + "' ,'" + login.ID + "','" + ds.Tables[0].Rows[line][0] + "','借出')");
                ds.Clear();
                borrow_Load(null, null);
            }
        }
    }
}
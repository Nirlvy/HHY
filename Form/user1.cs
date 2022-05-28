using System;
using System.Data;
using System.Windows.Forms;
using utils.Service;

namespace HHY
{
    public partial class user1 : Form
    {
        private DBService dbIris = DBService.getInstance("HHY");

        public user1()
        {
            InitializeComponent();
        }

        private void user1_Load(object sender, EventArgs e)
        {
            tip1.Text = login.name;
            DataTable dt;
            dt = dbIris.GetDataTableBySql(@"SELECT * FROM [Library].[dbo].[book] where user_id=" + login.ID + "ORDER BY time");
            int count = dt.Rows.Count;
            borrow.Text = "借书(你还可借" + (3 - count) + "本书)";
            if (count >= 3)
                borrow.Enabled = false;
            if (count != 0)
            {
                string time = Convert.ToDateTime(dt.Rows[0][5].ToString()).AddDays(14).ToString("yyyy/MM/dd");
                giveback.Text = "还书（最近时间为" + time + ")";
            }
        }

        private void borrow_Click(object sender, EventArgs e)
        {
            this.Close();
            common.user1 = null;
            common.getBorrowForm().Show();
        }

        private void giveback_Click(object sender, EventArgs e)
        {
            this.Close();
            common.user1 = null;
            common.getGivebackForm().Show();
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Close();
            common.user1 = null;
            common.getLoginForm().Show();
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HHY
{
    public partial class user1 : Form
    {
        public user1()
        {
            InitializeComponent();
        }

        private void user1_Load(object sender, EventArgs e)
        {
            tip1.Text = login.name;
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
    }
}

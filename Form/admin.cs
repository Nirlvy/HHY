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
    public partial class admin : Form
    {
        public admin()
        {
            InitializeComponent();
        }

        private void admin_Load(object sender, EventArgs e)
        {
            tip1.Text = login.name;
        }

        private void list_Click(object sender, EventArgs e)
        {
            this.Close();
            common.admin = null;
            common.getListForm().Show();
        }

        private void sign_up_Click(object sender, EventArgs e)
        {
             this.Close();
            common.admin = null;
            common.getSign_upForm().Show();
        }
    }
}

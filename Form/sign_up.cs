using AForge.Video.DirectShow;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using utils.Service;

namespace HHY
{
    public partial class sign_up : Form
    {
        private DBService dbIris = DBService.getInstance("HHY");

        private FilterInfoCollection videoDevices;
        private VideoCaptureDevice videoDevice;
        private VideoCapabilities[] videoCapabilities;

        private string base64_img;

        public sign_up()
        {
            InitializeComponent();
        }

        private void sign_up_Load(object sender, System.EventArgs e)
        {
            videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            videoDevice = new VideoCaptureDevice(videoDevices[0].MonikerString);
            videoCapabilities = videoDevice.VideoCapabilities;
        }

        private void DisConnect()
        {
            if (vispShoot.VideoSource != null)
            {
                vispShoot.SignalToStop();
                vispShoot.WaitForStop();
                vispShoot.VideoSource = null;
            }
        }

        private void timer_Tick(object sender, System.EventArgs e)
        {
            timer.Enabled = false;

            Bitmap img = vispShoot.GetCurrentVideoFrame();
            string temp = @".\temp\temp.jpeg";
            img.Save(temp, System.Drawing.Imaging.ImageFormat.Jpeg);
            img.Dispose();
            pic.BackgroundImage = Image.FromFile(temp);
            DisConnect();
            base64_img = base64.ImageToBase64(temp);
        }

        private void shoot_Click(object sender, System.EventArgs e)
        {
            if ((videoCapabilities != null) && (videoCapabilities.Length != 0))
            {
                videoDevice.VideoResolution = videoCapabilities[0];

                vispShoot.VideoSource = videoDevice;
                vispShoot.Start();

                timer.Enabled = true;
            }
        }

        private void save_Click(object sender, System.EventArgs e)
        {
            string id = tb_id.Text;
            string name = tb_name.Text;

            DataTable dt;
            dt = dbIris.GetDataTableBySql(@"SELECT * FROM [Library].[dbo].[user] where id=" + id);
            if (dt.Rows.Count != 0)
            {
                MessageBox.Show("该学号已注册！！！");
            }
            else
            {
                dbIris.ExecuteSql(@"INSERT INTO [Library].[dbo].[user] ([id],[name],[face],[admin],[password]) VALUES ('" + id + "' ,'" + name + "','" + base64_img + "','否',NULL)");
            }
        }

        private void sign_up_FormClosing(object sender, FormClosingEventArgs e)
        {
            pic.BackgroundImage = null;
            File.Delete(@".\temp\temp.jpeg");
        }

        private void check_Tick(object sender, System.EventArgs e)
        {
            if (tb_id.Text != "" && tb_name.Text != "")
                shoot.Enabled = true;
            else
                shoot.Enabled = false;
            if (pic.BackgroundImage != null)
                save.Enabled = true;
            else
                save.Enabled = false;
        }

        private void back_Click(object sender, System.EventArgs e)
        {
            this.Close();
            common.sign_up = null;
            common.getAdminForm().Show();
        }
    }
}
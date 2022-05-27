using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using utils.Service;
using AForge.Video.DirectShow;
using System.IO;

namespace HHY
{
    public partial class login : Form
    {
        DBService dbIris = DBService.getInstance("HHY");

        private FilterInfoCollection videoDevices;
        private VideoCaptureDevice videoDevice;
        private VideoCapabilities[] videoCapabilities;

        public login()
        {
            InitializeComponent();
        }

        public static string name;

        private void login_Load(object sender, EventArgs e)
        {
            videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            videoDevice = new VideoCaptureDevice(videoDevices[0].MonikerString);
            GetDeviceResolution(videoDevice);
        }

        private void GetDeviceResolution(VideoCaptureDevice videoCaptureDevice)
        {
            videoCapabilities = videoCaptureDevice.VideoCapabilities;
        }

        private void DisConnect()
        {
            if (vispShoot.VideoSource != null)
            {
                vispShoot.SignalToStop();
                vispShoot.WaitForStop();
                vispShoot.VideoSource = null;
            }
            vispShoot.Visible = false;
            tip.Visible = false;
            timer.Enabled = false;
        }

        private void btnReco_Click(object sender, EventArgs e)
        {
            if (Reco.Text == "识别")
            {
                if (textBox1.Text == "")
                    MessageBox.Show("请输入ID");
                else
                {
                    textBox1.ReadOnly = true;
                    Reco.Text = "重置";
                    if (videoDevice != null)
                    {
                        if ((videoCapabilities != null) && (videoCapabilities.Length != 0))
                        {
                            videoDevice.VideoResolution = videoCapabilities[0];

                            vispShoot.VideoSource = videoDevice;
                            vispShoot.Start();

                            timer.Enabled = true;
                            vispShoot.Visible = true;
                            tip.Visible = true;
                        }
                    }
                }
            }
            else
            {
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox1.ReadOnly = false;
                Reco.Text = "识别";
                DisConnect();
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            timer.Enabled = false;

            string id, code;
            id = textBox1.Text;
            code = textBox2.Text;

            DataTable dt;
            dt = dbIris.GetDataTableBySql(@"SELECT * FROM [Library].[dbo].[user] where id=" + id);
            int count = dt.Rows.Count;
            if (count == 0)
            {
                MessageBox.Show("用户未注册！！！");
            }
            else
            {
                Bitmap img = vispShoot.GetCurrentVideoFrame();
                string temp = @".\temp\temp.jpeg";
                img.Save(temp, System.Drawing.Imaging.ImageFormat.Jpeg);
                img.Dispose();
                DisConnect();
                string base64_1 = base64.ImageToBase64(temp);
                File.Delete(@".\temp\temp.jpeg");
                string base64_2 = dt.Rows[0][2].ToString();
                name = dt.Rows[0][1].ToString();

                if (radioButton1.Checked == true)//用户
                {
                    float score = float.Parse(AccessToken.faceMatch(base64_1, base64_2));
                    if (score > 80)
                    {
                        MessageBox.Show("欢迎" + dt.Rows[0][1].ToString() + "同学");
                        textBox3.Text = dt.Rows[0][1].ToString();
                        //System.Threading.Thread.Sleep(3000);
                        this.Hide();
                        common.getUser1Form().Show();
                    }
                    else
                    {
                        MessageBox.Show("id和人脸识别不匹配！！！请检查");
                    }
                }
                else if (radioButton2.Checked == true)//管理员
                {
                    if (dt.Rows[0][3].ToString() == "True" && code == dt.Rows[0][4].ToString())
                    {
                        float score = float.Parse(AccessToken.faceMatch(base64_1, base64_2));
                        if (score > 80)
                        {
                            //MessageBox.Show("欢迎" + dt.Rows[0][1].ToString() + "同学");
                            textBox3.Text = dt.Rows[0][1].ToString();
                            //System.Threading.Thread.Sleep(3000);
                            //this.Close();
                            //common.login = null;
                            //common.getUser1Form().Show();
                        }
                        else
                        {
                            MessageBox.Show("id和人脸识别不匹配！！！请检查");
                        }
                    }
                    else
                    {
                        MessageBox.Show("你不是管理员或者密码错误！！！");
                    }
                }
            }
        }

        private void timenow_Tick(object sender, EventArgs e)
        {
            label7.Text = DateTime.Now.ToString();
            if (radioButton1.Checked == true)
            {
                label3.Visible = false;
                textBox2.Visible = false;
            }
            else
            {
                label3.Visible = true;
                textBox2.Visible = true;
            }
        }

        private void login_FormClosing(object sender, FormClosingEventArgs e)
        {
            DisConnect();
        }
    }
}

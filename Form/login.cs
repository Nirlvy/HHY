using System;
using System.Collections.Generic;
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
        public Dictionary<int, Dictionary<string, string>> userInfo = new Dictionary<int, Dictionary<string, string>>();
        DBService dbIris = DBService.getInstance("HYY");

        private FilterInfoCollection videoDevices;
        private VideoCaptureDevice videoDevice;
        private VideoCapabilities[] videoCapabilities;

        public login()
        {
            InitializeComponent();
        }

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

        private void btn_Click(object sender, EventArgs e)
        {
            if (videoDevice != null)
            {
                if ((videoCapabilities != null) && (videoCapabilities.Length != 0))
                {
                    videoDevice.VideoResolution = videoCapabilities[0];

                    vispShoot.VideoSource = videoDevice;
                    vispShoot.Start();
                }
            }
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

        private void btnShoot_Click(object sender, EventArgs e)
        {
            Bitmap img = vispShoot.GetCurrentVideoFrame();
            img.Save(@".\temp\temp.jpeg", System.Drawing.Imaging.ImageFormat.Jpeg);
        }

        public static string GetBase64(string path)
        {
            using (var fs = new FileStream(path, FileMode.Open))
            {
                fs.Seek(0, SeekOrigin.Begin);
                int count = Convert.ToInt32(fs.Length);
                byte[] bs = new byte[count];
                fs.Read(bs, 0, count);
                return Convert.ToBase64String(bs);
            }
        }


        private void btnReco_Click(object sender, EventArgs e)
        {
            string id, code, face;
            id = textBox1.Text;
            code = textBox2.Text;
            face = textBox3.Text;
            if (Reco.Text == "识别")
            {
                if (textBox1.Text == "")
                    MessageBox.Show("请输入ID");
                else
                {
                    textBox1.ReadOnly = true;
                    Reco.Text = "重置";
                    if (radioButton1.Checked == true)//用户
                    {
                        if (face == "匹配")
                        {
                            DataTable dt;
                            dt = dbIris.GetDataTableBySql(@"SELECT name,face FROM [Library].[dbo].[user] where id=" + id);
                            int count = dt.Rows.Count;
                            if (count == 0)
                            {
                                MessageBox.Show("用户未注册！！！");
                            }
                            else
                            {
                                int line = 0;
                                do
                                {
                                    if (face == dt.Rows[line][0].ToString())
                                    {
                                        MessageBox.Show("欢迎" + dt.Rows[line][0].ToString() + "同学");
                                        System.Threading.Thread.Sleep(3000);
                                        this.Close();
                                        common.login = null;
                                        //common.getUser1Form().Show();
                                        break;
                                    }
                                    line++;
                                } while (line <= count);
                                MessageBox.Show("id和人脸识别不匹配！！！请检查");
                            }
                        }
                    }
                    if (radioButton2.Checked == true)//管理员
                    {
                        if (id != "" && face != "" && code != "")
                        {
                            DataTable dt;
                            dt = dbIris.GetDataTableBySql(@"SELECT face,code FROM [Library].[dbo].[admin] where id=" + id + "");
                            int count = dt.Rows.Count;
                            if (count == 0)
                            {
                                MessageBox.Show("用户未注册！！！");
                            }
                            else
                            {
                                int line = 0;
                                do
                                {
                                    if ((face == dt.Rows[line][0].ToString()) && (code == dt.Rows[line][1].ToString()))
                                    {
                                        MessageBox.Show("欢迎" + Name + "管理员");
                                        System.Threading.Thread.Sleep(3000);
                                        this.Close();
                                        common.login = null;
                                        //common.getAdmin11Form().Show();
                                        break;
                                    }
                                    line++;
                                } while (line <= count);
                                MessageBox.Show("id和人脸识别或者密码不匹配！！！请检查");
                            }
                        }
                    }
                }
            };
            
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


namespace HHY
{
    partial class sign_up
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(sign_up));
            this.lb_name = new System.Windows.Forms.Label();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.lb_id = new System.Windows.Forms.Label();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.vispShoot = new AForge.Controls.VideoSourcePlayer();
            this.shoot = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.pic = new System.Windows.Forms.PictureBox();
            this.check = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_name
            // 
            this.lb_name.AutoSize = true;
            this.lb_name.BackColor = System.Drawing.Color.Transparent;
            this.lb_name.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_name.Location = new System.Drawing.Point(40, 207);
            this.lb_name.Name = "lb_name";
            this.lb_name.Size = new System.Drawing.Size(69, 20);
            this.lb_name.TabIndex = 0;
            this.lb_name.Text = "姓名：";
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(103, 207);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(100, 21);
            this.tb_name.TabIndex = 1;
            // 
            // lb_id
            // 
            this.lb_id.AutoSize = true;
            this.lb_id.BackColor = System.Drawing.Color.Transparent;
            this.lb_id.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_id.Location = new System.Drawing.Point(40, 135);
            this.lb_id.Name = "lb_id";
            this.lb_id.Size = new System.Drawing.Size(69, 20);
            this.lb_id.TabIndex = 0;
            this.lb_id.Text = "学号：";
            // 
            // tb_id
            // 
            this.tb_id.Location = new System.Drawing.Point(103, 135);
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(100, 21);
            this.tb_id.TabIndex = 1;
            // 
            // vispShoot
            // 
            this.vispShoot.Location = new System.Drawing.Point(255, 11);
            this.vispShoot.Name = "vispShoot";
            this.vispShoot.Size = new System.Drawing.Size(200, 120);
            this.vispShoot.TabIndex = 2;
            this.vispShoot.Text = "videoSourcePlayer1";
            this.vispShoot.VideoSource = null;
            // 
            // shoot
            // 
            this.shoot.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.shoot.ForeColor = System.Drawing.SystemColors.ControlText;
            this.shoot.Location = new System.Drawing.Point(237, 159);
            this.shoot.Name = "shoot";
            this.shoot.Size = new System.Drawing.Size(106, 44);
            this.shoot.TabIndex = 3;
            this.shoot.Text = "拍照";
            this.shoot.UseVisualStyleBackColor = true;
            this.shoot.Click += new System.EventHandler(this.shoot_Click);
            // 
            // save
            // 
            this.save.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.save.Location = new System.Drawing.Point(368, 159);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(106, 44);
            this.save.TabIndex = 3;
            this.save.Text = "保存";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(3, 336);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(60, 22);
            this.back.TabIndex = 3;
            this.back.Text = "返回";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // timer
            // 
            this.timer.Interval = 3000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // pic
            // 
            this.pic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pic.Location = new System.Drawing.Point(255, 227);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(200, 113);
            this.pic.TabIndex = 4;
            this.pic.TabStop = false;
            // 
            // check
            // 
            this.check.Enabled = true;
            this.check.Tick += new System.EventHandler(this.check_Tick);
            // 
            // sign_up
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HHY.Properties.Resources.a87219f6e21e792647b69b661e5495ee;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.pic);
            this.Controls.Add(this.save);
            this.Controls.Add(this.back);
            this.Controls.Add(this.shoot);
            this.Controls.Add(this.vispShoot);
            this.Controls.Add(this.tb_id);
            this.Controls.Add(this.lb_id);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.lb_name);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "sign_up";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "sign_up";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.sign_up_FormClosing);
            this.Load += new System.EventHandler(this.sign_up_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_name;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.Label lb_id;
        private System.Windows.Forms.TextBox tb_id;
        private AForge.Controls.VideoSourcePlayer vispShoot;
        private System.Windows.Forms.Button shoot;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.PictureBox pic;
        private System.Windows.Forms.Timer check;
    }
}
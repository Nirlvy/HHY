
namespace HHY
{
    partial class list
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(list));
            this.tabControl = new System.Windows.Forms.TabControl();
            this.book = new System.Windows.Forms.TabPage();
            this.DGV1 = new System.Windows.Forms.DataGridView();
            this.borror_log = new System.Windows.Forms.TabPage();
            this.DGV2 = new System.Windows.Forms.DataGridView();
            this.user = new System.Windows.Forms.TabPage();
            this.DGV3 = new System.Windows.Forms.DataGridView();
            this.save = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.book.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV1)).BeginInit();
            this.borror_log.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV2)).BeginInit();
            this.user.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV3)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.book);
            this.tabControl.Controls.Add(this.borror_log);
            this.tabControl.Controls.Add(this.user);
            this.tabControl.Location = new System.Drawing.Point(2, 1);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(426, 357);
            this.tabControl.TabIndex = 0;
            // 
            // book
            // 
            this.book.Controls.Add(this.DGV1);
            this.book.Location = new System.Drawing.Point(4, 22);
            this.book.Name = "book";
            this.book.Padding = new System.Windows.Forms.Padding(3);
            this.book.Size = new System.Drawing.Size(418, 331);
            this.book.TabIndex = 0;
            this.book.Text = "书籍目录";
            this.book.UseVisualStyleBackColor = true;
            // 
            // DGV1
            // 
            this.DGV1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DGV1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV1.Location = new System.Drawing.Point(0, 0);
            this.DGV1.Name = "DGV1";
            this.DGV1.RowTemplate.Height = 23;
            this.DGV1.Size = new System.Drawing.Size(418, 331);
            this.DGV1.TabIndex = 0;
            // 
            // borror_log
            // 
            this.borror_log.Controls.Add(this.DGV2);
            this.borror_log.Location = new System.Drawing.Point(4, 22);
            this.borror_log.Name = "borror_log";
            this.borror_log.Padding = new System.Windows.Forms.Padding(3);
            this.borror_log.Size = new System.Drawing.Size(418, 331);
            this.borror_log.TabIndex = 1;
            this.borror_log.Text = "借阅记录";
            this.borror_log.UseVisualStyleBackColor = true;
            // 
            // DGV2
            // 
            this.DGV2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DGV2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV2.Location = new System.Drawing.Point(0, 0);
            this.DGV2.Name = "DGV2";
            this.DGV2.RowTemplate.Height = 23;
            this.DGV2.Size = new System.Drawing.Size(418, 331);
            this.DGV2.TabIndex = 1;
            // 
            // user
            // 
            this.user.Controls.Add(this.DGV3);
            this.user.Location = new System.Drawing.Point(4, 22);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(418, 331);
            this.user.TabIndex = 2;
            this.user.Text = "用户列表";
            this.user.UseVisualStyleBackColor = true;
            // 
            // DGV3
            // 
            this.DGV3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV3.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DGV3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV3.Location = new System.Drawing.Point(0, 0);
            this.DGV3.Name = "DGV3";
            this.DGV3.RowTemplate.Height = 23;
            this.DGV3.Size = new System.Drawing.Size(418, 331);
            this.DGV3.TabIndex = 1;
            // 
            // save
            // 
            this.save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(76)))), ((int)(((byte)(118)))));
            this.save.FlatAppearance.BorderSize = 0;
            this.save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.save.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.save.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.save.Location = new System.Drawing.Point(430, 234);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(53, 42);
            this.save.TabIndex = 1;
            this.save.Text = "保存";
            this.save.UseVisualStyleBackColor = false;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(84)))), ((int)(((byte)(134)))));
            this.back.FlatAppearance.BorderSize = 0;
            this.back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.back.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.back.Location = new System.Drawing.Point(430, 292);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(53, 42);
            this.back.TabIndex = 1;
            this.back.Text = "返回";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // list
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HHY.Properties.Resources.a87219f6e21e792647b69b661e5495ee;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.back);
            this.Controls.Add(this.save);
            this.Controls.Add(this.tabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "list";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "list";
            this.Load += new System.EventHandler(this.list_Load);
            this.tabControl.ResumeLayout(false);
            this.book.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV1)).EndInit();
            this.borror_log.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV2)).EndInit();
            this.user.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage book;
        private System.Windows.Forms.DataGridView DGV1;
        private System.Windows.Forms.TabPage borror_log;
        private System.Windows.Forms.DataGridView DGV2;
        private System.Windows.Forms.TabPage user;
        private System.Windows.Forms.DataGridView DGV3;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button back;
    }
}
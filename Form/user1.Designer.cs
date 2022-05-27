
namespace HHY
{
    partial class user1
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
            this.borrow = new System.Windows.Forms.Button();
            this.giveback = new System.Windows.Forms.Button();
            this.tip2 = new System.Windows.Forms.Label();
            this.tip1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // borrow
            // 
            this.borrow.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.borrow.ForeColor = System.Drawing.SystemColors.ControlText;
            this.borrow.Location = new System.Drawing.Point(127, 127);
            this.borrow.Name = "borrow";
            this.borrow.Size = new System.Drawing.Size(225, 65);
            this.borrow.TabIndex = 0;
            this.borrow.Text = "借书";
            this.borrow.UseVisualStyleBackColor = true;
            this.borrow.Click += new System.EventHandler(this.borrow_Click);
            // 
            // giveback
            // 
            this.giveback.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.giveback.Location = new System.Drawing.Point(127, 246);
            this.giveback.Name = "giveback";
            this.giveback.Size = new System.Drawing.Size(225, 65);
            this.giveback.TabIndex = 0;
            this.giveback.Text = "还书";
            this.giveback.UseVisualStyleBackColor = true;
            this.giveback.Click += new System.EventHandler(this.giveback_Click);
            // 
            // tip2
            // 
            this.tip2.AutoSize = true;
            this.tip2.BackColor = System.Drawing.Color.Transparent;
            this.tip2.Font = new System.Drawing.Font("宋体", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tip2.Location = new System.Drawing.Point(210, 52);
            this.tip2.Name = "tip2";
            this.tip2.Size = new System.Drawing.Size(155, 35);
            this.tip2.TabIndex = 1;
            this.tip2.Text = "同学你好";
            // 
            // tip1
            // 
            this.tip1.AutoSize = true;
            this.tip1.BackColor = System.Drawing.Color.Transparent;
            this.tip1.Font = new System.Drawing.Font("宋体", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tip1.Location = new System.Drawing.Point(130, 52);
            this.tip1.Name = "tip1";
            this.tip1.Size = new System.Drawing.Size(0, 35);
            this.tip1.TabIndex = 1;
            // 
            // user1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HHY.Properties.Resources.a87219f6e21e792647b69b661e5495ee;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.tip1);
            this.Controls.Add(this.tip2);
            this.Controls.Add(this.giveback);
            this.Controls.Add(this.borrow);
            this.Name = "user1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "user1";
            this.Load += new System.EventHandler(this.user1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button borrow;
        private System.Windows.Forms.Button giveback;
        private System.Windows.Forms.Label tip2;
        private System.Windows.Forms.Label tip1;
    }
}
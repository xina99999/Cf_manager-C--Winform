namespace Cf_manager
{
    partial class btn_exit
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.BtnDN = new System.Windows.Forms.Button();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtUser_name = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(252, 51);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(296, 155);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(308, 362);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(171, 37);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnDK_Click);
            // 
            // BtnDN
            // 
            this.BtnDN.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnDN.Location = new System.Drawing.Point(308, 310);
            this.BtnDN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnDN.Name = "BtnDN";
            this.BtnDN.Size = new System.Drawing.Size(171, 37);
            this.BtnDN.TabIndex = 9;
            this.BtnDN.Text = "Đăng Nhập";
            this.BtnDN.UseVisualStyleBackColor = true;
            this.BtnDN.Click += new System.EventHandler(this.BtnDN_Click);
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(308, 271);
            this.txtPass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(172, 22);
            this.txtPass.TabIndex = 8;
            this.txtPass.Text = "Mật khẩu";
            // 
            // txtUser_name
            // 
            this.txtUser_name.Location = new System.Drawing.Point(308, 233);
            this.txtUser_name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUser_name.Name = "txtUser_name";
            this.txtUser_name.Size = new System.Drawing.Size(172, 22);
            this.txtUser_name.TabIndex = 7;
            this.txtUser_name.Text = "Tên đang nhập";
            // 
            // btn_exit
            // 
            this.AcceptButton = this.BtnDN;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnDN;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.BtnDN);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtUser_name);
            this.Name = "btn_exit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Manchinh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button BtnDN;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtUser_name;
    }
}
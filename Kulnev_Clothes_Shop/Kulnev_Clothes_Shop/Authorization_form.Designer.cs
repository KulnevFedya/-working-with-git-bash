namespace Kulnev_Clothes_Shop
{
    partial class Authorization_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Authorization_form));
            this.txtboxLogin = new System.Windows.Forms.TextBox();
            this.txtboxPassword = new System.Windows.Forms.TextBox();
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.btnEnter = new System.Windows.Forms.Button();
            this.lblwelcome = new System.Windows.Forms.Label();
            this.picBoxCapcha = new System.Windows.Forms.PictureBox();
            this.txtBoxCapcha = new System.Windows.Forms.TextBox();
            this.btnCapcha = new System.Windows.Forms.Button();
            this.timer_for_blocking = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.imageListcapcha = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxCapcha)).BeginInit();
            this.SuspendLayout();
            // 
            // txtboxLogin
            // 
            this.txtboxLogin.Location = new System.Drawing.Point(96, 97);
            this.txtboxLogin.Name = "txtboxLogin";
            this.txtboxLogin.Size = new System.Drawing.Size(112, 20);
            this.txtboxLogin.TabIndex = 0;
            // 
            // txtboxPassword
            // 
            this.txtboxPassword.Location = new System.Drawing.Point(96, 152);
            this.txtboxPassword.Name = "txtboxPassword";
            this.txtboxPassword.Size = new System.Drawing.Size(112, 20);
            this.txtboxPassword.TabIndex = 1;
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Location = new System.Drawing.Point(129, 81);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(38, 13);
            this.lblLogin.TabIndex = 2;
            this.lblLogin.Text = "Логин";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(129, 136);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(45, 13);
            this.lblPassword.TabIndex = 3;
            this.lblPassword.Text = "Пароль";
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(107, 330);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(88, 48);
            this.btnEnter.TabIndex = 4;
            this.btnEnter.Text = "Вход";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // lblwelcome
            // 
            this.lblwelcome.AutoSize = true;
            this.lblwelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblwelcome.Location = new System.Drawing.Point(49, 28);
            this.lblwelcome.Name = "lblwelcome";
            this.lblwelcome.Size = new System.Drawing.Size(199, 32);
            this.lblwelcome.TabIndex = 5;
            this.lblwelcome.Text = "Добро пожаловать в магазин\r\n \"Встречают по одежке\"";
            this.lblwelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picBoxCapcha
            // 
            this.picBoxCapcha.Location = new System.Drawing.Point(77, 178);
            this.picBoxCapcha.Name = "picBoxCapcha";
            this.picBoxCapcha.Size = new System.Drawing.Size(148, 109);
            this.picBoxCapcha.TabIndex = 6;
            this.picBoxCapcha.TabStop = false;
            // 
            // txtBoxCapcha
            // 
            this.txtBoxCapcha.Location = new System.Drawing.Point(77, 293);
            this.txtBoxCapcha.Name = "txtBoxCapcha";
            this.txtBoxCapcha.Size = new System.Drawing.Size(77, 20);
            this.txtBoxCapcha.TabIndex = 7;
            // 
            // btnCapcha
            // 
            this.btnCapcha.Location = new System.Drawing.Point(160, 293);
            this.btnCapcha.Name = "btnCapcha";
            this.btnCapcha.Size = new System.Drawing.Size(65, 20);
            this.btnCapcha.TabIndex = 8;
            this.btnCapcha.Text = "Ввод";
            this.btnCapcha.UseVisualStyleBackColor = true;
            // 
            // timer_for_blocking
            // 
            this.timer_for_blocking.Tick += new System.EventHandler(this.timer_for_blocking_Tick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(96, 384);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 22);
            this.button1.TabIndex = 9;
            this.button1.Text = "Вход как гость";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // imageListcapcha
            // 
            this.imageListcapcha.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListcapcha.ImageStream")));
            this.imageListcapcha.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListcapcha.Images.SetKeyName(0, "6ne3.png");
            this.imageListcapcha.Images.SetKeyName(1, "e5hb.png");
            this.imageListcapcha.Images.SetKeyName(2, "xdhyn.png");
            // 
            // Authorization_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 412);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnCapcha);
            this.Controls.Add(this.txtBoxCapcha);
            this.Controls.Add(this.picBoxCapcha);
            this.Controls.Add(this.lblwelcome);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.txtboxPassword);
            this.Controls.Add(this.txtboxLogin);
            this.Name = "Authorization_form";
            this.Text = "Авторизация";
            this.Load += new System.EventHandler(this.Authorization_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxCapcha)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtboxLogin;
        private System.Windows.Forms.TextBox txtboxPassword;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Label lblwelcome;
        private System.Windows.Forms.PictureBox picBoxCapcha;
        private System.Windows.Forms.TextBox txtBoxCapcha;
        private System.Windows.Forms.Button btnCapcha;
        private System.Windows.Forms.Timer timer_for_blocking;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ImageList imageListcapcha;
    }
}
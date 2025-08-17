namespace ProgramUI
{
    partial class LoadForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoadForm));
            this.txt_username = new Sunny.UI.UITextBox();
            this.txt_password = new Sunny.UI.UITextBox();
            this.uiButton1 = new Sunny.UI.UIButton();
            this.btn_exit = new Sunny.UI.UIButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.titleBar = new Sunny.UI.UIPanel();
            this.uiLabel2 = new Sunny.UI.UILabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_username
            // 
            this.txt_username.BackColor = System.Drawing.Color.Transparent;
            this.txt_username.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_username.FillColor = System.Drawing.SystemColors.Window;
            this.txt_username.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_username.Icon = global::ProgramUI.Properties.Resources.农民;
            this.txt_username.Location = new System.Drawing.Point(69, 202);
            this.txt_username.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txt_username.MinimumSize = new System.Drawing.Size(1, 19);
            this.txt_username.Name = "txt_username";
            this.txt_username.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txt_username.RectColor = System.Drawing.Color.Transparent;
            this.txt_username.ShowText = false;
            this.txt_username.Size = new System.Drawing.Size(343, 38);
            this.txt_username.TabIndex = 2;
            this.txt_username.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txt_username.Watermark = "";
            // 
            // txt_password
            // 
            this.txt_password.BackColor = System.Drawing.Color.Transparent;
            this.txt_password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_password.FillColor = System.Drawing.SystemColors.Window;
            this.txt_password.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_password.Icon = global::ProgramUI.Properties.Resources.农业_密码;
            this.txt_password.Location = new System.Drawing.Point(69, 272);
            this.txt_password.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txt_password.MinimumSize = new System.Drawing.Size(1, 19);
            this.txt_password.Name = "txt_password";
            this.txt_password.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txt_password.PasswordChar = '*';
            this.txt_password.RectColor = System.Drawing.Color.Transparent;
            this.txt_password.ShowText = false;
            this.txt_password.Size = new System.Drawing.Size(343, 38);
            this.txt_password.TabIndex = 3;
            this.txt_password.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txt_password.Watermark = "";
            // 
            // uiButton1
            // 
            this.uiButton1.BackColor = System.Drawing.Color.Transparent;
            this.uiButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.uiButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton1.FillColor = System.Drawing.Color.Green;
            this.uiButton1.FillColor2 = System.Drawing.SystemColors.MenuHighlight;
            this.uiButton1.FillColorGradient = true;
            this.uiButton1.FillColorGradientDirection = System.Windows.Forms.FlowDirection.LeftToRight;
            this.uiButton1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiButton1.Location = new System.Drawing.Point(69, 355);
            this.uiButton1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.uiButton1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton1.Name = "uiButton1";
            this.uiButton1.Radius = 35;
            this.uiButton1.RectColor = System.Drawing.Color.Transparent;
            this.uiButton1.RectDisableColor = System.Drawing.Color.Transparent;
            this.uiButton1.RectHoverColor = System.Drawing.Color.Black;
            this.uiButton1.RectPressColor = System.Drawing.Color.Transparent;
            this.uiButton1.RectSelectedColor = System.Drawing.Color.Transparent;
            this.uiButton1.ShowFocusLine = true;
            this.uiButton1.Size = new System.Drawing.Size(343, 42);
            this.uiButton1.TabIndex = 4;
            this.uiButton1.Text = "登录";
            this.uiButton1.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiButton1.Click += new System.EventHandler(this.uiButton1_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_exit.BackColor = System.Drawing.Color.Transparent;
            this.btn_exit.BackgroundImage = global::ProgramUI.Properties.Resources.退出;
            this.btn_exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_exit.FillColor = System.Drawing.Color.Transparent;
            this.btn_exit.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_exit.Location = new System.Drawing.Point(803, 4);
            this.btn_exit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_exit.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.RectColor = System.Drawing.Color.Transparent;
            this.btn_exit.RectDisableColor = System.Drawing.Color.Transparent;
            this.btn_exit.RectHoverColor = System.Drawing.Color.Transparent;
            this.btn_exit.RectPressColor = System.Drawing.Color.Transparent;
            this.btn_exit.RectSelectedColor = System.Drawing.Color.Transparent;
            this.btn_exit.Size = new System.Drawing.Size(38, 43);
            this.btn_exit.TabIndex = 6;
            this.btn_exit.TipsColor = System.Drawing.Color.Transparent;
            this.btn_exit.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_exit.Click += new System.EventHandler(this.uiButton3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::ProgramUI.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(2, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(46, 47);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // uiLabel1
            // 
            this.uiLabel1.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel1.Font = new System.Drawing.Font("华文行楷", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel1.ForeColor = System.Drawing.Color.Lime;
            this.uiLabel1.Location = new System.Drawing.Point(42, 1);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(169, 47);
            this.uiLabel1.TabIndex = 8;
            this.uiLabel1.Text = "振博爱智农";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // titleBar
            // 
            this.titleBar.BackColor = System.Drawing.Color.Transparent;
            this.titleBar.FillColor = System.Drawing.Color.Transparent;
            this.titleBar.FillColor2 = System.Drawing.Color.Transparent;
            this.titleBar.FillDisableColor = System.Drawing.Color.Transparent;
            this.titleBar.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.titleBar.ForeColor = System.Drawing.Color.Transparent;
            this.titleBar.ForeDisableColor = System.Drawing.Color.Transparent;
            this.titleBar.Location = new System.Drawing.Point(2, 0);
            this.titleBar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.titleBar.MinimumSize = new System.Drawing.Size(1, 1);
            this.titleBar.Name = "titleBar";
            this.titleBar.RectColor = System.Drawing.Color.Transparent;
            this.titleBar.RectDisableColor = System.Drawing.Color.Transparent;
            this.titleBar.Size = new System.Drawing.Size(839, 48);
            this.titleBar.TabIndex = 9;
            this.titleBar.Text = "uiPanel1";
            this.titleBar.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiLabel2
            // 
            this.uiLabel2.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiLabel2.Font = new System.Drawing.Font("楷体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel2.ForeColor = System.Drawing.Color.LightGreen;
            this.uiLabel2.Location = new System.Drawing.Point(312, 423);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(100, 47);
            this.uiLabel2.TabIndex = 8;
            this.uiLabel2.Text = "注册账号";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LoadForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(842, 540);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.uiLabel2);
            this.Controls.Add(this.uiLabel1);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.uiButton1);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.titleBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "LoadForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "智能农业监控软件";
            this.Load += new System.EventHandler(this.LoadForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Sunny.UI.UITextBox txt_username;
        private Sunny.UI.UITextBox txt_password;
        private Sunny.UI.UIButton uiButton1;
        private Sunny.UI.UIButton btn_exit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UIPanel titleBar;
        private Sunny.UI.UILabel uiLabel2;
    }
}
using Entity;
using ProgramBLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramUI
{
    public partial class LoadForm : Form
    {
        LoadBLL loadbll = new LoadBLL();

        private Point mouseDownPoint = Point.Empty;

        public LoadForm()
        {
            InitializeComponent();
            // 添加拖动事件
            titleBar.MouseDown += (s, e) =>
            {
                if (e.Button == MouseButtons.Left)
                    mouseDownPoint = new Point(e.X, e.Y);
            };

            titleBar.MouseMove += (s, e) =>
            {
                if (mouseDownPoint != Point.Empty)
                {
                    Point newLocation = this.Location;
                    newLocation.X += e.X - mouseDownPoint.X;
                    newLocation.Y += e.Y - mouseDownPoint.Y;
                    this.Location = newLocation;
                }
            };

            titleBar.MouseUp += (s, e) => mouseDownPoint = Point.Empty;
        }

        private void LoadForm_Load(object sender, EventArgs e)
        {
            this.txt_username.SendToBack();
            this.txt_password.SendToBack();
        }

        private void uiButton3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void uiButton1_Click(object sender, EventArgs e)
        {
            try
            {
                string userName = this.txt_username.Text;
                int passWord = Convert.ToInt32(this.txt_password.Text);
                UsersEntity userentity = loadbll.UserLoad(userName, passWord);
                if (userName.ToUpper() == userentity.Username.ToUpper() && passWord == userentity.Password)
                {
                    MainForm main = new MainForm();
                    main.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("用户名或密码错误","提示",MessageBoxButtons.OKCancel);
            }

        }
    }
}

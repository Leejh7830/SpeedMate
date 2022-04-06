using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp9.Common;
using WindowsFormsApp9.Handler;
using WindowsFormsApp9.UI;

namespace WindowsFormsApp9
{
    public partial class MainForm : MaterialForm
    {
        BaseAdapter baseAd = new BaseAdapter();
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Theme.initTheme(this);
        }

        private void mainMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void mainExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void custFixAdd_Click(object sender, EventArgs e)
        {
            custFixAddUI Add = new custFixAddUI(baseAd);
            Add.Show();
        }

        private void custFixView_Click(object sender, EventArgs e)
        {
            //baseAd.viewReceipt(); // 콘솔확인용
            //baseAd.viewReceiptDB(); // 확인용
            ReceiptView View = new ReceiptView(baseAd);
            View.ShowDialog();
        }

        private void custFixAdmin_Click(object sender, EventArgs e)
        {

        }

        private void setting_Click(object sender, EventArgs e)
        {

        }

        private void about_Click(object sender, EventArgs e)
        {

        }
    }
}

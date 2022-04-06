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
using WindowsFormsApp9.DTO;
using WindowsFormsApp9.Handler;

namespace WindowsFormsApp9.UI
{
    partial class ReceiptView : MaterialForm
    {
        BaseAdapter baseAd;
        public ReceiptView()
        {
            InitializeComponent();
        }
        public ReceiptView(BaseAdapter baseAd)
        {
            InitializeComponent();
            this.baseAd = baseAd;
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ReceiptView_Load(object sender, EventArgs e)
        {
            initListView();
            //initGridView2();
        }

        private void initListView() // ListView에 DB 가져오기
        {
            List<ReceiptItem> list = baseAd.getReceiptDb();
            for (int i = 0; i < list.Count; i++)
            {
                rclistView.Items.Add(new ListViewItem(
                    new String[]
                    {
                        (i+1).ToString(), list[i].Indate, list[i].Total_price,
                        list[i].StaffName, list[i].CustName, list[i].CustTel,
                        list[i].CarNum, list[i].RepairChk
                    }));
            }
        }
        private void initGridView2() // ★GridView에 DB 가져오기
        {
            List<RepairItem> list = baseAd.getRepairDb();
            for (int i = 0; i < 100; i++)
            {
                rcGridView.Rows.Add(new string[]
                {
                    (i+1).ToString(), list[i].Repair,
                    string.Format("￦{0:#,0}원", list[i].Price)
                });
            }
        }
        private void initGridView2(List<RepairItem> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                rcGridView.Rows.Add(new string[]
                {
                    (i+1).ToString(), list[i].Repair,
                    string.Format("￦{0:#,0}원", list[i].Price)
                });
            }
        }

        private void rclistView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rclistView.SelectedItems.Count != 0)
            {
                int n = rclistView.SelectedItems[0].Index;
                string name = rclistView.Items[n].SubItems[4].Text;
                string tel = rclistView.Items[n].SubItems[5].Text;
                Console.WriteLine("고객명: " + name);
                Console.WriteLine("전화: " + tel);
                rcGridView.Rows.Clear();
                List<RepairItem> list = baseAd.getRepairDb(name, tel);
                initGridView2(list);
            }
        }
    }
}


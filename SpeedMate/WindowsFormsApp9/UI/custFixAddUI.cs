using MaterialSkin.Controls;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp9.DTO;
using WindowsFormsApp9.Handler;
using WindowsFormsApp9.Util;

namespace WindowsFormsApp9.UI
{
    partial class custFixAddUI : MaterialForm
    {
        BaseAdapter baseAd;
        public custFixAddUI()
        {
            InitializeComponent();
        }
        public custFixAddUI(BaseAdapter baseAd)
        {
            InitializeComponent();
            this.baseAd = baseAd;
        }


        private void addExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void custFixAddUI_Load(object sender, EventArgs e)
        {
            setYear();
            setMonth();
            setDay();
        }

        private void setYear()
        {
            //custY.Items.Add("2002");
            for (int i=2002; i>=1950; i--)
            {
                custY.Items.Add(i.ToString());
            }
        }

        private void setMonth()
        {
            for (int i = 1; i <= 12; i++)
            {
                custM.Items.Add(i.ToString());
            }
        }

        private void setDay()
        {
            for (int i = 1; i <= 31; i++)
            {
                custD.Items.Add(i.ToString());
            }
        }

        private void carModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            String model = carModel.SelectedItem.ToString();
            switch (model)
            {
                case "K3":
                    carPic.Image = Properties.Resources.K3;
                    break;
                case "그랜저":
                    carPic.Image = Properties.Resources.그랜저;
                    break;
                case "소나타":
                    carPic.Image = Properties.Resources.소나타;
                    break;
                case "아반떼":
                    carPic.Image = Properties.Resources.아반떼;
                    break;
                case "아이오닉":
                    carPic.Image = Properties.Resources.아이오닉;
                    break;
                case "제네시스":
                    carPic.Image = Properties.Resources.제네시스;
                    break;
                default:
                    carPic.Image = Properties.Resources.default_car;
                    break;
            }
        }

        private void addSave_Click(object sender, EventArgs e)
        {
            string name = custName.Text;
            string telH = custTelH.Text;
            string telB = custTelB.Text;
            string year = custY.Text;
            string month = custM.Text;
            string day = custD.Text;
            string model = carModel.Text;
            string num = carNum.Text;
            string cc = carCC.Text;
            string caryear = carMade.Text;
            string staffName = custStaff.Text;

            Control[] arrObj = new Control[]
            {
                custName, custTelH, custTelB, custY, custM, custD,
                carModel, carNum, carCC, carMade, custStaff
            };

            string[] arrData = new string[]
            {
                name, telH, telB, year, month, day, 
                model, num, cc, caryear, staffName
            };

            string[] arrMsg = new string[]
            {
                Properties.Resources.ERR_NAME, Properties.Resources.ERR_TEL_H,Properties.Resources.ERR_TEL_B,
                Properties.Resources.ERR_BIRTH_YEAR,Properties.Resources.ERR_BIRTH_MONTH,Properties.Resources.ERR_BIRTH_DAY,
                Properties.Resources.ERR_CAR_MODEL,Properties.Resources.ERR_CAR_NUMBER, Properties.Resources.ERR_CAR_CC,
                Properties.Resources.ERR_CAR_YEAR,Properties.Resources.ERR_STAFF_NAME
            };

            Dictionary<Control, string> dic = new Dictionary<Control, string>();
            for (int i=0; i<arrData.Length; i++)
            {
                dic.Add(arrObj[i], arrData[i]);
            }
            int cnt = 0;
            string telAll = telH + telB;
            foreach (KeyValuePair<Control, string> kvp in dic)
            {
                if (kvp.Value.Equals("") || kvp.Value.Equals("선택"))
                {
                    setFocus(kvp.Key, arrMsg[cnt]);
                    return;
                }
                if (!checkName(name) || !checkTel(telB))
                {
                    return;
                }
                cnt++;
            }

            UICheckBox[] checkBox =
            {
                chk1, chk2, chk3, chk4, chk5, chk6, chk7, chk8, chk9, chk10
            };

            List<RepairItem> itemList = new List<RepairItem>();
            int total = 0;
            for (int i=RepairTable.ENGINE_OIL;
                i<=RepairTable.ETC_COST; i++)
            {
                if (checkBox[i].Checked)
                {
                    //Console.WriteLine(checkBox[i].Text);
                    itemList.Add(new RepairItem(checkBox[i].Text,
                        RepairTable.fixMoney[i]));
                    total += RepairTable.fixMoney[i];
                }
            }

            if (itemList.Count == 0)
            {
                MessageBox.Show("수리항목을 선택하세요.");
                return;
            }

            Customer cust = new Customer(name, telAll, year + month + day);
            Car car = new Car(model, num, cc, caryear);
            Receipt receipt = new Receipt(cust, car, 
                DateTime.Now.ToString("yyyy년mm월dd일"),
                staffName, itemList, total, "NO");
            baseAd.addReceiptList(receipt);
            MessageBox.Show("데이터가 정상적으로 저장되었습니다.");
            Close();
        }

        private void setFocus(Control obj, string msg)
        {
            MessageBox.Show(msg);
            ActiveControl = obj;
            obj.Focus();
        }

        private bool checkName(string name)
        {
            Regex regex = new Regex(@"^[가-힣]{2,4}$");
            Match m = regex.Match(name);
            if (m.Success == false)
            {
                setFocus(custName, "잘못된 이름 정보입니다.");
                return false;
            }
            return true;
        }
        private bool checkTel(String telB)
        {
            Regex regex = new Regex(@"[0-9]{8}");
            Match m = regex.Match(telB);
            if (m.Success == false)
            {
                setFocus(custName, "잘못된 전화번호 정보입니다.");
                return false;
            }
            return true;
        }
    }
}

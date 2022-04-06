using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp9.DTO;

namespace WindowsFormsApp9.Handler
{
    class BaseAdapter
    {
        private DaoOracle ora = new DaoOracle();
        private List<Receipt> receiptList = new List<Receipt>();

        public void addReceiptList(Receipt receipt)
        {
            receiptList.Add(receipt);
            addReceiptDB();
        }

        public void addReceiptDB()
        {
            for (int i=0; i<receiptList.Count; i++)
            {
                ora.insertDB(receiptList[i]);
            }
            receiptList.Clear();
        }

        public void addReceiptDB(Receipt receipt)
        {
            ora.insertDB(receipt);
        }


        public void viewReceipt()  // 콘솔 검사용
        {
            for (int i=0; i<receiptList.Count; i++)
            {
                Customer customer = receiptList[i].Customer; // get
                Console.WriteLine("고객명 : " + customer.Name);
                Console.WriteLine("전화 : " + customer.Tel);
                Console.WriteLine("생년월일 : " + customer.Birth);

                Car car = receiptList[i].Car;
                Console.WriteLine("모델명 : " + car.Model);
                Console.WriteLine("차량번호 : " + car.Number);
                Console.WriteLine("배기량 : " + car.Cc);
                Console.WriteLine("연식 : " + car.Year);

                Console.WriteLine("접수날짜 : " + receiptList[i].InDate);
                Console.WriteLine("담당자 : " + receiptList[i].StaffName);

                List<RepairItem> itemList = receiptList[i].ItemList;
                for (int j=0; j<itemList.Count; j++)
                {
                    Console.WriteLine("수리항목 : " + itemList[j].Repair);
                    Console.WriteLine("수리비용 : " + itemList[j].Price);
                }

                Console.WriteLine("총 결제금액 : " + receiptList[i].TotalPrice);
                Console.WriteLine("수리 상태 : " + receiptList[i].RepairChk);
            }
        }

        public void viewReceiptDB()
        {
            ora.showDB2();
        }

        public List<ReceiptItem> getReceiptDb()
        {
            List<ReceiptItem> list = ora.getReceiptVO();
            return list;
        }
        public List<RepairItem> getRepairDb() //★샘플
        {
            List<RepairItem> list = ora.getRepairVO();
            return list;
        }
        public List<RepairItem> getRepairDb(string name, string tel)
        {
            List<RepairItem> list = ora.getRepairVO(name, tel);
            return list;
        }
    }
}

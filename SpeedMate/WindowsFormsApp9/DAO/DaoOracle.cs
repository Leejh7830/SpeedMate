using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp9.DTO;

namespace WindowsFormsApp9
{
    class DaoOracle
    {
        string ORADB = "Data Source=(DESCRIPTION=(ADDRESS_LIST=" +
            "(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521)))" +
            "(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=XE)));" +
            "User Id=test;Password=1234";
        OracleConnection conn;
        OracleCommand cmd;

        public DaoOracle() // 생성자
        {
            conn = new OracleConnection(ORADB);
            cmd = new OracleCommand();
            dbConn();
        }

        ~DaoOracle() // 소멸자
        {
            dbClose();
        }

        public void dbConn() // 오라클 접속
        {
            try
            {
                conn.Open();
                Console.WriteLine("오라클 DB 접속 성공");
            }
            catch (OracleException ex)
            {
                Console.WriteLine("접속 에러 :" + ex.Message);
                return;
            }
        }
        public void dbClose() // 오라클 접속해제
        {
            try
            {
                if (conn != null)
                {
                    conn.Close();
                    Console.WriteLine("오라클 DB 접속 해제");
                }
            }
            catch (OracleException ex)
            {
                Console.WriteLine("접속 해제 에러 :" + ex.Message);
            }
        }

        public void insertDB() // ★데이터 추가
        {
            try
            {
                string name = "홍길동";
                int age = 300;
                string addr = "조선 한양 11번지";
                string sql = string.Format($"insert into testTB1 values (seq_id.nextval,'{name}', {age}, '{addr}')");
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                Console.WriteLine(name + " 데이터 추가 성공!");
            }
            catch (OracleException ex)
            {
                Console.WriteLine("데이터 추가 에러: " + ex.Message);
            }
        }

        public void insertDB(Receipt receipt) // 데이터 추가
        {
            try
            {
                string sql = string.Format(
                    "insert all " +
                    "into car_t values (car_t_seq.nextval, '{0}','{1}','{2}','{3}')",
                    receipt.Car.Model, receipt.Car.Number, receipt.Car.Cc, receipt.Car.Year);
                sql += string.Format(
                    "into customer_t values (customer_t_seq.nextval, '{0}','{1}'," +
                    "'{2}', car_t_seq.currval)",
                    receipt.Customer.Name, receipt.Customer.Birth,
                    receipt.Customer.Tel);
                sql += "select * from dual";
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();

                List<RepairItem> itemList = receipt.ItemList;
                for (int j=0; j<itemList.Count; j++)
                {
                    string sqlItem = string.Format(
                        "insert into repair_item_t values (repair_item_t_seq.nextval, " +
                        "'{0}','{1}', car_t_seq.currval)",
                        itemList[j].Repair, itemList[j].Price);
                    cmd.CommandText = sqlItem;
                    cmd.ExecuteNonQuery();
                }

                string sqlRec = string.Format(
                    "insert into receipt_t values (receipt_t_seq.nextval, '{0}','{1}'," +
                    "'{2}', customer_t_seq.currval, " +
                    "(select staff_id from staff_t where staff_t.name='{3}'))",
                    receipt.InDate, receipt.TotalPrice, receipt.RepairChk, receipt.StaffName);
                cmd.CommandText = sqlRec;
                cmd.ExecuteNonQuery();
            }
            catch (OracleException ex)
            {
                Console.WriteLine("데이터 추가 에러: " + ex.Message);
            }
        }

        public void showDB() // ★데이터 보기
        {
            try
            {
                string sql = "select * from testTB1 order by id asc";
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                OracleDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read()) // 행 1개 읽기
                    {
                        Console.WriteLine("ID: " + reader["id"]);
                        Console.WriteLine("이름: " + reader["name"]);
                        Console.WriteLine("나이: " + reader["age"]);
                        Console.WriteLine("주소: " + reader["addr"]);
                        Console.WriteLine("-----------------------------");
                    }
                }
                else
                {
                    Console.WriteLine("데이터가 존재하지 않습니다.");
                }
                reader.Close();
            }
            catch (OracleException ex)
            {
                Console.WriteLine("데이터 추가 에러: " + ex.Message);
            }
        }

        public void showDB2() // 데이터 보기
        {
            try
            {
                string sql = "select indate as 접수날짜, total_price as 총결제금액," +
                    "(select staff_t.name from staff_t " +
                    "where staff_t.staff_id = receipt_t.staff_id) as 담당자, " +
                    "(select customer_t.name from customer_t " +
                    "where customer_t.cust_id = receipt_t.cust_id) as 고객명, " +
                    "(select customer_t.tel from customer_t " +
                    "where customer_t.cust_id = receipt_t.cust_id) as 고객전화, " +
                    "(select car_t.car_num from car_t " +
                    "where car_t.car_id = receipt_t.cust_id) as 차량번호, " +
                    "repair_chk as 수리상태 from receipt_t";
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.CommandType = System.Data.CommandType.Text;
                OracleDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read()) // 행 1개 읽기
                    {
                        Console.WriteLine("접수날짜: " + reader["접수날짜"]);
                        Console.WriteLine("총결제금액: " + reader["총결제금액"]);
                        Console.WriteLine("담당자: " + reader["담당자"]);
                        Console.WriteLine("고객명: " + reader["고객명"]);
                        Console.WriteLine("고객전화: " + reader["고객전화"]);
                        Console.WriteLine("차량번호: " + reader["차량번호"]);
                        Console.WriteLine("수리상태: " + reader["수리상태"]);
                        Console.WriteLine("-----------------------------");
                    }
                }
                else
                {
                    Console.WriteLine("데이터가 존재하지 않습니다.");
                }
                reader.Close();
            }
            catch (OracleException ex)
            {
                Console.WriteLine("데이터 보기 에러: " + ex.Message);
            }

            try
            {
                string queryItem = "select repair as 수리항목, price as 수리단가 " +
                    "from repair_item_t where repair_item_t.car_id = " +
                    "(select customer_t.cust_id from customer_t " +
                    "where customer_t.name = '유관순')";
                cmd.CommandText = queryItem;
                cmd.CommandType = System.Data.CommandType.Text;
                OracleDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read()) // 행 1개 읽기
                    {
                        Console.WriteLine("수리항목: " + reader["수리항목"]);
                        Console.WriteLine("수리금액: " + reader["수리단가"]);
                        Console.WriteLine("-------------------------");
                    }
                }
                else
                {
                    Console.WriteLine("데이터가 존재하지 않습니다.");
                }
                reader.Close();
            }
            catch (OracleException ex)
            {
                Console.WriteLine("수리항목보기 에러: " + ex.Message);
            }

        }

        public List<ReceiptItem> getReceiptVO()
        {
            List<ReceiptItem> listRec = null;
            try
            {
                string sql = "create or REPLACE view receipt_view " +
                   "as select indate as 접수날짜, total_price as 총결제금액, " +
                   "(select staff_t.name from staff_t " +
                   "where staff_t.staff_id = receipt_t.staff_id) as 담당자, " +
                   "(select customer_t.name from customer_t " +
                   "where customer_t.cust_id = receipt_t.cust_id) as 고객명, " +
                   "(select customer_t.tel from customer_t " +
                   "where customer_t.cust_id = receipt_t.cust_id) as 고객전화, " +
                   "(select car_t.car_num from car_t " +
                   "where car_t.car_id = receipt_t.cust_id) as 차량번호, " +
                   "repair_chk as 수리상태 from receipt_t order by receipt_id desc";
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteReader();

                string sql2 = "select * from receipt_view";
                cmd.CommandText = sql2;
                cmd.ExecuteReader();
                cmd.CommandType = System.Data.CommandType.Text;
                OracleDataReader reader = cmd.ExecuteReader();
                listRec = new List<ReceiptItem>();

                if (reader.HasRows)
                {
                    while (reader.Read()) // 데이터읽으면서 리스트에 저장
                    { 
                        listRec.Add(new ReceiptItem(
                            reader["접수날짜"].ToString(), reader["총결제금액"].ToString(),
                            reader["담당자"].ToString(), reader["고객명"].ToString(),
                            reader["고객전화"].ToString(), reader["차량번호"].ToString(),
                            reader["수리상태"].ToString()));
                    }
                }
                else
                {
                    Console.WriteLine("데이터가 존재하지 않습니다.");
                }
                reader.Close();
            }
            catch (OracleException ex)
            {
                Console.WriteLine("데이터 보기 에러: " + ex.Message);
            }
            return listRec;
        }

        public List<RepairItem> getRepairVO() // ★
        {
            List<RepairItem> list = new List<RepairItem>();
            try
            {
                string queryItem = "select repair_history as 수리항목, repair_price as 수리금액 " +
                "from repair_item_t where repair_item_t.car_id = " +
                "(select customer_t.cust_id from customer_t" +
                "where customer_t.cust_name = '유관순')";
                cmd.CommandText = queryItem;
                cmd.CommandType = System.Data.CommandType.Text;
                OracleDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read()) // 행 1개 읽기
                    {
                        list.Add(new RepairItem(reader["수리항목"].ToString(),
                        int.Parse(reader["수리금액"].ToString())));
                    }
                }
                else
                {
                    Console.WriteLine("데이터가 존재하지 않습니다.");
                }
                reader.Close();
            }
            catch (OracleException ex)
            {
                Console.WriteLine("수리항목보기 에러: " + ex.Message);
            }
            return list;
        }

        public List<RepairItem> getRepairVO(string name, string tel)
        {
            List<RepairItem> list = new List<RepairItem>();
            try
            {
                string queryItem =
                    string.Format("select repair as 수리항목, price as 수리단가 " +
                    "from repair_item_t where repair_item_t.car_id = " +
                    "(select customer_t.cust_id from customer_t " +
                    "where customer_t.name='{0}' and customer_t.tel='{1}')",
                    name, tel);

                cmd.CommandText = queryItem;
                cmd.CommandType = System.Data.CommandType.Text;
                OracleDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read()) // 행 1개 읽기
                    {
                        list.Add(new RepairItem(
                            reader["수리항목"].ToString(),
                            int.Parse(reader["수리단가"].ToString())));
                    }
                }
                else
                {
                    Console.WriteLine("데이터가 존재하지 않습니다.");
                }
                reader.Close();
            }
            catch (OracleException ex)
            {
                Console.WriteLine("수리항목보기 에러: " + ex.Message);
            }
            return list;
        }

        public void updateDB(int id, string name, int age, string addr) // ★데이터 수정
        {
            try
            {
                string sql = string.Format($"update testTB1 set name='{name}', age={age}, addr='{addr}' where id={id}");
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                Console.WriteLine("데이터 수정 성공!");
            }
            catch (OracleException ex)
            {
                Console.WriteLine("데이터 수정 에러: " + ex.Message);
            }
        }

        public void deleteDB(int id) // ★데이터 삭제
        {
            try
            {
                string sql = string.Format($"delete from testTB1 where id={id}");
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                Console.WriteLine("데이터 삭제 성공!");
            }
            catch (OracleException ex)
            {
                Console.WriteLine("데이터 삭제 에러: " + ex.Message);
            }
        }

        

    }//클래스
}//메인

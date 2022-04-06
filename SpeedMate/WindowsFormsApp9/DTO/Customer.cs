using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp9.DTO
{
    class Customer
    {
        private string name;
        private string tel;
        private string birth;

        public Customer(string name, string tel, string birth)
        {
            this.name = name;
            this.tel = tel;
            this.birth = birth;
        }

        public string Name { get => name; set => name = value; }
        public string Tel { get => tel; set => tel = value; }
        public string Birth { get => birth; set => birth = value; }
    }
}

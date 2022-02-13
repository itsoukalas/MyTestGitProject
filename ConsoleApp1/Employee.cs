using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Employee:Person
    {
        public string Department{ get; set; }
        public Employee()
        {
            Person person = new Person();
            person.Name = "hlias tsoukalas";
            person.age = 36;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheFirm2.Model;

namespace TheFirm2
{
    internal class Company
    {
        public Employee ceo = null;
        public Employee coo = null;
        public Employee cfo = null;

        public Employee dir1 = null;  // it
        public Employee dir2 = null;  // sales

        public Employee dir1man1 = null;  // it
        public Employee dir1man2 = null;
        public Employee dir2man1 = null;  // floor
        public Employee dir2man2 = null;

        public Employee sup1 = null;
        public Employee sup2 = null;
        public Employee sup3 = null;
        public Employee sup4 = null;
        public Employee sup5 = null;
        public Employee sup6 = null;

        public Employee sal1 = null;
        public Employee sal2 = null;
        public Employee sal3 = null;
        public Employee sal4 = null;
        public Employee sal5 = null;
        public Employee sal6 = null;

        public Employee hr = null;
        public Employee admin = null;

        Random r = new Random();
        public void InitializeEmployees()
        {
            ceo = new CEO("Jean-Luc Picard", 100000, new Car("Toyota", "Aygo"));
            coo = new COO("Beverly Crusher", 80000, new Car("Porsche", "911"));
            cfo = new CFO("William T. Riker", 80000, new Car("Morris", "1000"));

            dir1 = new ITDirector("Geordi LaForge", 60000, "glaf@company.com");

            dir2 = new SalesDirector("Kathryn Janeway", 60000, "kjan@company.com");

            dir1man1 = new ITManager("Data", 50000, r.Next(11111111, 99999999).ToString());
            dir1man2 = new ITManager("Tasha Yar", 50000, r.Next(11111111, 99999999).ToString());

            dir2man1 = new FloorManager("Worf", 50000, r.Next(11111111, 99999999).ToString());
            dir2man2 = new FloorManager("Miles O'Brien", 50000, r.Next(11111111, 99999999).ToString());

            sup1 = new Supporter("Alyssa Ogawa", 25000, r.Next(11111111, 99999999).ToString());
            sup2 = new Supporter("Reginald Barclay", 25000, r.Next(11111111, 99999999).ToString());
            sup3 = new Supporter("Sonya Gomez", 25000, r.Next(11111111, 99999999).ToString());

            sup4 = new Supporter("Lwaxana Troi", 25000, r.Next(11111111, 99999999).ToString());
            sup5 = new Supporter("Wesley Crusher", 25000, r.Next(11111111, 99999999).ToString());
            sup6 = new Supporter("Katherine Pulaski", 25000, r.Next(11111111, 99999999).ToString());

            sal1 = new Salesperson("Deanna Troi", 20000, 16243);
            sal2 = new Salesperson("Hugh of Borg", 20000, 34905);
            sal3 = new Salesperson("Alexander Rozhenko", 20000, 17359);

            sal4 = new Salesperson("Ro Laren", 20000, 44538);
            sal5 = new Salesperson("Robin Lefler", 20000, 90725);
            sal6 = new Salesperson("Alynna Nechayev", 20000, 43811);

            hr = new HR("Benjamin Sisko", 70000);
            admin = new Admin("7 of 9", 70000);

            AssignEmployees();
        }

        public void AssignEmployees()
        {
            COO Coo = (COO)coo;
            Coo.AddDirector((ITDirector)dir1);

            CFO Cfo = (CFO)cfo;
            Cfo.AddDirector((SalesDirector)dir2);

            Director Dir1 = (Director)dir1;
            Dir1.AddManager((ITManager)dir1man1);
            Dir1.AddManager((ITManager)dir1man2);

            Director Dir2 = (Director)dir2;
            Dir2.AddManager((FloorManager)dir2man1);
            Dir2.AddManager((FloorManager)dir2man2);

            Manager Dir1man1 = (Manager)dir1man1;
            Dir1man1.AddEmployee(sup1);
            Dir1man1.AddEmployee(sup2);
            Dir1man1.AddEmployee(sup3);

            Manager Dir1man2 = (Manager)dir1man2;
            Dir1man2.AddEmployee(sup4);
            Dir1man2.AddEmployee(sup5);
            Dir1man2.AddEmployee(sup6);

            Manager Dir2man1 = (Manager)dir2man1;
            Dir2man1.AddEmployee(sal1);
            Dir2man1.AddEmployee(sal2);
            Dir2man1.AddEmployee(sal3);

            Manager Dir2man2 = (Manager)dir2man2;
            Dir2man2.AddEmployee(sal4);
            Dir2man2.AddEmployee(sal5);
            Dir2man2.AddEmployee(sal6);

            CEO Ceo = (CEO)ceo;
            Ceo.AddStaff((Staff)hr);
            Ceo.AddStaff((Staff)admin);

            AssignEmployeesToHRList();
        }

        public void AssignEmployeesToHRList()
        {
            HR Hr = (HR)hr;
            Hr.AddEmployee(ceo);
            Hr.AddEmployee(coo);
            Hr.AddEmployee(cfo);
            Hr.AddEmployee(dir1);
            Hr.AddEmployee(dir2);
            Hr.AddEmployee(dir1man1);
            Hr.AddEmployee(dir1man2);
            Hr.AddEmployee(dir2man1);
            Hr.AddEmployee(dir2man2);
            Hr.AddEmployee(sup1);
            Hr.AddEmployee(sup2);
            Hr.AddEmployee(sup3);
            Hr.AddEmployee(sup4);
            Hr.AddEmployee(sup5);
            Hr.AddEmployee(sup6);
            Hr.AddEmployee(sal1);
            Hr.AddEmployee(sal2);
            Hr.AddEmployee(sal3);
            Hr.AddEmployee(sal4);
            Hr.AddEmployee(sal5);
            Hr.AddEmployee(sal6);
            Hr.AddEmployee(hr);
            Hr.AddEmployee(admin);
        }
    }
}

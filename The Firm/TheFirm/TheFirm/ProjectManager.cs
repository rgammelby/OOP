using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TheFirm
{
    internal class ProjectManager : Manager
    {
        protected string email;

        public ProjectManager()
        {
            email = "address@company.com";
        }

        public ProjectManager(string cprNo, string fName, string lName, string phone, string mail) : base(cprNo, fName, lName, phone)
        {
            cpr = cprNo;
            firstName = fName;
            lastName = lName;
            telephone = phone;
            email = mail;
        }

        public override string ToString()
        {
            return $"{base.ToString()}E-mail address: {email} \n";
        }
    }
}

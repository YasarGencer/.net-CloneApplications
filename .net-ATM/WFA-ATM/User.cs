using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_ATM
{
    class User
    {
        public String user, pass;
        public String name, surname;
        public String mail, contact, location;
        public String gender, cash;



        public User(string user, string pass)
        {
            this.user = user;
            this.pass = pass;
        }

        public User(string user, string pass, string name, string surname, string cash) : this(user, pass)
        {
            this.name = name;
            this.surname = surname;
            this.cash = cash;
        }

        public User(string user, string pass, string name, string surname, string mail, string location, string contact, string gender) : this(user, pass)
        {
            this.name = name;
            this.surname = surname;
            this.mail = mail;
            this.location = location;
            this.contact = contact;
            this.gender = gender;

            
        }

        public User(string user, string pass, string name, string surname, string mail, string contact, string location, string gender, string cash) : this(user, pass, name, surname, mail, contact, location, gender)
        {
            this.cash = cash;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class Profile
    {
        public string profileName;
        private string username;
        private string password;
        public int phoneNumber;
        public  List<string> pairedUnits;
        public List<string> schedule;


        public Profile(string name, string username, string password)
        {
            profileName = name;
            Username = username;
            Password = password;
        }

        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        public string Password
        {
            get { return password; } 
            set { password = value; } 
        }
    }


}

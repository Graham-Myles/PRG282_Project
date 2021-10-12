using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG282_Project.PresentationLayer
{
    class Employee
    {
        string username, password;

        public Employee() { }
        public Employee(string L_username, string L_password)
        {
            this.Username = L_username;
            this.Password = L_password;


        }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
    }
}

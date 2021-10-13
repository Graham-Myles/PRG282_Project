using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data;
using System.Data.SqlClient;
using PRG282_Project.DataAccesLayer;
using PRG282_Project.PresentationLayer;
using PRG282_Project.BusinessLogicLayer;

namespace PRG282_Project
{
    public partial class Login_Form : Form
    {

        public Login_Form()
        {
            InitializeComponent();
        }
        DataHandler DHandler = new DataHandler();
        FileHandler Fhandler = new FileHandler();
        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string pasword = txtPassword.Text;
            Employee temp = new Employee(username, pasword);

          DHandler.LoginVerification(temp);

        }

        private void button1_Click(object sender, EventArgs e)
        { 
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            Fhandler.Registration(username, password);

        }

        private void Login_Form_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
        }
    }
}

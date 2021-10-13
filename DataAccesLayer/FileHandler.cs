using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace PRG282_Project.DataAccesLayer
{
    class FileHandler
    {
        public void Registration(string username, string password)
        {
            string fileName = @"C:\Users\micha\source\repos\PRG282_Projectv4\DATA\TextFile1.txt";
           
            StreamWriter writer = new StreamWriter(File.Open(fileName,System.IO.FileMode.Append));
            writer.WriteLine("");
            writer.Write(username + "," + password);
            
          //  using (writer) { writer.Write(username + "," + password); }
            
            MessageBox.Show("Data was added");
            writer.Dispose();
            
        }
    }
}

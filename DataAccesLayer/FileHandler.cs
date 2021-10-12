using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PRG282_Project.DataAccesLayer
{
    class FileHandler
    {
        public void Registration(string username, string password)
        {
            string fileName = @"C:\Users\lstas\Source\Repos\PRG282_ProjectV2\DATA\TextFile1.txt";
            StreamWriter writer = new StreamWriter(fileName);
            using (writer) { writer.WriteLine(username + "," + password); }
        }
    }
}

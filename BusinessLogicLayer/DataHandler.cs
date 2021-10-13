using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using PRG282_Project.DataAccesLayer;
using PRG282_Project.PresentationLayer;
using System.Drawing;


namespace PRG282_Project.BusinessLogicLayer
{
    class DataHandler
    {
        public DataHandler() { }
        public void LoginVerification(Employee person)
        {
            Boolean acces = false;

            using (StreamReader sr = File.OpenText(@"C:\Users\micha\source\repos\PRG282_Projectv4\DATA\TextFile1.txt"))
                {
                    string input;
                    while ((input = sr.ReadLine()) != null)
                    {
                    
                        string[] line = input.Split(',');
                        string username = line[0];
                        string password = line[1];
                        string US = person.Username;
                        string PS = person.Password;
                        if (US == username)
                        {
                            if (PS == password)
                            {
                                acces = true;
                                
                            }
                            
                        }
                        
                    }
                }
            if (acces==true)
            {
                
                Student_Form st = new Student_Form();
                st.Show();
                Login_Form lg = new Login_Form();
                lg.Hide();
                lg.Enabled = false;
                MessageBox.Show("Welcome ");
            }
            else
            {
                MessageBox.Show("Incorrect Details or Try Resgistering");
            }

            

        }

        public byte[] ImageToByteArray(System.Drawing.Image imageIn)
        {
            using (var ms = new MemoryStream())
            {
                imageIn.Save(ms, imageIn.RawFormat);
                return ms.ToArray();
            }
        }
        public Image byteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using PRG282_Project.Properties;


namespace PRG282_Project.DataAccesLayer
{
    class DatabaseHandler
        
    {
         SqlConnection con = new SqlConnection("Server=.; Initial Catalog =PRG282Project; Integrated Security=SSPI");
        public  SqlConnection sqlcon()
        {
            try
            {
                con.Open();
                con.Close();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection Failed");
                MessageBox.Show(ex.ToString());
            }
            
            return con;

        }
        public void displaystudent()
        {
            try
            {                
                string query = @"Select * from StudentInfo";

                SqlDataAdapter adapter = new SqlDataAdapter(query,sqlcon());
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                Form1 f1 = new Form1();
              
                f1.dataGridView1.DataSource = dt; 
            }
            catch (Exception me)
            {
                MessageBox.Show("Data failed to be added");
                MessageBox.Show(me.ToString());
            }
        }


        public void displayModule()
        {
            try
            {
                string query = @"Select * from StudentInfo";

                SqlDataAdapter adapter = new SqlDataAdapter(query, sqlcon());
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                Form1 f1 = new Form1();

                //f1.dataGridView2.DataSource = dt;
            }
            catch (Exception me)
            {
                MessageBox.Show("Data failed to be added");
                MessageBox.Show(me.ToString());
            }

        } 

        public void UpdateStudent(int id,string name,string surname,string Phonenumber,int ModuleCode )
        {
            try
            {
                
                string line = "Update StudentInfo set  values  StudentName='" + name + "',StudentSurname= '" + surname + "', PhoneNumber='" + Phonenumber + "',ModuleCode='" + ModuleCode.ToString() + "' where StudentID= '" + id.ToString() + "'";
                SqlCommand command = new SqlCommand(line, sqlcon());
                command.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Data Failed to be Updated");
                MessageBox.Show(ex.ToString());

            }
            finally
            {
                MessageBox.Show("Data was updated");
                displaystudent();
            }
        }

        public void InsertStudent( string name, string surname, string Phonenumber, int ModuleCode,string dob,string Addres)
        {
            try
            {
                string line = "Insert into StudentInfo(StudentName,StudentSurname,PhoneNumber,DOB,Adress,ModuleCode) values('" + name + "','" + surname + "','" + Phonenumber + "','" +dob + "','"+Addres + "','" +ModuleCode.ToString()+"')";
                SqlCommand command = new SqlCommand(line, con);
                command.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Data Failed to be Added");
                MessageBox.Show(ex.ToString());

            }
            finally
            {
                MessageBox.Show("Data was added");
                displaystudent();
            }
        }

        public void DeleteStudent(int StudentID)
        {
            try
            {
                string line = "DELETE FROM StudentInfo WHERE StudentID= '" + StudentID.ToString() + "'";
                SqlCommand command = new SqlCommand(line, con);
                command.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Data Failed to be Deleted");
                MessageBox.Show(ex.ToString());

            }
            finally
            {
                MessageBox.Show("Data was Deleted");
                displaystudent();
            }
        }
        public void UpdateModule(int id,string Name,string Discription,string resources)
        {
            try
            {

                string line = "Update MDinfo set  values  ModuleName='" + Name + "',ModuleDescription= '" + Discription + "', OnlineResources='" + resources + "' where StudentID= '" + id.ToString() + "'";
                SqlCommand command = new SqlCommand(line, sqlcon());
                command.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Data Failed to be Updated");
                MessageBox.Show(ex.ToString());

            }
            finally
            {
                MessageBox.Show("Data was updated");
                displayModule();
            }
        }

        public void InsertModule( string Name, string Discription, string resources)
        {
            try
            {
                string line = "Insert into MDinfo(ModuleName,ModuleDescription,OnlineResources) values('" + Name + "','" + Discription + "','" + resources + "')";
                SqlCommand command = new SqlCommand(line, con);
                command.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Data Failed to be Added");
                MessageBox.Show(ex.ToString());

            }
            finally
            {
                MessageBox.Show("Data was added");
                displayModule();
            }
        }

        public void DeleteModule(int id)
        {
            try
            {
                string line = "DELETE FROM MDinfo WHERE StudentID= '" + id.ToString() + "'";
                SqlCommand command = new SqlCommand(line, con);
                command.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Data Failed to be Deleted");
                MessageBox.Show(ex.ToString());

            }
            finally
            {
                MessageBox.Show("Data was Deleted");
                displayModule();
            }
        }





    }
}

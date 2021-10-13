using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using PRG282_Project.Properties;
using System.Drawing;

namespace PRG282_Project.DataAccesLayer
{
    class DatabaseHandler
    {
        SqlConnection con = new SqlConnection("Server=.; Initial Catalog =PRG282Project; Integrated Security=SSPI");
        public SqlConnection sqlcon()
        {
            try
            {
                con.Open();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection Failed");
                MessageBox.Show(ex.ToString());
            }

            return con;

        }
        public DataTable displaystudent()
        {
            DataTable dt = new DataTable();
            try
            {
                string query = @"Select * from Studentinfo";

                SqlDataAdapter adapter = new SqlDataAdapter(query, sqlcon());


                adapter.Fill(dt);


            }
            catch (Exception me)
            {
                MessageBox.Show("Data failed to be displayed");
                MessageBox.Show(me.ToString());
            }


            return dt;

        }


        public DataTable displayModule()
        {
            DataTable dt = new DataTable();
            try
            {
                string query = @"Select * from MDinfo";

                SqlDataAdapter adapter = new SqlDataAdapter(query, sqlcon());

                adapter.Fill(dt);

            }
            catch (Exception me)
            {
                MessageBox.Show("Data failed to be displayed");
                MessageBox.Show(me.ToString());
            }
            return dt;
        }

        public void UpdateStudent(int id, string name, string surname, string Phonenumber, int ModuleCode, byte[] bm)
        {
            con.Open();
            try
            {

                string line = "Update StudentInfo set  StudentName='" + name + "',StudentSurname= '" + surname + "', PhoneNumber='" + Phonenumber + "',ModuleCode='" + ModuleCode.ToString() + "',StudentImage=  @img "+" where StudentID= '" + id.ToString() + "'";
                SqlCommand command = new SqlCommand(line, con);
                command.Parameters.Add(new SqlParameter("@img", bm));
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

            }
            con.Close();
        }

        public void InsertStudent(int id, string name, string surname, string Phonenumber, int ModuleCode, string dob, string Addres,string gender,byte[] bm)
        {
            con.Open();
            try
            {
                string line = "Insert into StudentInfo(StudentID,StudentName,StudentSurname,PhoneNumber,DOB,Adress,ModuleCode,Gender,StudentImage) values('" + id.ToString() + "','" + name + "','" + surname + "','" + Phonenumber + "','" + dob + "','" + Addres + "','" + ModuleCode.ToString() + "','"+gender+ "', @img )";
                SqlCommand command = new SqlCommand(line, con);
                command.Parameters.Add(new SqlParameter("@img", bm));
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

            }
            con.Close();
        }

        public void DeleteStudent(int StudentID)
        {
            con.Open();
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

            }
            con.Close();
        }



        public void UpdateModule(int id, string Name, string Discription, string resources)
        {

            try
            {

                string line = "Update MDinfo set   ModuleName='" + Name + "',ModuleDescription= '" + Discription + "', OnlineResources='" + resources + "' where ModeluID= '" + id.ToString() + "'";
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

            }
            con.Close();
        }

        public void InsertModule(int id, string Name, string Discription, string resources)
        {
            con.Open();
            try
            {

                string line = "Insert into MDinfo(ModeluID,ModuleName,ModuleDescription,OnlineResources) values('" + id + "','" + Name + "','" + Discription + "','" + resources + "')";
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

            }
            con.Close();
        }

        public void DeleteModule(int id)
        {
            con.Open();
            try
            {
                string line = "DELETE FROM MDinfo WHERE ModeluID= '" + id.ToString() + "'";
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

            }
            con.Close();
        }

        public DataTable SearchStudent(int id)
        {
            DataTable dt = new DataTable();
            try
            {
                string query = "Select * from Studentinfo where StudentID='" + id.ToString() + "'";

                SqlDataAdapter adapter = new SqlDataAdapter(query, sqlcon());


                adapter.Fill(dt);


            }
            catch (Exception me)
            {
                MessageBox.Show("Data failed to be found");
                MessageBox.Show(me.ToString());
            }
            return dt;
        }

        public DataTable SearchModule(int id)
        {
            DataTable dt = new DataTable();
            try
            {
                string query = "Select * from MDinfo where ModeluID='" + id.ToString() + "'";

                SqlDataAdapter adapter = new SqlDataAdapter(query, sqlcon());


                adapter.Fill(dt);


            }
            catch (Exception me)
            {
                MessageBox.Show("Data failed to be found");
                MessageBox.Show(me.ToString());
            }
            return dt;
        }

    }
}

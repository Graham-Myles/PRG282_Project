using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PRG282_Project.BusinessLogicLayer;
using PRG282_Project.DataAccesLayer;

namespace PRG282_Project
{
    public partial class Module_Form : Form
    {
        public Module_Form()
        {
            InitializeComponent();
        }

        private void Module_Form_Load(object sender, EventArgs e)
        {
            DatabaseHandler DH = new DatabaseHandler();
            dataGridView1.DataSource = DH.displayModule();
        }

        private void btnSearch2_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtSearch.Text);
            DatabaseHandler DH = new DatabaseHandler();
            dataGridView1.DataSource = DH.SearchModule(id);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                txtModCode.Text = row.Cells["ModeluID"].Value.ToString();
                txtModName.Text = row.Cells["ModuleName"].Value.ToString();
                txtModDes.Text = row.Cells["ModuleDescription"].Value.ToString();
                txtModRes.Text = row.Cells["OnlineResources"].Value.ToString();


            }


        }

        private void btnLogout2_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnDelete2_Click(object sender, EventArgs e)
        {
            DatabaseHandler DH = new DatabaseHandler();
            int id = Convert.ToInt32(txtSearch.Text);
            DH.DeleteModule(id);
            DH.displayModule();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DatabaseHandler DH = new DatabaseHandler();
            int id = Convert.ToInt32(txtModCode.Text);
            string name = txtModName.Text;
            string description = txtModDes.Text;
            string res = txtModRes.Text;
            DH.UpdateModule(id, name, description, res);
            DH.displayModule();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DatabaseHandler DH = new DatabaseHandler();
            int id = Convert.ToInt32(txtModCode.Text);
            string name = txtModName.Text;
            string description = txtModDes.Text;
            string res = txtModRes.Text;
            DH.InsertModule(id, name, description, res);
            DH.displayModule();
        }
    }
}

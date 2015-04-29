using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace One_Stop_Shop_Queue_Management_System
{
    public partial class Admin_Add_Clerk : Form
    {
        public Admin_Add_Clerk()
        {
            InitializeComponent();
        }

        private void Admin_Add_Clerk_Load(object sender, EventArgs e)
        {
            OleDbConnection connection = Database.Connect();
            OleDbCommand command = new OleDbCommand("SELECT CSTR(Counter_No) FROM [Counter]",connection);
            connection.Open();
            OleDbDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    cbxCounterNo.Items.Add(reader.GetString(0));
                }
            }
            connection.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbConnection connection = Database.Connect();
                OleDbCommand command = new OleDbCommand("INSERT INTO Clerk VALUES ('" + txtIdNo.Text + "','" + txtFName.Text + "','" + txtMName.Text + "','" + txtLName.Text + "','" + txtUser.Text + "','" + txtPassword.Text + "'," + cbxCounterNo.SelectedItem.ToString() + ");", connection);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Clerk Successfully Hired");
                this.Dispose();
            }
            catch 
            {
                MessageBox.Show("Clerk Information has Invalid Credentials");
            }
        }
    }
}

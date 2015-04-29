using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Speech.Synthesis;
using System.Data.OleDb;

namespace One_Stop_Shop_Queue_Management_System
{
    public partial class AdminForm : Form
    {
        LoginForm l;
        public AdminForm()
        {
            InitializeComponent();
        }

        public AdminForm(LoginForm l)
            : this()
        {
            this.l = l;
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            lvClerks.Items.Clear();
            OleDbConnection connection = Database.Connect();
            OleDbCommand command = new OleDbCommand("SELECT ID_No,FirstName,MiddleName,LastName,UserName,Password,CSTR(Counter_No) FROM Clerk;",connection);
            connection.Open();
            OleDbDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    string[] data = { reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetString(6) };
                    ListViewItem l = new ListViewItem(data);
                    lvClerks.Items.Add(l);
                }
            }
            connection.Close();
        }

        private void AdminForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            l.Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            new Admin_Add_Clerk().ShowDialog();
            this.AdminForm_Load(sender, e);
        }
    }
}

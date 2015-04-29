using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;

namespace One_Stop_Shop_Queue_Management_System
{
    public class Database
    {
        /// <summary>
        /// Connects the Program into the database
        /// </summary>
        /// <returns>an OleDb Connection</returns>
        public static OleDbConnection Connect()
        {
            //To Configurate in case of Transfer of Computer
            string connetionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\user\\Documents\\OSSQMS.accdb;Persist Security Info=False;";//Tentative Database Location for Prototype Dev't
            return new OleDbConnection(connetionString);
        }
    }
}

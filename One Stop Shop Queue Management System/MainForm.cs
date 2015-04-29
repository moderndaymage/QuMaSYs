using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Speech.Synthesis;
using System.Windows.Forms;

namespace One_Stop_Shop_Queue_Management_System
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            timeRefresh.Start();
        }

        private void timeRefresh_Tick(object sender, EventArgs e)
        {
            string dateToday=monthInWords(DateTime.Now.Month)+" "+ DateTime.Now.Day+", "+DateTime.Now.Year;
            string timeToday;
            string meridian;
            //Meridian State
            if (DateTime.Now.Hour >= 12)
                meridian = "PM";
            else meridian = "AM";
            
            //Time in AM PM Notation 
            if (DateTime.Now.Hour > 12)
                timeToday = "" + (DateTime.Now.Hour - 12);
            else timeToday =""+DateTime.Now.Hour;
            timeToday+= ":" + DateTime.Now.Minute+" "+meridian;

            lblTime.Text = dateToday+" "+timeToday;
        }

        private string monthInWords(int month)
        {
            switch (month)
            {
                case 1: return "January";
                case 2: return "February";
                case 3: return "March";
                case 4: return "April";
                case 5: return "May";
                case 6: return "June";
                case 7: return "July";
                case 8: return "August";
                case 9: return "September";
                case 10: return "October";
                case 11: return "November";
                case 12: return "December";
            }
            return null;
        }

        private void txtCallClient_Click(object sender, EventArgs e)
        {
            SpeechSynthesizer s = new SpeechSynthesizer();
            s.SpeakAsync("Calling client with control number 86");
        }
    }
}

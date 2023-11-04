﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace restarunttest2
{
    

    //Restrauntdb connection
    //these are placeholders ie change (name and password) // 
    public partial class Form1 : Form
    {
        private Timer lockouttimer;
        private int lockoutDuration = 5* 60 * 1000;

        public Form1()
        {
            InitializeComponent();
            lockouttimer = new Timer();
            lockouttimer.Interval = lockoutDuration;
            lockouttimer.Tick += lockouttimer_tick;
            lockouttimer.Enabled = false;
        }
        private void lockouttimer_tick(object sender, EventArgs e)
        {
            // Timer has elapsed. Unlock the form.
            UnlockForm();
        }

        public void LockForm()
        {
            // Disable user input on the form, display a message, or take other actions.
            this.Enabled = false;
            MessageBox.Show("You are temporarily locked out. Please try again later.");
            
            lockouttimer.Start();
        }

        private void UnlockForm()
        {
            // Re-enable the form.
            lockouttimer.Stop();
            this.Enabled = true;
            MessageBox.Show("Lockout period has ended. You can now try again.");
           
        }
    


private void Form1_Load(object sender, EventArgs e)
        {
            string connectionDb = "Server=localhost;Port=3306;Database=restrauntdb2;User=admin;Password=intrestingpassword;";
            MySqlConnection connection = new MySqlConnection(connectionDb);
            try
            {
                connection.Open();
            }
            catch (MySqlException ex)
            {
                // Handle exceptions here
                Console.WriteLine("MySQL Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }

        }
    }
}

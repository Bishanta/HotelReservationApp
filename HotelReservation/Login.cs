﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Data.SqlClient;
using System.Diagnostics;

namespace HotelReservation
{
    public partial class Login : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataReader dr;
        public Login()
        {
            InitializeComponent();
            conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\source\repos\HotelReservation\HotelReservation\Reservation.mdf;Integrated Security=True");
            conn.Open();
            pass_field.PasswordChar = '*';
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String user_name = user_field.Text;
            String password = pass_field.Text;
            Debug.WriteLine(password);
            Debug.WriteLine("select * from Room where user_name=" + user_name + " and password=" + password);

            cmd = new SqlCommand("select * from Users where user_name ='"+ user_name + "' and password='" + password + "'", conn);
            
            using (dr = cmd.ExecuteReader())
            {
                if (dr.Read())
                {
                    new Main().Show();
                    this.Hide();
                }
                else error_label.Text = "Username and Password didn't match!";

            };

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void user_field_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

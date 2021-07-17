using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Diagnostics;

namespace HotelReservation
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();

        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String user_name = user_field.Text;
            String password = pass_field.Text;

            if(password.Length >= 6)
            {

                if (user_name.Length >= 3)
                {
                    SqlCommand userCheckCmd = new SqlCommand("select * from Users where user_name ='" + user_name + "'", Connection.conn);

                    using (SqlDataReader dr = userCheckCmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            error_label.Text = "Username already exits!";
                        }
                        else
                        {
                            dr.Close();
                            password = encryptpass(password);
                            SqlCommand cmd = new SqlCommand("INSERT INTO Users(user_name, password) VALUES(@username, @password)", Connection.conn);
                            cmd.Parameters.AddWithValue("username", user_name);
                            cmd.Parameters.AddWithValue("password", password);
                            int numRes = cmd.ExecuteNonQuery();
                            if (numRes > 0)
                            {
                                new Login().Show();
                                this.Hide();

                            }
                            else Debug.WriteLine("Failed to register user for some reason");
                        }


                    };

                }
                else error_label.Text = "Username should be alteast 3 characters!";

            }
            else error_label.Text = "Password should be alteast 6 characters!";

            Debug.WriteLine("INSERT INTO Users(user_name, password) VALUES('" + user_name + "', '" + password + "')");
        }

        private void login_BtnClick(object sender, EventArgs e)
        {
            new Login().Show();
            this.Hide();
        }
        public string encryptpass(string password)
        {
            string msg = "";
            byte[] encode = new byte[password.Length];
            encode = Encoding.UTF8.GetBytes(password);
            msg = Convert.ToBase64String(encode);
            return msg;
        }

        private void error_label_Click(object sender, EventArgs e)
        {

        }
    }
}

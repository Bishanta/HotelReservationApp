using System;
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

namespace HotelReservation
{
    public partial class Reserve : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        public Reserve()
        {
            InitializeComponent();
            conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\source\repos\HotelReservation\HotelReservation\Reservation.mdf;Integrated Security=True");
            conn.Open();
            this.form_heading.Text = "Room Number: " + Main.roomNum.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Reserve_Load(object sender, EventArgs e)
        {

        }

        private void confirm_btn_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("Clicked!");

            var start_date = DateTime.Parse(date_starting.Value.ToString()).ToString("MM/dd/yyyy");
            var end_date = DateTime.Parse(date_ending.Value.ToString()).ToString("MM/dd/yyyy");

            Debug.WriteLine("starting date is: " + start_date);
            Debug.WriteLine("starting date is: " + end_date);
            cmd = new SqlCommand("spReservation", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ActionType", "SaveData");
            cmd.Parameters.AddWithValue("@UserId", 1);
            cmd.Parameters.AddWithValue("@RoomId", Main.roomNum);
            cmd.Parameters.AddWithValue("@DOR", start_date);
            cmd.Parameters.AddWithValue("@DOD", end_date);
            cmd.Parameters.AddWithValue("@Status", 1);
            int numRes = cmd.ExecuteNonQuery();
            if (numRes > 0)
            {
                Button confirm = (Button)sender;
                confirm.Text = "Success";
                confirm.BackColor = Color.FromArgb(43, 117, 112);
                confirm.ForeColor = Color.White;
                confirm.Enabled = false;

            }
            else Debug.WriteLine("Failed for some reason");


        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

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
    public partial class CancelReservation : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataReader dr;
        int reservation_id;
        public CancelReservation()
        {
            InitializeComponent();
            conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\source\repos\HotelReservation\HotelReservation\Reservation.mdf;Integrated Security=True;" + "MultipleActiveResultSets=True");
            conn.Open();

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void CancelReservation_Load(object sender, EventArgs e)
        {
            form_heading.Text = "Room Number " + Main.roomNum;
            cmd = new SqlCommand("spReservation", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ActionType", "FetchBookedRoom");
            cmd.Parameters.AddWithValue("@RoomId", (int) Main.roomNum);

            dr = cmd.ExecuteReader();
            dr.Read();
            doa.Text = dr["DOR"].ToString();
            dod.Text = dr["DOD"].ToString();
            reservation_id = (int) dr["reserveId"];


        }

        private void form_heading_Click(object sender, EventArgs e)
        {

        }

        private void cancel_booking_btn_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("spReservation", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ActionType", "SaveData");
            cmd.Parameters.AddWithValue("@Status", 0);
            cmd.Parameters.AddWithValue("@DOR", dr["DOR"]);
            cmd.Parameters.AddWithValue("@DOD", dr["DOD"]);
            cmd.Parameters.AddWithValue("@RoomId", Main.roomNum);

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
            dr.Close();
        }
    }
}

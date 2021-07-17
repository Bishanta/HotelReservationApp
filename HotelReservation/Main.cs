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
    public partial class Main : Form
    {
        CheckBox hotelRoom;
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataReader dr;

        public static int roomNum;
        
        public Main()
        {
            InitializeComponent();
            conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\source\repos\HotelReservation\HotelReservation\Reservation.mdf;Integrated Security=True;" + "MultipleActiveResultSets=True");
            conn.Open();
            load_active_Reservations();
            loadCheckboxes();
            Debug.WriteLine("Hlw");

        }

        private void loadCheckboxes()
        {
 
            cmd = new SqlCommand("select * from Room where hotel_id = 1", conn);
            using (dr = cmd.ExecuteReader())
            {
                while (dr.Read())
                {
                    Debug.WriteLine(dr["room_id"]);
                    Debug.WriteLine(dr["hotel_id"]);
                    hotelRoom = new CheckBox();
                    hotelRoom.Tag = dr["room_id"];
                    hotelRoom.Text = "Room No. " + dr["room_id"];
                    hotelRoom.Name = "checkbox_room" + dr["room_id"];

                    //checking if this room is already booked
                    SqlCommand fetchReserved = new SqlCommand("select * from Reservation where room_id = " + dr["room_id"] + " and status = 1", conn);
                    Debug.WriteLine("select * from Reservation where room_id = " + dr["room_id"] + " and status = 1");
                    SqlDataReader reader = fetchReserved.ExecuteReader();
                    if(reader.Read())
                    {
                        hotelRoom.Checked = true;
                        hotelRoom.Enabled = false;
                    }
                    else
                    {
                        hotelRoom.CheckStateChanged += new EventHandler(hotelRoom_CheckStateChanged);

                    }
                    sagarmatha_panel.Controls.Add(hotelRoom);
                    reader.Close();


                }
                dr.Close();

            };
            cmd = new SqlCommand("select * from Room where hotel_id = 2", conn);
            using (dr = cmd.ExecuteReader())
            {
                while (dr.Read())
                {
                    Debug.WriteLine(dr["room_id"]);
                    Debug.WriteLine(dr["hotel_id"]);
                    hotelRoom = new CheckBox();
                    hotelRoom.Tag = dr["room_id"];
                    hotelRoom.Text = "Room No. " + dr["room_id"];
                    hotelRoom.Name = "checkbox_room" + dr["room_id"];

                    //checking if this room is already booked
                    SqlCommand fetchReserved = new SqlCommand("select * from Reservation where room_id = " + dr["room_id"] + " and status = 1", conn);
                    Debug.WriteLine("select * from Reservation where room_id = " + dr["room_id"] + " and status = 1");
                    SqlDataReader reader = fetchReserved.ExecuteReader();
                    if (reader.Read())
                    {
                        hotelRoom.Checked = true;
                        hotelRoom.Enabled = false;
                    }
                    else
                    {
                        hotelRoom.CheckStateChanged += new EventHandler(hotelRoom_CheckStateChanged);

                    }
                    hyatt_panel.Controls.Add(hotelRoom);
                    reader.Close();
                }

            };
        }

        private void load_active_Reservations()
        {
            cmd = new SqlCommand("spReservation", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ActionType", "FetchuserRecord");
            cmd.Parameters.AddWithValue("@UserId", 1);
            
            using (dr = cmd.ExecuteReader())
            {
                while (dr.Read())
                {
                    Button button = new Button();

                    button.Cursor = Cursors.Hand;
                    button.FlatAppearance.BorderSize = 0;
                    button.FlatStyle = FlatStyle.Flat;
                    button.Font = new Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    button.ForeColor = Color.White;
                    //button.Location = new Point(10, 10);
                    button.Margin = new Padding(10);
                    button.Name = "btn_" + dr["room_id"];
                    button.Tag = dr["room_id"];
                    button.Size = new Size(345, 33);
                    button.TabIndex = 5;
                    button.Text = "Room numer " + dr["room_id"];
                    button.UseVisualStyleBackColor = false;
                    if ((int) dr["status"] == 1)
                    {
                        button.BackColor = Color.FromArgb(0,192,0);
                        button.Click += new EventHandler(roombtn_ClickEvent);
                        active_reservations_panel.Controls.Add(button);

                    }
                    else
                    {
                        button.BackColor = Color.FromArgb(0, 192, 0);
                        button.Click += new EventHandler(pastRoomsBtn_ClickEvent);
                        past_reservation.Controls.Add(button);
                    }
                    
                }

            }




        }

        private void pastRoomsBtn_ClickEvent(object sender, EventArgs e)
        {
            Button selectBtn = (Button)sender;
            roomNum = (int)selectBtn.Tag;
            Debug.WriteLine(roomNum + "Booking detail for this room opened!");
            Form reserveForm = new Reserve();
            reserveForm.Show();
            reserveForm.FormClosed += reserveForm_FormClosed;
        }
        private void reserve_tab_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void roombtn_ClickEvent(object sender, EventArgs e)
        {
            Debug.WriteLine("Booking Canceled!");
            Button selectBtn = (Button)sender;
            roomNum = (int) selectBtn.Tag;
            Debug.WriteLine(roomNum + "Booking detail for this room opened!");
            CancelReservation cancelForm = new CancelReservation();
            cancelForm.Show();
            cancelForm.FormClosed += cancelForm_ClosedEvent;



        }

        private void clearAllControls(FlowLayoutPanel panel)
        {
            List<Control> listControls = new List<Control>();

            foreach (Control control in panel.Controls)
            {
                listControls.Add(control);
            }

            foreach (Control control in listControls)
            {
                flowLayoutPanel1.Controls.Remove(control);
                control.Dispose();
            }
        }

        private void cancelForm_ClosedEvent(object sender, EventArgs e)
        {
            //remove the button from active reservation
            clearAllControls(active_reservations_panel);
            clearAllControls(past_reservation);
            load_active_Reservations();


            //enable checkbox in the reserve tab
            clearAllControls(sagarmatha_panel);
            clearAllControls(hyatt_panel);
            loadCheckboxes();

            //add the button to past reservation.
        }

        private void hotelRoom_CheckStateChanged(object sender, EventArgs e)
        {
            
            CheckBox chkbox = (CheckBox)sender;
            if (chkbox != null)
            {
                if(chkbox.Checked)
                {
                    Debug.WriteLine("chkbox_CheckStateChanged");
                    Debug.WriteLine(chkbox.Text);
                    Debug.WriteLine(chkbox.Checked.ToString());
                    Debug.WriteLine(chkbox.Name.ToString());
                    Debug.WriteLine("Tag: " + chkbox.Tag);
                    roomNum = (int)chkbox.Tag;
                    Form reserveForm = new Reserve();
                    reserveForm.Show();
                    reserveForm.FormClosed += reserveForm_FormClosed;
                }


            }
        }

        private void reserveForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            //enable checkbox in the reserve tab
            clearAllControls(sagarmatha_panel);
            clearAllControls(hyatt_panel);
            loadCheckboxes();


            //change active reservations
            //remove the button from active reservation
            clearAllControls(active_reservations_panel);
            clearAllControls(past_reservation);
            load_active_Reservations();

        }

        private void history_tab_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void picture_tab_Click(object sender, EventArgs e)
        {

        }
    }
}


namespace HotelReservation
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.main_tab = new System.Windows.Forms.TabControl();
            this.picture_tab = new System.Windows.Forms.TabPage();
            this.history_tab = new System.Windows.Forms.TabPage();
            this.past_reservation = new System.Windows.Forms.FlowLayoutPanel();
            this.active_reservations_panel = new System.Windows.Forms.FlowLayoutPanel();
            this.past_reservation_heading = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.active_reservation_heading = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.reserve_tab = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.sagarmatha_panel = new System.Windows.Forms.FlowLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.hyatt_panel = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.main_tab.SuspendLayout();
            this.picture_tab.SuspendLayout();
            this.history_tab.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.reserve_tab.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            this.SuspendLayout();
            // 
            // main_tab
            // 
            this.main_tab.Controls.Add(this.reserve_tab);
            this.main_tab.Controls.Add(this.picture_tab);
            this.main_tab.Controls.Add(this.history_tab);
            this.main_tab.Location = new System.Drawing.Point(-4, 0);
            this.main_tab.Name = "main_tab";
            this.main_tab.SelectedIndex = 0;
            this.main_tab.Size = new System.Drawing.Size(804, 449);
            this.main_tab.TabIndex = 0;
            // 
            // picture_tab
            // 
            this.picture_tab.BackgroundImage = global::HotelReservation.Properties.Resources.background_cities21;
            this.picture_tab.Controls.Add(this.label4);
            this.picture_tab.Controls.Add(this.panel6);
            this.picture_tab.Controls.Add(this.flowLayoutPanel2);
            this.picture_tab.Controls.Add(this.label5);
            this.picture_tab.Controls.Add(this.panel7);
            this.picture_tab.Controls.Add(this.flowLayoutPanel3);
            this.picture_tab.Location = new System.Drawing.Point(4, 22);
            this.picture_tab.Name = "picture_tab";
            this.picture_tab.Padding = new System.Windows.Forms.Padding(3);
            this.picture_tab.Size = new System.Drawing.Size(796, 423);
            this.picture_tab.TabIndex = 1;
            this.picture_tab.Text = "Pictures";
            this.picture_tab.UseVisualStyleBackColor = true;
            this.picture_tab.Click += new System.EventHandler(this.picture_tab_Click);
            // 
            // history_tab
            // 
            this.history_tab.BackgroundImage = global::HotelReservation.Properties.Resources.background_cities21;
            this.history_tab.Controls.Add(this.past_reservation);
            this.history_tab.Controls.Add(this.active_reservations_panel);
            this.history_tab.Controls.Add(this.past_reservation_heading);
            this.history_tab.Controls.Add(this.panel5);
            this.history_tab.Controls.Add(this.active_reservation_heading);
            this.history_tab.Controls.Add(this.panel4);
            this.history_tab.Location = new System.Drawing.Point(4, 22);
            this.history_tab.Name = "history_tab";
            this.history_tab.Size = new System.Drawing.Size(796, 423);
            this.history_tab.TabIndex = 2;
            this.history_tab.Text = "History";
            this.history_tab.UseVisualStyleBackColor = true;
            this.history_tab.Click += new System.EventHandler(this.history_tab_Click);
            // 
            // past_reservation
            // 
            this.past_reservation.BackColor = System.Drawing.Color.Transparent;
            this.past_reservation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.past_reservation.Location = new System.Drawing.Point(27, 250);
            this.past_reservation.Name = "past_reservation";
            this.past_reservation.Size = new System.Drawing.Size(758, 140);
            this.past_reservation.TabIndex = 8;
            // 
            // active_reservations_panel
            // 
            this.active_reservations_panel.BackColor = System.Drawing.Color.Transparent;
            this.active_reservations_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.active_reservations_panel.Location = new System.Drawing.Point(25, 55);
            this.active_reservations_panel.Name = "active_reservations_panel";
            this.active_reservations_panel.Size = new System.Drawing.Size(760, 119);
            this.active_reservations_panel.TabIndex = 7;
            // 
            // past_reservation_heading
            // 
            this.past_reservation_heading.AutoSize = true;
            this.past_reservation_heading.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.past_reservation_heading.Location = new System.Drawing.Point(23, 204);
            this.past_reservation_heading.Margin = new System.Windows.Forms.Padding(15, 15, 15, 5);
            this.past_reservation_heading.Name = "past_reservation_heading";
            this.past_reservation_heading.Size = new System.Drawing.Size(175, 24);
            this.past_reservation_heading.TabIndex = 5;
            this.past_reservation_heading.Text = "Past Reservations";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.panel5.Location = new System.Drawing.Point(28, 236);
            this.panel5.Margin = new System.Windows.Forms.Padding(20, 3, 3, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(150, 2);
            this.panel5.TabIndex = 6;
            // 
            // active_reservation_heading
            // 
            this.active_reservation_heading.AutoSize = true;
            this.active_reservation_heading.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.active_reservation_heading.Location = new System.Drawing.Point(21, 15);
            this.active_reservation_heading.Margin = new System.Windows.Forms.Padding(15, 15, 15, 5);
            this.active_reservation_heading.Name = "active_reservation_heading";
            this.active_reservation_heading.Size = new System.Drawing.Size(193, 24);
            this.active_reservation_heading.TabIndex = 5;
            this.active_reservation_heading.Text = "Active Reservations";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.panel4.Location = new System.Drawing.Point(26, 47);
            this.panel4.Margin = new System.Windows.Forms.Padding(20, 3, 3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(150, 2);
            this.panel4.TabIndex = 6;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 2);
            this.label4.Margin = new System.Windows.Forms.Padding(15, 15, 15, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(175, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "Hotel Sagarmatha";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.panel6.Location = new System.Drawing.Point(18, 34);
            this.panel6.Margin = new System.Windows.Forms.Padding(20, 3, 3, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(150, 2);
            this.panel6.TabIndex = 9;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.pictureBox1);
            this.flowLayoutPanel2.Controls.Add(this.pictureBox3);
            this.flowLayoutPanel2.Controls.Add(this.pictureBox2);
            this.flowLayoutPanel2.Controls.Add(this.pictureBox4);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(17, 49);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(15);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(760, 164);
            this.flowLayoutPanel2.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 217);
            this.label5.Margin = new System.Windows.Forms.Padding(15, 15, 15, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 24);
            this.label5.TabIndex = 7;
            this.label5.Text = "Hyatt Hotel";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.panel7.Location = new System.Drawing.Point(18, 249);
            this.panel7.Margin = new System.Windows.Forms.Padding(20, 3, 3, 3);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(80, 2);
            this.panel7.TabIndex = 10;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.pictureBox7);
            this.flowLayoutPanel3.Controls.Add(this.pictureBox5);
            this.flowLayoutPanel3.Controls.Add(this.pictureBox6);
            this.flowLayoutPanel3.Controls.Add(this.pictureBox8);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(16, 261);
            this.flowLayoutPanel3.Margin = new System.Windows.Forms.Padding(15);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(760, 162);
            this.flowLayoutPanel3.TabIndex = 11;
            // 
            // reserve_tab
            // 
            this.reserve_tab.BackgroundImage = global::HotelReservation.Properties.Resources.background_cities21;
            this.reserve_tab.Controls.Add(this.flowLayoutPanel1);
            this.reserve_tab.Controls.Add(this.label1);
            this.reserve_tab.Controls.Add(this.panel1);
            this.reserve_tab.Location = new System.Drawing.Point(4, 22);
            this.reserve_tab.Name = "reserve_tab";
            this.reserve_tab.Padding = new System.Windows.Forms.Padding(3);
            this.reserve_tab.Size = new System.Drawing.Size(796, 423);
            this.reserve_tab.TabIndex = 0;
            this.reserve_tab.Text = "Reserve";
            this.reserve_tab.UseVisualStyleBackColor = true;
            this.reserve_tab.Click += new System.EventHandler(this.reserve_tab_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.label2);
            this.flowLayoutPanel1.Controls.Add(this.panel2);
            this.flowLayoutPanel1.Controls.Add(this.sagarmatha_panel);
            this.flowLayoutPanel1.Controls.Add(this.label3);
            this.flowLayoutPanel1.Controls.Add(this.panel3);
            this.flowLayoutPanel1.Controls.Add(this.hyatt_panel);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 57);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(790, 367);
            this.flowLayoutPanel1.TabIndex = 6;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 15);
            this.label2.Margin = new System.Windows.Forms.Padding(15, 15, 15, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Hotel Sagarmatha";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.panel2.Location = new System.Drawing.Point(20, 47);
            this.panel2.Margin = new System.Windows.Forms.Padding(20, 3, 3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(150, 2);
            this.panel2.TabIndex = 4;
            // 
            // sagarmatha_panel
            // 
            this.sagarmatha_panel.BackColor = System.Drawing.Color.Transparent;
            this.sagarmatha_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sagarmatha_panel.Location = new System.Drawing.Point(15, 67);
            this.sagarmatha_panel.Margin = new System.Windows.Forms.Padding(15);
            this.sagarmatha_panel.Name = "sagarmatha_panel";
            this.sagarmatha_panel.Size = new System.Drawing.Size(760, 100);
            this.sagarmatha_panel.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 197);
            this.label3.Margin = new System.Windows.Forms.Padding(15, 15, 15, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "Hyatt Hotel";
            this.label3.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.panel3.Location = new System.Drawing.Point(20, 229);
            this.panel3.Margin = new System.Windows.Forms.Padding(20, 3, 3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(80, 2);
            this.panel3.TabIndex = 4;
            // 
            // hyatt_panel
            // 
            this.hyatt_panel.BackColor = System.Drawing.Color.Transparent;
            this.hyatt_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.hyatt_panel.ForeColor = System.Drawing.Color.Black;
            this.hyatt_panel.Location = new System.Drawing.Point(15, 249);
            this.hyatt_panel.Margin = new System.Windows.Forms.Padding(15);
            this.hyatt_panel.Name = "hyatt_panel";
            this.hyatt_panel.Size = new System.Drawing.Size(760, 100);
            this.hyatt_panel.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(280, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Available Reservations";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.panel1.Location = new System.Drawing.Point(285, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(236, 2);
            this.panel1.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HotelReservation.Properties.Resources.hotel1;
            this.pictureBox1.Location = new System.Drawing.Point(3, 10);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(180, 154);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::HotelReservation.Properties.Resources.hotel2;
            this.pictureBox3.Location = new System.Drawing.Point(189, 10);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(187, 154);
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::HotelReservation.Properties.Resources.photo;
            this.pictureBox2.Location = new System.Drawing.Point(382, 10);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(187, 154);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::HotelReservation.Properties.Resources.hotel4;
            this.pictureBox4.Location = new System.Drawing.Point(575, 10);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(180, 154);
            this.pictureBox4.TabIndex = 0;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::HotelReservation.Properties.Resources.hotel5;
            this.pictureBox7.Location = new System.Drawing.Point(3, 10);
            this.pictureBox7.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(187, 145);
            this.pictureBox7.TabIndex = 1;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::HotelReservation.Properties.Resources.hotel1;
            this.pictureBox5.Location = new System.Drawing.Point(196, 10);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(180, 145);
            this.pictureBox5.TabIndex = 0;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::HotelReservation.Properties.Resources.hotel2;
            this.pictureBox6.Location = new System.Drawing.Point(382, 10);
            this.pictureBox6.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(187, 145);
            this.pictureBox6.TabIndex = 1;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = global::HotelReservation.Properties.Resources.photo;
            this.pictureBox8.Location = new System.Drawing.Point(575, 10);
            this.pictureBox8.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(180, 145);
            this.pictureBox8.TabIndex = 0;
            this.pictureBox8.TabStop = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.main_tab);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.main_tab.ResumeLayout(false);
            this.picture_tab.ResumeLayout(false);
            this.picture_tab.PerformLayout();
            this.history_tab.ResumeLayout(false);
            this.history_tab.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel3.ResumeLayout(false);
            this.reserve_tab.ResumeLayout(false);
            this.reserve_tab.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.TabControl main_tab;
        private System.Windows.Forms.TabPage reserve_tab;
        private System.Windows.Forms.TabPage picture_tab;
        private System.Windows.Forms.TabPage history_tab;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel sagarmatha_panel;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.FlowLayoutPanel hyatt_panel;
        private System.Windows.Forms.FlowLayoutPanel past_reservation;
        private System.Windows.Forms.FlowLayoutPanel active_reservations_panel;
        private System.Windows.Forms.Label past_reservation_heading;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label active_reservation_heading;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox8;
    }
}
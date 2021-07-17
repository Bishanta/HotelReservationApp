
namespace HotelReservation
{
    partial class CancelReservation
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
            this.label1 = new System.Windows.Forms.Label();
            this.hotel_name = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.doa = new System.Windows.Forms.Label();
            this.label99 = new System.Windows.Forms.Label();
            this.dod = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.form_heading = new System.Windows.Forms.Label();
            this.cancel_booking_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(135, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Hotel Name : ";
            // 
            // hotel_name
            // 
            this.hotel_name.AutoSize = true;
            this.hotel_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hotel_name.ForeColor = System.Drawing.Color.Black;
            this.hotel_name.Location = new System.Drawing.Point(249, 78);
            this.hotel_name.Name = "hotel_name";
            this.hotel_name.Size = new System.Drawing.Size(122, 18);
            this.hotel_name.TabIndex = 2;
            this.hotel_name.Text = "Reservation Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(135, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Date of Arrival :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // doa
            // 
            this.doa.AutoSize = true;
            this.doa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doa.ForeColor = System.Drawing.Color.Black;
            this.doa.Location = new System.Drawing.Point(249, 110);
            this.doa.Name = "doa";
            this.doa.Size = new System.Drawing.Size(122, 18);
            this.doa.TabIndex = 2;
            this.doa.Text = "Reservation Date";
            this.doa.Click += new System.EventHandler(this.label4_Click);
            // 
            // label99
            // 
            this.label99.AutoSize = true;
            this.label99.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label99.ForeColor = System.Drawing.Color.Black;
            this.label99.Location = new System.Drawing.Point(135, 141);
            this.label99.Name = "label99";
            this.label99.Size = new System.Drawing.Size(81, 18);
            this.label99.TabIndex = 2;
            this.label99.Text = "Departure :";
            this.label99.Click += new System.EventHandler(this.label3_Click);
            // 
            // dod
            // 
            this.dod.AutoSize = true;
            this.dod.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dod.ForeColor = System.Drawing.Color.Black;
            this.dod.Location = new System.Drawing.Point(249, 141);
            this.dod.Name = "dod";
            this.dod.Size = new System.Drawing.Size(122, 18);
            this.dod.TabIndex = 2;
            this.dod.Text = "Reservation Date";
            this.dod.Click += new System.EventHandler(this.label4_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.panel1.Location = new System.Drawing.Point(138, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(236, 1);
            this.panel1.TabIndex = 6;
            // 
            // form_heading
            // 
            this.form_heading.AutoSize = true;
            this.form_heading.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.form_heading.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.form_heading.Location = new System.Drawing.Point(173, 15);
            this.form_heading.Name = "form_heading";
            this.form_heading.Size = new System.Drawing.Size(0, 25);
            this.form_heading.TabIndex = 5;
            this.form_heading.Click += new System.EventHandler(this.form_heading_Click);
            // 
            // cancel_booking_btn
            // 
            this.cancel_booking_btn.BackColor = System.Drawing.Color.Red;
            this.cancel_booking_btn.FlatAppearance.BorderSize = 0;
            this.cancel_booking_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancel_booking_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel_booking_btn.ForeColor = System.Drawing.Color.White;
            this.cancel_booking_btn.Location = new System.Drawing.Point(95, 184);
            this.cancel_booking_btn.Name = "cancel_booking_btn";
            this.cancel_booking_btn.Size = new System.Drawing.Size(333, 27);
            this.cancel_booking_btn.TabIndex = 7;
            this.cancel_booking_btn.Text = "Cancel Booking";
            this.cancel_booking_btn.UseVisualStyleBackColor = false;
            this.cancel_booking_btn.Click += new System.EventHandler(this.cancel_booking_btn_Click);
            // 
            // CancelReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 236);
            this.Controls.Add(this.cancel_booking_btn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.form_heading);
            this.Controls.Add(this.dod);
            this.Controls.Add(this.doa);
            this.Controls.Add(this.label99);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.hotel_name);
            this.Controls.Add(this.label1);
            this.Name = "CancelReservation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reservation Detail";
            this.Load += new System.EventHandler(this.CancelReservation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label hotel_name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label doa;
        private System.Windows.Forms.Label label99;
        private System.Windows.Forms.Label dod;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label form_heading;
        private System.Windows.Forms.Button cancel_booking_btn;
    }
}
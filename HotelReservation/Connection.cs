using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace HotelReservation
{
    class Connection
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataReader dr;
        Connection()
        {
            conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\source\repos\HotelReservation\HotelReservation\Reservation.mdf;Integrated Security=True;" + "MultipleActiveResultSets=True");
        }
    }
}

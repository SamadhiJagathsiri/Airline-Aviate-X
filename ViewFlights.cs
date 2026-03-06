using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;


namespace Project
{
    public partial class ViewFlights : Form
    {
        private string username;
        public ViewFlights(string loggedInUsername)
        {
            InitializeComponent();
            username = loggedInUsername;
            LoadBookings();
        }
        private string connectionString = "Data Source=DESKTOP-7JUK9DS\\SQLEXPRESS04;Initial Catalog=Aviation; Integrated Security=True";

        private void btnBack_Click(object sender, EventArgs e)
        {
            Admin newForm = new Admin(username);
            this.Hide();         // Hide Form1
            newForm.Show();
        }

        private void LoadBookings()
        {

            using (SqlConnection conn = new SqlConnection(connectionString))
            {

                string query = @"
                    SELECT 
                        b.BookingID,
                        b.PassengerName,
                        b.ContactNo,
                        f.FlightID,
                        f.Departure,
                        f.Destination,
                        f.DepartureTime,
                        f.Price,
                        b.BookingDate
                    FROM Booking b
                    INNER JOIN Flight f ON b.FlightID = f.FlightID
                    ORDER BY b.BookingDate DESC";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();

                try
                {
                    conn.Open();
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading bookings: " + ex.Message);

                }

            }
        }
        private void ViewFlights_Load(object sender, EventArgs e)
        {

            LoadBookings();
        }

        string selectedBookingID = "";
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedBookingID = dataGridView1.Rows[e.RowIndex].Cells["BookingID"].Value.ToString();
            }

        }

        private void dataGridView1_AutoSizeColumnsModeChanged(object sender, DataGridViewAutoSizeColumnsModeEventArgs e)
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        private void dataGridView1_MultiSelectChanged(object sender, EventArgs e)
        {
            dataGridView1.MultiSelect = false;

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(selectedBookingID))
            {
                MessageBox.Show("Please select a booking to cancel.");
                return;
            }
            var confirm = MessageBox.Show("Are you sure you want to cancel this booking?", "Confirm", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.No) return;
            string connectionString = "Data Source=DESKTOP-7JUK9DS\\SQLEXPRESS04;Initial Catalog=Aviation;Integrated Security=True";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM Booking WHERE BookingID = @bookingID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@bookingID", selectedBookingID);

                try
                {
                    conn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Booking cancelled successfully!");
                        LoadBookings(); // refresh grid after delete
                        selectedBookingID = ""; // clear selection
                    }
                    else
                    {
                        MessageBox.Show("No matching booking found.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }


            }

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            
        
            LoadBookings(); // Re-fetch and reload data from database
            MessageBox.Show("Bookings list refreshed!");
        }

    }
}



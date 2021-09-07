using Npgsql;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Library
{
    public partial class RentReturn : Form
    {
        NpgsqlConnection connect = new NpgsqlConnection("server=localHost; port=5432; Database=Library; user ID=postgres; password=1234;");
        public RentReturn()
        {
            InitializeComponent();

            connect.Open();

            string query = @"select r.book_id, r.book_name, u.user_name, u.user_surname from rental r, users u where u.user_id = r.rentedto order by r.book_id";
            int i;
            string text;

            NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, connect);
            DataSet ds = new DataSet();

            da.Fill(ds);

            connect.Close();

            if (ds.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("Kiralanmış kitap yok.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                comboBox1.Enabled = false;
            }
            else
            {
                for (i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    text = ds.Tables[0].Rows[i][0] + " - " + ds.Tables[0].Rows[i][1] + " - " + ds.Tables[0].Rows[i][2] + " " + ds.Tables[0].Rows[i][3];
                    comboBox1.Items.Add(text);
                }
            }
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == null)
            {
                button1.Enabled = false;
            }
            else
            {
                button1.Enabled = true;
            }

            string[] book = comboBox1.Text.Split('-');

            string query = @"select r.book_rentalfinish, b.b_rent from rental r, books b where book_id = b_id and book_id = " + book[0].Trim();

            connect.Open();

            NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, connect);
            DataSet ds = new DataSet();
            da.Fill(ds);

            connect.Close();

            DateTime now = DateTime.Now.Date;
            DateTime finish = Convert.ToDateTime(ds.Tables[0].Rows[0][0]);

            if (finish < now)
            {
                TimeSpan latency = now.Subtract(finish);
                textBox1.Text = latency.TotalDays.ToString() + " Gün";

                int money = Convert.ToInt32(ds.Tables[0].Rows[0][1]) * 2 * Convert.ToInt32(latency.TotalDays);
                textBox2.Text = money.ToString() + "₺";
            }
            else
            {
                textBox1.Text = "0 Gün";
                textBox2.Text = "0₺";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] name = comboBox1.Text.Split('-');

            DialogResult result = MessageBox.Show("Silmek istediğinize emin misiniz?", "Kontrol", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                string query = @"delete from rental where book_id = " + name[0].Trim();

                connect.Open();

                NpgsqlCommand cmd = new NpgsqlCommand(query, connect);
                cmd.ExecuteNonQuery();

                query = @"update books set is_taken = 'false' where b_id =" + name[0].Trim();

                cmd = new NpgsqlCommand(query, connect);
                cmd.ExecuteNonQuery();

                connect.Close();

                Close();
            }
        }
    }
}

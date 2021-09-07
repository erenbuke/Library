using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace Library
{
    public partial class MainMenu : Form
    {

        NpgsqlConnection connect = new NpgsqlConnection("server=localHost; port=5432; Database=Library; user ID=postgres; password=1234;");
        public MainMenu()
        {
            InitializeComponent();
            connect.Open();

            panel1.Visible = true;
            panel2.Visible = false;
            panel3.Visible = false;
            string query = @"select * from books";

            NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, connect);
            DataSet ds = new DataSet();

            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.Sort(dataGridView1.Columns[0], ListSortDirection.Ascending);
            connect.Close();
        }

        private void rentPage_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = true;
            booksPage.Enabled = true;
            rentPage.Enabled = false;
            usersPage.Enabled = true;

            connect.Open();

            string query = @"select * from rental";

            NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, connect);
            DataSet ds = new DataSet();

            da.Fill(ds);
            dataGridView2.DataSource = ds.Tables[0];
            dataGridView2.Sort(dataGridView2.Columns[0], ListSortDirection.Ascending);

            connect.Close();
        }

        private void booksPage_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = false;
            panel3.Visible = false;
            booksPage.Enabled = false;
            rentPage.Enabled = true;
            usersPage.Enabled = true;

            connect.Open();

            string query = @"select * from books";

            NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, connect);
            DataSet ds = new DataSet();

            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.Sort(dataGridView1.Columns[0], ListSortDirection.Ascending);

            connect.Close();
        }

        private void usersPage_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = true;
            panel3.Visible = false;
            booksPage.Enabled = true;
            rentPage.Enabled = true;
            usersPage.Enabled = false;

            connect.Open();

            string query = @"select * from users";

            NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, connect);
            DataSet ds = new DataSet();

            da.Fill(ds);
            dataGridView3.DataSource = ds.Tables[0];
            dataGridView3.Sort(dataGridView3.Columns[0], ListSortDirection.Ascending);

            connect.Close();
        }

        private void addbook_Click(object sender, EventArgs e)
        {
            
            AddBook f3 = new AddBook();
            f3.ShowDialog();

            connect.Open();
            string query = @"select * from books";

            NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, connect);
            DataSet ds = new DataSet();

            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.Sort(dataGridView1.Columns[0], ListSortDirection.Ascending);
            connect.Close();

        }

        private void refresh_Click(object sender, EventArgs e)
        {
            connect.Open();
            string query = @"select * from books";

            NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, connect);
            DataSet ds = new DataSet();

            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.Sort(dataGridView1.Columns[0], ListSortDirection.Ascending);
            connect.Close();

        }

        private void deletebook_Click(object sender, EventArgs e)
        {
            DialogResult dialog = new DialogResult();

            dialog = MessageBox.Show("Seçili kitabı silmek istediğinize emin misiniz?", "Kontrol", MessageBoxButtons.YesNo);

            if (dialog == DialogResult.Yes) 
            {
                connect.Open();
                string query = @"delete from books where b_id = " + dataGridView1.SelectedRows[0].Cells[0].Value;
                NpgsqlCommand cmd = new NpgsqlCommand(query, connect);
                cmd.ExecuteNonQuery();
                query = @"select * from books";
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, connect);
                DataSet ds = new DataSet();

                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                dataGridView1.Sort(dataGridView1.Columns[0], ListSortDirection.Ascending);
                connect.Close();
            }
        }

        private void refresh2_Click(object sender, EventArgs e)
        {
            connect.Open();
            string query = @"select * from rental";

            NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, connect);
            DataSet ds = new DataSet();

            da.Fill(ds);
            dataGridView2.DataSource = ds.Tables[0];
            dataGridView2.Sort(dataGridView2.Columns[0], ListSortDirection.Ascending);
            connect.Close();
        }

        private void rent_Click(object sender, EventArgs e)
        {
            RentBook f4 = new RentBook();
            f4.ShowDialog();

            connect.Open();

            string query = @"select * from rental";

            NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, connect);
            DataSet ds = new DataSet();

            da.Fill(ds);

            dataGridView2.DataSource = ds.Tables[0];
            dataGridView2.Sort(dataGridView2.Columns[0], ListSortDirection.Ascending);
            connect.Close();
        }

        private void addUser_Click(object sender, EventArgs e)
        {
            AddUser f5 = new AddUser();
            f5.ShowDialog();

            connect.Open();

            string query = @"select * from users";

            NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, connect);
            DataSet ds = new DataSet();

            da.Fill(ds);

            dataGridView3.DataSource = ds.Tables[0];
            dataGridView3.Sort(dataGridView3.Columns[0], ListSortDirection.Ascending);

            connect.Close();
        }

        private void refresh3_Click(object sender, EventArgs e)
        {
            connect.Open();
            string query = @"select * from users";

            NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, connect);
            DataSet ds = new DataSet();

            da.Fill(ds);
            dataGridView3.DataSource = ds.Tables[0];
            dataGridView3.Sort(dataGridView3.Columns[0], ListSortDirection.Ascending);
            connect.Close();

        }

        private void deleteUser_Click(object sender, EventArgs e)
        {
            DialogResult dialog = new DialogResult();

            dialog = MessageBox.Show("Seçili kullanıcıyı silmek istediğinize emin misiniz?", "Kontrol", MessageBoxButtons.YesNo);

            if (dialog == DialogResult.Yes)
            {
                connect.Open();
                string query = @"delete from users where user_id = " + dataGridView3.SelectedRows[0].Cells[0].Value;
                NpgsqlCommand cmd = new NpgsqlCommand(query, connect);
                cmd.ExecuteNonQuery();

                query = @"select * from users";
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, connect);
                DataSet ds = new DataSet();

                da.Fill(ds);
                dataGridView3.DataSource = ds.Tables[0];
                dataGridView3.Sort(dataGridView3.Columns[0], ListSortDirection.Ascending);
                connect.Close();
            }
        }

        private void rentPayment_Click(object sender, EventArgs e)
        {
            RentReturn f1 = new RentReturn();
            f1.ShowDialog();

            connect.Open();

            string query = @"select * from rental";

            NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, connect);
            DataSet ds = new DataSet();

            da.Fill(ds);

            dataGridView2.DataSource = ds.Tables[0];
            dataGridView2.Sort(dataGridView2.Columns[0], ListSortDirection.Ascending);

            connect.Close();
        }
    }
}

using Npgsql;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Library
{
    public partial class AddType : Form
    {
        NpgsqlConnection connect = new NpgsqlConnection("server=localHost; port=5432; Database=Library; user ID=postgres; password=1234;");
        public AddType()
        {
            InitializeComponent();

            connect.Open();

            string query = @"select * from categories order by categories";

            NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, connect);
            DataSet ds = new DataSet();

            da.Fill(ds);

            connect.Close();

            int i;

            if (ds.Tables[0].Rows.Count != 0)
            {
                for (i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    listBox1.Items.Add(ds.Tables[0].Rows[i][0]);
                }
            }

        }

        private void add_Click(object sender, EventArgs e)
        {
            if (newType.Text.Equals(string.Empty))
            {
                MessageBox.Show("Lütfen kutuyu doldurunuz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                connect.Open();

                string query = @"insert into categories values('" + newType.Text + "')";
                NpgsqlCommand cmd = new NpgsqlCommand(query, connect);
                cmd.ExecuteNonQuery();

                connect.Close();

                MessageBox.Show("Eklendi.");

                AddBook f1 = new AddBook();
                this.Hide();
                f1.ShowDialog();
                this.Close();
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen listeden silinecek kategori seçiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string delete = listBox1.SelectedItem.ToString();

                DialogResult dialog = new DialogResult();

                dialog = MessageBox.Show("Seçili kategoriyi silmek istediğinize emin misiniz?", "Kontrol", MessageBoxButtons.YesNo);

                if (dialog == DialogResult.Yes)
                {
                    connect.Open();

                    string query = "delete from categories where categories = '" + delete + "'";
                    NpgsqlCommand cmd = new NpgsqlCommand(query, connect);
                    cmd.ExecuteNonQuery();

                    connect.Close();
                }
            }
        }
    }
}

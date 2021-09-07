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
    public partial class AddDiscount : Form
    {
        NpgsqlConnection connect = new NpgsqlConnection("server=localHost; port=5432; Database=Library; user ID=postgres; password=1234;");
        public AddDiscount()
        {
            InitializeComponent();

            connect.Open();

            string query = @"select * from discounts";

            NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, connect);
            DataSet ds = new DataSet();
            da.Fill(ds);

            connect.Close();

            int i;
            string text;
            if(ds.Tables[0].Rows.Count != 0)
            {
                for(i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    text = ds.Tables[0].Rows[i][0] + " - %" + ds.Tables[0].Rows[i][1];
                    listBox1.Items.Add(text);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text.Equals("") || textBox2.Text.Equals(""))
            {
                MessageBox.Show("Lütfen kutuları doldurunuz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                connect.Open();
                string query = @"insert into discounts values('" + textBox1.Text + "', " + textBox2.Text + ")";

                NpgsqlCommand cmd = new NpgsqlCommand(query, connect);
                cmd.ExecuteNonQuery();
                connect.Close();

                MessageBox.Show("İndirim Eklendi.");

                AddUser f1 = new AddUser();
                this.Hide();
                f1.ShowDialog();
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string[] delete = listBox1.SelectedItem.ToString().Split('-');

            DialogResult dialog = new DialogResult();

            dialog = MessageBox.Show("Seçili indirimi silmek istediğinize emin misiniz?", "Kontrol", MessageBoxButtons.YesNo);

            if (dialog == DialogResult.Yes)
            {
                connect.Open();

                string query = "delete from discounts where discount_name = '" + delete[0].Trim() + "'";
                NpgsqlCommand cmd = new NpgsqlCommand(query, connect);
                cmd.ExecuteNonQuery();

                connect.Close();

            }

        }
    }
}

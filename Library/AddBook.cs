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
    public partial class AddBook : Form
    {

        NpgsqlConnection connect = new NpgsqlConnection("server=localHost; port=5432; Database=Library; user ID=postgres; password=1234;");
        public AddBook()
        {
            InitializeComponent();

            int i;
            int exit;
            connect.Open();
            string query = @"select * from categories order by categories";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, connect);

            DataSet ds = new DataSet();

            da.Fill(ds);
            if(ds.Tables[0].Rows.Count != 0)
            {
                for (i = 0; i < ds.Tables[0].Rows.Count; i++)
                    category.Items.Add(ds.Tables[0].Rows[i]["categories"]);
            }

            query = @"select * from books order by b_id";
            da = new NpgsqlDataAdapter(query, connect);
            DataSet ds2 = new DataSet();

            da.Fill(ds2);
            exit = 0;
            i = 0;

            while(i < ds2.Tables[0].Rows.Count && exit == 0)
            {
                if (i + 1 != Int32.Parse(ds2.Tables[0].Rows[i]["b_id"].ToString()))
                {
                    exit = 1;
                }
                i++;
            }
            if(exit == 0)
            {
                i++;
            }

            bID.Text = i.ToString();

            connect.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int j;
            if(bID.Text.Equals("") || name.Text.Equals("") || category.Text.Equals("") || section.Text.Equals("") || row.Text.Equals("") || money.Text.Equals(""))
            {
                MessageBox.Show("Lütfen boşlukları eksiksiz doldurun.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(!(Int32.TryParse(section.Text, out j) || Int32.TryParse(row.Text, out j) || Int32.TryParse(money.Text, out j)))
            {
                MessageBox.Show("Lütfen Bölüm, Raf ve Fiyat kutucuklarına sayı girin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                connect.Open();
                string query = "select * from books order by b_id";
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, connect);
                DataSet ds = new DataSet();
                da.Fill(ds);

                query = @"insert into books values(" + bID.Text + ", '" + name.Text + "', '" + category.Text + "', " + section.Text + ", " + row.Text + ", 'false', " + money.Text + ")";

                NpgsqlCommand cmd = new NpgsqlCommand(query, connect);
                cmd.ExecuteNonQuery();
                DialogResult result;
                result = MessageBox.Show("Kitap eklendi.\nBaşka kitap eklemek ister misiniz?", "", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {


                    int exit = 0;
                    int i = 0;
                    query = "select * from books order by b_id";
                    da = new NpgsqlDataAdapter(query, connect);
                    DataSet ds2 = new DataSet();
                    da.Fill(ds2);

                    while (i < ds2.Tables[0].Rows.Count && exit == 0)
                    {
                        if (i + 1 != Int32.Parse(ds2.Tables[0].Rows[i]["b_id"].ToString()))
                        {
                            exit = 1;
                        }
                        i++;
                    }
                    if (exit == 0)
                    {
                        i++;
                    }

                    bID.Text = i.ToString();
                    name.Text = null;
                    category.Text = null;
                    section.Text = null;
                    row.Text = null;
                    money.Text = null;
                }
                else
                {
                    this.Close();
                }

                connect.Close();
            }
        }

        private void row_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                button1_Click(this, new EventArgs());
            }
        }

        private void newType_Click(object sender, EventArgs e)
        {
            AddType f1 = new AddType();
            this.Hide();
            f1.ShowDialog();
            this.Close();
        }
    }
}

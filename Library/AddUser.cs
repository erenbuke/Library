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
    public partial class AddUser : Form
    {
        NpgsqlConnection connect = new NpgsqlConnection("server=localHost; port=5432; Database=Library; user ID=postgres; password=1234;");

        public AddUser()
        {
            InitializeComponent();

            int i;
            int exit;
            connect.Open();

            string query = @"select * from discounts order by discount_name";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, connect);

            DataSet ds = new DataSet();
            da.Fill(ds);

            string add;

            for(i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                add = ds.Tables[0].Rows[i]["discount_name"] + @"- %" + ds.Tables[0].Rows[i]["discount_percent"];
                userDiscount.Items.Add(add);
            }

            DataSet ds2 = new DataSet();
            query = @"select * from users order by user_id";
            da = new NpgsqlDataAdapter(query, connect);
            da.Fill(ds2);

            i = 0;
            exit = 0;

            if (ds2.Tables[0].Rows.Count == 0)
            {
                i = 1;
            }
            else
            {

                while (i < ds2.Tables[0].Rows.Count && exit == 0)
                {
                    if (!(i + 1).ToString().Equals(ds2.Tables[0].Rows[i]["user_id"].ToString()))
                    {
                        exit = 1;
                    }
                    
                    i++;
                    
                }

                if (exit == 0)
                {
                    i++;
                }

            }
            connect.Close();

            userID.Text = i.ToString();

        }

        private void confirmUser_Click(object sender, EventArgs e)
        {
            if(userName.Text.Equals("") || userSurname.Text.Equals("") || userDiscount.Text.Equals(""))
            {
                MessageBox.Show("Lütfen kutuları doldurunuz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string[] discount = userDiscount.Text.Split('-');
                string query = @"insert into users values(" + userID.Text + ", '" + userName.Text + "', '" + userSurname.Text + "', '" + discount[0] + "')";

                connect.Open();
                NpgsqlCommand cmd = new NpgsqlCommand(query, connect);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Kullanıcı eklendi");
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddDiscount f1 = new AddDiscount();
            this.Hide();
            f1.ShowDialog();
            this.Close();
        }
    }
}

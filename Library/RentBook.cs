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
    public partial class RentBook : Form
    {
        NpgsqlConnection connect = new NpgsqlConnection("server=localHost; port=5432; Database=Library; user ID=postgres; password=1234;");

        public RentBook()
        {
            InitializeComponent();

            connect.Open();
            string query = @"select b_id, b_name from books where is_taken = 'false' order by b_id";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, connect);
            DataSet ds = new DataSet();
            da.Fill(ds);

            int i;
            string add;

            for(i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                add = ds.Tables[0].Rows[i][0].ToString()+ "- " + ds.Tables[0].Rows[i][1].ToString();
                bookSelect.Items.Add(add);
            }

            query = @"select user_name, user_surname from users order by user_name";
            da = new NpgsqlDataAdapter(query, connect);
            DataSet ds2 = new DataSet();

            da.Fill(ds2);

            for(i = 0; i < ds2.Tables[0].Rows.Count; i++)
            {
                add = ds2.Tables[0].Rows[i][0] + " " + ds2.Tables[0].Rows[i][1];
                renteduser.Items.Add(add);
            }

            DataSet ds3 = new DataSet();
            query = @"select * from rental order by rent_id";
            da = new NpgsqlDataAdapter(query, connect);
            da.Fill(ds3);

            i = 0;
            int exit = 0;

            if (ds3.Tables[0].Rows.Count == 0)
            {
                i = 1;
            }
            else
            {

                while (i < ds3.Tables[0].Rows.Count && exit == 0)
                {
                    if (!(i + 1).ToString().Equals(ds3.Tables[0].Rows[i]["rent_id"].ToString()))
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

            rentID.Text = i.ToString();

            connect.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            connect.Open();
            string[] split = bookSelect.Text.Split('-');
            string[] split2 = renteduser.Text.Split(' ');

            string query = @"select user_id from users where user_name = '"+ split2[0] +"' and user_surname = '"+ split2[1] +"'";

            NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, connect);
            DataSet ds = new DataSet();

            da.Fill(ds);

            string userid = ds.Tables[0].Rows[0][0].ToString();
            string date = DateTime.Now.Year + "-" + DateTime.Now.Month + "-" + DateTime.Now.Day;
            string[] returndate1 = dateTimePicker1.Value.ToString().Split(' ');
            string[] returndate2 = returndate1[0].Split('.');
            string realreturndate = returndate2[2] + "-" + returndate2[1] + "-" + returndate2[0];

            string query2 = "insert into rental values("+ rentID.Text +", "+ split[0] +", '"+ split[1] +"', '"+ date +"', '"+ realreturndate +"', "+ userid +") ";

            NpgsqlCommand cmd = new NpgsqlCommand(query2, connect);
            cmd.ExecuteNonQuery();

            MessageBox.Show("Kitap kiralandı.");
            query = @"update books set is_taken = 'true' where b_id = " + split[0];

            cmd = new NpgsqlCommand(query, connect);
            cmd.ExecuteNonQuery();

            connect.Close();
            this.Close();

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string dayform = textBox2.Text;
            int dayformint;
            DateTime date = DateTime.Today;

            string[] bookid = bookSelect.Text.Split('-');

            connect.Open();
            
            string query = @"select b_rent from books where b_id = " + bookid[0];
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, connect);
            DataSet ds = new DataSet();
            
            da.Fill(ds);
            
            string[] user = renteduser.Text.Split(' ');
            int money = Int32.Parse(ds.Tables[0].Rows[0][0].ToString());

            query = @"select d.discount_percent from users u, discounts d where u.user_discount = d.discount_name and u.user_name = '"+ user[0] +"'";
            da = new NpgsqlDataAdapter(query, connect);
            DataSet ds2 = new DataSet();
            
            da.Fill(ds2);
            
            int discount = Int32.Parse(ds2.Tables[0].Rows[0][0].ToString());

            connect.Close();

            if (int.TryParse(dayform, out dayformint))
            {
                if(dayformint > 30)
                {
                    dayformint = 30;
                    textBox2.Text = "30";
                }
                if(dayformint < 1)
                {
                    dayformint = 1;
                    textBox2.Text = "1";
                }

                textBox1.Text = (dayformint * (money - (money * discount)/100)).ToString() + "₺";
                date.AddDays(dayformint);
                DateTime lastday = date.AddDays(dayformint);
                dateTimePicker1.Text = lastday.ToString();
            }
            else
            {
                textBox2.Text = "";
                textBox1.Text = "";
            }
        }

        private void bookSelect_SelectedValueChanged(object sender, EventArgs e)
        {
            if (!bookSelect.Text.Equals("") && !renteduser.Text.Equals(""))
            {
                textBox2.Enabled = true;
            }
            else
            {
                textBox2.Enabled = false;
            }

            string dayform = textBox2.Text;
            int dayformint;

            if (int.TryParse(dayform, out dayformint))
            {
                string[] bookid = bookSelect.Text.Split('-');

                connect.Open();

                string query = @"select b_rent from books where b_id = " + bookid[0];
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, connect);
                DataSet ds = new DataSet();

                da.Fill(ds);

                string[] user = renteduser.Text.Split(' ');
                int money = Int32.Parse(ds.Tables[0].Rows[0][0].ToString());

                query = @"select d.discount_percent from users u, discounts d where u.user_discount = d.discount_name and u.user_name = '" + user[0] + "'";
                da = new NpgsqlDataAdapter(query, connect);
                DataSet ds2 = new DataSet();

                da.Fill(ds2);

                connect.Close();

                int discount = Int32.Parse(ds2.Tables[0].Rows[0][0].ToString());

                textBox1.Text = (dayformint * (money - (money * discount) / 100)).ToString();
            }
        }

        private void renteduser_SelectedValueChanged(object sender, EventArgs e)
        {
            if ((!bookSelect.Text.Equals("")) && (!renteduser.Text.Equals("")))
            {
                textBox2.Enabled = true;
            }
            else
            {
                textBox2.Enabled = false;
            }

            string dayform = textBox2.Text;
            int dayformint;

            if (int.TryParse(dayform, out dayformint))
            {
                string[] bookid = bookSelect.Text.Split('-');

                connect.Open();
                
                string query = @"select b_rent from books where b_id = " + bookid[0];
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, connect);
                DataSet ds = new DataSet();
                
                da.Fill(ds);
                
                string[] user = renteduser.Text.Split(' ');
                int money = Int32.Parse(ds.Tables[0].Rows[0][0].ToString());

                query = @"select d.discount_percent from users u, discounts d where u.user_discount = d.discount_name and u.user_name = '" + user[0] + "'";
                da = new NpgsqlDataAdapter(query, connect);
                DataSet ds2 = new DataSet();
                
                da.Fill(ds2);
                
                connect.Close();
                
                int discount = Int32.Parse(ds2.Tables[0].Rows[0][0].ToString());

                textBox1.Text = (dayformint * (money - (money * discount) / 100)).ToString();
            }
        }
    }
}

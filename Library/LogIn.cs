using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Npgsql;


namespace Library
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string uname = username.Text;
            string pword = password.Text;

            NpgsqlConnection connect = new NpgsqlConnection("server=localHost; port=5432; Database=Library; user ID=postgres; password=1234;");
            string query = @"select * from login where username = '" + uname + "' and password = '"+ pword + "'";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, connect);
            DataSet ds = new DataSet();
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count == 0)
            {
                
                MessageBox.Show("Hatalı giriş bilgileri", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                connect.Close();

                MainMenu f2 = new MainMenu();
                this.Hide();
                f2.ShowDialog();
                this.Close();
                

            }

            

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked == true)
            {
                password.UseSystemPasswordChar = false;
                Console.WriteLine("off");
            }
            else
            {
                password.UseSystemPasswordChar = true;
                Console.WriteLine("on");
            }
        }

        private void password_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                button1_Click(this, new EventArgs());
            }
        }
    }
}
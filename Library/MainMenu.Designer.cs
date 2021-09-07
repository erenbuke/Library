
namespace Library
{
    partial class MainMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.refresh = new System.Windows.Forms.Button();
            this.addbook = new System.Windows.Forms.Button();
            this.deletebook = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.rentPage = new System.Windows.Forms.Button();
            this.booksPage = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.rent = new System.Windows.Forms.Button();
            this.refresh2 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.rentPayment = new System.Windows.Forms.Button();
            this.usersPage = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.deleteUser = new System.Windows.Forms.Button();
            this.addUser = new System.Windows.Forms.Button();
            this.refresh3 = new System.Windows.Forms.Button();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.refresh);
            this.panel1.Controls.Add(this.addbook);
            this.panel1.Controls.Add(this.deletebook);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(0, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 422);
            this.panel1.TabIndex = 0;
            // 
            // refresh
            // 
            this.refresh.Location = new System.Drawing.Point(12, 349);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(75, 23);
            this.refresh.TabIndex = 5;
            this.refresh.Text = "Yenile";
            this.refresh.UseVisualStyleBackColor = true;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // addbook
            // 
            this.addbook.Location = new System.Drawing.Point(647, 378);
            this.addbook.Name = "addbook";
            this.addbook.Size = new System.Drawing.Size(141, 32);
            this.addbook.TabIndex = 4;
            this.addbook.Text = "Kitap Ekle";
            this.addbook.UseVisualStyleBackColor = true;
            this.addbook.Click += new System.EventHandler(this.addbook_Click);
            // 
            // deletebook
            // 
            this.deletebook.Location = new System.Drawing.Point(480, 378);
            this.deletebook.Name = "deletebook";
            this.deletebook.Size = new System.Drawing.Size(141, 32);
            this.deletebook.TabIndex = 1;
            this.deletebook.Text = "Kitap Sil";
            this.deletebook.UseVisualStyleBackColor = true;
            this.deletebook.Click += new System.EventHandler(this.deletebook_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 6);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(776, 337);
            this.dataGridView1.TabIndex = 0;
            // 
            // rentPage
            // 
            this.rentPage.Location = new System.Drawing.Point(208, 0);
            this.rentPage.Name = "rentPage";
            this.rentPage.Size = new System.Drawing.Size(105, 28);
            this.rentPage.TabIndex = 0;
            this.rentPage.Text = "Kitap Kiralama";
            this.rentPage.Click += new System.EventHandler(this.rentPage_Click);
            // 
            // booksPage
            // 
            this.booksPage.Enabled = false;
            this.booksPage.Location = new System.Drawing.Point(0, 0);
            this.booksPage.Name = "booksPage";
            this.booksPage.Size = new System.Drawing.Size(105, 28);
            this.booksPage.TabIndex = 1;
            this.booksPage.Text = "Kitaplar";
            this.booksPage.UseVisualStyleBackColor = true;
            this.booksPage.Click += new System.EventHandler(this.booksPage_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.rent);
            this.panel3.Controls.Add(this.refresh2);
            this.panel3.Controls.Add(this.dataGridView2);
            this.panel3.Controls.Add(this.rentPayment);
            this.panel3.Location = new System.Drawing.Point(0, 28);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(800, 422);
            this.panel3.TabIndex = 2;
            this.panel3.Visible = false;
            // 
            // rent
            // 
            this.rent.Location = new System.Drawing.Point(647, 378);
            this.rent.Name = "rent";
            this.rent.Size = new System.Drawing.Size(141, 32);
            this.rent.TabIndex = 2;
            this.rent.Text = "Kitap Kirala";
            this.rent.UseVisualStyleBackColor = true;
            this.rent.Click += new System.EventHandler(this.rent_Click);
            // 
            // refresh2
            // 
            this.refresh2.Location = new System.Drawing.Point(12, 349);
            this.refresh2.Name = "refresh2";
            this.refresh2.Size = new System.Drawing.Size(75, 23);
            this.refresh2.TabIndex = 1;
            this.refresh2.Text = "Yenile";
            this.refresh2.UseVisualStyleBackColor = true;
            this.refresh2.Click += new System.EventHandler(this.refresh2_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(12, 6);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(776, 337);
            this.dataGridView2.TabIndex = 0;
            // 
            // rentPayment
            // 
            this.rentPayment.Location = new System.Drawing.Point(480, 378);
            this.rentPayment.Name = "rentPayment";
            this.rentPayment.Size = new System.Drawing.Size(141, 32);
            this.rentPayment.TabIndex = 9;
            this.rentPayment.Text = "Kira Sonlandırma";
            this.rentPayment.UseVisualStyleBackColor = true;
            this.rentPayment.Click += new System.EventHandler(this.rentPayment_Click);
            // 
            // usersPage
            // 
            this.usersPage.Location = new System.Drawing.Point(104, 0);
            this.usersPage.Name = "usersPage";
            this.usersPage.Size = new System.Drawing.Size(105, 28);
            this.usersPage.TabIndex = 3;
            this.usersPage.Text = "Kullanıcılar";
            this.usersPage.UseVisualStyleBackColor = true;
            this.usersPage.Click += new System.EventHandler(this.usersPage_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.deleteUser);
            this.panel2.Controls.Add(this.addUser);
            this.panel2.Controls.Add(this.refresh3);
            this.panel2.Controls.Add(this.dataGridView3);
            this.panel2.Location = new System.Drawing.Point(0, 28);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 422);
            this.panel2.TabIndex = 4;
            // 
            // deleteUser
            // 
            this.deleteUser.Location = new System.Drawing.Point(480, 378);
            this.deleteUser.Name = "deleteUser";
            this.deleteUser.Size = new System.Drawing.Size(141, 32);
            this.deleteUser.TabIndex = 8;
            this.deleteUser.Text = "Kullanıcı Sil";
            this.deleteUser.UseVisualStyleBackColor = true;
            this.deleteUser.Click += new System.EventHandler(this.deleteUser_Click);
            // 
            // addUser
            // 
            this.addUser.Location = new System.Drawing.Point(647, 378);
            this.addUser.Name = "addUser";
            this.addUser.Size = new System.Drawing.Size(141, 32);
            this.addUser.TabIndex = 7;
            this.addUser.Text = "Kullanıcı Ekle";
            this.addUser.UseVisualStyleBackColor = true;
            this.addUser.Click += new System.EventHandler(this.addUser_Click);
            // 
            // refresh3
            // 
            this.refresh3.Location = new System.Drawing.Point(12, 349);
            this.refresh3.Name = "refresh3";
            this.refresh3.Size = new System.Drawing.Size(75, 23);
            this.refresh3.TabIndex = 6;
            this.refresh3.Text = "Yenile";
            this.refresh3.UseVisualStyleBackColor = true;
            this.refresh3.Click += new System.EventHandler(this.refresh3_Click);
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(12, 6);
            this.dataGridView3.MultiSelect = false;
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView3.Size = new System.Drawing.Size(776, 337);
            this.dataGridView3.TabIndex = 5;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.booksPage);
            this.Controls.Add(this.usersPage);
            this.Controls.Add(this.rentPage);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Location = new System.Drawing.Point(-1, 0);
            this.Name = "MainMenu";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ana Menü";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button rentPage;
        private System.Windows.Forms.Button booksPage;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button addbook;
        private System.Windows.Forms.Button deletebook;
        private System.Windows.Forms.Button refresh;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button refresh2;
        private System.Windows.Forms.Button rent;
        private System.Windows.Forms.Button usersPage;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button deleteUser;
        private System.Windows.Forms.Button addUser;
        private System.Windows.Forms.Button refresh3;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Button rentPayment;
    }
}
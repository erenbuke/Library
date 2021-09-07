
namespace Library
{
    partial class AddUser
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
            this.userID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.userName = new System.Windows.Forms.MaskedTextBox();
            this.userDiscount = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.userSurname = new System.Windows.Forms.TextBox();
            this.confirmUser = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // userID
            // 
            this.userID.Location = new System.Drawing.Point(12, 30);
            this.userID.Name = "userID";
            this.userID.ReadOnly = true;
            this.userID.Size = new System.Drawing.Size(232, 20);
            this.userID.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kullanıcı Kodu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Kullanıcı Adı";
            // 
            // userName
            // 
            this.userName.Location = new System.Drawing.Point(12, 79);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(232, 20);
            this.userName.TabIndex = 7;
            // 
            // userDiscount
            // 
            this.userDiscount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.userDiscount.Location = new System.Drawing.Point(12, 177);
            this.userDiscount.Name = "userDiscount";
            this.userDiscount.Size = new System.Drawing.Size(172, 21);
            this.userDiscount.Sorted = true;
            this.userDiscount.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Üyelik Türü";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Kullanıcı Soyadı";
            // 
            // userSurname
            // 
            this.userSurname.Location = new System.Drawing.Point(12, 128);
            this.userSurname.Name = "userSurname";
            this.userSurname.Size = new System.Drawing.Size(232, 20);
            this.userSurname.TabIndex = 9;
            // 
            // confirmUser
            // 
            this.confirmUser.Location = new System.Drawing.Point(12, 216);
            this.confirmUser.Name = "confirmUser";
            this.confirmUser.Size = new System.Drawing.Size(232, 23);
            this.confirmUser.TabIndex = 14;
            this.confirmUser.Text = "Kullanıcıyı kaydet";
            this.confirmUser.UseVisualStyleBackColor = true;
            this.confirmUser.Click += new System.EventHandler(this.confirmUser_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(190, 176);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(54, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "yeni tür";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(256, 251);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.confirmUser);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.userSurname);
            this.Controls.Add(this.userDiscount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.userName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.userID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AddUser";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kullanıcı Ekle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox userID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox userName;
        private System.Windows.Forms.ComboBox userDiscount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox userSurname;
        private System.Windows.Forms.Button confirmUser;
        private System.Windows.Forms.Button button1;
    }
}
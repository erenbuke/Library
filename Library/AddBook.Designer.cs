
namespace Library
{
    partial class AddBook
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
            this.bID = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.MaskedTextBox();
            this.section = new System.Windows.Forms.TextBox();
            this.row = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.category = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.newType = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.money = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bID
            // 
            this.bID.Location = new System.Drawing.Point(12, 29);
            this.bID.Name = "bID";
            this.bID.ReadOnly = true;
            this.bID.Size = new System.Drawing.Size(232, 20);
            this.bID.TabIndex = 0;
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(12, 76);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(232, 20);
            this.name.TabIndex = 1;
            // 
            // section
            // 
            this.section.Location = new System.Drawing.Point(12, 171);
            this.section.Name = "section";
            this.section.Size = new System.Drawing.Size(232, 20);
            this.section.TabIndex = 3;
            // 
            // row
            // 
            this.row.Location = new System.Drawing.Point(12, 218);
            this.row.Name = "row";
            this.row.Size = new System.Drawing.Size(232, 20);
            this.row.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Kitap Kodu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Kitap İsmi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Kitap Türü";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Kitabın Bulunduğu Bölüm";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Kitabın Bulunduğu Raf";
            // 
            // category
            // 
            this.category.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.category.Location = new System.Drawing.Point(12, 123);
            this.category.Name = "category";
            this.category.Size = new System.Drawing.Size(156, 21);
            this.category.Sorted = true;
            this.category.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 292);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(232, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Kitabı Kaydet";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // newType
            // 
            this.newType.Location = new System.Drawing.Point(169, 122);
            this.newType.Name = "newType";
            this.newType.Size = new System.Drawing.Size(75, 23);
            this.newType.TabIndex = 12;
            this.newType.Text = "Yeni Tür";
            this.newType.UseVisualStyleBackColor = true;
            this.newType.Click += new System.EventHandler(this.newType_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 245);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Fiyat";
            // 
            // money
            // 
            this.money.Location = new System.Drawing.Point(12, 265);
            this.money.Name = "money";
            this.money.Size = new System.Drawing.Size(232, 20);
            this.money.TabIndex = 5;
            this.money.KeyDown += new System.Windows.Forms.KeyEventHandler(this.row_KeyDown);
            // 
            // AddBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(256, 327);
            this.Controls.Add(this.money);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.newType);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.category);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.row);
            this.Controls.Add(this.section);
            this.Controls.Add(this.name);
            this.Controls.Add(this.bID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AddBook";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kitap Ekle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox bID;
        private System.Windows.Forms.MaskedTextBox name;
        private System.Windows.Forms.TextBox section;
        private System.Windows.Forms.TextBox row;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox category;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button newType;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox money;
    }
}
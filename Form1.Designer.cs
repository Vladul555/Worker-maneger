namespace TDD
{
    partial class sort_time
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
            this.exit = new System.Windows.Forms.Button();
            this.tax_calculation = new System.Windows.Forms.Button();
            this.add_many = new System.Windows.Forms.Button();
            this.add_worker = new System.Windows.Forms.Button();
            this.adresse = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.family_name = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.id = new System.Windows.Forms.TextBox();
            this.pay = new System.Windows.Forms.TextBox();
            this.phone_number = new System.Windows.Forms.TextBox();
            this.sort = new System.Windows.Forms.Button();
            this.lable1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tax_show = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.worker_list = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(695, 473);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(75, 23);
            this.exit.TabIndex = 1;
            this.exit.Text = "יציאה";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // tax_calculation
            // 
            this.tax_calculation.Location = new System.Drawing.Point(255, 461);
            this.tax_calculation.Name = "tax_calculation";
            this.tax_calculation.Size = new System.Drawing.Size(75, 23);
            this.tax_calculation.TabIndex = 2;
            this.tax_calculation.Text = "חישוב מס";
            this.tax_calculation.UseVisualStyleBackColor = true;
            this.tax_calculation.Click += new System.EventHandler(this.tax_calculation_Click);
            // 
            // add_many
            // 
            this.add_many.Location = new System.Drawing.Point(406, 256);
            this.add_many.Name = "add_many";
            this.add_many.Size = new System.Drawing.Size(258, 32);
            this.add_many.TabIndex = 5;
            this.add_many.Text = "הוספת  10,000 עובדים";
            this.add_many.UseVisualStyleBackColor = true;
            this.add_many.Click += new System.EventHandler(this.add_many_Click);
            // 
            // add_worker
            // 
            this.add_worker.Location = new System.Drawing.Point(406, 126);
            this.add_worker.Name = "add_worker";
            this.add_worker.Size = new System.Drawing.Size(154, 23);
            this.add_worker.TabIndex = 6;
            this.add_worker.Text = "הוסף עובד";
            this.add_worker.UseVisualStyleBackColor = true;
            this.add_worker.Click += new System.EventHandler(this.add_worker_Click);
            // 
            // adresse
            // 
            this.adresse.Location = new System.Drawing.Point(406, 48);
            this.adresse.Name = "adresse";
            this.adresse.Size = new System.Drawing.Size(100, 20);
            this.adresse.TabIndex = 7;
            this.adresse.TextChanged += new System.EventHandler(this.addres_TextChanged);
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(564, 126);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(100, 20);
            this.email.TabIndex = 8;
            this.email.TextChanged += new System.EventHandler(this.email_TextChanged);
            // 
            // family_name
            // 
            this.family_name.Location = new System.Drawing.Point(564, 100);
            this.family_name.Name = "family_name";
            this.family_name.Size = new System.Drawing.Size(100, 20);
            this.family_name.TabIndex = 9;
            this.family_name.TextChanged += new System.EventHandler(this.family_name_TextChanged);
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(564, 74);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(100, 20);
            this.name.TabIndex = 10;
            this.name.TextChanged += new System.EventHandler(this.name_TextChanged);
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(564, 48);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(100, 20);
            this.id.TabIndex = 11;
            this.id.TextChanged += new System.EventHandler(this.id_TextChanged);
            // 
            // pay
            // 
            this.pay.Location = new System.Drawing.Point(406, 100);
            this.pay.Name = "pay";
            this.pay.Size = new System.Drawing.Size(100, 20);
            this.pay.TabIndex = 12;
            this.pay.TextChanged += new System.EventHandler(this.pay_TextChanged);
            // 
            // phone_number
            // 
            this.phone_number.Location = new System.Drawing.Point(406, 74);
            this.phone_number.Name = "phone_number";
            this.phone_number.Size = new System.Drawing.Size(100, 20);
            this.phone_number.TabIndex = 13;
            this.phone_number.TextChanged += new System.EventHandler(this.phone_number_TextChanged);
            // 
            // sort
            // 
            this.sort.Location = new System.Drawing.Point(406, 313);
            this.sort.Name = "sort";
            this.sort.Size = new System.Drawing.Size(258, 32);
            this.sort.TabIndex = 15;
            this.sort.Text = "מיון לפי משכורת";
            this.sort.UseVisualStyleBackColor = true;
            this.sort.Click += new System.EventHandler(this.sort_Click);
            // 
            // lable1
            // 
            this.lable1.AutoSize = true;
            this.lable1.Location = new System.Drawing.Point(270, 32);
            this.lable1.Name = "lable1";
            this.lable1.Size = new System.Drawing.Size(23, 13);
            this.lable1.TabIndex = 16;
            this.lable1.Text = "שם";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(169, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "ת\"ז";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "משכורת";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(151, 466);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "מס הכנסה חודשי";
            // 
            // tax_show
            // 
            this.tax_show.AutoSize = true;
            this.tax_show.Location = new System.Drawing.Point(50, 466);
            this.tax_show.Name = "tax_show";
            this.tax_show.Size = new System.Drawing.Size(35, 13);
            this.tax_show.TabIndex = 20;
            this.tax_show.Text = "XXXX";
            this.tax_show.Click += new System.EventHandler(this.tax_show_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(512, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "כתובת";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(512, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "טלפון";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(512, 103);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "משכורת";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(684, 51);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(24, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "ת\"ז";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(684, 74);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 13);
            this.label10.TabIndex = 25;
            this.label10.Text = "שם פרטי";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(684, 100);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 13);
            this.label11.TabIndex = 26;
            this.label11.Text = "שם משפחה";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(684, 131);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 13);
            this.label12.TabIndex = 27;
            this.label12.Text = "אימייל";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(255, 12);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(85, 13);
            this.label13.TabIndex = 28;
            this.label13.Text = "רשימת עובדים:";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // worker_list
            // 
            this.worker_list.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.worker_list.HideSelection = false;
            this.worker_list.Location = new System.Drawing.Point(26, 51);
            this.worker_list.Name = "worker_list";
            this.worker_list.Size = new System.Drawing.Size(304, 404);
            this.worker_list.TabIndex = 0;
            this.worker_list.UseCompatibleStateImageBehavior = false;
            this.worker_list.View = System.Windows.Forms.View.Details;
            this.worker_list.SelectedIndexChanged += new System.EventHandler(this.worker_list_SelectedIndexChanged);
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "משכורת";
            this.columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "ת\"ז";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 100;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "שם";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader6.Width = 100;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(670, 323);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "The sort took";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // sort_time
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 508);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.worker_list);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tax_show);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lable1);
            this.Controls.Add(this.sort);
            this.Controls.Add(this.phone_number);
            this.Controls.Add(this.pay);
            this.Controls.Add(this.id);
            this.Controls.Add(this.name);
            this.Controls.Add(this.family_name);
            this.Controls.Add(this.email);
            this.Controls.Add(this.adresse);
            this.Controls.Add(this.add_worker);
            this.Controls.Add(this.add_many);
            this.Controls.Add(this.tax_calculation);
            this.Controls.Add(this.exit);
            this.Name = "sort_time";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button tax_calculation;
        private System.Windows.Forms.Button add_many;
        private System.Windows.Forms.Button add_worker;
        private System.Windows.Forms.TextBox adresse;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.TextBox family_name;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.TextBox pay;
        private System.Windows.Forms.TextBox phone_number;
        private System.Windows.Forms.Button sort;
        private System.Windows.Forms.Label lable1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label tax_show;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ListView worker_list;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Label label1;
    }
}


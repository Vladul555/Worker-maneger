using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TDD
{
    public partial class sort_time : Form
    {
        List<Worker> worker_arry;
        public sort_time()
        {
            worker_arry = new List<Worker>();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void add_many_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 100; i++)
            {
                Worker worker = new Worker(Worker.Randome_name(), Worker.Random_family_name(), Worker.Random_email(), Worker.Random_adress(), worker_arry.Count + 1, Worker.Random_phone_number(), Worker.Random_pay());
                worker_arry.Add(worker);
                add_to_list(worker);
            }
        }

        private void name_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void worker_list_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void add_worker_Click(object sender, EventArgs e)
        {
            string nm = name.Text;
            string fnm = family_name.Text;
            string em = email.Text;
            string ad = adresse.Text;
            long ide = long.Parse(id.Text);
            string pn = phone_number.Text;
            long py = long.Parse(pay.Text);
            Worker worker = new Worker(nm, fnm, em, ad, ide, pn, py);
            worker_arry.Add(worker);
            add_to_list(worker);
            id.Clear();
            family_name.Clear();
            email.Clear();
            adresse.Clear();
            phone_number.Clear();
            pay.Clear();
            name.Clear();
            

        }
        private void add_to_list(Worker worker)
        {
            ListViewItem item = new ListViewItem(worker.pay.ToString());
            item.SubItems.Add(worker.id.ToString());
            item.SubItems.Add(worker.name.ToString());
            worker_list.Items.Add(item);
        }


        private void sort_Click(object sender, EventArgs e)
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            //Worker.bubbleSort(worker_arry);
            Worker.SortArray(worker_arry,0,worker_arry.Count-1);
            for (int i = 0; i < worker_list.Items.Count; i++)
            {
                
                worker_list.Items[i].Remove();
                i--;

            }
            
            foreach (var worker in worker_arry)
            {
                add_to_list(worker);
            }
            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;
            label1.Text = "The sort took "+elapsedMs.ToString()+" ms";
        }

        private void show_Click(object sender, EventArgs e)
        {

        }

        private void tax_calculation_Click(object sender, EventArgs e)
        {
            int mony = int.Parse(worker_list.SelectedItems[0].Text);
            tax_calculationi(mony);
        }
        public double tax_calculationi(int mony)
        {

            if (mony < 6450)
            {
                tax_show.Text = (mony * 0.1).ToString();
                return (mony * 0.1);
            }
            else if (mony < 9240)
            {
                tax_show.Text = (mony * 0.14).ToString();
                return (mony * 0.14);
            }
            else if (mony < 14840)
            {
                tax_show.Text = (mony * 0.2).ToString();
                return (mony * 0.2);
            }
            else if (mony < 20620)
            {
                tax_show.Text = (mony * 0.31).ToString();
                return (mony * 0.31);
            }
            else if (mony < 42910)
            {
                tax_show.Text = (mony * 0.35).ToString();
                return (mony * 0.35);
            }
            else
                tax_show.Text = (mony * 0.47).ToString();
            return (mony * 0.47);
        }

        private void id_TextChanged(object sender, EventArgs e)
        {

        }

        private void addres_TextChanged(object sender, EventArgs e)
        {

        }

        private void phone_number_TextChanged(object sender, EventArgs e)
        {

        }

        private void family_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void pay_TextChanged(object sender, EventArgs e)
        {

        }

        private void email_TextChanged(object sender, EventArgs e)
        {

        }

        private void tax_show_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}



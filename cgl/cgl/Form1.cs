using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace cgl
{
    public partial class Form1 : Form
    {
        public  int remaning_trial = 5;
        int myvariable = 1;
        string mystring;
        string mystring2 = "sinirli civciv";

        public object Me { get; private set; }

        public Form1()
        {
            InitializeComponent();
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mystring = myvariable.ToString();
            MessageBox.Show(mystring);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form2 frm = new Form2();

            if (textBox1.Text == "19")
            {
                label1.Text = mystring2;
                frm.Show();
            }
            else

            {

                downcount(ref remaning_trial);
                mystring = remaning_trial.ToString();
                label1.Text = "Wrong Pasword ";
                label2.Text = "Remaning Attemt" + mystring;
                attempt_check(remaning_trial);
            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            Form1 frm1 = new Form1();

            frm.Show();
            this.Hide();

        }


        public void attempt_check (int count)
        {
            if (count<0)
            {
                this.Close();
            }
        }

         public  void  downcount (ref int count)
        {
            var temp =count;
            temp = temp - 1;
            count = count - 1;
        
        }   
          


    }
    }


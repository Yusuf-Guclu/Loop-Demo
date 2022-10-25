using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random random = new Random(); // Do not repeat your self

            //for loop
            for (int a = 0; a < 20; a++)
            {
                int random_number = random.Next(0, 101);

                if (random_number > 50)
                {
                    listBox2.Items.Add(random_number);
                }
                else
                {
                    listBox1.Items.Add(random_number);
                }
            }

            int i = 0;
            while (i < 20)
            {
                int random_number = random.Next(0, 101);
                if (random_number > 50)
                {
                    listBox2.Items.Add(random_number);
                }
                else
                {
                    listBox1.Items.Add(random_number);
                }
                i++;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
        }
    }
}

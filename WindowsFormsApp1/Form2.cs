using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        int leftcontrol = 3;
        int integer;
        Form1 form = new Form1();

        List<TextBox> textBoxes = new List<TextBox>();
       
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        public void GetValue(int integer)
        {
            this.integer = integer;
            int left = 0;

            for (int i = 0; i < integer; i++)
            {                       
                for (int j = 0; j < integer; j++)
                {
                    TextBox txt = new TextBox();
                    Controls.Add(txt);
                    txt.Top = leftcontrol * 25;
                    txt.Left = left;
                    txt.Text = this.leftcontrol.ToString();
                    leftcontrol = leftcontrol + 1;

                    textBoxes.Add(txt);
                }

                left = left + 100;
                leftcontrol = 3;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int startPoint = Int32.Parse(textBox1.Text);
            int endPoint = Int32.Parse(textBox2.Text);

            form.UseAlgorithm(textBoxes, integer, startPoint, endPoint);
            this.Hide();
            form.ShowDialog();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            form.Exemplu(1);
            form.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            form.Exemplu(2);
            form.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            form.Exemplu(3);
            form.ShowDialog();
        }
    }
}

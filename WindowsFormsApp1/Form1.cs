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

    public partial class Form1 : Form
    {
        private List<TextBox> textBoxes;
        private int[,] matrix;
        private int integer;
        private int maxFlow;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string value = textBox1.Text;
            integer = Int32.Parse(value);

            this.Hide();

            Form2 form2 = new Form2();
            form2.GetValue(integer);
            form2.ShowDialog();

        }

        public void UseAlgorithm(List<TextBox> textBoxes, int integer, int startPoint, int endPoint)   {
            
            this.textBoxes = textBoxes;
            this.integer = integer;

            CreateMatrix();

            FordFulkerson fordFulkerson = new FordFulkerson();

            maxFlow = fordFulkerson.Run(matrix, startPoint, endPoint, integer);

            label1.Text = "Maximum flow of the graph is " + maxFlow.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void CreateMatrix()
        {
            matrix = new int[integer, integer];

            int i = 0; int j = 0;

            foreach (TextBox textBox in textBoxes)
            {
                if(j == integer)
                {
                    i ++;
                    j = 0;
                }
                matrix[j,i] = Int32.Parse(textBox.Text);
                j++;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();

            form3.ShowDialog();
        }      

        public void Exemplu(int i)
        {
            Exemple exemplu = new Exemple();

            if (i == 1)
            {
                exemplu.Exemplu1();                
            }else  if(i == 2)
                    {
                         exemplu.Exemplu2();
                    }else if(i == 3)
                          {
                exemplu.Exemplu3();
                          }

            FordFulkerson fordFulkerson = new FordFulkerson();
            maxFlow = fordFulkerson.Run(exemplu.graph, exemplu.startPoint, exemplu.endPoint, exemplu.integer);
            label1.Text = "Maximum flow of the graph is " + maxFlow.ToString();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

      
      //  private void button1_Click(object sender, EventArgs e)
      //  {
      //      Generate();
      //  }

    //   private void Form1_Load(object sender, EventArgs e)
      //  {
       //     Generate();
      //  }

     //   private void button2_Click(object sender, EventArgs e)
     //   {
     //       Application.Exit();
      //  }

        void Generate()
        {
            List<string> Quotes = new List<string>();

            Random rand = new Random();

            StreamReader quoteReader = new StreamReader("Quotes.txt");

            string line = "";

            while (!quoteReader.EndOfStream)
            {
                line = quoteReader.ReadLine();
                Quotes.Add(line);
            }

            lblMessage.Text = Quotes[rand.Next(1, Quotes.Count)];

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            Generate();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Generate();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

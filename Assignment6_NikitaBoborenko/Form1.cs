using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment6_NikitaBoborenko
{
    public partial class Form1 : Form
    {
        int current_number;
        public Form1()
        {
            InitializeComponent();
        }


        public int Randomgenerator()
        {
            Random rnd = new Random();
            int random_number = rnd.Next(1, 4);
            return random_number;
        }
        public void New_Game()
        {
            current_number = Randomgenerator();
        }

        private void rock_btn_Click(object sender, EventArgs e)
        {
            if (current_number==1) {
                MessageBox.Show("You won");
            }
            else
            {
                MessageBox.Show("You lose");
            }
            New_Game();
        }

        private void paper_btn_Click(object sender, EventArgs e)
        {
            if (current_number == 2)
            {
                MessageBox.Show("You have won");
            }
            else
            {
                MessageBox.Show("You lose");
            }
            New_Game();
        }

        private void scissors_btn_Click(object sender, EventArgs e)
        {
            if (current_number == 3)
            {
                MessageBox.Show("You have won");
            }
            else
            {
                MessageBox.Show("You have lost");
            }
            New_Game();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            New_Game();
        }
    }
}

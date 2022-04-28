using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalkulator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        string FirstNumber, SecondNumber;
        char WhatToDo = ' ';
        

        private void bplus_Click(object sender, EventArgs e)
        {
            WhatToDo = '+';
            wyswietlacz.Text = "";
        }

        private void bminus_Click(object sender, EventArgs e)
        {
            WhatToDo = '-';
            wyswietlacz.Text = "";
        }

        private void brazy_Click(object sender, EventArgs e)
        {
            WhatToDo = '*';
            wyswietlacz.Text = "";
        }

        private void bdivine_Click(object sender, EventArgs e)
        {
            WhatToDo = '/';
            wyswietlacz.Text = "";
        }

        private void bequal_Click(object sender, EventArgs e)
        {
            switch (WhatToDo)
            {
                
                case ('+'):
                   
                    wyswietlacz.Text = (int.Parse(FirstNumber) + int.Parse(SecondNumber)).ToString();
                    break;
                case ('-'):
                    wyswietlacz.Text = (int.Parse(FirstNumber) - int.Parse(SecondNumber)).ToString();
                    break;
                case ('*'):
                    wyswietlacz.Text = (int.Parse(FirstNumber) * int.Parse(SecondNumber)).ToString();
                    break;
                case ('/'):
                    if (int.Parse(SecondNumber) == 0)
                    {
                        wyswietlacz.Text = "Nie dziel przez zero!";
                    }
                    else
                    {
                        wyswietlacz.Text = (int.Parse(FirstNumber) / int.Parse(SecondNumber)).ToString();
                    }
                    break;

                

            }

            FirstNumber = "";
            SecondNumber = "";
            WhatToDo = ' ';
        }

        private void b1_Click(object sender, EventArgs e)
        {
            Calculation(1);
        }
        private void b2_Click(object sender, EventArgs e)
        {
            Calculation(2);
        }
        private void b3_Click(object sender, EventArgs e)
        {
            Calculation(3);
        }
        private void b4_Click(object sender, EventArgs e)
        {
            Calculation(4);
        }
        private void b5_Click(object sender, EventArgs e)
        {
            Calculation(5);
        }
        private void b6_Click(object sender, EventArgs e)
        {
            Calculation(6);
        }

        private void b7_Click(object sender, EventArgs e)
        {
            Calculation(7);
        }

        private void b8_Click(object sender, EventArgs e)
        {
            Calculation(8);
        }
        private void b9_Click(object sender, EventArgs e)
        {
            Calculation(9);
        }

        private void b0_Click(object sender, EventArgs e)
        {
            Calculation(0);
        }

        private void Calculation(int number)
        {




            if (WhatToDo.Equals(' '))
            {

                FirstNumber += number;
                wyswietlacz.Text = FirstNumber;
            }
            else 
                {
                    SecondNumber += number;
                    wyswietlacz.Text = SecondNumber;
                }

            
        }

      

    }
}

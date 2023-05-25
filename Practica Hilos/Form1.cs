using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading; //biblioteca para manejar hilos

namespace Practica_Hilos
{
    public partial class Form1 : Form
    {
        //variables para los procesos
        int pA = 0, pB = 0, pC, pD = 0;
        //DEFINIR PROCESOS
        Thread proceso1;
        Thread proceso2;
        Thread proceso3;
        Thread proceso4;

        

        private void star_Click(object sender, EventArgs e)
        {
            int meta = this.Width - auto1.Width - 50;
            bool a1 = false, a2 = false, a3 = false, a4 = false, a5= false;
            Random valoresR = new Random();

            while (!a1 && !a2 && !a3 && !a4 && !a5)
            {
                auto1.Left += valoresR.Next(10);
            
            
            }
        }

        private void pause_Click(object sender, EventArgs e)
        {

        }
        
        private void reset_Click(object sender, EventArgs e)
        {

        }

        


        public Form1()
        {
            InitializeComponent();
        }
    }
}

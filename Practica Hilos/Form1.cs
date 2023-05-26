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
    public partial class CandyRush : Form
    {
        //variables para los procesos
        int pA = 0, pB = 0, pC=0, pD = 0;
        int meta = 500;
        bool a1 = false, a2 = false, a3 = false, a4 = false;
        
        //DEFINIR PROCESOS
        Thread proceso1;
        Thread proceso2;
        Thread proceso3;
        Thread proceso4;

        //variable random
        Random valoresAle = new Random();

        private void Form1_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;

            proceso1 = new Thread(new ThreadStart(valorA1));
            proceso2 = new Thread(new ThreadStart(valorA2));
            proceso3 = new Thread(new ThreadStart(valorA3));
            proceso4 = new Thread(new ThreadStart(valorA4));
        }

        //valor 1
        public void valorA1()
        {
            while (true)
            {

                Thread.Sleep(valoresAle.Next(500));
                pA++;
                auto1.Location = new Point(auto1.Location.X + pA, auto1.Location.Y);

                if (auto1.Location.X + pA >= meta && !a2 && !a3 && !a4)
                {
                    
                    MessageBox.Show("Ganador corredor 1");
                }

            }
        }

        //valor 2
        public void valorA2()
        {
            while(true)
            {
                Thread.Sleep(valoresAle.Next(500));
                pB++;
                auto2.Location = new Point(auto2.Location.X+pB, auto2.Location.Y);
                if (auto2.Location.X + pB >= meta && !a1 && !a3 && !a4) 
                {
                    btonPause();
                    MessageBox.Show("Ganador corredor 2");
                }
            }


        }

        //valor3
        public void valorA3()
        {
            while(true)
            {
                Thread.Sleep(valoresAle.Next(500));
                pC++;
                auto3.Location = new Point(auto3.Location.X+pC, auto3.Location.Y);

                if (auto3.Location.X + pC >= meta && !a1 && !a2 && !a4)
                {
                    btonPause();
                    MessageBox.Show("Ganador corredor 3");
                }
            }
        }

        //valor 4
        public void valorA4()
        {
            while(true)
            {
                Thread.Sleep(valoresAle.Next(500));
                pD++;
                auto4.Location = new Point(auto4.Location.X+pD, auto4.Location.Y);

                if (auto4.Location.X + pD >= meta && !a1 && !a2 && !a3)
                {
                    btonPause();
                    MessageBox.Show("Ganador corredor 4");
                }
            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        //boton de iniciar
        private void star_Click(object sender, EventArgs e)
        {       
                proceso1.Start();
                proceso2.Start();
                proceso3.Start();
                proceso4.Start();
            
        }

        public void btonPause()
        {
            proceso1.Suspend();
            proceso2.Suspend();
            proceso3.Suspend();
            proceso4.Suspend();

        }

        //PAUSA
        private void pause_Click(object sender, EventArgs e)
        {
            btonPause();
        }
        
        //REAUNDAR
        private void reset_Click(object sender, EventArgs e)
        {
            proceso1.Resume();
            proceso2.Resume();
            proceso3.Resume();
            proceso4.Resume();
        }

        //SALIR
        private void exit_Click(object sender, EventArgs e)
        {
            proceso1.Abort();
            proceso2.Abort();
            proceso3.Abort();
            proceso4.Abort();
        }


        public CandyRush()
        {
            InitializeComponent();
        }
    }
}

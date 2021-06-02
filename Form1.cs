using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace projekat1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            // prva ploca
            e.Graphics.FillRectangle(Brushes.Black, 100, 500, 600, 20);
            // prve merdevine
            e.Graphics.FillRectangle(Brushes.SandyBrown, 660, 350, 10, 150); // drugi stap
            e.Graphics.FillRectangle(Brushes.SandyBrown, 600, 350, 10, 150); // prvi stap

            e.Graphics.FillRectangle(Brushes.SandyBrown, 610, 370, 50, 6); // prva sipka
            e.Graphics.FillRectangle(Brushes.SandyBrown, 610, 420, 50, 6); // druga sipka
            e.Graphics.FillRectangle(Brushes.SandyBrown, 610, 470, 50, 6); // treca sipka
            // druga ploca
            e.Graphics.FillRectangle(Brushes.Black, 400, 330, 600, 20);
            // druge merdevine
            e.Graphics.FillRectangle(Brushes.SandyBrown, 450, 230, 10, 100); // prvi stap
            e.Graphics.FillRectangle(Brushes.SandyBrown, 510, 230, 10, 100); // drugi stap

            e.Graphics.FillRectangle(Brushes.SandyBrown, 460, 250, 50, 6); //prva sipka
            e.Graphics.FillRectangle(Brushes.SandyBrown, 460, 300, 50, 6); //druga sipka
            // treca ploca
            e.Graphics.FillRectangle(Brushes.Black, 50, 210, 600, 20);
            // trece merdevine
            e.Graphics.FillRectangle(Brushes.SandyBrown, 200, 230, 10, 270); // prvi stap
            e.Graphics.FillRectangle(Brushes.SandyBrown, 260, 230, 10, 270); // drugi stap

            int x = 0;
            for (int i = 0; i < 6; i++)
            {
                e.Graphics.FillRectangle(Brushes.SandyBrown, 210, 240 + x, 50, 6); // sipke
                x += 50;
            }
            x = 0;

            // cetvrta ploca 
            e.Graphics.FillRectangle(Brushes.Black, 50, 750, 950, 20);
            // natpis START
            e.Graphics.FillRectangle(Brushes.Green, 100, 680, 15, 70); //daska
            Pen p = new Pen(Color.Black, 5);
            g.DrawRectangle(p, 60, 630, 90, 50);// daska sa natpisom
            // cetvrte merdevine
            e.Graphics.FillRectangle(Brushes.SandyBrown, 380, 520, 10, 230); // prvi stap
            e.Graphics.FillRectangle(Brushes.SandyBrown, 440, 520, 10, 230); // drugi stap
            for (int i = 0; i < 4; i++)
            {
                e.Graphics.FillRectangle(Brushes.SandyBrown, 390, 560 + x, 50, 6); // sipke
                x += 50;
            }

            //pete merdevine
            e.Graphics.FillRectangle(Brushes.SandyBrown, 840, 180, 10, 150); // prvi stap
            e.Graphics.FillRectangle(Brushes.SandyBrown, 900, 180, 10, 150);// drugi stap
            
            e.Graphics.FillRectangle(Brushes.SandyBrown, 850, 220, 50, 6); // sipke
            e.Graphics.FillRectangle(Brushes.SandyBrown, 850, 270, 50, 6);

            // peta ploca
            e.Graphics.FillRectangle(Brushes.Black, 800, 170, 400, 20);

            g.DrawRectangle(p, 1060  , 48, 90, 50);// daska sa natpisom
            e.Graphics.FillRectangle(Brushes.Green, 1100, 100, 15, 70); // drska
        }

        int pomeraj1 = 0;
        int pomeraj2 = 0; 
        private void timer1_Tick(object sender, EventArgs e)
        {
            btn_object.Left += pomeraj1;
            btn_object.Top += pomeraj2;
           
        }

        private void btn_pokret_Click(object sender, EventArgs e)
        {
            timer1.Enabled = !timer1.Enabled;
        }

        private void btn_levo_Click(object sender, EventArgs e)
        {
            pomeraj1 = -30;
            pomeraj2 = 0;
        }

        private void btn_desno_Click(object sender, EventArgs e)
        {
            pomeraj1 = 30;
            pomeraj2 = 0;
        }

        private void btn_gore_Click(object sender, EventArgs e)
        {
            pomeraj2 = -10;
            pomeraj1 = 0;
        }

        private void btn_dole_Click(object sender, EventArgs e)
        {
            pomeraj2 = 10;
            pomeraj1 = 0;
        }
    }
}

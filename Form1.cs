using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projekat2._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

           
        }
        int brojacX = 0;
        int brojacO = 0;
        char[,] m = new char[3, 3];

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }
        
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen olovka = new Pen(Color.Black, 6);
            // tabla za iks - oks
            e.Graphics.FillRectangle(Brushes.Black, 400, 100, 8, 600);  //stap vertikalno
            e.Graphics.FillRectangle(Brushes.Black, 600, 100, 8, 600);  // stap vertikalno
            e.Graphics.FillRectangle(Brushes.Black, 200, 300, 600, 8);  //stap horizontalno
            e.Graphics.FillRectangle(Brushes.Black, 200, 500, 600, 8);  //stap horizontalno

            
            for(int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    if(m[i, j] == 'x')
                    {  
                        g.DrawLine(olovka, 210 + (j * 208), 110 + (i * 208), 390 + (j * 208), 290 + (i * 208));
                        g.DrawLine(olovka, 390 + (j * 208), 110 + (i * 208), 210 + (j * 208), 290 + (i * 208));
                        Validate(); 
                    }
                    else if(m[i, j] == 'o')
                    { 
                        g.DrawEllipse(new Pen(Color.Black, 6), new Rectangle(210 + (j * 208), 110 + (i * 208), 180, 180));
                        Validate();
                    }
                }
            }
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.X > 199 &&  e.X < 401 && e.Y < 301 && e.Y > 99)
            {
                if(brojacX == brojacO)
                {
                    m[0, 0] = 'x';
                    brojacX++;
                }
                else if(brojacX > brojacO)
                {
                    m[0, 0] = 'o';
                    brojacO++;  
                }
                Invalidate();
            }
            else if(e.X > 408 && e.X < 609 && e.Y > 99 && e.Y < 301)
            {
                if (brojacX == brojacO)
                {
                    m[0, 1] = 'x';
                    brojacX++;
                }
                else if (brojacX > brojacO)
                {
                    m[0, 1] = 'o';
                    brojacO++;
                }
                Invalidate();
            }
            else if(e.X > 616 && e.X < 817 && e.Y > 99 && e.Y < 301)
            {
                if (brojacX == brojacO)
                {
                    m[0, 2] = 'x';
                    brojacX++;
                }
                else if (brojacX > brojacO)
                {
                    m[0, 2] = 'o';
                    brojacO++;
                }
                Invalidate();
            }
            else if(e.X > 199 && e.X < 401 && e.Y > 308 && e.Y < 510)
            {
                if (brojacX == brojacO)
                {
                    m[1, 0] = 'x';
                    brojacX++;
                }
                else if (brojacX > brojacO)
                {
                    m[1, 0] = 'o';
                    brojacO++;
                }
                Invalidate();
            }
            else if(e.X > 408 && e.X < 609 && e.Y > 308 && e.Y < 510)
            {
                if (brojacX == brojacO)
                {
                    m[1, 1] = 'x';
                    brojacX++;
                }
                else if (brojacX > brojacO)
                {
                    m[1, 1] = 'o';
                    brojacO++;
                }
                Invalidate();
            }
            else if(e.X > 616 && e.X < 817 && e.Y > 308 && e.Y < 510)
            {
                if (brojacX == brojacO)
                {
                    m[1, 2] = 'x';
                    brojacX++;
                }
                else if (brojacX > brojacO)
                {
                    m[1, 2] = 'o';
                    brojacO++;
                }
                Invalidate();
            }
            else if(e.X > 199 && e.X < 401 && e.Y > 518 && e.Y < 717)
            {
                if (brojacX == brojacO)
                {
                    m[2, 0] = 'x';
                    brojacX++;
                }
                else if (brojacX > brojacO)
                {
                    m[2, 0] = 'o';
                    brojacO++;
                }
                Invalidate();
            }
            else if(e.X > 408 && e.X < 609 && e.Y > 518 && e.Y < 717)
            {
                if (brojacX == brojacO)
                {
                    m[2, 1] = 'x';
                    brojacX++;
                }
                else if (brojacX > brojacO)
                {
                    m[2, 1] = 'o';
                    brojacO++;
                }
                Invalidate();
            }
            else if(e.X > 616 && e.X < 817 && e.Y > 518 && e.Y < 717)
            {
                if (brojacX == brojacO)
                {
                    m[2, 2] = 'x';
                    brojacX++;
                }
                else if (brojacX > brojacO)
                {
                    m[2, 2] = 'o';
                    brojacO++;
                }
                Invalidate();
            }


            if (m[0, 0] == m[0, 1] && m[0, 1] == m[0, 2])
            {
                if (m[0, 1] == 'x') MessageBox.Show("IGRAC X JE POBEDIO");
                else if (m[0, 1] == 'o') MessageBox.Show("IGRAC O-ks JE POBEDIO");
            }
            else if (m[1, 0] == m[1, 1] && m[1, 1] == m[1, 2])
            {
                if (m[1, 1] == 'x') MessageBox.Show("IGRAC X JE POBEDIO");
                else if (m[1, 1] == 'o') MessageBox.Show("IGRAC O-ks JE POBEDIO");
            }
            else if (m[2, 0] == m[2, 1] && m[2, 1] == m[2, 2])
            {
                if (m[2, 1] == 'x') MessageBox.Show("IGRAC X JE POBEDIO");
                else if (m[2, 1] == 'o') MessageBox.Show("IGRAC O-ks JE POBEDIO");
            }
            else if (m[0, 0] == m[1, 0] && m[1, 0] == m[2, 0])
            {
                if (m[1, 0] == 'x') MessageBox.Show("IGRAC X JE POBEDIO");
                else if (m[0, 0] == 'o') MessageBox.Show("IGRAC O-ks JE POBEDIO");
            }
            else if (m[0, 1] == m[1, 1] && m[1, 1] == m[2, 1])
            {
                if (m[1, 1] == 'x') MessageBox.Show("IGRAC X JE POBEDIO");
                else if (m[1, 1] == 'o') MessageBox.Show("IGRAC O-ks JE POBEDIO");
            }
            else if (m[0, 2] == m[1, 2] && m[1, 2] == m[2, 2])
            {
                if (m[0, 2] == 'x') MessageBox.Show("IGRAC X JE POBEDIO");
                else if (m[0, 2] == 'o') MessageBox.Show("IGRAC O-ks JE POBEDIO");
            }
            else if (m[0, 0] == m[1, 1] && m[1, 1] == m[2, 2])
            {
                if (m[0, 0] == 'x') MessageBox.Show("IGRAC X JE POBEDIO");
                else if (m[0, 0] == 'o') MessageBox.Show("IGRAC O-ks JE POBEDIO");
            }
            else if (m[0, 2] == m[1, 1] && m[1, 1] == m[0, 0])
            {
                if (m[0, 2] == 'x') MessageBox.Show("IGRAC X JE POBEDIO");
                else if (m[0, 2] == 'o') MessageBox.Show("IGRAC O-ks JE POBEDIO");
            }
        }
    }
}

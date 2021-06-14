using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projekat4._3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        char[,] m = new char[6, 7];
        int[] BrojacRedova = new int[7];
        int BrojacCrvena = 0;
        int BrojacZuta = 0;
        bool crta = false;
        bool crtanjecrte = false;
        int brojacC = 0;
        int brojacZ = 0;
        int j;
        int x1;
        int y1;
        int x2;
        int y2;
        int k;

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "Crveni igrac";
            for (int i = 0; i < 7; i++)
            {
                BrojacRedova[i] = 0;
            }
            if (BrojacCrvena == BrojacZuta)
            {
                label1.Text = "Crveni igrac";
            }
            else if (BrojacCrvena > BrojacZuta)
            {
                label1.Text = "Zuti igrac";
            }
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            int x = 0;
            int y = 0;
            Graphics g = e.Graphics;
            Pen olovka = new Pen(Color.Black, 15);

            //tabla za igru
            g.FillRectangle(Brushes.DarkBlue, 70, 90, 945, 690);
            // beli krugovi
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    if (m[i, j] == 'r')
                    {
                        g.FillEllipse(new SolidBrush(Color.Red), new Rectangle(80 + x, 100 + y, 100, 100));
                    }
                    else if (m[i, j] == 'y')
                    {
                        g.FillEllipse(new SolidBrush(Color.Yellow), new Rectangle(80 + x, 100 + y, 100, 100));
                    }
                    else
                    {
                        g.FillEllipse(new SolidBrush(Color.White), new Rectangle(80 + x, 100 + y, 100, 100));
                    }
                    x += 135;
                }
                x = 0;
                y += 111;
            }
            if(crta == true)
            g.DrawLine(olovka, x1, y1, x2, y2);

            crtanjecrte = true;
        }
         
        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.X > 70 && e.X < 206 && e.Y >= 0 && e.Y < 781)
            {
                j = 0;
                Igraci(j);
            }
            else if (e.X > 205 && e.X < 342 && e.Y >= 0 && e.Y < 781)
            {
                j = 1;
                Igraci(j);
            }
            else if (e.X > 341 && e.X < 478 && e.Y >= 0 && e.Y < 781)
            {
                j = 2;
                Igraci(j);
            }
            else if (e.X > 477 && e.X < 614 && e.Y >= 0 && e.Y < 781)
            {
                j = 3;
                Igraci(j);
            }
            else if (e.X > 613 && e.X < 749 && e.Y >= 0 && e.Y < 781)
            {
                j = 4;
                Igraci(j);
            }
            else if (e.X > 748 && e.X < 885 && e.Y >= 0 && e.Y < 781)
            {
                j = 5;
                Igraci(j);
            }
            else if (e.X > 884 && e.Y < 1021 && e.Y >= 0 && e.Y < 781)
            {
                j = 6;
                Igraci(j);
            }
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    if (m[i, j] != '\0' && j < 4 && m[i, j] == m[i, j + 1] && m[i, j + 1] == m[i, j + 2] && m[i, j + 2] == m[i, j + 3]) //desno
                    {
                        k = 1;
                        Kordinate(i, j);
                        if (crtanjecrte == true)
                            Pobednik(i, j);
                    }
                    else if (m[i, j] != '\0' && j > 2 && m[i, j] == m[i, j - 1] && m[i, j - 1] == m[i, j - 2] && m[i, j - 2] == m[i, j - 3]) //levo
                    {
                        k = 2;
                        Kordinate(i, j);
                        if (crtanjecrte == true)
                            Pobednik(i, j);
                    }
                    else if (m[i, j] != '\0' && i > 2 && m[i, j] == m[i - 1, j] && m[i - 1, j] == m[i - 2, j] && m[i - 2, j] == m[i - 3, j]) //gore
                    {
                        k = 3;
                        Kordinate(i, j);
                        if (crtanjecrte == true)
                          Pobednik(i, j);  
                    }
                    else if (m[i, j] != '\0' && i < 3 && m[i, j] == m[i + 1, j] && m[i + 1, j] == m[i + 2, j] && m[i + 2, j] == m[i + 3, j]) //dole
                    {
                        k = 4;
                        Kordinate(i, j);
                        if (crtanjecrte == true)
                            Pobednik(i, j);
                    }
                    else if (m[i, j] != '\0' && j < 4 && i > 2 && m[i, j] == m[i - 1, j + 1] && m[i - 1, j + 1] == m[i - 2, j + 2] && m[i - 2, j + 2] == m[i - 3, j + 3]) //gore desno
                    {
                        k = 5;
                        Kordinate(i, j);
                        if (crtanjecrte == true)
                            Pobednik(i, j);
                    }
                    else if (m[i, j] != '\0' && i < 3 && j > 2 && m[i, j] == m[i + 1, j - 1] && m[i + 1, j - 1] == m[i + 2, j - 2] && m[i + 2, j - 2] == m[i + 3, j - 3]) //dole levo
                    {
                        k = 6;
                        Kordinate(i, j);
                        if (crtanjecrte == true)
                            Pobednik(i, j);
                    }
                    else if (m[i, j] != '\0' && i > 2 && j > 2 && m[i, j] == m[i - 1, j - 1] && m[i - 1, j - 1] == m[i - 2, j - 2] && m[i - 2, j - 2] == m[i - 3, j - 3]) // gore levo
                    {
                        k = 7;
                        Kordinate(i, j);
                        if (crtanjecrte == true)
                            Pobednik(i, j);
                    }
                    else if (m[i, j] != '\0' && i < 3 && j < 4 && m[i, j] == m[i + 1, j + 1] && m[i + 1, j + 1] == m[i + 2, j + 2] && m[i + 2, j + 2] == m[i + 3, j + 3]) //dole desno
                    {
                        k = 8;
                        Kordinate(i, j);
                        if (crtanjecrte == true)
                            Pobednik(i, j);
                    }
                }
            }
        }
        private void Kordinate(int i, int j)
        {
            crta = true;
            x1 = 130 + (j * 135);
            y1 = 150 + (i * 111);
            if(k == 1)
            {
                x2 = 130 + ((j + 3) * 135);
                y2 = 150 + (i * 111);
            }
            else if(k == 2)
            {
                x2 = 130 + ((j - 3) * 135);
                y2 = 150 + (i * 111);
            }
            else if(k == 3)
            {
                x2 = 130 + (j * 135);
                y2 = 150 + ((i - 3) * 111);
            }
            else if(k == 4)
            {
                x2 = 130 + (j * 135);
                y2 = 150 + ((i + 3) * 111);
            }
            else if(k == 5)
            {
                x2 = 130 + ((j + 3) * 135);
                y2 = 150 + ((i - 3) * 111);
            }
            else if(k == 6)
            {
                x2 = 130 + ((j - 3) * 135);
                y2 = 150 + ((i + 3) * 111);
            }
            else if(k == 7)
            {
                x2 = 130 + ((j - 3) * 135);
                y2 = 150 + ((i - 3) * 111);
            }
            else if(k == 8)
            {
                x2 = 130 + ((j + 3) * 135);
                y2 = 150 + ((i + 3) * 111);
            }
            
            if (crtanjecrte == true)
                Pobednik(i, j);
        }
        private void Pobednik(int i, int j)
        {
            if (m[i, j] == 'r')
            {
                brojacC++;
                if (brojacC == 1) DispleyMessage("Crveni igrac je pobedio");
            }
            else if (m[i, j] == 'y')
            {
                brojacZ++;
                if (brojacZ == 1) DispleyMessage("Zuti igrac je pobedio");
            }
        }
        private void Igraci(int j)
        {
            if (BrojacCrvena == BrojacZuta)
            {
                label1.Text = "Crveni igrac";
                m[5 - BrojacRedova[j], j] = 'r';
                BrojacCrvena++;
            }
            else if (BrojacCrvena > BrojacZuta)
            {
                label1.Text = "Zuti igrac";
                m[5 - BrojacRedova[j], j] = 'y';
                BrojacZuta++;
            }

            BrojacRedova[j]++;
            Invalidate();
        }
        private void DispleyMessage(string poruka)
        {
            DialogResult dialog = MessageBox.Show(poruka, "", MessageBoxButtons.OK);
            if (dialog == DialogResult.OK)
            {
                m = new char[6, 7];
                BrojacRedova = new int[7];
                BrojacCrvena = 0;
                BrojacZuta = 0;
                brojacC = 0;
                brojacZ = 0;
                x1 = 0;
                x2 = 0;
                y1 = 0;
                y2 = 0;
                Invalidate();
            }

        }
    }
}
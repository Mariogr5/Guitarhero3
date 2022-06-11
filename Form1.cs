using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guitarhero3
{
    public partial class Form1 : Form
    {
        int speed = 2;
        int score = 0;
        bool press = false;
        bool colour = true;
        Stack<PictureBox> obj = new Stack<PictureBox>();
        int ilosc = 0;

        public Form1()
        {
            InitializeComponent();
            Newgame();
        }


        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void czasruchu(object sender, EventArgs e)
        {
            //foreach (PictureBox picturebox in obj)
            if (obj.Peek() != null)
            {
                foreach (Control x in this.Controls)
                {
                    if (x is PictureBox)
                    {
                        
                        x.Top += speed;
                        if (x.Top > 400)
                        {
                            x.Top = Rand();
                        }
                    }
                }
            }
        }
        private void KeyisDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Z)
            {
                colorchange();               
                colour = true;
                foreach (Control x in this.Controls)
                {
                    if(x is PictureBox)
                    if (x.Top > 300)
                    {
                        score++;
                        wynik.Text = "Score: " + score;
                        if (Progres.Value != 100)
                            Progres.Value += 10;
                        else
                        {
                            Progres.Value = 0;
                            Gen(obj);
                                speed++;
                        }
                        x.Top = Rand();
                        
                    }
                }
            }
        }

        private void wynik_Click(object sender, EventArgs e)
        {
        }
        private void Newgame()
        {
            ilosc = 0;
            obj.Clear();
            obj.Push(Kwadrat);
            Gen(obj);
        }


        private void Kliker_KeyUp(object sender, KeyEventArgs e)
        {
            Kliker.BringToFront();
            if (e.KeyCode == Keys.Z )
            {
                colorchange();
            }
        }
        private void colorchange()
        {
            if (colour == true)
            {
                Kliker.BackColor = Color.Yellow;
                colour = false;
            }
            else
            {
                Kliker.BackColor = Color.Green;
                colour = true;
            }
        }
        private void Gen(Stack<PictureBox> obj)
        {
            PictureBox c = obj.Peek();
            var newobject = new PictureBox()
            {
                Name = "Kwadrat" + ilosc.ToString(),
                Tag = "note",
                Parent = Kwadrat,
                Size = Kwadrat.Size,
                Image = Kwadrat.Image,
                //BackColor = Color.Red,
                SizeMode = PictureBoxSizeMode.StretchImage,
                Location = Kwadrat.Location,
            };
            newobject.Top = c.Top + Rand() + c.Width;
            obj.Push(newobject);
            Controls.Add(newobject);
            newobject.BringToFront();
            ilosc++;
        }
        private int Rand()
        {
            Random rnd = new Random();
            return rnd.Next(-300 + 10*ilosc, -100 + 10*ilosc);

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Kwadrat2_Click(object sender, EventArgs e)
        {

        }
    }
}

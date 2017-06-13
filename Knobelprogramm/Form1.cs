using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Knobelprogramm
{
    
    public partial class Form1 : Form
    {
        public int nUpDownRingeValue = 3;
        public int panelHeight = 0;
        public int panelWidth = 0;
        bool initialized = true;
        List<Panel> ringe = new List<Panel>();
        List<Panel> leftStack = new List<Panel>();
        List<Panel> middleStack = new List<Panel>();
        List<Panel> rightStack = new List<Panel>();
        List<String> ausgabe = new List<String>();
        List<Button> btnGet = new List<Button>();
        List<Button> btnSet = new List<Button>();
        Panel cache;

        public Form1()
        {
            InitializeComponent();
            startProgramm();
        }

        public void startProgramm()
        {
            nUpDownRinge.Value = nUpDownRingeValue;
            panelHeight = pnlAroundLeft.Height;
            panelWidth = pnlAroundLeft.Width;
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public Panel takeRing(Button btn)
        {
            Panel re = new Panel();

            switch (btn.Name[6])
            {
                case 'L': re = changeTakeBelong(leftStack); removeTake(leftStack); break;
                case 'M': re = changeTakeBelong(middleStack); removeTake(middleStack); break;
                case 'R': re = changeTakeBelong(rightStack); removeTake(rightStack); break;
                default: break;
            }

            return re;
        }

        public Panel changeTakeBelong(List<Panel> aktuell)
        {
            Panel r = new Panel();

            if (aktuell.Count != 0)
            {
                r = aktuell[aktuell.Count - 1];
            }

            return r;
        }

        public void removeTake(List<Panel> aktuell)
        {
            aktuell.RemoveAt(aktuell.Count - 1);
        }

        public Panel setRing(Button btn)
        {
            Panel re = new Panel();

            if (cache.Size != 0)
            {
                
            }
        }

        public void takeButtonAction(object sender, EventArgs e)
        {
            if (initialized == false)
            {
                Button btn = new Button();

                if (sender is Button)
                {
                    btn = sender as Button;
                    cache = takeRing(btn);
                }
            }
        }

       

        public void setButtonAction(object sender, EventArgs e)
        {
            if (initialized == false)
            {
                if (sender is Button)
                {

                }
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (initialized)
            {
                entferneRinge(ringe);
                ringe = generiereRinge(nUpDownRingeValue);
                zeichneRinge(ringe);
                File.WriteAllLines("C:/Users/vmadmin/Desktop/ausgabe.txt", ausgabe);
                initialized = false;
                leftStack = ringe;
            }
        }

        public void entferneRinge(List<Panel> ring)
        {
            foreach(Panel p in ring)
            {
                pnlAroundLeft.Controls.Remove(p);
            }
            
        }

        private List<Panel> generiereRinge(int anzahl)
        {
            List<Panel> r = new List<Panel>();

            int xPos = 0;
            int yPos = 0;
            int widthTotal = panelWidth;
            int heightTotal = panelHeight;

            int widthSpezific = spezific(anzahl,panelWidth,panelHeight)[1];
            int heightSpezific = spezific(anzahl, panelWidth, panelHeight)[0];
            int insertWidth = widthTotal;

            widthTotal = panelWidth;
            heightTotal = panelHeight;

            yPos = panelHeight - heightSpezific;
            xPos = 0;

            for(int i = 0; i < anzahl; i++)
            {
                string temp = xPos + "-" + yPos + "-" + (widthTotal - (widthSpezific * i)) + "-" + heightSpezific;

                ausgabe.Add(temp);
              //  MessageBox.Show(widthSpezific.ToString() + " "+widthTotal.ToString());
                r.Add(generiereRing(xPos, yPos, insertWidth, heightSpezific));

                insertWidth -= (2 * widthSpezific);
                xPos += widthSpezific;
                yPos -= heightSpezific;
            }

            return r;
        }

        public int[] spezific(int zahl, int width,int height)
        {
            int[] r = new int[2];

            r[0] = (height/2) / zahl;
            r[1] = (width/2)/ zahl;

            return r;
        }

        public Panel generiereRing(int x, int y,int w, int h)
        {
            Panel r = new Panel();

            r.BackColor = Color.Navy;
            r.BorderStyle = BorderStyle.FixedSingle;
            r.Location = new System.Drawing.Point(x, y);
            r.Name = "pnlAroundLeft";
            r.Size = new System.Drawing.Size(w, h);
            r.TabIndex = 8;
  
            return r;
        }


        private void zeichneRinge(List<Panel> p)
        {
            foreach (Panel panel in p)
            {
                pnlAroundLeft.Controls.Add(panel);
            }
        }

        private void nUpDownRinge_ValueChanged(object sender, EventArgs e)
        {
            nUpDownRingeValue = Convert.ToInt32(nUpDownRinge.Value);
        }

        private void btnSetLeft_Click(object sender, EventArgs e)
        {

        }
    }
}

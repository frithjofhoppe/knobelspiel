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
    //Change
    public partial class Form1 : Form
    {
        public int nUpDownRingeValue = 3;
        public int panelHeight = 0;
        public int panelWidth = 0;
        List<Panel> ringe = new List<Panel>();
        List<String> ausgabe = new List<String>();

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

        private void btnStart_Click(object sender, EventArgs e)
        {
           ringe =  generiereRinge(nUpDownRingeValue);
           zeichneRinge(ringe);
            File.WriteAllLines("C:/Users/vmadmin/Desktop/ausgabe.txt.txt", ausgabe);
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

            widthTotal = panelWidth;
            heightTotal = panelHeight;

            yPos = panelHeight - heightSpezific;
            xPos = heightSpezific;

            for(int i = 0; i < anzahl; i++)
            {
                string temp = xPos + "-" + yPos + "-" + (widthTotal - (widthSpezific * i)) + "-" + heightSpezific;

                ausgabe.Add(temp);

                r.Add(generiereRing(xPos, yPos, (widthTotal - (widthSpezific * i)), heightSpezific));

                xPos += widthSpezific;
                yPos -= heightSpezific;
            }

            return r;
        }

        public int[] 
            spezific(int zahl, int width,int height)
        {
            int[] r = new int[2];

            r[0] = (height/2) % zahl;
            r[1] = (width/2)% zahl;

            return r;
        }

        public Panel generiereRing(int x, int y,int w, int h)
        {
            Panel r = new Panel();

            r.BackColor = System.Drawing.SystemColors.ButtonFace;

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
    }
}

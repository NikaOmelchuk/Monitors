using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using MonitorLib;

namespace Monitors
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

        private void button1_Click(object sender, EventArgs e)
        {
            Builder b = new BuilderMonitorWithCam();
            MonitorWithCam m = new MonitorWithCam();
            Director d = new Director();

            label1.Text = d.build(b);

            label2.Text = m.Nazva;
            pictureBox1.Tag = m.cod;
            pictureBox1.BackgroundImage = imageList1.Images[m.cod - 1];

            mc = new MonitorClone(pictureBox1,d.build(b), m.Nazva);
            button4.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Builder b = new BuilderMonitor3D();
            Monitor3D m = new Monitor3D();
            Director d = new Director();

            label1.Text = d.build(b);

            label2.Text = m.Nazva;
            pictureBox1.Tag = m.cod;
            pictureBox1.BackgroundImage = imageList1.Images[m.cod-1];

            mc = new MonitorClone(pictureBox1, d.build(b), m.Nazva);
            button4.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Builder b = new BuilderSensorMonitor();
            SensorMonitor m = new SensorMonitor();
            Director d = new Director();

            label1.Text = d.build(b);

            label2.Text = m.Nazva;
            pictureBox1.Tag = m.cod;
            pictureBox1.BackgroundImage = imageList1.Images[m.cod - 1];

            mc = new MonitorClone(pictureBox1, d.build(b), m.Nazva);
            button4.Enabled = true;
        }

        MonitorClone mc;
        List<MonitorClone> listC = new List<MonitorClone>();
        int i = 1;

        private void button4_Click(object sender, EventArgs e)
        {
            MonitorClone clone = (MonitorClone)mc.Clone();
            listC.Add(clone);
            label4.Text = clone.Nazva;
            label3.Text = clone.str;

            Random r = new Random();

            PictureBox Po = new PictureBox();
            Po.Click += new EventHandler(p1_Click);
            Po.Tag = i;
            Po.Size = clone.p.Size / 2;
            Po.BackgroundImage = clone.p.BackgroundImage;
            Po.BackgroundImageLayout = clone.p.BackgroundImageLayout;
            Po.Name = "p" + i;
            Po.Location = new Point(r.Next(0, 650), r.Next(0, 380));

            panel2.Controls.Add(Po);

            i++;
        }
        object sourse;
        private void p1_Click(object sender, EventArgs e)
        {
            if(sourse!=null)
                ((PictureBox)sourse).Image = null;

            ((PictureBox)sender).Image = pictureBox1.Image;
            ((PictureBox)sender).SizeMode = pictureBox1.SizeMode;
            sourse = sender;

            for (int l = 0; l < listC.Count; l++)
            {
                if(((PictureBox)sender).Tag.ToString() == (l+1).ToString())
                {
                    label4.Text = listC[l].Nazva;
                    label3.Text = listC[l].str;
                }
            }
            
        }
    }
}

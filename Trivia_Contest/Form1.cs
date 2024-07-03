using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trivia_Contest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            buttona.Enabled = false;
            buttonb.Enabled = false;
            buttonc.Enabled = false;
            buttond.Enabled = false;
            buttonnext.Enabled = true;

            

            label5.Text = buttonc.Text;
            if (label4.Text == label5.Text)
            {
                cno++;
                labelcorrect.Text = cno.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                wno++;
                labelwrong.Text = wno.ToString();
                pictureBox2.Visible = true;
            }
            
        }
        int qno = 0, cno = 0, wno = 0;

        private void buttona_Click(object sender, EventArgs e)
        {
            buttona.Enabled = false;
            buttonb.Enabled = false;
            buttonc.Enabled = false;
            buttond.Enabled = false;
            buttonnext.Enabled = true;

            

            label5.Text = buttona.Text;
            if(label4.Text == label5.Text)
            {
                cno++;
                labelcorrect.Text = cno.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                wno++;
                labelwrong.Text = wno.ToString();
                pictureBox2.Visible = true;
            }
           
        }

        private void buttonb_Click(object sender, EventArgs e)
        {
            buttona.Enabled = false;
            buttonb.Enabled = false;
            buttonc.Enabled = false;
            buttond.Enabled = false;
            buttonnext.Enabled = true;

            

            label5.Text = buttonb.Text;
            if (label4.Text == label5.Text)
            {
                cno++;
                labelcorrect.Text = cno.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                wno++;
                labelwrong.Text = wno.ToString();
                pictureBox2.Visible = true;
            }
            
        }

        private void buttond_Click(object sender, EventArgs e)
        {
            buttona.Enabled = false;
            buttonb.Enabled = false;
            buttonc.Enabled = false;
            buttond.Enabled = false;
            buttonnext.Enabled = true;

            

            label5.Text = buttond.Text;
            if (label4.Text == label5.Text)
            {
                cno++;
                labelcorrect.Text = cno.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                wno++;
                labelwrong.Text = wno.ToString();
                pictureBox2.Visible = true;
            }
            
        }

        private void labelcorrect_Click(object sender, EventArgs e)
        {

        }

        private void buttonnext_Click(object sender, EventArgs e)
        {
            buttona.Enabled = true;
            buttonb.Enabled = true;
            buttonc.Enabled = true;
            buttond.Enabled = true;
            buttonnext.Enabled = false;

            pictureBox1.Visible = false;
            pictureBox2.Visible = false;

            qno ++;
            labelqno.Text = qno.ToString();

            if (qno == 1) {
                richTextBox1.Text = "Türkiye'nin başkenti neresidir ?";
               
                buttona.Text= "Ankara";
                buttonb.Text = "Konya";
                buttonc.Text = "Konya";
                buttond.Text = "Bursa";
            
                label4.Text = "Ankara";
                
                
            }
            if (qno == 2)
            {
                richTextBox1.Text = "Mevlana Nerededir ?";

                buttona.Text = "Van";
                buttonb.Text = "Bitlis";
                buttonc.Text = "Malatya";
                buttond.Text = "Konya";
           
                label4.Text = "Konya";
                buttonnext.Text = "Sonucu Gör";
            }
            if (qno == 3){
                
                buttona.Enabled = false;
                buttonb.Enabled = false;
                buttonc.Enabled = false;
                buttond.Enabled = false;
                buttonnext.Enabled = false;
                MessageBox.Show("Doğru :"+ cno + " Yanlış : " + wno);

            }
        }
    }
}

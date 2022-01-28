using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kinoteatr_bilet
{
    public partial class Afisha : Form
    {

        PictureBox image1;
        PictureBox image2;
        PictureBox image3;
        public Afisha()
        {

            this.ClientSize = new System.Drawing.Size(720, 500);

            image1 = new PictureBox();//создали PictureBox
            image1.Size = new Size(220, 400);
            image1.Location = new Point(500, 20);
            image1.SizeMode = PictureBoxSizeMode.StretchImage;
            image1.ImageLocation = (@"..\..\image\joker2.jpg");
            image1.Click += kartinka1_Click;
            
            image2 = new PictureBox();//создали PictureBox
            image2.Size = new Size(220, 400);
            image2.Location = new Point(250, 20);
            image2.SizeMode = PictureBoxSizeMode.StretchImage;
            image2.ImageLocation = (@"..\..\image\grinch2.jpg");
            image2.Click += kartinka2_Click;
            
            image3 = new PictureBox();//создали PictureBox
            image3.Size = new Size(220, 400);
            image3.Location = new Point(1, 20);
            image3.SizeMode = PictureBoxSizeMode.StretchImage;
            image3.ImageLocation = (@"..\..\image\spnowayhome.jpg");
            image3.Click += kartinka3_Click;


            this.BackColor = Color.DeepSkyBlue;
            this.Controls.Add(image1);
            this.Controls.Add(image2);
            this.Controls.Add(image3);

        }

        private void kartinka1_Click(object sender, EventArgs e)
        {
            Zal_form uus_aken = new Zal_form();//запускает пустую форму
            uus_aken.StartPosition = FormStartPosition.CenterScreen;
            uus_aken.Show();
            string avatar = "Joker";
            using (StreamWriter srb = new StreamWriter(@"..\..\zapisfilma\Film.txt", true))
            {
                srb.WriteLine(avatar);
            }
            this.Hide();

        }

        private void kartinka2_Click(object sender, EventArgs e)
        {
            Zal_form uus_aken = new Zal_form();//запускает пустую форму
            uus_aken.StartPosition = FormStartPosition.CenterScreen;
            uus_aken.Show();
            string mc = "Grinch";
            using (StreamWriter srb = new StreamWriter(@"..\..\zapisfilma\Film.txt", true))
            {
                srb.WriteLine(mc);
            }
            this.Hide();
        }

        private void kartinka3_Click(object sender, EventArgs e)
        {
            Zal_form uus_aken = new Zal_form();//запускает пустую форму
            uus_aken.StartPosition = FormStartPosition.CenterScreen;
            uus_aken.Show();
            string dz = "Spider Man:No Way Home";
            using (StreamWriter srb = new StreamWriter(@"..\..\zapisfilma\Film.txt", true))
            {
                srb.WriteLine(dz);
            }
            this.Hide();
        }

        private void InitializeComponent(object sender, EventArgs e)
        {
            this.SuspendLayout();
            // 
            // Afisha
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Name = "Afisha";
            this.Load += new System.EventHandler(this.Afisha_Load_1);
            this.ResumeLayout(false);

        }

        private void Afisha_Load(object sender, EventArgs e)
        {

        }

        private void Afisha_Load_1(object sender, EventArgs e)
        {

        }
    }
}

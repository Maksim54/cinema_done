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
    class Menu : System.Windows.Forms.Form
    {
        PictureBox afisha;

        public PictureBox picture;

        public Menu()
        {
            Button Kinozal_btn = new Button
            {
                Font = new Font("Lato", 12, FontStyle.Regular),
                Text = "Buy ticket",
                Location = new System.Drawing.Point(470, 130),//Point(x,y)
                Height = 50,
                Width = 120,
                BackColor = Color.Fuchsia
            };
            Kinozal_btn.Click += Kinozal_btn_Click;


            afisha = new PictureBox();//создали PictureBox
            afisha.Size = new Size(450, 405);
            afisha.Location = new Point(1, 55);
            afisha.SizeMode = PictureBoxSizeMode.StretchImage;
            afisha.ImageLocation = (@"..\..\image\Travolta_Cinema.gif");
            afisha.DoubleClick += Afisha_DoubleClick;

            Button Listat_btn = new Button
            {
                Font = new Font("Lato", 12, FontStyle.Regular),
                Text = "❯",
                Location = new System.Drawing.Point(690, 270),//Point(x,y)
                Height = 30,
                Width = 60,
                BackColor = Color.Fuchsia
            };

            Button Listat_btn2 = new Button
            {
                Font = new Font("Lato", 12, FontStyle.Regular),
                Text = "❮",
                Location = new System.Drawing.Point(480, 270),//Point(x,y)
                Height = 30,
                Width = 60,
                BackColor = Color.Fuchsia
            };


            Button Info_btn = new Button
            {
                Font = new Font("Lato", 12, FontStyle.Regular),
                Text = "Info",
                Location = new System.Drawing.Point(645, 130),//Point(x,y)
                Height = 50,
                Width = 120,
                BackColor = Color.Fuchsia
            };
            Info_btn.Click += Info_btn_Click;

            Button Pravil_btn = new Button
            {
                Font = new Font("Lato", 12, FontStyle.Regular),
                Text = "Rules",
                Location = new System.Drawing.Point(555, 200),//Point(x,y)
                Height = 50,
                Width = 120,
                BackColor = Color.Fuchsia
            };
            Pravil_btn.Click += Pravil_btn_Click;


            Label lbl = new Label
            {
                ForeColor = Color.Teal,
                BackColor = Color.Transparent,
                Text = "Cinamon Kosmos",
                Size = new System.Drawing.Size(190, 82),
                Location = new System.Drawing.Point(520, 22),
                Font = new Font("Gwendolyn", 25, FontStyle.Italic),
            };

            picture = new PictureBox()
            {
                Size = new Size(214, 95),
                Location = new Point(508, 15),
                ImageLocation = ("../../image/neonborder.gif"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };


            this.Controls.Add(Kinozal_btn);
            this.Controls.Add(Info_btn);
            this.Controls.Add(Pravil_btn);
            this.Controls.Add(lbl);
            this.Controls.Add(picture);


            Image myimage = new Bitmap(@"..\..\image\cinamon.jpg");
            this.BackgroundImage = myimage;
            this.Width = 800;
            this.Height = 800;

            Listat_btn.Click += Listat_btn_Click;
            Listat_btn2.Click += Listat_btn2_Click;
            this.Controls.Add(Listat_btn);
            this.Controls.Add(Listat_btn2);
            this.Controls.Add(afisha);
            this.Controls.Add(Kinozal_btn);
            this.Height = 500;//свойство высота формы
            this.Width = 800;
        }

        private PictureBox pictureBox1;
        int scetcikafi = 0;
        private void Listat_btn_Click(object sender, EventArgs e)
        {
            scetcikafi++; //тут я увеличиваю значения счетчика на 1
            if (scetcikafi == 1)
            {

                afisha.ImageLocation = (@"..\..\image\grinch_hall.png");

            }
            else if (scetcikafi == 2)
            {

                afisha.ImageLocation = (@"..\..\image\joker_hall.png");
            }
            else if (scetcikafi == 3)
            {
                afisha.ImageLocation = (@"..\..\image\sm_hall.png");
            }
            else if (scetcikafi == 4)
            {

                scetcikafi = 0; //сбрасывает счетччик, что бы начать все заново
                afisha.ImageLocation = (@"..\..\image\Travolta_Cinema.gif");
            }
        }

        private void Listat_btn2_Click(object sender, EventArgs e)
        {
            scetcikafi++;
            if (scetcikafi == 1)
            {

                afisha.ImageLocation = (@"..\..\image\grinch_hall.png");

            }
            else if (scetcikafi == 2)
            {

                afisha.ImageLocation = (@"..\..\image\joker_hall.png");
            }
            else if (scetcikafi == 3)
            {
                afisha.ImageLocation = (@"..\..\image\sm_hall.png");
            }
            else if (scetcikafi == 4)
            {
                scetcikafi = 0; //сбрасывает счетчик, что бы начать все заново
                afisha.ImageLocation = (@"..\..\image\Travolta_Cinema.gif");
            }
        }

        private void Pravil_btn_Click(object sender, EventArgs e)
        {
            var info = File.ReadAllText(@"..\..\texte\Pravila_zal.txt");
            var information = MessageBox.Show(info, "Info");
        }

        private void Info_btn_Click(object sender, EventArgs e)
        {
            var info = File.ReadAllText(@"..\..\texte\Info_text_zal.txt");
            var information = MessageBox.Show(info, "Info");
        }
        public static void Count(object obj)
        {
            int x = (int)obj;
            for (int i = 1; i < 9; i++, x++)
            {
                Console.WriteLine($"{x * i}");
            }
        }

        private void Kinozal_btn_Click(object sender, EventArgs e)
        {
            Afisha uus_aken = new Afisha();//запускает пустую форму
            uus_aken.StartPosition = FormStartPosition.CenterScreen;
            uus_aken.Show();
            this.Hide();
        }

        private void Afisha_DoubleClick(object sender, EventArgs e)
        {
        }

        private void InitializeComponent(object sender, EventArgs e)
        {
            this.SuspendLayout();
            // 
            // Menu
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Name = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.ResumeLayout(false);

        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }
    }
}
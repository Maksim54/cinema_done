using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kinoteatr_bilet
{
    public partial class Zal_form : Form
    {
        public Zal_form()
        {
            this.ClientSize = new System.Drawing.Size(400, 300);

            Button mal_btn = new Button
            {
                Font = new Font("Lato", 12, FontStyle.Regular),
                Text = "Small hall",
                Location = new System.Drawing.Point(130, 100),//Point(x,y)
                Height = 50,
                Width = 150,
                BackColor = Color.Fuchsia
            };
            mal_btn.Click += Mal_btn_Click;

            Button sred_btn = new Button
            {
                Font = new Font("Lato", 12, FontStyle.Regular),
                Text = "Medium hall",
                Location = new System.Drawing.Point(130, 170),//Point(x,y)
                Height = 50,
                Width = 150,
                BackColor = Color.Fuchsia
            };
            sred_btn.Click += Sred_btn_Click;

            Button bol_btn = new Button
            {
                Font = new Font("Lato", 12, FontStyle.Regular),
                Text = "Huge hall",
                Location = new System.Drawing.Point(130, 240),//Point(x,y)
                Height = 50,
                Width = 150,
                BackColor = Color.Fuchsia
            };
            bol_btn.Click += Bol_btn_Click;

            Label lbl_zal = new Label
            {
                Text = "Choose hall you want",
                Size = new System.Drawing.Size(180, 50),
                Location = new System.Drawing.Point(135, 25),
                Font = new Font("Oswald", 16, FontStyle.Bold)
            };

            this.Controls.Add(lbl_zal);
            this.Controls.Add(mal_btn);
            this.Controls.Add(sred_btn);
            this.Controls.Add(bol_btn);
            this.BackColor = Color.DeepSkyBlue;
        }

        private void Bol_btn_Click(object sender, EventArgs e)
        {
            Zal_vaata uus_aken = new Zal_vaata(9, 9);//запускает пустую форму
            uus_aken.StartPosition = FormStartPosition.CenterScreen;
            uus_aken.ShowDialog();
        }

        private void Sred_btn_Click(object sender, EventArgs e)
        {
            Zal_vaata uus_aken = new Zal_vaata(7, 7);//запускает пустую форму
            uus_aken.StartPosition = FormStartPosition.CenterScreen;
            uus_aken.ShowDialog();
        }

        private void Mal_btn_Click(object sender, EventArgs e)
        {
            Zal_vaata uus_aken = new Zal_vaata(5, 5);//запускает пустую форму
            uus_aken.StartPosition = FormStartPosition.CenterScreen;
            uus_aken.ShowDialog();
        }


        private void MyFotm_Click(object sender, EventArgs e)
        {

        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // Zal_form
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Name = "Zal_form";
            this.Load += new System.EventHandler(this.Zal_form_Load);
            this.ResumeLayout(false);

        }

        private void Zal_form_Load(object sender, EventArgs e)
        {

        }
    }
}

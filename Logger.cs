using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QSOLogger
{
    public partial class Logger : Form
    {
        public Logger()
        {
            InitializeComponent();
            Init();
        }

        // Init

        void Init()
        {
            vrijeme.Text = DateTime.UtcNow.ToString("HH:mm");
            oznaka.Clear();
            Mode_RST();
            lokator.Clear();
        }

        void Mode_RST()
        {
            if (mod.Text == "CW")
            {
                s_rst.Text = "599";
                r_rst.Text = "599";
            }
            else
            {
                s_rst.Text = "59";
                r_rst.Text = "59";
            }
        }

        // Composing

        string Compositor()
        {
            return " " +
                vrijeme.Text + " | " +
                band.Text + " | " +
                mod.Text + " | " +
                frekvencija.Text + " | " +
                oznaka.Text + " | " +
                s_rst.Text + " | " +
                r_rst.Text + " | " +
                lokator.Text;
        }

        bool Check()
        {
            bool prazan = false;

            if (band.Text == "")
            {
                band.BackColor = Color.FromArgb(255, 205, 205);
                prazan = true;
            }
            else
            {
                band.BackColor = Color.Empty;
            }

            if (mod.Text == "")
            {
                mod.BackColor = Color.FromArgb(255, 205, 205);
                prazan = true;
            }
            else
            {
                mod.BackColor = Color.Empty;
            }

            if (oznaka.Text == "")
            {
                oznaka.BackColor = Color.FromArgb(255, 205, 205);
                prazan = true;
            }
            else
            {
                oznaka.BackColor = Color.Empty;
            }

            int check;
            if (!int.TryParse(s_rst.Text, out check))
            {
                s_rst.BackColor = Color.FromArgb(255, 205, 205);
                prazan = true;
            }
            else
            {
                s_rst.BackColor = Color.Empty;
            }

            if (!int.TryParse(r_rst.Text, out check))
            {
                r_rst.BackColor = Color.FromArgb(255, 205, 205);
                prazan = true;
            }
            else
            {
                r_rst.BackColor = Color.Empty;
            }

            if (prazan)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void Unesi_vezu(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;

                if (Check())
                {
                    oznaka.BackColor = Color.Empty;

                    veze_log.Items.Add(Compositor());

                    Init();

                    oznaka.Focus();
                }
            }
        }


        // VS Handlers

        private void timer1_Tick(object sender, EventArgs e)
        {
            vrijeme.Text = DateTime.UtcNow.ToString("HH:mm");
        }

        private void mod_TextUpdate(object sender, EventArgs e)
        {
            Mode_RST();
        }
    }
}

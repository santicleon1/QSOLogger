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
            bool valja = true;
            var error_Boja = Color.FromArgb(255, 205, 205);

            Control[] input = new Control[] {band, mod, oznaka};
            foreach (var item in input)
            {
                if (string.IsNullOrWhiteSpace(item.Text))
                {
                    item.BackColor = error_Boja;
                    valja = false;
                }

                else
                {
                    item.BackColor = Color.Empty;
                }
            }

            input = new Control[] { s_rst, r_rst };
            foreach (var item in input)
            {
                if (!int.TryParse(item.Text, out _))
                {
                    item.BackColor = error_Boja;
                    valja = false;
                }
                else
                {
                    item.BackColor = Color.Empty;
                }
            }

            return valja;
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

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

        int redni_broj_veze = 1;


        void Init()
        {
            broj_veze.Text = redni_broj_veze.ToString("000");
            vrijeme.Text = DateTime.Now.ToString("HH:mm");
            oznaka.Clear();
            s_rst.Text = "59";
            r_rst.Text = "59";
            lokator.Clear();
        }

        string Compressor()
        {
            return " " + broj_veze.Text + " | " +
                vrijeme.Text + " | " +
                oznaka.Text + " | " +
                s_rst.Text + " | " +
                r_rst.Text + " | " +
                lokator.Text;
        }

        private void Unesi_vezu(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;

                if (oznaka.Text != "")
                {
                    oznaka.BackColor = Color.Empty;

                    veze_log.Items.Add(Compressor());

                    redni_broj_veze++;

                    Init();

                    oznaka.Focus();
                }

                else
                    oznaka.BackColor = Color.FromArgb(255, 205, 205);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            vrijeme.Text = DateTime.Now.ToString("HH:mm");
        }
    }
}

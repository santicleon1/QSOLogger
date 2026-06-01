using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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

            ArrayList data = stanica.Read_Data();

            oznaka_stanice.Text = (string)data[0];
            lokator_stanice.Text = (string)data[1];
            oznaka_operatora.Text = (string)data[2];
        }

        // Init

        readonly Station stanica = new Station();


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

        string Raw_Log()
        {
            LogEntry logEntry = new LogEntry
            {
                band = band.Text,
                mod = mod.Text,
                frekvencija = frekvencija.Text,
                oznaka = oznaka.Text,
                s_rst = s_rst.Text,
                r_rst = r_rst.Text,
                lokator = lokator.Text
            };

            logEntry.Save_Log();

            return logEntry.Raw_String();
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

        void Freq_Band_Update()
        {
            if (frekvencija.Text.Length > 0)
            {
                if (frekvencija.Text.Contains(','))
                {
                    frekvencija.Text = frekvencija.Text.Replace(',', '.');
                }

                if (double.TryParse(frekvencija.Text, out double f))
                {
                    if (f >= 1.8 && f <= 2.0)
                    {
                        band.Text = "160m";
                    }
                    else if (f >= 3.5 && f <= 3.8)
                    {
                        band.Text = "80m";
                    }
                    else if (f >= 7.0 && f <= 7.2)
                    {
                        band.Text = "40m";
                    }
                    else if (f >= 10.1 && f <= 10.15)
                    {
                        band.Text = "30m";
                    }
                    else if (f >= 14.0 && f <= 14.35)
                    {
                        band.Text = "20m";
                    }
                    else if (f >= 18.068 && f <= 18.168)
                    {
                        band.Text = "17m";
                    }
                    else if (f >= 21.0 && f <= 21.45)
                    {
                        band.Text = "15m";
                    }
                    else if (f >= 24.89 && f <= 24.99)
                    {
                        band.Text = "12m";
                    }
                    else if (f >= 28.0 && f <= 29.7)
                    {
                        band.Text = "10m";
                    }
                    else
                    {
                        band.Text = "";
                    }
                }
            }
        }

        private void Unesi_vezu(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;

                if (Check())
                {
                    veze_log.Items.Add(Raw_Log());

                    Init();

                    oznaka.Focus();
                }
            }
        }

        private void Otvori_Log_Folder()
        {
            if (!Directory.Exists("LOG"))
            {
                Directory.CreateDirectory("LOG");
            }

            Process.Start(new ProcessStartInfo
            {
                FileName = "explorer.exe",
                Arguments = Directory.GetCurrentDirectory() + "\\LOG\\",
                UseShellExecute = true
            });
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

        private void frekvencija_TextChanged(object sender, EventArgs e)
        {
            Freq_Band_Update();
        }

        private void logToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Otvori_Log_Folder();
        }

        private void stanicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            stanica.ShowDialog();

            ArrayList data = stanica.Read_Data();

            oznaka_stanice.Text = (string)data[0];
            lokator_stanice.Text = (string)data[1];
            oznaka_operatora.Text = (string)data[2];
        }
    }
}

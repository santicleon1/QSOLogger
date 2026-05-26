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
using System.Collections;

namespace QSOLogger
{
    public partial class Station : Form
    {
        public Station()
        {
            InitializeComponent();
            Load_Data();
        }

        private void Load_Data()
        {
            if (File.Exists("Station_Info.dat"))
            {
                ArrayList data = new ArrayList();

                using (StreamReader sr = new StreamReader("Station_Info.dat"))
                {
                    data.Add(sr.ReadLine());
                }

                oznaka_stanice.Text = (string)data[0];
                lokator_stanice.Text = (string)data[1];
                oznaka_operatora.Text = (string)data[2];
            }
        }

        private void Save_Data()
        {
            string info =
                oznaka_stanice.Text + "\n" +
                lokator_stanice.Text + "\n" +
                oznaka_operatora.Text + "\n";

            using (StreamWriter sw = new StreamWriter("Station_Info.dat"))
            {
                sw.WriteLine(info);
            }
        }

        private void spremi_Click(object sender, EventArgs e)
        {
            Save_Data();
        }
    }
}

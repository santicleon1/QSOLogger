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
            ControlBox = false;
        }

        public void Load_Data()
        {
            if (File.Exists("Station_Info.dat"))
            {
                ArrayList data = Read_Data();

                oznaka_stanice.Text = (string)data[0];
                lokator_stanice.Text = (string)data[1];
                oznaka_operatora.Text = (string)data[2];
            }

            else
            {
                ShowDialog();
            }       
        }

        public ArrayList Read_Data()
        {
            ArrayList data = new ArrayList();

            using (StreamReader sr = new StreamReader("Station_Info.dat"))
            {
                while (!sr.EndOfStream)
                {
                    data.Add(sr.ReadLine());
                }
            }

            return data;
        }

        private bool Save_Data()
        {
            ArrayList info = new ArrayList() { oznaka_stanice.Text, lokator_stanice.Text, oznaka_operatora.Text };

            foreach (var item in info)
            {
                if ((string)item == "")
                {
                    MessageBox.Show("Invalid data!");
                    return false;
                }
            }

            using (StreamWriter sw = new StreamWriter("Station_Info.dat"))
            {
                foreach (var item in info)
                {
                    sw.WriteLine(item);
                }
            }

            return true;
        }

        private void spremi_Click(object sender, EventArgs e)
        {
            if (Save_Data())
            {
                Load_Data();
                Close();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace QSOLogger
{
    internal class LogEntry
    {
        public string vrijeme;
        public string band;
        public string mod;
        public string frekvencija;
        public string oznaka;
        public string s_rst;
        public string r_rst;
        public string lokator;

        public string Raw_String()
        {
            return " " +
                vrijeme + " | " +
                band + " | " +
                mod + " | " +
                frekvencija + " | " +
                oznaka + " | " +
                s_rst + " | " +
                r_rst + " | " +
                lokator;
        }

        public string ADIF_Parse()
        {
            var datum = DateTime.UtcNow.ToString("yyyyMMdd");

            string parse = "<QSO_DATE:" + datum.Length + ">" + datum + " " +
                "<TIME_ON:" + vrijeme.Length + ">" + vrijeme + " " +
                "<BAND:" + band.Length + ">" + band + " " +
                "<MODE:" + mod.Length + ">" + mod + " " +
                "<FREQ:" + frekvencija.Length + ">" + frekvencija + " " +
                "<CALL:" + oznaka.Length + ">" + oznaka + " " +
                "<RST_SENT:" + s_rst.Length + ">" + s_rst + " " +
                "<RST_RCVD:" + r_rst.Length + ">" + r_rst + " " +
                "<GRID_SQUARE:" + lokator.Length + ">" + lokator +
                "<EOR>";

            return parse;
        }

        public void Save_Log()
        {
            string filename = "LOG_" + DateTime.UtcNow.ToString("yyyy_MM_dd") + ".adi";
            string path = "LOG\\" + filename;

            if (!Directory.Exists("LOG"))
            {
                Directory.CreateDirectory("LOG");
            }

            if (!File.Exists(path))
            {
                using (StreamWriter writer = new StreamWriter(path))
                {
                    string header = "<ADIF_VER:5>3.1.5\n" +
                        "<PROGRAMID:9>QSOLogger\n" +
                        "<EOH>";

                    writer.Write(header + "\n");
                }
            }

            using (StreamWriter writer = new StreamWriter(path, true))
            {
                writer.Write(ADIF_Parse() + "\n");
            }
        }
    }
}

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
                DateTime.UtcNow.ToString("HH:mm") + " | " +
                band + " | " +
                mod + " | " +
                frekvencija + " | " +
                oznaka + " | " +
                s_rst + " | " +
                r_rst + " | " +
                lokator;
        }

        public string ADIF_Header()
        {
            return
                "ADIF from QSOLogger by santicleon1" + 
                "<ADIF_VER:5>3.1.7\n" +
                "<CREATED_TIMESTAMP:15>" + DateTime.UtcNow.ToString("yyyyMMdd HHmmss") + "\n" +
                "<PROGRAMID:9>QSOLogger\n" +
                "<PROGRAMVERSION:1>1\n" +
                "<EOH>";
        }

        public string ADIF_Parse()
        {
            var datum = DateTime.UtcNow.ToString("yyyyMMdd");
            var vrijeme = DateTime.UtcNow.ToString("HHmmss");

            string parse =
                "<QSO_DATE:" + datum.Length + ">" + datum + " " +
                "<TIME_ON:" + vrijeme.Length + ">" + vrijeme + " ";

            if (lokator != "")
                parse += "<GRIDSQUARE:" + lokator.Length + ">" + lokator + " ";

            if (frekvencija != "")
                parse += "<FREQ:" + frekvencija.Length + ">" + frekvencija + " ";

                parse +=
                "<BAND:" + band.Length + ">" + band + " " +
                "<MODE:" + mod.Length + ">" + mod + " " +
                "<CALL:" + oznaka.Length + ">" + oznaka + " " +
                "<RST_SENT:" + s_rst.Length + ">" + s_rst + " " +
                "<RST_RCVD:" + r_rst.Length + ">" + r_rst + " " +
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
                    writer.WriteLine(ADIF_Header());
                }
            }

            using (StreamWriter writer = new StreamWriter(path, true))
            {
                writer.WriteLine(ADIF_Parse());
            }
        }
    }
}

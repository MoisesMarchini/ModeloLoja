using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ModeloLoja.Config
{
    static class MainConfig
    {
        public static Size LoginFormSize = new Size(346, 259);
        public static Size DefaultLayoutSize = new Size(514, 450);

        public static string serverIp;
        public static string serverUser;
        public static string serverPass;
        public static string serverName;
        public static string resourcesPath => Application.StartupPath + @"\Resources\";
        //public static string configPath => @"D:\Protótipos\ModeloLoja\ModeloLoja\Config\MainConfig.txt";
        public static string configPath => Application.StartupPath + @"\Config\MainConfig.txt";

        public static void SetDefaultSize(Form form, Size size)
        {
            form.MaximumSize = size;
            form.MinimumSize = size;
            form.Size = size;
        }

        public static void ImportData()
        {
            StreamReader reader = new StreamReader(configPath);

            string Emptytxt = "";
            Emptytxt = reader.ReadLine();
            serverIp = reader.ReadLine();
            Emptytxt = reader.ReadLine();
            Emptytxt = reader.ReadLine();
            serverUser = reader.ReadLine();
            Emptytxt = reader.ReadLine();
            Emptytxt = reader.ReadLine();
            serverPass = reader.ReadLine();
            Emptytxt = reader.ReadLine();
            Emptytxt = reader.ReadLine();
            serverName = reader.ReadLine();
            reader.Close();
            if (serverIp == "")
            {
                MessageBox.Show(@"Insira suas configurações de servidor no arquivo '\Config\MainConfig.txt' e abra o aplicativo novamente.\nO aplicativo será fechado.");
                Application.Exit();
            }
        }
    }
}

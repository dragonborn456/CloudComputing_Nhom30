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

namespace Ubuntuconnect
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }




        private void Form1_Load(object sender, EventArgs e)
        {

        }


        public string ExecuteCommandSync(object commmand)
        {
            try
            {
                System.Diagnostics.ProcessStartInfo processStartInfo =
                    new System.Diagnostics.ProcessStartInfo("cmd", "/c" + commmand);
                processStartInfo.RedirectStandardOutput = true;
                processStartInfo.UseShellExecute = false;
                processStartInfo.CreateNoWindow = true;
                System.Diagnostics.Process proc =
                   new System.Diagnostics.Process();
                proc.StartInfo = processStartInfo;
                proc.Start();
                string result = proc.StandardOutput.ReadToEnd();
                return result;

            }
            catch (Exception objException)
            {
                return "";
            }

        }

        private void BtnCmd_Click(object sender, EventArgs e)
        {
            string commmand = "docker build -t onlinecompiler C:/Users/Admin/demo";
            ExecuteCommandSync(commmand);
            string commmand1 = "docker run -p 4000:80 --name phong onlinecompiler";
            ExecuteCommandSync(commmand1);
            btnCmd.BackColor = Color.Blue;
        }


    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using MaterialSkin;
using MaterialSkin.Controls;

namespace BlenderConsoleRender
{
    public partial class Form1 : MaterialForm
    {
        MaterialSkinManager materialSkinManager;
        //string filename;
        string mainConsoleCmd;
        string workingDirectory;
        string renderOutput;
        string projectFile;
        string mainConsoleCmd1;


        public Form1()
        {

            InitializeComponent();

            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue500, Primary.Blue600, Primary.Red100, Accent.Yellow700, TextShade.WHITE);
            darkTheme.Checked = Properties.Settings.Default.chBox1;
            closeAfterStart.Checked = Properties.Settings.Default.chBox2;
            browseString.Text = Properties.Settings.Default.txt;
            browseString1.Text = Properties.Settings.Default.txt2;
            saveString.Text = Properties.Settings.Default.txt3;
            frameName.Text = Properties.Settings.Default.txt4;
            startFrame.Text = Properties.Settings.Default.txt5;
            lastFrame.Text = Properties.Settings.Default.txt6;
            frameJump.Text = Properties.Settings.Default.txt7;
            treatsCPU.Text = Properties.Settings.Default.txt8;

        }
        private void darkTheme_CheckedChanged(object sender, EventArgs e)
        {

            if (darkTheme.Checked == true)
            {
                materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
                materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue900, Primary.Blue800, Primary.Red100, Accent.Yellow700, TextShade.WHITE);
            }
            else
            {
                materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
                materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue500, Primary.Blue600, Primary.Red100, Accent.Yellow700, TextShade.WHITE);
            }
        }

        private void browseButton_Click(object sender, EventArgs e)
        {///Path to Blender
            var folderBrowserDialog1 = new FolderBrowserDialog();

            // Show the FolderBrowserDialog.
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                workingDirectory = folderBrowserDialog1.SelectedPath;
                browseString.Text = workingDirectory;
            }

        }

        private void saveButton_Click(object sender, EventArgs e)
        {///Save Path
            var folderBrowserDialog1 = new FolderBrowserDialog();

            // Show the FolderBrowserDialog.
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                renderOutput = folderBrowserDialog1.SelectedPath;
                saveString.Text = renderOutput;
            }
        }

        private void browseButton1_Click(object sender, EventArgs e)
        {///Path .blend
            openFileDialog1.Filter = "Blender project(*.blend)|*.blend|All files(*.*)|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            /// get the selected file
            projectFile = openFileDialog1.FileName;
            /// read the file in the line
            string fileText1 = System.IO.File.ReadAllText(projectFile);
            browseString1.Text = projectFile;
            MessageBox.Show("Succes");

        }

        public void startButton1_Click(object sender, EventArgs e)
        {
            workingDirectory = browseString.Text;
            string startFrame1 = startFrame.Text; ///Start Frame!!!
            string lastFrame1 = lastFrame.Text; ///Last Frame!!!
            string thretsCPU1 = treatsCPU.Text;///CPU Threads!!!
            string frameJump1 = frameJump.Text;///Skip Frames!!!
            string frameName1 = frameName.Text;///Frames Name!!!
            string renderOutput = saveString.Text + @"\" + frameName1; ///Save Path!!!
            string projectFile = browseString1.Text; ///File .blend!!!
            string mainConsoleCmd = "blender.exe -b " + projectFile + " -o " + renderOutput + " -t " + thretsCPU1 + " -j " + frameJump1 + " -s " + startFrame1 + " -e " + lastFrame1 + " -a "; ///Конечная команда!!!
            mainConsoleCmd1 = "ping 1.1.1.1";
            //cmd();
            var proc = new ProcessStartInfo()///Start CMD!!!
            {
                UseShellExecute = true,
                WorkingDirectory = workingDirectory,
                FileName = @"C:\Windows\System32\cmd.exe",
                Arguments = "/c " + mainConsoleCmd,
                //WindowStyle = ProcessWindowStyle.Hidden
            };
            Process.Start(proc);
            Console.WriteLine(workingDirectory);

            string info = "Generated CMD: ";
            startCommand.Text = info + mainConsoleCmd;
            startCommand.Font = new Font("Verdana", 8);

            if (closeAfterStart.Checked == true)
            {
                Application.Exit();
            }
        }
        private void saveParmButt_Click(object sender, EventArgs e) //Save Parameters
        {

            Properties.Settings.Default.chBox1 = darkTheme.Checked;
            Properties.Settings.Default.chBox2 = closeAfterStart.Checked;
            Properties.Settings.Default.txt = browseString.Text;
            Properties.Settings.Default.txt2 = browseString1.Text;
            Properties.Settings.Default.txt3 = saveString.Text;
            Properties.Settings.Default.txt4 = frameName.Text;
            Properties.Settings.Default.txt5 = startFrame.Text;
            Properties.Settings.Default.txt6 = lastFrame.Text;
            Properties.Settings.Default.txt7 = frameJump.Text;
            Properties.Settings.Default.txt8 = treatsCPU.Text;
            Properties.Settings.Default.Save();
        }

        private void materialLabel10_Click(object sender, EventArgs e)
        {

        }

        private void materialLabel2_Click(object sender, EventArgs e)
        {

        }

        private void startCommand_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void materialLabel4_Click(object sender, EventArgs e)
        {

        }

        private void AboutButton_Click(object sender, EventArgs e)
        {
            Form Form2 = new Form2();
            Form2.Show();
        }

        private void WikiButt_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/VandDApps/blender-console-render");
        }
    }
}
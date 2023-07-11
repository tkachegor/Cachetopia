using System;
using System.Timers;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using Microsoft.Win32;
using System.Security.AccessControl;

namespace Cachetopia
{
    public partial class Form1 : MaterialForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Paths & Variables
        // === Browswers cache paths === //
        public static string recycleBin = "C:$Recycle.Bin";

        public string firefoxProfileName = GetFirefoxProfileName();

        public string browserCachePath = "C:\\Users\\" + Environment.UserName.ToString() + "\\AppData\\Local\\Google\\Chrome\\User Data\\Default\\Cache";
        public string mozillaCachePath = "C:\\Users\\" + Environment.UserName.ToString() + "\\AppData\\Local\\Mozilla\\Firefox\\Profiles\\" + GetFirefoxProfileName() + "\\cache2\\entries";
        public string operaCachePath = "C:\\Users\\" + Environment.UserName.ToString() + "\\AppData\\Local\\Opera Software\\Opera Stable\\Cache";
        public string edgeCachePath = "C:\\Users\\" + Environment.UserName.ToString() + "\\AppData\\Local\\Packages\\Microsoft.MicrosoftEdge_8wekyb3d8bbwe\\LocalCache";
        public string edgeCachePathSecond = "C:\\Users\\" + Environment.UserName.ToString() + "\\AppData\\Local\\Packages\\Microsoft.MicrosoftEdge_8wekyb3d8bbwe\\LocalState";
        public string temporarPath = "C:\\Пользователи\\" + Environment.UserName.ToString() + "\\AppData\\Local\\Microsoft\\Windows\\Temporar";

        // === Standart windows paths === //
        public string tempPathDir = "C:\\Users\\" + Environment.UserName.ToString() + "\\AppData\\Local\\Temp";
        public string tempPathDirSecond = "C:\\Windows\\Temp";
        public string windowsPrefetchPath = "C:\\Windows\\Prefetch";
        public string javaPath = "C:\\Users\\" + Environment.UserName.ToString() + "\\AppData\\LocalLow\\Sun\\Java\\Deployment\\cache";
        public string officePath = "C:\\Users\\" + Environment.UserName.ToString() + "\\AppData\\Local\\Microsoft\\Office\\16.0\\OfficeFileCache";
        public string thumbnailsPath = "C:\\Users\\ " + Environment.UserName.ToString() + "\\AppData\\Local\\Microsoft\\Windows\\Explorer";
        public string[] lines = File.ReadAllLines("C:\\Cachetopia\\config.txt");

        public string configPath = "C:\\Cachetopia\\config.txt";


        // Functions
        private static void ClearPath(string path)
        {
            try
            {
                if (Directory.Exists(path))
                {
                    DirectoryInfo tempPathDirSecondInfo = new DirectoryInfo(path);
                    foreach (FileInfo file in tempPathDirSecondInfo.GetFiles())
                    {
                        try
                        {
                            file.Delete();
                        }
                        catch (Exception e)
                        {

                        }
                    }

                    foreach (DirectoryInfo subDirectory in tempPathDirSecondInfo.GetDirectories())
                    {
                        try
                        {
                            //subDirectory.Delete(true);
                            Directory.Delete(subDirectory.FullName, true);
                        }
                        catch (Exception e)
                        {

                        }
                    }
                }
            }
            catch (Exception e)
            {

            }

        }

        static string GetFirefoxProfileName()
        {
            string registryPath = @"Software\Microsoft\Windows\CurrentVersion\App Paths\firefox.exe";
            using (RegistryKey key = Registry.LocalMachine.OpenSubKey(registryPath))
            {
                if (key != null)
                {
                    object value = key.GetValue("PathToProfile"); //Find path // FIX THIS
                    if (value != null)
                    {
                        string profilePath = value.ToString();
                        string profileName = Path.GetFileName(profilePath);
                        return profileName;
                    }
                }
            }

            return null;
        }


        // Event Handlers
        // Clear All Handler
        private void materialButton1_Click(object sender, EventArgs e)
        {
            // Clear standart application cache
            ClearPath(tempPathDir);
            ClearPath(tempPathDirSecond);
            ClearPath(javaPath);
            ClearPath(officePath);
            ClearPath(thumbnailsPath);
            //ClearPath(windowsPrefetchPath); !!!!!! FIX THIS


            // Clear browsers cache
            ClearPath(browserCachePath);
            ClearPath(mozillaCachePath);
            ClearPath(operaCachePath);
            ClearPath(edgeCachePath);
            ClearPath(edgeCachePathSecond);
            ClearPath(temporarPath);

            ClearPath(recycleBin);

            MessageBox.Show("Done!", "Message");
        }

        private void clearBrowser_Click(object sender, EventArgs e)
        {
            ClearPath(browserCachePath);
            ClearPath(mozillaCachePath);
            ClearPath(operaCachePath);
            ClearPath(edgeCachePath);
            ClearPath(edgeCachePathSecond);
            ClearPath(temporarPath);

            ClearPath(recycleBin);
            MessageBox.Show("Done!", "Message");
        }

        private void standartProgramms_Click(object sender, EventArgs e)
        {
            ClearPath(tempPathDir);
            ClearPath(tempPathDirSecond);

            //ClearPath(windowsPrefetchPath); !!!!!! FIX THIS
            ClearPath(recycleBin);
            MessageBox.Show("Done!", "Message");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if(WindowState == FormWindowState.Minimized)
            {
                trayIcon.Visible = true;
                this.Hide();
            }
        }

        private void trayIcon_DoubleClick(object sender, EventArgs e)
        {

        }

        private void trayIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            trayIcon.Visible = false;
            Show();
            WindowState = FormWindowState.Normal;
        }

        private void openCachetopiaStrip_Click(object sender, EventArgs e)
        {
            trayIcon.Visible = false;
            Show();
            WindowState = FormWindowState.Normal;
        }

        private void exitCachetopiaStrip_Click(object sender, EventArgs e)
        {
            trayIcon.Dispose();
            Application.Exit();
        }

        private void clearAllCacheStrip_Click(object sender, EventArgs e)
        {
            // Clear standart application cache
            ClearPath(tempPathDir);
            ClearPath(tempPathDirSecond);
            ClearPath(javaPath);
            ClearPath(officePath);
            ClearPath(thumbnailsPath);
            //ClearPath(windowsPrefetchPath); !!!!!! FIX THIS


            // Clear browsers cache
            ClearPath(browserCachePath);
            ClearPath(mozillaCachePath);
            ClearPath(operaCachePath);
            ClearPath(edgeCachePath);
            ClearPath(edgeCachePathSecond);
            ClearPath(temporarPath);

            ClearPath(recycleBin);

            MessageBox.Show("Done!", "Message");
        }

        private void clearBrowserStrip_Click(object sender, EventArgs e)
        {
            ClearPath(browserCachePath);
            ClearPath(mozillaCachePath);
            ClearPath(operaCachePath);
            ClearPath(edgeCachePath);
            ClearPath(edgeCachePathSecond);
            ClearPath(temporarPath);

            ClearPath(recycleBin);
            MessageBox.Show("Done!", "Message");
        }

        private void clearSystemStrip_Click(object sender, EventArgs e)
        {
            ClearPath(tempPathDir);
            ClearPath(tempPathDirSecond);

            ClearPath(recycleBin);
            MessageBox.Show("Done!", "Message");
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            Form2 window = new Form2();
            window.Show();
        }

        public async void timeIsClear(object state)
        {
            DateTime currentTime = DateTime.Now;

            string currentDateAndTime = currentTime.ToString().Substring(0, 16);
            string plannedDateAndTime = lines[0].Substring(0, 16);

            if (currentDateAndTime.Equals(plannedDateAndTime))
            {
                // Clear All
                // Clear standart application cache
                ClearPath(tempPathDir);
                ClearPath(tempPathDirSecond);
                ClearPath(javaPath);
                ClearPath(officePath);
                ClearPath(thumbnailsPath);
                //ClearPath(windowsPrefetchPath); !!!!!! FIX THIS


                // Clear browsers cache
                ClearPath(browserCachePath);
                ClearPath(mozillaCachePath);
                ClearPath(operaCachePath);
                ClearPath(edgeCachePath);
                ClearPath(edgeCachePathSecond);
                ClearPath(temporarPath);

                ClearPath(recycleBin);

                File.WriteAllText(configPath, string.Empty);

                MessageBox.Show("Scheduled cleaning was successful", "Message");
            }
            await Task.Delay(TimeSpan.FromMinutes(1));
        }

        // Form loading
        private void Form1_Load(object sender, EventArgs e)
        {
            //timeIsClear();
            try
            {
                DateTime activationDateTime = DateTime.Parse(lines[0]); // Пример: 16 июня 2023 года, 10:00:00

                // Вычислите время ожидания до активации функции
                TimeSpan timeToActivation = activationDateTime - DateTime.Now;

                // Создайте таймер и установите его интервал равным времени ожидания
                System.Threading.Timer timer = new System.Threading.Timer(timeIsClear, null, timeToActivation, TimeSpan.Zero);
            } catch(Exception ex)
            {
                
            }
            
        }
    }
}

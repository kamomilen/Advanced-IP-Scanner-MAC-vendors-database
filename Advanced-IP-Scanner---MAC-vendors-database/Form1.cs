
using System.Diagnostics;
using System.Globalization;
using System.Security.Policy;
using System.Text;
using System.Text.Json;

namespace Advanced_IP_Scanner___MAC_vendors_database
{
    public partial class Form1 : Form
    {
        private string workJsonPath = Path.GetFullPath(@".\mac-vendors-export.json");
        private string downloadJsonPath = System.Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + @"\Downloads\mac-vendors-export.json";
        private string currentDirectoryPath = Path.GetFullPath(Directory.GetCurrentDirectory());
        private string portableDirectoryPath = System.Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + @"\AppData\Local\Temp\Advanced IP Scanner 2";

        public Form1()
        {
            InitializeComponent();
            ResourcesSetting();
        }

        private void ResourcesSetting()
        {
            if (Thread.CurrentThread.CurrentUICulture.Name == "ja-JP")
            {
                日本語JapaniseToolStripMenuItem.Checked = true;
                englishEnglishToolStripMenuItem.Checked = false;
            }

            // Menu
            settingsToolStripMenuItem.Text = Resources.MenuSettings;
            languageToolStripMenuItem.Text = Resources.MenuSettingsLanguage;

            // Label
            label1.Text = Resources.FormLabel1;
            label2.Text = Resources.FormLabel2;
            label3.Text = Resources.FormLabel3;

            // Checkbox
            checkBox_backup.Text = Resources.FormCheckBoxBackup;

            // Button
            button_file_update.Text = Resources.FormButtonFileUpdate;
            button_open_browser.Text = Resources.FormButtonOpenBrowser;
            button_open_directory.Text = Resources.FormButtonOpenDirectory;
            button_launch_exe.Text = Resources.FormButtonLaunchExe;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                // Directory existence check 1.(Custom Install Path)
                if (File.Exists(currentDirectoryPath + Path.DirectorySeparatorChar + "advanced_ip_scanner.exe"))
                {
                    textBox_dir_path.Text = currentDirectoryPath;
                    button_open_directory.Enabled = true;
                    button_launch_exe.Enabled = true;
                    button_open_browser.Enabled = true;
                    return;
                }
                // Directory existence check 2.
                if (Directory.Exists(textBox_dir_path.Text))
                {
                    button_open_directory.Enabled = true;
                    button_launch_exe.Enabled = true;
                    button_open_browser.Enabled = true;
                    return;
                }
                // Directory existence check 3.(Portable Install Path)
                if (Directory.Exists(portableDirectoryPath))
                {
                    textBox_dir_path.Text = portableDirectoryPath;
                    button_open_directory.Enabled = true;
                    button_launch_exe.Enabled = true;
                    button_open_browser.Enabled = true;
                    return;
                }

                textBox_dir_path.Text = string.Empty;
            }
            catch (Exception ex)
            {
                textBox_dir_path.Text = string.Empty;
                MessageBox.Show(Resources.ExceptionMessages + Environment.NewLine + ex.ToString(), Resources.ExceptionCaption);
            }
            finally
            {
                if (File.Exists(workJsonPath))
                {
                    button_file_update.Enabled = true;
                }
                else if (File.Exists(downloadJsonPath))
                {
                    button_file_update.Enabled = true;
                }
            }
        }

        private void button_file_update_Click(object sender, EventArgs e)
        {
            try
            {
                string workJsonBackupPath = currentDirectoryPath + Path.DirectorySeparatorChar + "mac-vendors-export_" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".json";
                string macFilePath = textBox_dir_path.Text + Path.DirectorySeparatorChar + "mac_interval_tree.txt";
                string jsonFilePath;
                bool moveFlag = false;

                // Search for the location of the JSON file.
                if (File.Exists(workJsonPath))
                {
                    jsonFilePath = workJsonPath;
                }
                else if (File.Exists(downloadJsonPath))
                {

                    moveFlag = true;
                    jsonFilePath = downloadJsonPath;
                }
                else
                {
                    DialogResult result = openFileDialog1.ShowDialog(this);
                    if (result != DialogResult.OK)
                    {
                        return;
                    }
                    moveFlag = true;
                    jsonFilePath = openFileDialog1.FileName;
                }

                // Confirm file used.
                DialogResult result_button = MessageBox.Show(Resources.FileUpdateConfirmMessage + System.Environment.NewLine + jsonFilePath, Resources.FileUpdateConfirmMessageCaption, MessageBoxButtons.OKCancel);
                if (DialogResult.OK != result_button)
                {
                    return;
                }

                // move
                if (moveFlag)
                {
                    File.Move(jsonFilePath, workJsonPath);
                    jsonFilePath = workJsonPath;
                }

                // Import JSON file.
                string jsonString = string.Empty;
                using (FileStream fs = new(jsonFilePath, FileMode.Open))
                {
                    using (StreamReader sr = new(fs, Encoding.GetEncoding("UTF-8")))
                    {
                        jsonString = sr.ReadToEnd();
                        sr.Dispose();
                    }
                    fs.Dispose();
                }

                // Get content.
                List<string> macDeviceList = [];
                try
                {
                    var documentOptions = new JsonDocumentOptions
                    {
                        CommentHandling = JsonCommentHandling.Skip
                    };

                    using (JsonDocument document = JsonDocument.Parse(jsonString, documentOptions))
                    {
                        var rootToList = document.RootElement.EnumerateArray().ToList();
                        foreach (var root in rootToList)
                        {
                            string mac = root.GetProperty("macPrefix").ToString().Replace(":", "");
                            string macDeviceStr = mac + new string('F', 12 - mac.Length) + " " + root.GetProperty("vendorName");
                            macDeviceList.Add(macDeviceStr);
                        }
                    }
                    macDeviceList.Sort();
                }
                finally
                {
                    File.Move(jsonFilePath, workJsonBackupPath);
                    jsonString = string.Empty;
                }

                // File backup processing.
                if (checkBox_backup.Checked)
                {
                    string backupFilePath = textBox_dir_path.Text + Path.DirectorySeparatorChar + "mac_interval_tree_" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".txt";
                    File.Copy(macFilePath, backupFilePath, true);
                }

                // File Update.
                using (FileStream fs = new(macFilePath, FileMode.Create))
                {
                    using (StreamWriter sw = new(fs, new UTF8Encoding(false)))
                    {
                        foreach (string str in macDeviceList)
                        {
                            sw.Write(str + "\n");
                        }
                        sw.Flush();
                        sw.Dispose();
                    }
                    fs.Dispose();
                }

                MessageBox.Show(Resources.FileUpdateCompletionNotification);
            }
            catch (Exception ex)
            {
                MessageBox.Show(Resources.ExceptionMessages + Environment.NewLine + ex.ToString(), Resources.ExceptionCaption);
            }
        }

        private void button_open_browser_Click(object sender, EventArgs e)
        {
            string url = "https://maclookup.app/downloads/json-database";
            var startInfo = new System.Diagnostics.ProcessStartInfo(url);
            startInfo.UseShellExecute = true;
            Process.Start(startInfo);

            button_file_update.Enabled = true;
        }

        private void button_open_directory_Click(object sender, EventArgs e)
        {
            var startInfo = new System.Diagnostics.ProcessStartInfo(textBox_dir_path.Text);
            startInfo.UseShellExecute = true;
            Process.Start(startInfo);
        }

        private void englishEnglishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            englishEnglishToolStripMenuItem.Checked = true;
            日本語JapaniseToolStripMenuItem.Checked = false;
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US");
            ResourcesSetting();
        }

        private void 日本語JapaniseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            日本語JapaniseToolStripMenuItem.Checked = true;
            englishEnglishToolStripMenuItem.Checked = false;
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("ja-JP");
            ResourcesSetting();
        }

        private void button_launch_exe_Click(object sender, EventArgs e)
        {
            string exePath = textBox_dir_path.Text + Path.DirectorySeparatorChar + "advanced_ip_scanner.exe";
            var startInfo = new System.Diagnostics.ProcessStartInfo(exePath);
            startInfo.UseShellExecute = true;
            startInfo.WorkingDirectory = textBox_dir_path.Text;
            Process.Start(startInfo);
        }
    }
}

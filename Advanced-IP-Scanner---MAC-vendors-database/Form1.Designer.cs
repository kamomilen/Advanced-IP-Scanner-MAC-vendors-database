namespace Advanced_IP_Scanner___MAC_vendors_database
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            textBox_dir_path = new TextBox();
            groupBox1 = new GroupBox();
            button_open_directory = new Button();
            checkBox_backup = new CheckBox();
            button_file_update = new Button();
            openFileDialog1 = new OpenFileDialog();
            button_open_browser = new Button();
            label2 = new Label();
            label3 = new Label();
            menuStrip1 = new MenuStrip();
            settingsToolStripMenuItem = new ToolStripMenuItem();
            languageToolStripMenuItem = new ToolStripMenuItem();
            englishEnglishToolStripMenuItem = new ToolStripMenuItem();
            日本語JapaniseToolStripMenuItem = new ToolStripMenuItem();
            groupBox1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 32);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(149, 20);
            label1.TabIndex = 0;
            label1.Text = "Install Directory Path:";
            // 
            // textBox_dir_path
            // 
            textBox_dir_path.Enabled = false;
            textBox_dir_path.Location = new Point(20, 56);
            textBox_dir_path.Margin = new Padding(4);
            textBox_dir_path.Name = "textBox_dir_path";
            textBox_dir_path.Size = new Size(561, 27);
            textBox_dir_path.TabIndex = 1;
            textBox_dir_path.Text = "C:\\Program Files (x86)\\Advanced IP Scanner";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button_open_directory);
            groupBox1.Controls.Add(checkBox_backup);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(textBox_dir_path);
            groupBox1.Location = new Point(15, 49);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(714, 151);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Advanced IP Scanner";
            // 
            // button_open_directory
            // 
            button_open_directory.Enabled = false;
            button_open_directory.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            button_open_directory.Location = new Point(589, 20);
            button_open_directory.Margin = new Padding(4);
            button_open_directory.Name = "button_open_directory";
            button_open_directory.Size = new Size(117, 63);
            button_open_directory.TabIndex = 6;
            button_open_directory.Text = "Open Directory";
            button_open_directory.UseVisualStyleBackColor = true;
            button_open_directory.Click += button_open_directory_Click;
            // 
            // checkBox_backup
            // 
            checkBox_backup.AutoSize = true;
            checkBox_backup.Checked = true;
            checkBox_backup.CheckState = CheckState.Checked;
            checkBox_backup.Location = new Point(20, 107);
            checkBox_backup.Name = "checkBox_backup";
            checkBox_backup.Size = new Size(252, 24);
            checkBox_backup.TabIndex = 2;
            checkBox_backup.Text = "Backup File [mac_interval_tree.txt]";
            checkBox_backup.UseVisualStyleBackColor = true;
            // 
            // button_file_update
            // 
            button_file_update.Enabled = false;
            button_file_update.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            button_file_update.Location = new Point(118, 255);
            button_file_update.Margin = new Padding(4);
            button_file_update.Name = "button_file_update";
            button_file_update.Size = new Size(607, 39);
            button_file_update.TabIndex = 4;
            button_file_update.Text = "Update the file: [mac_interval_tree.txt]";
            button_file_update.UseVisualStyleBackColor = true;
            button_file_update.Click += button_file_update_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "mac-vendors-export.json";
            openFileDialog1.Filter = "JSON File|mac-vendors-export.json";
            openFileDialog1.RestoreDirectory = true;
            openFileDialog1.Title = "Please select open file.";
            // 
            // button_open_browser
            // 
            button_open_browser.Enabled = false;
            button_open_browser.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            button_open_browser.Location = new Point(119, 208);
            button_open_browser.Margin = new Padding(4);
            button_open_browser.Name = "button_open_browser";
            button_open_browser.Size = new Size(607, 39);
            button_open_browser.TabIndex = 5;
            button_open_browser.Text = "Please download the JSON file manually. (Open Browser)";
            button_open_browser.UseVisualStyleBackColor = true;
            button_open_browser.Click += button_open_browser_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 219);
            label2.Name = "label2";
            label2.Size = new Size(54, 20);
            label2.TabIndex = 6;
            label2.Text = "Step 1:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(35, 266);
            label3.Name = "label3";
            label3.Size = new Size(54, 20);
            label3.TabIndex = 7;
            label3.Text = "Step 2:";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { settingsToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(742, 24);
            menuStrip1.TabIndex = 8;
            menuStrip1.Text = "menuStrip1";
            // 
            // settingsToolStripMenuItem
            // 
            settingsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { languageToolStripMenuItem });
            settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            settingsToolStripMenuItem.Size = new Size(61, 20);
            settingsToolStripMenuItem.Text = "Settings";
            // 
            // languageToolStripMenuItem
            // 
            languageToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { englishEnglishToolStripMenuItem, 日本語JapaniseToolStripMenuItem });
            languageToolStripMenuItem.Name = "languageToolStripMenuItem";
            languageToolStripMenuItem.Size = new Size(126, 22);
            languageToolStripMenuItem.Text = "Language";
            // 
            // englishEnglishToolStripMenuItem
            // 
            englishEnglishToolStripMenuItem.Checked = true;
            englishEnglishToolStripMenuItem.CheckState = CheckState.Checked;
            englishEnglishToolStripMenuItem.Name = "englishEnglishToolStripMenuItem";
            englishEnglishToolStripMenuItem.Size = new Size(165, 22);
            englishEnglishToolStripMenuItem.Text = "English(English)";
            englishEnglishToolStripMenuItem.Click += englishEnglishToolStripMenuItem_Click;
            // 
            // 日本語JapaniseToolStripMenuItem
            // 
            日本語JapaniseToolStripMenuItem.Name = "日本語JapaniseToolStripMenuItem";
            日本語JapaniseToolStripMenuItem.Size = new Size(165, 22);
            日本語JapaniseToolStripMenuItem.Text = "日本語(Japanese)";
            日本語JapaniseToolStripMenuItem.Click += 日本語JapaniseToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(742, 310);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button_open_browser);
            Controls.Add(button_file_update);
            Controls.Add(groupBox1);
            Controls.Add(menuStrip1);
            Font = new Font("Yu Gothic UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Advanced-IP-Scanner-MAC-vendors-database";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox_dir_path;
        private GroupBox groupBox1;
        private CheckBox checkBox_backup;
        private Button button_file_update;
        private OpenFileDialog openFileDialog1;
        private Button button_open_browser;
        private Label label2;
        private Label label3;
        private Button button_open_directory;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem settingsToolStripMenuItem;
        private ToolStripMenuItem languageToolStripMenuItem;
        private ToolStripMenuItem englishEnglishToolStripMenuItem;
        private ToolStripMenuItem 日本語JapaniseToolStripMenuItem;
    }
}

﻿namespace SirenSharp
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            newToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            saveAsToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            importToolStripMenuItem = new ToolStripMenuItem();
            toolsToolStripMenuItem = new ToolStripMenuItem();
            generateFiveMResourceToolStripMenuItem = new ToolStripMenuItem();
            fileListView = new ListView();
            playlistNameHeader = new ColumnHeader();
            playlistTypeHeader = new ColumnHeader();
            playlistLengthHeader = new ColumnHeader();
            playlistSizeHeader = new ColumnHeader();
            tabControl1 = new TabControl();
            settingsPage = new TabPage();
            dlcNameTextBox = new TextBox();
            label4 = new Label();
            fivemResourceNameTextBox = new TextBox();
            label3 = new Label();
            sirenPage = new TabPage();
            button2 = new Button();
            sirenAudioPathTextBox = new TextBox();
            label2 = new Label();
            sirenNameTextBox = new TextBox();
            label1 = new Label();
            button1 = new Button();
            awcNameTextBox = new TextBox();
            label5 = new Label();
            menuStrip1.SuspendLayout();
            tabControl1.SuspendLayout();
            settingsPage.SuspendLayout();
            sirenPage.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, editToolStripMenuItem, toolsToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newToolStripMenuItem, openToolStripMenuItem, saveAsToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            newToolStripMenuItem.Name = "newToolStripMenuItem";
            newToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.N;
            newToolStripMenuItem.Size = new Size(163, 22);
            newToolStripMenuItem.Text = "New";
            newToolStripMenuItem.Click += newToolStripMenuItem_Click;
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.O;
            openToolStripMenuItem.Size = new Size(163, 22);
            openToolStripMenuItem.Text = "Open...";
            openToolStripMenuItem.Click += loadToolStripMenuItem_Click;
            // 
            // saveAsToolStripMenuItem
            // 
            saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            saveAsToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
            saveAsToolStripMenuItem.Size = new Size(163, 22);
            saveAsToolStripMenuItem.Text = "Save As...";
            saveAsToolStripMenuItem.Click += saveAsToolStripMenuItem_Click;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { importToolStripMenuItem });
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(39, 20);
            editToolStripMenuItem.Text = "Edit";
            // 
            // importToolStripMenuItem
            // 
            importToolStripMenuItem.Name = "importToolStripMenuItem";
            importToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.I;
            importToolStripMenuItem.Size = new Size(156, 22);
            importToolStripMenuItem.Text = "Import...";
            importToolStripMenuItem.Click += importToolStripMenuItem_Click;
            // 
            // toolsToolStripMenuItem
            // 
            toolsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { generateFiveMResourceToolStripMenuItem });
            toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            toolsToolStripMenuItem.Size = new Size(46, 20);
            toolsToolStripMenuItem.Text = "Tools";
            // 
            // generateFiveMResourceToolStripMenuItem
            // 
            generateFiveMResourceToolStripMenuItem.Name = "generateFiveMResourceToolStripMenuItem";
            generateFiveMResourceToolStripMenuItem.Size = new Size(216, 22);
            generateFiveMResourceToolStripMenuItem.Text = "Generate FiveM Resource...";
            generateFiveMResourceToolStripMenuItem.Click += generateFiveMResourceToolStripMenuItem_Click;
            // 
            // listView1
            // 
            fileListView.Columns.AddRange(new ColumnHeader[] { playlistNameHeader, playlistTypeHeader, playlistLengthHeader, playlistSizeHeader });
            fileListView.FullRowSelect = true;
            fileListView.Location = new Point(12, 27);
            fileListView.Name = "listView1";
            fileListView.Size = new Size(374, 411);
            fileListView.TabIndex = 1;
            fileListView.UseCompatibleStateImageBehavior = false;
            fileListView.View = View.Details;
            fileListView.SelectedIndexChanged += fileListView_SelectedIndexChanged;
            // 
            // playlistNameHeader
            // 
            playlistNameHeader.Text = "Name";
            playlistNameHeader.Width = 150;
            // 
            // playlistTypeHeader
            // 
            playlistTypeHeader.Text = "Type";
            playlistTypeHeader.Width = 100;
            // 
            // playlistLengthHeader
            // 
            playlistLengthHeader.Text = "Length";
            playlistLengthHeader.TextAlign = HorizontalAlignment.Right;
            playlistLengthHeader.Width = 50;
            // 
            // playlistSizeHeader
            // 
            playlistSizeHeader.Text = "Size";
            playlistSizeHeader.TextAlign = HorizontalAlignment.Right;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(settingsPage);
            tabControl1.Controls.Add(sirenPage);
            tabControl1.Location = new Point(392, 27);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(408, 411);
            tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            settingsPage.Controls.Add(awcNameTextBox);
            settingsPage.Controls.Add(label5);
            settingsPage.Controls.Add(dlcNameTextBox);
            settingsPage.Controls.Add(label4);
            settingsPage.Controls.Add(fivemResourceNameTextBox);
            settingsPage.Controls.Add(label3);
            settingsPage.Location = new Point(4, 24);
            settingsPage.Name = "tabPage1";
            settingsPage.Padding = new Padding(3);
            settingsPage.Size = new Size(400, 383);
            settingsPage.TabIndex = 0;
            settingsPage.Text = "Settings";
            settingsPage.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            dlcNameTextBox.Location = new Point(18, 98);
            dlcNameTextBox.Name = "textBox4";
            dlcNameTextBox.PlaceholderText = "my_custom_dlc";
            dlcNameTextBox.Size = new Size(152, 23);
            dlcNameTextBox.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 80);
            label4.Name = "label4";
            label4.Size = new Size(67, 15);
            label4.TabIndex = 2;
            label4.Text = "DLC Name:";
            // 
            // textBox3
            // 
            fivemResourceNameTextBox.Location = new Point(18, 36);
            fivemResourceNameTextBox.Name = "textBox3";
            fivemResourceNameTextBox.PlaceholderText = "my-custom-sirens";
            fivemResourceNameTextBox.Size = new Size(152, 23);
            fivemResourceNameTextBox.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 18);
            label3.Name = "label3";
            label3.Size = new Size(128, 15);
            label3.TabIndex = 0;
            label3.Text = "FiveM Resource Name:";
            // 
            // tabPage2
            // 
            sirenPage.Controls.Add(button2);
            sirenPage.Controls.Add(sirenAudioPathTextBox);
            sirenPage.Controls.Add(label2);
            sirenPage.Controls.Add(sirenNameTextBox);
            sirenPage.Controls.Add(label1);
            sirenPage.Controls.Add(button1);
            sirenPage.Location = new Point(4, 24);
            sirenPage.Name = "tabPage2";
            sirenPage.Padding = new Padding(3);
            sirenPage.Size = new Size(400, 383);
            sirenPage.TabIndex = 1;
            sirenPage.Text = "Siren";
            sirenPage.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(17, 157);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 5;
            button2.Text = "Save";
            button2.UseVisualStyleBackColor = true;
            button2.Click += sirenSaveButton_Clicked;
            // 
            // textBox2
            // 
            sirenAudioPathTextBox.Location = new Point(17, 95);
            sirenAudioPathTextBox.Name = "textBox2";
            sirenAudioPathTextBox.Size = new Size(294, 23);
            sirenAudioPathTextBox.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 77);
            label2.Name = "label2";
            label2.Size = new Size(69, 15);
            label2.TabIndex = 3;
            label2.Text = "Audio Path:";
            // 
            // textBox1
            // 
            sirenNameTextBox.Location = new Point(17, 32);
            sirenNameTextBox.Name = "textBox1";
            sirenNameTextBox.Size = new Size(222, 23);
            sirenNameTextBox.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 14);
            label1.Name = "label1";
            label1.Size = new Size(71, 15);
            label1.TabIndex = 1;
            label1.Text = "Siren Name:";
            // 
            // button1
            // 
            button1.Location = new Point(317, 95);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "Browse...";
            button1.UseVisualStyleBackColor = true;
            button1.Click += sirenAudioBrowseButton_Clicked;
            // 
            // textBox5
            // 
            awcNameTextBox.Location = new Point(18, 161);
            awcNameTextBox.Name = "textBox5";
            awcNameTextBox.PlaceholderText = "my_sirens";
            awcNameTextBox.Size = new Size(152, 23);
            awcNameTextBox.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(18, 143);
            label5.Name = "label5";
            label5.Size = new Size(71, 15);
            label5.TabIndex = 4;
            label5.Text = "AWC Name:";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Controls.Add(fileListView);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            Text = "SirenSharp";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            tabControl1.ResumeLayout(false);
            settingsPage.ResumeLayout(false);
            settingsPage.PerformLayout();
            sirenPage.ResumeLayout(false);
            sirenPage.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem newToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ListView fileListView;
        private ColumnHeader playlistNameHeader;
        private ColumnHeader playlistTypeHeader;
        private ColumnHeader playlistLengthHeader;
        private ColumnHeader playlistSizeHeader;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem importToolStripMenuItem;
        private ToolStripMenuItem saveAsToolStripMenuItem;
        private ToolStripMenuItem toolsToolStripMenuItem;
        private ToolStripMenuItem generateFiveMResourceToolStripMenuItem;
        private TabControl tabControl1;
        private TabPage settingsPage;
        private TabPage sirenPage;
        private Button button2;
        private TextBox sirenAudioPathTextBox;
        private Label label2;
        private TextBox sirenNameTextBox;
        private Label label1;
        private Button button1;
        private TextBox dlcNameTextBox;
        private Label label4;
        private TextBox fivemResourceNameTextBox;
        private Label label3;
        private TextBox awcNameTextBox;
        private Label label5;
    }
}
namespace Kodlama_Programı
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.nyX_Theme1 = new CS_ClassLibraryTester.NYX_Theme();
            this.link = new System.Windows.Forms.Label();
            this.nyX_GroupBox3 = new CS_ClassLibraryTester.NYX_GroupBox();
            this.console = new System.Windows.Forms.RichTextBox();
            this.nyX_GroupBox2 = new CS_ClassLibraryTester.NYX_GroupBox();
            this.download_button = new CS_ClassLibraryTester.NYX_Button();
            this.process_mb = new System.Windows.Forms.ComboBox();
            this.islemci_isim = new System.Windows.Forms.ComboBox();
            this.download_panel = new System.Windows.Forms.ComboBox();
            this.nyX_ProgressBar1 = new CS_ClassLibraryTester.NYX_ProgressBar();
            this.materialDivider4 = new MaterialSkin.Controls.MaterialDivider();
            this.materialDivider3 = new MaterialSkin.Controls.MaterialDivider();
            this.materialDivider2 = new MaterialSkin.Controls.MaterialDivider();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.nyX_GroupBox1 = new CS_ClassLibraryTester.NYX_GroupBox();
            this.ozellikler_ici = new System.Windows.Forms.ComboBox();
            this.arac_Ozellikler = new System.Windows.Forms.ComboBox();
            this.araclar = new System.Windows.Forms.ComboBox();
            this.diller = new System.Windows.Forms.ComboBox();
            this.nyX_ControlBox1 = new CS_ClassLibraryTester.NYX_ControlBox();
            this.nyX_Theme1.SuspendLayout();
            this.nyX_GroupBox3.SuspendLayout();
            this.nyX_GroupBox2.SuspendLayout();
            this.nyX_GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // nyX_Theme1
            // 
            this.nyX_Theme1.Animated = true;
            this.nyX_Theme1.BorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.nyX_Theme1.Colors = new CS_ClassLibraryTester.Bloom[0];
            this.nyX_Theme1.Controls.Add(this.link);
            this.nyX_Theme1.Controls.Add(this.nyX_GroupBox3);
            this.nyX_Theme1.Controls.Add(this.nyX_GroupBox2);
            this.nyX_Theme1.Controls.Add(this.nyX_ProgressBar1);
            this.nyX_Theme1.Controls.Add(this.materialDivider4);
            this.nyX_Theme1.Controls.Add(this.materialDivider3);
            this.nyX_Theme1.Controls.Add(this.materialDivider2);
            this.nyX_Theme1.Controls.Add(this.materialDivider1);
            this.nyX_Theme1.Controls.Add(this.nyX_GroupBox1);
            this.nyX_Theme1.Controls.Add(this.nyX_ControlBox1);
            this.nyX_Theme1.Customization = "";
            this.nyX_Theme1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nyX_Theme1.Font = new System.Drawing.Font("Verdana", 8F);
            this.nyX_Theme1.Image = null;
            this.nyX_Theme1.Location = new System.Drawing.Point(0, 0);
            this.nyX_Theme1.Movable = true;
            this.nyX_Theme1.Name = "nyX_Theme1";
            this.nyX_Theme1.NoRounding = false;
            this.nyX_Theme1.Sizable = true;
            this.nyX_Theme1.Size = new System.Drawing.Size(550, 354);
            this.nyX_Theme1.SmartBounds = true;
            this.nyX_Theme1.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.nyX_Theme1.TabIndex = 0;
            this.nyX_Theme1.Text = "Geliştirmeye Yardımcı Araç  - Barış MIZRAKLI";
            this.nyX_Theme1.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.nyX_Theme1.Transparent = false;
            this.nyX_Theme1.Click += new System.EventHandler(this.nyX_Theme1_Click);
            // 
            // link
            // 
            this.link.AutoSize = true;
            this.link.Location = new System.Drawing.Point(602, 87);
            this.link.Name = "link";
            this.link.Size = new System.Drawing.Size(34, 13);
            this.link.TabIndex = 11;
            this.link.Text = "LINK";
            this.link.Visible = false;
            // 
            // nyX_GroupBox3
            // 
            this.nyX_GroupBox3.Animated = true;
            this.nyX_GroupBox3.BorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.nyX_GroupBox3.Colors = new CS_ClassLibraryTester.Bloom[0];
            this.nyX_GroupBox3.Controls.Add(this.console);
            this.nyX_GroupBox3.Customization = "";
            this.nyX_GroupBox3.Font = new System.Drawing.Font("Arial", 9F);
            this.nyX_GroupBox3.Image = null;
            this.nyX_GroupBox3.Location = new System.Drawing.Point(230, 29);
            this.nyX_GroupBox3.Movable = true;
            this.nyX_GroupBox3.Name = "nyX_GroupBox3";
            this.nyX_GroupBox3.NoRounding = false;
            this.nyX_GroupBox3.Sizable = true;
            this.nyX_GroupBox3.Size = new System.Drawing.Size(307, 287);
            this.nyX_GroupBox3.SmartBounds = true;
            this.nyX_GroupBox3.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.nyX_GroupBox3.TabIndex = 10;
            this.nyX_GroupBox3.Text = "Kod Çıktısı";
            this.nyX_GroupBox3.TransparencyKey = System.Drawing.Color.Empty;
            this.nyX_GroupBox3.Transparent = false;
            // 
            // console
            // 
            this.console.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.console.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.console.ForeColor = System.Drawing.Color.White;
            this.console.Location = new System.Drawing.Point(5, 25);
            this.console.Name = "console";
            this.console.Size = new System.Drawing.Size(295, 259);
            this.console.TabIndex = 9;
            this.console.Text = "";
            // 
            // nyX_GroupBox2
            // 
            this.nyX_GroupBox2.Animated = true;
            this.nyX_GroupBox2.BorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.nyX_GroupBox2.Colors = new CS_ClassLibraryTester.Bloom[0];
            this.nyX_GroupBox2.Controls.Add(this.download_button);
            this.nyX_GroupBox2.Controls.Add(this.process_mb);
            this.nyX_GroupBox2.Controls.Add(this.islemci_isim);
            this.nyX_GroupBox2.Controls.Add(this.download_panel);
            this.nyX_GroupBox2.Customization = "";
            this.nyX_GroupBox2.Font = new System.Drawing.Font("Arial", 9F);
            this.nyX_GroupBox2.Image = null;
            this.nyX_GroupBox2.Location = new System.Drawing.Point(12, 177);
            this.nyX_GroupBox2.Movable = true;
            this.nyX_GroupBox2.Name = "nyX_GroupBox2";
            this.nyX_GroupBox2.NoRounding = false;
            this.nyX_GroupBox2.Sizable = true;
            this.nyX_GroupBox2.Size = new System.Drawing.Size(211, 139);
            this.nyX_GroupBox2.SmartBounds = true;
            this.nyX_GroupBox2.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.nyX_GroupBox2.TabIndex = 5;
            this.nyX_GroupBox2.Text = "Yardımcı Araç - İçerik İndirme Paneli";
            this.nyX_GroupBox2.TransparencyKey = System.Drawing.Color.Empty;
            this.nyX_GroupBox2.Transparent = false;
            // 
            // download_button
            // 
            this.download_button.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.download_button.Colors = new CS_ClassLibraryTester.Bloom[0];
            this.download_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.download_button.Customization = "";
            this.download_button.Enabled = false;
            this.download_button.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.download_button.Image = null;
            this.download_button.Location = new System.Drawing.Point(3, 112);
            this.download_button.Name = "download_button";
            this.download_button.NoRounding = false;
            this.download_button.Size = new System.Drawing.Size(205, 27);
            this.download_button.TabIndex = 8;
            this.download_button.Text = "İndirme İşlemini Başlat";
            this.download_button.Transparent = false;
            this.download_button.Click += new System.EventHandler(this.Download_button_Click);
            // 
            // process_mb
            // 
            this.process_mb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.process_mb.Enabled = false;
            this.process_mb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.process_mb.ForeColor = System.Drawing.Color.White;
            this.process_mb.FormattingEnabled = true;
            this.process_mb.Location = new System.Drawing.Point(3, 83);
            this.process_mb.Name = "process_mb";
            this.process_mb.Size = new System.Drawing.Size(205, 23);
            this.process_mb.TabIndex = 7;
            this.process_mb.SelectedIndexChanged += new System.EventHandler(this.ComboBox6_SelectedIndexChanged);
            // 
            // islemci_isim
            // 
            this.islemci_isim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.islemci_isim.Enabled = false;
            this.islemci_isim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.islemci_isim.ForeColor = System.Drawing.Color.White;
            this.islemci_isim.FormattingEnabled = true;
            this.islemci_isim.Location = new System.Drawing.Point(3, 56);
            this.islemci_isim.Name = "islemci_isim";
            this.islemci_isim.Size = new System.Drawing.Size(205, 23);
            this.islemci_isim.TabIndex = 6;
            this.islemci_isim.SelectedIndexChanged += new System.EventHandler(this.ComboBox4_SelectedIndexChanged);
            // 
            // download_panel
            // 
            this.download_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.download_panel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.download_panel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.download_panel.ForeColor = System.Drawing.Color.White;
            this.download_panel.FormattingEnabled = true;
            this.download_panel.Location = new System.Drawing.Point(3, 27);
            this.download_panel.Name = "download_panel";
            this.download_panel.Size = new System.Drawing.Size(205, 23);
            this.download_panel.TabIndex = 5;
            this.download_panel.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // nyX_ProgressBar1
            // 
            this.nyX_ProgressBar1.Colors = new CS_ClassLibraryTester.Bloom[0];
            this.nyX_ProgressBar1.Customization = "";
            this.nyX_ProgressBar1.Font = new System.Drawing.Font("Verdana", 8F);
            this.nyX_ProgressBar1.Image = null;
            this.nyX_ProgressBar1.Location = new System.Drawing.Point(24, 324);
            this.nyX_ProgressBar1.Maximum = 100;
            this.nyX_ProgressBar1.Name = "nyX_ProgressBar1";
            this.nyX_ProgressBar1.NoRounding = false;
            this.nyX_ProgressBar1.Size = new System.Drawing.Size(501, 12);
            this.nyX_ProgressBar1.TabIndex = 7;
            this.nyX_ProgressBar1.Text = "nyX_ProgressBar1";
            this.nyX_ProgressBar1.Transparent = false;
            this.nyX_ProgressBar1.Value = 1;
            // 
            // materialDivider4
            // 
            this.materialDivider4.BackColor = System.Drawing.Color.SeaGreen;
            this.materialDivider4.Depth = 0;
            this.materialDivider4.Location = new System.Drawing.Point(531, 319);
            this.materialDivider4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider4.Name = "materialDivider4";
            this.materialDivider4.Size = new System.Drawing.Size(1, 21);
            this.materialDivider4.TabIndex = 6;
            this.materialDivider4.Text = "materialDivider4";
            // 
            // materialDivider3
            // 
            this.materialDivider3.BackColor = System.Drawing.Color.SeaGreen;
            this.materialDivider3.Depth = 0;
            this.materialDivider3.Location = new System.Drawing.Point(17, 319);
            this.materialDivider3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider3.Name = "materialDivider3";
            this.materialDivider3.Size = new System.Drawing.Size(1, 21);
            this.materialDivider3.TabIndex = 5;
            this.materialDivider3.Text = "materialDivider3";
            // 
            // materialDivider2
            // 
            this.materialDivider2.BackColor = System.Drawing.Color.SeaGreen;
            this.materialDivider2.Depth = 0;
            this.materialDivider2.Location = new System.Drawing.Point(18, 319);
            this.materialDivider2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider2.Name = "materialDivider2";
            this.materialDivider2.Size = new System.Drawing.Size(514, 1);
            this.materialDivider2.TabIndex = 4;
            this.materialDivider2.Text = "materialDivider2";
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.SeaGreen;
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(18, 339);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(514, 1);
            this.materialDivider1.TabIndex = 3;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // nyX_GroupBox1
            // 
            this.nyX_GroupBox1.Animated = true;
            this.nyX_GroupBox1.BorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.nyX_GroupBox1.Colors = new CS_ClassLibraryTester.Bloom[0];
            this.nyX_GroupBox1.Controls.Add(this.ozellikler_ici);
            this.nyX_GroupBox1.Controls.Add(this.arac_Ozellikler);
            this.nyX_GroupBox1.Controls.Add(this.araclar);
            this.nyX_GroupBox1.Controls.Add(this.diller);
            this.nyX_GroupBox1.Customization = "";
            this.nyX_GroupBox1.Font = new System.Drawing.Font("Arial", 9F);
            this.nyX_GroupBox1.Image = null;
            this.nyX_GroupBox1.Location = new System.Drawing.Point(12, 29);
            this.nyX_GroupBox1.Movable = true;
            this.nyX_GroupBox1.Name = "nyX_GroupBox1";
            this.nyX_GroupBox1.NoRounding = false;
            this.nyX_GroupBox1.Sizable = true;
            this.nyX_GroupBox1.Size = new System.Drawing.Size(211, 142);
            this.nyX_GroupBox1.SmartBounds = true;
            this.nyX_GroupBox1.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.nyX_GroupBox1.TabIndex = 2;
            this.nyX_GroupBox1.Text = "Dil ve Araç Seçim Paneli";
            this.nyX_GroupBox1.TransparencyKey = System.Drawing.Color.Empty;
            this.nyX_GroupBox1.Transparent = false;
            // 
            // ozellikler_ici
            // 
            this.ozellikler_ici.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ozellikler_ici.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ozellikler_ici.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ozellikler_ici.ForeColor = System.Drawing.Color.White;
            this.ozellikler_ici.FormattingEnabled = true;
            this.ozellikler_ici.Location = new System.Drawing.Point(3, 112);
            this.ozellikler_ici.Name = "ozellikler_ici";
            this.ozellikler_ici.Size = new System.Drawing.Size(205, 23);
            this.ozellikler_ici.TabIndex = 4;
            this.ozellikler_ici.SelectedIndexChanged += new System.EventHandler(this.ozellikler_ici_SelectedIndexChanged);
            // 
            // arac_Ozellikler
            // 
            this.arac_Ozellikler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.arac_Ozellikler.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.arac_Ozellikler.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.arac_Ozellikler.ForeColor = System.Drawing.Color.White;
            this.arac_Ozellikler.FormattingEnabled = true;
            this.arac_Ozellikler.Location = new System.Drawing.Point(3, 83);
            this.arac_Ozellikler.Name = "arac_Ozellikler";
            this.arac_Ozellikler.Size = new System.Drawing.Size(205, 23);
            this.arac_Ozellikler.TabIndex = 3;
            this.arac_Ozellikler.SelectedIndexChanged += new System.EventHandler(this.arac_Ozellikler_SelectedIndexChanged);
            // 
            // araclar
            // 
            this.araclar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.araclar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.araclar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.araclar.ForeColor = System.Drawing.Color.White;
            this.araclar.FormattingEnabled = true;
            this.araclar.Location = new System.Drawing.Point(3, 54);
            this.araclar.Name = "araclar";
            this.araclar.Size = new System.Drawing.Size(205, 23);
            this.araclar.TabIndex = 2;
            this.araclar.SelectedIndexChanged += new System.EventHandler(this.araclar_SelectedIndexChanged);
            // 
            // diller
            // 
            this.diller.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.diller.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.diller.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.diller.ForeColor = System.Drawing.Color.White;
            this.diller.FormattingEnabled = true;
            this.diller.Items.AddRange(new object[] {
            "C# Programlama Dili"});
            this.diller.Location = new System.Drawing.Point(3, 25);
            this.diller.Name = "diller";
            this.diller.Size = new System.Drawing.Size(205, 23);
            this.diller.TabIndex = 1;
            this.diller.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // nyX_ControlBox1
            // 
            this.nyX_ControlBox1.Colors = new CS_ClassLibraryTester.Bloom[0];
            this.nyX_ControlBox1.Customization = "";
            this.nyX_ControlBox1.Font = new System.Drawing.Font("Verdana", 8F);
            this.nyX_ControlBox1.Image = null;
            this.nyX_ControlBox1.Location = new System.Drawing.Point(1, 1);
            this.nyX_ControlBox1.Name = "nyX_ControlBox1";
            this.nyX_ControlBox1.NoRounding = false;
            this.nyX_ControlBox1.Size = new System.Drawing.Size(44, 23);
            this.nyX_ControlBox1.TabIndex = 0;
            this.nyX_ControlBox1.Text = "nyX_ControlBox1";
            this.nyX_ControlBox1.Transparent = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 354);
            this.Controls.Add(this.nyX_Theme1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.nyX_Theme1.ResumeLayout(false);
            this.nyX_Theme1.PerformLayout();
            this.nyX_GroupBox3.ResumeLayout(false);
            this.nyX_GroupBox2.ResumeLayout(false);
            this.nyX_GroupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private CS_ClassLibraryTester.NYX_Theme nyX_Theme1;
        private CS_ClassLibraryTester.NYX_ControlBox nyX_ControlBox1;
        private CS_ClassLibraryTester.NYX_GroupBox nyX_GroupBox1;
        private System.Windows.Forms.ComboBox araclar;
        private System.Windows.Forms.ComboBox diller;
        private CS_ClassLibraryTester.NYX_GroupBox nyX_GroupBox2;
        private CS_ClassLibraryTester.NYX_ProgressBar nyX_ProgressBar1;
        private MaterialSkin.Controls.MaterialDivider materialDivider4;
        private MaterialSkin.Controls.MaterialDivider materialDivider3;
        private MaterialSkin.Controls.MaterialDivider materialDivider2;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private CS_ClassLibraryTester.NYX_GroupBox nyX_GroupBox3;
        private System.Windows.Forms.RichTextBox console;
        private System.Windows.Forms.ComboBox process_mb;
        private System.Windows.Forms.ComboBox islemci_isim;
        private System.Windows.Forms.ComboBox download_panel;
        private System.Windows.Forms.ComboBox ozellikler_ici;
        private System.Windows.Forms.ComboBox arac_Ozellikler;
        private CS_ClassLibraryTester.NYX_Button download_button;
        private System.Windows.Forms.Label link;
    }
}


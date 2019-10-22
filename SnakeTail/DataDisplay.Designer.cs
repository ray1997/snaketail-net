namespace SnakeTail
{
    partial class DataDisplay
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataDisplay));
            this.panel1 = new System.Windows.Forms.Panel();
            this.mainMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.settingState = new System.Windows.Forms.ToolStripMenuItem();
            this.settingPanel = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.offerNameKiller = new System.Windows.Forms.Label();
            this.killer_type = new System.Windows.Forms.Label();
            this.killer_preview = new System.Windows.Forms.PictureBox();
            this.map_subrealm = new System.Windows.Forms.Label();
            this.mapRealm = new System.Windows.Forms.Label();
            this.mapPreview = new System.Windows.Forms.PictureBox();
            this.chars = new System.Windows.Forms.ImageList(this.components);
            this.maps = new System.Windows.Forms.ImageList(this.components);
            this.panel1.SuspendLayout();
            this.mainMenu.SuspendLayout();
            this.settingPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.killer_preview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mapPreview)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.ContextMenuStrip = this.mainMenu;
            this.panel1.Controls.Add(this.settingPanel);
            this.panel1.Controls.Add(this.offerNameKiller);
            this.panel1.Controls.Add(this.killer_type);
            this.panel1.Controls.Add(this.killer_preview);
            this.panel1.Controls.Add(this.map_subrealm);
            this.panel1.Controls.Add(this.mapRealm);
            this.panel1.Controls.Add(this.mapPreview);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(405, 213);
            this.panel1.TabIndex = 0;
            // 
            // mainMenu
            // 
            this.mainMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingState});
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(132, 28);
            // 
            // settingState
            // 
            this.settingState.CheckOnClick = true;
            this.settingState.Name = "settingState";
            this.settingState.Size = new System.Drawing.Size(131, 24);
            this.settingState.Text = "Settings";
            this.settingState.CheckedChanged += new System.EventHandler(this.ToolStripMenuItem1_CheckedChanged);
            // 
            // settingPanel
            // 
            this.settingPanel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.settingPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.settingPanel.Controls.Add(this.button2);
            this.settingPanel.Controls.Add(this.label5);
            this.settingPanel.Controls.Add(this.checkBox2);
            this.settingPanel.Controls.Add(this.checkBox1);
            this.settingPanel.Controls.Add(this.button1);
            this.settingPanel.Controls.Add(this.label2);
            this.settingPanel.Controls.Add(this.label1);
            this.settingPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.settingPanel.Location = new System.Drawing.Point(201, 0);
            this.settingPanel.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.settingPanel.Name = "settingPanel";
            this.settingPanel.Size = new System.Drawing.Size(204, 213);
            this.settingPanel.TabIndex = 0;
            this.settingPanel.Visible = false;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.button2.Location = new System.Drawing.Point(136, 89);
            this.button2.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(52, 31);
            this.button2.TabIndex = 6;
            this.button2.Text = "Set";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 96);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 19);
            this.label5.TabIndex = 5;
            this.label5.Text = "Transparent color";
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.checkBox2.Location = new System.Drawing.Point(12, 159);
            this.checkBox2.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(87, 23);
            this.checkBox2.TabIndex = 4;
            this.checkBox2.Text = "top most";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.CheckBox2_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.checkBox1.Location = new System.Drawing.Point(12, 128);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(91, 23);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "Show title";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.button1.Location = new System.Drawing.Point(136, 50);
            this.button1.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(52, 35);
            this.button1.TabIndex = 2;
            this.button1.Text = "Set";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 59);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Background";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Settings";
            // 
            // offerNameKiller
            // 
            this.offerNameKiller.AutoSize = true;
            this.offerNameKiller.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.offerNameKiller.Location = new System.Drawing.Point(94, 129);
            this.offerNameKiller.Name = "offerNameKiller";
            this.offerNameKiller.Size = new System.Drawing.Size(0, 32);
            this.offerNameKiller.TabIndex = 6;
            // 
            // killer_type
            // 
            this.killer_type.AutoSize = true;
            this.killer_type.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.killer_type.Location = new System.Drawing.Point(94, 97);
            this.killer_type.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.killer_type.Name = "killer_type";
            this.killer_type.Size = new System.Drawing.Size(229, 32);
            this.killer_type.TabIndex = 5;
            this.killer_type.Text = "Killer is... not nea..";
            // 
            // killer_preview
            // 
            this.killer_preview.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.killer_preview.Image = ((System.Drawing.Image)(resources.GetObject("killer_preview.Image")));
            this.killer_preview.Location = new System.Drawing.Point(6, 97);
            this.killer_preview.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.killer_preview.Name = "killer_preview";
            this.killer_preview.Size = new System.Drawing.Size(76, 100);
            this.killer_preview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.killer_preview.TabIndex = 4;
            this.killer_preview.TabStop = false;
            // 
            // map_subrealm
            // 
            this.map_subrealm.AutoSize = true;
            this.map_subrealm.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.map_subrealm.Location = new System.Drawing.Point(94, 47);
            this.map_subrealm.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.map_subrealm.Name = "map_subrealm";
            this.map_subrealm.Size = new System.Drawing.Size(124, 32);
            this.map_subrealm.TabIndex = 3;
            this.map_subrealm.Text = "we\'ll see..";
            // 
            // mapRealm
            // 
            this.mapRealm.AutoSize = true;
            this.mapRealm.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mapRealm.Location = new System.Drawing.Point(94, 9);
            this.mapRealm.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.mapRealm.Name = "mapRealm";
            this.mapRealm.Size = new System.Drawing.Size(257, 32);
            this.mapRealm.TabIndex = 2;
            this.mapRealm.Text = "It could be any map..";
            // 
            // mapPreview
            // 
            this.mapPreview.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mapPreview.Image = ((System.Drawing.Image)(resources.GetObject("mapPreview.Image")));
            this.mapPreview.Location = new System.Drawing.Point(6, 7);
            this.mapPreview.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.mapPreview.Name = "mapPreview";
            this.mapPreview.Size = new System.Drawing.Size(76, 72);
            this.mapPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.mapPreview.TabIndex = 1;
            this.mapPreview.TabStop = false;
            // 
            // chars
            // 
            this.chars.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("chars.ImageStream")));
            this.chars.TransparentColor = System.Drawing.Color.Transparent;
            this.chars.Images.SetKeyName(0, "BP_Slasher_Character_00_C_0.png");
            this.chars.Images.SetKeyName(1, "BP_Slasher_Character_01_C_0.png");
            this.chars.Images.SetKeyName(2, "BP_Slasher_Character_02_C_0.png");
            this.chars.Images.SetKeyName(3, "BP_Slasher_Character_03_C_0.png");
            this.chars.Images.SetKeyName(4, "BP_Slasher_Character_04_C_0.png");
            this.chars.Images.SetKeyName(5, "BP_Slasher_Character_05_C_0.png");
            this.chars.Images.SetKeyName(6, "BP_Slasher_Character_06_C_0.png");
            this.chars.Images.SetKeyName(7, "BP_Slasher_Character_07_C_0.png");
            this.chars.Images.SetKeyName(8, "BP_Slasher_Character_08_C_0.png");
            this.chars.Images.SetKeyName(9, "BP_Slasher_Character_09_C_0.png");
            this.chars.Images.SetKeyName(10, "BP_Slasher_Character_10_C_0.png");
            this.chars.Images.SetKeyName(11, "BP_Slasher_Character_11_C_0.png");
            this.chars.Images.SetKeyName(12, "BP_Slasher_Character_12_C_0.png");
            this.chars.Images.SetKeyName(13, "BP_Slasher_Character_13_C_0.png");
            this.chars.Images.SetKeyName(14, "BP_Slasher_Character_14_C_0.png");
            this.chars.Images.SetKeyName(15, "BP_Slasher_Character_15_C_0.png");
            this.chars.Images.SetKeyName(16, "BP_Slasher_Character_16_C_0.png");
            this.chars.Images.SetKeyName(17, "BP_Slasher_Character_17_C_0.png");
            // 
            // maps
            // 
            this.maps.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("maps.ImageStream")));
            this.maps.TransparentColor = System.Drawing.Color.Transparent;
            this.maps.Images.SetKeyName(0, "iconMap_Asy_Asylum.png");
            this.maps.Images.SetKeyName(1, "iconMap_Asy_Chapel.png");
            this.maps.Images.SetKeyName(2, "iconMap_Brl_MaHouse.png");
            this.maps.Images.SetKeyName(3, "iconMap_Brl_Temple.png");
            this.maps.Images.SetKeyName(4, "iconMap_Eng_ElmStreet.png");
            this.maps.Images.SetKeyName(5, "iconMap_Eng_ElmStreet02.png");
            this.maps.Images.SetKeyName(6, "iconMap_Eng_ElmStreet03.png");
            this.maps.Images.SetKeyName(7, "iconMap_Eng_ElmStreet04.png");
            this.maps.Images.SetKeyName(8, "iconMap_Eng_ElmStreet05.png");
            this.maps.Images.SetKeyName(9, "iconMap_Fin_TheGame.png");
            this.maps.Images.SetKeyName(10, "iconMap_Frm_Barn.png");
            this.maps.Images.SetKeyName(11, "iconMap_Frm_Cornfield.png");
            this.maps.Images.SetKeyName(12, "iconMap_Frm_Farmhouse.png");
            this.maps.Images.SetKeyName(13, "iconMap_Frm_Silo.png");
            this.maps.Images.SetKeyName(14, "iconMap_Frm_Slaughterhouse.png");
            this.maps.Images.SetKeyName(15, "iconMap_Hos_Treatment.png");
            this.maps.Images.SetKeyName(16, "iconMap_Hti_Manor.png");
            this.maps.Images.SetKeyName(17, "iconMap_Ind_CoalTower.png");
            this.maps.Images.SetKeyName(18, "iconMap_Ind_Forest.png");
            this.maps.Images.SetKeyName(19, "iconMap_Ind_Foundry.png");
            this.maps.Images.SetKeyName(20, "iconMap_Ind_Mine.png");
            this.maps.Images.SetKeyName(21, "iconMap_Ind_Storehouse.png");
            this.maps.Images.SetKeyName(22, "iconMap_Jnk_Garage.png");
            this.maps.Images.SetKeyName(23, "iconMap_Jnk_GasStation.png");
            this.maps.Images.SetKeyName(24, "iconMap_Jnk_Lodge.png");
            this.maps.Images.SetKeyName(25, "iconMap_Jnk_Office.png");
            this.maps.Images.SetKeyName(26, "iconMap_Jnk_Scrapyard.png");
            this.maps.Images.SetKeyName(27, "iconMap_Kny_Cottage.png");
            this.maps.Images.SetKeyName(28, "iconMap_Qat_Lab.png");
            this.maps.Images.SetKeyName(29, "iconMap_Sub_Street.png");
            this.maps.Images.SetKeyName(30, "iconMap_Swp_GrimPantry.png");
            this.maps.Images.SetKeyName(31, "iconMap_Swp_PaleRose.png");
            // 
            // DataDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 213);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "DataDisplay";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DataDisplay_FormClosed);
            this.Shown += new System.EventHandler(this.DataDisplay_Shown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.mainMenu.ResumeLayout(false);
            this.settingPanel.ResumeLayout(false);
            this.settingPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.killer_preview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mapPreview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ContextMenuStrip mainMenu;
        private System.Windows.Forms.Panel settingPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem settingState;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.PictureBox mapPreview;
        private System.Windows.Forms.Label mapRealm;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Label map_subrealm;
        private System.Windows.Forms.Label killer_type;
        private System.Windows.Forms.PictureBox killer_preview;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ImageList chars;
        private System.Windows.Forms.ImageList maps;
        private System.Windows.Forms.Label offerNameKiller;
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SnakeTail
{
    public partial class DataDisplay : Form
    {
        private static DataDisplay _displayInstance = null;
        public static DataDisplay DisplayInstance
        {
            get
            {
                if (_displayInstance is null)
                {
                    _displayInstance = new DataDisplay();
                }
                return _displayInstance;
            }
            set
            {
                _displayInstance = value;
            }
        }

        private static bool _open;
        public static bool IsOpen
        {
            get => _open;
            private set => _open = value;
        }

        public DataDisplay()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //Set background color
            using (ColorDialog color = new ColorDialog
            {
                Color = this.BackColor
            })
            {
                var result = color.ShowDialog();
                if (result == DialogResult.OK)
                {
                    this.BackColor = color.Color;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Set foreground color
            using (ColorDialog color = new ColorDialog
            {
                Color = this.ForeColor
            })
            {
                var result = color.ShowDialog();
                if (result == DialogResult.OK)
                {
                    this.ForeColor = color.Color;
                }
            }
        }
        private void ToolStripMenuItem1_CheckedChanged(object sender, EventArgs e)
        {
            settingPanel.Visible = settingState.Checked;
        }

        private void DataDisplay_Shown(object sender, EventArgs e)
            => IsOpen = true;

        private void DataDisplay_FormClosed(object sender, FormClosedEventArgs e)
            => IsOpen = false;

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            this.ControlBox = checkBox1.Checked;
        }

        private void CheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            this.TopMost = checkBox2.Checked;
        }

        public void DisplayData(string line)
        {
            System.Diagnostics.Debug.WriteLine("Processing line: " + line);
            //Processing line of texts
            //Offering
            if (line.Contains("GameFlow: OnlineContextComponent::SendOfferingsDataToUI"))
            {
                //Reset match info
                if (!offerNameKiller.Text.StartsWith("w/ "))
                {
                    SetText(mapRealm, "Loading...");
                    SetText(map_subrealm, "Loading...");
                    SetKillerPreview(killer_preview, 0);
                    SetText(killer_type, "Definitely not nea...");
                    SetText(offerNameKiller, "");
                }
                //Offering
                if (line.Contains("Mori"))
                {
                    if (line.Contains("Ebony"))
                        SetText(offerNameKiller, "w/ Ebony Mori");
                    else if (line.Contains("Ivory"))
                        SetText(offerNameKiller, "w/ Ivory Mori");
                    else if (line.Contains("Cypress"))
                        SetText(offerNameKiller, "w/ Cypress Mori");
                }
            }
            //Map info
            else if (line.Contains("ProceduralLevelGeneration: InitLevel: Theme: "))
            {
                UpdateMapDisplay(line);
            }
            else if (line.Contains("BP_Slasher_Character_"))
            {
                UpdateKillerInfo(line);
            }
        }

        public void UpdateMapDisplay(string fullLog)
        {
            //Trim all text to Map: 
            fullLog = fullLog.Substring(fullLog.IndexOf("Map: ") + 5);
            //Trim everything after the first space
            fullLog = fullLog.Substring(0, fullLog.IndexOf(" "));
            //The only thing left now should be map id.
            var mapinfo = fullLog.Split('_');
            //Map theme
            switch (mapinfo[0])
            {
                case "Ind": SetText(mapRealm, "The MacMillan Estate"); break;
                case "Jnk": SetText(mapRealm, "Autohaven Wreckers"); break;
                case "Frm": SetText(mapRealm, "Coldwind Farm"); break;
                case "Asy": SetText(mapRealm, "Crotus Prenn Asylum"); break;
                case "Sub": SetText(mapRealm, "Haddonfield"); break;
                case "Swp": SetText(mapRealm, "Backwater Swamp"); break;
                case "Hos": SetText(mapRealm, "Léry's Memorial Institute"); break;
                case "Brl": SetText(mapRealm, "Red Forest"); break;
                case "Eng": SetText(mapRealm, "Springwood"); break;
                case "Fin": SetText(mapRealm, "Finland"); break;
                case "Hti": SetText(mapRealm, "Yamaoka Estate"); break;
                case "Kny": SetText(mapRealm, "Ormond"); break;
                case "Qat": SetText(mapRealm, "Hawkins National Laboratory"); break;
            }
            //Sub realm
            switch (mapinfo[1])
            {
                case "CoalTower": SetText(map_subrealm, "Coal Tower"); break;
                case "Storehouse": SetText(map_subrealm, "Groaning Storehouse"); break;
                case "Foundry": SetText(map_subrealm, "Ironworks of Misery"); break;
                case "Forest": SetText(map_subrealm, "Shelter Woods"); break;
                case "Mine": SetText(map_subrealm, "Suffocation Pit"); break;

                case "Office": SetText(map_subrealm, "Azarov's Resting Place"); break;
                case "Lodge": SetText(map_subrealm, "Blood Lodge"); break;
                case "GasStation": SetText(map_subrealm, "Gas Heaven"); break;
                case "Garage": SetText(map_subrealm, "Wretched Shop"); break;
                case "Scrapyard": SetText(map_subrealm, "Wreckers' Yard"); break;

                case "Barn": SetText(map_subrealm, "Fractured Cow Shed"); break;
                case "Farmhouse": SetText(map_subrealm, "The Thompson House"); break;
                case "Silo": SetText(map_subrealm, "Torment Creek"); break;
                case "Slaughterhouse": SetText(map_subrealm, "Rancid Abattoir"); break;
                case "Cornfield": SetText(map_subrealm, "Rotten Field"); break;

                case "Asylum": SetText(map_subrealm, "Disturbed Ward"); break;
                case "Chapel": SetText(map_subrealm, "Father Campbell's Chapel"); break;

                case "Palerose": SetText(map_subrealm, "The Pale Rose"); break;
                case "GrimPantry": SetText(map_subrealm, "Grim Pantry"); break;

                case "Threatment": SetText(map_subrealm, "Treatment Theatre"); break;

                case "MaHouse": SetText(map_subrealm, "Mother's Dwelling"); break;
                case "Temple": SetText(map_subrealm, "The Temple of Purgation"); break;

                case "Street":
                    if (mapinfo[0] == "Sub")
                        SetText(map_subrealm, "Lampkin Lane");
                    else if (mapinfo[0] == "Eng")
                        SetText(map_subrealm, $"Badham Preschool {IDIndexToRoman(mapinfo[2])}");
                    break;
                case "Hideout": SetText(map_subrealm, "The Game"); break;

                case "Manor": SetText(map_subrealm, "Family Residence"); break;

                case "Cottage": SetText(map_subrealm, "Mount Ormond Resort"); break;

                case "Lab": SetText(map_subrealm, "The Underground Complex"); break;
            }

            //Icon
            switch (mapinfo[1])
            {
                case "Asylum": SetMapPreview(mapPreview, 0); break;
                case "Chapel": SetMapPreview(mapPreview, 1); break;

                case "MaHouse": SetMapPreview(mapPreview, 2); break;
                case "Temple": SetMapPreview(mapPreview, 3); break;

                case "Street":
                    if (mapinfo[0] == "Sub") SetMapPreview(mapPreview, 29);
                    else if (mapinfo[0] == "Eng") SetMapPreview(mapPreview, 3 + int.Parse(mapinfo[2].Replace("0", ""))); break;

                case "Hideout": SetMapPreview(mapPreview, 9); break;

                case "Barn": SetMapPreview(mapPreview, 10); break;
                case "Cornfield": SetMapPreview(mapPreview, 11); break;
                case "Farmhouse": SetMapPreview(mapPreview, 12); break;
                case "Silo": SetMapPreview(mapPreview, 13); break;
                case "Slaughterhouse": SetMapPreview(mapPreview, 14); break;

                case "Threatment": SetMapPreview(mapPreview, 15); break;

                case "Manor": SetMapPreview(mapPreview, 16); break;

                case "CoalTower": SetMapPreview(mapPreview, 17); break;
                case "Forest": SetMapPreview(mapPreview, 18); break;
                case "Foundry": SetMapPreview(mapPreview, 19); break;
                case "Mine": SetMapPreview(mapPreview, 20); break;
                case "Storehouse": SetMapPreview(mapPreview, 21); break;

                case "Garage": SetMapPreview(mapPreview, 22); break;
                case "GasStation": SetMapPreview(mapPreview, 23); break;
                case "Lodge": SetMapPreview(mapPreview, 24); break;
                case "Office": SetMapPreview(mapPreview, 25); break;
                case "Scrapyard": SetMapPreview(mapPreview, 26); break;

                case "Cottage": SetMapPreview(mapPreview, 27); break;

                case "Lab": SetMapPreview(mapPreview, 28); break;

                case "GrimPantry": SetMapPreview(mapPreview, 30); break;
                case "Palerose": SetMapPreview(mapPreview, 31); break;

            }
        }
        public string IDIndexToRoman(string input)
        {
            switch (input)
            {
                case "01":
                    return "I";
                case "02":
                    return "II";
                case "03":
                    return "III";
                case "04":
                    return "IV";
                case "05":
                    return "V";
                default:
                    return "";
            }
        }

        public void UpdateKillerInfo(string fullLog)
        {
            //Take only last section
            fullLog = fullLog.Substring(fullLog.LastIndexOf(" ") + 1);
            if (!fullLog.StartsWith("BP_Slasher"))
                return;
            fullLog = fullLog.Replace("BP_Slasher_Character_", "");
            fullLog = fullLog.Replace("_C_0", "");
            //Name
            switch (fullLog)
            {
                case "01": SetText(killer_type, "The Trapper"); break;
                case "02": SetText(killer_type, "The Wraith"); break;
                case "03": SetText(killer_type, "The Hillbilly"); break;
                case "04": SetText(killer_type, "The Nurse"); break;
                case "05": SetText(killer_type, "The Shape"); break;
                case "06": SetText(killer_type, "The Hag"); break;
                case "07": SetText(killer_type, "The Doctor"); break;
                case "08": SetText(killer_type, "The Huntress"); break;
                case "09": SetText(killer_type, "The Cannibal"); break;
                case "10": SetText(killer_type, "The Nightmare"); break;
                case "11": SetText(killer_type, "The Pig"); break;
                case "12": SetText(killer_type, "The Clown"); break;
                case "13": SetText(killer_type, "The Spirit"); break;
                case "14": SetText(killer_type, "The Legion"); break;
                case "15": SetText(killer_type, "The Plague"); break;
                case "16": SetText(killer_type, "The Ghost Face"); break;
                case "17": SetText(killer_type, "The Demogorgon"); break;
            }
            //Icon
            SetKillerPreview(killer_preview, int.Parse(fullLog.StartsWith("0") ? fullLog.Replace("0", "") : fullLog));
        }

        delegate void SetTextCallback(Control item, string text);

        private void SetText(Control set, string text)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (this.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                this.Invoke(d, new object[] {set, text });
            }
            else
            {
                set.Text = text;
            }
        }

        delegate void SetMapPreviewCallback(PictureBox pic, int mapID);

        private void SetMapPreview(PictureBox pic, int id)
        {
            if (this.InvokeRequired)
            {
                SetMapPreviewCallback m = new SetMapPreviewCallback(SetMapPreview);
                this.Invoke(m, new object[] { pic, id });
            }
            else
            {
                pic.Image = maps.Images[id];
            }
        }

        delegate void SetKillerPreviewCallback(PictureBox pic, int mapID);

        private void SetKillerPreview(PictureBox pic, int id)
        {
            if (this.InvokeRequired)
            {
                SetMapPreviewCallback m = new SetMapPreviewCallback(SetKillerPreview);
                this.Invoke(m, new object[] { pic, id });
            }
            else
            {
                pic.Image = chars.Images[id];
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            double converted = Convert.ToDouble(trackBar1.Value);
            converted /= 100;
            this.Opacity = converted;
        }

    }
}

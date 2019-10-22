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
                Color = panel1.BackColor
            })
            {
                var result = color.ShowDialog();
                if (result == DialogResult.OK)
                {
                    panel1.BackColor = color.Color;
                }
            }                
        }
        
        private void Button2_Click(object sender, EventArgs e)
        {
            using (ColorDialog color = new ColorDialog
            {
                Color = this.TransparencyKey
            })
            {
                var result = color.ShowDialog();
                if (result == DialogResult.OK)
                {
                    this.TransparencyKey = color.Color;
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
            //Processing line of texts
            //Offering
            if (line.Contains("GameFlow: OnlineContextComponent::SendOfferingsDataToUI"))
            {
                //Offering
                if (line.Contains("mori"))
                {
                    if (line.Contains("ebony"))
                        offerNameKiller.Text = "w/ Ebony Mori";
                    else if (line.Contains("ivory"))
                        offerNameKiller.Text = "w/ Ivory Mori";
                    else if (line.Contains("cypress"))
                        offerNameKiller.Text = "w/ Cypress Mori";
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
                case "Ind": mapRealm.Text = "The MacMillan Estate"; break;
                case "Jnk": mapRealm.Text = "Autohaven Wreckers"; break;
                case "Frm": mapRealm.Text = "Coldwind Farm"; break;
                case "Asy": mapRealm.Text = "Crotus Prenn Asylum"; break;
                case "Sub": mapRealm.Text = "Haddonfield"; break;
                case "Swp": mapRealm.Text = "Backwater Swamp"; break;
                case "Hos": mapRealm.Text = "Léry's Memorial Institute"; break;
                case "Brl": mapRealm.Text = "Red Forest"; break;
                case "Eng": mapRealm.Text = "Springwood"; break;
                case "Fin": mapRealm.Text = "Finland"; break;
                case "Hti": mapRealm.Text = "Yamaoka Estate"; break;
                case "Kny": mapRealm.Text = "Ormond"; break;
                case "Qat": mapRealm.Text = "Hawkins National Laboratory"; break;
            }
            //Sub realm
            switch (mapinfo[1])
            {
                case "CoalTower":
                    map_subrealm.Text = "Coal Tower";
                    break;
                case "Storehouse": map_subrealm.Text = "Groaning Storehouse"; break;
                case "Foundry": map_subrealm.Text = "Ironworks of Misery"; break;
                case "Forest": map_subrealm.Text = "Shelter Woods"; break;
                case "Mine": map_subrealm.Text = "Suffocation Pit"; break;

                case "Office": map_subrealm.Text = "Azarov's Resting Place"; break;
                case "Lodge": map_subrealm.Text = "Blood Lodge"; break;
                case "GasStation": map_subrealm.Text = "Gas Heaven"; break;
                case "Garage": map_subrealm.Text = "Wretched Shop"; break;
                case "Scrapyard": map_subrealm.Text = "Wreckers' Yard"; break;

                case "Barn": map_subrealm.Text = "Fractured Cow Shed"; break;
                case "Farmhouse": map_subrealm.Text = "The Thompson House"; break;
                case "Silo": map_subrealm.Text = "Torment Creek"; break;
                case "Slaughterhouse": map_subrealm.Text = "Rancid Abattoir"; break;
                case "Cornfield": map_subrealm.Text = "Rotten Field"; break;

                case "Asylum": map_subrealm.Text = "Disturbed Ward"; break;
                case "Chapel": map_subrealm.Text = "Father Campbell's Chapel"; break;

                case "Palerose": map_subrealm.Text = "The Pale Rose"; break;
                case "GrimPantry": map_subrealm.Text = "Grim Pantry"; break;

                case "Threatment": map_subrealm.Text = "Treatment Theatre"; break;

                case "MaHouse": map_subrealm.Text = "Mother's Dwelling"; break;
                case "Temple": map_subrealm.Text = "The Temple of Purgation"; break;

                case "Street":
                    if (mapRealm.Text == "Sub")
                        map_subrealm.Text = "Lampkin Lane";
                    else if (mapRealm.Text == "Eng")
                        map_subrealm.Text = $"Badham Preschool {IDIndexToRoman(mapinfo[2])}";
                    break;
                case "Hideout": map_subrealm.Text = "The Game"; break;

                case "Manor": map_subrealm.Text = "Family Residence"; break;

                case "Cottage": map_subrealm.Text = "Mount Ormond Resort"; break;

                case "Lab": map_subrealm.Text = "The Underground Complex"; break;
            }

            //Icon
            switch (mapinfo[1])
            {
                case "Asylum": mapPreview.Image = maps.Images[0]; break;
                case "Chapel": mapPreview.Image = maps.Images[1]; break;

                case "MaHouse": mapPreview.Image = maps.Images[2]; break;
                case "Temple": mapPreview.Image = maps.Images[3]; break;

                case "Street":
                    if (mapRealm.Text == "Sub") mapPreview.Image = maps.Images[29];
                    else if (mapRealm.Text == "Eng") mapPreview.Image = maps.Images[3 + int.Parse(mapinfo[2])]; break;
                    //map_subrealm.Text = $"Badham Preschool {IDIndexToRoman(mapinfo[2])}";

                case "Hideout": mapPreview.Image = maps.Images[9]; break;

                case "Barn": mapPreview.Image = maps.Images[10]; break;
                case "Cornfield": mapPreview.Image = maps.Images[11]; break;
                case "Farmhouse": mapPreview.Image = maps.Images[12]; break;
                case "Silo": mapPreview.Image = maps.Images[13]; break;
                case "Slaughterhouse": mapPreview.Image = maps.Images[14]; break;

                case "Threatment": mapPreview.Image = maps.Images[15]; break;

                case "Manor": mapPreview.Image = maps.Images[16]; break;

                case "CoalTower": mapPreview.Image = maps.Images[17]; break;
                case "Forest": mapPreview.Image = maps.Images[18]; break;
                case "Foundry": mapPreview.Image = maps.Images[19]; break;
                case "Mine": mapPreview.Image = maps.Images[20]; break;
                case "Storehouse": mapPreview.Image = maps.Images[21]; break;

                case "Garage": mapPreview.Image = maps.Images[22]; break;
                case "GasStation": mapPreview.Image = maps.Images[23]; break;
                case "Lodge": mapPreview.Image = maps.Images[24]; break;
                case "Office": mapPreview.Image = maps.Images[25]; break;
                case "Scrapyard": mapPreview.Image = maps.Images[26]; break;

                case "Cottage": mapPreview.Image = maps.Images[27]; break;

                case "Lab": mapPreview.Image = maps.Images[28]; break;

                case "Palerose": mapPreview.Image = maps.Images[30]; break;
                case "GrimPantry": mapPreview.Image = maps.Images[31]; break;

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

        public void UpdateKillerInfo(string fullLog, out string name)
        {
            name = "";
            //Take only last section
            fullLog = fullLog.Substring(fullLog.LastIndexOf(" ") + 1);
            fullLog = fullLog.Replace("BP_Slasher_Character_", "");
            fullLog = fullLog.Replace("_C_0", "");
            //Name
            switch (fullLog)
            {
                case "01": killer_type.Text = "The Trapper"; break;
                case "02": killer_type.Text = "The Wraith"; break;
                case "03": killer_type.Text = "The Hillbilly"; break;
                case "04": killer_type.Text = "The Nurse"; break;
                case "05": killer_type.Text = "The Shape"; break;
                case "06": killer_type.Text = "The Hag"; break;
                case "07": killer_type.Text = "The Doctor"; break;
                case "08": killer_type.Text = "The Huntress"; break;
                case "09": killer_type.Text = "The Cannibal"; break;
                case "10": killer_type.Text = "The Nightmare"; break;
                case "11": killer_type.Text = "The Pig"; break;
                case "12": killer_type.Text = "The Clown"; break;
                case "13": killer_type.Text = "The Spirit"; break;
                case "14": killer_type.Text = "The Legion"; break;
                case "15": killer_type.Text = "The Plague"; break;
                case "16": killer_type.Text = "The Ghost Face"; break;
                case "17": killer_type.Text = "The Demogorgon"; break;
            }
            //Icon
            killer_preview.Image = chars.Images[int.Parse(fullLog)];
        }
    }
}

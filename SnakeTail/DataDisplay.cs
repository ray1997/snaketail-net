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

        }
    }
}

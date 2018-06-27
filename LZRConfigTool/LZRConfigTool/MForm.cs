using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LZRConfigTool
{
    public partial class MForm : Form
    {
        private const int LZR_DETECT_CURTAIN_DEF = 9;

        private const int LZR_IMMUNITY_MIN = 1;
        private const int LZR_IMMUNITY_MAX = 8;
        private const int LZR_IMMUNITY_DEFLT = 3;
        private const int LZR_
        


        public MForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBoxFieldWidth_TextChanged(object sender, EventArgs e)
        {
            //if(this.textBoxFieldWidth.Text
        }

        private void MForm_Load(object sender, EventArgs e)
        {
            // This is for GUI Initialization
            this.labelDevConnect.Text = "";
            this.labelFileCheck.Text = "";

            this.buttonWriteFile.Enabled = false;

            this.numericUpDownFieldWidth.Minimum = 0;
            this.numericUpDownFieldWidth.Maximum = 5;
            this.numericUpDownFieldWidth.DecimalPlaces = 1;
            this.numericUpDownFieldWidth.Increment = 0.1M;
            this.numericUpDownFieldWidth.Value = 5;

            this.numericUpDownFieldHeight.Minimum = 0;
            this.numericUpDownFieldHeight.Maximum = 5;
            this.numericUpDownFieldHeight.DecimalPlaces = 1;
            this.numericUpDownFieldHeight.Increment = 0.1M;
            this.numericUpDownFieldHeight.Value = 5;

            this.comboBoxActiveDetectCurtains.Items.Add(0);
            this.comboBoxActiveDetectCurtains.Items.Add(1);
            this.comboBoxActiveDetectCurtains.Items.Add(2);
            this.comboBoxActiveDetectCurtains.Items.Add(9);
            this.comboBoxActiveDetectCurtains.SelectedItem = 9;
            this.comboBoxActiveDetectCurtains.DropDownStyle = ComboBoxStyle.DropDownList;

            for (int i = LZR_IMMUNITY_MIN; i <= LZR_IMMUNITY_MAX; i++)
            {
                this.comboBoxImmunityFilter.Items.Add(i);
            }
            this.comboBoxImmunityFilter.SelectedItem = 3;


        }
    }
}

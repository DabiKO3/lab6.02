using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab6._02
{
    public partial class Form1 : Form
    {

        private IPerson selectedPerson;
        public Form1()
        {
            InitializeComponent();

            comboBoxPerson.Items.Add("Italian");
            comboBoxPerson.Items.Add("Ukrainian");
            comboBoxPerson.SelectedIndex = 0; 
            comboBoxPerson.SelectedIndexChanged += comboBoxPerson_SelectedIndexChanged;

            selectedPerson = new Italian(); 
        }

        private void btnPrintCountryName_Click(object sender, EventArgs e)
        {
            selectedPerson?.PrintCountryName();
        }

        private void btnSpeak_Click(object sender, EventArgs e)
        {
            selectedPerson?.Speak();
        }

        private void comboBoxPerson_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxPerson.SelectedItem.ToString())
            {
                case "Italian":
                    selectedPerson = new Italian();
                    break;
                case "Ukrainian":
                    selectedPerson = new Ukrainian();
                    break;
            }
        }
    }
}

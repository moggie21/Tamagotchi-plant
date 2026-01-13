using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tamagotchi
{
    public partial class PlantNameForm : Form
    {
        public string PlantName => nameTextBox.Text.Trim();

        public PlantNameForm()
        {
            InitializeComponent();

            nameTextBox.TextChanged += (s, e) =>
            {
                okButton.Enabled = !string.IsNullOrWhiteSpace(nameTextBox.Text);
            };
            okButton.Enabled = false;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(PlantName))
            {
                DialogResult = DialogResult.OK;
                Close();
            }

        }
    }
}

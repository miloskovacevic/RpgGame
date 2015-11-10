using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RpgGameApp
{
    public partial class FormCharacterCreator : Form
    {
        public FormCharacterCreator()
        {
            InitializeComponent();
        }

        private void Btn_SaveCharacter_Click(object sender, EventArgs e)
        {
            string output = string.Empty;
            output += "Name: " + Txt_CharacterName.Text;
            output += "\nGender: " +
                (string)(this.Rdo_GenderMale.Checked ? "Male" : "Female");
            output += "\nClass: " + Cbo_CharacterClass.Text;

            Txt_CharacterName.Text = string.Empty;
            Rdo_GenderMale.Checked = false;
            Rdo_GenderFemale.Checked = false;
            Cbo_CharacterClass.Text = string.Empty;
            MessageBox.Show(output);
        }
    }
}

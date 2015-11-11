using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RpgGameApp.CharacterClasses;

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
            //make sure nothing is empty
            if (string.IsNullOrEmpty(Txt_CharacterName.Text) || Txt_CharacterName.Text[0] == ' ')
            {
                MessageBox.Show("You must name your character! Names cannot begin with spaces...");
                return;
            }

            if (this.Rdo_GenderMale.Checked == false && this.Rdo_GenderFemale.Checked == false)
            {
                MessageBox.Show("You need to select gender mothafuckaaa!");
                return;
            }

            string gender = (string)(this.Rdo_GenderMale.Checked ? "Male" : "Female");

            //provjera koju klasu smo zabrali...
            if(string.IsNullOrEmpty(Cbo_CharacterClass.Text))
            {
                MessageBox.Show("Please select class of player eg. Lumberjacck, Mage...");
                return;
            }

            string name = Txt_CharacterName.Text;
            EntityGender eGender ;

            if(this.Rdo_GenderMale.Checked)
            {
                eGender = EntityGender.Male;
            }
            else
            {
                eGender = EntityGender.Female;
            }

            Mage player1 = new Mage(name, eGender);
            MessageBox.Show(String.Format("Player 1 created : {0}, a {1}, Named: {2}", player1.GetType().Name, player1.Gender.ToString(), player1.Name));

            Txt_CharacterName.Text = string.Empty;
            Rdo_GenderMale.Checked = false;
            Rdo_GenderFemale.Checked = false;
            Cbo_CharacterClass.Text = string.Empty;
            
        }
    }
}

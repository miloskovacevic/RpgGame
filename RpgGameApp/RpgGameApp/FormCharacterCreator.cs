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

            string name = Txt_CharacterName.Text;

            EntityGender eGender;
            
            if (this.Rdo_GenderMale.Checked)
            {
                eGender = EntityGender.Male;
            }
            else if (this.Rdo_GenderFemale.Checked)
            {
                eGender = EntityGender.Female;
            }
            else
            {
                MessageBox.Show("You must select a gender!");
                return;
            }

            //provjera koju klasu smo zabrali...
            EntityClass eClass;

            if(this.Cbo_CharacterClass.Text == "Mage")
            {
                eClass = EntityClass.Mage;
            }
            else if (this.Cbo_CharacterClass.Text == "Rogue")
            {
                eClass = EntityClass.Rogue;
            }
            else if (this.Cbo_CharacterClass.Text == "Cleric")
            {
                eClass = EntityClass.Cleric;
            }
            else if (this.Cbo_CharacterClass.Text == "Paladin")
            {
                eClass = EntityClass.Paladin;
            }
            else if (this.Cbo_CharacterClass.Text == "Lumberjack")
            {
                eClass = EntityClass.Lumberjack;
            }
            else
            {
                MessageBox.Show("You must choose class for your character!");
                return;
            }

            //kreiramo igraca
            Player player1 = new Player(name, eGender, eClass);
            string output;
            output = String.Format("You created a new character.\n" + 
                "Your name is: {0}. \nYour gender is: {1}.\n" +
             "Your class is: {2}", player1.Name, player1.Gender.ToString(), player1.CharacterClass.ToString());
            MessageBox.Show(output, "Success!");


            //Mage player2 = new Mage(name, eGender);
            //MessageBox.Show(String.Format("Player 1 created : {0}, a {1}, Named: {2}", player1.GetType().Name, player1.Gender.ToString(), player1.Name));

            Txt_CharacterName.Text = string.Empty;
            Rdo_GenderMale.Checked = false;
            Rdo_GenderFemale.Checked = false;
            Cbo_CharacterClass.Text = string.Empty;
            
        }
    }
}

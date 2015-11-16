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
using System.IO;
using System.Xml;
using System.Xml.Serialization;

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

            //string output;
            //output = String.Format("You created a new character.\n" + 
            //    "Your name is: {0}. \nYour gender is: {1}.\n" +
            // "Your class is: {2}", player1.Name, player1.Gender.ToString(), player1.CharacterClass.ToString());
            //MessageBox.Show(output, "Success!");

            //store our player...
            FileManager.StoreCharacter(player1);
            //StoreCharacter(player1);

            CharacterID stats = new CharacterID();
            stats.Show();
            this.Close();
        }

        private void StoreCharacter(Player player)
        {
            using (Stream stream = File.Create(PlayerSettingsFile))
            {
                XmlSerializer ser = new XmlSerializer(player.GetType());
                ser.Serialize(stream, player);
            }
        }

        // vrati settings folder
        private static String SettingsFolder
        {
            get
            { 
                // create a string folder
                string folder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
                //add a subfolder
                folder = Path.Combine(folder, "RPG Project");
                folder = Path.Combine(folder, "CharacterSettings");
                if(!Directory.Exists(folder))
                {
                    Directory.CreateDirectory(folder);
                }

                return folder;
            }
        }

        //vrati settings fajl...
        private static String PlayerSettingsFile
        {
            get 
            {
                return Path.Combine(SettingsFolder, "Player.xml");
            }
        }

        private static Player DefaultSettings
        {
            get 
            {
                return new Player
                {
                    Name = "",
                    Gender = EntityGender.Unknown,
                    CharacterClass = EntityClass.Unknown,
                    Dexterity = 0,
                    Health = 0,
                    Strength = 0
                };
            }
        }

        
    }
}

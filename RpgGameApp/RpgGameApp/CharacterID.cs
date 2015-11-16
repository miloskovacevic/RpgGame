using RpgGameApp.CharacterClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RpgGameApp;

namespace RpgGameApp
{
    public partial class CharacterID : Form
    {
        public CharacterID()
        {
            InitializeComponent();
        }

        private void CharacterID_Load(object sender, EventArgs e)
        {
            Player p1 = new Player();
            p1 = FileManager.LoadPlayer();
            Lbl_Name.Text = p1.Name;
            Lbl_Class.Text = p1.CharacterClass.ToString();
            Lbl_Gender.Text = p1.Gender.ToString();

        }

        private void Btn_Close_Click(object sender, EventArgs e)
        {
            Frm_Menu menu = new Frm_Menu();
            menu.Show();
            this.Hide();
        }
    }
}

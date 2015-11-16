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
    public partial class Frm_Menu : Form
    {
        public Frm_Menu()
        {
            InitializeComponent();
        }

        private void Btn_CreateCharacter_Click(object sender, EventArgs e)
        {
            
            FormCharacterCreator charCreator = new FormCharacterCreator();
            charCreator.Show();
            this.Hide();
        }
    }
}

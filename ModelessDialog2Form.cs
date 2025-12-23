using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eunice_Fmukam_Lab3
{
    public delegate void delUncheck(bool b);
    public delegate void delScore(int score);
    public partial class UI_Score_ModelessDialogForm : Form
    {
        public delUncheck _deluncheck;
        public delScore _delsc = null;
        public UI_Score_ModelessDialogForm()
        {
            InitializeComponent();
        }

        private void UI_Score_ModelessDialogForm_Load(object sender, EventArgs e)
        {            
                _delsc = UpdateScore;
        }

        public void UpdateScore(int score)
        {
            UI_DisplayScore_Lbl.Text= score.ToString(); // Update the label with the new score
        }

        private void UI_Score_ModelessDialogForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;   // Annule la fermeture
            this.Hide();
            if (_deluncheck != null)
                _deluncheck(false);                 
        }
    }
}

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
    public delegate void delHighScore(string name);                 // Delegate for passing high score name
    public partial class UI_HighScore_ModelessDialogForm : Form
    {
        public delHighScore _delSave = null;                     // Delegate instance for saving high score name
        public UI_HighScore_ModelessDialogForm()
        {
            InitializeComponent();
        }

        private void UI_Cancel_Btn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;                         // Set dialog result to Cancel
            Close();                                                   // Close the dialog
        }

        private void UI_HighScore_ModelessDialogForm_Load(object sender, EventArgs e)
        {

        }

        private void UI_Ok_Btn_Click(object sender, EventArgs e)
        {
            if (_delSave != null)                              //   Check if delegate is assigned
                _delSave(UI_PlayerName_Tbx.Text);             // Invoke delegate to save player name

            DialogResult = DialogResult.OK;                 // Set dialog result to OK
            Close();                                       // Close the dialog
        }
    }
}

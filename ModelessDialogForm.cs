using GDIDrawer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using GDIDrawer;
using System.Threading;
namespace Eunice_Fmukam_Lab3
{
    public delegate void DelMode(int i);
    public partial class UI_SelectDifficulty_ModelessDialog : Form
    {      
        public DelMode _delm = null;          // delegate instance for passing difficulty mode
        public UI_SelectDifficulty_ModelessDialog()
        {
            
            InitializeComponent();
        }

        private void UI_Ok_Btn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;        // Set dialog result to OK

            // Invoke the delegate based on the selected difficulty
            if (UI_EasyDiff_Rbtn.Checked)        
            {
                if(_delm!=null)
                _delm.Invoke(3);    // Easy mode
            }

            if (UI_MediumDiff_Rbtn.Checked) 
            {
                if (_delm != null)
                    _delm.Invoke(4);     // Medium mode
            }

            if (UI_HardDiff_Rbtn.Checked)
            {
                if (_delm != null)
                    _delm.Invoke(5); // Hard mode
            }         
        }

        private void UI_Cancel_Btn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel; // Set dialog result to Cancel
            Close();                          // Close the dialog
        }

        private void UI_SelectDifficulty_ModelessDialog_Load(object sender, EventArgs e)
        {

        }

    }
}

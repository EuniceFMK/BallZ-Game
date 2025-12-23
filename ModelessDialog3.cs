using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Eunice_Fmukam_Lab3
{
    public delegate void delUncheckA(bool b);            // Delegate for unchecking action
    public delegate void delUpdateSlip(int v);           // Delegate for updating slip value

    public partial class UI_AnimationSp_ModelessDialogForm : Form
    {
        public delUncheckA _delUnchA = null;              // Delegate instance for unchecking action
        public delUpdateSlip _delDelay = null;           // Delegate instance for updating slip value
        public UI_AnimationSp_ModelessDialogForm()
        {
            InitializeComponent();
        }

        private void UI_AnimationSp_ModelessDialogForm_Load(object sender, EventArgs e)
        {

        }

        private void UI_AnimationSp_ModelessDialogForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;                // Cancel the closing event
            this.Hide();                   // Hide the form instead of closing
            if (_delUnchA != null)        // Invoke the uncheck delegate
                _delUnchA(false);        // Pass false to indicate unchecking
        }

        private void UI_AnimationSp_Trbr_Scroll(object sender, EventArgs e)
        {
            if (_delDelay != null)                                   
                _delDelay.Invoke(UI_AnimationSp_Trbr.Value);     // Invoke the delegate to update slip value
        }
    }
}

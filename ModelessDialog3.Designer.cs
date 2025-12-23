namespace Eunice_Fmukam_Lab3
{
    partial class UI_AnimationSp_ModelessDialogForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.UI_AnimationSp_Trbr = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.UI_AnimationSp_Trbr)).BeginInit();
            this.SuspendLayout();
            // 
            // UI_AnimationSp_Trbr
            // 
            this.UI_AnimationSp_Trbr.Location = new System.Drawing.Point(51, 87);
            this.UI_AnimationSp_Trbr.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.UI_AnimationSp_Trbr.Maximum = 200;
            this.UI_AnimationSp_Trbr.Minimum = 10;
            this.UI_AnimationSp_Trbr.Name = "UI_AnimationSp_Trbr";
            this.UI_AnimationSp_Trbr.Size = new System.Drawing.Size(612, 69);
            this.UI_AnimationSp_Trbr.TabIndex = 0;
            this.UI_AnimationSp_Trbr.Value = 10;
            this.UI_AnimationSp_Trbr.Scroll += new System.EventHandler(this.UI_AnimationSp_Trbr_Scroll);
            // 
            // UI_AnimationSp_ModelessDialogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 229);
            this.Controls.Add(this.UI_AnimationSp_Trbr);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UI_AnimationSp_ModelessDialogForm";
            this.Text = "Animation Speed";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UI_AnimationSp_ModelessDialogForm_FormClosing);
            this.Load += new System.EventHandler(this.UI_AnimationSp_ModelessDialogForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UI_AnimationSp_Trbr)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar UI_AnimationSp_Trbr;
    }
}
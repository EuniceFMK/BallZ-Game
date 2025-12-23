namespace Eunice_Fmukam_Lab3
{
    partial class UI_Score_ModelessDialogForm
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
            this.UI_Score_Lbl = new System.Windows.Forms.Label();
            this.UI_DisplayScore_Lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // UI_Score_Lbl
            // 
            this.UI_Score_Lbl.AutoSize = true;
            this.UI_Score_Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_Score_Lbl.Location = new System.Drawing.Point(104, 105);
            this.UI_Score_Lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UI_Score_Lbl.Name = "UI_Score_Lbl";
            this.UI_Score_Lbl.Size = new System.Drawing.Size(89, 29);
            this.UI_Score_Lbl.TabIndex = 0;
            this.UI_Score_Lbl.Text = "Score:";
            // 
            // UI_DisplayScore_Lbl
            // 
            this.UI_DisplayScore_Lbl.AutoSize = true;
            this.UI_DisplayScore_Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_DisplayScore_Lbl.Location = new System.Drawing.Point(242, 105);
            this.UI_DisplayScore_Lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UI_DisplayScore_Lbl.Name = "UI_DisplayScore_Lbl";
            this.UI_DisplayScore_Lbl.Size = new System.Drawing.Size(69, 29);
            this.UI_DisplayScore_Lbl.TabIndex = 1;
            this.UI_DisplayScore_Lbl.Text = "0000";
            // 
            // UI_Score_ModelessDialogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 231);
            this.Controls.Add(this.UI_DisplayScore_Lbl);
            this.Controls.Add(this.UI_Score_Lbl);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UI_Score_ModelessDialogForm";
            this.Text = "Score";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UI_Score_ModelessDialogForm_FormClosing);
            this.Load += new System.EventHandler(this.UI_Score_ModelessDialogForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UI_Score_Lbl;
        private System.Windows.Forms.Label UI_DisplayScore_Lbl;
    }
}
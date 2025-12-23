namespace Eunice_Fmukam_Lab3
{
    partial class UI_HighScore_ModelessDialogForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.UI_PlayerName_Tbx = new System.Windows.Forms.TextBox();
            this.UI_Cancel_Btn = new System.Windows.Forms.Button();
            this.UI_Ok_Btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(68, 100);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Player Name:";
            // 
            // UI_PlayerName_Tbx
            // 
            this.UI_PlayerName_Tbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_PlayerName_Tbx.Location = new System.Drawing.Point(279, 100);
            this.UI_PlayerName_Tbx.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.UI_PlayerName_Tbx.Name = "UI_PlayerName_Tbx";
            this.UI_PlayerName_Tbx.Size = new System.Drawing.Size(338, 33);
            this.UI_PlayerName_Tbx.TabIndex = 1;
            // 
            // UI_Cancel_Btn
            // 
            this.UI_Cancel_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_Cancel_Btn.Location = new System.Drawing.Point(289, 190);
            this.UI_Cancel_Btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.UI_Cancel_Btn.Name = "UI_Cancel_Btn";
            this.UI_Cancel_Btn.Size = new System.Drawing.Size(112, 46);
            this.UI_Cancel_Btn.TabIndex = 2;
            this.UI_Cancel_Btn.Text = "Cancel";
            this.UI_Cancel_Btn.UseVisualStyleBackColor = true;
            this.UI_Cancel_Btn.Click += new System.EventHandler(this.UI_Cancel_Btn_Click);
            // 
            // UI_Ok_Btn
            // 
            this.UI_Ok_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_Ok_Btn.Location = new System.Drawing.Point(73, 190);
            this.UI_Ok_Btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.UI_Ok_Btn.Name = "UI_Ok_Btn";
            this.UI_Ok_Btn.Size = new System.Drawing.Size(112, 46);
            this.UI_Ok_Btn.TabIndex = 3;
            this.UI_Ok_Btn.Text = "OK";
            this.UI_Ok_Btn.UseVisualStyleBackColor = true;
            this.UI_Ok_Btn.Click += new System.EventHandler(this.UI_Ok_Btn_Click);
            // 
            // UI_HighScore_ModelessDialogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 304);
            this.Controls.Add(this.UI_Ok_Btn);
            this.Controls.Add(this.UI_Cancel_Btn);
            this.Controls.Add(this.UI_PlayerName_Tbx);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UI_HighScore_ModelessDialogForm";
            this.Text = "High Score";
            this.Load += new System.EventHandler(this.UI_HighScore_ModelessDialogForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox UI_PlayerName_Tbx;
        private System.Windows.Forms.Button UI_Cancel_Btn;
        private System.Windows.Forms.Button UI_Ok_Btn;
    }
}
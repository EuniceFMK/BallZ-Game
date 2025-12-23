namespace Eunice_Fmukam_Lab3
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.UI_ShowScore_Chbx = new System.Windows.Forms.CheckBox();
            this.UI_ShowAnimSp_Chbx = new System.Windows.Forms.CheckBox();
            this.UI_Play_Btn = new System.Windows.Forms.Button();
            this.UI_Timer_Tim = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // UI_ShowScore_Chbx
            // 
            this.UI_ShowScore_Chbx.AutoSize = true;
            this.UI_ShowScore_Chbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_ShowScore_Chbx.Location = new System.Drawing.Point(174, 125);
            this.UI_ShowScore_Chbx.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.UI_ShowScore_Chbx.Name = "UI_ShowScore_Chbx";
            this.UI_ShowScore_Chbx.Size = new System.Drawing.Size(155, 29);
            this.UI_ShowScore_Chbx.TabIndex = 0;
            this.UI_ShowScore_Chbx.Text = "Show Score";
            this.UI_ShowScore_Chbx.UseVisualStyleBackColor = true;
            this.UI_ShowScore_Chbx.CheckedChanged += new System.EventHandler(this.UI_ShowScore_Chbx_CheckedChanged);
            // 
            // UI_ShowAnimSp_Chbx
            // 
            this.UI_ShowAnimSp_Chbx.AutoSize = true;
            this.UI_ShowAnimSp_Chbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_ShowAnimSp_Chbx.Location = new System.Drawing.Point(174, 194);
            this.UI_ShowAnimSp_Chbx.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.UI_ShowAnimSp_Chbx.Name = "UI_ShowAnimSp_Chbx";
            this.UI_ShowAnimSp_Chbx.Size = new System.Drawing.Size(263, 29);
            this.UI_ShowAnimSp_Chbx.TabIndex = 1;
            this.UI_ShowAnimSp_Chbx.Text = "Show Animation Speed";
            this.UI_ShowAnimSp_Chbx.UseVisualStyleBackColor = true;
            this.UI_ShowAnimSp_Chbx.CheckedChanged += new System.EventHandler(this.UI_ShowAnimSp_Chbx_CheckedChanged);
            // 
            // UI_Play_Btn
            // 
            this.UI_Play_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_Play_Btn.Location = new System.Drawing.Point(328, 254);
            this.UI_Play_Btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.UI_Play_Btn.Name = "UI_Play_Btn";
            this.UI_Play_Btn.Size = new System.Drawing.Size(189, 71);
            this.UI_Play_Btn.TabIndex = 4;
            this.UI_Play_Btn.Text = "Play";
            this.UI_Play_Btn.UseVisualStyleBackColor = true;
            this.UI_Play_Btn.Click += new System.EventHandler(this.UI_Play_Btn_Click);
            // 
            // UI_Timer_Tim
            // 
            this.UI_Timer_Tim.Tick += new System.EventHandler(this.UI_Timer_Tim_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.UI_Play_Btn);
            this.Controls.Add(this.UI_ShowAnimSp_Chbx);
            this.Controls.Add(this.UI_ShowScore_Chbx);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox UI_ShowScore_Chbx;
        private System.Windows.Forms.CheckBox UI_ShowAnimSp_Chbx;
        private System.Windows.Forms.Button UI_Play_Btn;
        private System.Windows.Forms.Timer UI_Timer_Tim;
    }
}


namespace APPLE_GAME
{
    partial class multi
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
            this.Panel_P1 = new Guna.UI2.WinForms.Guna2Panel();
            this.txt_score = new System.Windows.Forms.TextBox();
            this.lbl_score = new System.Windows.Forms.Label();
            this.prg_time = new Guna.UI2.WinForms.Guna2VProgressBar();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.SuspendLayout();
            // 
            // Panel_P1
            // 
            this.Panel_P1.Location = new System.Drawing.Point(246, 227);
            this.Panel_P1.Name = "Panel_P1";
            this.Panel_P1.Size = new System.Drawing.Size(750, 400);
            this.Panel_P1.TabIndex = 10;
            // 
            // txt_score
            // 
            this.txt_score.Font = new System.Drawing.Font("휴먼둥근헤드라인", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txt_score.Location = new System.Drawing.Point(1079, 72);
            this.txt_score.Name = "txt_score";
            this.txt_score.Size = new System.Drawing.Size(64, 30);
            this.txt_score.TabIndex = 9;
            // 
            // lbl_score
            // 
            this.lbl_score.AutoSize = true;
            this.lbl_score.Font = new System.Drawing.Font("휴먼둥근헤드라인", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_score.Location = new System.Drawing.Point(1009, 75);
            this.lbl_score.Name = "lbl_score";
            this.lbl_score.Size = new System.Drawing.Size(77, 21);
            this.lbl_score.TabIndex = 8;
            this.lbl_score.Text = "점수 : ";
            // 
            // prg_time
            // 
            this.prg_time.Location = new System.Drawing.Point(1079, 126);
            this.prg_time.Name = "prg_time";
            this.prg_time.Size = new System.Drawing.Size(30, 477);
            this.prg_time.TabIndex = 7;
            this.prg_time.Text = "guna2VProgressBar1";
            this.prg_time.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Location = new System.Drawing.Point(760, 37);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(200, 120);
            this.guna2Panel1.TabIndex = 11;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Location = new System.Drawing.Point(513, 37);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(200, 120);
            this.guna2Panel2.TabIndex = 12;
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.Location = new System.Drawing.Point(279, 37);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Size = new System.Drawing.Size(200, 120);
            this.guna2Panel3.TabIndex = 12;
            // 
            // multi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 653);
            this.Controls.Add(this.guna2Panel3);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.Panel_P1);
            this.Controls.Add(this.txt_score);
            this.Controls.Add(this.lbl_score);
            this.Controls.Add(this.prg_time);
            this.Name = "multi";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel Panel_P1;
        private System.Windows.Forms.TextBox txt_score;
        private System.Windows.Forms.Label lbl_score;
        private Guna.UI2.WinForms.Guna2VProgressBar prg_time;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
    }
}
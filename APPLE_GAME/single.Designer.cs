namespace APPLE_GAME
{
    partial class single
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Game_panel = new System.Windows.Forms.FlowLayoutPanel();
            this.prg_time = new Guna.UI2.WinForms.Guna2VProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.txtscore = new System.Windows.Forms.TextBox();
            this.btn_test = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // Game_panel
            // 
            this.Game_panel.Location = new System.Drawing.Point(140, 98);
            this.Game_panel.Name = "Game_panel";
            this.Game_panel.Size = new System.Drawing.Size(900, 500);
            this.Game_panel.TabIndex = 1;
            // 
            // prg_time
            // 
            this.prg_time.Location = new System.Drawing.Point(1100, 113);
            this.prg_time.Name = "prg_time";
            this.prg_time.Size = new System.Drawing.Size(30, 477);
            this.prg_time.TabIndex = 2;
            this.prg_time.Text = "guna2VProgressBar1";
            this.prg_time.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("휴먼둥근헤드라인", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(979, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "점수 : ";
            // 
            // txtscore
            // 
            this.txtscore.Font = new System.Drawing.Font("휴먼둥근헤드라인", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtscore.Location = new System.Drawing.Point(1062, 49);
            this.txtscore.Name = "txtscore";
            this.txtscore.Size = new System.Drawing.Size(80, 34);
            this.txtscore.TabIndex = 4;
            // 
            // btn_test
            // 
            this.btn_test.Location = new System.Drawing.Point(28, 12);
            this.btn_test.Name = "btn_test";
            this.btn_test.Size = new System.Drawing.Size(186, 48);
            this.btn_test.TabIndex = 5;
            this.btn_test.Text = "테스트용";
            this.btn_test.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // single
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 753);
            this.Controls.Add(this.btn_test);
            this.Controls.Add(this.txtscore);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.prg_time);
            this.Controls.Add(this.Game_panel);
            this.Name = "single";
            this.Text = "apple_game";
            this.Load += new System.EventHandler(this.single_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel Game_panel;
        private Guna.UI2.WinForms.Guna2VProgressBar prg_time;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtscore;
        private System.Windows.Forms.Button btn_test;
        private System.Windows.Forms.Timer timer1;
    }
}


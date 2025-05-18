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
            this.prg_time = new Guna.UI2.WinForms.Guna2VProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_score = new System.Windows.Forms.TextBox();
            this.btn_test = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel_game = new Guna.UI2.WinForms.Guna2Panel();
            this.txt_test = new System.Windows.Forms.TextBox();
            this.apple1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.panel_overlay = new Guna.UI2.WinForms.Guna2Panel();
            this.panel_game.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.apple1)).BeginInit();
            this.SuspendLayout();
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
            this.label1.Font = new System.Drawing.Font("휴먼둥근헤드라인", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(1030, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "점수 : ";
            // 
            // txt_score
            // 
            this.txt_score.Font = new System.Drawing.Font("휴먼둥근헤드라인", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txt_score.Location = new System.Drawing.Point(1100, 59);
            this.txt_score.Name = "txt_score";
            this.txt_score.Size = new System.Drawing.Size(64, 30);
            this.txt_score.TabIndex = 4;
            // 
            // btn_test
            // 
            this.btn_test.Location = new System.Drawing.Point(12, 31);
            this.btn_test.Name = "btn_test";
            this.btn_test.Size = new System.Drawing.Size(145, 44);
            this.btn_test.TabIndex = 5;
            this.btn_test.Text = "테스트용";
            this.btn_test.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel_game
            // 
            this.panel_game.BorderColor = System.Drawing.Color.LawnGreen;
            this.panel_game.BorderThickness = 3;
            this.panel_game.Controls.Add(this.panel_overlay);
            this.panel_game.Location = new System.Drawing.Point(160, 100);
            this.panel_game.Name = "panel_game";
            this.panel_game.Size = new System.Drawing.Size(900, 500);
            this.panel_game.TabIndex = 6;
            this.panel_game.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_game_Paint);
            this.panel_game.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_game_MouseDown);
            this.panel_game.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_game_MouseMove);
            this.panel_game.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel_game_MouseUp);
            // 
            // txt_test
            // 
            this.txt_test.Font = new System.Drawing.Font("휴먼둥근헤드라인", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txt_test.Location = new System.Drawing.Point(181, 45);
            this.txt_test.Name = "txt_test";
            this.txt_test.Size = new System.Drawing.Size(64, 30);
            this.txt_test.TabIndex = 7;
            // 
            // apple1
            // 
            this.apple1.BackColor = System.Drawing.Color.Transparent;
            this.apple1.Image = global::APPLE_GAME.Properties.Resources.b4;
            this.apple1.ImageRotate = 0F;
            this.apple1.Location = new System.Drawing.Point(12, 122);
            this.apple1.Name = "apple1";
            this.apple1.Size = new System.Drawing.Size(137, 137);
            this.apple1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.apple1.TabIndex = 0;
            this.apple1.TabStop = false;
            this.apple1.UseTransparentBackground = true;
            this.apple1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_game_MouseDown);
            this.apple1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_game_MouseMove);
            this.apple1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel_game_MouseUp);
            // 
            // panel_overlay
            // 
            this.panel_overlay.BackColor = System.Drawing.Color.Transparent;
            this.panel_overlay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_overlay.Location = new System.Drawing.Point(0, 0);
            this.panel_overlay.Name = "panel_overlay";
            this.panel_overlay.Size = new System.Drawing.Size(900, 500);
            this.panel_overlay.TabIndex = 3;
            this.panel_overlay.UseTransparentBackground = true;
            this.panel_overlay.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_game_Paint);
            this.panel_overlay.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_game_MouseDown);
            this.panel_overlay.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_game_MouseMove);
            this.panel_overlay.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel_game_MouseUp);
            // 
            // single
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 653);
            this.Controls.Add(this.apple1);
            this.Controls.Add(this.txt_test);
            this.Controls.Add(this.btn_test);
            this.Controls.Add(this.txt_score);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.prg_time);
            this.Controls.Add(this.panel_game);
            this.Name = "single";
            this.Text = "apple_game";
            this.Load += new System.EventHandler(this.single_Load);
            this.panel_game.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.apple1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2VProgressBar prg_time;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_score;
        private System.Windows.Forms.Button btn_test;
        private System.Windows.Forms.Timer timer1;
        private Guna.UI2.WinForms.Guna2Panel panel_game;
        private System.Windows.Forms.TextBox txt_test;
        private Guna.UI2.WinForms.Guna2PictureBox apple1;
        private Guna.UI2.WinForms.Guna2Panel panel_overlay;
    }
}


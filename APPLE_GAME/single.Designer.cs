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
            this.apple1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.guna2CirclePictureBox2 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.guna2CirclePictureBox3 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.txt_test = new System.Windows.Forms.TextBox();
            this.panel_game.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.apple1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox3)).BeginInit();
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
            this.panel_game.Controls.Add(this.guna2CirclePictureBox3);
            this.panel_game.Controls.Add(this.guna2CirclePictureBox2);
            this.panel_game.Controls.Add(this.guna2CirclePictureBox1);
            this.panel_game.Controls.Add(this.apple1);
            this.panel_game.Location = new System.Drawing.Point(163, 102);
            this.panel_game.Name = "panel_game";
            this.panel_game.Size = new System.Drawing.Size(900, 500);
            this.panel_game.TabIndex = 6;
            this.panel_game.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_game_Paint);
            this.panel_game.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_game_MouseDown);
            this.panel_game.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_game_MouseMove);
            this.panel_game.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel_game_MouseUp);
            // 
            // apple1
            // 
            this.apple1.Image = global::APPLE_GAME.Properties.Resources.apple_cut;
            this.apple1.ImageRotate = 0F;
            this.apple1.InitialImage = global::APPLE_GAME.Properties.Resources.apple_cut;
            this.apple1.Location = new System.Drawing.Point(771, 158);
            this.apple1.Name = "apple1";
            this.apple1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.apple1.Size = new System.Drawing.Size(64, 64);
            this.apple1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.apple1.TabIndex = 7;
            this.apple1.TabStop = false;
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.Image = global::APPLE_GAME.Properties.Resources.apple_cut;
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.InitialImage = global::APPLE_GAME.Properties.Resources.apple_cut;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(725, 292);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(64, 64);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2CirclePictureBox1.TabIndex = 8;
            this.guna2CirclePictureBox1.TabStop = false;
            // 
            // guna2CirclePictureBox2
            // 
            this.guna2CirclePictureBox2.Image = global::APPLE_GAME.Properties.Resources.apple_cut;
            this.guna2CirclePictureBox2.ImageRotate = 0F;
            this.guna2CirclePictureBox2.InitialImage = global::APPLE_GAME.Properties.Resources.apple_cut;
            this.guna2CirclePictureBox2.Location = new System.Drawing.Point(621, 319);
            this.guna2CirclePictureBox2.Name = "guna2CirclePictureBox2";
            this.guna2CirclePictureBox2.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox2.Size = new System.Drawing.Size(64, 64);
            this.guna2CirclePictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2CirclePictureBox2.TabIndex = 9;
            this.guna2CirclePictureBox2.TabStop = false;
            // 
            // guna2CirclePictureBox3
            // 
            this.guna2CirclePictureBox3.Image = global::APPLE_GAME.Properties.Resources.apple_cut;
            this.guna2CirclePictureBox3.ImageRotate = 0F;
            this.guna2CirclePictureBox3.InitialImage = global::APPLE_GAME.Properties.Resources.apple_cut;
            this.guna2CirclePictureBox3.Location = new System.Drawing.Point(621, 158);
            this.guna2CirclePictureBox3.Name = "guna2CirclePictureBox3";
            this.guna2CirclePictureBox3.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox3.Size = new System.Drawing.Size(64, 64);
            this.guna2CirclePictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2CirclePictureBox3.TabIndex = 10;
            this.guna2CirclePictureBox3.TabStop = false;
            // 
            // txt_test
            // 
            this.txt_test.Font = new System.Drawing.Font("휴먼둥근헤드라인", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txt_test.Location = new System.Drawing.Point(181, 45);
            this.txt_test.Name = "txt_test";
            this.txt_test.Size = new System.Drawing.Size(64, 30);
            this.txt_test.TabIndex = 7;
            // 
            // single
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 653);
            this.Controls.Add(this.txt_test);
            this.Controls.Add(this.panel_game);
            this.Controls.Add(this.btn_test);
            this.Controls.Add(this.txt_score);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.prg_time);
            this.Name = "single";
            this.Text = "apple_game";
            this.Load += new System.EventHandler(this.single_Load);
            this.panel_game.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.apple1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox3)).EndInit();
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
        private Guna.UI2.WinForms.Guna2CirclePictureBox apple1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox3;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox2;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private System.Windows.Forms.TextBox txt_test;
    }
}


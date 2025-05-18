using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APPLE_GAME
{
    public partial class single : Form
    {
        int remainingTime = 120; //게임 시간 
        int score = 0; // 테스트용 score
        DragHelper drag = new DragHelper(); 

        public single()
        {
            InitializeComponent();
        }

        private void single_Load(object sender, EventArgs e)
        {
            prg_time.Maximum = remainingTime;
            prg_time.Value = remainingTime;

            // 타이머 설정
            timer1.Interval = 1000; // 1초마다          
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (remainingTime > 0)
            {
                remainingTime--;

                score++; // 테스트용 점수증가
                txt_score.Text = score.ToString(); // 테스트용 점수 출력
                prg_time.Value = remainingTime;
            }
            else
            {
                timer1.Stop();
                MessageBox.Show("시간 종료!");
            }
        }

        private void panel_game_MouseDown(object sender, MouseEventArgs e)
        {
            drag.Begin(e.Location);
            panel_game.Invalidate();
        }

        private void panel_game_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag.IsDragging)
            {
                drag.Update(e.Location);
                panel_game.Invalidate();
            }
        }

        private void panel_game_MouseUp(object sender, MouseEventArgs e)
        {
            drag.EndDrag();
            panel_game.Invalidate();
        }

        private void panel_game_Paint(object sender, PaintEventArgs e)
        {
            if (drag.IsDragging)
            {
                using (Pen pen = new Pen(Color.Orange, 2))
                {
                    e.Graphics.DrawRectangle(pen, drag.GetRect());
                }
            }
        }



    }
}

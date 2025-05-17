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
        int remainingTime = 10; //게임 시간 
        int score = 0; // 테스트용 score
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
                txtscore.Text = score.ToString(); // 테스트용 점수 출력
                prg_time.Value = remainingTime;
            }
            else
            {
                timer1.Stop();
                MessageBox.Show("시간 종료!");
            }
        }
    }
}

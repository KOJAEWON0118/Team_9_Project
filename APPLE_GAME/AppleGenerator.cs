using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APPLE_GAME
{
    public class AppleData
    {
        public int Row { get; set; }
        public int Col { get; set; }
        public int Value { get; set; }
        public PictureBox Picture { get; set; }  // ← Label 대신 PictureBox
    }

    internal class AppleGenerator
    {
        public static List<AppleData> GenerateApples(Panel panel, int boxSize = 40, int margin = 4)
        {
            int cols = panel.Width / (boxSize + margin);
            int rows = panel.Height / (boxSize + margin);
            Random rand = new Random();
            List<AppleData> apples = new List<AppleData>();

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    int num = rand.Next(1, 10);  // 1~9

                    Guna2PictureBox pb = new Guna2PictureBox
                    {
                        Size = new Size(boxSize, boxSize),
                        Location = new Point(j * (boxSize + margin), i * (boxSize + margin)),
                        Image = (Image)Properties.Resources.ResourceManager.GetObject($"a{num}"),
                        SizeMode = PictureBoxSizeMode.Zoom,
                      
                    };

                    panel.Controls.Add(pb);

                    apples.Add(new AppleData
                    {
                        Row = i,
                        Col = j,
                        Value = num,
                        Picture = pb
                    });
                }
            }

            return apples;
        }
    }
}

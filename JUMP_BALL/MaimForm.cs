using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JUMP_BALL
{
    public partial class MaimForm : Form
    {
        int x = 134;
        int y = 95;
        const int MOOVING = 25;
        public MaimForm()
        {
            InitializeComponent();
        }

        private void UpPicBx_Click(object sender, EventArgs e)
        {
            Current_Location();
            BasketballPicBx.Location = new Point(x, y- MOOVING);
        }

        private void DownPicBx_Click(object sender, EventArgs e)
        {
            Current_Location();
            BasketballPicBx.Location = new Point(x, y + MOOVING);
        }

        private void RightPicBx_Click(object sender, EventArgs e)
        {
            Current_Location();
            BasketballPicBx.Location = new Point(x + MOOVING, y);
        }

        private void LeftPicBx_Click(object sender, EventArgs e)
        {
            Current_Location();
            BasketballPicBx.Location = new Point(x - MOOVING, y);
        }

        private void MaimForm_KeyDown(object sender, KeyEventArgs e)
        {
            Current_Location();
            if (e.KeyCode == Keys.Up)
            {
                BasketballPicBx.Location = new Point(x, y - MOOVING);
            }
            else if (e.KeyCode == Keys.Down)
            {
                BasketballPicBx.Location = new Point(x, y + MOOVING);
            }
            else if (e.KeyCode == Keys.Left)
            {
                BasketballPicBx.Location = new Point(x - MOOVING, y);
            }
            else if (e.KeyCode == Keys.Right)
            {
                BasketballPicBx.Location = new Point(x + MOOVING, y);
            }
        }
        private void Current_Location()
        {
             x = BasketballPicBx.Location.X;
             y = BasketballPicBx.Location.Y;
        }
    }
}

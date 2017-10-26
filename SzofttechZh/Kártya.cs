using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SzofttechZh
{
    // 1. a
    class Kártya : PictureBox
    {
        // 1. b
        public Kártya(string fájlNév) {
            // 2. a
            this.Visible = true;

            // 1. c
            this.Load(fájlNév);
            // 1. d
            this.Width = this.Width / 3;
            this.Height = this.Height / 3;
            // 1. e
            this.Visible = false;
            this.SizeMode = PictureBoxSizeMode.StretchImage;
        }
    }
}

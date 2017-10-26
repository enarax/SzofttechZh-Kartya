using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SzofttechZh
{
    public partial class Form1 : Form
    {
        // 2. e
        public int LapokSzáma = 52;

        // 3. f / 1
        public Random random = new Random();

        public Form1()
        {
            InitializeComponent();

            // 2. b
            StreamReader sr = new StreamReader("cards.txt");
            while (!sr.EndOfStream)
            {
                string sor = sr.ReadLine();
                // 2. c
                Kártya kártya = new Kártya(sor);
                // 2. d
                this.Controls.Add(kártya);
            }

            // 3. a / 2
            Leosztás();
        }

        // 3. a / 1
        public void Leosztás() {
            // 3. b
            for (int i = 0; i < 5; i++)
            {
                // 3. e / 1
                int szamlalo = 0;

                // 3. f / 2
                int veletlen = random.Next(0, LapokSzáma);

                // 3. c
                foreach(Kártya lap in this.Controls)
                {

                    // 3. g
                    if (lap.Visible == false && szamlalo == veletlen)
                    {
                        lap.Visible = true;
                        LapokSzáma--;
                        lap.Left = i * lap.Width;
                    }

                    // 3. d
                    if (lap.Visible == false)
                    {
                        // 3. e / 2
                        szamlalo++;
                    }
                }
            }
        }
    }
}

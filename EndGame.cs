using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniGameParty
{
    public partial class EndGame : Form
    {
        public EndGame(int p1s, int p2s, int p1p, int p2p)
        {
            InitializeComponent();

            if (p1s == p2s)
            {
                if (p1p == p2p)
                {

                }
                else if (p1p > p2p)
                {

                }
                else
                {

                }
            }
            else if (p1s > p2s)
            {

            }
            else
            {

            }
        }
    }
}

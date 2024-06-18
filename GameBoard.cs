using MiniGameParty2;
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
    public partial class GameBoard : Form
    {
        int turn = 50;
        public GameBoard()
        {
            InitializeComponent();
            lb_lastturn.Text = turn.ToString();
        }
    }
}

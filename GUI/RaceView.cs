using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formTemplate
{
    public partial class RaceView : Form
    {
        public static enum Action { ls, touch, rm, pull, push }
        public RaceView(Action Action)
        {
            InitializeComponent();
        }

    }
}

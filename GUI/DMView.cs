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
    public partial class DMView : Form
    {
        public static enum Action { touch, ls, rm }
        public DMView(Action Action)
        {
            InitializeComponent();
        }

    }
}

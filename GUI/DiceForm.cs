using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dnd.NET.GUI
{
    public partial class DiceForm : Form
    {
        public enum Action { player, dm }
        public DiceForm(Action Action)
        {
            InitializeComponent();
        }

    }
}

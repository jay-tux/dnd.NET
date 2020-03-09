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
    public partial class PlayerForm : Form
    {
        public enum Action { touch, ls, rm }
        public PlayerForm(Action Action)
        {
            InitializeComponent();
        }

        protected void CreateChar(){}
        protected void DeleteChar(){}
        protected void ViewChar(){}
        protected void RollFor(){}
        protected void Export(){}
        protected void Level(){}
        protected void EditChar(){}
    }
}

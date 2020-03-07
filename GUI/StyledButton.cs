using System.Windows.Forms;
using System.Drawing;
using System;

namespace dnd.NET.GUI
{
    public class StyledButton : RoundedButton
    {
        public StyledButton(string Text, Point Location, EventHandler Handler)
        {
            this.Text = Text;
            this.Location = Location;
            this.AutoSize = true;
            this.Click += Handler;
            this.Font = DefaultFonts.ButtonFont;
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderColor = DefaultColors.EmphasisColor;
            this.BackColor = DefaultColors.ButtonColor;
            this.ForeColor = DefaultColors.TextColor;
        }
    }
}
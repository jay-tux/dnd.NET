using System;
using System.Windows.Forms;
using System.Drawing;

namespace dnd.NET.GUI
{
    public class HeaderLabel : Label
    {
        public HeaderLabel(string Text, Point Location)
        {
            this.Text = Text;
            this.Location = Location;
            this.AutoSize = true;
            this.Font = DefaultFonts.HeaderFont;
            this.ForeColor = DefaultColors.HeaderColor;
        }
    }

    public class MainLabel : Label
    {
        public MainLabel(string Text, Point Location, bool Bold = false, bool Italic = false)
        {
            this.Text = Text;
            this.Location = Location;
            this.AutoSize = true;
            this.Font = Bold ? DefaultFonts.BoldFont : (Italic ? DefaultFonts.ItalicFont : DefaultFonts.TextFont);
            this.ForeColor = DefaultColors.TextColor;
        }
    }

    public class MainLinkLabel : LinkLabel
    {
        public MainLinkLabel(string Text, Point Location, EventHandler handler, bool Bold = false, bool Italic = false, bool Emphasis = false)
        {
            this.Text = Text;
            this.Location = Location;
            this.AutoSize = true;
            this.Font = Emphasis ? DefaultFonts.EmphasisFont : 
                (Bold ? DefaultFonts.BoldFont : 
                (Italic ? DefaultFonts.ItalicFont : DefaultFonts.TextFont));
            this.ForeColor = DefaultColors.TextColor;
            this.LinkColor = DefaultColors.TextColor;
            this.VisitedLinkColor = DefaultColors.TextColor;
            this.Click += handler;
        }
    }
}
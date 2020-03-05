using System.Windows.Forms;
using System.Drawing;

namespace dnd.NET.GUI
{
    public static class DefaultFonts
    {
        public static Font HeaderFont = new Font("Z003", 20, FontStyle.Bold | FontStyle.Underline);
        public static Font BoldFont = new Font("Serif", 12, FontStyle.Bold);
        public static Font ItalicFont = new Font("Serif", 12, FontStyle.Italic);
        public static Font TextFont = new Font("Serif", 12);
        public static Font ButtonFont = new Font("Hack", 13);
        public static Font GroupBoxFont = new Font("Z003", 18, FontStyle.Bold);
    }

    public static class DefaultColors
    {
        public static Color BackColor = Color.MidnightBlue;
        public static Color HeaderColor = Color.Aqua;
        public static Color TextColor = Color.SkyBlue;
        public static Color BorderColor = Color.MediumBlue;
    }
}
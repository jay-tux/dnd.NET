using System.Windows.Forms;
using System.Drawing;

namespace dnd.NET.GUI
{
    public static class DefaultFonts
    {
        public static Font HeaderFont = new Font("Hack", 20, FontStyle.Bold | FontStyle.Underline);
        public static Font BoldFont = new Font("Serif", 12, FontStyle.Bold);
        public static Font ItalicFont = new Font("Serif", 12, FontStyle.Italic);
        public static Font TextFont = new Font("Serif", 12);
        public static Font ButtonFont = new Font("Hack", 13);
        public static Font EmphasisFont = new Font("Serif", 14, FontStyle.Bold);
        public static Font GroupBoxFont = new Font("Hack", 18, FontStyle.Bold);
    }

    public static class DefaultColors
    {
        public static Color BackColor = Color.FromArgb(1, 4, 64);
        public static Color HeaderColor = Color.FromArgb(80, 5, 242);
        public static Color TextColor = Color.FromArgb(29, 4, 191);
        public static Color BorderColor = Color.FromArgb(80, 5, 242);
        public static Color EmphasisColor = Color.FromArgb(80, 5, 242);
        public static Color ButtonColor = Color.FromArgb(5, 2, 89);
    }
}
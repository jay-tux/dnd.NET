using System.Windows.Forms;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace dnd.NET.GUI
{
    public class StyledGroupBox : GroupBox
    {
        protected int BorderWidth = 3;
        protected int TextIndent = 5;
        protected int BorderRadius = 5;

        public StyledGroupBox(string Text, Size Size, Point Location)
        {
            AutoSize = true;
            BackColor = DefaultColors.BackColor;
            this.Text = Text;
            Font = DefaultFonts.GroupBoxFont;
            Padding = new Padding(12);
            Margin = new Padding(12);
            ForeColor = DefaultColors.HeaderColor;
            Paint += Border;
            this.Size = Size;
            this.Location = Location;
        }

        protected void Border(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Brush textBrush = new SolidBrush(this.ForeColor);
            SizeF strSize = g.MeasureString(this.Text, this.Font);

            Brush borderBrush = new SolidBrush(DefaultColors.BorderColor);
            Pen borderPen = new Pen(borderBrush,(float)this.BorderWidth);
            Rectangle rect = new Rectangle(this.ClientRectangle.X,
                                            this.ClientRectangle.Y + (int)(strSize.Height / 2),
                                            this.ClientRectangle.Width - 1,
                                            this.ClientRectangle.Height - (int)(strSize.Height / 2) - 1);

            Brush labelBrush = new SolidBrush(this.BackColor);

            // Clear text and border
            g.Clear(this.BackColor);

            // Drawing Border (added "Fix" from Jim Fell, Oct 6, '18)
            int rectX = (0 == this.BorderWidth % 2) ? rect.X + this.BorderWidth / 2 : rect.X + 1 + this.BorderWidth / 2;
            int rectHeight = (0 == this.BorderWidth % 2) ? rect.Height - this.BorderWidth / 2 : rect.Height - 1 - this.BorderWidth / 2;
            // NOTE DIFFERENCE: rectX vs rect.X and rectHeight vs rect.Height
            g.DrawRoundedRectangle(borderPen, rect, this.BorderRadius);

            // Draw text
            if (this.Text.Length > 0)
            {
                // Do some work to ensure we don't put the label outside
                // of the box, regardless of what value is assigned to the Indent:
                int width = (int)rect.Width, posX;
                posX = (this.TextIndent < 0) ? Math.Max(0-width,this.TextIndent) : Math.Min(width, this.TextIndent);
                posX = (posX < 0) ? rect.Width + posX - (int)strSize.Width : posX;
                g.FillRectangle(labelBrush, posX - 2, 0, strSize.Width + 4, strSize.Height);
                g.DrawString(this.Text, this.Font, textBrush, posX, 0);
            }
        }
    }
}
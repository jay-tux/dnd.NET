using System.Windows.Forms;
using System.Drawing;
using System.Collections.Generic;
using System;
using System.Drawing.Drawing2D;

namespace dnd.NET.GUI
{
    public class StyledListBox : ListBox
    {
        protected int BorderWidth = 3;
        protected int TextIndent = 5;
        protected int BorderRadius = 5;

        public StyledListBox(List<string> Items, Size Size, Point Location, EventHandler SelectionChanged, EventHandler SelectionEmptied)
        {
            this.Size = Size;
            this.Location = Location;
            Items.ForEach(x => this.Items.Add(x));
            this.BackColor = DefaultColors.BackColor;
            this.ForeColor = DefaultColors.TextColor;
            this.SelectedIndexChanged += SelectionChanged;
            this.MouseDown += (o, e) => { if(IndexFromPoint(e.Location) == NoMatches) { SelectedIndex = -1; SelectionEmptied(this, new EventArgs()); } };
            this.BorderStyle = BorderStyle.None;
        }
    }
}
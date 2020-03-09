using System.Drawing;
using System.Collections.Generic;

namespace dnd.NET.GUI
{
    partial class PlayerForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Size = new Size(800, 450);
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Text = "D&D Player Tool";
            this.BackColor = DefaultColors.BackColor;

            HeaderLabel Header = new HeaderLabel("D&&D 5e Player Tool", new Point(0, 0));
            Header.Location = new Point((int)(((Size.Width / 2) - (Header.Size.Width / 2)) * 0.9), (int)(0.025 * Size.Height));
            StyledGroupBox links = new StyledGroupBox("", 
                new Size((int)(Size.Width * 0.925), (int)(Size.Height * 0.1)), 
                new Point((int)(Size.Width * 0.05), (int)(0.1 * Size.Height)));
            StyledGroupBox mychars = new StyledGroupBox("My Characters",
                new Size((int)(Size.Width * 0.9 / 2), (int)(Size.Height * 0.7)),
                new Point((int)(Size.Width * 0.05), (int)(Size.Height * 0.2)));
            StyledGroupBox actions = new StyledGroupBox("Actions",
                new Size((int)(Size.Width * 0.9 / 2), (int)(Size.Height * 0.7)),
                new Point((int)(Size.Width * 0.525), (int)(Size.Height * 0.2)));

            StyledListBox slb = new StyledListBox(new List<string>(), new Size((int)(mychars.Size.Width * 0.9), (int)(mychars.Size.Height * 0.9)), 
                new Point(15, 35), (o, e) => {}, (o, e) => {});
            MainLabel noFound = new MainLabel("You have no characters yet.", new Point((int)(mychars.Size.Width * 0.15), (int)(mychars.Size.Height * 0.45)), true);
            MainLinkLabel create = new MainLinkLabel("Create one", new Point((int)(mychars.Size.Width * 0.35), (int)(mychars.Size.Height * 0.5)), (o, e) => {}, true);
            MainLinkLabel nchar = new MainLinkLabel("Create Character", new Point(15, 15), (o, e) => CreateChar(), false, false, true);
            MainLinkLabel dchar = new MainLinkLabel("Remove Character", new Point((int)(links.Size.Width * 0.7), 15), (o, e) => DeleteChar(), false, false, true);

            MainLabel name = new MainLabel("----", new Point(45, 25), true);
            MainLabel nosel = new MainLabel("No character selected.", new Point(25, 45), true);
            MainLabel race = new MainLabel("----", new Point(45, 45), true);
            MainLabel clss = new MainLabel("----", new Point(45, 65), true);

            MainLinkLabel view = new MainLinkLabel("Quick Overview", new Point(15, 85), (o, e) => ViewChar());
            MainLinkLabel edit = new MainLinkLabel("Edit Character", new Point(15, 105), (o, e) => EditChar());
            MainLinkLabel rolls = new MainLinkLabel("Character Specific Rolls", new Point(15, 125), (o, e) => RollFor());
            MainLinkLabel Level = new MainLinkLabel("Level Character Up", new Point(15, 145), (o, e) => this.Level());
            MainLinkLabel rem = new MainLinkLabel("Remove Characer", new Point(15, 165), (o, e) => DeleteChar());
            MainLinkLabel exp = new MainLinkLabel("Export Character", new Point(15 ,185), (o, e) => Export());
            MainLinkLabel back = new MainLinkLabel("Go Back", new Point(), (o, e) => Close(), false, false, true);
            back.Location = new Point((int)((links.Size.Width / 2) - (back.Size.Width / 2)), 15);

            links.Controls.Add(nchar);
            links.Controls.Add(dchar);
            links.Controls.Add(back);
            actions.Controls.Add(name);
            actions.Controls.Add(nosel);
            actions.Controls.Add(race);
            actions.Controls.Add(clss);
            actions.Controls.Add(view);
            actions.Controls.Add(edit);
            actions.Controls.Add(rolls);
            actions.Controls.Add(Level);
            actions.Controls.Add(rem);
            actions.Controls.Add(exp);
            mychars.Controls.Add(noFound);
            mychars.Controls.Add(create);
            mychars.Controls.Add(slb);
            this.Controls.Add(Header);
            this.Controls.Add(links);
            this.Controls.Add(mychars);
            this.Controls.Add(actions);
        }

        #endregion
    }
}


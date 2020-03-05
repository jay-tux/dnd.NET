using System.Windows.Forms;
using System;
using System.Drawing;

namespace dnd.NET.GUI
{
    partial class MainWindow
    {
        protected StyledGroupBox PlayerBox;
        protected StyledGroupBox DMBox;
        protected HeaderLabel Header;

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
            this.ClientSize = new System.Drawing.Size(800, 400);
            this.Text = "D&D 5e DM/Player Suite";
            this.BackColor = DefaultColors.BackColor;
            this.Paint += ResizeTools;

            this.Header = new HeaderLabel("D&&D 5e DM/Player Tool", new Point(0, 0));
            this.Header.Location = new Point((int)(((Size.Width / 2) - (this.Header.Size.Width / 2)) * 0.9), (int)(0.025 * Size.Height));
            DMBox = new StyledGroupBox("DM Tools", 
                new Size((int)(Size.Width / 2 * 0.9), (int)(Size.Height * 0.75)), 
                new Point((int)(0.025 * Size.Width), (int)(0.1 * Size.Height)));
            PlayerBox = new StyledGroupBox("Player Tools", 
                new Size((int)(Size.Width / 2 * 0.9), (int)(Size.Height * 0.75)), 
                new Point((int)(Size.Width / 2), (int)(0.1 * Size.Height)));
            MainLinkLabel nchr = new MainLinkLabel("New Character", new Point(15, 25), (o, e) => Player.NewChar());
            MainLinkLabel chrs = new MainLinkLabel("My Characters", new Point(15, 45), (o, e) => Player.StartChars());
            MainLinkLabel dchr = new MainLinkLabel("Remove Character", new Point(15, 65), (o, e) => Player.RmChar());
            MainLinkLabel dice = new MainLinkLabel("Roll Dice", new Point(15, 85), (o, e) => Player.StartDice());
            MainLinkLabel races = new MainLinkLabel("Race Overview", new Point(15, 125), (o, e) => Both.StartRace());
            MainLinkLabel irace = new MainLinkLabel("Import Race", new Point(15, 145), (o, e) => Player.ImportRace());
            MainLinkLabel drace = new MainLinkLabel("Disable Race", new Point(15, 165), (o, e) => Player.DisableRace());
            MainLinkLabel classs = new MainLinkLabel("Class Overview", new Point(15, 205), (o, e) => Both.StartClass());
            MainLinkLabel iclass = new MainLinkLabel("Import Class", new Point(15, 225), (o, e) => Player.ImportClass());
            MainLinkLabel dclass = new MainLinkLabel("Disable Class", new Point(15, 245), (o, e) => Player.DisableClass());

            PlayerBox.Controls.Add(chrs);
            PlayerBox.Controls.Add(dice);
            PlayerBox.Controls.Add(nchr);
            PlayerBox.Controls.Add(dchr);
            PlayerBox.Controls.Add(races);
            PlayerBox.Controls.Add(irace);
            PlayerBox.Controls.Add(drace);
            PlayerBox.Controls.Add(classs);
            PlayerBox.Controls.Add(iclass);
            PlayerBox.Controls.Add(dclass);
            this.Controls.Add(DMBox);
            this.Controls.Add(PlayerBox);
            this.Controls.Add(Header);
        }

        protected void ResizeTools(object sender, EventArgs e)
        {
            this.Header.Location = new Point((int)(((Size.Width / 2) - (this.Header.Size.Width / 2)) * 0.9), (int)(0.025 * Size.Height));
            this.DMBox.Location = new Point((int)(0.025 * Size.Width), (int)(0.1 * Size.Height));
            this.DMBox.Size = new Size((int)(Size.Width / 2 * 0.9), (int)(Size.Height * 0.75));
            this.PlayerBox.Location = new Point((int)(Size.Width / 2), (int)(0.1 * Size.Height));
            this.PlayerBox.Size = new Size((int)(Size.Width / 2 * 0.9), (int)(Size.Height * 0.75));
        }

        #endregion
    }
}


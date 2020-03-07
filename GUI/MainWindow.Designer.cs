﻿using System.Windows.Forms;
using System.Collections.Generic;
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
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            
            MainLinkLabel chrs = new MainLinkLabel("My Characters", new Point(15, 25), (o, e) => Player.StartChars(), false, false, true);
            MainLinkLabel nchr = new MainLinkLabel("New Character", new Point(25, 45), (o, e) => Player.NewChar());
            MainLinkLabel dchr = new MainLinkLabel("Remove Character", new Point(25, 65), (o, e) => Player.RmChar());

            MainLinkLabel dice = new MainLinkLabel("Roll Dice", new Point(15, 105), (o, e) => Player.StartDice(), false, false, true);
            
            MainLinkLabel races = new MainLinkLabel("Race Overview", new Point(15, 145), (o, e) => Both.StartRace(), false, false, true);
            MainLinkLabel irace = new MainLinkLabel("Import Race", new Point(25, 165), (o, e) => Player.ImportRace());
            MainLinkLabel drace = new MainLinkLabel("Disable Race", new Point(25, 185), (o, e) => Player.DisableRace());

            MainLinkLabel classs = new MainLinkLabel("Class Overview", new Point(15, 225), (o, e) => Both.StartClass(), false, false, true);
            MainLinkLabel iclass = new MainLinkLabel("Import Class", new Point(25, 245), (o, e) => Player.ImportClass());
            MainLinkLabel dclass = new MainLinkLabel("Disable Class", new Point(25, 265), (o, e) => Player.DisableClass());

            MainLinkLabel cmps = new MainLinkLabel("My Campaigns", new Point(15, 25), (o, e) => DM.StartCampaigns(), false, false, true);
            MainLinkLabel ncmp = new MainLinkLabel("New Campaign", new Point(25, 45), (o, e) => DM.NewCampaign());
            MainLinkLabel dcmp = new MainLinkLabel("Remove Campaign", new Point(25, 65), (o, e) => DM.RmCampaign());

            MainLinkLabel diceD = new MainLinkLabel("Roll Dice", new Point(15, 105), (o, e) => DM.StartDice(), false, false, true);

            MainLinkLabel racesD = new MainLinkLabel("Race Overview", new Point(15, 145), (o, e) => Both.StartRace(), false, false, true);
            MainLinkLabel nrace = new MainLinkLabel("Create Race", new Point(25, 165), (o, e) => DM.NewRace());
            MainLinkLabel erace = new MainLinkLabel("Export Race List", new Point(25, 185), (o, e) => DM.ExportRaces());
            
            MainLinkLabel classsD = new MainLinkLabel("Class Overview", new Point(15, 225), (o, e) => Both.StartClass(), false, false, true);
            MainLinkLabel nclass = new MainLinkLabel("Create Class", new Point(25, 245), (o, e) => DM.NewClass());
            MainLinkLabel eclass = new MainLinkLabel("Export Classes", new Point(25, 265), (o, e) => DM.ExportClasses());

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
            
            DMBox.Controls.Add(ncmp);
            DMBox.Controls.Add(cmps);
            DMBox.Controls.Add(dcmp);
            DMBox.Controls.Add(diceD);
            DMBox.Controls.Add(racesD);
            DMBox.Controls.Add(nrace);
            DMBox.Controls.Add(erace);
            DMBox.Controls.Add(classsD);
            DMBox.Controls.Add(nclass);
            DMBox.Controls.Add(eclass);

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


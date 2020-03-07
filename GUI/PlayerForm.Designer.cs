using System.Drawing;

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
                new Size((int)(Size.Width * 0.9), (int)(Size.Height * 0.02)), 
                new Point((int)(Size.Width * 0.05), (int)(0.1 * Size.Height)));
            StyledGroupBox mychars = new StyledGroupBox("My Characters",
                new Size((int)(Size.Width * 0.9 / 2), (int)(Size.Height * 0.65)),
                new Point((int)(Size.Width * 0.05), (int)(Size.Height * 0.25)));
            StyledGroupBox actions = new StyledGroupBox("Actions",
                new Size((int)(Size.Width * 0.9 / 2), (int)(Size.Height * 0.65)),
                new Point((int)(Size.Width * 0.525), (int)(Size.Height * 0.25)));

            MainLinkLabel nchar = new MainLinkLabel("Create Character", new Point(15, 15), (o, e) => CreateChar(), false, false, true);
            MainLinkLabel dchar = new MainLinkLabel("Remove Character", new Point((int)(links.Size.Width * 0.75), 15), (o, e) => DeleteChar(), false, false, true);
            MainLinkLabel back = new MainLinkLabel("Go Back", new Point(), (o, e) => Close(), false, false, true);
            back.Location = new Point((int)((links.Size.Width / 2) - (back.Size.Width / 2)), 15);

            links.Controls.Add(nchar);
            links.Controls.Add(dchar);
            links.Controls.Add(back);
            this.Controls.Add(Header);
            this.Controls.Add(links);
            this.Controls.Add(mychars);
            this.Controls.Add(actions);
        }

        #endregion
    }
}


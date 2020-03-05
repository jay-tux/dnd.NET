using System;
using System.Collections.Generic;
using System.ComponentModel;
//using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dnd.NET.GUI
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        protected static class Player
        {
            public static void NewChar() { new PlayerForm(PlayerForm.Action.touch).ShowDialog(); }
            public static void StartChars() { new PlayerForm(PlayerForm.Action.ls).ShowDialog(); }
            public static void StartDice(){ new DiceForm(DiceForm.Action.player).ShowDialog(); }
            public static void RmChar() { new PlayerForm(PlayerForm.Action.rm).ShowDialog(); }

            public static void ImportRace() {}
            public static void DisableRace() {}

            public static void ImportClass() {}
            public static void DisableClass() {}
        }

        protected static class Both
        {
            public static void StartRace() {}
            public static void StartClass() {}
        }

        protected static class DM
        {
            public static void NewCampaign() { new DMView(DMView.Action.touch).ShowDialog(); }
            public static void StartCampaigns() { new DMView(DMView.Action.ls).ShowDialog(); }
            public static void RmCampaign() { new DMView(DMView.Action.rm).ShowDialog(); }
            public static void StartDice() { new DiceForm(DiceForm.Action.dm).ShowDialog(); }
            public static void NewRace() {}
            public static void ExportRaces() {}
            public static void NewClass() {}
            public static void ExportClasses() {}
        }
    }
}

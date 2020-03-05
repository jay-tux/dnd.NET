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

            public static void ImportRace() { new RaceView(RaceView.Action.pull).ShowDialog(); }
            public static void DisableRace() { new RaceView(RaceView.Action.rm).ShowDialog(); }

            public static void ImportClass() { new ClassView(ClassView.Action.pull).ShowDialog(); }
            public static void DisableClass() { new ClassView(ClassView.Action.rm).ShowDialog(); }
        }

        protected static class Both
        {
            public static void StartRace() { new RaceView(RaceView.Action.ls).ShowDialog(); }
            public static void StartClass() { new ClassView(ClassView.Action.ls).ShowDialog(); }
        }

        protected static class DM
        {
            public static void NewCampaign() { new DMView(DMView.Action.touch).ShowDialog(); }
            public static void StartCampaigns() { new DMView(DMView.Action.ls).ShowDialog(); }
            public static void RmCampaign() { new DMView(DMView.Action.rm).ShowDialog(); }
            public static void StartDice() { new DiceForm(DiceForm.Action.dm).ShowDialog(); }

            public static void NewRace() { new RaceView(RaceView.Action.touch).ShowDialog(); }
            public static void ExportRaces() { new RaceView(RaceView.Action.push).ShowDialog(); }

            public static void NewClass() { new ClassView(ClassView.Action.touch).ShowDialog(); }
            public static void ExportClasses() { new ClassView(ClassView.Action.push).ShowDialog(); }
        }
    }
}

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
            public static void NewChar() {}
            public static void StartChars() {}
            public static void StartDice(){}
            public static void RmChar() {}

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
            public static void NewCampaign() {}
            public static void StartCampaigns() {}
            public static void RmCampaign() {}
            public static void StartDice() {}
            public static void NewRace() {}
            public static void ExportRaces() {}
            public static void NewClass() {}
            public static void ExportClasses() {}
        }
    }
}

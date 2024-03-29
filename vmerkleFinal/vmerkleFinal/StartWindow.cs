using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vmerkleFinal
{
    public partial class StartWindow : Form
    {
        private static GameWindow newGameWindow = new GameWindow();

        public static GameWindow Game
        {
            get { return newGameWindow; }
            set { newGameWindow = value; }
        }

        public StartWindow() //opens and sets up the form
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e) //Exits the form when clicked
        {
            this.Close();
        }

        private void startButton_Click(object sender, EventArgs e) //Calls the game form when clicked
        {
            newGameWindow = new GameWindow();
            newGameWindow.Show();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace SnakeWPF
{
    /// <summary>
    /// Interaction logic for Game.xaml
    /// </summary>
    /// 
    public enum Direction
    {
        Up,
        Right,
        Down,
        Left
    }
    public partial class Game : Window
    {
        //variables and consts
        private const int minimi= 5;
        private const int maxHeight = 620;
        private const int maxWidth = 380;
        private int snakeWidth = 10;
        private int snakeLength = 100;
        private int easiness = 20;
        private int score = 0;

        public Game()
        {
            InitializeComponent();
        }
    }
}

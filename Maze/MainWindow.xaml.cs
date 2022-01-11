using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Maze
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<MazeColRow> _mazeSpaces;
        Label explorer;
        int explorerRow = 3;
        int explorerCol = 3;
        private List<MazeColRow> _recordMoves = new List<MazeColRow>();

        public MainWindow()
        {
            InitializeComponent();
            _mazeSpaces = MazeHelpers.GetBlancWalls();
            int mazeRows = 15;
            int mazeCol = 15;
            emptywalls.Content = $"Empty Spaces({_mazeSpaces.Count})";
            Totalwalls.Content = $"Number of walls({225 -_mazeSpaces.Count})";

            //var grid = (GridMaze)Grid;

            for (int i = 0; i < mazeRows; i++)
            {
                Label lable = new();
                lable.Name = $"Row{i.ToString()}";
                lable.Content = "X";
                lable.HorizontalAlignment = HorizontalAlignment.Center;
                lable.VerticalAlignment = VerticalAlignment.Center;
                lable.FontSize = 35;
                Grid.SetRow(lable, i);
                Grid.SetColumn(lable, 0);
                GridMaze.Children.Add(lable);
                for (int j = 0; j < mazeCol; j++)
                {
                    if (!DonotWrite(i, j))
                    {
                        Label collable = new();
                        collable.Name = $"RowCol{i.ToString()}{j.ToString()}";
                        collable.Content = "X";
                        collable.HorizontalAlignment = HorizontalAlignment.Center;
                        collable.VerticalAlignment = VerticalAlignment.Center;
                        collable.FontSize = 35;
                        Grid.SetRow(collable, i);
                        Grid.SetColumn(collable, j);
                        GridMaze.Children.Add(collable);
                    }

                }

            }
            LoadStartUp();
        }
        void LoadStartUp()
        {
            explorer = new Label();
            explorer.Name = "explorer";
            explorer.Content = "S";
            explorer.HorizontalAlignment = HorizontalAlignment.Center;
            explorer.VerticalAlignment = VerticalAlignment.Center;
            explorer.FontSize = 35;
            Grid.SetRow(explorer, explorerRow);
            Grid.SetColumn(explorer, explorerCol);
            GridMaze.Children.Add(explorer);
            exploraCoord.Content = $" Row coordinate {explorerRow} Col coordinate {explorerCol}";
            _recordMoves.Add(new MazeColRow { Row = explorerRow, Col = explorerCol });
        }
       
        void Move(int explorerRow, int explorerCol)
        {
            if (DonotWrite(explorerRow, explorerCol))
            {
                clearExplorer();
                explorer = new Label();
                explorer.Name = "explorer";
                explorer.Content = "S";
                explorer.HorizontalAlignment = HorizontalAlignment.Center;
                explorer.VerticalAlignment = VerticalAlignment.Center;
                explorer.FontSize = 35;
                Grid.SetRow(explorer, explorerRow);
                Grid.SetColumn(explorer, explorerCol);
                GridMaze.Children.Add(explorer);
                this.explorerRow = explorerRow;
                this.explorerCol = explorerCol;
                exploraCoord.Content = $" Row coordinate {explorerRow} Col coordinate {explorerCol}";
                _recordMoves.Add(new MazeColRow { Row = explorerRow, Col = explorerCol });
            }

        }
        void MoveRecord(int explorerRow, int explorerCol)
        {
            if (DonotWrite(explorerRow, explorerCol))
            {
                clearExplorer();
                explorer = new Label();
                explorer.Name = "explorer";
                explorer.Content = "S";
                explorer.HorizontalAlignment = HorizontalAlignment.Center;
                explorer.VerticalAlignment = VerticalAlignment.Center;
                explorer.FontSize = 35;
                Grid.SetRow(explorer, explorerRow);
                Grid.SetColumn(explorer, explorerCol);
                GridMaze.Children.Add(explorer);
                this.explorerRow = explorerRow;
                this.explorerCol = explorerCol;
                exploraCoord.Content = $" Row coordinate {explorerRow} Col coordinate {explorerCol}";
            }

        }
        void clearExplorer()
        {
            explorer.Content = " ";
        }

        bool DonotWrite(int row, int column)
        {
           
            var result = _mazeSpaces.Where(r => r.Row == row && r.Col == column).FirstOrDefault();
            if (result != null)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        private void btnSearchCoordinate_Click(object sender, RoutedEventArgs e)
        {

            var row = int.Parse(xcoordinate.Text);
            var column = int.Parse(ycoordinate.Text);
            if(row < 0 && row > 14)
            {
                MessageBox.Show("Row coordinate should be between 0 and 14 ");
                return;
            }
            if (column < 0 && column > 14)
            {
                MessageBox.Show("Col coordinate should be between 0 and 14 ");
                return;
            }
            if (!DonotWrite(row, column))
            {
                MessageBox.Show("point is Wall X");
            }
            else
            {
                MessageBox.Show("point is Space");
            }
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Key == Key.Up)
            {
                int upRow = this.explorerRow - 1;
                Move(upRow, explorerCol);
            }
            if (e.Key == Key.Down)
            {
                int upRow = this.explorerRow + 1;
                Move(upRow, explorerCol);
            }
            if (e.Key == Key.Right)
            {
                int keyCol = this.explorerCol + 1;
                Move(explorerRow, keyCol);
            }
            if (e.Key == Key.Left)
            {
                int keyCol = this.explorerCol - 1;
                Move(explorerRow, keyCol);
            }
        }
        async void  route()
        {
            foreach (var explorer in _recordMoves)
            {
                MoveRecord(explorer.Row, explorer.Col);
                await Task.Delay(500);

            }
        }

        private void PlayForword_Click(object sender, RoutedEventArgs e)
        {
            route();
        }
    }
}

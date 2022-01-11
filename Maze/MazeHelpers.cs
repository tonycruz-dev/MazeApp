using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maze
{
    public static class MazeHelpers
    {
        public static List<MazeColRow> GetBlancWalls()
        {
           return new List<MazeColRow>
            {
                new MazeColRow()
                {
                    Col = 1,
                    Row = 1
                },new MazeColRow()
                {
                    Col = 2,
                    Row = 1
                },new MazeColRow()
                {
                    Col = 3,
                    Row = 1
                },new MazeColRow()
                {
                    Col = 4,
                    Row = 1
                },new MazeColRow()
                {
                    Col = 5,
                    Row = 1
                },new MazeColRow()
                {
                    Col = 6,
                    Row = 1
                },new MazeColRow()
                {
                    Col = 7,
                    Row = 1
                },new MazeColRow()
                {
                    Col = 8,
                    Row = 1
                },new MazeColRow()
                {
                    Col = 9,
                    Row = 1
                },new MazeColRow()
                {
                    Col = 10,
                    Row = 1
                },new MazeColRow()
                {
                    Col = 11,
                    Row = 1
                },new MazeColRow()
                {
                    Col = 12,
                    Row = 1
                },new MazeColRow()
                {
                    Col = 13,
                    Row = 1
                }

                ,new MazeColRow()
                {
                    Col = 1,
                    Row = 2
                },new MazeColRow()
                {
                    Col = 1,
                    Row = 3
                },new MazeColRow()
                {
                    Col = 1,
                    Row = 4
                },new MazeColRow()
                {
                    Col = 1,
                    Row = 5
                },new MazeColRow()
                {
                    Col = 1,
                    Row = 6
                },new MazeColRow()
                {
                    Col = 1,
                    Row = 7
                },new MazeColRow()
                {
                    Col = 1,
                    Row = 8
                },new MazeColRow()
                {
                    Col = 1,
                    Row = 9
                },new MazeColRow()
                {
                    Col = 1,
                    Row = 10
                },new MazeColRow()
                {
                    Col = 1,
                    Row = 11
                },new MazeColRow()
                {
                    Col = 1,
                    Row = 12
                },new MazeColRow()
                {
                    Col = 1,
                    Row = 13
                },new MazeColRow()
                {
                    Col = 1,
                    Row = 14
                },new MazeColRow()
                {
                    Col = 1,
                    Row = 15
                },
                new MazeColRow()
                {
                    Col = 13,
                    Row = 2
                },new MazeColRow()
                {
                    Col = 13,
                    Row = 3
                },new MazeColRow()
                {
                    Col = 13,
                    Row = 4
                },new MazeColRow()
                {
                    Col = 13,
                    Row = 5
                },new MazeColRow()
                {
                   Col = 13,
                    Row = 6
                },new MazeColRow()
                {
                    Col = 13,
                    Row = 7
                },new MazeColRow()
                {
                    Col = 13,
                    Row = 8
                },new MazeColRow()
                {
                    Col = 13,
                    Row = 9
                },new MazeColRow()
                {
                    Col = 13,
                    Row = 10
                },new MazeColRow()
                {
                    Col = 13,
                    Row = 11
                },new MazeColRow()
                {
                    Col = 13,
                    Row = 12
                },new MazeColRow()
                {
                    Col = 13,
                    Row = 13
                },
                new MazeColRow()
                {
                    Col = 12,
                    Row = 13
                }, new MazeColRow()
                {
                    Col = 11,
                    Row = 13
                },new MazeColRow()
                {
                    Col = 11,
                    Row = 12
                },
                new MazeColRow()
                {
                    Col = 10,
                    Row = 12
                },new MazeColRow()
                {
                    Col = 9,
                    Row = 12
                }, new MazeColRow()
                {
                    Col = 8,
                    Row = 12
                },new MazeColRow()
                {
                    Col = 7,
                    Row = 12
                },new MazeColRow()
                {
                    Col = 6,
                    Row = 12
                },new MazeColRow()
                {
                    Col = 5,
                    Row = 12
                },new MazeColRow()
                {
                    Col = 4,
                    Row = 12
                },new MazeColRow()
                {
                    Col = 3,
                    Row = 12
                },new MazeColRow()
                {
                    Col = 3,
                    Row = 11
                },new MazeColRow()
                {
                    Col = 3,
                    Row = 10
                },new MazeColRow()
                {
                    Col = 3,
                    Row = 9
                },new MazeColRow()
                {
                    Col = 4,
                    Row = 9
                },new MazeColRow()
                {
                    Col = 5,
                    Row = 9
                },new MazeColRow()
                {
                    Col = 6,
                    Row = 9
                },new MazeColRow()
                {
                    Col = 6,
                    Row = 8
                },new MazeColRow()
                {
                    Col = 6,
                    Row = 7
                },new MazeColRow()
                {
                    Col = 6,
                    Row = 6
                },new MazeColRow()
                {
                    Col = 7,
                    Row = 6
                },new MazeColRow()
                {
                    Col = 8,
                    Row = 6
                },new MazeColRow()
                {
                    Col = 8,
                    Row = 6
                },new MazeColRow()
                {
                    Col = 9,
                    Row = 6
                },new MazeColRow()
                {
                    Col = 10,
                    Row = 6
                },new MazeColRow()
                {
                    Col = 11,
                    Row = 6
                },new MazeColRow()
                {
                    Col = 11,
                    Row = 5
                },new MazeColRow()
                {
                    Col = 11,
                    Row = 4
                },new MazeColRow()
                {
                    Col = 11,
                    Row = 3
                },new MazeColRow()
                {
                    Col = 10,
                    Row = 3
                },new MazeColRow()
                {
                    Col = 9,
                    Row = 3
                },new MazeColRow()
                {
                    Col = 8,
                    Row = 3
                },new MazeColRow()
                {
                    Col = 7,
                    Row = 3
                },new MazeColRow()
                {
                    Col = 6,
                    Row = 3
                },new MazeColRow()
                {
                    Col = 5,
                    Row = 3
                },new MazeColRow()
                {
                    Col = 4,
                    Row = 3
                },new MazeColRow()
                {
                    Col = 3,
                    Row = 3
                },

            };
            //return RowShouldNotWrite;
        }
    }
}

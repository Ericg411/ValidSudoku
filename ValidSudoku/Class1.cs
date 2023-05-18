using System.Collections;

namespace ValidSudoku;
public class Class1
{
    public bool IsValidSudoku(char[][] board)
    {
        IList<IList<char>> horizontal = new List<IList<char>>();
        IList<IList<char>> vertical = new List<IList<char>>();
        IList<IList<char>> grid = new List<IList<char>>();

        for (int i = 0; i < board.Length; i++)
        {
            horizontal.Add(board[i].ToList());
        }

        IList<char> list0 = new List<char>();
        IList<char> list1 = new List<char>();
        IList<char> list2 = new List<char>();
        IList<char> list3 = new List<char>();
        IList<char> list4 = new List<char>();
        IList<char> list5 = new List<char>();
        IList<char> list6 = new List<char>();
        IList<char> list7 = new List<char>();
        IList<char> list8 = new List<char>();

        for (int i = 0; i < board.Length; i++)
        {
            for (int j = 0; j < board[i].Length; j++)
            {
                switch (j)
                {
                    case 0:
                        list0.Add(board[i][j]);
                        break;
                    case 1:
                        list1.Add(board[i][j]);
                        break;
                    case 2:
                        list2.Add(board[i][j]);
                        break;
                    case 3:
                        list3.Add(board[i][j]);
                        break;
                    case 4:
                        list4.Add(board[i][j]);
                        break;
                    case 5:
                        list5.Add(board[i][j]);
                        break;
                    case 6:
                        list6.Add(board[i][j]);
                        break;
                    case 7:
                        list7.Add(board[i][j]);
                        break;
                    case 8:
                        list8.Add(board[i][j]);
                        break;
                    default:
                        break;
                }
            }
        }

        vertical.Add(list0);
        vertical.Add(list1);
        vertical.Add(list2);
        vertical.Add(list3);
        vertical.Add(list4);
        vertical.Add(list5);
        vertical.Add(list6);
        vertical.Add(list7);
        vertical.Add(list8);

        IList<char> list9 = new List<char>();
        IList<char> list10 = new List<char>();
        IList<char> list11 = new List<char>();
        IList<char> list12 = new List<char>();
        IList<char> list13 = new List<char>();
        IList<char> list14 = new List<char>();
        IList<char> list15 = new List<char>();
        IList<char> list16 = new List<char>();
        IList<char> list17 = new List<char>();

        for (int i = 0; i < board.Length; i++)
        {
            for (int j = 0; j < board[i].Length; j++)
            {
                if (i <= 2 && j <= 2)
                {
                    list9.Add(board[i][j]);
                }
                else if (i > 2 && i <= 5 && j <= 2)
                {
                    list10.Add(board[i][j]);
                }
                else if (i > 5 && i < board.Length && j <= 2)
                {
                    list11.Add(board[i][j]);
                }
                else if (i <= 2 && j > 2 && j <= 5)
                {
                    list12.Add(board[i][j]);
                }
                else if (i > 2 && i <= 5 && j > 2 && j <= 5)
                {
                    list13.Add(board[i][j]);
                }
                else if (i > 5 && i < board.Length && j > 2 && j <= 5)
                {
                    list14.Add(board[i][j]);
                }
                else if (i <= 2 && j > 5 && j < board[i].Length)
                {
                    list15.Add(board[i][j]);
                }
                else if (i > 2 && i <= 5 && j > 5 && j < board[i].Length)
                {
                    list16.Add(board[i][j]);
                }
                else if (i > 5 && i < board.Length && j > 5 && j < board[i].Length)
                {
                    list17.Add(board[i][j]);
                }
            }
        }

        grid.Add(list9);
        grid.Add(list10);
        grid.Add(list11);
        grid.Add(list12);
        grid.Add(list13);
        grid.Add(list14);
        grid.Add(list15);
        grid.Add(list16);
        grid.Add(list17);

        bool horCheck = Checker(horizontal);
        bool verCheck = Checker(vertical);
        bool griCheck = Checker(grid);

        if (horCheck && verCheck && griCheck)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public bool Checker(IList<IList<char>> list)
    {
        foreach (IList<char> l in list)
        {
            var result = innerChecker(l, newHash());
            if (!result)
            {
                return false;
            }
        }
        return true;
    }

    public bool innerChecker(IList<char> list, Hashtable table)
    {
        foreach (char c in list)
        {
            table[c] = (int)table[c] + 1;
            if (c != '.' && (int)table[c] >= 2)
            {
                return false;
            }
        }

        return true;
    }

    public Hashtable newHash()
    {
        Hashtable numbas = new Hashtable();
        numbas.Add('1', 0);
        numbas.Add('2', 0);
        numbas.Add('3', 0);
        numbas.Add('4', 0);
        numbas.Add('5', 0);
        numbas.Add('6', 0);
        numbas.Add('7', 0);
        numbas.Add('8', 0);
        numbas.Add('9', 0);
        numbas.Add('.', 0);
        return numbas;
    }
}

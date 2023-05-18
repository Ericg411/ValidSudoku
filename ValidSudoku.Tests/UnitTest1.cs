namespace ValidSudoku.Tests;

[TestClass]
public class UnitTest1
{
    private readonly Class1 _test;

    public UnitTest1() 
    {
        _test = new Class1();
    }

    [TestMethod]
    public void True()
    {
        char[][] board = new char[9][];
        board[0] = new char[] { '5', '3', '.', '.', '7', '.', '.', '.', '.' };
        board[1] = new char[] { '6', '.', '.', '1', '9', '5', '.', '.', '.' };
        board[2] = new char[] { '.', '9', '8', '.', '.', '.', '.', '6', '.' };
        board[3] = new char[] { '8', '.', '.', '.', '6', '.', '.', '.', '3' };
        board[4] = new char[] { '4', '.', '.', '8', '.', '3', '.', '.', '1' };
        board[5] = new char[] { '7', '.', '.', '.', '2', '.', '.', '.', '6' };
        board[6] = new char[] { '.', '6', '.', '.', '.', '.', '2', '8', '.' };
        board[7] = new char[] { '.', '.', '.', '4', '1', '9', '.', '.', '5' };
        board[8] = new char[] { '.', '.', '.', '.', '8', '.', '.', '7', '9' };

        var result = _test.IsValidSudoku(board);

        Assert.IsTrue(result);
    }

    [TestMethod]
    public void False()
    {
        char[][] board = new char[9][];
        board[0] = new char[] { '8', '3', '.', '.', '7', '.', '.', '.', '.' };
        board[1] = new char[] { '6', '.', '.', '1', '9', '5', '.', '.', '.' };
        board[2] = new char[] { '.', '9', '8', '.', '.', '.', '.', '6', '.' };
        board[3] = new char[] { '8', '.', '.', '.', '6', '.', '.', '.', '3' };
        board[4] = new char[] { '4', '.', '.', '8', '.', '3', '.', '.', '1' };
        board[5] = new char[] { '7', '.', '.', '.', '2', '.', '.', '.', '6' };
        board[6] = new char[] { '.', '6', '.', '.', '.', '.', '2', '8', '.' };
        board[7] = new char[] { '.', '.', '.', '4', '1', '9', '.', '.', '5' };
        board[8] = new char[] { '.', '.', '.', '.', '8', '.', '.', '7', '9' };

        var result = _test.IsValidSudoku(board);

        Assert.IsFalse(result);
    }
}
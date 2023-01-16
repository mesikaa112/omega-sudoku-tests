using Microsoft.VisualStudio.TestTools.UnitTesting;
using OmegaSudoku;
using OmegaSudoku.Exceptions;

namespace SudokuTests
{
    /// <summary>
    /// This class represented the test for sudoku board 4X4
    /// </summary>
    [TestClass]
    public class TestsForSudokuBoard4X4
    {
        /// <summary>
        /// Test number 1: 4X4 Board - Solveable (empty board)
        /// </summary>
        [TestMethod]
        public void Board4X4_Solveable_Test1()
        {
            // Set the board and the expected solution
            string board = "0000000000000000";
            string expectedSolution = "1234341221434321";

            // Solve the Board
            string actualSolution = SolveSudoku.Solve(board, "");

            // Check if the expected solution equals to the actual solution
            Assert.AreEqual(expectedSolution, actualSolution);
        }

        /// <summary>
        /// Test number 2: 4X4 Board - Solveable
        /// </summary>
        [TestMethod]
        public void Board4X4_Solveable_Test2()
        {
            // Set the board and the expected solution
            string board = "0340400210030210";
            string expectedSolution = "2341413214233214";

            // Solve the Board
            string actualSolution = SolveSudoku.Solve(board, "");

            // Check if the expected solution equals to the actual solution
            Assert.AreEqual(expectedSolution, actualSolution);
        }

        /// <summary>
        /// Test number 3: 4X4 Board - Solved
        /// </summary>
        [TestMethod]
        public void Board4X4_Solved_Test3()
        {
            // Set the board and the expected solution
            string board = "3214412314322341";
            string expectedSolution = "3214412314322341";

            // Solve the Board
            string actualSolution = SolveSudoku.Solve(board, "");

            // Check if the expected solution equals to the actual solution
            Assert.AreEqual(expectedSolution, actualSolution);
        }

        /// <summary>
        /// Test number 4: 4X4 Board - Unsolveable
        /// </summary>
        [TestMethod]
        public void Board4X4_Unsolveable_Test4()
        {
            // Set the board
            string board = "1240403004033100";

            // Solve the Board and check if UnSolveableBoardError thrown
            Assert.ThrowsException<UnSolveableBoardError>(() => SolveSudoku.Solve(board, ""));
        }

        /// <summary>
        /// Test number 5: 4X4 Board - 2 or more same values in the same row
        /// </summary>
        [TestMethod]
        public void Board4X4_TwoSameValuesInTheSameRow_Test5()
        {
            // Set the board
            string board = "2000003004000011";

            // Solve the Board and check if TwoValuesInTheSameRowError thrown
            Assert.ThrowsException<TwoValuesInTheSameRowError>(() => SolveSudoku.Solve(board, ""));
        }

        /// <summary>
        /// Test number 6: 4X4 Board - 2 or more same values in the same col
        /// </summary>
        [TestMethod]
        public void Board4X4_TwoSameValuesInTheSameCol_Test6()
        {
            // Set the board
            string board = "0010401000020300";

            // Solve the Board and check if TwoValuesInTheSameColError thrown
            Assert.ThrowsException<TwoValuesInTheSameColError>(() => SolveSudoku.Solve(board, ""));
        }

        /// <summary>
        /// Test number 7: 4X4 Board - 2 or more same values in the same sub square
        /// </summary>
        [TestMethod]
        public void Board4X4_TwoSameValuesInTheSameSubSquare_Test7()
        {
            // Set the board
            string board = "0130100000003421";

            // Solve the Board and check if TwoValuesInTheSameSubSquareError thrown
            Assert.ThrowsException<TwoValuesInTheSameSubSquareError>(() => SolveSudoku.Solve(board, ""));
        }
    }
}

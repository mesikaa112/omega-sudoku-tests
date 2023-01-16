using Microsoft.VisualStudio.TestTools.UnitTesting;
using OmegaSudoku;
using OmegaSudoku.Exceptions;

namespace SudokuTests
{
    /// <summary>
    /// This class represented the test for sudoku board 9X9
    /// </summary>
    [TestClass]
    public class TestsForSudokuBoard9X9
    {
        /// <summary>
        /// Test number 1: 9X9 Board - Solveable (empty board)
        /// </summary>
        [TestMethod]
        public void Board9X9_Solveable_Test1()
        {
            // Set the board and the expected solution
            string board = "000000000000000000000000000000000000000000000000000000000000000000000000000000000";
            string expectedSolution = "123456789687139254495278136712893465956714823348625917261347598879561342534982671";

            // Solve the Board
            string actualSolution = SolveSudoku.Solve(board, "");

            // Check if the expected solution equals to the actual solution
            Assert.AreEqual(expectedSolution, actualSolution);
        }

        /// <summary>
        /// Test number 1: 9X9 Board - Solveable
        /// </summary>
        [TestMethod]
        public void Board9X9_Solveable_Test2()
        {
            // Set the board and the expected solution
            string board = "000000000000003085001020000000507000004000100090000000500000073002010000000040009";
            string expectedSolution = "987654321246173985351928746128537694634892157795461832519286473472319568863745219";

            // Solve the Board
            string actualSolution = SolveSudoku.Solve(board, "");

            // Check if the expected solution equals to the actual solution
            Assert.AreEqual(expectedSolution, actualSolution);
        }

        /// <summary>
        /// Test number 3: 9X9 Board - Solved
        /// </summary>
        [TestMethod]
        public void Board9X9_Solved_Test3()
        {
            // Set the board and the expected solution
            string board = "831529674796814253542637189159783426483296715627145938365471892274958361918362547";
            string expectedSolution = "831529674796814253542637189159783426483296715627145938365471892274958361918362547";

            // Solve the Board
            string actualSolution = SolveSudoku.Solve(board, "");

            // Check if the expected solution equals to the actual solution
            Assert.AreEqual(expectedSolution, actualSolution);
        }

        /// <summary>
        /// Test number 4: 9X9 Board - Unsolveable
        /// </summary>
        [TestMethod]
        public void Board9X9_Unsolveable_Test4()
        {
            // Set the board
            string board = "403000002080050000700800049000000100006003000900500078009060014000400200100000500";

            // Solve the Board and check if UnSolveableBoardError thrown
            Assert.ThrowsException<UnSolveableBoardError>(() => SolveSudoku.Solve(board, ""));
        }

        /// <summary>
        /// Test number 5: 9X9 Board - 2 or more same values in the same row
        /// </summary>
        [TestMethod]
        public void Board9X9_TwoSameValuesInTheSameRow_Test5()
        {
            // Set the board
            string board = "000006000059000008200008000045000000003000000006003054000325006000000000040400000";

            // Solve the Board and check if TwoValuesInTheSameRowError thrown
            Assert.ThrowsException<TwoValuesInTheSameRowError>(() => SolveSudoku.Solve(board, ""));
        }

        /// <summary>
        /// Test number 6: 9X9 Board - 2 or more same values in the same col
        /// </summary>
        [TestMethod]
        public void Board9X9_TwoSameValuesInTheSameCol_Test6()
        {
            // Set the board
            string board = "530070001600195000098000060800060003400803001700020006060000280000419005000080079";

            // Solve the Board and check if TwoValuesInTheSameColError thrown
            Assert.ThrowsException<TwoValuesInTheSameColError>(() => SolveSudoku.Solve(board, ""));
        }

        /// <summary>
        /// Test number 7: 9X9 Board - 2 or more same values in the same sub square     
        /// </summary>
        [TestMethod]
        public void Board9X9_TwoSameValuesInTheSameSubSquare_Test7()
        {
            // Set the board
            string board = "072346080300000100700000300901407068807060090006000410210600070400000050600900030";

            // Solve the Board and check if TwoValuesInTheSameSubSquareError thrown
            Assert.ThrowsException<TwoValuesInTheSameSubSquareError>(() => SolveSudoku.Solve(board, ""));
        }
    }
}

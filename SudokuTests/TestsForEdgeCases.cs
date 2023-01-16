using Microsoft.VisualStudio.TestTools.UnitTesting;
using OmegaSudoku;
using OmegaSudoku.Exceptions;

namespace SudokuTests
{
    /// <summary>
    /// This class represented the test for edge cases
    /// </summary>
    [TestClass]
    public class TestsForEdgeCases
    {
        /// <summary>
        /// Test number 1: Empty board
        /// </summary>
        [TestMethod]
        public void EmptyBoard_Test1()
        {
            // Set the board
            string board = "";

            // Solve the Board and check if NullBoardError thrown
            Assert.ThrowsException<NullBoardError>(() => SolveSudoku.Solve(board, ""));
        }

        /// <summary>
        /// Test number 2: Empty board
        /// </summary>
        [TestMethod]
        public void Board_WithSpaces_Test2()
        {
            // Set the board
            string board = "\t\t   \t \r \n \n \t    ";

            // Solve the Board and check if NullBoardError thrown
            Assert.ThrowsException<NullBoardError>(() => SolveSudoku.Solve(board, ""));
        }

        /// <summary>
        /// Test number 3: Null board
        /// </summary>
        [TestMethod]
        public void NullBoard_Test3()
        {
            // Set the board
            string? board = null;

            // Solve the Board and check if NullBoardError thrown
            Assert.ThrowsException<NullBoardError>(() => SolveSudoku.Solve(board, ""));
        }

        /// <summary>
        /// Test number 4: Board that contains one space (' ')
        /// </summary>
        [TestMethod]
        public void Board_WithSpace_Test4()
        {
            // Set the board
            string board = " ";

            // Solve the Board and check if NullBoardError thrown
            Assert.ThrowsException<NullBoardError>(() => SolveSudoku.Solve(board, ""));
        }

        /// <summary>
        /// Test number 5: Invalid board by length
        /// </summary>
        [TestMethod]
        public void InvalidBoard_ByLength_Test5()
        {
            // Set the board
            string board = "00400102030";

            // Solve the Board and check if InvalidBoardLengthError thrown
            Assert.ThrowsException<InvalidBoardLengthError>(() => SolveSudoku.Solve(board, ""));
        }

        /// <summary>
        /// Test number 6: Invalid board by character
        /// </summary>
        [TestMethod]
        public void InvalidBoard_ByCharacter_Test6()
        {
            // Set the board
            string board = "0130010012400007";

            // Solve the Board and check if InvalidCharactersInTheStringError thrown
            Assert.ThrowsException<InvalidCharactersInTheStringError>(() => SolveSudoku.Solve(board, ""));
        }

        /// <summary>
        /// Test number 7: Invalid file - Empty file
        /// </summary>
        [TestMethod]
        public void InvalidFile_EmptyFile_Test7()
        {
            // Set the file psth
            string? filePath = "";

            // Try to Read from the file and check if FileNotFoundException thrown
            Assert.ThrowsException<FileNotFoundException>(() => SolveSudoku.ReadFromFile(filePath));
        }

        /// <summary>
        /// Test number 8: Invalid file - Null file
        /// </summary>
        [TestMethod]
        public void InvalidFile_NullFile_Test8()
        {
            // Set the file psth
            string? filePath = null;

            // Try to Read from the file and check if FileNotFoundException thrown
            Assert.ThrowsException<FileNotFoundException>(() => SolveSudoku.ReadFromFile(filePath));
        }

        /// <summary>
        /// Test number 9: Invalid file - not a text file
        /// </summary>
        [TestMethod]
        public void InvalidFile_NotTextFile_Test9()
        {
            // Set the file psth
            string? filePath = "picture.png";

            // Try to Read from the file and check if FileIsNotTextFileException thrown
            Assert.ThrowsException<FileIsNotTextFileException>(() => SolveSudoku.ReadFromFile(filePath));
        }
    }
}

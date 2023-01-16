using Microsoft.VisualStudio.TestTools.UnitTesting;
using OmegaSudoku;
using OmegaSudoku.Exceptions;

namespace SudokuTests
{
    /// <summary>
    /// This class represented the test for sudoku board 16X16
    /// </summary>
    [TestClass]
    public class TestsForSudokuBoard16x16
    {
        /// <summary>
        /// Test number 1: 16X16 Board - Solveable (empty board)
        /// </summary>
        [TestMethod]
        public void Board16X16_Solveable_Test1()
        {
            // Set the board and the expected solution
            string board = "0000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000";
            string expectedSolution = "123456789:;<=>?@?=@714;<368>29:5<;:>2=9?145@368768593:>@27?=14;<9123?@475<>8:;6=:6?;815=@34972<>>@<=926;?17:53484578>3<:=26;@19?3?127<84:>@6;=598<=6@?15;934>72:79>@:;268=15?<3454;:=>39<?278@16236145=>78<?9:@;=:8?67@14;93<5>2@>9<;8:265=14?73;745<9?3>@:268=1";

            // Solve the Board
            string actualSolution = SolveSudoku.Solve(board, "");

            // Check if the expected solution equals to the actual solution
            Assert.AreEqual(expectedSolution, actualSolution);
        }

        /// <summary>
        /// Test number 2: 16X16 Board - Solveable
        /// </summary>
        [TestMethod]
        public void Board16X16_Solveable_Test2()
        {
            // Set the board and the expected solution
            string board = "0>0000030060402?000=08104000>0@580702000>00000=0?000000<0309000803600002;@?40050070000;@0=50000:00005>000000728000059:0070010000009>03600000@00006801700054;090002004;00000<0803005000=008:00000=9003601?4700000000002?40>;@0:00200000500:000006@00;<09080000070";
            string expectedSolution = "5><@=9:317684;2?9:3=68174;2?><@581762?4;><@5:3=9?4;2@5><:3=91768:3698172;@?4<=5>1728?4;@<=5>369:4;@?5><=369:7281><=59:367281;@?4<=9>:3682?17@54;368:172?@54;=9><72?14;@5=9><68:3;@54><=968:32?17=9:<3681?4725>;@681372?45>;@9:<=2?47;@5>9:<=8136@5>;<=9:8136?472";

            // Solve the Board
            string actualSolution = SolveSudoku.Solve(board, "");

            // Check if the expected solution equals to the actual solution
            Assert.AreEqual(expectedSolution, actualSolution);
        }

        /// <summary>
        /// Test number 3: 16X16 Board - Solveable
        /// </summary>
        [TestMethod]
        public void Board16X16_Solveable_Test3()
        {
            // Set the board and the expected solution
            string board = "00040000005007=00000>@560=0?300006>00000000080<:00001093;0:00000?0@502370000;<:007=2490000600@0000090000000>00200;0:05?>00000400005?001000;0<:000=230000000<05000008:600000@0001>0:60?7003104900@00>07000140900000073042800000000030800000@:500=<90;6>0:07000300";
            string expectedSolution = "9314;<:8>@56?7=2:8;<>@567=2?314956>@7=2?14938;<:2?7=1493;<:86>@5?>@5=2374981;<:637=24981<:6;>@5?8149<:6;@5?>7=236;<:@5?>=23714987@5?231=98;4<:6>1=2398;4:6><@5?7;498:6><5?7@=231><:65?7@231=498;@:6>?7=5314298;<=5?731428;<9:6>@42318;<96>@:5?7=<98;6>@:?7=52314";

            // Solve the Board
            string actualSolution = SolveSudoku.Solve(board, "");

            // Check if the expected solution equals to the actual solution
            Assert.AreEqual(expectedSolution, actualSolution);
        }

        /// <summary>
        /// Test number 4: 16X16 Board - Solved
        /// </summary>
        [TestMethod]
        public void Board16X16_Solved_Test4()
        {
            // Set the board and the expected solution
            string board = "813;<2@9=>:?6457576413;8@9<2:?=>=>:?7645;813<2@9@9<2>:?=457613;8;8139<2@?=>:76454576813;2@9<>:?=?=>:57643;819<2@2@9<=>:?6457813;:?=>457613;8@9<2<2@9?=>:7645;8133;81@9<2:?=>57646457;813<2@9=>:?13;82@9<>:?=457676453;819<2@?=>:>:?=6457813;2@9<9<2@:?=>57643;81";
            string expectedSolution = "813;<2@9=>:?6457576413;8@9<2:?=>=>:?7645;813<2@9@9<2>:?=457613;8;8139<2@?=>:76454576813;2@9<>:?=?=>:57643;819<2@2@9<=>:?6457813;:?=>457613;8@9<2<2@9?=>:7645;8133;81@9<2:?=>57646457;813<2@9=>:?13;82@9<>:?=457676453;819<2@?=>:>:?=6457813;2@9<9<2@:?=>57643;81";

            // Solve the Board
            string actualSolution = SolveSudoku.Solve(board, "");

            // Check if the expected solution equals to the actual solution
            Assert.AreEqual(expectedSolution, actualSolution);
        }

        /// <summary>
        /// Test number 5: 16X16 Board - Unsolveable
        /// </summary>
        [TestMethod]
        public void Board16X16_Unsolveable_Test5()
        {
            // Set the board
            string board = ">8091400<@3000000=1400<05002090:00070008006000?0000260000000000@@000050006400?=10;050>:6=000000000007001000<9080007020@0800000003000000004?00000;000?064000=0002600:<=000050>0;907000@00;9>00:040006010<25800;000<0080009>:;=04?2000:;904?000070000006007<008000";

            // Solve the Board and check if UnSolveableBoardError thrown
            Assert.ThrowsException<UnSolveableBoardError>(() => SolveSudoku.Solve(board, ""));
        }

        /// <summary>
        /// Test number 6: 16X16 Board - 2 or more same values in the same row
        /// </summary>
        [TestMethod]
        public void Board16X16_TwoSameValuesInTheSameRow_Test6()
        {
            // Set the board
            string board = "@000?@030=204000009;650<03?0200002:0049;70650@>3?@>0008=00405700000906000030=2088000010057000?000000=2000004050006070?@00800000;>3?0000009000000006500002000;1490000700500>00=00:0000;10000<00000:0000;00050@>00003?:000109;00605000003000:0900049005000000>0802";

            // Solve the Board and check if TwoValuesInTheSameRowError thrown
            Assert.ThrowsException<TwoValuesInTheSameRowError>(() => SolveSudoku.Solve(board, ""));
        }

        /// <summary>
        /// Test number 7: 16X16 Board - 2 or more same values in the same col
        /// </summary>
        [TestMethod]
        public void Board16X16_TwoSameValuesInTheSameCol_Test7()
        {
            // Set the board
            string board = "0?00000000000120789;0000000000:00000000<>000000=0000000000000?00000000000000008<>;:00000?000000@=0000000000000000000000000000000?00000000000;00000:000000000000000000000>00000000000000=@0000000000000004000000000000000:000000000000000700005000000000000000000";

            // Solve the Board and check if TwoValuesInTheSameColError thrown
            Assert.ThrowsException<TwoValuesInTheSameColError>(() => SolveSudoku.Solve(board, ""));
        }

        /// <summary>
        /// Test number 8: 16X16 Board - 2 or more same values in the same sub square
        /// </summary>
        [TestMethod]
        public void Board16X16_TwoSameValuesInTheSameSubSquare_Test8()
        {
            // Set the board
            string board = ">0091400<@3000000=1400<05002090:00070008006000?0000260000000000@@000050006400?=10;050>:6=000000000007001000<9080007020@0800000003000000004?00000;000?064000=0002600:<=000050>0;907000@00;9>00:040006010<25800;000<0080009>:;=04?2000:;904?000070000006007<008400";

            // Solve the Board and check if TwoValuesInTheSameSubSquareError thrown
            Assert.ThrowsException<TwoValuesInTheSameSubSquareError>(() => SolveSudoku.Solve(board, ""));
        }
    }
}

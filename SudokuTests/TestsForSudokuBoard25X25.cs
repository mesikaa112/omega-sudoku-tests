﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using OmegaSudoku;
using OmegaSudoku.Exceptions;

namespace SudokuTests
{
    /// <summary>
    /// This class represented the test for sudoku board 25X25
    /// </summary>
    [TestClass]
    public class TestsForSudokuBoard25X25
    {
        /// <summary>
        /// Test number 1: 25X25 Board - Solveable (empty board)
        /// </summary>
        [TestMethod]
        public void Board25X25_Solveable_Test1()
        {
            // Set the board and the expected solution
            string board = "0000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000";
            string expectedSolution = "123456789:;<=>?@ABCDEFGHIDBGH<15;FI48:EC3?>962@=7AF;8EI2?@CG15DAB4=H7<39:6>9:=>@3DA<H276GF15I8E4?B;C?A67C4>E=B39IH@2:F;G158<DE1234IH5896D<:>;G@A?7BC=FCDIF>@16G?=357H829<B;4AE:=@9BH:27;>F1A8G645ECD3I?<;<AG?D3=EFC4B9I71:H>6258@5678:<4BAC?2@;ED3=IFG1>9H4I123?B958DE><:GCA6;@H7F=GH@<9FI16=BC357ED2?8:>4A;:E?CA>@27;HF1=8BI459<G3D6>8F=;CG3D<IA469H71@:?E25B75D6BHE4:A@G2?;<>3F=I81C934E1289?H5:=;F<A6CB@>IDG7AFCIDG=>167@E35:982HB;<4?H>:@GBFD278I?1A=;<45C693E<=B?8;CI3E9HG46>FD17A:@25695;7A:<4@>BC2D?EG3IF=H182349156F?D<:8C=I@;>AH7EBGIC>AE78GB15;9D3FH6:2=<?@4BGHDF9;CI2E>7@15<?=48A6:3@?<:=EAH>3G6FB4987D15C;I287;56=<:@4A?HI2CBEG39DF>1";

            // Solve the Board
            string actualSolution = SolveSudoku.Solve(board, "");

            // Check if the expected solution equals to the actual solution
            Assert.AreEqual(expectedSolution, actualSolution);
        }

        /// <summary>
        /// Test number 2: 25X25 Board - Solveable
        /// </summary>
        [TestMethod]
        public void Board25X25_Solveable_Test2()
        {
            // Set the board and the expected solution
            string board = "005DEI0000;9800:070F00000000I0B098G0@F:H0>3?0E0600080B;000F03?0<>5DE20A100I00:0003?=00200000000090G0?=<00D0265A10C00B0900000HF0000000<0005IEBA04C9000;=003?0265I00C0A0098000:00000E2A04C098GH;00@F00=<0000BA0;080H@F0>7030=0200IE000;07@F:0?0<D3I006010CB00DE?0260I00C001090G0F:>0000A2004C000GH003@0:0=0D0?0000098GH0F0>3@E?=0065002G07980F:>3=<D0?A265000000:>00F?0000000A2;040B8G070>0?00=00E050016040B;G00@0D020<65I01CB094@00H7:>0?0IA1654C000G00@8?00000000=0094C8007@:00002=<DE0IA00H700G00>0?<DE0=100IAC0;900@FGH:00?=DE20000IA00;08C0?0:>000000A1408C0;0H7@00E00<D0IA14B;9000G07@030=00145I0B;9800@0G0000?0E00<0080BGH7@F000=:60DE000100";
            string expectedSolution = "265DEIA14C;98GB:H7@F3?=<>14CIAB;98G7@F:H<>3?=E265D98GB;H7@F:3?=<>5DE26A14CI@F:H7>3?=<E265DCIA14;98GB?=<>3DE265A14CIGB;987@F:HF:>7@3?=<D265IEBA14C98GH;=<D3?E265I14CBAH;98G@F:>765IE2A14CB98GH;>7@F:?=<D34CBA1;98GH@F:>7D3?=<265IE8GH;97@F:>?=<D3IE26514CBA<DE?=265IA4CB;1798GHF:>3@5IA2614CB;8GH793@F:>=<DE?CB;1498GH7F:>3@E?=<D65IA2GH798@F:>3=<DE?A265I4CB;1:>3@F?=<DE65IA2;14CB8GH79>3?F:=<DE25IA1694CB;GH7@8DE2=<65IA1CB;94@8GH7:>3?FIA1654CB;9GH7@8?F:>3<DE2=B;94C8GH7@:>3?F2=<DE5IA16H7@8GF:>3?<DE2=165IACB;947@FGH:>3?=DE26<45IA1B;98C3?=:><DE26IA1458CB;9H7@FGE26<D5IA14B;98CFGH7@>3?=:A145ICB;98H7@FG=:>3?DE26<;98CBGH7@F>3?=:6<DE2IA145";

            // Solve the Board
            string actualSolution = SolveSudoku.Solve(board, "");

            // Check if the expected solution equals to the actual solution
            Assert.AreEqual(expectedSolution, actualSolution);
        }

        /// <summary>
        /// Test number 3: 25X25 Board - Solveable
        /// </summary>
        [TestMethod]
        public void Board25X25_Solveable_Test3()
        {
            // Set the board and the expected solution
            string board = "7<00AH0D0000E:F80;00I?1>0090BDG000@06;300?000<05070000:6;008I00>0<05A09HB0240603?0>00<=5000HB02@0E0FCI?0>05A009HBD20G00F80000800:F030I0?1>0<=5A790000006;041>C<000079H002@0E0080?100507900BD0@G0:006;04I000A7B0200GE0086;30I?10C<@H0D000F8G60340?10C<=5A79=0>0<00000000@000F80;34I0H5009D0@G000F86;300?000<=G0000:F86E000I?00C<00009H0000034I?00>C<=50700B02@00;300000=000700BD2@GE:F0603400C0=0>07000000G00086;0>C<=09H0AD200E0000;000?1B00000@GE0:086030I01>0000E02@GF06;0340?100<=5A0900;:00040?130C0=5000HB02@0000@G0860004I?10C000A790B03F8600?0>40<05079H0D20GE:04I00<00A0090B000GE0F0003A0005000D02@000F80030I010079HB0GE00080;30001000000";
            string expectedSolution = "7<=5AHBD29@GE:F86;34I?1>C29HBDGE:F@86;34I?1>C<=5A7F@GE:6;348I?1>C<=5A79HBD2486;3?1>CI<=5A79HBD2@GE:FCI?1>=5A7<9HBD2@GE:F86;348GE:F;34I6?1>C<=5A79HBD2@I6;341>C<?=5A79HBD2@GE:F8<?1>C5A79=HBD2@GE:F86;34I9=5A7BD2@HGE:F86;34I?1>C<@HBD2E:F8G6;34I?1>C<=5A79=1>C<A79H5BD2@GE:F86;34I?H5A79D2@GBE:F86;34I?1>C<=GBD2@:F86E;34I?1>C<=5A79H6E:F834I?;1>C<=5A79HBD2@G?;34I>C<=15A79HBD2@GE:F86134I?C<=5>A79HBD2@GE:F86;5>C<=79HBAD2@GE:F86;34I?1BA79H2@GED:F86;34I?1>C<=5ED2@GF86;:34I?1>C<=5A79HB;:F864I?13>C<=5A79HBD2@GE:2@GE86;3F4I?1>C<=5A79HBD3F86;I?1>4C<=5A79HBD2@GE:>4I?1<=5AC79HBD2@GE:F86;3AC<=59HBD72@GE:F86;34I?1>D79HB@GE:2F86;34I?1>C<=5A";

            // Solve the Board
            string actualSolution = SolveSudoku.Solve(board, "");

            // Check if the expected solution equals to the actual solution
            Assert.AreEqual(expectedSolution, actualSolution);
        }

        /// <summary>
        /// Test number 4: 25X25 Board - Solved
        /// </summary>
        [TestMethod]
        public void Board25X25_Solved_Test4()
        {
            // Set the board and the expected solution
            string board = "?9C6:831<42IGEH>@75D=FA;B4831<EH2IGD>@75FA;B=6:?9CGEH2I75D>@=FA;B:?9C61<483@75D>;B=FA6:?9C<48312IGEHA;B=F9C6:?1<483IGEH2D>@757H2IG5D>@;FA9B=?8C6:<4E31;5D>@B=FA9:?8C64E31<IG7H29B=FAC6:?8<4E31G7H2I>@;5D8C6:?31<4EIG7H2@;5D>FA9B=E31<4H2IG7>@;5DA9B=F:?8C6BD>@;=FA9C?836:EH1<4G752IC=FA96:?834EH1<752IG@;BD>36:?81<4EHG752I;BD>@A9C=FH1<4E2IG75@;BD>9C=FA?836:52IG7D>@;BA9C=F836:?4EH1<1:?83<4EH275DIGB=>@;9C6FA2<4EHIG75D;B=>@C6FA9831:?DIG75>@;B=9C6FA31:?8EH2<4=>@;BFA9C6831:?H2<4E75DIG6FA9C:?831EH2<45DIG7;B=>@F@;B=A9C6:31<?82I4EH5D>G7:A9C6?831<H2I4ED>G75B=F@;<?8314EH2I5D>G7=F@;BC6:A9I4EH2G75D>B=F@;6:A9C31<?8>G75D@;B=FC6:A91<?83H2I4E";
            string expectedSolution = "?9C6:831<42IGEH>@75D=FA;B4831<EH2IGD>@75FA;B=6:?9CGEH2I75D>@=FA;B:?9C61<483@75D>;B=FA6:?9C<48312IGEHA;B=F9C6:?1<483IGEH2D>@757H2IG5D>@;FA9B=?8C6:<4E31;5D>@B=FA9:?8C64E31<IG7H29B=FAC6:?8<4E31G7H2I>@;5D8C6:?31<4EIG7H2@;5D>FA9B=E31<4H2IG7>@;5DA9B=F:?8C6BD>@;=FA9C?836:EH1<4G752IC=FA96:?834EH1<752IG@;BD>36:?81<4EHG752I;BD>@A9C=FH1<4E2IG75@;BD>9C=FA?836:52IG7D>@;BA9C=F836:?4EH1<1:?83<4EH275DIGB=>@;9C6FA2<4EHIG75D;B=>@C6FA9831:?DIG75>@;B=9C6FA31:?8EH2<4=>@;BFA9C6831:?H2<4E75DIG6FA9C:?831EH2<45DIG7;B=>@F@;B=A9C6:31<?82I4EH5D>G7:A9C6?831<H2I4ED>G75B=F@;<?8314EH2I5D>G7=F@;BC6:A9I4EH2G75D>B=F@;6:A9C31<?8>G75D@;B=FC6:A91<?83H2I4E";

            // Solve the Board
            string actualSolution = SolveSudoku.Solve(board, "");

            // Check if the expected solution equals to the actual solution
            Assert.AreEqual(expectedSolution, actualSolution);
        }

        /// <summary>
        /// Test number 5: 25X25 Board - Unsolveable
        /// </summary>
        [TestMethod]
        public void Board25X25_Unsolveable_Test5()
        {
            // Set the board
            string board = "D0402?AI00CG0070:;010@0H3?0I00G00700E1000>050000000000C00=:0H08@>40203A000?E1=:;580>02030F090?A<B0CG08@0HD340060009B0000100000@>H5A40200<I0000G10=:;E0A002D<096?01B0C:;0000>H50<09601B0CGE0=0;>05300000A1B7000000E00@00F2D04I00?000:000@>000A0F000?0I0700000000000?<1=7CG0E80000500006?<=00010@0;0H534>0200I070G00:;E834>050DAIF060<B0:0E80>H030I0206?0B07000=4>0500F00A0090?CG1=00008@>0E0@00500I900000000C01=0FH530000A0B06?<010:00E80000DAI000<B=00G1E0000H004F000<B0CG0=0>;E85300H2DA00:C010>;00@4F003DA0900?<B0H08@>2034096000<000?G00:;0530F6D0000C?0B0=:00E000H6DAI00?<B70;00080>0E534F000007000=0>008000000D0I96000000E00002000A090D?<B00";

            // Solve the Board and check if UnSolveableBoardError thrown
            Assert.ThrowsException<UnSolveableBoardError>(() => SolveSudoku.Solve(board, ""));
        }

        /// <summary>
        /// Test number 6: 25X25 Board - 2 or more same values in the same row
        /// </summary>
        [TestMethod]
        public void Board25X25_TwoSameValuesInTheSameRow_Test6()
        {
            // Set the board
            string board = "F100?0E2<=006>G0I@007B010E00=000056I0D0900000000130H00>A900D:;7B8F000?00E000I0DAB800703000E20=00>GH50:;0B?00342<=0000500D090@I00>0000DA;0080034000EH<=000A90100B04?020<=CE00I00000B802300<0C00I00>G00:0D234?00H00C560G000D0900100H00CEGI560@0A901;008?020430081000?0000H50000090000<0?F2H000E00GI0;DA0:0037B5000HI000GD000037B01F2000000GI0;DA97B010<40F2005=C;0A9:030B80?02<5=CEHG0@600>0I@;7A00B0104=000<0500E7000034B810F20=00E00000000B80000?F2CE050D>00@:07A000F0<50C0H>G00D0090;104B06C0H5@D00I09000000002<=?0CF00=60EH5G00DAB9:0700000>0056D00I00:;7008134<=C020GI@07000;8130?C00<=0600HB00;700800F200C>0H060D000?0034=000<0H50>0G00D00B0:";

            // Solve the Board and check if TwoValuesInTheSameRowError thrown
            Assert.ThrowsException<TwoValuesInTheSameRowError>(() => SolveSudoku.Solve(board, ""));
        }

        /// <summary>
        /// Test number 7: 25X25 Board - 2 or more same values in the same col
        /// </summary>
        [TestMethod]
        public void Board25X25_TwoSameValuesInTheSameCol_Test7()
        {
            // Set the board
            string board = "02010D=<8B4>0090000HEG00;00;EG0010000BD=089000CH707000H;E0000I0:10=05040009@004>A60070?F;E2:00000B0=0D0<0890>@C0700F000?0002:300:1BD000940@807A00;0G?FG?F;0I00130<500>@800A0007H0060F;00013000BD=<594>08>@800006C0000F;I2:03=05B0500=<0004>600000F;EG:000003I2050D=<800>@00006F000?00?F0002:00=00B0>@80706C0C07A0?F0EG010025BD008940000@09H7000;E0?030001D=<00<0000>@804A0CH0G000E2:00004>@00H006F000?0000:B0000=05BD00@897A0C00G?F;0001301302<5B00@89406C070?F;00;EG0F03I0:0D=0090>@00006C0C000G?F;00:13I<5B0=00000F0E0?01002500=080400C07A006CH7000F002000=0500>@800004>@0000A0F;EG010000000<D0<5094>@0H7A0C;EG?03020100000=00BD00090A0CH0G?F0E";

            // Solve the Board and check if TwoValuesInTheSameColError thrown
            Assert.ThrowsException<TwoValuesInTheSameColError>(() => SolveSudoku.Solve(board, ""));
        }

        /// <summary>
        /// Test number 8: 25X25 Board - 2 or more same values in the same sub square
        /// </summary>
        [TestMethod]
        public void Board25X25_TwoSameValuesInTheSameSubSquare_Test8()
        {
            // Set the board
            string board = "E9;F80305B0100=0:?>06@7C00@70G0AF8E03<500H10I000000;00?0@00GE00F85BD00400H1040=H0000?06@0C080003<000D000014I=H?>;0:7C0600000E00@7CE0A0000305I=H14>00:0?002:G6@708E0A000B0304I00H140=?000:C06@0A08E003<0B003050100000>02@7C06090F80E0AF0D3<0001400200>06@70=0140:?>;20CG6@9A08EBD0<05B00<0H00I00?>06@7000E0A0F009A0B03<I=H100;20?C0607C06@00090F000004I=01?0;000?0020000008000000BD0100000?>;70G60AF8E903<5B=0140I0000200>0@7C0609AF85B00000B000=H0400:?006@7000E90008E000B0040=H0?00200CG0@00G00F009A<50D3140000000207C06000E93<0B0H04002:?>0;20?000C069AF0EB0000000104I0010000>600CG000AF000033050D40=010;000CG6@0A08009008E3<5B0000000?000@70G6";

            // Solve the Board and check if TwoValuesInTheSameSubSquareError thrown
            Assert.ThrowsException<TwoValuesInTheSameSubSquareError>(() => SolveSudoku.Solve(board, ""));
        }
    }
}
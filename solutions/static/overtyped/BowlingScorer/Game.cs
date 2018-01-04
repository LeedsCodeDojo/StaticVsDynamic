using System.Collections.Generic;

namespace BowlingScorer
{
	public class Game
	{
		public static Frame1Score0 Score0() => new Frame1Score0(new List<int> {0});
		public static Frame1Score1 Score1() => new Frame1Score1(new List<int> {1});
		public static Frame1Score2 Score2() => new Frame1Score2(new List<int> {2});
		public static Frame1Score3 Score3() => new Frame1Score3(new List<int> {3});
		public static Frame1Score4 Score4() => new Frame1Score4(new List<int> {4});
		public static Frame1Score5 Score5() => new Frame1Score5(new List<int> {5});
		public static Frame1Score6 Score6() => new Frame1Score6(new List<int> {6});
		public static Frame1Score7 Score7() => new Frame1Score7(new List<int> {7});
		public static Frame1Score8 Score8() => new Frame1Score8(new List<int> {8});
		public static Frame1Score9 Score9() => new Frame1Score9(new List<int> {9});
		public static Frame2 Strike() => new Frame2(new List<int> {10});
	}
}
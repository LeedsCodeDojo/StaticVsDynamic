using System.Collections.Generic;

namespace BowlingScorer
{
    public class Frame6
    {
        private readonly ICollection<int> _rolls;
        internal Frame6(ICollection<int> rolls) => _rolls = rolls;
        public Frame6Score0 Score0() => new Frame6Score0(_rolls.With(0));
        public Frame6Score1 Score1() => new Frame6Score1(_rolls.With(1));
        public Frame6Score2 Score2() => new Frame6Score2(_rolls.With(2));
        public Frame6Score3 Score3() => new Frame6Score3(_rolls.With(3));
        public Frame6Score4 Score4() => new Frame6Score4(_rolls.With(4));
        public Frame6Score5 Score5() => new Frame6Score5(_rolls.With(5));
        public Frame6Score6 Score6() => new Frame6Score6(_rolls.With(6));
        public Frame6Score7 Score7() => new Frame6Score7(_rolls.With(7));
        public Frame6Score8 Score8() => new Frame6Score8(_rolls.With(8));
        public Frame6Score9 Score9() => new Frame6Score9(_rolls.With(9));
        public Frame7 Strike() => new Frame7(_rolls.With(10));
    }

    public class Frame6Score0
    {
        private readonly ICollection<int> _rolls;
        internal Frame6Score0(ICollection<int> rolls) => _rolls = rolls;
        public Frame7 Then0() => new Frame7(_rolls.With(0));
        public Frame7 Then1() => new Frame7(_rolls.With(1));
        public Frame7 Then2() => new Frame7(_rolls.With(2));
        public Frame7 Then3() => new Frame7(_rolls.With(3));
        public Frame7 Then4() => new Frame7(_rolls.With(4));
        public Frame7 Then5() => new Frame7(_rolls.With(5));
        public Frame7 Then6() => new Frame7(_rolls.With(6));
        public Frame7 Then7() => new Frame7(_rolls.With(7));
        public Frame7 Then8() => new Frame7(_rolls.With(8));
        public Frame7 Then9() => new Frame7(_rolls.With(9));
        public Frame7 Spare() => new Frame7(_rolls.With(10));
    }
    public class Frame6Score1
    {
        private readonly ICollection<int> _rolls;
        internal Frame6Score1(ICollection<int> rolls) => _rolls = rolls;
        public Frame7 Then0() => new Frame7(_rolls.With(0));
        public Frame7 Then1() => new Frame7(_rolls.With(1));
        public Frame7 Then2() => new Frame7(_rolls.With(2));
        public Frame7 Then3() => new Frame7(_rolls.With(3));
        public Frame7 Then4() => new Frame7(_rolls.With(4));
        public Frame7 Then5() => new Frame7(_rolls.With(5));
        public Frame7 Then6() => new Frame7(_rolls.With(6));
        public Frame7 Then7() => new Frame7(_rolls.With(7));
        public Frame7 Then8() => new Frame7(_rolls.With(8));
        public Frame7 Spare() => new Frame7(_rolls.With(9));
    }
    public class Frame6Score2
    {
        private readonly ICollection<int> _rolls;
        internal Frame6Score2(ICollection<int> rolls) => _rolls = rolls;
        public Frame7 Then0() => new Frame7(_rolls.With(0));
        public Frame7 Then1() => new Frame7(_rolls.With(1));
        public Frame7 Then2() => new Frame7(_rolls.With(2));
        public Frame7 Then3() => new Frame7(_rolls.With(3));
        public Frame7 Then4() => new Frame7(_rolls.With(4));
        public Frame7 Then5() => new Frame7(_rolls.With(5));
        public Frame7 Then6() => new Frame7(_rolls.With(6));
        public Frame7 Then7() => new Frame7(_rolls.With(7));
        public Frame7 Spare() => new Frame7(_rolls.With(8));
    }
    public class Frame6Score3
    {
        private readonly ICollection<int> _rolls;
        internal Frame6Score3(ICollection<int> rolls) => _rolls = rolls;
        public Frame7 Then0() => new Frame7(_rolls.With(0));
        public Frame7 Then1() => new Frame7(_rolls.With(1));
        public Frame7 Then2() => new Frame7(_rolls.With(2));
        public Frame7 Then3() => new Frame7(_rolls.With(3));
        public Frame7 Then4() => new Frame7(_rolls.With(4));
        public Frame7 Then5() => new Frame7(_rolls.With(5));
        public Frame7 Then6() => new Frame7(_rolls.With(6));
        public Frame7 Spare() => new Frame7(_rolls.With(7));
    }
    public class Frame6Score4
    {
        private readonly ICollection<int> _rolls;
        internal Frame6Score4(ICollection<int> rolls) => _rolls = rolls;
        public Frame7 Then0() => new Frame7(_rolls.With(0));
        public Frame7 Then1() => new Frame7(_rolls.With(1));
        public Frame7 Then2() => new Frame7(_rolls.With(2));
        public Frame7 Then3() => new Frame7(_rolls.With(3));
        public Frame7 Then4() => new Frame7(_rolls.With(4));
        public Frame7 Then5() => new Frame7(_rolls.With(5));
        public Frame7 Spare() => new Frame7(_rolls.With(6));
    }
    public class Frame6Score5
    {
        private readonly ICollection<int> _rolls;
        internal Frame6Score5(ICollection<int> rolls) => _rolls = rolls;
        public Frame7 Then0() => new Frame7(_rolls.With(0));
        public Frame7 Then1() => new Frame7(_rolls.With(1));
        public Frame7 Then2() => new Frame7(_rolls.With(2));
        public Frame7 Then3() => new Frame7(_rolls.With(3));
        public Frame7 Then4() => new Frame7(_rolls.With(4));
        public Frame7 Spare() => new Frame7(_rolls.With(5));
    }
    public class Frame6Score6
    {
        private readonly ICollection<int> _rolls;
        internal Frame6Score6(ICollection<int> rolls) => _rolls = rolls;
        public Frame7 Then0() => new Frame7(_rolls.With(0));
        public Frame7 Then1() => new Frame7(_rolls.With(1));
        public Frame7 Then2() => new Frame7(_rolls.With(2));
        public Frame7 Then3() => new Frame7(_rolls.With(3));
        public Frame7 Spare() => new Frame7(_rolls.With(4));
    }
    public class Frame6Score7
    {
        private readonly ICollection<int> _rolls;
        internal Frame6Score7(ICollection<int> rolls) => _rolls = rolls;
        public Frame7 Then0() => new Frame7(_rolls.With(0));
        public Frame7 Then1() => new Frame7(_rolls.With(1));
        public Frame7 Then2() => new Frame7(_rolls.With(2));
        public Frame7 Spare() => new Frame7(_rolls.With(3));
    }
    public class Frame6Score8
    {
        private readonly ICollection<int> _rolls;
        internal Frame6Score8(ICollection<int> rolls) => _rolls = rolls;
        public Frame7 Then0() => new Frame7(_rolls.With(0));
        public Frame7 Then1() => new Frame7(_rolls.With(1));
        public Frame7 Spare() => new Frame7(_rolls.With(2));
    }
    public class Frame6Score9
    {
        private readonly ICollection<int> _rolls;
        internal Frame6Score9(ICollection<int> rolls) => _rolls = rolls;
        public Frame7 Then0() => new Frame7(_rolls.With(0));
        public Frame7 Spare() => new Frame7(_rolls.With(1));
    }
}

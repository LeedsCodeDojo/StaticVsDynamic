using System.Collections.Generic;

namespace BowlingScorer
{
    public class Frame4
    {
        private readonly ICollection<int> _rolls;
        internal Frame4(ICollection<int> rolls) => _rolls = rolls;
        public Frame4Score0 Score0() => new Frame4Score0(_rolls.With(0));
        public Frame4Score1 Score1() => new Frame4Score1(_rolls.With(1));
        public Frame4Score2 Score2() => new Frame4Score2(_rolls.With(2));
        public Frame4Score3 Score3() => new Frame4Score3(_rolls.With(3));
        public Frame4Score4 Score4() => new Frame4Score4(_rolls.With(4));
        public Frame4Score5 Score5() => new Frame4Score5(_rolls.With(5));
        public Frame4Score6 Score6() => new Frame4Score6(_rolls.With(6));
        public Frame4Score7 Score7() => new Frame4Score7(_rolls.With(7));
        public Frame4Score8 Score8() => new Frame4Score8(_rolls.With(8));
        public Frame4Score9 Score9() => new Frame4Score9(_rolls.With(9));
        public Frame5 Strike() => new Frame5(_rolls.With(10));
    }

    public class Frame4Score0
    {
        private readonly ICollection<int> _rolls;
        internal Frame4Score0(ICollection<int> rolls) => _rolls = rolls;
        public Frame5 Then0() => new Frame5(_rolls.With(0));
        public Frame5 Then1() => new Frame5(_rolls.With(1));
        public Frame5 Then2() => new Frame5(_rolls.With(2));
        public Frame5 Then3() => new Frame5(_rolls.With(3));
        public Frame5 Then4() => new Frame5(_rolls.With(4));
        public Frame5 Then5() => new Frame5(_rolls.With(5));
        public Frame5 Then6() => new Frame5(_rolls.With(6));
        public Frame5 Then7() => new Frame5(_rolls.With(7));
        public Frame5 Then8() => new Frame5(_rolls.With(8));
        public Frame5 Then9() => new Frame5(_rolls.With(9));
        public Frame5 Spare() => new Frame5(_rolls.With(10));
    }
    public class Frame4Score1
    {
        private readonly ICollection<int> _rolls;
        internal Frame4Score1(ICollection<int> rolls) => _rolls = rolls;
        public Frame5 Then0() => new Frame5(_rolls.With(0));
        public Frame5 Then1() => new Frame5(_rolls.With(1));
        public Frame5 Then2() => new Frame5(_rolls.With(2));
        public Frame5 Then3() => new Frame5(_rolls.With(3));
        public Frame5 Then4() => new Frame5(_rolls.With(4));
        public Frame5 Then5() => new Frame5(_rolls.With(5));
        public Frame5 Then6() => new Frame5(_rolls.With(6));
        public Frame5 Then7() => new Frame5(_rolls.With(7));
        public Frame5 Then8() => new Frame5(_rolls.With(8));
        public Frame5 Spare() => new Frame5(_rolls.With(9));
    }
    public class Frame4Score2
    {
        private readonly ICollection<int> _rolls;
        internal Frame4Score2(ICollection<int> rolls) => _rolls = rolls;
        public Frame5 Then0() => new Frame5(_rolls.With(0));
        public Frame5 Then1() => new Frame5(_rolls.With(1));
        public Frame5 Then2() => new Frame5(_rolls.With(2));
        public Frame5 Then3() => new Frame5(_rolls.With(3));
        public Frame5 Then4() => new Frame5(_rolls.With(4));
        public Frame5 Then5() => new Frame5(_rolls.With(5));
        public Frame5 Then6() => new Frame5(_rolls.With(6));
        public Frame5 Then7() => new Frame5(_rolls.With(7));
        public Frame5 Spare() => new Frame5(_rolls.With(8));
    }
    public class Frame4Score3
    {
        private readonly ICollection<int> _rolls;
        internal Frame4Score3(ICollection<int> rolls) => _rolls = rolls;
        public Frame5 Then0() => new Frame5(_rolls.With(0));
        public Frame5 Then1() => new Frame5(_rolls.With(1));
        public Frame5 Then2() => new Frame5(_rolls.With(2));
        public Frame5 Then3() => new Frame5(_rolls.With(3));
        public Frame5 Then4() => new Frame5(_rolls.With(4));
        public Frame5 Then5() => new Frame5(_rolls.With(5));
        public Frame5 Then6() => new Frame5(_rolls.With(6));
        public Frame5 Spare() => new Frame5(_rolls.With(7));
    }
    public class Frame4Score4
    {
        private readonly ICollection<int> _rolls;
        internal Frame4Score4(ICollection<int> rolls) => _rolls = rolls;
        public Frame5 Then0() => new Frame5(_rolls.With(0));
        public Frame5 Then1() => new Frame5(_rolls.With(1));
        public Frame5 Then2() => new Frame5(_rolls.With(2));
        public Frame5 Then3() => new Frame5(_rolls.With(3));
        public Frame5 Then4() => new Frame5(_rolls.With(4));
        public Frame5 Then5() => new Frame5(_rolls.With(5));
        public Frame5 Spare() => new Frame5(_rolls.With(6));
    }
    public class Frame4Score5
    {
        private readonly ICollection<int> _rolls;
        internal Frame4Score5(ICollection<int> rolls) => _rolls = rolls;
        public Frame5 Then0() => new Frame5(_rolls.With(0));
        public Frame5 Then1() => new Frame5(_rolls.With(1));
        public Frame5 Then2() => new Frame5(_rolls.With(2));
        public Frame5 Then3() => new Frame5(_rolls.With(3));
        public Frame5 Then4() => new Frame5(_rolls.With(4));
        public Frame5 Spare() => new Frame5(_rolls.With(5));
    }
    public class Frame4Score6
    {
        private readonly ICollection<int> _rolls;
        internal Frame4Score6(ICollection<int> rolls) => _rolls = rolls;
        public Frame5 Then0() => new Frame5(_rolls.With(0));
        public Frame5 Then1() => new Frame5(_rolls.With(1));
        public Frame5 Then2() => new Frame5(_rolls.With(2));
        public Frame5 Then3() => new Frame5(_rolls.With(3));
        public Frame5 Spare() => new Frame5(_rolls.With(4));
    }
    public class Frame4Score7
    {
        private readonly ICollection<int> _rolls;
        internal Frame4Score7(ICollection<int> rolls) => _rolls = rolls;
        public Frame5 Then0() => new Frame5(_rolls.With(0));
        public Frame5 Then1() => new Frame5(_rolls.With(1));
        public Frame5 Then2() => new Frame5(_rolls.With(2));
        public Frame5 Spare() => new Frame5(_rolls.With(3));
    }
    public class Frame4Score8
    {
        private readonly ICollection<int> _rolls;
        internal Frame4Score8(ICollection<int> rolls) => _rolls = rolls;
        public Frame5 Then0() => new Frame5(_rolls.With(0));
        public Frame5 Then1() => new Frame5(_rolls.With(1));
        public Frame5 Spare() => new Frame5(_rolls.With(2));
    }
    public class Frame4Score9
    {
        private readonly ICollection<int> _rolls;
        internal Frame4Score9(ICollection<int> rolls) => _rolls = rolls;
        public Frame5 Then0() => new Frame5(_rolls.With(0));
        public Frame5 Spare() => new Frame5(_rolls.With(1));
    }
}

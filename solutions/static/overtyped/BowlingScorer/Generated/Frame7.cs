using System.Collections.Generic;

namespace BowlingScorer
{
    public class Frame7
    {
        private readonly ICollection<int> _rolls;
        internal Frame7(ICollection<int> rolls) => _rolls = rolls;
        public Frame7Score0 Score0() => new Frame7Score0(_rolls.With(0));
        public Frame7Score1 Score1() => new Frame7Score1(_rolls.With(1));
        public Frame7Score2 Score2() => new Frame7Score2(_rolls.With(2));
        public Frame7Score3 Score3() => new Frame7Score3(_rolls.With(3));
        public Frame7Score4 Score4() => new Frame7Score4(_rolls.With(4));
        public Frame7Score5 Score5() => new Frame7Score5(_rolls.With(5));
        public Frame7Score6 Score6() => new Frame7Score6(_rolls.With(6));
        public Frame7Score7 Score7() => new Frame7Score7(_rolls.With(7));
        public Frame7Score8 Score8() => new Frame7Score8(_rolls.With(8));
        public Frame7Score9 Score9() => new Frame7Score9(_rolls.With(9));
        public Frame8 Strike() => new Frame8(_rolls.With(10));
    }

    public class Frame7Score0
    {
        private readonly ICollection<int> _rolls;
        internal Frame7Score0(ICollection<int> rolls) => _rolls = rolls;
        public Frame8 Then0() => new Frame8(_rolls.With(0));
        public Frame8 Then1() => new Frame8(_rolls.With(1));
        public Frame8 Then2() => new Frame8(_rolls.With(2));
        public Frame8 Then3() => new Frame8(_rolls.With(3));
        public Frame8 Then4() => new Frame8(_rolls.With(4));
        public Frame8 Then5() => new Frame8(_rolls.With(5));
        public Frame8 Then6() => new Frame8(_rolls.With(6));
        public Frame8 Then7() => new Frame8(_rolls.With(7));
        public Frame8 Then8() => new Frame8(_rolls.With(8));
        public Frame8 Then9() => new Frame8(_rolls.With(9));
        public Frame8 Spare() => new Frame8(_rolls.With(10));
    }
    public class Frame7Score1
    {
        private readonly ICollection<int> _rolls;
        internal Frame7Score1(ICollection<int> rolls) => _rolls = rolls;
        public Frame8 Then0() => new Frame8(_rolls.With(0));
        public Frame8 Then1() => new Frame8(_rolls.With(1));
        public Frame8 Then2() => new Frame8(_rolls.With(2));
        public Frame8 Then3() => new Frame8(_rolls.With(3));
        public Frame8 Then4() => new Frame8(_rolls.With(4));
        public Frame8 Then5() => new Frame8(_rolls.With(5));
        public Frame8 Then6() => new Frame8(_rolls.With(6));
        public Frame8 Then7() => new Frame8(_rolls.With(7));
        public Frame8 Then8() => new Frame8(_rolls.With(8));
        public Frame8 Spare() => new Frame8(_rolls.With(9));
    }
    public class Frame7Score2
    {
        private readonly ICollection<int> _rolls;
        internal Frame7Score2(ICollection<int> rolls) => _rolls = rolls;
        public Frame8 Then0() => new Frame8(_rolls.With(0));
        public Frame8 Then1() => new Frame8(_rolls.With(1));
        public Frame8 Then2() => new Frame8(_rolls.With(2));
        public Frame8 Then3() => new Frame8(_rolls.With(3));
        public Frame8 Then4() => new Frame8(_rolls.With(4));
        public Frame8 Then5() => new Frame8(_rolls.With(5));
        public Frame8 Then6() => new Frame8(_rolls.With(6));
        public Frame8 Then7() => new Frame8(_rolls.With(7));
        public Frame8 Spare() => new Frame8(_rolls.With(8));
    }
    public class Frame7Score3
    {
        private readonly ICollection<int> _rolls;
        internal Frame7Score3(ICollection<int> rolls) => _rolls = rolls;
        public Frame8 Then0() => new Frame8(_rolls.With(0));
        public Frame8 Then1() => new Frame8(_rolls.With(1));
        public Frame8 Then2() => new Frame8(_rolls.With(2));
        public Frame8 Then3() => new Frame8(_rolls.With(3));
        public Frame8 Then4() => new Frame8(_rolls.With(4));
        public Frame8 Then5() => new Frame8(_rolls.With(5));
        public Frame8 Then6() => new Frame8(_rolls.With(6));
        public Frame8 Spare() => new Frame8(_rolls.With(7));
    }
    public class Frame7Score4
    {
        private readonly ICollection<int> _rolls;
        internal Frame7Score4(ICollection<int> rolls) => _rolls = rolls;
        public Frame8 Then0() => new Frame8(_rolls.With(0));
        public Frame8 Then1() => new Frame8(_rolls.With(1));
        public Frame8 Then2() => new Frame8(_rolls.With(2));
        public Frame8 Then3() => new Frame8(_rolls.With(3));
        public Frame8 Then4() => new Frame8(_rolls.With(4));
        public Frame8 Then5() => new Frame8(_rolls.With(5));
        public Frame8 Spare() => new Frame8(_rolls.With(6));
    }
    public class Frame7Score5
    {
        private readonly ICollection<int> _rolls;
        internal Frame7Score5(ICollection<int> rolls) => _rolls = rolls;
        public Frame8 Then0() => new Frame8(_rolls.With(0));
        public Frame8 Then1() => new Frame8(_rolls.With(1));
        public Frame8 Then2() => new Frame8(_rolls.With(2));
        public Frame8 Then3() => new Frame8(_rolls.With(3));
        public Frame8 Then4() => new Frame8(_rolls.With(4));
        public Frame8 Spare() => new Frame8(_rolls.With(5));
    }
    public class Frame7Score6
    {
        private readonly ICollection<int> _rolls;
        internal Frame7Score6(ICollection<int> rolls) => _rolls = rolls;
        public Frame8 Then0() => new Frame8(_rolls.With(0));
        public Frame8 Then1() => new Frame8(_rolls.With(1));
        public Frame8 Then2() => new Frame8(_rolls.With(2));
        public Frame8 Then3() => new Frame8(_rolls.With(3));
        public Frame8 Spare() => new Frame8(_rolls.With(4));
    }
    public class Frame7Score7
    {
        private readonly ICollection<int> _rolls;
        internal Frame7Score7(ICollection<int> rolls) => _rolls = rolls;
        public Frame8 Then0() => new Frame8(_rolls.With(0));
        public Frame8 Then1() => new Frame8(_rolls.With(1));
        public Frame8 Then2() => new Frame8(_rolls.With(2));
        public Frame8 Spare() => new Frame8(_rolls.With(3));
    }
    public class Frame7Score8
    {
        private readonly ICollection<int> _rolls;
        internal Frame7Score8(ICollection<int> rolls) => _rolls = rolls;
        public Frame8 Then0() => new Frame8(_rolls.With(0));
        public Frame8 Then1() => new Frame8(_rolls.With(1));
        public Frame8 Spare() => new Frame8(_rolls.With(2));
    }
    public class Frame7Score9
    {
        private readonly ICollection<int> _rolls;
        internal Frame7Score9(ICollection<int> rolls) => _rolls = rolls;
        public Frame8 Then0() => new Frame8(_rolls.With(0));
        public Frame8 Spare() => new Frame8(_rolls.With(1));
    }
}

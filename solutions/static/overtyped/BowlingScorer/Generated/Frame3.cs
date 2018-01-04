using System.Collections.Generic;

namespace BowlingScorer
{
    public class Frame3
    {
        private readonly ICollection<int> _rolls;
        internal Frame3(ICollection<int> rolls) => _rolls = rolls;
        public Frame3Score0 Score0() => new Frame3Score0(_rolls.With(0));
        public Frame3Score1 Score1() => new Frame3Score1(_rolls.With(1));
        public Frame3Score2 Score2() => new Frame3Score2(_rolls.With(2));
        public Frame3Score3 Score3() => new Frame3Score3(_rolls.With(3));
        public Frame3Score4 Score4() => new Frame3Score4(_rolls.With(4));
        public Frame3Score5 Score5() => new Frame3Score5(_rolls.With(5));
        public Frame3Score6 Score6() => new Frame3Score6(_rolls.With(6));
        public Frame3Score7 Score7() => new Frame3Score7(_rolls.With(7));
        public Frame3Score8 Score8() => new Frame3Score8(_rolls.With(8));
        public Frame3Score9 Score9() => new Frame3Score9(_rolls.With(9));
        public Frame4 Strike() => new Frame4(_rolls.With(10));
    }

    public class Frame3Score0
    {
        private readonly ICollection<int> _rolls;
        internal Frame3Score0(ICollection<int> rolls) => _rolls = rolls;
        public Frame4 Then0() => new Frame4(_rolls.With(0));
        public Frame4 Then1() => new Frame4(_rolls.With(1));
        public Frame4 Then2() => new Frame4(_rolls.With(2));
        public Frame4 Then3() => new Frame4(_rolls.With(3));
        public Frame4 Then4() => new Frame4(_rolls.With(4));
        public Frame4 Then5() => new Frame4(_rolls.With(5));
        public Frame4 Then6() => new Frame4(_rolls.With(6));
        public Frame4 Then7() => new Frame4(_rolls.With(7));
        public Frame4 Then8() => new Frame4(_rolls.With(8));
        public Frame4 Then9() => new Frame4(_rolls.With(9));
        public Frame4 Spare() => new Frame4(_rolls.With(10));
    }
    public class Frame3Score1
    {
        private readonly ICollection<int> _rolls;
        internal Frame3Score1(ICollection<int> rolls) => _rolls = rolls;
        public Frame4 Then0() => new Frame4(_rolls.With(0));
        public Frame4 Then1() => new Frame4(_rolls.With(1));
        public Frame4 Then2() => new Frame4(_rolls.With(2));
        public Frame4 Then3() => new Frame4(_rolls.With(3));
        public Frame4 Then4() => new Frame4(_rolls.With(4));
        public Frame4 Then5() => new Frame4(_rolls.With(5));
        public Frame4 Then6() => new Frame4(_rolls.With(6));
        public Frame4 Then7() => new Frame4(_rolls.With(7));
        public Frame4 Then8() => new Frame4(_rolls.With(8));
        public Frame4 Spare() => new Frame4(_rolls.With(9));
    }
    public class Frame3Score2
    {
        private readonly ICollection<int> _rolls;
        internal Frame3Score2(ICollection<int> rolls) => _rolls = rolls;
        public Frame4 Then0() => new Frame4(_rolls.With(0));
        public Frame4 Then1() => new Frame4(_rolls.With(1));
        public Frame4 Then2() => new Frame4(_rolls.With(2));
        public Frame4 Then3() => new Frame4(_rolls.With(3));
        public Frame4 Then4() => new Frame4(_rolls.With(4));
        public Frame4 Then5() => new Frame4(_rolls.With(5));
        public Frame4 Then6() => new Frame4(_rolls.With(6));
        public Frame4 Then7() => new Frame4(_rolls.With(7));
        public Frame4 Spare() => new Frame4(_rolls.With(8));
    }
    public class Frame3Score3
    {
        private readonly ICollection<int> _rolls;
        internal Frame3Score3(ICollection<int> rolls) => _rolls = rolls;
        public Frame4 Then0() => new Frame4(_rolls.With(0));
        public Frame4 Then1() => new Frame4(_rolls.With(1));
        public Frame4 Then2() => new Frame4(_rolls.With(2));
        public Frame4 Then3() => new Frame4(_rolls.With(3));
        public Frame4 Then4() => new Frame4(_rolls.With(4));
        public Frame4 Then5() => new Frame4(_rolls.With(5));
        public Frame4 Then6() => new Frame4(_rolls.With(6));
        public Frame4 Spare() => new Frame4(_rolls.With(7));
    }
    public class Frame3Score4
    {
        private readonly ICollection<int> _rolls;
        internal Frame3Score4(ICollection<int> rolls) => _rolls = rolls;
        public Frame4 Then0() => new Frame4(_rolls.With(0));
        public Frame4 Then1() => new Frame4(_rolls.With(1));
        public Frame4 Then2() => new Frame4(_rolls.With(2));
        public Frame4 Then3() => new Frame4(_rolls.With(3));
        public Frame4 Then4() => new Frame4(_rolls.With(4));
        public Frame4 Then5() => new Frame4(_rolls.With(5));
        public Frame4 Spare() => new Frame4(_rolls.With(6));
    }
    public class Frame3Score5
    {
        private readonly ICollection<int> _rolls;
        internal Frame3Score5(ICollection<int> rolls) => _rolls = rolls;
        public Frame4 Then0() => new Frame4(_rolls.With(0));
        public Frame4 Then1() => new Frame4(_rolls.With(1));
        public Frame4 Then2() => new Frame4(_rolls.With(2));
        public Frame4 Then3() => new Frame4(_rolls.With(3));
        public Frame4 Then4() => new Frame4(_rolls.With(4));
        public Frame4 Spare() => new Frame4(_rolls.With(5));
    }
    public class Frame3Score6
    {
        private readonly ICollection<int> _rolls;
        internal Frame3Score6(ICollection<int> rolls) => _rolls = rolls;
        public Frame4 Then0() => new Frame4(_rolls.With(0));
        public Frame4 Then1() => new Frame4(_rolls.With(1));
        public Frame4 Then2() => new Frame4(_rolls.With(2));
        public Frame4 Then3() => new Frame4(_rolls.With(3));
        public Frame4 Spare() => new Frame4(_rolls.With(4));
    }
    public class Frame3Score7
    {
        private readonly ICollection<int> _rolls;
        internal Frame3Score7(ICollection<int> rolls) => _rolls = rolls;
        public Frame4 Then0() => new Frame4(_rolls.With(0));
        public Frame4 Then1() => new Frame4(_rolls.With(1));
        public Frame4 Then2() => new Frame4(_rolls.With(2));
        public Frame4 Spare() => new Frame4(_rolls.With(3));
    }
    public class Frame3Score8
    {
        private readonly ICollection<int> _rolls;
        internal Frame3Score8(ICollection<int> rolls) => _rolls = rolls;
        public Frame4 Then0() => new Frame4(_rolls.With(0));
        public Frame4 Then1() => new Frame4(_rolls.With(1));
        public Frame4 Spare() => new Frame4(_rolls.With(2));
    }
    public class Frame3Score9
    {
        private readonly ICollection<int> _rolls;
        internal Frame3Score9(ICollection<int> rolls) => _rolls = rolls;
        public Frame4 Then0() => new Frame4(_rolls.With(0));
        public Frame4 Spare() => new Frame4(_rolls.With(1));
    }
}

using System.Collections.Generic;

namespace BowlingScorer
{
    public class Frame5
    {
        private readonly ICollection<int> _rolls;
        internal Frame5(ICollection<int> rolls) => _rolls = rolls;
        public Frame5Score0 Score0() => new Frame5Score0(_rolls.With(0));
        public Frame5Score1 Score1() => new Frame5Score1(_rolls.With(1));
        public Frame5Score2 Score2() => new Frame5Score2(_rolls.With(2));
        public Frame5Score3 Score3() => new Frame5Score3(_rolls.With(3));
        public Frame5Score4 Score4() => new Frame5Score4(_rolls.With(4));
        public Frame5Score5 Score5() => new Frame5Score5(_rolls.With(5));
        public Frame5Score6 Score6() => new Frame5Score6(_rolls.With(6));
        public Frame5Score7 Score7() => new Frame5Score7(_rolls.With(7));
        public Frame5Score8 Score8() => new Frame5Score8(_rolls.With(8));
        public Frame5Score9 Score9() => new Frame5Score9(_rolls.With(9));
        public Frame6 Strike() => new Frame6(_rolls.With(10));
    }

    public class Frame5Score0
    {
        private readonly ICollection<int> _rolls;
        internal Frame5Score0(ICollection<int> rolls) => _rolls = rolls;
        public Frame6 Then0() => new Frame6(_rolls.With(0));
        public Frame6 Then1() => new Frame6(_rolls.With(1));
        public Frame6 Then2() => new Frame6(_rolls.With(2));
        public Frame6 Then3() => new Frame6(_rolls.With(3));
        public Frame6 Then4() => new Frame6(_rolls.With(4));
        public Frame6 Then5() => new Frame6(_rolls.With(5));
        public Frame6 Then6() => new Frame6(_rolls.With(6));
        public Frame6 Then7() => new Frame6(_rolls.With(7));
        public Frame6 Then8() => new Frame6(_rolls.With(8));
        public Frame6 Then9() => new Frame6(_rolls.With(9));
        public Frame6 Spare() => new Frame6(_rolls.With(10));
    }
    public class Frame5Score1
    {
        private readonly ICollection<int> _rolls;
        internal Frame5Score1(ICollection<int> rolls) => _rolls = rolls;
        public Frame6 Then0() => new Frame6(_rolls.With(0));
        public Frame6 Then1() => new Frame6(_rolls.With(1));
        public Frame6 Then2() => new Frame6(_rolls.With(2));
        public Frame6 Then3() => new Frame6(_rolls.With(3));
        public Frame6 Then4() => new Frame6(_rolls.With(4));
        public Frame6 Then5() => new Frame6(_rolls.With(5));
        public Frame6 Then6() => new Frame6(_rolls.With(6));
        public Frame6 Then7() => new Frame6(_rolls.With(7));
        public Frame6 Then8() => new Frame6(_rolls.With(8));
        public Frame6 Spare() => new Frame6(_rolls.With(9));
    }
    public class Frame5Score2
    {
        private readonly ICollection<int> _rolls;
        internal Frame5Score2(ICollection<int> rolls) => _rolls = rolls;
        public Frame6 Then0() => new Frame6(_rolls.With(0));
        public Frame6 Then1() => new Frame6(_rolls.With(1));
        public Frame6 Then2() => new Frame6(_rolls.With(2));
        public Frame6 Then3() => new Frame6(_rolls.With(3));
        public Frame6 Then4() => new Frame6(_rolls.With(4));
        public Frame6 Then5() => new Frame6(_rolls.With(5));
        public Frame6 Then6() => new Frame6(_rolls.With(6));
        public Frame6 Then7() => new Frame6(_rolls.With(7));
        public Frame6 Spare() => new Frame6(_rolls.With(8));
    }
    public class Frame5Score3
    {
        private readonly ICollection<int> _rolls;
        internal Frame5Score3(ICollection<int> rolls) => _rolls = rolls;
        public Frame6 Then0() => new Frame6(_rolls.With(0));
        public Frame6 Then1() => new Frame6(_rolls.With(1));
        public Frame6 Then2() => new Frame6(_rolls.With(2));
        public Frame6 Then3() => new Frame6(_rolls.With(3));
        public Frame6 Then4() => new Frame6(_rolls.With(4));
        public Frame6 Then5() => new Frame6(_rolls.With(5));
        public Frame6 Then6() => new Frame6(_rolls.With(6));
        public Frame6 Spare() => new Frame6(_rolls.With(7));
    }
    public class Frame5Score4
    {
        private readonly ICollection<int> _rolls;
        internal Frame5Score4(ICollection<int> rolls) => _rolls = rolls;
        public Frame6 Then0() => new Frame6(_rolls.With(0));
        public Frame6 Then1() => new Frame6(_rolls.With(1));
        public Frame6 Then2() => new Frame6(_rolls.With(2));
        public Frame6 Then3() => new Frame6(_rolls.With(3));
        public Frame6 Then4() => new Frame6(_rolls.With(4));
        public Frame6 Then5() => new Frame6(_rolls.With(5));
        public Frame6 Spare() => new Frame6(_rolls.With(6));
    }
    public class Frame5Score5
    {
        private readonly ICollection<int> _rolls;
        internal Frame5Score5(ICollection<int> rolls) => _rolls = rolls;
        public Frame6 Then0() => new Frame6(_rolls.With(0));
        public Frame6 Then1() => new Frame6(_rolls.With(1));
        public Frame6 Then2() => new Frame6(_rolls.With(2));
        public Frame6 Then3() => new Frame6(_rolls.With(3));
        public Frame6 Then4() => new Frame6(_rolls.With(4));
        public Frame6 Spare() => new Frame6(_rolls.With(5));
    }
    public class Frame5Score6
    {
        private readonly ICollection<int> _rolls;
        internal Frame5Score6(ICollection<int> rolls) => _rolls = rolls;
        public Frame6 Then0() => new Frame6(_rolls.With(0));
        public Frame6 Then1() => new Frame6(_rolls.With(1));
        public Frame6 Then2() => new Frame6(_rolls.With(2));
        public Frame6 Then3() => new Frame6(_rolls.With(3));
        public Frame6 Spare() => new Frame6(_rolls.With(4));
    }
    public class Frame5Score7
    {
        private readonly ICollection<int> _rolls;
        internal Frame5Score7(ICollection<int> rolls) => _rolls = rolls;
        public Frame6 Then0() => new Frame6(_rolls.With(0));
        public Frame6 Then1() => new Frame6(_rolls.With(1));
        public Frame6 Then2() => new Frame6(_rolls.With(2));
        public Frame6 Spare() => new Frame6(_rolls.With(3));
    }
    public class Frame5Score8
    {
        private readonly ICollection<int> _rolls;
        internal Frame5Score8(ICollection<int> rolls) => _rolls = rolls;
        public Frame6 Then0() => new Frame6(_rolls.With(0));
        public Frame6 Then1() => new Frame6(_rolls.With(1));
        public Frame6 Spare() => new Frame6(_rolls.With(2));
    }
    public class Frame5Score9
    {
        private readonly ICollection<int> _rolls;
        internal Frame5Score9(ICollection<int> rolls) => _rolls = rolls;
        public Frame6 Then0() => new Frame6(_rolls.With(0));
        public Frame6 Spare() => new Frame6(_rolls.With(1));
    }
}

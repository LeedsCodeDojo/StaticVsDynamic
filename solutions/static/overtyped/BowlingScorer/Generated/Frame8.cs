using System.Collections.Generic;

namespace BowlingScorer
{
    public class Frame8
    {
        private readonly ICollection<int> _rolls;
        internal Frame8(ICollection<int> rolls) => _rolls = rolls;
        public Frame8Score0 Score0() => new Frame8Score0(_rolls.With(0));
        public Frame8Score1 Score1() => new Frame8Score1(_rolls.With(1));
        public Frame8Score2 Score2() => new Frame8Score2(_rolls.With(2));
        public Frame8Score3 Score3() => new Frame8Score3(_rolls.With(3));
        public Frame8Score4 Score4() => new Frame8Score4(_rolls.With(4));
        public Frame8Score5 Score5() => new Frame8Score5(_rolls.With(5));
        public Frame8Score6 Score6() => new Frame8Score6(_rolls.With(6));
        public Frame8Score7 Score7() => new Frame8Score7(_rolls.With(7));
        public Frame8Score8 Score8() => new Frame8Score8(_rolls.With(8));
        public Frame8Score9 Score9() => new Frame8Score9(_rolls.With(9));
        public Frame9 Strike() => new Frame9(_rolls.With(10));
    }

    public class Frame8Score0
    {
        private readonly ICollection<int> _rolls;
        internal Frame8Score0(ICollection<int> rolls) => _rolls = rolls;
        public Frame9 Then0() => new Frame9(_rolls.With(0));
        public Frame9 Then1() => new Frame9(_rolls.With(1));
        public Frame9 Then2() => new Frame9(_rolls.With(2));
        public Frame9 Then3() => new Frame9(_rolls.With(3));
        public Frame9 Then4() => new Frame9(_rolls.With(4));
        public Frame9 Then5() => new Frame9(_rolls.With(5));
        public Frame9 Then6() => new Frame9(_rolls.With(6));
        public Frame9 Then7() => new Frame9(_rolls.With(7));
        public Frame9 Then8() => new Frame9(_rolls.With(8));
        public Frame9 Then9() => new Frame9(_rolls.With(9));
        public Frame9 Spare() => new Frame9(_rolls.With(10));
    }
    public class Frame8Score1
    {
        private readonly ICollection<int> _rolls;
        internal Frame8Score1(ICollection<int> rolls) => _rolls = rolls;
        public Frame9 Then0() => new Frame9(_rolls.With(0));
        public Frame9 Then1() => new Frame9(_rolls.With(1));
        public Frame9 Then2() => new Frame9(_rolls.With(2));
        public Frame9 Then3() => new Frame9(_rolls.With(3));
        public Frame9 Then4() => new Frame9(_rolls.With(4));
        public Frame9 Then5() => new Frame9(_rolls.With(5));
        public Frame9 Then6() => new Frame9(_rolls.With(6));
        public Frame9 Then7() => new Frame9(_rolls.With(7));
        public Frame9 Then8() => new Frame9(_rolls.With(8));
        public Frame9 Spare() => new Frame9(_rolls.With(9));
    }
    public class Frame8Score2
    {
        private readonly ICollection<int> _rolls;
        internal Frame8Score2(ICollection<int> rolls) => _rolls = rolls;
        public Frame9 Then0() => new Frame9(_rolls.With(0));
        public Frame9 Then1() => new Frame9(_rolls.With(1));
        public Frame9 Then2() => new Frame9(_rolls.With(2));
        public Frame9 Then3() => new Frame9(_rolls.With(3));
        public Frame9 Then4() => new Frame9(_rolls.With(4));
        public Frame9 Then5() => new Frame9(_rolls.With(5));
        public Frame9 Then6() => new Frame9(_rolls.With(6));
        public Frame9 Then7() => new Frame9(_rolls.With(7));
        public Frame9 Spare() => new Frame9(_rolls.With(8));
    }
    public class Frame8Score3
    {
        private readonly ICollection<int> _rolls;
        internal Frame8Score3(ICollection<int> rolls) => _rolls = rolls;
        public Frame9 Then0() => new Frame9(_rolls.With(0));
        public Frame9 Then1() => new Frame9(_rolls.With(1));
        public Frame9 Then2() => new Frame9(_rolls.With(2));
        public Frame9 Then3() => new Frame9(_rolls.With(3));
        public Frame9 Then4() => new Frame9(_rolls.With(4));
        public Frame9 Then5() => new Frame9(_rolls.With(5));
        public Frame9 Then6() => new Frame9(_rolls.With(6));
        public Frame9 Spare() => new Frame9(_rolls.With(7));
    }
    public class Frame8Score4
    {
        private readonly ICollection<int> _rolls;
        internal Frame8Score4(ICollection<int> rolls) => _rolls = rolls;
        public Frame9 Then0() => new Frame9(_rolls.With(0));
        public Frame9 Then1() => new Frame9(_rolls.With(1));
        public Frame9 Then2() => new Frame9(_rolls.With(2));
        public Frame9 Then3() => new Frame9(_rolls.With(3));
        public Frame9 Then4() => new Frame9(_rolls.With(4));
        public Frame9 Then5() => new Frame9(_rolls.With(5));
        public Frame9 Spare() => new Frame9(_rolls.With(6));
    }
    public class Frame8Score5
    {
        private readonly ICollection<int> _rolls;
        internal Frame8Score5(ICollection<int> rolls) => _rolls = rolls;
        public Frame9 Then0() => new Frame9(_rolls.With(0));
        public Frame9 Then1() => new Frame9(_rolls.With(1));
        public Frame9 Then2() => new Frame9(_rolls.With(2));
        public Frame9 Then3() => new Frame9(_rolls.With(3));
        public Frame9 Then4() => new Frame9(_rolls.With(4));
        public Frame9 Spare() => new Frame9(_rolls.With(5));
    }
    public class Frame8Score6
    {
        private readonly ICollection<int> _rolls;
        internal Frame8Score6(ICollection<int> rolls) => _rolls = rolls;
        public Frame9 Then0() => new Frame9(_rolls.With(0));
        public Frame9 Then1() => new Frame9(_rolls.With(1));
        public Frame9 Then2() => new Frame9(_rolls.With(2));
        public Frame9 Then3() => new Frame9(_rolls.With(3));
        public Frame9 Spare() => new Frame9(_rolls.With(4));
    }
    public class Frame8Score7
    {
        private readonly ICollection<int> _rolls;
        internal Frame8Score7(ICollection<int> rolls) => _rolls = rolls;
        public Frame9 Then0() => new Frame9(_rolls.With(0));
        public Frame9 Then1() => new Frame9(_rolls.With(1));
        public Frame9 Then2() => new Frame9(_rolls.With(2));
        public Frame9 Spare() => new Frame9(_rolls.With(3));
    }
    public class Frame8Score8
    {
        private readonly ICollection<int> _rolls;
        internal Frame8Score8(ICollection<int> rolls) => _rolls = rolls;
        public Frame9 Then0() => new Frame9(_rolls.With(0));
        public Frame9 Then1() => new Frame9(_rolls.With(1));
        public Frame9 Spare() => new Frame9(_rolls.With(2));
    }
    public class Frame8Score9
    {
        private readonly ICollection<int> _rolls;
        internal Frame8Score9(ICollection<int> rolls) => _rolls = rolls;
        public Frame9 Then0() => new Frame9(_rolls.With(0));
        public Frame9 Spare() => new Frame9(_rolls.With(1));
    }
}

using System.Collections.Generic;

namespace BowlingScorer
{
    public class Frame9
    {
        private readonly ICollection<int> _rolls;
        internal Frame9(ICollection<int> rolls) => _rolls = rolls;
        public Frame9Score0 Score0() => new Frame9Score0(_rolls.With(0));
        public Frame9Score1 Score1() => new Frame9Score1(_rolls.With(1));
        public Frame9Score2 Score2() => new Frame9Score2(_rolls.With(2));
        public Frame9Score3 Score3() => new Frame9Score3(_rolls.With(3));
        public Frame9Score4 Score4() => new Frame9Score4(_rolls.With(4));
        public Frame9Score5 Score5() => new Frame9Score5(_rolls.With(5));
        public Frame9Score6 Score6() => new Frame9Score6(_rolls.With(6));
        public Frame9Score7 Score7() => new Frame9Score7(_rolls.With(7));
        public Frame9Score8 Score8() => new Frame9Score8(_rolls.With(8));
        public Frame9Score9 Score9() => new Frame9Score9(_rolls.With(9));
        public Frame10 Strike() => new Frame10(_rolls.With(10));
    }

    public class Frame9Score0
    {
        private readonly ICollection<int> _rolls;
        internal Frame9Score0(ICollection<int> rolls) => _rolls = rolls;
        public Frame10 Then0() => new Frame10(_rolls.With(0));
        public Frame10 Then1() => new Frame10(_rolls.With(1));
        public Frame10 Then2() => new Frame10(_rolls.With(2));
        public Frame10 Then3() => new Frame10(_rolls.With(3));
        public Frame10 Then4() => new Frame10(_rolls.With(4));
        public Frame10 Then5() => new Frame10(_rolls.With(5));
        public Frame10 Then6() => new Frame10(_rolls.With(6));
        public Frame10 Then7() => new Frame10(_rolls.With(7));
        public Frame10 Then8() => new Frame10(_rolls.With(8));
        public Frame10 Then9() => new Frame10(_rolls.With(9));
        public Frame10 Spare() => new Frame10(_rolls.With(10));
    }
    public class Frame9Score1
    {
        private readonly ICollection<int> _rolls;
        internal Frame9Score1(ICollection<int> rolls) => _rolls = rolls;
        public Frame10 Then0() => new Frame10(_rolls.With(0));
        public Frame10 Then1() => new Frame10(_rolls.With(1));
        public Frame10 Then2() => new Frame10(_rolls.With(2));
        public Frame10 Then3() => new Frame10(_rolls.With(3));
        public Frame10 Then4() => new Frame10(_rolls.With(4));
        public Frame10 Then5() => new Frame10(_rolls.With(5));
        public Frame10 Then6() => new Frame10(_rolls.With(6));
        public Frame10 Then7() => new Frame10(_rolls.With(7));
        public Frame10 Then8() => new Frame10(_rolls.With(8));
        public Frame10 Spare() => new Frame10(_rolls.With(9));
    }
    public class Frame9Score2
    {
        private readonly ICollection<int> _rolls;
        internal Frame9Score2(ICollection<int> rolls) => _rolls = rolls;
        public Frame10 Then0() => new Frame10(_rolls.With(0));
        public Frame10 Then1() => new Frame10(_rolls.With(1));
        public Frame10 Then2() => new Frame10(_rolls.With(2));
        public Frame10 Then3() => new Frame10(_rolls.With(3));
        public Frame10 Then4() => new Frame10(_rolls.With(4));
        public Frame10 Then5() => new Frame10(_rolls.With(5));
        public Frame10 Then6() => new Frame10(_rolls.With(6));
        public Frame10 Then7() => new Frame10(_rolls.With(7));
        public Frame10 Spare() => new Frame10(_rolls.With(8));
    }
    public class Frame9Score3
    {
        private readonly ICollection<int> _rolls;
        internal Frame9Score3(ICollection<int> rolls) => _rolls = rolls;
        public Frame10 Then0() => new Frame10(_rolls.With(0));
        public Frame10 Then1() => new Frame10(_rolls.With(1));
        public Frame10 Then2() => new Frame10(_rolls.With(2));
        public Frame10 Then3() => new Frame10(_rolls.With(3));
        public Frame10 Then4() => new Frame10(_rolls.With(4));
        public Frame10 Then5() => new Frame10(_rolls.With(5));
        public Frame10 Then6() => new Frame10(_rolls.With(6));
        public Frame10 Spare() => new Frame10(_rolls.With(7));
    }
    public class Frame9Score4
    {
        private readonly ICollection<int> _rolls;
        internal Frame9Score4(ICollection<int> rolls) => _rolls = rolls;
        public Frame10 Then0() => new Frame10(_rolls.With(0));
        public Frame10 Then1() => new Frame10(_rolls.With(1));
        public Frame10 Then2() => new Frame10(_rolls.With(2));
        public Frame10 Then3() => new Frame10(_rolls.With(3));
        public Frame10 Then4() => new Frame10(_rolls.With(4));
        public Frame10 Then5() => new Frame10(_rolls.With(5));
        public Frame10 Spare() => new Frame10(_rolls.With(6));
    }
    public class Frame9Score5
    {
        private readonly ICollection<int> _rolls;
        internal Frame9Score5(ICollection<int> rolls) => _rolls = rolls;
        public Frame10 Then0() => new Frame10(_rolls.With(0));
        public Frame10 Then1() => new Frame10(_rolls.With(1));
        public Frame10 Then2() => new Frame10(_rolls.With(2));
        public Frame10 Then3() => new Frame10(_rolls.With(3));
        public Frame10 Then4() => new Frame10(_rolls.With(4));
        public Frame10 Spare() => new Frame10(_rolls.With(5));
    }
    public class Frame9Score6
    {
        private readonly ICollection<int> _rolls;
        internal Frame9Score6(ICollection<int> rolls) => _rolls = rolls;
        public Frame10 Then0() => new Frame10(_rolls.With(0));
        public Frame10 Then1() => new Frame10(_rolls.With(1));
        public Frame10 Then2() => new Frame10(_rolls.With(2));
        public Frame10 Then3() => new Frame10(_rolls.With(3));
        public Frame10 Spare() => new Frame10(_rolls.With(4));
    }
    public class Frame9Score7
    {
        private readonly ICollection<int> _rolls;
        internal Frame9Score7(ICollection<int> rolls) => _rolls = rolls;
        public Frame10 Then0() => new Frame10(_rolls.With(0));
        public Frame10 Then1() => new Frame10(_rolls.With(1));
        public Frame10 Then2() => new Frame10(_rolls.With(2));
        public Frame10 Spare() => new Frame10(_rolls.With(3));
    }
    public class Frame9Score8
    {
        private readonly ICollection<int> _rolls;
        internal Frame9Score8(ICollection<int> rolls) => _rolls = rolls;
        public Frame10 Then0() => new Frame10(_rolls.With(0));
        public Frame10 Then1() => new Frame10(_rolls.With(1));
        public Frame10 Spare() => new Frame10(_rolls.With(2));
    }
    public class Frame9Score9
    {
        private readonly ICollection<int> _rolls;
        internal Frame9Score9(ICollection<int> rolls) => _rolls = rolls;
        public Frame10 Then0() => new Frame10(_rolls.With(0));
        public Frame10 Spare() => new Frame10(_rolls.With(1));
    }
}

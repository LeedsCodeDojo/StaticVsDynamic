using System.Collections.Generic;

namespace BowlingScorer
{
    public class Frame2
    {
        private readonly ICollection<int> _rolls;
        internal Frame2(ICollection<int> rolls) => _rolls = rolls;
        public Frame2Score0 Score0() => new Frame2Score0(_rolls.With(0));
        public Frame2Score1 Score1() => new Frame2Score1(_rolls.With(1));
        public Frame2Score2 Score2() => new Frame2Score2(_rolls.With(2));
        public Frame2Score3 Score3() => new Frame2Score3(_rolls.With(3));
        public Frame2Score4 Score4() => new Frame2Score4(_rolls.With(4));
        public Frame2Score5 Score5() => new Frame2Score5(_rolls.With(5));
        public Frame2Score6 Score6() => new Frame2Score6(_rolls.With(6));
        public Frame2Score7 Score7() => new Frame2Score7(_rolls.With(7));
        public Frame2Score8 Score8() => new Frame2Score8(_rolls.With(8));
        public Frame2Score9 Score9() => new Frame2Score9(_rolls.With(9));
        public Frame3 Strike() => new Frame3(_rolls.With(10));
    }

    public class Frame2Score0
    {
        private readonly ICollection<int> _rolls;
        internal Frame2Score0(ICollection<int> rolls) => _rolls = rolls;
        public Frame3 Then0() => new Frame3(_rolls.With(0));
        public Frame3 Then1() => new Frame3(_rolls.With(1));
        public Frame3 Then2() => new Frame3(_rolls.With(2));
        public Frame3 Then3() => new Frame3(_rolls.With(3));
        public Frame3 Then4() => new Frame3(_rolls.With(4));
        public Frame3 Then5() => new Frame3(_rolls.With(5));
        public Frame3 Then6() => new Frame3(_rolls.With(6));
        public Frame3 Then7() => new Frame3(_rolls.With(7));
        public Frame3 Then8() => new Frame3(_rolls.With(8));
        public Frame3 Then9() => new Frame3(_rolls.With(9));
        public Frame3 Spare() => new Frame3(_rolls.With(10));
    }
    public class Frame2Score1
    {
        private readonly ICollection<int> _rolls;
        internal Frame2Score1(ICollection<int> rolls) => _rolls = rolls;
        public Frame3 Then0() => new Frame3(_rolls.With(0));
        public Frame3 Then1() => new Frame3(_rolls.With(1));
        public Frame3 Then2() => new Frame3(_rolls.With(2));
        public Frame3 Then3() => new Frame3(_rolls.With(3));
        public Frame3 Then4() => new Frame3(_rolls.With(4));
        public Frame3 Then5() => new Frame3(_rolls.With(5));
        public Frame3 Then6() => new Frame3(_rolls.With(6));
        public Frame3 Then7() => new Frame3(_rolls.With(7));
        public Frame3 Then8() => new Frame3(_rolls.With(8));
        public Frame3 Spare() => new Frame3(_rolls.With(9));
    }
    public class Frame2Score2
    {
        private readonly ICollection<int> _rolls;
        internal Frame2Score2(ICollection<int> rolls) => _rolls = rolls;
        public Frame3 Then0() => new Frame3(_rolls.With(0));
        public Frame3 Then1() => new Frame3(_rolls.With(1));
        public Frame3 Then2() => new Frame3(_rolls.With(2));
        public Frame3 Then3() => new Frame3(_rolls.With(3));
        public Frame3 Then4() => new Frame3(_rolls.With(4));
        public Frame3 Then5() => new Frame3(_rolls.With(5));
        public Frame3 Then6() => new Frame3(_rolls.With(6));
        public Frame3 Then7() => new Frame3(_rolls.With(7));
        public Frame3 Spare() => new Frame3(_rolls.With(8));
    }
    public class Frame2Score3
    {
        private readonly ICollection<int> _rolls;
        internal Frame2Score3(ICollection<int> rolls) => _rolls = rolls;
        public Frame3 Then0() => new Frame3(_rolls.With(0));
        public Frame3 Then1() => new Frame3(_rolls.With(1));
        public Frame3 Then2() => new Frame3(_rolls.With(2));
        public Frame3 Then3() => new Frame3(_rolls.With(3));
        public Frame3 Then4() => new Frame3(_rolls.With(4));
        public Frame3 Then5() => new Frame3(_rolls.With(5));
        public Frame3 Then6() => new Frame3(_rolls.With(6));
        public Frame3 Spare() => new Frame3(_rolls.With(7));
    }
    public class Frame2Score4
    {
        private readonly ICollection<int> _rolls;
        internal Frame2Score4(ICollection<int> rolls) => _rolls = rolls;
        public Frame3 Then0() => new Frame3(_rolls.With(0));
        public Frame3 Then1() => new Frame3(_rolls.With(1));
        public Frame3 Then2() => new Frame3(_rolls.With(2));
        public Frame3 Then3() => new Frame3(_rolls.With(3));
        public Frame3 Then4() => new Frame3(_rolls.With(4));
        public Frame3 Then5() => new Frame3(_rolls.With(5));
        public Frame3 Spare() => new Frame3(_rolls.With(6));
    }
    public class Frame2Score5
    {
        private readonly ICollection<int> _rolls;
        internal Frame2Score5(ICollection<int> rolls) => _rolls = rolls;
        public Frame3 Then0() => new Frame3(_rolls.With(0));
        public Frame3 Then1() => new Frame3(_rolls.With(1));
        public Frame3 Then2() => new Frame3(_rolls.With(2));
        public Frame3 Then3() => new Frame3(_rolls.With(3));
        public Frame3 Then4() => new Frame3(_rolls.With(4));
        public Frame3 Spare() => new Frame3(_rolls.With(5));
    }
    public class Frame2Score6
    {
        private readonly ICollection<int> _rolls;
        internal Frame2Score6(ICollection<int> rolls) => _rolls = rolls;
        public Frame3 Then0() => new Frame3(_rolls.With(0));
        public Frame3 Then1() => new Frame3(_rolls.With(1));
        public Frame3 Then2() => new Frame3(_rolls.With(2));
        public Frame3 Then3() => new Frame3(_rolls.With(3));
        public Frame3 Spare() => new Frame3(_rolls.With(4));
    }
    public class Frame2Score7
    {
        private readonly ICollection<int> _rolls;
        internal Frame2Score7(ICollection<int> rolls) => _rolls = rolls;
        public Frame3 Then0() => new Frame3(_rolls.With(0));
        public Frame3 Then1() => new Frame3(_rolls.With(1));
        public Frame3 Then2() => new Frame3(_rolls.With(2));
        public Frame3 Spare() => new Frame3(_rolls.With(3));
    }
    public class Frame2Score8
    {
        private readonly ICollection<int> _rolls;
        internal Frame2Score8(ICollection<int> rolls) => _rolls = rolls;
        public Frame3 Then0() => new Frame3(_rolls.With(0));
        public Frame3 Then1() => new Frame3(_rolls.With(1));
        public Frame3 Spare() => new Frame3(_rolls.With(2));
    }
    public class Frame2Score9
    {
        private readonly ICollection<int> _rolls;
        internal Frame2Score9(ICollection<int> rolls) => _rolls = rolls;
        public Frame3 Then0() => new Frame3(_rolls.With(0));
        public Frame3 Spare() => new Frame3(_rolls.With(1));
    }
}

using System.Collections.Generic;

namespace BowlingScorer
{
    public class Frame1Score0
    {
        private readonly ICollection<int> _rolls;
        internal Frame1Score0(ICollection<int> rolls) => _rolls = rolls;
        public Frame2 Then0() => new Frame2(_rolls.With(0));
        public Frame2 Then1() => new Frame2(_rolls.With(1));
        public Frame2 Then2() => new Frame2(_rolls.With(2));
        public Frame2 Then3() => new Frame2(_rolls.With(3));
        public Frame2 Then4() => new Frame2(_rolls.With(4));
        public Frame2 Then5() => new Frame2(_rolls.With(5));
        public Frame2 Then6() => new Frame2(_rolls.With(6));
        public Frame2 Then7() => new Frame2(_rolls.With(7));
        public Frame2 Then8() => new Frame2(_rolls.With(8));
        public Frame2 Then9() => new Frame2(_rolls.With(9));
        public Frame2 Spare() => new Frame2(_rolls.With(10));
    }
    public class Frame1Score1
    {
        private readonly ICollection<int> _rolls;
        internal Frame1Score1(ICollection<int> rolls) => _rolls = rolls;
        public Frame2 Then0() => new Frame2(_rolls.With(0));
        public Frame2 Then1() => new Frame2(_rolls.With(1));
        public Frame2 Then2() => new Frame2(_rolls.With(2));
        public Frame2 Then3() => new Frame2(_rolls.With(3));
        public Frame2 Then4() => new Frame2(_rolls.With(4));
        public Frame2 Then5() => new Frame2(_rolls.With(5));
        public Frame2 Then6() => new Frame2(_rolls.With(6));
        public Frame2 Then7() => new Frame2(_rolls.With(7));
        public Frame2 Then8() => new Frame2(_rolls.With(8));
        public Frame2 Spare() => new Frame2(_rolls.With(9));
    }
    public class Frame1Score2
    {
        private readonly ICollection<int> _rolls;
        internal Frame1Score2(ICollection<int> rolls) => _rolls = rolls;
        public Frame2 Then0() => new Frame2(_rolls.With(0));
        public Frame2 Then1() => new Frame2(_rolls.With(1));
        public Frame2 Then2() => new Frame2(_rolls.With(2));
        public Frame2 Then3() => new Frame2(_rolls.With(3));
        public Frame2 Then4() => new Frame2(_rolls.With(4));
        public Frame2 Then5() => new Frame2(_rolls.With(5));
        public Frame2 Then6() => new Frame2(_rolls.With(6));
        public Frame2 Then7() => new Frame2(_rolls.With(7));
        public Frame2 Spare() => new Frame2(_rolls.With(8));
    }
    public class Frame1Score3
    {
        private readonly ICollection<int> _rolls;
        internal Frame1Score3(ICollection<int> rolls) => _rolls = rolls;
        public Frame2 Then0() => new Frame2(_rolls.With(0));
        public Frame2 Then1() => new Frame2(_rolls.With(1));
        public Frame2 Then2() => new Frame2(_rolls.With(2));
        public Frame2 Then3() => new Frame2(_rolls.With(3));
        public Frame2 Then4() => new Frame2(_rolls.With(4));
        public Frame2 Then5() => new Frame2(_rolls.With(5));
        public Frame2 Then6() => new Frame2(_rolls.With(6));
        public Frame2 Spare() => new Frame2(_rolls.With(7));
    }
    public class Frame1Score4
    {
        private readonly ICollection<int> _rolls;
        internal Frame1Score4(ICollection<int> rolls) => _rolls = rolls;
        public Frame2 Then0() => new Frame2(_rolls.With(0));
        public Frame2 Then1() => new Frame2(_rolls.With(1));
        public Frame2 Then2() => new Frame2(_rolls.With(2));
        public Frame2 Then3() => new Frame2(_rolls.With(3));
        public Frame2 Then4() => new Frame2(_rolls.With(4));
        public Frame2 Then5() => new Frame2(_rolls.With(5));
        public Frame2 Spare() => new Frame2(_rolls.With(6));
    }
    public class Frame1Score5
    {
        private readonly ICollection<int> _rolls;
        internal Frame1Score5(ICollection<int> rolls) => _rolls = rolls;
        public Frame2 Then0() => new Frame2(_rolls.With(0));
        public Frame2 Then1() => new Frame2(_rolls.With(1));
        public Frame2 Then2() => new Frame2(_rolls.With(2));
        public Frame2 Then3() => new Frame2(_rolls.With(3));
        public Frame2 Then4() => new Frame2(_rolls.With(4));
        public Frame2 Spare() => new Frame2(_rolls.With(5));
    }
    public class Frame1Score6
    {
        private readonly ICollection<int> _rolls;
        internal Frame1Score6(ICollection<int> rolls) => _rolls = rolls;
        public Frame2 Then0() => new Frame2(_rolls.With(0));
        public Frame2 Then1() => new Frame2(_rolls.With(1));
        public Frame2 Then2() => new Frame2(_rolls.With(2));
        public Frame2 Then3() => new Frame2(_rolls.With(3));
        public Frame2 Spare() => new Frame2(_rolls.With(4));
    }
    public class Frame1Score7
    {
        private readonly ICollection<int> _rolls;
        internal Frame1Score7(ICollection<int> rolls) => _rolls = rolls;
        public Frame2 Then0() => new Frame2(_rolls.With(0));
        public Frame2 Then1() => new Frame2(_rolls.With(1));
        public Frame2 Then2() => new Frame2(_rolls.With(2));
        public Frame2 Spare() => new Frame2(_rolls.With(3));
    }
    public class Frame1Score8
    {
        private readonly ICollection<int> _rolls;
        internal Frame1Score8(ICollection<int> rolls) => _rolls = rolls;
        public Frame2 Then0() => new Frame2(_rolls.With(0));
        public Frame2 Then1() => new Frame2(_rolls.With(1));
        public Frame2 Spare() => new Frame2(_rolls.With(2));
    }
    public class Frame1Score9
    {
        private readonly ICollection<int> _rolls;
        internal Frame1Score9(ICollection<int> rolls) => _rolls = rolls;
        public Frame2 Then0() => new Frame2(_rolls.With(0));
        public Frame2 Spare() => new Frame2(_rolls.With(1));
    }
}

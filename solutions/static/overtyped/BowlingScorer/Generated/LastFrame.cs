using System.Collections.Generic;

namespace BowlingScorer
{
    public class Frame10
    {
        private readonly ICollection<int> _rolls;
        internal Frame10(ICollection<int> rolls) => _rolls = rolls;
        public Frame10Score0 Score0() => new Frame10Score0(_rolls.With(0));
        public Frame10Score1 Score1() => new Frame10Score1(_rolls.With(1));
        public Frame10Score2 Score2() => new Frame10Score2(_rolls.With(2));
        public Frame10Score3 Score3() => new Frame10Score3(_rolls.With(3));
        public Frame10Score4 Score4() => new Frame10Score4(_rolls.With(4));
        public Frame10Score5 Score5() => new Frame10Score5(_rolls.With(5));
        public Frame10Score6 Score6() => new Frame10Score6(_rolls.With(6));
        public Frame10Score7 Score7() => new Frame10Score7(_rolls.With(7));
        public Frame10Score8 Score8() => new Frame10Score8(_rolls.With(8));
        public Frame10Score9 Score9() => new Frame10Score9(_rolls.With(9));
        public BonusBalls Strike() => new BonusBalls(_rolls.With(10));
    }

    public class Frame10Score0
    {
        private readonly ICollection<int> _rolls;
        internal Frame10Score0(ICollection<int> rolls) => _rolls = rolls;
        public Finished Then0() => new Finished(_rolls.With(0));
        public Finished Then1() => new Finished(_rolls.With(1));
        public Finished Then2() => new Finished(_rolls.With(2));
        public Finished Then3() => new Finished(_rolls.With(3));
        public Finished Then4() => new Finished(_rolls.With(4));
        public Finished Then5() => new Finished(_rolls.With(5));
        public Finished Then6() => new Finished(_rolls.With(6));
        public Finished Then7() => new Finished(_rolls.With(7));
        public Finished Then8() => new Finished(_rolls.With(8));
        public Finished Then9() => new Finished(_rolls.With(9));
        public BonusBall Spare() => new BonusBall(_rolls.With(10));
    }

    public class Frame10Score1
    {
        private readonly ICollection<int> _rolls;
        internal Frame10Score1(ICollection<int> rolls) => _rolls = rolls;
        public Finished Then0() => new Finished(_rolls.With(0));
        public Finished Then1() => new Finished(_rolls.With(1));
        public Finished Then2() => new Finished(_rolls.With(2));
        public Finished Then3() => new Finished(_rolls.With(3));
        public Finished Then4() => new Finished(_rolls.With(4));
        public Finished Then5() => new Finished(_rolls.With(5));
        public Finished Then6() => new Finished(_rolls.With(6));
        public Finished Then7() => new Finished(_rolls.With(7));
        public Finished Then8() => new Finished(_rolls.With(8));
        public BonusBall Spare() => new BonusBall(_rolls.With(9));
    }

    public class Frame10Score2
    {
        private readonly ICollection<int> _rolls;
        internal Frame10Score2(ICollection<int> rolls) => _rolls = rolls;
        public Finished Then0() => new Finished(_rolls.With(0));
        public Finished Then1() => new Finished(_rolls.With(1));
        public Finished Then2() => new Finished(_rolls.With(2));
        public Finished Then3() => new Finished(_rolls.With(3));
        public Finished Then4() => new Finished(_rolls.With(4));
        public Finished Then5() => new Finished(_rolls.With(5));
        public Finished Then6() => new Finished(_rolls.With(6));
        public Finished Then7() => new Finished(_rolls.With(7));
        public BonusBall Spare() => new BonusBall(_rolls.With(8));
    }

    public class Frame10Score3
    {
        private readonly ICollection<int> _rolls;
        internal Frame10Score3(ICollection<int> rolls) => _rolls = rolls;
        public Finished Then0() => new Finished(_rolls.With(0));
        public Finished Then1() => new Finished(_rolls.With(1));
        public Finished Then2() => new Finished(_rolls.With(2));
        public Finished Then3() => new Finished(_rolls.With(3));
        public Finished Then4() => new Finished(_rolls.With(4));
        public Finished Then5() => new Finished(_rolls.With(5));
        public Finished Then6() => new Finished(_rolls.With(6));
        public BonusBall Spare() => new BonusBall(_rolls.With(7));
    }

    public class Frame10Score4
    {
        private readonly ICollection<int> _rolls;
        internal Frame10Score4(ICollection<int> rolls) => _rolls = rolls;
        public Finished Then0() => new Finished(_rolls.With(0));
        public Finished Then1() => new Finished(_rolls.With(1));
        public Finished Then2() => new Finished(_rolls.With(2));
        public Finished Then3() => new Finished(_rolls.With(3));
        public Finished Then4() => new Finished(_rolls.With(4));
        public Finished Then5() => new Finished(_rolls.With(5));
        public BonusBall Spare() => new BonusBall(_rolls.With(6));
    }

    public class Frame10Score5
    {
        private readonly ICollection<int> _rolls;
        internal Frame10Score5(ICollection<int> rolls) => _rolls = rolls;
        public Finished Then0() => new Finished(_rolls.With(0));
        public Finished Then1() => new Finished(_rolls.With(1));
        public Finished Then2() => new Finished(_rolls.With(2));
        public Finished Then3() => new Finished(_rolls.With(3));
        public Finished Then4() => new Finished(_rolls.With(4));
        public BonusBall Spare() => new BonusBall(_rolls.With(5));
    }

    public class Frame10Score6
    {
        private readonly ICollection<int> _rolls;
        internal Frame10Score6(ICollection<int> rolls) => _rolls = rolls;
        public Finished Then0() => new Finished(_rolls.With(0));
        public Finished Then1() => new Finished(_rolls.With(1));
        public Finished Then2() => new Finished(_rolls.With(2));
        public Finished Then3() => new Finished(_rolls.With(3));
        public BonusBall Spare() => new BonusBall(_rolls.With(4));
    }

    public class Frame10Score7
    {
        private readonly ICollection<int> _rolls;
        internal Frame10Score7(ICollection<int> rolls) => _rolls = rolls;
        public Finished Then0() => new Finished(_rolls.With(0));
        public Finished Then1() => new Finished(_rolls.With(1));
        public Finished Then2() => new Finished(_rolls.With(2));
        public BonusBall Spare() => new BonusBall(_rolls.With(3));
    }

    public class Frame10Score8
    {
        private readonly ICollection<int> _rolls;
        internal Frame10Score8(ICollection<int> rolls) => _rolls = rolls;
        public Finished Then0() => new Finished(_rolls.With(0));
        public Finished Then1() => new Finished(_rolls.With(1));
        public BonusBall Spare() => new BonusBall(_rolls.With(2));
    }

    public class Frame10Score9
    {
        private readonly ICollection<int> _rolls;
        internal Frame10Score9(ICollection<int> rolls) => _rolls = rolls;
        public Finished Then0() => new Finished(_rolls.With(0));
        public BonusBall Spare() => new BonusBall(_rolls.With(1));
    }

    public class BonusBalls
    {
        private readonly ICollection<int> _rolls;
        internal BonusBalls(ICollection<int> rolls) => _rolls = rolls;
        public Finished Score0() => new Finished(_rolls.With(0));
        public Finished Score1() => new Finished(_rolls.With(1));
        public Finished Score2() => new Finished(_rolls.With(2));
        public Finished Score3() => new Finished(_rolls.With(3));
        public Finished Score4() => new Finished(_rolls.With(4));
        public Finished Score5() => new Finished(_rolls.With(5));
        public Finished Score6() => new Finished(_rolls.With(6));
        public Finished Score7() => new Finished(_rolls.With(7));
        public Finished Score8() => new Finished(_rolls.With(8));
        public Finished Score9() => new Finished(_rolls.With(9));
        public BonusBall Strike() => new BonusBall(_rolls.With(10));
    }

    public class BonusBall
    {
        private readonly ICollection<int> _rolls;
        internal BonusBall(ICollection<int> rolls) => _rolls = rolls;
        public Finished Score0() => new Finished(_rolls.With(0));
        public Finished Score1() => new Finished(_rolls.With(1));
        public Finished Score2() => new Finished(_rolls.With(2));
        public Finished Score3() => new Finished(_rolls.With(3));
        public Finished Score4() => new Finished(_rolls.With(4));
        public Finished Score5() => new Finished(_rolls.With(5));
        public Finished Score6() => new Finished(_rolls.With(6));
        public Finished Score7() => new Finished(_rolls.With(7));
        public Finished Score8() => new Finished(_rolls.With(8));
        public Finished Score9() => new Finished(_rolls.With(9));
        public Finished Strike() => new Finished(_rolls.With(10));
    }
}

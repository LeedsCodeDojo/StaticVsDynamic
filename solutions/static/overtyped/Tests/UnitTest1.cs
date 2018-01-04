using BowlingScorer;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var score = Game
                .Strike()
                .Strike()
                .Strike()
                .Strike()
                .Strike()
                .Strike()
                .Strike()
                .Strike()
                .Strike()
                .Strike()
                .Strike()
                .Strike()
                .CalculateScore();
            Assert.AreEqual(300, score);
        }

        [TestMethod]
        public void TestMethod2()
        {
            var score = Game
                .Score0().Then0()
                .Score0().Then0()
                .Score0().Then0()
                .Score0().Then0()
                .Score0().Then0()
                .Score0().Then0()
                .Score0().Then0()
                .Score0().Then0()
                .Score0().Then0()
                .Score0().Then0()
                .CalculateScore();
            Assert.AreEqual(0, score);
        }
    }
}

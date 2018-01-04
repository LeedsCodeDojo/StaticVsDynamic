using System.IO;
using System.Linq;
using System.Text;
using System.Threading;

namespace CodeGEn
{
    internal class Program
    {
        private static void Main()
        {
            var cd = Directory.GetCurrentDirectory();
            var generatedFolder = Path.GetFullPath(Path.Combine(cd, "..", "BowlingScorer", "Generated"));
            if (Directory.Exists(generatedFolder))
            {
                Directory.Delete(generatedFolder, true);
            }

            Directory.CreateDirectory(generatedFolder);
            Thread.Sleep(200); //Temporary
            foreach (var frame in Enumerable.Range(1, 9))
            {
                var code = $@"using System.Collections.Generic;

namespace BowlingScorer
{{
{GenerateClasses(frame)}}}
";
                File.WriteAllText(Path.Combine(generatedFolder, $"Frame{frame}.cs"), code);
            }


            var finalCode = new StringBuilder();
                finalCode.AppendLine(@"using System.Collections.Generic;

namespace BowlingScorer
{
    public class Frame10
    {
        private readonly ICollection<int> _rolls;
        internal Frame10(ICollection<int> rolls) => _rolls = rolls;");
                foreach (var ball1 in Enumerable.Range(0, 10))
                {
                    finalCode.AppendLine(
                        $@"        public Frame10Score{ball1} Score{ball1}() => new Frame10Score{ball1}(_rolls.With({ball1}));");
                }
                finalCode.AppendLine(@"        public BonusBalls Strike() => new BonusBalls(_rolls.With(10));
    }");
                finalCode.AppendLine();

            foreach (var ball1 in Enumerable.Range(0, 10))
            {
                finalCode.AppendLine($"    public class Frame10Score{ball1}");
                finalCode.AppendLine("    {");
                finalCode.AppendLine("        private readonly ICollection<int> _rolls;");
                finalCode.AppendLine($"        internal Frame10Score{ball1}(ICollection<int> rolls) => _rolls = rolls;");
                foreach (var ball2 in Enumerable.Range(0, 10 - ball1))
                {
                    finalCode.AppendLine($"        public Finished Then{ball2}() => new Finished(_rolls.With({ball2}));");
                }
                finalCode.AppendLine($"        public BonusBall Spare() => new BonusBall(_rolls.With({10 - ball1}));");

                finalCode.AppendLine("    }");
                finalCode.AppendLine();
            }

            finalCode.AppendLine(@"    public class BonusBalls
    {
        private readonly ICollection<int> _rolls;
        internal BonusBalls(ICollection<int> rolls) => _rolls = rolls;");
            foreach (var ball1 in Enumerable.Range(0, 10))
            {
                finalCode.AppendLine(
                    $@"        public Finished Score{ball1}() => new Finished(_rolls.With({ball1}));");
            }
            finalCode.AppendLine(@"        public BonusBall Strike() => new BonusBall(_rolls.With(10));
    }");
            finalCode.AppendLine();

            finalCode.AppendLine(@"    public class BonusBall
    {
        private readonly ICollection<int> _rolls;
        internal BonusBall(ICollection<int> rolls) => _rolls = rolls;");
            foreach (var ball1 in Enumerable.Range(0, 10))
            {
                finalCode.AppendLine(
                    $@"        public Finished Score{ball1}() => new Finished(_rolls.With({ball1}));");
            }
            finalCode.AppendLine(@"        public Finished Strike() => new Finished(_rolls.With(10));
    }");

            finalCode.AppendLine("}");

            File.WriteAllText(Path.Combine(generatedFolder, "LastFrame.cs"), finalCode.ToString());
        }

        private static string GenerateClasses(int frame)
        {
            var output = new StringBuilder();
            if (frame > 1)
            {
                output.AppendLine($@"    public class Frame{frame}
    {{
        private readonly ICollection<int> _rolls;
        internal Frame{frame}(ICollection<int> rolls) => _rolls = rolls;");
                foreach (var ball1 in Enumerable.Range(0, 10))
                {
                output.AppendLine(
                    $@"        public Frame{frame}Score{ball1} Score{ball1}() => new Frame{frame}Score{ball1}(_rolls.With({ball1}));");
                }
                output.AppendLine($@"        public Frame{frame + 1} Strike() => new Frame{frame + 1}(_rolls.With(10));
    }}");
            }

            foreach (var ball1 in Enumerable.Range(0, 10))
            {
                if (frame > 1 && ball1 == 0)
                {
                    output.AppendLine();
                }

                output.AppendLine($"    public class Frame{frame}Score{ball1}");
                output.AppendLine("    {");
                output.AppendLine("        private readonly ICollection<int> _rolls;");
                output.AppendLine($"        internal Frame{frame}Score{ball1}(ICollection<int> rolls) => _rolls = rolls;");
                var spareRemainder = 11 - ball1;
                foreach (var ball2 in Enumerable.Range(0, spareRemainder))
                {
                    var name = ball2+1 == spareRemainder ? "Spare" : $"Then{ball2}";
                    output.AppendLine($"        public Frame{frame + 1} {name}() => new Frame{frame + 1}(_rolls.With({ball2}));");
                }

                output.AppendLine("    }");
            }

            return output.ToString();
        }
    }
}
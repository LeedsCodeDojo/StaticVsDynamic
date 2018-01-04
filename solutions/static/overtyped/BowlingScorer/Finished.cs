using System.Collections.Generic;
using System.Linq;

namespace BowlingScorer
{
	public class Finished
	{
		private readonly List<int> _rolls;

		public Finished(ICollection<int> rolls) => _rolls = rolls.ToList();

		public int CalculateScore()
		{
			var total = 0;
			var secondThrow = false;
			var rollsCount = _rolls.Count;
			var frame = 1;
			for (var i = 0; i < rollsCount; i++)
			{
				if (frame > 10)
				{
					break;
				}

				var roll = _rolls[i];
				total += roll;
				var nextIndex = i + 1;
				var lastIndex = i - 1;
				if (roll == 10 && !secondThrow)
				{
					total += _rolls[nextIndex];
					total += _rolls[nextIndex + 1];
					frame += 1;
					continue;
				}

				if (secondThrow && roll + _rolls[lastIndex] == 10)
				{
					total += _rolls[nextIndex];
					frame += 1;
					secondThrow = false;
					continue;
				}
				if (secondThrow)
				{
					frame += 1;
				}
				secondThrow = !secondThrow;

			}

			return total;
		}
	}
}
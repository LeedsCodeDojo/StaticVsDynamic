using System.Collections.Generic;
using System.Linq;

namespace BowlingScorer
{
	internal static class Helpers
	{
		public static ICollection<T> With<T>(this ICollection<T> list, T extra)
		{
			var newList = list.ToList();
			newList.Add(extra);
			return newList;
		}
	}
}
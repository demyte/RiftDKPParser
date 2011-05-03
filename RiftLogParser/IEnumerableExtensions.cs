using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace RiftLogParser
{
	public static class IEnumerableExtensions
	{
		public static void Each<T>(this IEnumerable<T> list, Action<T> action)
		{
			list.ToList().ForEach(action);
		}

		public static string Join(this IEnumerable enumerable, string separator, Func<object, string> action)
		{
			return string.Join(separator, (from object o in enumerable select action(o)).ToArray());
		}
	}
}
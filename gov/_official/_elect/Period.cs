using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.regime_.et.gov._official._elect
{
	internal class Period
	{

		/// <summary>
		/// intentionally designed as primes, to avoid resonance (the vibrates or oscilation frequency coindidend.)
		/// </summary>
		/// <remarks>
		/// the 1st is for <see cref="gov.congress.council"/>.
		/// </remarks>
		public static int[] Intervals =

			[2,5,7,11,7 ]

			//[3,5,7,11,13]

		;
		// 2 is reserved for consecutive second term. and also for the election to hold in one alternative of two years: in odd or even year.
		/// considering maximum terms, if we can exclude primes smaller than that, then the change of office would never exceed. but the maximum terms might be too high. So a compromise is to exclude 2. 3 is not excluded now, as that would make 5 is the min term which is too long, too stale.
	}
}

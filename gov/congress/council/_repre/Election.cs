using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.regime_.et.gov.congress.council._repre
{
	/// <summary>
	/// the constituency partitions voters by the canonical attributes: spatial; that is, by different astrological body such as earth or mars, and then on each planet by country/province/municipal/county/town/rural/hamlet
	/// the interval is the smallest in <see cref="gov._official._elect.Period.Intervals"/>:2, intentionally allows a dynamic process to introduce new and young candidates bringing in new ideas, helping folster future political servant for the people.
	/// </summary>
	/// <remarks>
	/// a representatives can get reelected. 
	/// </remarks>
	internal class Election
	{
		/// <summary>
		/// 
		/// </summary>
		/// <remarks>
		/// United States: Members of the House of Representatives serve 2-year terms. Therefore, elections are held every 2 years.
		/// </remarks>
		/// 
		static public /*readonly*/ int YearsPerTerm =
			gov._official._elect.Period.Intervals.First()		//3
			;
		/// <summary>
		/// consecutive terms include the first(initial) term.
		/// inconsecutive terms is not counted here. eg: after consecutive terms, one can seek reelection in a next nonconsecutive interval.
		/// </summary>
		///  <remarks>
		///  consecutive terms cannot exceed this number.
		/// the total consecutive years one can serve is <see cref="YearsPerTerm"/> * <see cref="ConsecutiveTerms"/>
		/// </remarks>
		/// 
		public static int ConsecutiveTerms = 2	/// this number shall be the ponent of <see cref="YearsPerTerm"/>: <see cref="YearsPerTerm"/>^n.

			;

		/// <summary>
		/// total terms (consecutive or not) cannot exceed this number.
		/// </summary>
		/// <remarks>
		/// In years it's <see cref="TotalTerms"/> * <see cref="YearsPerTerm"/>
		/// </remarks>
		public static int TotalTerms = ConsecutiveTerms *2	/// eg: 3^3 =27

			;

	}
}

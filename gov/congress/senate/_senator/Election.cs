using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.regime_.et.gov.congress.senate._senator
{
	/// <summary>
	/// the constituency partitions voters by profession: farmer, workers, technicians, engineers, teachers, lawyers, medical doctors.
	/// the partition takes academic college as reference, <see cref="nilnul.ken"/>; each trade is organized by an academic union.
	/// The representative ratio might be favorable to:
	///		:those profession which is profound but not many knows
	///		:: these professionals often lack interest in policticals.
	///	, hence the design is intentional this way. But it may induce disputes and manipulation, which must be prevented by some procedures:
	///		, a special committee must be neutrally define these professional unions in advance
	///		: the partitions of nilnul.ken must be well accepted, and separated and interdepended in clear structure.
	///		: each constitucency's members must closely know each other profession, far beyond across the boundaries of different constituency.
	///		: software engineering is utilized, well established, before being deployed.
	/// </summary>
	/// <remarks>
	/// a senator can get reelected. 
	/// </remarks>
	internal class Election
	{
		/// <summary>
		/// </summary>
		/// <remarks>
		/// United States: U.S. Senators serve 6-year terms. Elections for Senate seats are staggered, with approximately one-third of the Senate seats up for election every 2 years.
		/// </remarks>
		/// 
		static public /*readonly*/ int YearsPerTerm =
			gov._official._elect.Period.Intervals[2]	/// 7
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
		public static int ConsecutiveTerms = 2	/// this number shall be the ponent(<see cref="nilnul.num.op_.Ponent"/>) of <see cref="YearsPerTerm"/>: <see cref="YearsPerTerm"/>^n.

			;

		/// <summary>
		/// total terms (consecutive or not) cannot exceed this number.
		/// </summary>
		/// <remarks>
		/// In years it's <see cref="TotalTerms"/> * <see cref="YearsPerTerm"/>
		/// </remarks>
		public static int TotalTerms = ConsecutiveTerms
			*2	/// or 2?

			;

	}
}

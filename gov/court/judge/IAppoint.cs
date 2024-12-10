using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.regime_.et.gov.court.judge
{

	/// studied by law, the rules for social.
	/// <summary>
	/// include the supreme court, or the circuit court;
	/// provincial or lower court judges are nominated at the provincial level: eg, it's elected by the provincial council, not national congress, nominated by governor, not the president ;
	/// </summary>
	/// <remarks>
	/// the process can be for example:
	///		: voted by defendant and suer who have ever been judged.
	///		: nominated by the president
	///		: approved by the congress.
	/// </remarks>
	/// 
	internal class IAppoint
	{
		public static int YearsPerTerm = gov._official._elect.Period.Intervals[3]	/// eg: 11
		;

		/// <summary>
		/// after the nonlast term, defaulted to another one term if no new appointment is raised.
		/// </summary>
		public static int ConsecutiveTerms = 2;

		/// <summary>
		/// </summary>
		/// <remarks>
		/// a judge can continue to be a lawyer or a persecutor.
		///
		/// </remarks>
		public static int TotalTerms = ConsecutiveTerms *2;


	}
}

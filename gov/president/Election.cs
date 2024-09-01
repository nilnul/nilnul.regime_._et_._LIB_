using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.regime_.et.gov.congress.premier
{
	/// <summary>
	/// </summary>
	/// <remarks>
	/// </remarks>
	internal class Election
	{
		/// <summary>
		/// </summary>
		/// 
		static public /*readonly*/ int YearsPerTerm =
			gov._official._elect.Period.Intervals[1]		//5
			;
		/// <summary>
		/// </summary>
		///  <remarks>
		/// </remarks>
		/// 
		public static int ConsecutiveTerms = 2	

			;

		/// <summary>
		/// total terms (consecutive or not) cannot exceed this number.
		/// reserved for contingency situations such as when in war.
		/// </summary>
		/// <remarks>
		/// In years it's <see cref="TotalTerms"/> * <see cref="YearsPerTerm"/>
		/// </remarks>
		public static int TotalTerms = ConsecutiveTerms *2	/// 

			;

	}
}

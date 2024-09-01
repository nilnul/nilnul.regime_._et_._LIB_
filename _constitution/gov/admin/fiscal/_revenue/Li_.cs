using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.regime_.et._constitution.gov.admin.fiscal._revenue
{
	internal enum Li_
	{
		/// <summary>
		/// auction of shared public service:
		///		eg:
		///			tickets to museum, if the accormodation is over registered.
		///			use of aerospace in a specified period of time
		///			rental of public land
		/// </summary>
		Auction
			,
		/// <summary>
		/// eg:
		///		spitting on public land.
		/// </summary>
		Penalty
			,
		/// <summary>
		/// if the above two is enough, tax can be nil.
		/// </summary>
		/// <remarks>
		/// reserved for military, as either a person or a finance support is needed to support the military;
		/// </remarks>
		Tax
	}
}

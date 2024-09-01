using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.regime_.et.people._petition
{
	/// <summary>
	/// whether a petition is responded is determined by several factors:
	///		1) if the petitions are too many, the government might be overwhelmed. So only the most signed petition would be tackled for a period of time, say one month. At least <see cref="_petition.Settings1.limit_per_month"/> for each <see cref="gov.ITrich"/> must be responded to; 
	///		2) if a petition doesnot meet the threshold for a response in a certain period of time <see cref="Settings1.valid_in_months"/>, it's expired.
	/// </summary>
	internal class SettingsX
	{


	}
}

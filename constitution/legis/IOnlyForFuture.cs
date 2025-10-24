using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.regime_.et.constitution.legis
{
	/// <summary>
	/// any law, created new or updated, cannot be applied to current ongoing matters. It's only applied to future matters. Should have any effect on ongoing matters.
	/// eg:
	///		if one matter is already initialized or invested by research/money, it's expected fledgling process till it's complete shall not be affected by the new law. That means, a law must wait for a period time to allow any ongoing project to finish. It can only be applied to project that has been ongoing before the law is promulgated. That means a law can take effect immediately, but a time must be given for it to be universally applicable (any ongoing project is expected to be complete before that time). eg: it might take effect on 20250901, and allow any ongoing matter to follow old law until 20270901 (two years of deference), such that new contract before deferred time can choose explicitly the new law to follow, and new administrative rules shall follow the new law immediatly, even before the deference time.
	///		
	/// </summary>
	/// <remarks>
	///  a transition period must be given to allow:
	///		1) past deeds can follow old law;
	///		2) ongoing deeds can opt for new law;
	///	; after transition, all must follow the new law
	/// </remarks>
	internal class IOnlyForFuture
	{
	}
}

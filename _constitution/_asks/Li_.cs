using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.regime_.et._constitution._asks
{
	internal enum Li_
	{
		/// is it legal for some drug?
		Drug
			,
		/// <summary>
		/// is there death penalty per law?
		/// </summary>
		DeathPenaly
			,
		/// <summary>
		/// is military service voluntary or compulsory?
		/// </summary>
		Conscript
			,
		/// <summary>
		/// Can a military member become gov leader not long after quitting active duty?
		/// </summary>
		Civil0junta
			,
		/// <summary>
		/// is citizenship exclusive? is the citizenship rescindable?
		/// </summary>
		ExclusiveCitizenship
			,

		/// <summary>
		/// polygamny? polyandry? polygeny? or no marriage at all?
		/// </summary>
		/// <remarks>
		/// for versioning compatibility, is marriage allowed to accomodate non traditional such as nonheterosexual or nonhuman?
		/// </remarks>
		/// mating rights means responsibilities:
		///		in war,
		///		in disaster, eg: in the Titanic ship sink, man shall allow women and children escape first, this is especiall true for mating aged men, and for those who has been married, and for those who is polygeny;
		/// 
		Marriage
			,
		/// <summary>
		/// uncensored news;
		/// news agencency must be disowned by <see cref="Governance"/>
		/// </summary>
		/// <remarks>
		/// information(news, policies) flow shall be made free and open.
		/// any archives, including any confidential ones no matter how confidential it is, shall be made open to the congress and the supreme court immediatly, and shall then be made open to the public in a certain time stipulated by a legal procedure. Any procastination shall be approved by the congress.
		/// the documentation involving congress shall be made open to the supreme court and the president immediatly, and then in a certain time shall be made open to the public. Any procastination shall be approved by the court.
		/// the documentation of court shall be made open to the congress and the president immediatly. Any confidential ones shall be made open to the people in a certain time. Any procrastination shall be approved by the congress; the procrastination cannot be too long, and any extending of such procrastination shall be approved on a periodica basis.
		/// </remarks>
		/// whether a document from one branch is confidential shall be determined by another branch ?
		/// the confidential document shall be sealed and sent to the other one or two branches designated by law; and the other one or two branches can open it in a certain time designated by law.
		/// all docments, confidential or no, shall be archived immediatly in a certain system; and some confidential document is sealed, and will be made available to some other branches in a certain time, and finally in some time public to the people. To unseal a confidential document, a procedure is followed; once the procedure is completed, the document is automatically unsealed to the designated group, or all, of people
		InfoFree
	}
}

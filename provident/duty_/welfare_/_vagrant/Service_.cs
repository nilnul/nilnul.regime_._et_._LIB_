using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.regime_.et.provident.duty_.welfare_._vagrant
{
	/// like a capsule hospital/housing (eg: 方舱医院);
	/// not a prison, but the maintenance and management might be somewhat like an open prison.
	///
	/// <summary>
	/// the service provides lodge and boarding to satisfy basic (but not luxury to avoid inducing the unintended seclusion tendency from the active society) living needs:
	///		1) the lodge shall be like a battalion with a big housing with arrangement of many beds, each with a locked (eg: by electronic lock) cabin for personal valuables.
	///		; the lodge, room, and bedding is publicly maintained by hygiene works, so the dwellers don't have to.
	///		2) the meal and shower time is prearranged, one by one in queues, like a paramilitary context.
	///		3) militia training or labor is actively carried out.
	///		4) different genders are partitioned.
	///		5) there are free time reserved when the participants can go anywhere, including to outside, freely, to buy or consume or any other deeds. Eg: weekends can be reserved as such purpose.
	/// </summary>
	/// <remarks>
	/// the participants can register a quit any time.
	/// homeless can participate a variety of service at times.
	/// </remarks>
	internal enum Service_
	{
		/// <summary>
		/// the vagrant can volunteer for militia training at a training center.
		/// </summary>
		/// <remarks>
	/// They can also enroll, at their own volition, formal military service.
		///
		/// </remarks>
		/// 
		MilitiaTraining
			,
		/// <summary>
		/// a voluntary labor organized, perhaps with some simple training.
		/// the labor might be about cleaning public area, to visit and help nursing home for the old and wound, to patrol mountain,lake, forest, etc.
		/// </summary>
		VoluntaryLabor
			,

		/// <summary>
		/// dedicating  life to spiritual work, community service, and religious practices. in temple, church, mosque, etc.
		/// </summary>
		/// 
		Meditation
			,
		/// <summary>
		/// learning some science, technique. The learning center might be about a specialized topic.
		/// </summary>
		LearningCenter
			,
		/// <summary>
		/// for the old or the wound or the disabled. Often they cannot care for themselves. Participant can or have to entrust the nurses/helpers/volunteers to lock there belongings in their locker.
		/// </summary>
		/// <remarks>
		/// leisure here. often in scenery natural unpopulated area.
		/// </remarks>
		NursingCenter
	}
}

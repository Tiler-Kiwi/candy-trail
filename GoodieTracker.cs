/*
 * Created by SharpDevelop.
 * User: adam.moseman
 * Date: 8/15/2016
 * Time: 4:48 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace candytrail2
{
	/// <summary>
	/// Created by PlayerWagon to track goodies. Pretty tightly coupled to it.
	/// 
	///
	/// 
	/// </summary>
	public class GoodieTracker : IGoodieTracker
	{
		public GoodieTracker()
		{
		}
		
		public GoodieTracker(PlayerWagon player)
		{
			PlayerWagon myplayer = player;
		}
	}
}

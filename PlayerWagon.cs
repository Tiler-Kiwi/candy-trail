/*
 * Created by SharpDevelop.
 * User: adam.moseman
 * Date: 8/14/2016
 * Time: 3:57 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace candytrail2
{
	/// <summary>
	/// Description of PlayerWagon.
	/// </summary>
	public class PlayerWagon : IPlayerWagon
	{
		public PlayerWagon()
			: this(100,100,1000)
		{
		}
		
		public PlayerWagon(int gold, int food, int distance)
		{
			int wagongold = gold;
			int wagonfood = food;
			int wagondistance = distance;
		}
	}
}

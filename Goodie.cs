/*
 * Created by SharpDevelop.
 * User: adam.moseman
 * Date: 8/15/2016
 * Time: 5:23 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace candytrail2
{
	/// <summary>
	/// Implementation of GoodieEffect stuff. All should be called via Activate().
	/// </summary>
	public class Village : GoodieEffect
	{
		private IPlayerWagon _wagon;
		
		public Village(IPlayerWagon wagon)
		{
			this._wagon = wagon;
		}
		
		
	}
}

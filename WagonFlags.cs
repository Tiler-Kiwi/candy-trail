/*
 * Created by SharpDevelop.
 * User: adam.moseman
 * Date: 8/15/2016
 * Time: 3:59 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace candytrail2
{
	/// <summary>
	/// enumeration for flags that a wagon must keep track of for pertinant information
	/// </summary>

	[Flags]
	public enum WagonFlags 
	{
		None = 0,
		NoFood = 2,
		DonatedGood = 4,
		FoundMonument = 8,
		TreasureOne = 16,
		TreasureTwo =32,
		Adventure = 64,
		DwarfHold = 128,
		BurialGround = 256,
		Deadlands = 512,
		GPRZFEC = 1024
	}
}

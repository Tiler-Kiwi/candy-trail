/*
 * Created by SharpDevelop.
 * User: adam.moseman
 * Date: 8/14/2016
 * Time: 3:56 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace candytrail2
{
	/// <summary>
	/// Framework for events to be created from.
	/// Utilizes the Subclass Sandbox paradigm
	/// 
	/// 
	/// </summary>
	public abstract class GoodieEffect
	{
		private string goodietext;
		private string goodieforktext;
		private GoodieName goodiename;
		private GoodieType goodietype;
		private PlayerWagon playerwagon;
		
		protected virtual void activate(){}
		protected void DisplayText(){}
		protected void GoodieForkChoice(){}
		protected void GenerateGoodie(){}
		protected void ModifyWagonValues(){}
	}
}

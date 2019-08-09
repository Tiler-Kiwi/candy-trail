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
	/// Does everything related to putting text on the console.
	/// Probably shouldn't ever be called by anyone else.
	/// </summary>
	public class UXMonger : IUXMonger
	{
		public UXMonger()
		{
		}
		
		public void CreditScreen(){}
		public void MainMenu(){}
		public void RenderMainScreen(IPlayerWagon wagon){}
		public void TextWindow(string thing){}
	}
}

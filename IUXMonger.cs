/*
 * Created by SharpDevelop.
 * User: adam.moseman
 * Date: 8/19/2016
 * Time: 3:03 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace candytrail2
{
	/// <summary>
	/// Description of IUXMonger.
	/// </summary>
	public interface IUXMonger
	{
		void TextWindow(string text);
		void RenderMainScreen(IPlayerWagon wagon);
		void MainMenu();
		void CreditScreen();
	}
}

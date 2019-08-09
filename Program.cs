/*
 * Created by SharpDevelop.
 * User: amoseman
 * Date: 7/16/2016
 * Time: 1:49 PM
 * 
 */
using System;
using System.Threading.Tasks;
using System.Timers;

//NOTE: This is not the correct program.cs file. This was created for an even earlier protoype.
//but the program file for candytrail2 was irrecoverably lost

namespace candytrail2
{
	class Program
	{
		public static void Main(string[] args)
		{
			bool gamerunning = true;
			bool paused = false;
			char input = 'X';
			PathTracker pathObject = new PathTracker();
			EventMagic eventObject = new EventMagic();

			Console.WriteLine(" ESCAPE FROM CANDYLAND!\n Controls: Press Space to Pause\n New Game Y/N?");
			input = Convert.ToChar(Console.ReadKey().Key);
			
			if(Char.ToUpper(input)=='Y')
			{
				Console.Write("\r Good! What else would you be doing?\n");
			}
			else
			{
				Console.Write("\r Well that's a funny way to type 'Y'...\n");
			}
			
			while(gamerunning)
			{
				do
				{
					while (! Console.KeyAvailable && gamerunning)
					{
						System.Threading.Thread.Sleep(100);
						Console.Write("\r SPACE:{0} DISTANCE LEFT:{1}", pathObject.currentspot, 1000-pathObject.currentspot);
						pathObject.AdvanceSpot();
						eventObject.PingEvent(pathObject);
						
						if(pathObject.currentspot >= 1000)
						{
							Console.WriteLine(" You Won! Boy howdy I hope this validates you. Also fuck you.");
							Console.WriteLine(" Press any key to quit.");
							Console.ReadKey(true);
							gamerunning = false;
						}
					}
				} while (gamerunning && Console.ReadKey(true).Key != ConsoleKey.Spacebar);
				
				paused = true;
				Console.WriteLine("");
				while(paused && gamerunning)
				{
					Console.Write("\r GAME PAUSED. Hit V to View Surroundings, or hit Space to Proceed...\n");
					input = Convert.ToChar(Console.ReadKey().Key);
					if(input == ' ')
					{
						Console.Write("Game Resumed.\n");
						paused = false;
					}
					else if(Char.ToUpper(input) == 'V')
					{
						pathObject.SurroundingsView();
					}
					else
					{
						Console.Write("Try Again.");
					}
					
				}
			}
		}
	}
}

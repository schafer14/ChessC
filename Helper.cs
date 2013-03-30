using System;
using System.Collections.Generic;
using System.Text;
using System.IO;


/*
  **HELPER.cs

  *Static helper methods
*/
public class Helper
	{
		public static int [] getMove ()
		{
			//Break Point
			Console.WriteLine("m: move, p:print state, c:clear");
			string action = Console.ReadLine();
			if(action=="m")
			{
				int currCol = getCurrCol();
				int currRow = getCurrRow() - 1;//minus one for fence post error on user input
				int col = getCol();
				int row = getRow() - 1;//minus one for fence post error on user input

				int[] ints = new int[] { currCol, currRow, col, row};
				return ints;
			}
			else if (action=="p")
			{
				State.printState();
				return getMove();
			}
			else if (action=="c")
			{
				Console.Clear();
				return getMove();
			}
			else
			{
				Console.WriteLine("I did not get that sorry :(");
				return getMove();
			}
			

		}//function getMove

		public static int getCurrCol()
		{
			Console.Write("Current Column (Letter)");
			string hold = Console.ReadLine();
			if (hold.Length != 1)
			{
				Console.WriteLine("That is not a valid input.");
				return getCurrCol();
			}
			int currCol = letterToNumber(hold);
			return currCol;
		}//end function getCurrCol
		
		public static int getCurrRow()
		{
			Console.Write("Current Row (Number).");
			string hold = Console.ReadLine();
			if (hold.Length != 1)
			{
				Console.WriteLine("That is not a valid input.");
				return getCurrRow();
			}
			int currRow = Convert.ToInt32(hold);
			return currRow;
		}//end function getCurrRow
		
		public static int getCol()
		{
			Console.Write("New Column (Letter).");
			string hold = Console.ReadLine();
			if (hold.Length != 1)
			{
				Console.WriteLine("That is not a valid input.");
				return getCol();
			}
			int col = letterToNumber(hold);
			return col;
		}//end function getCol
		
		public static int getRow()
		{
			Console.Write("New Row (Number)");
			string hold = Console.ReadLine();
			if (hold.Length != 1)
			{
				Console.WriteLine("That is not a valid input.");
				return getRow();
			}
			int row = Convert.ToInt32(hold);
			return row;
		}//end function getRow

		public static string numberToLetter(int integer)
		{
			string newStr = null;
			integer = integer + 1; 
			switch (integer)
			{
				case 1:
					newStr = "a";
					break;
				case 2:
					newStr = "b";
					break;
				case 3:
					newStr = "c";
					break;
				case 4:
					newStr = "d";
					break;
				case 5:
					newStr = "e";
					break;
				case 6:
					newStr = "f";
					break;
				case 7:
					newStr = "g";
					break;
				case 8:
					newStr = "h";
					break;
				default:            
            		Console.WriteLine("In class Helper method moveToNumber: invalid number");            
            		break;  
			}//switch
			return newStr;
		}//function numberToLetter

		public static int letterToNumber(string str)
		{
			int num = -1;
			switch (str)
			{
				case "a":
					num = 0;
					break;
				case "b":
					num = 1;
					break;
				case "c":
					num = 2;
					break;
				case "d":
					num = 3;
					break;
				case "e":
					num = 4;
					break;
				case "f":
					num = 5;
					break;
				case "g":
					num = 6;
					break;
				case "h":
					num = 7;
					break;
				default:            
            		Console.WriteLine("In class Helper method letterToNumber: invalid number");            
            		break;  
			}//switch
			return num;
		}//function letterToNumber

		public static bool checkPosition (int currCol, int currRow, int col, int row)
		{
			if(col < 0 || col > 7 || row < 0 || row > 7)
			{
				Console.Write("Error: invalid input piece is off the board.");
				return false;
			}// endif

			if(currCol < 0 || currCol > 7 || currRow < 0 || currRow > 7)
			{
				Console.Write("Error: invalid input piece is off the board.");
				return false;
			}// endif

			return true;

		}// function checkPosition

	}
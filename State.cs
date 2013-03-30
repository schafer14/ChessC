using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

/*
*
*
* State
*
*
*/
public static class State
{
	//vars
	public static string playerOneColor;
	public static string turn;
	public static int strength;
	public static int moveNumber;
	public static List<Piece> positions = new List<Piece>();

	public static void addPiece (Piece [] pieces)
	{
		foreach (Piece p in pieces)
		{
			positions.Add(p);
		}
	}

	public static void printState ()
	{
		
		Console.Write("playerOneColor: ");
		Console.WriteLine(playerOneColor);

		Console.Write("turn: ");
		Console.WriteLine(turn);

		Console.Write("strength: ");
		Console.WriteLine(strength);

		Console.Write("move number: ");
		Console.WriteLine(moveNumber);

		foreach (Piece p in positions)
		{
			Console.Write(p.color);
			Console.Write(" ");
			Console.Write(p.name);
			Console.Write(" at: ");
			Console.Write(Helper.numberToLetter(p.col));
			Console.Write(p.row + 1);
			if (p.isAlive)
			{
				Console.WriteLine(" is alive.");
			}
			else 
			{
				Console.WriteLine(" is dead.");
			}
		}

		
	}

	public static void updateState()
	{
		if (turn == "White")
		{
			turn = "Black";
		}
		else
		{
			turn = "White";
		}
		moveNumber = moveNumber + 1; 
	}//function updateState

	public static string colorOfPieceAt (int col, int row)
	{
		string correct = "none";
		bool exists = false;
		foreach (Piece p in positions)
		{
			if (p.col == col && p.row == row )
			{
				return p.color;
			} 			
		}
		return correct;
	}

	public static Piece getPieceAtLocation (int col, int row)
	{
		Piece correct = null;
		bool exists = false;
		foreach (Piece p in positions)
		{
			if (p.col == col && p.row == row)
			{
				correct = p;
				exists = true;
			}
			else
			{
				//Do nothing.
			}
		}//positions
		if (exists)
		{
			return correct;
		}
		else
		{
			Console.Write("There is no piece at that location.");
			return null;
		}

	}//function getPieceAtLocation

}//end class State
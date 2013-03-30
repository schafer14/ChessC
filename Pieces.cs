using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

/*
*
*
* Pieces
*
*
*/
public abstract class Piece
{
	public int col;
	public int row;
	public string color;
	public bool isAlive;
	public string name;

	public abstract bool make (int newCol, int newRow);

	public bool legalMove(int newCol, int newRow)
	{
		if (Helper.checkPosition(col, row, newCol, newRow))
		{
			if (col == newCol && row == newRow)
			{
				Console.WriteLine("Your pieces is already there silly!");
				return false;
			}
			else
			{
				if (State.colorOfPieceAt(newCol, newRow) != color)
				{
					if (make(newCol, newRow))
					{
						Console.WriteLine("color of opponent: " + State.colorOfPieceAt(newCol, newRow));
						if (State.colorOfPieceAt(newCol, newRow ) != "none")
						{
							State.getPieceAtLocation(newCol, newRow).isAlive = false;
						}
						return true;
					}
					else
					{
						Console.WriteLine("invalid move");
						return false;
					}
				}
				else
				{
					Console.WriteLine("You already have a piece on that line");
					return false;
				}
			}
		}//if valid position
		else
		{
			Console.WriteLine("You have entered in invalid square");
			return false;
		}
	}

}//end class Piece



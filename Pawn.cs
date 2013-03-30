using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
public class Pawn : Piece
{
	//constructor
	public Pawn (int colInit, int rowInit, string colorInit)
	{
		isAlive = true;
		col = colInit;
		row = rowInit;
		color = colorInit;
		name = "Pawn";
	}

	public override bool make (int newCol, int newRow)
	{
		if (color == "Black")
		{
			if (col != newCol)//Taking on the diagonal
			{
				if (col + 1 == newCol || col - 1 == newCol)
				{
					Piece p = State.getPieceAtLocation(newCol, newRow);
					if (p.color == "White")
					{
						p.isAlive = false;
						return true;
					}
					else
					{
						return false;
					}//if square is occupied by same color
				}
				else
				{
					return false;
				}
			}
			else // moving forward
			{
				if (State.colorOfPieceAt(newCol, newRow) != "none")
				{
					Console.WriteLine("There is already a piece there. ");
					return false;
				}
				else
				{
					if ((row == newRow + 2) && (row == 6))
					{
						return true;
					}
					else if (row == newRow + 1)
					{
						return true;
					}
					else
					{
						return false;
					}
				}
			}
		}
		else //color is white
		{
			if (col != newCol)//Taking on the diagonal
			{
				if (col + 1 == newCol || col - 1 == newCol)
				{
					Piece p = State.getPieceAtLocation(newCol, newRow);
					if (p.color == "Black")
					{
						p.isAlive = false;
						return true;
					}
					else 
					{
						return false;
					}
				}
				else
				{
					return false;
				}
			}
			else // moving forward
			{
				if (State.colorOfPieceAt(newCol, newRow) != "none")
				{
					Console.WriteLine("There is already a piece there. ");
					return false;
				}
				else
				{
					if ((row == newRow - 2) && (row == 1))
					{
						return true;
					}
					else if (row == newRow - 1)
					{
						return true;
					}
					else 
					{
						return false;
					}
				}
			}//else pawn is moving foward
		}//eles color is white
	}//end function legal move

}//end class Pawn
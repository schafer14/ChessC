using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

public class Bishop : Piece
{
	//constructor
	public Bishop (int colInit, int rowInit, string colorInit)
	{
		isAlive = true;
		col = colInit;
		row = rowInit;
		color = colorInit;
		name = "Bishop";
	}

	public override bool make (int newCol, int newRow)
	{
		if (!(Math.Abs(col - newCol) == Math.Abs(row - newRow)))//not moving diagonally.
		{
			return false;
		}
		else //moving along a diagonal
		{
			//case one col > newCol && row > newRow
			if (col > newCol && row > newRow)
			{
				int j = newRow;
				for (int i = newCol; i < col ; i++)
				{
					if (State.colorOfPieceAt(i, j) != "none")
					{
						return false;
					}
					j++;
				}
				return true;
			}
			//case one col < newCol && row > newRow
			else if (col < newCol && row > newRow)
			{
				int j = newRow;
				for (int i = newCol; i < col ; i--)
				{
					if (State.colorOfPieceAt(i, j) != "none")
					{
						return false;
					}
					j++;
				}
				return true;
			}
			//case one col > newCol && row < newRow
			else if (col > newCol && row < newRow)
			{
				int j = newRow;
				for (int i = newCol; i < col ; i++)
				{
					if (State.colorOfPieceAt(i, j) != "none")
					{
						return false;
					}
					j--;
				}
				return true;
			}
			//case one col < newCol && row < newRow
			else
			{
				int j = newRow;
				for (int i = newCol; i < col ; i--)
				{
					if (State.colorOfPieceAt(i, j) != "none")
					{
						return false;
					}
					j--;
				}
				return true;
			}
		}
	}// end of make
}// end of class bishop

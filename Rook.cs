using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

public class Rook : Piece
{
	//constructor
	public Rook (int colInit, int rowInit, string colorInit)
	{
		isAlive = true;
		col = colInit;
		row = rowInit;
		color = colorInit;
		name = "Rook";
	}

	public override bool make (int newCol, int newRow)
	{
		//if both row and col are different
		if ((newRow != row) && (newCol != col))
		{
			return false;
		}
		//Check that there are no pieces when moving along a column
		else if (newRow == row)
		{
			if (col > newCol)
			{
				for (int i = newCol; i < col; i++)
				{
					if (State.colorOfPieceAt(i, row) != "none")
					{
						return false;
					}
				}
				return true;
			}
			else // newCol > col
			{
				for (int i = col; i < newCol; i++)
				{
					if (State.colorOfPieceAt(i, row) != "none")
					{
						return false;
					}
				}
				return true;
			}
		}// end moving along a colum (row == newRow)

		//moving along row
		else //(newCol == col)
		{
			if (row > newRow)
			{
				for (int i = newRow; i < row; i++)
				{
					if (State.colorOfPieceAt(col, i) != "none")
					{
						return false;
					}
				}
				return true;
			}
			else // newCol > col
			{
				for (int i = row; i < newRow; i++)
				{
					if (State.colorOfPieceAt(col, i) != "none")
					{
						return false;
					}
				}
				return true;
			}
		}// end moving along a colum (row == newRow)
	}
}
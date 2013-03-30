using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

public class Queen : Piece
{
	//constructor
	public Queen (int colInit, int rowInit, string colorInit)
	{
		isAlive = true;
		col = colInit;
		row = rowInit;
		color = colorInit;
		name = "Queen";
	}

	public override bool make (int newCol, int newRow)
	{
		if ((Math.Abs(col - newCol) == Math.Abs(row - newRow)))//makes a diagonal move
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
			//case four col < newCol && row < newRow
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
		}//end diagonal move
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
		else if (newCol == col)
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
		else //not diagonal and col != newCol and row != newRow
		{
			return false;
		}
	}
}
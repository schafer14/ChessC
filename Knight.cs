using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

public class Knight : Piece
{
	//constructor
	public Knight (int colInit, int rowInit, string colorInit)
	{
		isAlive = true;
		col = colInit;
		row = rowInit;
		color = colorInit;
		name = "Knight";
	}

	public override bool make (int newCol, int newRow)
	{
		if ((((newRow == row + 2)|| (newRow == row - 2)) && ((newCol == col + 1) || (newCol == col -1)))
		  ||(((newRow == row + 1) || (newRow == row -1)) && ((newCol == col + 2) || (newCol == col -2))))
		{
			return true;
		}
		else
		{
			return false;
		}
	}
}
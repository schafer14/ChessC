using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

public class King : Piece
{
	//constructor
	public King (int colInit, int rowInit, string colorInit)
	{
		isAlive = true;
		col = colInit;
		row = rowInit;
		color = colorInit;
		name = "King";
	}

	public override bool make (int newCol, int newRow)
	{
		if ((col == newCol + 1 || col == newCol -1 || col == newCol)
		  &&(row == newRow + 1 || row == newRow -1 ||(row == newRow && !(col==newCol))))
		{
			return true;
		}
		else
		{
			Console.Write("Invalid move.");
			return false;
		}//if valid move
	}

	public int [] getLocation ()
	{
		int [] use = new int [] {col, row};
		return use;
	}
}//end class King
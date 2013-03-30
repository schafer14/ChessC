using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Better_Half_Chess
{
	class Driver
	{
		static void Main(string [] args)
		{
			initGame();
			State.printState();

			//Playing loop
			bool exit = false;

			do
			{
				int[] move = Helper.getMove();
				Piece currPiece = State.getPieceAtLocation(move[0], move[1]);

				//Check to make sure the correct color is moving.
				if(State.colorOfPieceAt(move[0],move[1])==State.turn)
				{
					if (currPiece == null)
					{
						//do nothing maybe.
					}
					else
					{
						if (currPiece.legalMove(move[2], move[3]))
						{
							Console.WriteLine("Legal Move");
							currPiece.col = move[2];
							currPiece.row = move[3];
							State.updateState();
						}
					}
				}
				else
				{
					Console.WriteLine("It's not your turn.");
				}
				//do
				//{
					//if(turn=="comp")
					//{
					//	call engine
					//	make move	
					//}
					//else 
					//{
					//	wait for response
					//	if (valid())
					//	{
					//		turn="comp"
					//	}
					//  else
					//	{
					//		invalid move response
					//	}
					//}
			}while(exit == false);
			Console.Clear();
		} //static void Main

		public static void initGame()
		{
			Console.Clear();
			//initalize game

			Random rnd = new Random ();
			if (rnd.Next(2)==1)
			{
				State.playerOneColor = "White";
			}
			else
			{
				State.playerOneColor = "Black";
			}

			State.moveNumber = 0;
			State.turn = "White";
			State.strength = 18;

			//Initiate White pieces
			Piece k2 = new King (4, 0, "White");
			Piece q1 = new Queen(3, 0, "White");
			Piece r1 = new Rook(0, 0, "White");
			Piece r2 = new Rook(7, 0, "White");
			Piece b1 = new Bishop (5, 0, "White");
			Piece b2 = new Bishop (2, 0, "White");
			Piece n1 = new Knight (1, 0, "White");
			Piece n2 = new Knight (6, 0, "White");
			//pawns
			Piece p0 = new Pawn (0, 1, "White");
			Piece p1 = new Pawn (1, 1, "White");
			Piece p2 = new Pawn (2, 1, "White");
			Piece p3 = new Pawn (3, 1, "White");
			Piece p4 = new Pawn (4, 1, "White");
			Piece p5 = new Pawn (5, 1, "White");
			Piece p6 = new Pawn (6, 1, "White");
			Piece p7 = new Pawn (7, 1, "White");

			//Initiate Black pieces
			Piece k1 = new King (4, 7, "Black");
			Piece q2 = new Queen (3, 7, "Black");
			Piece r3 = new Rook (0, 7, "Black");
			Piece r4 = new Rook (7, 7, "Black");
			Piece b3 = new Bishop(5, 7, "Black");
			Piece b4 = new Bishop(2, 7, "Black");
			Piece n3 = new Knight (1,7, "Black");
			Piece n4 = new Knight (6,7, "Black");
			//pawns
			Piece p8 = new Pawn (0, 6, "Black");
			Piece p9 = new Pawn (1, 6, "Black");
			Piece p10 = new Pawn (2, 6, "Black");
			Piece p11 = new Pawn (3, 6, "Black");
			Piece p12 = new Pawn (4, 6, "Black");
			Piece p13 = new Pawn (5, 6, "Black");
			Piece p14 = new Pawn (6, 6, "Black");
			Piece p15 = new Pawn (7, 6, "Black");

			//Add pieces to piece array
			Piece[] pieces = new Piece[] {k1, k2, q1, q2,
				r1, r2, r3, r4, n1, n2, n3, n4, b1, b2, b3, b4,
				p0, p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15};

			//Send setup back to the state
			State.addPiece(pieces);
		}
	}//end class Driver
}//end of namespace
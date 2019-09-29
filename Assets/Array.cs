using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Array : MonoBehaviour {
	
	private int max, min;
	void Start (){

		const int Row = 8;
		const int Col = 4;
		int[,] Arrs = new int[Row, Col] { 
			
			{2, 4, 6, -8}, {44, -22, 11, 12}, {-15, 10, -30, 32}, {-1, -2, 100, 150},
			{73, 90, -101, 66}, {69, 67, 666, 78}, {-87, -93, 91, 153}, {500, 401, 234, 456}};

		print("Normal: " + Arr(Arrs, Row, Col));
		print("Reverse: " + ArrRev(Arrs, Row, Col));
		MaxnMin(Arrs, Row, Col);
		print("Min: " + min );
		print("Max: " + max );

	}

	void Update ()
	{
	}
	private string Arr(int[,] arrz, int ROWS, int COLS){
		
		string vals = "[";
		for (int i = 0; i < ROWS; i++)
			for (int j = 0; j < COLS; j++)
			{
				vals += arrz[i, j];
				if (i == ROWS - 1 && j == COLS - 1)
					vals += "]";
				else
					vals += ", ";
			}

		return vals;
	}

	private string ArrRev(int[,] arrz, int ROWS, int COLS){
		
		string arrayValues = "[";
		for (int i = ROWS - 1; i >= 0; i--)
			for (int j = COLS - 1; j >= 0; j--)
			{
				arrayValues += arrz[i, j];
				if (i == 0 && j == 0)
					arrayValues += "]";
				else
					arrayValues += ", ";
			}

		return arrayValues;
	}

	private void MaxnMin(int[,] arrz, int ROWS, int COLS){
		
		max = min = arrz[0, 0];
		for(int i = 0; i < ROWS; i++)
		{
			for(int j = 0; j < COLS; j++)
			{
				if (min > arrz[i, j])
					min = arrz[i, j];
				if (max < arrz[i, j])
					max = arrz[i, j];
			}
		}


	}
}
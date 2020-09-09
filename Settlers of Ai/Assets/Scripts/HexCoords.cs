using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class HexCoords : MonoBehaviour
{
	public int X {
		get; private set; 
	}

	public int Z {
		get; private set; 
	}

	public HexCoords(int x, int z)
	{
		X = x;
		Z = z;
	}


	public static HexCoords FromOffsetCoordinates(int x, int z){
		return new HexCoords(x-z / 2, z);
	}

	public override string ToString()
	{
		return "(" + X.ToString() + ", " + Z.ToString() + ")";
	}

	public string ToStringOnSeparateLines()
	{
		return X.ToString() + "\n" + Z.ToString();
	}

}
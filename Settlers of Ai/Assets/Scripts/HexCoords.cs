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
	public int Y
	{
		get
		{
			return -X - Z;
		}
	}

	public HexCoords(int x, int z)
	{
		X = x;
		Z = z;
	}


	public static HexCoords FromOffsetCoordinates(int x, int z){
		return new HexCoords(x-z / 2, z);
	}

	public static HexCoords FromPosition(Vector3 position)
	{
		float x = position.x / (HexMetrics.innerRadius * 2f);
		float y = -x;
		float offset = position.z / (HexMetrics.outerRadius * 3f);
		x -= offset;
		y -= offset;

		int iX = Mathf.RoundToInt(x);
		int iY = Mathf.RoundToInt(y);
		int iZ = Mathf.RoundToInt(-x - y);

		if (iX + iY + iZ != 0)
		{
			float dX = Mathf.Abs(x - iX);
			float dY = Mathf.Abs(y - iY);
			float dZ = Mathf.Abs(-x - y - iZ);

			if (dX > dY && dX > dZ)
			{
				iX = -iY - iZ;
			}
			else if (dZ > dY)
			{
				iZ = -iX - iY;
			}
		}

		return new HexCoords(iX, iZ);
	}

	public override string ToString()
	{
		return "(" +
			X.ToString() + ", " + Y.ToString() + ", " + Z.ToString() + ")";
	}

	public string ToStringOnSeparateLines()
	{
		return X.ToString() + "\n" + Y.ToString() + "\n" + Z.ToString();
	}
}
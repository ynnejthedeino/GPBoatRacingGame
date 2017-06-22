using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridManager : MonoBehaviour {
public int sizeX, sizeY;
public GameObject gridSquare;
GameObject[,] gridSquares;
	// Use this for initialization
	void Start () {
		Generate();

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void Generate (/*feedme*/)
	{
		gridSquares=new GameObject[sizeX,sizeY];
		for (int x = 0; x < sizeX; x++)
		{
			for (int y = 0; y < sizeY; y++)
			{
				CreateSquare(x, y);
			}
		}
	}

    private void CreateSquare(int x, int y)
    {
        GameObject newSquare = Instantiate(gridSquare) as GameObject;
		gridSquares[x,y] = newSquare;
		newSquare.name = "Square " + x + ", " + y;
		newSquare.transform.parent = transform;
		newSquare.transform.localPosition = new Vector3(x - sizeX * 0.5f, y - sizeY * 0.5f, 0f);
    }
}

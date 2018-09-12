using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateBoard : MonoBehaviour {

    enum Piece {Invalid, Empty, Red, Green, Blue, Yellow, };

    private const int maxRow = 17;
    private const int maxColumn = 13;

    Piece[,] board = new Piece[maxRow, maxColumn];

    Piece[,] board = new Piece[maxColumn, maxRow]
    {
        Piece.Invalid, Piece.Invalid, Piece.Invalid, Piece.Invalid, Piece.Invalid, Piece.Invalid,
        Piece.Red,
        Piece.Invalid, Piece.Invalid, Piece.Invalid, Piece.Invalid, Piece.Invalid, Piece.Invalid
    },
    {
        Piece.Invalid, Piece.Invalid, Piece.Invalid, Piece.Invalid, Piece.Invalid, 
        Piece.Red, Piece.Red,
        Piece.Invalid, Piece.Invalid, Piece.Invalid, Piece.Invalid, Piece.Invalid, Piece.Invalid
    },
    {
        Piece.Invalid, Piece.Invalid, Piece.Invalid, Piece.Invalid, Piece.Invalid, 
        Piece.Red, Piece.Red,
        Piece.Invalid, Piece.Invalid, Piece.Invalid, Piece.Invalid, Piece.Invalid, Piece.Invalid
    },
    {
            Piece.Invalid, Piece.Invalid, Piece.Invalid, Piece.Invalid, Piece.Invalid, Piece.Invalid,
        Piece.Red,
        Piece.Invalid, Piece.Invalid, Piece.Invalid, Piece.Invalid, Piece.Invalid, Piece.Invalid
    },
    {
            Piece.Invalid, Piece.Invalid, Piece.Invalid, Piece.Invalid, Piece.Invalid, Piece.Invalid,
        Piece.Red,
        Piece.Invalid, Piece.Invalid, Piece.Invalid, Piece.Invalid, Piece.Invalid, Piece.Invalid
    },
    {
            Piece.Invalid, Piece.Invalid, Piece.Invalid, Piece.Invalid, Piece.Invalid, Piece.Invalid,
        Piece.Red,
        Piece.Invalid, Piece.Invalid, Piece.Invalid, Piece.Invalid, Piece.Invalid, Piece.Invalid
    },
    {
            Piece.Invalid, Piece.Invalid, Piece.Invalid, Piece.Invalid, Piece.Invalid, Piece.Invalid,
        Piece.Red,
        Piece.Invalid, Piece.Invalid, Piece.Invalid, Piece.Invalid, Piece.Invalid, Piece.Invalid
    },
    {
            Piece.Invalid, Piece.Invalid, Piece.Invalid, Piece.Invalid, Piece.Invalid, Piece.Invalid,
        Piece.Red,
        Piece.Invalid, Piece.Invalid, Piece.Invalid, Piece.Invalid, Piece.Invalid, Piece.Invalid
    },
    {
            Piece.Invalid, Piece.Invalid, Piece.Invalid, Piece.Invalid, Piece.Invalid, Piece.Invalid,
        Piece.Red,
        Piece.Invalid, Piece.Invalid, Piece.Invalid, Piece.Invalid, Piece.Invalid, Piece.Invalid
    },
    {
            Piece.Invalid, Piece.Invalid, Piece.Invalid, Piece.Invalid, Piece.Invalid, Piece.Invalid,
        Piece.Red,
        Piece.Invalid, Piece.Invalid, Piece.Invalid, Piece.Invalid, Piece.Invalid, Piece.Invalid
    },
    {
            Piece.Invalid, Piece.Invalid, Piece.Invalid, Piece.Invalid, Piece.Invalid, Piece.Invalid,
        Piece.Red,
        Piece.Invalid, Piece.Invalid, Piece.Invalid, Piece.Invalid, Piece.Invalid, Piece.Invalid
    },
    {
            Piece.Invalid, Piece.Invalid, Piece.Invalid, Piece.Invalid, Piece.Invalid, Piece.Invalid,
        Piece.Red,
        Piece.Invalid, Piece.Invalid, Piece.Invalid, Piece.Invalid, Piece.Invalid, Piece.Invalid
    },
    {
            Piece.Invalid, Piece.Invalid, Piece.Invalid, Piece.Invalid, Piece.Invalid, Piece.Invalid,
        Piece.Red,
        Piece.Invalid, Piece.Invalid, Piece.Invalid, Piece.Invalid, Piece.Invalid, Piece.Invalid
    }; 

    private float offsetX = 0.5F;
    private float offsetY = 1.0F;
    private float offsetUnevenRows = 0.5F;
    //[SerializeField]
    //private Vector2 xOffset = 1;

    //private int[,] plates = { 13, 17 };

    [SerializeField]
    GameObject piecePrefab;

	// Use this for initialization
	void Start ()
    {
        InstantiateLoop();
    }
	
    private void InstantiateLoop()
    {
        for (int x = 0; x < maxRow; x++)
        {
            for (int y = 0; y < maxColumn; y++)
            {
                //Instantiate(piecePrefab, new Vector2(y * offsetY, x * offsetX), transform.rotation);


                //GeneratePiece
                if (x % 2 == 0)
                {
                    //InstantiatePlate();
                    Instantiate(piecePrefab, new Vector2(y * offsetY, x * offsetX), Quaternion.Euler(90, 0, 0));
                }
                else
                {
                    Instantiate(piecePrefab, new Vector2(y * offsetY + offsetUnevenRows, x * offsetX), Quaternion.Euler(90, 0, 0));
                }
            }
        }
    }

    /*private void InstantiatePlate()
    {
        GameObject go = Instantiate(platePrefab);
        go.transform.SetParent(transform);
        //pieces[x, y];
    }*/
}

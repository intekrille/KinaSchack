using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pieces : MonoBehaviour
{

    // Jag har fått en del inspiration från en youtube-tutorial
    // https://www.youtube.com/watch?v=PPthLxykDr8 - Quill18Creates

    // Piece Colour
    public Piece colour;
    // Coordinates in the array
    public int x;
    public int y;
    
    private void OnMouseDown()
    {
        GetNeighbours();
    }

    private void Start()
    {
        GetNeighbours();
    }

    public void GetNeighbours()
    {
        // Player will always play as red team
        if (colour == Piece.Red)
        {
            // Right and left neighbours are easy to find
            GameObject leftNeighbour = GameObject.Find("Piece" + (x - 1) + ", " + y);
            GameObject rightNeighbour = GameObject.Find("Piece" + (x + 1) + ", " + y);
            // Upper and lower neighbours are harder to find because of offsetUnevenRows
            if (x % 2 == 0)
            {
                GameObject upperLeftNeighbour = GameObject.Find("Piece" + x + ", " + (y + 1));
                GameObject upperRightNeighbour = GameObject.Find("Piece" + (x - 1) + ", " + (y + 1));
                GameObject lowerLeftNeighbour = GameObject.Find("Piece" + x + ", " + (y - 1));
                GameObject lowerRightNeighbour = GameObject.Find("Piece" + (x - 1) + ", " + (y - 1));
            }
            else
            {
                GameObject upperLeftNeighbour = GameObject.Find("Piece" + (x + 1) + ", " + (y + 1));
                GameObject upperRightNeighbour = GameObject.Find("Piece" + x + ", " + (y + 1));
                GameObject lowerLeftNeighbour = GameObject.Find("Piece" + (x + 1) + ", " + (y - 1));
                GameObject lowerRightNeighbour = GameObject.Find("Piece" + x + ", " + (y - 1));
            }

            // List<Pieces> neighbours = new List<Pieces>();
            // neighbours.Add(leftNeighbour);

            // Create a list of all the neighbours.
            // Later we can add the possible jumps into the same list.
            //return ;
        }

    }

}

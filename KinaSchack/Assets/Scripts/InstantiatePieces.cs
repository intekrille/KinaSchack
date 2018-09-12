using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiatePieces : MonoBehaviour {

    [SerializeField]
    GameObject piece;
   //[SerializeField]
   //int numberOfPieces = 10;

    // Use this for initialization
    void Start()
    {
        SpawnPieces();
    }

    void SpawnPieces()
    {
        /*GameObject[] children = new GameObject[transform.childCount];

        for (int i = 0; i < children.length; i++)
        {

        }*/

        Instantiate(piece, transform.position, transform.rotation);
    }
}

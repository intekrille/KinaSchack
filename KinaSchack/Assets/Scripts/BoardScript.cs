using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardScript : MonoBehaviour {

    //Denna klass används inte.

    /*
    private Vector2 mouseOver;
    private Vector2 startDrag;
    private Vector2 endDrag;


    private Pieces selectPiece;

    public Pieces[,] pieces = new Pieces[10, 10];

    private void Update()
    {
        UpdateMouseOver();

        // If it's my turn
        {
            int x = (int)mouseOver.x;
            int y = (int)mouseOver.y;

            if (Input.GetMouseButton(0))
                SelectPiece(x, y);

            if (Input.GetMouseButtonUp(0))
                TryMove((int)startDrag.x, (int)startDrag.y, x, y);
        }
    }

    private void TryMove(int x1, int y1, int x2, int y2)
    {
        startDrag = new Vector2(x1, y1);
        endDrag = new Vector2(x2, y2);
        selectPiece = pieces[x1, y1];

        MovePiece(selectPiece, x2, y2);
    }

    private void MovePiece(Pieces p, int x, int y)
    {
        p.transform.position = (Vector3.right * x) + (Vector3.forward * y);
    }

    private void SelectPiece(int x, int y)
    {
        // Out of bounds
       //if (x < 0 || x >= pieces.Length || y >= pieces.Length)
       //    return;

        // Is there a piece here?
        Pieces p = pieces[x, y];
        if (p != null)
        {
            selectPiece = p;
            startDrag = mouseOver;
            Debug.Log(selectPiece.name);
        }
    }

    private void UpdateMouseOver()
    {
        if (!Camera.main)
        {
            Debug.Log("Can't find a camera");
            return;
        }

        // If it's my turn
        RaycastHit hit;
        if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit, 25.0f, LayerMask.GetMask("GameBoard")))
        {
            mouseOver.x = (int)hit.point.x;
            mouseOver.y = (int)(hit.point.z - boardOffset.z);
            //return;
        }
        else
        {
            mouseOver.x = -1;
            mouseOver.y = -1;
            //return;
        }
    }*/


}

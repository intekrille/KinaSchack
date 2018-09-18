using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

    private Vector2 mouseOver;

    private void Update()
    {
        RaycastHit hit;
        if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit, 25.0f, LayerMask.GetMask("Piece")))
        {
            mouseOver.x = (int)hit.point.x;
            mouseOver.y = (int)(hit.point.z);
            //SelectPiece(mouseOver.x, mouseOver.y);
        }
    }

    public static void SelectPiece(int x, int y)
    {
        //Pieces p = InstantiateBoard.board[x, y];
    }
}

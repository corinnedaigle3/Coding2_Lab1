using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChessBoard : MonoBehaviour
{
    void OnDrawGizmos()
    {
        //Vectors for Y
        Vector2 startingPosY = new Vector2(0, 0);
        Vector2 endingPosY = new Vector2(0, -8);
        Vector2 subtractY = new Vector2(1, 0);

        //Vectors for X
        Vector2 startingPosX = new Vector2(0, 0);
        Vector2 endingPosX = new Vector2(-8, 0);
        Vector2 subtractX = new Vector2(0, 1);

        //Loop for Vertical Lines
        for (int i = 0; i < 9; i++)
        {
            Gizmos.DrawLine(startingPosY, endingPosY);

            startingPosY -= subtractY;
            endingPosY -= subtractY;
        }

        //Loop for Horizontal Lines
        for (int j = 0; j <= 8; j++)
        {
            Gizmos.DrawLine(startingPosX, endingPosX);

            startingPosX -= subtractX;
            endingPosX -= subtractX;
        }
    }
}

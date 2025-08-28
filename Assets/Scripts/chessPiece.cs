using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chessPiece : MonoBehaviour
{
  public enum classType
  {
    None,
    Bishop,
    Knight,
    King,
    Queen,
    Rook,
    Pawn
  }

  public classType ClassType = new classType();

  // Start is called before the first frame update
  void Start()
  {

  }

  // Update is called once per frame
  void Update()
  {

  }

  //Function that draws gizmos when the object is selected
  void OnDrawGizmosSelected()
  {  
    //Switch statement used to switch between the selected class types
    switch (ClassType)
    {
      case classType.Bishop:
        //Vectors used to create the end points for the bishop
        Vector3 bishopPoint = transform.position + new Vector3(7, 7, 0);
        Vector3 bishopPoint2 = transform.position + new Vector3(-7, 7, 0);
        Vector3 bishopPoint3 = transform.position + new Vector3(7, -7, 0);
        Vector3 bishopPoint4 = transform.position + new Vector3(-7, -7, 0);

        //Gizmos that draw the line between both points
        Gizmos.DrawLine(bishopPoint, bishopPoint4);
        Gizmos.DrawLine(bishopPoint2, bishopPoint3);
        break;
      case classType.Knight:
      //Vectors used to create the end points for the knight
        Vector3 knightPoint = transform.position + new Vector3(-1, 2, 0);
        Vector3 knightPoint2 = transform.position + new Vector3(1, 2, 0);
        Vector3 knightPoint3 = transform.position + new Vector3(-1, -2, 0);
        Vector3 knightPoint4 = transform.position + new Vector3(1, -2, 0);
        Vector3 knightPoint5 = transform.position + new Vector3(-2, 1, 0);
        Vector3 knightPoint6 = transform.position + new Vector3(2, 1, 0);
        Vector3 knightPoint7 = transform.position + new Vector3(-2, -1, 0);
        Vector3 knightPoint8 = transform.position + new Vector3(2, -1, 0);

        //Gizmos that draw the line between both points
        Gizmos.DrawCube(knightPoint, Vector3.one);
        Gizmos.DrawCube(knightPoint2, Vector3.one);
        Gizmos.DrawCube(knightPoint3, Vector3.one);
        Gizmos.DrawCube(knightPoint4, Vector3.one);
        Gizmos.DrawCube(knightPoint5, Vector3.one);
        Gizmos.DrawCube(knightPoint6, Vector3.one);
        Gizmos.DrawCube(knightPoint7, Vector3.one);
        Gizmos.DrawCube(knightPoint8, Vector3.one);
        break;
      case classType.King:
      //Vectors used to create the end points for the king
        Vector3 kingPoint = transform.position + new Vector3(1, 1, 0);
        Vector3 kingPoint2 = transform.position + new Vector3(-1, 1, 0);
        Vector3 kingPoint3 = transform.position + new Vector3(1, -1, 0);
        Vector3 kingPoint4 = transform.position + new Vector3(-1, -1, 0);
        Vector3 kingPoint5 = transform.position + new Vector3(1,0,0);
        Vector3 kingPoint6 = transform.position + new Vector3(-1,0,0);
        Vector3 kingPoint7 = transform.position + new Vector3(0,1,0);
        Vector3 kingPoint8 = transform.position + new Vector3(0,-1,0);

        //Gizmos that draw the line between both points
        Gizmos.DrawLine(kingPoint, kingPoint4);
        Gizmos.DrawLine(kingPoint2, kingPoint3);
        Gizmos.DrawLine(kingPoint5, kingPoint6);
        Gizmos.DrawLine(kingPoint7, kingPoint8);
        break;
      case classType.Queen:
      //Vectors used to create the end points for the queen
        Vector3 queenPoint = transform.position + new Vector3(7, 7, 0);
        Vector3 queenPoint2 = transform.position + new Vector3(-7, 7, 0);
        Vector3 queenPoint3 = transform.position + new Vector3(7, -7, 0);
        Vector3 queenPoint4 = transform.position + new Vector3(-7, -7, 0);
        Vector3 queenPoint5 = transform.position + new Vector3(7,0,0);
        Vector3 queenPoint6 = transform.position + new Vector3(-7,0,0);
        Vector3 queenPoint7 = transform.position + new Vector3(0,7,0);
        Vector3 queenPoint8 = transform.position + new Vector3(0,-7,0);

        //Gizmos that draw the line between both points
        Gizmos.DrawLine(queenPoint, queenPoint4);
        Gizmos.DrawLine(queenPoint2, queenPoint3);
        Gizmos.DrawLine(queenPoint5, queenPoint6);
        Gizmos.DrawLine(queenPoint7, queenPoint8);
        break;
      case classType.Rook:
      //Vectors used to create the end points for the rook
        Vector3 rookPoint = transform.position + new Vector3(7,0,0);
        Vector3 rookPoint2 = transform.position + new Vector3(-7,0,0);
        Vector3 rookPoint3 = transform.position + new Vector3(0,7,0);
        Vector3 rookPoint4 = transform.position + new Vector3(0,-7,0);

        //Gizmos that draw the line between both points
        Gizmos.DrawLine(rookPoint, rookPoint2);
        Gizmos.DrawLine(rookPoint3, rookPoint4);
        break;
      case classType.Pawn:
      //Vectors used to create the end points for the pawn
        Vector3 pawnPoint = transform.position + new Vector3(1, 1, 0);
        Vector3 pawnPoint2 = transform.position + new Vector3(-1, 1, 0);
        Vector3 pawnPoint3 = transform.position + new Vector3(0,1,0);

        //Gizmos that draw the line between both points
        Gizmos.DrawLine(transform.position, pawnPoint);
        Gizmos.DrawLine(transform.position, pawnPoint2);
        Gizmos.DrawLine(transform.position, pawnPoint3);
        break;
    }
  }
}

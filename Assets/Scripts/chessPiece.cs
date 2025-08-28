using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chessPiece : MonoBehaviour
{
  public enum classType
  {
    None,
    Bishop,
    Horse,
    King,
    Queen,
    Rook,
    Pawn
  }

/*  private float Line = 8f;
  private float kingLine = 1f;
  private float pawnLine = 2f;*/

/*  public GameObject bishop;
  public GameObject horse;
  public GameObject king;
  public GameObject queen;
  public GameObject rook;
  public GameObject pawn;

  private GameObject selectedPiece;*/

  //[SerializedField] classType ClassType = new classType();
  public classType ClassType = new classType();

  // Start is called before the first frame update
  void Start()
  {
   /* switch (ClassType)
    {
      case classType.Bishop:
        //code
        break;
      case classType.Horse:
        //code
        break;
      case classType.King:
        //code
        break;
      case classType.Queen:
        //code
        break;
      case classType.Rook:
        Gizmos.DrawLine(transform.position, Vector3.forward);
        Gizmos.DrawLine(transform.position, -Vector3.forward);
        //code
        break;
      case classType.Pawn:
        //code
        break;
        
    }*/
  }

    // Update is called once per frame
    void Update()
    {

    }
   /* void UpdatePiece()
    {
      DestroyImmediate(selectedPiece);
    }*/
  void OnDrawGizmosSelected()
  {  
    switch (ClassType)
    {
      case classType.Bishop:
       // selectedPiece = Instantiate(bishopPrefab, transform);
       Vector3 bishopPoint = transform.position + Vector3.one * 8;
       Vector3 bishopPoint2 = transform.position + -Vector3.one * 8;
        Gizmos.DrawLine(transform.position, bishopPoint);
        Gizmos.DrawLine(transform.position, -bishopPoint);

        Gizmos.DrawLine(transform.position, bishopPoint2);
       // Gizmos.DrawLine(transform.position, -bishopPoint2);
        //Gizmo code
        break;
      case classType.Horse:
     // selectedPiece = Instantiate(horsePrefab, transform);
        //Gizmo code
        break;
      case classType.King:
     // selectedPiece = Instantiate(kingPrefab, transform);
        //Gizmo code
        break;
      case classType.Queen:
     // GameObject newQueen = Instantiate(queenPrefab, promotionPosition, Quaternion.identity);
     // newQueen.GetComponent<ChessPiece>().currentPieceType = PieceType.Queen;
     // selectedPiece = Instantiate(queenPrefab, transform);
        //Gizmo code
        break;
      case classType.Rook:
     // selectedPiece = Instantiate(rookPrefab, transform);
        //Gizmo code
        Vector3 point = transform.position + transform.forward * 8;
       // Vector3 point2 = transform.position - transform.forward * 16;
        Gizmos.DrawLine(transform.position, point);
       // Gizmos.DrawLine(transform.position, point);
        
        break;
      case classType.Pawn:
     // selectedPiece = Instantiate(pawnPrefab, transform);
        //Gizmo code
        break;
    }
  }

/*  void onValidate()
  {
    DestroyImmediate(selectedPiece);
  }*/
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chessPiece : MonoBehaviour
{
  public enum classType
  {
    Bishop,
    Horse,
    King,
    Queen,
    Rook,
    Pawn
  }

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
  void OnDrawGizmosSelected()
  {  
    switch (ClassType)
    {
      case classType.Bishop:
        Gizmos.DrawLine(transform.position, Vector3.one);
        Gizmos.DrawLine(transform.position, -Vector3.one);
        //Gizmo code
        break;
      case classType.Horse:
        //Gizmo code
        break;
      case classType.King:
        //Gizmo code
        break;
      case classType.Queen:
        //Gizmo code
        break;
      case classType.Rook:
        //Gizmo code
        Gizmos.DrawLine(transform.position, Vector3.forward);
        Gizmos.DrawLine(transform.position, -Vector3.forward);
        break;
      case classType.Pawn:
        //Gizmo code
        break;
    }
  }
}

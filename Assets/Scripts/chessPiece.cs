using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chessPiece : MonoBehaviour
{
  //  public GameObject bishop;
    //  public List<GameObject> chessType;
    // Start is called before the first frame update
    void Start()
    {
        // chessType = new List<GameObject>();

        /* chessType.Add("Bishop");
         chessType.Add("Horse");
         chessType.Add("King");
         chessType.Add("Queen");
         chessType.Add("Rook");
         chessType.Add("Unknown");*/

    }

    // Update is called once per frame
    void Update()
    {

    }

    /*  void OnDrawGizmos()
      {
          //OnDrawGizmosSelected.matrix = transform.localToWorldMatrix;
         // Gizmos.DrawCube(Vector3.zero, Vector3.one);
      }*/
    void OnDrawGizmosSelected()
    {
        //Bishop
        // Gizmos.DrawLine(transform.position, Vector3.one);
        // Gizmos.DrawLine(transform.position, -Vector3.one);

        //Rook
        Gizmos.DrawLine(transform.position, Vector3.forward);
        Gizmos.DrawLine(transform.position, -Vector3.forward);
    }
}

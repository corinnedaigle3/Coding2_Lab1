using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drawboard : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnDrawGizmos()
    {       
        Vector2 startingPosY = new Vector2(0, 0);
        Vector2 endingPosY = new Vector2(0, -8);
        Vector2 subtractY = new Vector2(1, 0);

        Vector2 startingPosX = new Vector2(0, 0);
        Vector2 endingPosX = new Vector2(-8, 0);
        Vector2 subtractX = new Vector2(0, 1);

        for (int i = 0; i < 9; i++) 
        {
            Gizmos.DrawLine(startingPosY, endingPosY);

            startingPosY -= subtractY;
            endingPosY -= subtractY;
        }
            
        for (int j = 0; j <= 8; j++) 
        {
            Gizmos.DrawLine(startingPosX, endingPosX);

            startingPosX -= subtractX;
            endingPosX -= subtractX;
        }
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chess : MonoBehaviour
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
        Gizmos.color = Color.yellow;
         int i = 0;
         while(i<9)
         {
            Gizmos.DrawLine(new Vector3(i, 0,0),new Vector3(i, 8,0));
            Gizmos.DrawLine(new Vector3(0, i,0),new Vector3(8,i,0));
            i++;
         }
    }
}

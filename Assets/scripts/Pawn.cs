using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pawn : MonoBehaviour
{
    
    void OnDrawGizmosSelected() {
        Gizmos.color = Color.blue;

        Gizmos.DrawLine(transform.position + new Vector3(-0.03f,0,0), new Vector2(transform.position.x -0.03f,transform.position.y + 1));
        Gizmos.DrawLine(transform.position + new Vector3(0.03f,0,0), new Vector2(transform.position.x + 0.03f,transform.position.y + 2));

    }
}

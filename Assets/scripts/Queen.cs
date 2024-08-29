using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Queen : MonoBehaviour
{
    void OnDrawGizmosSelected() {
        Gizmos.color = Color.blue;

        Gizmos.DrawLine(transform.position, new Vector2(0,1));
        Gizmos.DrawLine(transform.position, new Vector2(0,4));
        Gizmos.DrawLine(transform.position, new Vector2(3,8));
        Gizmos.DrawLine(transform.position, new Vector2(8,4));
        Gizmos.DrawLine(transform.position, new Vector2(8,1));
    }
}


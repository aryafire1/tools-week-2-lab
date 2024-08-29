using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class King : MonoBehaviour
{
    //hooray for hardcoding
    void OnDrawGizmosSelected() {
        Gizmos.color = Color.blue;

        Gizmos.DrawLine(transform.position, new Vector2(3,1));
        Gizmos.DrawLine(transform.position, new Vector2(3,2));
        Gizmos.DrawLine(transform.position, new Vector2(4,2));
        Gizmos.DrawLine(transform.position, new Vector2(6,2));
        Gizmos.DrawLine(transform.position, new Vector2(6,1));
    }
}

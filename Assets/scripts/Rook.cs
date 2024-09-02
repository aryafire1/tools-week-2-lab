using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rook : MonoBehaviour
{
    void OnDrawGizmosSelected() {
        Gizmos.color = Color.blue;

        Gizmos.DrawLine(transform.position, new Vector2(transform.position.x + 1,transform.position.y));
        Gizmos.DrawLine(transform.position, new Vector2(transform.position.x - 1,transform.position.y));
        Gizmos.DrawLine(transform.position, new Vector2(transform.position.x,transform.position.y + 1));
        Gizmos.DrawLine(transform.position, new Vector2(transform.position.x,transform.position.y - 1));
    }
}

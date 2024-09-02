using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Queen : MonoBehaviour
{
    void OnDrawGizmosSelected() {
        Gizmos.color = Color.blue;

        Gizmos.DrawLine(transform.position, new Vector2(transform.position.x - 2,transform.position.y));
        Gizmos.DrawLine(transform.position, new Vector2(transform.position.x,transform.position.y + 2));
        Gizmos.DrawLine(transform.position, new Vector2(transform.position.x + 2, transform.position.y));
        Gizmos.DrawLine(transform.position, new Vector2(transform.position.x,transform.position.y - 2));
        Gizmos.DrawLine(transform.position, new Vector2(transform.position.x-2,transform.position.y - 2));
        Gizmos.DrawLine(transform.position, new Vector2(transform.position.x + 2,transform.position.y + 2));
        Gizmos.DrawLine(transform.position, new Vector2(transform.position.x-2,transform.position.y + 2));
        Gizmos.DrawLine(transform.position, new Vector2(transform.position.x + 2,transform.position.y - 2));
    }
}


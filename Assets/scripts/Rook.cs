using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rook : MonoBehaviour
{
    void OnDrawGizmosSelected() {
        Gizmos.color = Color.blue;

        Gizmos.DrawLine(transform.position, new Vector2(0,1));
        Gizmos.DrawLine(transform.position, new Vector2(8,8));
    }
}

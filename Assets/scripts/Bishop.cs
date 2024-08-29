using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bishop : MonoBehaviour
{
    void OnDrawGizmosSelected() {
        Gizmos.color = Color.blue;

        Gizmos.DrawLine(transform.position, new Vector2(0,6));
        Gizmos.DrawLine(transform.position, new Vector2(8,3));
    }
}

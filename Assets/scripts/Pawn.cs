using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pawn : MonoBehaviour
{
    void OnDrawGizmosSelected() {
        Gizmos.color = Color.blue;

        Gizmos.DrawLine(transform.position, new Vector2(8,3));

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;


public class Bishop : MonoBehaviour
{
    void OnDrawGizmosSelected() {
        Gizmos.color = Color.blue;
        Gizmos.DrawLine(transform.position, new Vector2(transform.position.x-1,transform.position.y - 1));
        Gizmos.DrawLine(transform.position, new Vector2(transform.position.x + 1,transform.position.y + 1));
        Gizmos.DrawLine(transform.position, new Vector2(transform.position.x-1,transform.position.y + 1));
        Gizmos.DrawLine(transform.position, new Vector2(transform.position.x + 1,transform.position.y - 1));
    }
}

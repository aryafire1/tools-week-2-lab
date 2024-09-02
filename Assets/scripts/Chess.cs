using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEditor.VersionControl;


public class Chess : MonoBehaviour
{
    public GameObject[] objects;
    public void Update()
    {
        
    }
    void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;
         int i = 0;
         //Starting from point (0,0,0), draw lines across 9 points 
         while(i<9)
         {
            Gizmos.DrawLine(new Vector3(i, 0,0),new Vector3(i, 8,0));
            Gizmos.DrawLine(new Vector3(0, i,0),new Vector3(8,i,0));
            i++;
         }
    }

    [CustomEditor(typeof(GameObject))]
    public class CustomInspector : Editor
    {
        private GameObject[] objects;

        public void OnEnable()
        {
            // Note: If you use FindGameObjectsWithTag in a Prefab Stage that you opened from a Scene,
            // it includes GameObjects from that Scene. Instead use:
            // var renderers = StageUtility.GetCurrentStage().FindComponentsOfType<Renderer>();
            // to explicitly specify where to get the GameObjects from.
            objects = GameObject.FindGameObjectsWithTag("Piece");
            Repaint();  // populate the objects array with game objects
        }

        public void OnSceneGUI()
        {
            // draw the outline with an alpha of 0.5
            if (Event.current.type == EventType.Repaint)
                Handles.DrawOutline(objects, Color.green, Color.blue, 0.1f);
        }
    }
}

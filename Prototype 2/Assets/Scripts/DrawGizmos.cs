using UnityEngine;

public class DrawGizmos : MonoBehaviour
{
    void OnDrawGizmos() {
        Gizmos.color = Color.black;
        Gizmos.DrawCube(transform.position, Vector3.one);
    }
}

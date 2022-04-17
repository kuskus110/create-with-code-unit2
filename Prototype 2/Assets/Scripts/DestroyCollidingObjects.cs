using UnityEngine;

public class DestroyCollidingObjects : MonoBehaviour
{
    #region Variables
    #endregion

    void OnTriggerEnter(Collider collider) {
        Destroy(collider.gameObject);
    }
}

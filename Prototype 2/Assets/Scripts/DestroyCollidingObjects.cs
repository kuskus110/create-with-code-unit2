using UnityEngine;
using System.Collections.Generic;
using System.Linq;

public class DestroyCollidingObjects : MonoBehaviour
{
    #region Variables
    [Tooltip("Destroy obejcts only with these gametags. Optional - if empty, destroys every object")] 
    public List<string> gameTagWhitelist;
    [Tooltip("Destroy also this object after a collision")]
    public bool destroySelf = false;
    #endregion

    void OnTriggerEnter(Collider other) {
        bool whitelistNotEmpty = gameTagWhitelist.Any();
        if (whitelistNotEmpty && gameTagWhitelist.Contains(other.tag) || !whitelistNotEmpty) {
            Destroy(other.gameObject);
        }
        if (destroySelf) {
            Destroy(gameObject);
        }
    }
}

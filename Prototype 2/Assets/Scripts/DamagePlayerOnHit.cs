using UnityEngine;

public class DamagePlayerOnHit : MonoBehaviour
{
    #region Variables
    #endregion

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) {
            other.GetComponent<PlayerLives>().HitPlayer();
        }
    }

}

using UnityEngine;

public class ThrowFood : MonoBehaviour
{
    #region Variables
    public GameObject foodProjectile;
    #endregion


    void Update()
    {
        if (Input.GetButtonDown("Fire")) {
            Instantiate(foodProjectile, transform.position, foodProjectile.transform.rotation);
        }
    }
}

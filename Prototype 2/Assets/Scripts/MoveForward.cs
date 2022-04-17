using UnityEngine;

public class MoveForward : MonoBehaviour
{
    #region Variables
    public float speed = 40f;
    #endregion

    void FixedUpdate()
    {
        transform.Translate(Vector3.forward * (speed * Time.fixedDeltaTime));
    }
}
